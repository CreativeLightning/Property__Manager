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
        VerifyExit(sender, e, btnExit)
    End Sub

    Private Sub txtSearchByTenant_TextChanged(sender As Object, e As EventArgs) Handles txtSearchByTenant.TextChanged
        'search the database for the tenant name entered from the tenants table either fname or lname = txtSearchByTenant
        'connection string is defined in the module as ConnectionString
        'with results we fill cboTenants with fname and lname and ID from tenants table
        'If txtSearchByTenant is empty exit the sub and clear cboTenants
        If txtSearchByTenant.Text = "" Then
            cboTenants.Items.Clear()
            cboTenants.Text = ""
            Exit Sub
        End If
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
        grpPropertyPayments.Visible = False
    End Sub

    Private Sub btnAllTenantPayments_Click(sender As Object, e As EventArgs) Handles btnAllTenantPayments.Click

        TenantID = Convert.ToInt32(cboTenants.Text.Substring(0, cboTenants.Text.IndexOf(" ")))

        con.ConnectionString = connectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Payments WHERE Tenant = " & TenantID & " AND PaymentDate >= #" & dtpStart.Value.ToString("MM/dd/yyyy") & "# AND PaymentDate <= #" & dtpEnd.Value.ToString("MM/dd/yyyy") & "#"
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No Payments Found", "No Payments", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            Exit Sub
        ElseIf dt.Rows.Count > 0 Then
            cmd.CommandText = "SELECT * FROM Company WHERE ID = 1"
            da.SelectCommand = cmd
            Dim dtCompany As New DataTable
            da.Fill(dtCompany)
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
        cmd.CommandText = "SELECT * FROM Payments WHERE Tenant = " & TenantID & " AND PaymentDate >= #" & dtpStart.Value.ToString("MM/dd/yyyy") & "# AND PaymentDate <= #" & dtpEnd.Value.ToString("MM/dd/yyyy") & "#"
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
        'add TenantTotalPaid to the paymentsDetails
        paymentsDetails &= "------------------------------------------------------------" & Environment.NewLine
        paymentsDetails &= "Total Paid: " & TenantTotalPaid.ToString("C") & Environment.NewLine
        ' Draw the company details, tenant details, and payments on the print document
        GetCompanyDetails()
        e.Graphics.DrawString(CompanyDetails, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(100, 50))
        e.Graphics.DrawString(tenantDetails, New Font("Arial", 12), Brushes.Black, New PointF(100, 150))
        e.Graphics.DrawString(paymentsDetails, New Font("Arial", 12), Brushes.Black, New PointF(100, 200))
        ' Print the total paid by the tenant

    End Sub

    Private Sub txtSearchByStreet_TextChanged(sender As Object, e As EventArgs) Handles txtSearchByStreet.TextChanged
        'search the database for Properties from the properties table where StreetName like txtSearchByStreet
        'connection string is defined in the module as ConnectionString
        'with results we fill cboProperties with ID, StreetNumber and StreetName from properties table
        'If txtSearchByStreet is empty exit the sub and clear cboProperties
        If txtSearchByStreet.Text = "" Then
            cboProperties.Items.Clear()
            cboProperties.Text = ""
            Exit Sub
        End If
        'code is as follows
        con.ConnectionString = connectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Properties WHERE StreetName LIKE '%" & txtSearchByStreet.Text & "%'"
        'run the query
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        'if there are no results, clear the combobox and display a message No Properties Found hide the groupbox
        If dt.Rows.Count = 0 Then
            cboProperties.Items.Clear()
            cboProperties.Text = "No Properties Found"
            grpPropertyPayments.Visible = False
            con.Close()
            Exit Sub
        End If
        'clear the combobox
        cboProperties.Items.Clear()
        'loop through the results and add them to the combobox as ID, StreetNumber, StreetName
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim propertyInfo As String = dt.Rows(i).Item("ID") & " " & dt.Rows(i).Item("StreetNumber") & " " & dt.Rows(i).Item("StreetName")
            cboProperties.Items.Add(propertyInfo)
        Next
        con.Close()
        cboProperties.SelectedIndex = 0

    End Sub

    Private Sub cboProperties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProperties.SelectedIndexChanged
        grpPropertyPayments.Visible = True
        grpTenantPayments.Visible = False

    End Sub

    Private Sub btnPrintRentHistory_Click(sender As Object, e As EventArgs) Handles btnPrintRentHistory.Click
        'We have PropertyID assigned by cboProperties_SelectedIndexChanged
        'Here we collect all Rent received for the PropertyID from the payments table
        'Connection string is defined in the module as ConnectionString
        'Code is as follows
        'Use substring to get ID value from cboProperties and assign it to PropertyID
        PropertyID = Convert.ToInt32(cboProperties.Text.Substring(0, cboProperties.Text.IndexOf(" ")))

        'Connect to the database
        con.ConnectionString = connectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Payments WHERE Property = " & PropertyID & " AND PaymentDate >= #" & dtpStart.Value.ToString("MM/dd/yyyy") & "# AND PaymentDate <= #" & dtpEnd.Value.ToString("MM/dd/yyyy") & "#"
        'Run the query
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        'If there are no results, MsgBox No Payments Found
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No Payments Found", "No Payments", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            Exit Sub
        ElseIf dt.Rows.Count > 0 Then

            'Create a PrintDocument object and handle its PrintPage event
            Dim printDocument As New Printing.PrintDocument()
            AddHandler printDocument.PrintPage, AddressOf PrintRent
            'Create a PrintPreviewDialog object and set its Document property
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDocument
            'Show the print preview dialog
            printPreviewDialog.ShowDialog()


        End If
    End Sub


    Private Sub PrintRent(Sender As Object, e As Printing.PrintPageEventArgs)

        ' Get property details
        Dim propertyAddress As String = cboProperties.Text
        ' Print the property details
        Dim propertyDetails As String = $"Property Address: # {propertyAddress}" & Environment.NewLine & Environment.NewLine
        ' Print the payments
        Dim paymentsDetails As String = "Date Received" & Environment.NewLine
        ' Collect payment details from the payments table using PropertyID

        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Payments WHERE Property = " & PropertyID & " AND PaymentDate >= #" & dtpStart.Value.ToString("MM/dd/yyyy") & "# AND PaymentDate <= #" & dtpEnd.Value.ToString("MM/dd/yyyy") & "#"
        da.SelectCommand = cmd
        Dim dtPayments As New DataTable
        da.Fill(dtPayments)
        con.Close()
        TotalPropertyPaid = 0
        'while we loop thru these records, we add the payment amount to TotalPropertyPaid
        For Each row As DataRow In dtPayments.Rows
            paymentsDetails &= row("PaymentDate").ToString() & vbTab & row("PaymentType").ToString() & vbTab & Convert.ToDecimal(row("Amount")).ToString("C") & vbTab & row("Notes").ToString() & Environment.NewLine
            TotalPropertyPaid += Convert.ToDecimal(row("Amount"))
        Next
        'add TotalPropertyPaid to the paymentsDetails
        paymentsDetails &= "------------------------------------------------------------" & Environment.NewLine
        paymentsDetails &= "Total Received: " & TotalPropertyPaid.ToString("C") & Environment.NewLine
        GetCompanyDetails()
        ' Draw the company details, property details, and payments on the print document
        e.Graphics.DrawString(CompanyDetails, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(100, 50))
        e.Graphics.DrawString(propertyDetails, New Font("Arial", 12), Brushes.Black, New PointF(100, 150))
        e.Graphics.DrawString(paymentsDetails, New Font("Arial", 12), Brushes.Black, New PointF(100, 200))

    End Sub

    Private Sub frmPaymentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set custom format for dtpStart and dtpEnd
        dtpStart.Format = DateTimePickerFormat.Custom
        dtpStart.CustomFormat = "MM/dd/yyyy"
        dtpEnd.Format = DateTimePickerFormat.Custom
        dtpEnd.CustomFormat = "MM/dd/yyyy"

        ' Set default values for dtpStart and dtpEnd
        dtpStart.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpEnd.Value = New DateTime(DateTime.Now.Year, 12, 31)
    End Sub
End Class