Public Class frmExpenses
    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTotalWOs_Click(sender As Object, e As EventArgs) Handles btnTotalWOs.Click
        ' Calculate the total of the work orders from the charges table
        ' and display a print preview of details and total
        ' code to collect work orders and calculate total goes here

        Dim WOtotal As Decimal = 0
        Dim WOcount As Integer = 0
        Dim WO As String = ""
        Dim WOlist As String = ""
        Dim WOcharge As Decimal = 0
        Dim WOtotalcharge As Decimal = 0
        Dim theStartDate As String = dtpStart.Value.ToShortDateString
        Dim theEndDate As String = dtpEnd.Value.ToShortDateString
        ' If theStartDate > theEndDate Then
        'MessageBox.Show("The start date must be before the end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Exit Sub
        'End If
        'use ConnectionString Globals.vb
        Dim conn As New OleDb.OleDbConnection(connectionString)
        Dim cmdDistinctProperty As New OleDb.OleDbCommand
        Dim cmdProperty As New OleDb.OleDbCommand
        Dim cmdCharges As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
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
            Dim ChargeDetails As String = ""
            dr = cmdDistinctProperty.ExecuteReader()

            ' For each PropertyID in the charges table, get the PropertyDetails
            While dr.Read()
                Dim PropertyID As Integer = dr("PropertyID")

                cmdProperty.CommandText = "SELECT StreetNumber, StreetName, AptSuiteNumber, City, State, Zip FROM Properties WHERE ID = @PropertyID"
                cmdProperty.Parameters.Clear()
                cmdProperty.Parameters.AddWithValue("@PropertyID", PropertyID)
                Dim drProperty As OleDb.OleDbDataReader = cmdProperty.ExecuteReader()
                If drProperty.Read() Then
                    ChargeDetails &= drProperty("StreetNumber") & " " & drProperty("StreetName") & " " & drProperty("AptSuiteNumber") & " " & drProperty("City") & " " & drProperty("State") & " " & drProperty("Zip") & vbCrLf

                    ' Get all charges for this property by using the PropertyID, StartDate, and EndDate
                    cmdCharges.CommandText = "SELECT DateBilled, Total FROM Charges WHERE PropertyID = @PropertyID AND DateBilled >= @StartDate AND DateBilled <= @EndDate"
                    cmdCharges.Parameters.Clear()
                    cmdCharges.Parameters.AddWithValue("@PropertyID", PropertyID)
                    cmdCharges.Parameters.AddWithValue("@StartDate", theStartDate)
                    cmdCharges.Parameters.AddWithValue("@EndDate", theEndDate)
                    Dim drCharges As OleDb.OleDbDataReader = cmdCharges.ExecuteReader()
                    While drCharges.Read()
                        ChargeDetails &= "Date: " & drCharges("DateBilled") & " Total: " & drCharges("Total") & vbCrLf
                    End While
                    drCharges.Close()
                End If
                drProperty.Close()
            End While
            dr.Close()
            MsgBox(ChargeDetails)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

End Class