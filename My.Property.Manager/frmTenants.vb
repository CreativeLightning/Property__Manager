Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports My_Property_Manager.Property_ManagerDataSetTableAdapters
Imports System.Data.OleDb

Public Class frmTenants
    Private Property_ManagerDataSet As New Property_ManagerDataSet()
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmAddTenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the 'Property_ManagerDataSet.Tenants' table
        TenantsTableAdapter.Fill(Me.Property_ManagerDataSet.Tenants)
        PropertiesTableAdapter.Fill(Me.Property_ManagerDataSet.Properties)
        PaymentTypesTableAdapter.Fill(Me.Property_ManagerDataSet.PaymentTypes)
        'hide tenant info group box
        grpTenantInfo.Visible = False

        'PaymentsTableAdapter.Fill(Me.Property_ManagerDataSet.Payments)
        If HelpMessages Then
            MsgBox("Type Tenant's First or Last Name to search for Tenant, then select Tenant from dropdown list to view or edit Tenant information.")
        End If
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        ' Validate Fname
        If String.IsNullOrEmpty(txtFName.Text) Then
            MessageBox.Show("Please enter a valid First Name.")
            txtFName.Focus()
            Return
        End If

        ' Validate Lname
        If String.IsNullOrEmpty(txtLName.Text) Then
            MessageBox.Show("Please enter a valid Last Name.")
            txtLName.Focus()
            Return
        End If

        ' Validate SSN
        Dim ssnValue As String = RemoveNonNumeric(txtSSN.Text)
        If String.IsNullOrEmpty(ssnValue) OrElse Not IsNumeric(ssnValue) Then
            MessageBox.Show("Please enter a valid SSN.")
            txtSSN.Focus()
            Return
        End If

        ' Validate Phone
        Dim phoneValue As String = RemoveNonNumeric(txtPhone.Text)
        If Not String.IsNullOrEmpty(phoneValue) AndAlso Not IsNumeric(phoneValue) Then
            MessageBox.Show("Please enter a valid Phone number.")
            txtPhone.Focus()
            Return
        End If

        ' Validate Phone2
        Dim phone2Value As String = RemoveNonNumeric(txtPhone2.Text)
        If Not String.IsNullOrEmpty(phone2Value) AndAlso Not IsNumeric(phone2Value) Then
            MessageBox.Show("Please enter a valid Phone2 number.")
            Return
        End If

        ' Validate Phone3
        Dim phone3Value As String = RemoveNonNumeric(txtPhone3.Text)
        If Not String.IsNullOrEmpty(phone3Value) AndAlso Not IsNumeric(phone3Value) Then
            MessageBox.Show("Please enter a valid Phone3 number.")
            Return
        End If

        ' Validate DOB
        Dim dobValue As Date
        If Not Date.TryParse(txtDOB.Text, dobValue) Then
            MessageBox.Show("Please enter a valid Date Of Birth In the format MM/DD/YYYY.")
            txtDOB.Focus()
            Return
        End If

        ' Set additional fields
        Dim notesValue As String = txtNotes.Text
        Dim activeValue As String = "y"
        Dim propertyIDValue As String = "0" ' or some default value
        Dim userIDValue As String = User 'global variable

        ' Define the connection string


        ' Create a connection object
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()
            Dim transaction As OleDb.OleDbTransaction = connection.BeginTransaction()

            Try
                ' Create a command object
                Dim command As New OleDb.OleDbCommand("INSERT INTO Tenants (Fname, Lname, SSN, Phone, Phone2, Phone3, DOB, Notes, Active, PropertyID, UserID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", connection, transaction)

                ' Add parameters to the command
                command.Parameters.Add(New OleDb.OleDbParameter("Fname", txtFName.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Lname", txtLName.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("SSN", txtSSN.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone", txtPhone.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone2", txtPhone2.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone3", txtPhone3.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("DOB", txtDOB.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Notes", txtNotes.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Active", "y"))
                command.Parameters.Add(New OleDb.OleDbParameter("PropertyID", "0"))
                command.Parameters.Add(New OleDb.OleDbParameter("UserID", "0"))


                Try
                    ' Execute the command
                    command.ExecuteNonQuery()
                    command.Transaction.Commit()
                    'TenantsTableAdapter.InsertCommand = command
                    TenantsTableAdapter.Update(Property_ManagerDataSet.Tenants)
                    Property_ManagerDataSet.Tables("Tenants").AcceptChanges()
                    MessageBox.Show("Tenant added successfully.")
                    btnSaveNew.Visible = False
                    btnCancel.Visible = False
                    btnSave.Visible = True
                    TenantsTableAdapter.ClearBeforeFill = True
                    TenantsTableAdapter.Fill(Me.Property_ManagerDataSet.Tenants)
                    cboTenants.Items.Clear()
                    cboTenants.Text = "No tenants found"
                Catch ex As Exception
                    ' Handle any errors that may have occurred
                    If transaction.Connection IsNot Nothing Then
                        transaction.Rollback()
                    End If
                    MessageBox.Show("An Error occurred: " & ex.Message)
                End Try

            Finally
                ' Ensure the connection is closed
                connection.Close()
            End Try
        End Using
        grpSearch.Visible = True
        grpTenantInfo.Visible = True
        grpPayment.Visible = False
        ClearTextboxes()
    End Sub

    Private Function RemoveNonNumeric(input As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(input, "[^\d]", "")
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            grpSearch.Visible = True
            btnSaveNew.Visible = False
            btnCancel.Visible = False
            btnSave.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        grpTenantInfo.Visible = True
        btnSaveNew.Visible = True
        btnCancel.Visible = True
        grpSearch.Visible = False
        btnSave.Visible = False
        ClearTextboxes()
        grpRentInfo.Visible = False
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub txtSSN_TextChanged(sender As Object, e As EventArgs) Handles txtSSN.TextChanged
        ' Remove any non-numeric characters
        Dim digitsOnly As String = New String(txtSSN.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Show or hide the lblSSNtoolong label based on the length of digitsOnly
        lblInvalidSSN.Visible = digitsOnly.Length <> 9

        ' Format the SSN with hyphens
        Dim formattedSSN As String = ""
        If digitsOnly.Length > 0 Then
            formattedSSN = digitsOnly.Substring(0, Math.Min(3, digitsOnly.Length))
        End If
        If digitsOnly.Length > 3 Then
            formattedSSN &= "-" & digitsOnly.Substring(3, Math.Min(2, digitsOnly.Length - 3))
        End If
        If digitsOnly.Length > 5 Then
            formattedSSN &= "-" & digitsOnly.Substring(5, Math.Min(4, digitsOnly.Length - 5))
        End If
        If digitsOnly.Length > 9 Then
            formattedSSN &= digitsOnly.Substring(9)
        End If

        ' Update the text box with the formatted SSN
        txtSSN.Text = formattedSSN
        txtSSN.SelectionStart = txtSSN.Text.Length ' Set the cursor to the end of the text
    End Sub
    Private Sub FormatPhoneNumber(textBox As TextBox, lblPhoneTooLong As Label)
        ' Remove any non-numeric characters
        Dim digitsOnly As String = New String(textBox.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Show or hide the lblPhoneTooLong label based on the length of digitsOnly
        lblPhoneTooLong.Visible = digitsOnly.Length <> 10

        ' Format the phone number with parentheses and a hyphen
        Dim formattedPhoneNumber As String = ""
        If digitsOnly.Length > 0 Then
            formattedPhoneNumber = "(" & digitsOnly.Substring(0, Math.Min(3, digitsOnly.Length))
        End If
        If digitsOnly.Length > 3 Then
            formattedPhoneNumber &= ") " & digitsOnly.Substring(3, Math.Min(3, digitsOnly.Length - 3))
        End If
        If digitsOnly.Length > 6 Then
            formattedPhoneNumber &= "-" & digitsOnly.Substring(6, Math.Min(4, digitsOnly.Length - 6))
        End If
        If digitsOnly.Length > 10 Then
            formattedPhoneNumber &= " " & digitsOnly.Substring(10)
        End If

        ' Update the text box with the formatted phone number
        textBox.Text = formattedPhoneNumber
        textBox.SelectionStart = textBox.Text.Length ' Set the cursor to the end of the text
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        FormatPhoneNumber(txtPhone, lblInvalidPhone)
    End Sub

    Private Sub txtPhone2_TextChanged(sender As Object, e As EventArgs) Handles txtPhone2.TextChanged
        FormatPhoneNumber(txtPhone2, lblInvalidPhone)
    End Sub

    Private Sub txtPhone3_TextChanged(sender As Object, e As EventArgs) Handles txtPhone3.TextChanged
        FormatPhoneNumber(txtPhone3, lblInvalidPhone)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If searchText.Length = 0 Then
            cboTenants.Items.Clear()
            cboTenants.Text = "No tenants found"
            lblNoneFound.Visible = False
            btnDelete.Visible = False
            btnSave.Visible = False
            Return
        End If
        btnSave.Visible = True
        PropertiesTableAdapter.Fill(Me.Property_ManagerDataSet.Properties)
        Dim filteredRows = Property_ManagerDataSet.Tenants.Select($"Fname LIKE '%{searchText}%' OR Lname LIKE '%{searchText}%'")

        cboTenants.Items.Clear()
        For Each row As DataRow In filteredRows
            cboTenants.Items.Add($"{row("ID")}: {row("Fname")} {row("Lname")}")
            cboTenants.DisplayMember = Format($"{row("Fname")} {row("Lname")}")
        Next

        ' Show the first item if there are items in the combo box
        If cboTenants.Items.Count > 0 Then
            cboTenants.SelectedIndex = 0
            lblNoneFound.Visible = False
            btnDelete.Visible = True
            'show the tenant info group box
            grpTenantInfo.Visible = True

        Else
            cboTenants.Text = "No tenants found"
            lblNoneFound.Visible = True
            btnDelete.Visible = False
            'hide tenant info group box
            grpTenantInfo.Visible = False
        End If
    End Sub


    Private Sub txtDOB_TextChanged(sender As Object, e As EventArgs) Handles txtDOB.TextChanged
        Dim text As String = txtDOB.Text
        lblInvalidDOB.Visible = text.Length <> 10
        If text.Length = 3 OrElse text.Length = 6 Then
            If Not text.EndsWith("/") Then
                txtDOB.Text = text.Insert(text.Length - 1, "/")
                txtDOB.SelectionStart = txtDOB.Text.Length
            End If
        End If
    End Sub

    Private Sub cboTenants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTenants.SelectedIndexChanged
        Dim selectedTenant As String = cboTenants.SelectedItem.ToString()
        Dim tenantID As Integer = Integer.Parse(selectedTenant.Split(":")(0).Trim())
        Dim tenantRow As DataRow = Property_ManagerDataSet.Tenants.Select($"ID = {tenantID}").FirstOrDefault()
        If tenantRow IsNot Nothing Then
            txtFName.Text = tenantRow("Fname").ToString()
            txtLName.Text = tenantRow("Lname").ToString()
            txtSSN.Text = tenantRow("SSN").ToString()
            txtPhone.Text = tenantRow("Phone").ToString()
            txtPhone2.Text = tenantRow("Phone2").ToString()
            txtPhone3.Text = tenantRow("Phone3").ToString()
            txtDOB.Text = tenantRow("DOB").ToString()
            txtNotes.Text = tenantRow("Notes").ToString()
            Rent = tenantRow("Rent").ToString()
            If Rent > 0 Then
                grpRentInfo.Visible = True
                txtRentAmount.Text = Rent
            Else
                grpRentInfo.Visible = False
            End If
            txtRentAmount.Text = Rent
            DueDate = tenantRow("RentDue").ToString()
            ' Collect the PropertyID value from the Properties table
            Dim propertyid As Integer = tenantRow("PropertyID")
            Dim propertyRows As DataRow() = Property_ManagerDataSet.Properties.Select($"ID = {propertyid}")
            If propertyRows.Length > 0 Then
                Dim propertyRow As DataRow = propertyRows(0)
                Dim streetNumber As String = propertyRow("StreetNumber").ToString()
                Dim streetName As String = propertyRow("StreetName").ToString()
                lblProperty.Text = $"{streetNumber} {streetName} - Rent Due: {Date.Parse(DueDate).ToString("MM/dd/yyyy")} Amount: {Decimal.Parse(Rent).ToString("C")}"
                btnTakePayment.Visible = True
                cboPickProperty.Visible = False
                grpRentInfo.Visible = False
            Else
                lblProperty.Text = "Choose Property"
                btnTakePayment.Visible = False
                FillcboPickProperty()
                cboPickProperty.Visible = True
                grpRentInfo.Visible = True
            End If
        End If
    End Sub
    Private Sub FillcboPickProperty()
        cboPickProperty.Items.Clear()
        Dim propertyRows As DataRow() = Property_ManagerDataSet.Properties.Select()
        For Each propertyRow As DataRow In propertyRows
            Dim streetNumber As String = propertyRow("StreetNumber").ToString()
            Dim streetName As String = propertyRow("StreetName").ToString()
            Dim PropertyID As Integer = propertyRow("ID")
            cboPickProperty.ValueMember = PropertyID
            cboPickProperty.Items.Add($"{streetNumber} {streetName}")
        Next
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate Fname
        If HelpMessages = True Then
            If String.IsNullOrEmpty(txtFName.Text) Then
                MessageBox.Show("Please enter a valid First Name.")
                Return
            End If

            ' Validate Lname
            If String.IsNullOrEmpty(txtLName.Text) Then
                MessageBox.Show("Please enter a valid Last Name.")
                Return
            End If

            ' Validate SSN
            Dim ssnValue As String = RemoveNonNumeric(txtSSN.Text)
            If String.IsNullOrEmpty(ssnValue) OrElse Not IsNumeric(ssnValue) Then
                MessageBox.Show("Please enter a valid SSN.")
                Return
            End If

            ' Validate Phone
            Dim phoneValue As String = RemoveNonNumeric(txtPhone.Text)
            If Not String.IsNullOrEmpty(phoneValue) AndAlso Not IsNumeric(phoneValue) Then
                MessageBox.Show("Please enter a valid Phone number.")
                Return
            End If

            ' Validate Phone2
            Dim phone2Value As String = RemoveNonNumeric(txtPhone2.Text)
            If Not String.IsNullOrEmpty(phone2Value) AndAlso Not IsNumeric(phone2Value) Then
                MessageBox.Show("Please enter a valid Phone2 number.")
                Return
            End If

            ' Validate Phone3
            Dim phone3Value As String = RemoveNonNumeric(txtPhone3.Text)
            If Not String.IsNullOrEmpty(phone3Value) AndAlso Not IsNumeric(phone3Value) Then
                MessageBox.Show("Please enter a valid Phone3 number.")
                Return
            End If

            ' Validate DOB
            Dim dobValue As Date
            If Not Date.TryParse(txtDOB.Text, dobValue) Then
                MessageBox.Show("Please enter a valid Date of Birth in the format MM/DD/YYYY.")
                Return
            End If
        End If
        ' Get the selected tenant ID
        Dim selectedTenant As String = cboTenants.SelectedItem.ToString()
        Dim tenantID As Integer = Integer.Parse(selectedTenant.Split(":")(0).Trim())
        MsgBox(tenantID).ToString()
        ' Get the selected property ID
        Dim tenantRow As DataRow = Property_ManagerDataSet.Tenants.Select($"ID = {tenantID}").FirstOrDefault()
        Dim propertyID As Integer = Integer.Parse(tenantRow("PropertyID").ToString())

        ' Define the connection string
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()
            Dim transaction As OleDb.OleDbTransaction = connection.BeginTransaction()

            Try
                ' Create a command object
                ' using command object, update the tenants table where the ID = tenantID
                Dim command As New OleDb.OleDbCommand("UPDATE Tenants SET Fname = ?, Lname = ?, SSN = ?, Phone = ?, Phone2 = ?, Phone3 = ?, DOB = ?, Notes = ?, Rent = ? WHERE ID = ?", connection, transaction)

                ' Add parameters to the command
                command.Parameters.Add(New OleDb.OleDbParameter("Fname", txtFName.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Lname", txtLName.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("SSN", txtSSN.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone", txtPhone.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone2", txtPhone2.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone3", txtPhone3.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("DOB", txtDOB.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Notes", txtNotes.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Rent", txtRentAmount.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("ID", tenantID))

                Try
                    ' Execute the command
                    command.ExecuteNonQuery()
                    transaction.Commit()
                    TenantsTableAdapter.Update(Property_ManagerDataSet.Tenants)
                    Property_ManagerDataSet.Tables("Tenants").AcceptChanges()
                    If HelpMessages = True Then
                        MessageBox.Show("Tenant updated successfully.")
                    End If
                    TenantsTableAdapter.ClearBeforeFill = True
                    TenantsTableAdapter.Fill(Me.Property_ManagerDataSet.Tenants)
                Catch ex As Exception
                    ' Handle any errors that may have occurred
                    If transaction.Connection IsNot Nothing Then
                        transaction.Rollback()
                    End If
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try

            Finally
                ' Ensure the connection is closed
                connection.Close()
            End Try
        End Using
        cboTenants.Text = "No tenants found"
        txtSearch.Text = ""
        cboTenants.Items.Clear()
        lblProperty.Text = ""
        ClearTextboxes()
    End Sub

    Private Sub btnTakePayment_Click(sender As Object, e As EventArgs) Handles btnTakePayment.Click
        grpSearch.Visible = False
        grpTenantInfo.Visible = False
        grpPayment.Visible = True
        grpPayment.Location = New Point(111, 92)
        btnTakePayment.Visible = False
        txtAmount.Text = Rent
        txtNotes.Text = ""
        txtPaymentDate.Text = Date.Today.ToString("MM/dd/yyyy")
        lblTenantName.Text = "Tenant Name: " & cboTenants.SelectedItem.ToString()
        ' Fill cboPaymentType with data from PaymentTypesTableAdapter
        cboPaymentType.DataSource = Me.Property_ManagerDataSet.PaymentTypes
        cboPaymentType.DisplayMember = "Type"

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        grpPayment.Visible = False
        grpSearch.Visible = True
        grpTenantInfo.Visible = True

        ' Clear the payment fields
        txtAmount.Text = ""
        btnTakePayment.Visible = True

    End Sub

    Private Sub btnRecordPayment_Click(sender As Object, e As EventArgs) Handles btnRecordPayment.Click
        ' Validate Amount
        Dim amountValue As Integer
        If Not Integer.TryParse(txtAmount.Text, amountValue) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If

        ' Validate Payment Type
        If cboPaymentType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a payment type.")
            Return
        End If

        ' Get the selected tenant ID
        Dim selectedTenant As String = cboTenants.SelectedItem.ToString()
        Dim tenantID As Integer = Integer.Parse(selectedTenant.Split(":")(0).Trim())

        ' Get the selected property ID
        Dim tenantRow As DataRow = Property_ManagerDataSet.Tenants.Select($"ID = {tenantID}").FirstOrDefault()
        Dim propertyID As Integer = Integer.Parse(tenantRow("PropertyID").ToString())

        'Add one month to the DueDate value and store it back in the tenants table
        Dim DueDate As Date = Date.Parse(tenantRow("RentDue").ToString())
        Dim NewDueDate As Date = DueDate.AddMonths(1)
        tenantRow("RentDue") = NewDueDate.ToString("MM/dd/yyyy")
        Try
            TenantsTableAdapter.Update(Property_ManagerDataSet.Tenants)
            Property_ManagerDataSet.Tables("Tenants").AcceptChanges()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        ' Define the connection string
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()
            Dim transaction As OleDb.OleDbTransaction = connection.BeginTransaction()

            Try
                ' Create a command object
                Dim command As New OleDb.OleDbCommand("INSERT INTO Payments (PaymentDate, PaymentType, PaymentIDNumber, Amount, Tenant, Property, TakenBy, Notes) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", connection, transaction)

                ' Add parameters to the command
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentDate", Date.Parse(txtPaymentDate.Text)))
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentType", cboPaymentType.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentIDNumber", txtPaymentIDNumber.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Amount", amountValue))
                command.Parameters.Add(New OleDb.OleDbParameter("Tenant", tenantID))
                command.Parameters.Add(New OleDb.OleDbParameter("Property", propertyID))
                command.Parameters.Add(New OleDb.OleDbParameter("TakenBy", User))
                command.Parameters.Add(New OleDb.OleDbParameter("Notes", txtNotes.Text))

                Try
                    ' Execute the command
                    command.ExecuteNonQuery()
                    transaction.Commit()
                    PaymentsTableAdapter.Update(Property_ManagerDataSet.Payments)
                    Property_ManagerDataSet.Tables("Payments").AcceptChanges()
                    MessageBox.Show("Payment recorded successfully.")
                Catch ex As Exception
                    ' Handle any errors that may have occurred
                    If transaction.Connection IsNot Nothing Then
                        transaction.Rollback()
                    End If
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try

            Finally
                ' Ensure the connection is closed
                connection.Close()
            End Try
        End Using

        ' Close the form
        Me.Close()
    End Sub

    Private Sub ClearTextboxes()
        txtFName.Text = ""
        txtLName.Text = ""
        txtSSN.Text = ""
        txtPhone.Text = ""
        txtPhone2.Text = ""
        txtPhone3.Text = ""
        txtDOB.Text = ""
        txtNotes.Text = ""
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        AssignProperty()
    End Sub
    Private Sub AssignProperty()
        If txtRentDue.Text.Length <> 10 Then
            MessageBox.Show("Please enter a valid Rent Due date for their next rent.")
            Return
        End If
        Dim selectedTenant As String = cboTenants.SelectedItem.ToString()
        Dim tenantID As Integer = Integer.Parse(selectedTenant.Split(":")(0).Trim())
        Dim tenantRow As DataRow = Property_ManagerDataSet.Tenants.Select($"ID = {tenantID}").FirstOrDefault()
        If tenantRow IsNot Nothing Then
            Dim propertyIndex As Integer = cboPickProperty.SelectedIndex
            tenantRow("PropertyID") = propertyIndex + 1
            tenantRow("RentDue") = txtRentDue.Text
            tenantRow("Deposit") = txtDeposit.Text
            tenantRow("Rent") = txtRent.Text
            tenantRow("DepositPaid") = chkDepositPaid.Checked
            Try
                TenantsTableAdapter.Update(Property_ManagerDataSet.Tenants)
                Property_ManagerDataSet.Tables("Tenants").AcceptChanges()
                MessageBox.Show("Property and Amounts assigned successfully.")
                cboPickProperty.Visible = False
                btnTakePayment.Visible = True
                grpRentInfo.Visible = False
                btnTakePayment.Visible = False
                lblProperty.Text = ""
                txtSearch.Text = ""
                cboTenants.Text = "No tenants found"
                ClearTextboxes()
                lblProperty.Text = $"{cboPickProperty.SelectedItem.ToString()}"
                'Record a payment in the payments table for the rent amount
                ' Define the connection string
                Using connection As New OleDb.OleDbConnection(connectionString)
                    connection.Open()
                    Dim transaction As OleDb.OleDbTransaction = connection.BeginTransaction()
                    ' Create a command object
                    Dim command As New OleDb.OleDbCommand("INSERT INTO Payments (PaymentDate, PaymentType, PaymentIDNumber, Amount, Tenant, Property, TakenBy, Notes) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", connection, transaction)
                    ' Add parameters to the command
                    command.Parameters.Add(New OleDb.OleDbParameter("PaymentDate", Date.Today.ToString("MM/dd/yyyy")))
                    command.Parameters.Add(New OleDb.OleDbParameter("PaymentType", "Rent"))
                    command.Parameters.Add(New OleDb.OleDbParameter("PaymentIDNumber", "0"))
                    command.Parameters.Add(New OleDb.OleDbParameter("Amount", txtRent.Text))
                    command.Parameters.Add(New OleDb.OleDbParameter("Tenant", tenantID))
                    command.Parameters.Add(New OleDb.OleDbParameter("Property", propertyIndex + 1))
                    command.Parameters.Add(New OleDb.OleDbParameter("TakenBy", User))
                    command.Parameters.Add(New OleDb.OleDbParameter("Notes", "Rent Payment"))
                    Try
                        ' Execute the command
                        command.ExecuteNonQuery()
                        transaction.Commit()
                        PaymentsTableAdapter.Update(Property_ManagerDataSet.Payments)
                        Property_ManagerDataSet.Tables("Payments").AcceptChanges()
                        If HelpMessages Then
                            MessageBox.Show("Rent Payment recorded successfully.")
                        End If
                    Catch ex As Exception
                        ' Handle any errors that may have occurred
                        If transaction.Connection IsNot Nothing Then
                            transaction.Rollback()
                        End If
                        MessageBox.Show("An error occurred: " & ex.Message)
                    End Try
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
            'Record a payment in the payments table for the deposit amount
            ' Define the connection string
            Using connection As New OleDb.OleDbConnection(connectionString)
                connection.Open()
                Dim transaction As OleDb.OleDbTransaction = connection.BeginTransaction()
                ' Create a command object
                Dim command As New OleDb.OleDbCommand("INSERT INTO Payments (PaymentDate, PaymentType, PaymentIDNumber, Amount, Tenant, Property, TakenBy, Notes) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", connection, transaction)
                ' Add parameters to the command
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentDate", Date.Today.ToString("MM/dd/yyyy")))
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentType", "Deposit"))
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentIDNumber", "0"))
                command.Parameters.Add(New OleDb.OleDbParameter("Amount", txtDeposit.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Tenant", tenantID))
                command.Parameters.Add(New OleDb.OleDbParameter("Property", propertyIndex + 1))
                command.Parameters.Add(New OleDb.OleDbParameter("TakenBy", User))
                command.Parameters.Add(New OleDb.OleDbParameter("Notes", "Deposit Payment"))
                Try
                    ' Execute the command
                    command.ExecuteNonQuery()
                    transaction.Commit()
                    PaymentsTableAdapter.Update(Property_ManagerDataSet.Payments)
                    Property_ManagerDataSet.Tables("Payments").AcceptChanges()
                    If HelpMessages Then
                        MessageBox.Show("Deposit Payment recorded successfully.")
                    End If
                Catch ex As Exception
                    ' Handle any errors that may have occurred
                    If transaction.Connection IsNot Nothing Then
                        transaction.Rollback()
                    End If
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this Tenant??", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        Dim selectedTenant As String = cboTenants.SelectedItem.ToString()
        Dim tenantID As Integer = Integer.Parse(selectedTenant.Split(":")(0).Trim())
        Dim tenantRow As DataRow = Property_ManagerDataSet.Tenants.Select($"ID = {tenantID}").FirstOrDefault()
        If tenantRow IsNot Nothing Then
            tenantRow.Delete()
            Try
                TenantsTableAdapter.Update(Property_ManagerDataSet.Tenants)
                Property_ManagerDataSet.Tables("Tenants").AcceptChanges()
                MessageBox.Show("Tenant deleted successfully.")
                cboPickProperty.Visible = False
                lblProperty.Visible = False
                TenantsTableAdapter.ClearBeforeFill = True
                TenantsTableAdapter.Fill(Me.Property_ManagerDataSet.Tenants)
                cboTenants.Text = "No tenants found"
                txtSearch.Text = ""
                ClearTextboxes()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        VerifyExit(sender, e, btnExit)
    End Sub

    Private Sub txtRentDue_TextChanged(sender As Object, e As EventArgs)
        'format the rent due text box as date 00/00/0000
        Dim text As String = txtRentDue.Text
        lblInvalidRentDue.Visible = text.Length <> 10
        If text.Length = 3 OrElse text.Length = 6 Then
            If Not text.EndsWith("/") Then
                txtRentDue.Text = text.Insert(text.Length - 1, "/")
                txtRentDue.SelectionStart = txtRentDue.Text.Length
            End If
        End If
    End Sub

    Private Sub cboPickProperty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPickProperty.SelectedIndexChanged
        'collect the rent due value from the selected property as well as the deposit amount from the properties table
        'put these values in the txtRent and txtDeposit text boxes, respectively.
        Dim propertyIndex As Integer = cboPickProperty.SelectedIndex
        Dim propertyRow As DataRow = Property_ManagerDataSet.Properties.Rows(propertyIndex)
        txtRent.Text = propertyRow("Rent").ToString()
        txtDeposit.Text = propertyRow("Deposit").ToString()
        txtRentDue.Text = Date.Today.AddMonths(1).ToString("MM/dd/yyyy")
    End Sub


    Private Sub btnRecordPaymentPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnRecordPaymentPrintReceipt.Click
        'same code as btnRecordPayment_Click, but add code to print a receipt
        ' Validate Amount
        Dim AmountPaid As Integer
        If Not Integer.TryParse(txtAmount.Text, AmountPaid) Then
            MessageBox.Show("Please enter a valid amount.")
            Return
        End If
        ' Validate Payment Type
        If cboPaymentType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a payment type.")
            Return
        End If
        ' Get the selected tenant ID
        Dim selectedTenant As String = cboTenants.SelectedItem.ToString()
        Dim tenantID As Integer = Integer.Parse(selectedTenant.Split(":")(0).Trim())
        ' Get the selected property ID
        Dim tenantRow As DataRow = Property_ManagerDataSet.Tenants.Select($"ID = {tenantID}").FirstOrDefault()
        Dim propertyID As Integer = Integer.Parse(tenantRow("PropertyID").ToString())
        'Add one month to the DueDate value and store it back in the tenants table
        Dim DueDate As Date = Date.Parse(tenantRow("RentDue").ToString())
        Dim NewDueDate As Date = DueDate.AddMonths(1)
        tenantRow("RentDue") = NewDueDate.ToString("MM/dd/yyyy")
        Try
            TenantsTableAdapter.Update(Property_ManagerDataSet.Tenants)
            Property_ManagerDataSet.Tables("Tenants").AcceptChanges()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
        ' Define the connection string
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()
            Dim transaction As OleDb.OleDbTransaction = connection.BeginTransaction()
            Try
                ' Create a command object
                Dim command As New OleDb.OleDbCommand("INSERT INTO Payments (PaymentDate, PaymentType, PaymentIDNumber, Amount, Tenant, Property, TakenBy, Notes) VALUES (?, ?, ?, ?, ?, ?, ?, ?)", connection, transaction)
                ' Add parameters to the command
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentDate", Date.Parse(txtPaymentDate.Text)))
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentType", cboPaymentType.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("PaymentIDNumber", txtPaymentIDNumber.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Amount", AmountPaid))
                command.Parameters.Add(New OleDb.OleDbParameter("Tenant", tenantID))
                command.Parameters.Add(New OleDb.OleDbParameter("Property", propertyID))
                command.Parameters.Add(New OleDb.OleDbParameter("TakenBy", User))
                command.Parameters.Add(New OleDb.OleDbParameter("Notes", txtNotes.Text))
                Try
                    ' Execute the command
                    command.ExecuteNonQuery()
                    transaction.Commit()
                    PaymentsTableAdapter.Update(Property_ManagerDataSet.Payments)
                    Property_ManagerDataSet.Tables("Payments").AcceptChanges()
                    MessageBox.Show("Payment recorded successfully.")
                Catch ex As Exception
                    ' Handle any errors that may have occurred
                    If transaction.Connection IsNot Nothing Then
                        transaction.Rollback()
                    End If
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            Finally
                ' Ensure the connection is closed
                'collect the max payment id from the payments table and assign it to PaymentID

                Dim command As New OleDb.OleDbCommand("SELECT MAX(ID) FROM Payments", connection)
                Dim adapter As New OleDb.OleDbDataAdapter(command)
                Try
                    paymentID = command.ExecuteScalar()
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try

                connection.Close()
            End Try
        End Using

        ' Create a PrintDocument object and handle its PrintPage event
        Dim printDocument As New Printing.PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintReceipt

        ' Create a PrintPreviewDialog object and set its Document property
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument

        ' Show the print preview dialog
        printPreviewDialog.ShowDialog()

        Me.Close()
    End Sub

    Private Sub PrintReceipt(sender As Object, e As Printing.PrintPageEventArgs)
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
                                       $"Phone: {phone} Fax: {fax}" & Environment.NewLine & Environment.NewLine &
        "Receipt No: 1001" & PaymentID
        ' Print the receipt with Tenant Name, Payment Date, Payment Type, Amount Paid, and Notes
        Dim tenantName As String = txtFName.Text & " " & txtLName.Text
        Dim paymentDate As Date = DateTime.ParseExact(txtPaymentDate.Text, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture).Date
        Dim paymentType As String = cboPaymentType.Text
        Dim amountPaid As String = Convert.ToDecimal(txtAmount.Text).ToString("C")
        Dim notes As String = txtNotes.Text

        Dim receipt As String = $"Tenant Name: {tenantName}" & Environment.NewLine &
                                $"Payment Date: {paymentDate}" & Environment.NewLine &
                                $"Payment Type: {paymentType}" & Environment.NewLine &
                                $"Amount Paid: {amountPaid}" & Environment.NewLine &
                                $"Notes: {notes}"

        ' Draw the company details and receipt on the print document
        e.Graphics.DrawString(companyDetails, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, New PointF(100, 50))
        e.Graphics.DrawString(receipt, New Font("Arial", 12), Brushes.Black, New PointF(100, 250))

        ' Draw the signature line at the bottom of the receipt
        e.Graphics.DrawString("Signature: _______________________", New Font("Arial", 12), Brushes.Black, New PointF(100, 500))
    End Sub

End Class