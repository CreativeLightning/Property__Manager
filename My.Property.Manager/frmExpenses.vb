Public Class frmExpenses

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpStart.Value = New Date(Today.Year, 1, 1) ' Set the start date to January 1st of the current year
        dtpEnd.Value = New Date(Today.Year, 12, 31) ' Set the end date to December 31st of the current year
    End Sub


    Private Sub btnTotalWOs_Click(sender As Object, e As EventArgs) Handles btnTotalWOs.Click
        ' Calculate the total of the work orders from the charges table
        ' and display a print preview of details and total
        ' code to collect work orders and calculate total goes here

        Dim WOtotal As Decimal = 0
        Dim WOcount As Integer = 0
        Dim WO As String = ""
        Dim WOlist As String = ""
        Dim WOcharges As Decimal = 0
        WOtotalcharge = 0
        ChargeDetails = ""
        Dim theStartDate As Date = dtpStart.Value ' Start date is the date selected
        Dim theEndDate As Date = dtpEnd.Value ' End date is the date selected
        If theStartDate >= theEndDate Then
            MessageBox.Show("The start date must be before the end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim conn As New OleDb.OleDbConnection(connectionString)
        Dim cmdDistinctProperty As New OleDb.OleDbCommand
        Dim cmdProperty As New OleDb.OleDbCommand
        Dim cmdCharges As New OleDb.OleDbCommand
        Try
            ' Open the connection
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Set up the command object to use the connection object
            cmdDistinctProperty.Connection = conn
            cmdProperty.Connection = conn
            cmdCharges.Connection = conn

            ' Set up the command text (SQL)
            cmdDistinctProperty.CommandText = "SELECT DISTINCT PropertyID from Charges"
            GetCompanyDetails()
            ' For each PropertyID in the charges table, get the PropertyDetails
            Dim dtProperties As New DataTable()
            Dim dtCharges As New DataTable()

            ' Fill dtProperties with distinct PropertyIDs
            Using daProperties As New OleDb.OleDbDataAdapter("SELECT DISTINCT PropertyID FROM Charges", conn)
                daProperties.Fill(dtProperties)
            End Using
            'if there are no properties, msgbox and exit
            If dtProperties.Rows.Count = 0 Then
                MessageBox.Show("There are no properties with charges in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            For Each row As DataRow In dtProperties.Rows
                Dim PropertyID As Integer = row("PropertyID")

                ' Fill dtPropertyDetails with property details
                Using daPropertyDetails As New OleDb.OleDbDataAdapter("SELECT StreetNumber, StreetName, AptSuiteNumber, City, State, Zip FROM Properties WHERE ID = @PropertyID", conn)
                    daPropertyDetails.SelectCommand.Parameters.AddWithValue("@PropertyID", PropertyID)
                    Dim dtPropertyDetails As New DataTable()
                    daPropertyDetails.Fill(dtPropertyDetails)
                    'if there are no property details, msgbox and exit
                    If dtPropertyDetails.Rows.Count = 0 Then
                        MessageBox.Show("There are no property details for PropertyID " & PropertyID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If dtPropertyDetails.Rows.Count > 0 Then
                        Dim propertyRow As DataRow = dtPropertyDetails.Rows(0)
                        ChargeDetails &= propertyRow("StreetNumber") & " " & propertyRow("StreetName") & " " & propertyRow("AptSuiteNumber") & " " & propertyRow("City") & " " & propertyRow("State") & " " & propertyRow("Zip") & vbCrLf
                        WOcharges = 0
                        ' Fill dtCharges with charges for this property
                        Using daCharges As New OleDb.OleDbDataAdapter("SELECT DateBilled, Total FROM Charges WHERE PropertyID = @PropertyID AND DateBilled >= @StartDate AND DateBilled <= @EndDate", conn)
                            daCharges.SelectCommand.Parameters.AddWithValue("@PropertyID", PropertyID)
                            daCharges.SelectCommand.Parameters.AddWithValue("@StartDate", theStartDate)
                            daCharges.SelectCommand.Parameters.AddWithValue("@EndDate", theEndDate)
                            dtCharges.Clear()
                            daCharges.Fill(dtCharges)
                            'if there are no charges, msgbox and exit
                            If dtCharges.Rows.Count = 0 Then
                                ChargeDetails &= "No charges for this property" & vbCrLf
                            End If
                            For Each chargeRow As DataRow In dtCharges.Rows
                                ChargeDetails &= "Date: " & chargeRow("DateBilled") & " Total: $" & chargeRow("Total") & vbCrLf
                                WOtotalcharge += chargeRow("Total") 'Total charges for all work orders
                                WOcharges += chargeRow("Total") 'Total charges for this work order
                            Next
                            ChargeDetails &= "Total of Work Orders for this property: $" & WOcharges & vbCrLf
                        End Using
                        ChargeDetails &= vbCrLf
                    End If
                End Using
            Next

            ' Create a PrintDocument object and handle its PrintPage event
            Dim printDocument As New Printing.PrintDocument()
            AddHandler printDocument.PrintPage, AddressOf PrintWOExpenses

            ' Create a PrintPreviewDialog object and set its Document property
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDocument

            ' Show the print preview dialog
            printPreviewDialog.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub PrintWOExpenses(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)

        ' Print CompanyDetails in Bold 14 point font
        GetCompanyDetails()
        Dim companyFont As New Font("Arial", 14, FontStyle.Bold)
        e.Graphics.DrawString(CompanyDetails, companyFont, Brushes.Black, 100, 100)
        ' Print ChargeDetails and WOtotalcharge in 12 point font using & vbCrLf to separate lines
        Dim chargeFont As New Font("Arial", 12)
        e.Graphics.DrawString(ChargeDetails & vbCrLf & "Work Order Expense for all properties from:" & dtpStart.Value & " to:" & dtpEnd.Value & " $" & WOtotalcharge, chargeFont, Brushes.Black, 100, 240)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        VerifyExit(sender, e, btnExit)
    End Sub
End Class