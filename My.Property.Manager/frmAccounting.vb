Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Threading.Tasks

Public Class frmAccounting
    Private payments As DataTable
    Private charges As DataTable
    Private properties As DataTable
    Private currentPropertyIndex As Integer = 0
    Private totalPaymentsAllProperties As Decimal = 0
    Private totalChargesAllProperties As Decimal = 0

    ' Constants for magic numbers
    Private Const MarginLeft As Single = 100
    Private Const MarginTop As Single = 50
    Private Const LineSpacing As Single = 30
    Private Const PropertyInfoStartY As Single = 200
    Private Const SummaryStartY As Single = 200

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        VerifyExit(sender, e, btnExit)
    End Sub

    Private Sub frmAccounting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpStart.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpEnd.Value = New DateTime(DateTime.Now.Year, 12, 31)
        dtpStart.Format = DateTimePickerFormat.Custom
        dtpStart.CustomFormat = "MM/dd/yyyy"
        dtpEnd.Format = DateTimePickerFormat.Custom
        dtpEnd.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Async Sub btnFullReport_Click(sender As Object, e As EventArgs) Handles btnFullReport.Click
        ' Validate date range
        If dtpStart.Value > dtpEnd.Value Then
            MessageBox.Show("Start date must be earlier than end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Collect payment, charges, and property history
        Dim startDate As Date = dtpStart.Value
        Dim endDate As Date = dtpEnd.Value

        payments = New DataTable()
        charges = New DataTable()
        properties = New DataTable()

        Try
            Using connection As New OleDbConnection(connectionString)
                Await connection.OpenAsync()

                ' Collect payment history
                Using cmd As New OleDbCommand("SELECT * FROM Payments WHERE PaymentDate >= @StartDate AND PaymentDate <= @EndDate", connection)
                    cmd.Parameters.AddWithValue("@StartDate", startDate)
                    cmd.Parameters.AddWithValue("@EndDate", endDate)
                    Using da As New OleDbDataAdapter(cmd)
                        da.Fill(payments)
                    End Using
                End Using

                ' Collect charges history
                Using cmd As New OleDbCommand("SELECT * FROM Charges WHERE DateBilled >= @StartDate AND DateBilled <= @EndDate", connection)
                    cmd.Parameters.AddWithValue("@StartDate", startDate)
                    cmd.Parameters.AddWithValue("@EndDate", endDate)
                    Using da As New OleDbDataAdapter(cmd)
                        da.Fill(charges)
                    End Using
                End Using

                ' Collect property information
                Using cmd As New OleDbCommand("SELECT * FROM Properties", connection)
                    Using da As New OleDbDataAdapter(cmd)
                        da.Fill(properties)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Log the error (e.g., to a file or database) for debugging
            Console.WriteLine("Error: " & ex.Message)
            Return
        End Try

        ' Reset the current property index and totals
        currentPropertyIndex = 0
        totalPaymentsAllProperties = 0
        totalChargesAllProperties = 0

        ' Create a PrintDocument object and handle its PrintPage event
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintReport

        ' Create a PrintPreviewDialog object and set its Document property
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument

        ' Show the print preview dialog
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintReport(sender As Object, e As PrintPageEventArgs)
        ' Get company details
        GetCompanyDetails()

        ' Print company details
        e.Graphics.DrawString(CompanyDetails, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, MarginTop))

        ' Group payments and charges by PropertyID
        Dim groupedPayments = If(payments IsNot Nothing, payments.AsEnumerable().GroupBy(Function(row) row.Field(Of Integer)("Property")), Nothing)
        Dim groupedCharges = If(charges IsNot Nothing, charges.AsEnumerable().GroupBy(Function(row) row.Field(Of Integer)("PropertyID")), Nothing)

        Dim yPos As Single = PropertyInfoStartY

        ' Print report for the current property
        If currentPropertyIndex < properties.Rows.Count Then
            Dim propertyRow = properties.Rows(currentPropertyIndex)
            Dim propertyID As Integer = propertyRow.Field(Of Integer)("ID")
            Dim streetNumber As String = propertyRow.Field(Of String)("StreetNumber").ToUpper()
            Dim streetName As String = propertyRow.Field(Of String)("StreetName").ToUpper()
            Dim aptSuiteNumber As String = propertyRow.Field(Of String)("AptSuiteNumber").ToUpper()
            Dim city As String = propertyRow.Field(Of String)("City").ToUpper()
            Dim state As String = propertyRow.Field(Of String)("State").ToUpper()
            Dim zip As String = propertyRow.Field(Of String)("Zip").ToUpper()

            Dim propertyPayments = groupedPayments?.FirstOrDefault(Function(g) g.Key = propertyID)?.ToList()
            Dim propertyCharges = groupedCharges?.FirstOrDefault(Function(g) g.Key = propertyID)?.ToList()

            ' Print property details
            e.Graphics.DrawString($"PROPERTY ID: {propertyID}, {streetNumber} {streetName}, {aptSuiteNumber}, {city}, {state} {zip}", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
            yPos += LineSpacing

            ' Print payments
            Dim totalPayments As Decimal = 0
            If propertyPayments IsNot Nothing AndAlso propertyPayments.Any() Then
                e.Graphics.DrawString("PAYMENTS:", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
                yPos += LineSpacing
                For Each payment In propertyPayments
                    e.Graphics.DrawString($"DATE: {payment.Field(Of Date)("PaymentDate")}, AMOUNT: {payment.Field(Of Decimal)("Amount"):C}, TYPE: {payment.Field(Of String)("PaymentType")}, NOTES: {payment.Field(Of String)("Notes")}", New Font("Arial", 12), Brushes.Black, New PointF(MarginLeft, yPos))
                    totalPayments += payment.Field(Of Decimal)("Amount")
                    yPos += LineSpacing
                Next
                e.Graphics.DrawString($"TOTAL PAYMENTS: {totalPayments:C}", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
                yPos += LineSpacing
            Else
                e.Graphics.DrawString("NO PAYMENTS AVAILABLE.", New Font("Arial", 12, FontStyle.Italic), Brushes.Black, New PointF(MarginLeft, yPos))
                yPos += LineSpacing
            End If

            ' Print charges
            Dim totalCharges As Decimal = 0
            If propertyCharges IsNot Nothing AndAlso propertyCharges.Any() Then
                e.Graphics.DrawString("EXPENSES:", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
                yPos += LineSpacing
                For Each charge In propertyCharges
                    e.Graphics.DrawString($"DATE: {charge.Field(Of Date)("DateBilled")}, TOTAL: {charge.Field(Of Decimal)("Total"):C}, NOTES: {charge.Field(Of String)("ChargeNotes")}", New Font("Arial", 12), Brushes.Black, New PointF(MarginLeft, yPos))
                    totalCharges += charge.Field(Of Decimal)("Total")
                    yPos += LineSpacing
                Next
                e.Graphics.DrawString($"TOTAL EXPENSES: {totalCharges:C}", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
                yPos += LineSpacing
            Else
                e.Graphics.DrawString("NO EXPENSES AVAILABLE.", New Font("Arial", 12, FontStyle.Italic), Brushes.Black, New PointF(MarginLeft, yPos))
                yPos += LineSpacing
            End If

            ' Calculate and print net income
            Dim netIncome As Decimal = totalPayments - totalCharges
            e.Graphics.DrawString($"NET INCOME FOR THIS PROPERTY: {netIncome:C}", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
            yPos += LineSpacing

            ' Update totals for all properties
            totalPaymentsAllProperties += totalPayments
            totalChargesAllProperties += totalCharges

            ' Move to the next property for the next page
            currentPropertyIndex += 1

            ' Indicate that there are more pages to print
            e.HasMorePages = True
        ElseIf currentPropertyIndex = properties.Rows.Count Then
            ' Print the final summary page
            e.Graphics.DrawString("FINAL SUMMARY", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, SummaryStartY))
            yPos = SummaryStartY + LineSpacing
            e.Graphics.DrawString($"TOTAL PAYMENTS: {totalPaymentsAllProperties:C}", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
            yPos += LineSpacing
            e.Graphics.DrawString($"TOTAL EXPENSES: {totalChargesAllProperties:C}", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
            yPos += LineSpacing
            Dim totalNetIncome As Decimal = totalPaymentsAllProperties - totalChargesAllProperties
            e.Graphics.DrawString($"TOTAL NET INCOME: {totalNetIncome:C}", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(MarginLeft, yPos))
            yPos += LineSpacing

            ' Indicate that there are no more pages to print
            e.HasMorePages = False
        End If
    End Sub
End Class
