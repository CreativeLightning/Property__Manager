'need to import oledb to connect to the database
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class frmPaymentHistory
    'need to declare the connection and command
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim tenantIDs As New Dictionary(Of String, Integer)

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'confirm the user wants to close the application
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtSearchByTenant_TextChanged(sender As Object, e As EventArgs) Handles txtSearchByTenant.TextChanged
        'search the database for the tenant name entered from the tenants table either fname or lname = txtSearchByTenant
        'connection string is defined in the module as ConnectionString
        'with results we fill cboTenants with fname and lname and ID from tenants table
        'code is as follows
        con.ConnectionString = connectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Tenants WHERE fname LIKE '%" & txtSearchByTenant.Text & "%' OR lname LIKE '%" & txtSearchByTenant.Text & "%'"
        'run the query
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        'if there are no results, clear the combobox and display a message No Tenants Found hide the groupbox
        If dt.Rows.Count = 0 Then
            cboTenants.Items.Clear()
            cboTenants.Text = "No Tenants Found"
            grpTenantPayments.Visible = False
            con.Close()
            Exit Sub
        End If
        'clear the combobox
        cboTenants.Items.Clear()
        'loop through the results and add them to the combobox as ID, fname, lname
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim tenantInfo As String = dt.Rows(i).Item("ID") & " " & dt.Rows(i).Item("fname") & " " & dt.Rows(i).Item("lname")
            cboTenants.Items.Add(tenantInfo)
        Next
        con.Close()
        cboTenants.SelectedIndex = 0
    End Sub

    Private Sub cboTenants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenants.SelectedIndexChanged
        grpTenantPayments.Visible = True
    End Sub

    Private Sub btnAllTenantPayments_Click(sender As Object, e As EventArgs) Handles btnAllTenantPayments.Click
        'we have tenantID assigned by cboTenants_SelectedIndexChanged
        'here we collect all payments for the tenantID from the payments table
        'connection string is defined in the module as ConnectionString
        'code is as follows
        'use substring to get ID value from cbotenants and assign it to TenantID
        TenantID = Convert.ToInt32(cboTenants.Text.Substring(0, cboTenants.Text.IndexOf(" ")))

        'connect to the database
        con.ConnectionString = connectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Payments WHERE Tenant = " & TenantID
        'run the query
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        'if there are no results, msgbox No Payments Found
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No Payments Found", "No Payments", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            Exit Sub
        ElseIf dt.Rows.Count > 0 Then
            'if there are results, we print them in a document
            'we first print Company, Address, Address2, City, State, Zip, Phone, Fax from the Company table
            'then we print the tenant name and address from the tenants table
            'then we print the payments in a table with Payment Date, Payment Type, Payment Amount, Payment Note
            'we print the total of the payments
            'we print the Rent, Due Date, and Total Due from the tenants table
            'code to get the company information is as follows, company id is always 1
            cmd.CommandText = "SELECT * FROM Company WHERE ID = 1"
            da.SelectCommand = cmd
            Dim dtCompany As New DataTable
            da.Fill(dtCompany)
            'print the company information  
            'display Company on the first line in upper case bold letters, display address and address2 on the next line, display city, state, zip on the next line
            'display phone and fax on the next line with prefix Phone: and Fax:
            'code is as follows
            Dim company As String = dtCompany.Rows(0).Item("Company")
            Dim address As String = dtCompany.Rows(0).Item("Address")
            Dim address2 As String = dtCompany.Rows(0).Item("Address2")
            Dim city As String = dtCompany.Rows(0).Item("City")
            Dim state As String = dtCompany.Rows(0).Item("State")
            Dim zip As String = dtCompany.Rows(0).Item("Zip")
            Dim phone As String = dtCompany.Rows(0).Item("Phone")
            Dim fax As String = dtCompany.Rows(0).Item("Fax")
            'close connection
            con.Close()
            ' Create a PrintDocument object and handle its PrintPage event
            Dim printDocument As New Printing.PrintDocument()
            AddHandler printDocument.PrintPage, AddressOf PrintPayments

            ' Create a PrintPreviewDialog object and set its Document property
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDocument

            ' Show the print preview dialog
            printPreviewDialog.ShowDialog()


        End If
    End Sub

    Private Sub PrintPayments(sender As Object, e As Printing.PrintPageEventArgs)
        ' Ensure the dataset is filled with data
        Dim connection As New OleDbConnection(connectionString)
        connection.Open()
        Dim command As New OleDbCommand("SELECT * FROM Company WHERE ID = 1", connection)
        Dim adapter As New OleDbDataAdapter(command)
        Dim companyTable As New DataTable()
        adapter.Fill(companyTable)
        connection.Close()

        ' Get company details from the company table
        Dim companyRow As DataRow = companyTable.Rows(0)
        Dim companyName As String = companyRow("Company").ToString().ToUpper()
        Dim address As String = companyRow("Address").ToString()
        Dim address2 As String = companyRow("Address2").ToString()
        Dim city As String = companyRow("City").ToString()
        Dim state As String = companyRow("State").ToString()
        Dim zip As String = companyRow("Zip").ToString()
        Dim phone As String = companyRow("Phone").ToString()
        Dim fax As String = companyRow("Fax").ToString()

        ' Print the company details at the top of the receipt
        Dim companyDetails As String = $"{companyName}" & Environment.NewLine &
                                       $"{address} {address2}" & Environment.NewLine &
                                       $"{city}, {state} {zip}" & Environment.NewLine &
                                       $"Phone: {phone} Fax: {fax}" & Environment.NewLine & Environment.NewLine

        ' Get tenant details
        Dim tenantName As String = cboTenants.Text

        ' Print the tenant details
        Dim tenantDetails As String = $"Tenant Name: {tenantName}" & Environment.NewLine & Environment.NewLine

        ' Print the payments
        Dim paymentsDetails As String = "Payment Date" & Environment.NewLine
        ' Collect payment details from the payments table using TenantID
        con.ConnectionString = connectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Payments WHERE Tenant = " & TenantID
        da.SelectCommand = cmd
        Dim dtPayments As New DataTable
        da.Fill(dtPayments)
        con.Close()
        TenantTotalPaid = 0
        'while we loop thru these records, we add the payment amount to TenantTotalPaid
        For Each row As DataRow In dtPayments.Rows
            paymentsDetails &= row("PaymentDate").ToString() & vbTab & row("PaymentType").ToString() & vbTab & Convert.ToDecimal(row("Amount")).ToString("C") & vbTab & row("Notes").ToString() & Environment.NewLine
            TenantTotalPaid += Convert.ToDecimal(row("Amount"))
        Next

        ' Draw the company details, tenant details, and payments on the print document
        e.Graphics.DrawString(companyDetails, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(100, 50))
        e.Graphics.DrawString(tenantDetails, New Font("Arial", 12), Brushes.Black, New PointF(100, 150))
        e.Graphics.DrawString(paymentsDetails, New Font("Arial", 12), Brushes.Black, New PointF(100, 200))
        ' Print the total paid by the tenant
        e.Graphics.DrawString($"Total Paid: {TenantTotalPaid.ToString("C")}", New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(100, 400))

    End Sub
End Class