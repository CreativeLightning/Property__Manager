Public Class frmEmployees
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the 'Property_ManagerDataSet.Employees' table
        Me.EmployeesTableAdapter.Fill(Me.Property_ManagerDataSet.Employees)

        ' Populate the cboEmployees ComboBox
        PopulateEmployeesComboBox()
        If cboEmployees.Items.Count > 0 Then
            cboEmployees.SelectedIndex = 0
        End If
    End Sub

    Private Sub PopulateEmployeesComboBox()

        ' Create a connection object
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()

            ' Create a command object
            Dim command As New OleDb.OleDbCommand("SELECT Fname, Lname FROM Employees", connection)

            ' Execute the command and read the data
            Using reader As OleDb.OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim fullName As String = reader("Fname").ToString() & " " & reader("Lname").ToString()
                    cboEmployees.Items.Add(fullName)
                End While
            End Using
        End Using
    End Sub

    Private Sub cboEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmployees.SelectedIndexChanged
        btnSave.Visible = True
        If cboEmployees.SelectedIndex = 0 Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
        If cboEmployees.SelectedIndex = 0 Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
        ' Create a connection object
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()

            ' Get the selected employee's full name
            Dim selectedFullName As String = cboEmployees.SelectedItem.ToString()
            Dim names() As String = selectedFullName.Split(" "c)
            Dim fName As String = names(0)
            Dim lName As String = names(1)

            ' Create a command object to retrieve the employee's information
            Dim command As New OleDb.OleDbCommand("SELECT * FROM Employees WHERE Fname = ? AND Lname = ?", connection)
            command.Parameters.AddWithValue("@Fname", fName)
            command.Parameters.AddWithValue("@Lname", lName)

            ' Execute the command and read the data
            Using reader As OleDb.OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Populate text boxes with the retrieved data
                    txtFName.Text = reader("Fname").ToString()
                    txtLName.Text = reader("Lname").ToString()
                    txtAddress.Text = reader("Address").ToString()
                    txtAddress2.Text = reader("Address2").ToString()
                    txtCity.Text = reader("City").ToString()
                    txtZip.Text = reader("Zip").ToString()
                    txtSSN.Text = reader("SSN").ToString()
                    txtPhone.Text = reader("Phone").ToString()
                    txtPhone2.Text = reader("Phone2").ToString()
                    txtPhone3.Text = reader("Phone3").ToString()
                    txtStartDate.Text = reader("StartDate").ToString()
                    txtEndDate.Text = reader("EndDate").ToString()
                    chkInactive.Checked = (reader("Active").ToString().ToLower() = "n")
                End If
            End Using
        End Using

    End Sub
    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        txtFName.Text = txtFName.Text.Replace(" ", "")
        txtFName.SelectionStart = txtFName.Text.Length ' Set the cursor to the end of the text
    End Sub

    Private Sub txtLName_TextChanged(sender As Object, e As EventArgs) Handles txtLName.TextChanged
        txtLName.Text = txtLName.Text.Replace(" ", "")
        txtLName.SelectionStart = txtLName.Text.Length ' Set the cursor to the end of the text
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Create a connection object
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()

            ' Get the selected employee's full name
            Dim selectedFullName As String = cboEmployees.SelectedItem.ToString()
            Dim names() As String = selectedFullName.Split(" "c)
            Dim fName As String = names(0)
            Dim lName As String = names(1)

            ' Create a command object to update the employee's information
            Dim command As New OleDb.OleDbCommand("UPDATE Employees SET Fname = ?, Lname = ?, Address = ?, Address2 = ?, City = ?, Zip = ?, SSN = ?, Phone = ?, Phone2 = ?, Phone3 = ?, StartDate = ?, EndDate = ?, Active = ? WHERE Fname = ? AND Lname = ?", connection)
            command.Parameters.AddWithValue("@Fname", txtFName.Text)
            command.Parameters.AddWithValue("@Lname", txtLName.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Address2", txtAddress2.Text)
            command.Parameters.AddWithValue("@City", txtCity.Text)
            command.Parameters.AddWithValue("@Zip", txtZip.Text)
            command.Parameters.AddWithValue("@SSN", txtSSN.Text)
            command.Parameters.AddWithValue("@Phone", txtPhone.Text)
            command.Parameters.AddWithValue("@Phone2", txtPhone2.Text)
            command.Parameters.AddWithValue("@Phone3", txtPhone3.Text)
            command.Parameters.AddWithValue("@StartDate", txtStartDate.Text)
            command.Parameters.AddWithValue("@EndDate", txtEndDate.Text)
            command.Parameters.AddWithValue("@Active", If(chkInactive.Checked, "n", "y"))
            command.Parameters.AddWithValue("@Fname", txtFName.Text)
            command.Parameters.AddWithValue("@Lname", txtLName.Text)

            ' Execute the command
            command.ExecuteNonQuery()
        End Using

        ' Optionally, refresh the data in the ComboBox and text boxes
        'PopulateEmployeesComboBox()
        ClearTextBoxes()
    End Sub
    Private Sub ClearTextBoxes()
        txtFName.Text = ""
        txtLName.Text = ""
        txtAddress.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtZip.Text = ""
        txtSSN.Text = ""
        txtPhone.Text = ""
        txtPhone2.Text = ""
        txtPhone3.Text = ""
        txtStartDate.Text = ""
        txtEndDate.Text = ""
        chkInactive.Checked = False
    End Sub
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        btnSave.Visible = False
        btnSaveNew.Visible = True
        btnCanel.Visible = True
        cboEmployees.Visible = False
        cboEmployees.Items.Clear()
        ClearTextBoxes()
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        If txtFName.Text = "" Then
            MessageBox.Show("First Name is required")
            Exit Sub
        End If
        If txtLName.Text = "" Then
            MessageBox.Show("Last Name is required")
            Exit Sub
        End If
        If txtAddress.Text = "" Then
            MessageBox.Show("Address is required")
            Exit Sub
        End If
        If txtCity.Text = "" Then
            MessageBox.Show("City is required")
            Exit Sub
        End If
        If txtZip.Text = "" Then
            MessageBox.Show("Zip is required")
            Exit Sub
        End If
        If txtSSN.Text = "" Then
            MessageBox.Show("SSN is required")
            Exit Sub
        End If
        If txtPhone.Text = "" Then
            MessageBox.Show("Phone is required")
            Exit Sub
        End If
        If txtStartDate.Text = "" Then
            MessageBox.Show("Start Date is required")
            txtStartDate.Text = Date.Today.ToString("MM/dd/yyyy")
            Exit Sub
        End If

        ' Create a connection object
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()

            ' Create a command object to insert a new employee
            Dim command As New OleDb.OleDbCommand("INSERT INTO Employees (Fname, Lname, Address, Address2, City, Zip, SSN, Phone, Phone2, Phone3, StartDate, EndDate, Active) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", connection)
            command.Parameters.AddWithValue("@Fname", txtFName.Text)
            command.Parameters.AddWithValue("@Lname", txtLName.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Address2", txtAddress2.Text)
            command.Parameters.AddWithValue("@City", txtCity.Text)
            command.Parameters.AddWithValue("@Zip", txtZip.Text)
            command.Parameters.AddWithValue("@SSN", txtSSN.Text)
            command.Parameters.AddWithValue("@Phone", txtPhone.Text)
            command.Parameters.AddWithValue("@Phone2", txtPhone2.Text)
            command.Parameters.AddWithValue("@Phone3", txtPhone3.Text)
            command.Parameters.AddWithValue("@StartDate", txtStartDate.Text)
            command.Parameters.AddWithValue("@EndDate", txtEndDate.Text)
            command.Parameters.AddWithValue("@Active", If(chkInactive.Checked, "n", "y"))

            ' Try and execute the command, if successful and HelpMessages is True, show a message box "Employee Added"
            Try
                command.ExecuteNonQuery()
                If HelpMessages = True Then
                    MessageBox.Show("Employee Added")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        btnSaveNew.Visible = False
        btnCanel.Visible = False
        cboEmployees.Visible = True
        ClearTextBoxes()
        ' Optionally, refresh the data in the ComboBox and text boxes
        PopulateEmployeesComboBox()
    End Sub

    Private Sub btnCanel_Click(sender As Object, e As EventArgs) Handles btnCanel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel adding a new employee?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            btnSaveNew.Visible = False
            btnCanel.Visible = False
            cboEmployees.Visible = True
            ClearTextBoxes()
            cboEmployees.Items.Clear()
            PopulateEmployeesComboBox()
            If cboEmployees.Items.Count > 0 Then
                cboEmployees.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' Create a connection object
            Using connection As New OleDb.OleDbConnection(connectionString)
                connection.Open()

                ' Get the selected employee's full name
                Dim selectedFullName As String = cboEmployees.SelectedItem.ToString()
                Dim names() As String = selectedFullName.Split(" "c)
                Dim fName As String = names(0)
                Dim lName As String = names(1)

                ' Create a command object to delete the employee
                Dim command As New OleDb.OleDbCommand("DELETE FROM Employees WHERE Fname = ? AND Lname = ?", connection)
                command.Parameters.AddWithValue("@Fname", fName)
                command.Parameters.AddWithValue("@Lname", lName)

                ' Execute the command
                command.ExecuteNonQuery()
            End Using

            ' Clear the text boxes and refresh the ComboBox
            ClearTextBoxes()
            cboEmployees.Items.Clear()
            PopulateEmployeesComboBox()
            If cboEmployees.Items.Count > 0 Then
                cboEmployees.SelectedIndex = 0
            End If
        End If
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

    Private Sub FormatDateTextBox(textBox As TextBox, lblInvalidDate As Label)
        ' Remove any non-numeric characters
        Dim digitsOnly As String = New String(textBox.Text.Where(Function(c) Char.IsDigit(c)).ToArray())


        ' Show or hide the lblInvalidDate label based on the length of digitsOnly
        lblInvalidDate.Visible = digitsOnly.Length <> 8

        ' Format the date as 00/00/0000
        Dim formattedDate As String = ""
        If digitsOnly.Length > 0 Then
            formattedDate = digitsOnly.Substring(0, Math.Min(2, digitsOnly.Length))
        End If
        If digitsOnly.Length > 2 Then
            formattedDate &= "/" & digitsOnly.Substring(2, Math.Min(2, digitsOnly.Length - 2))
        End If
        If digitsOnly.Length > 4 Then
            formattedDate &= "/" & digitsOnly.Substring(4, Math.Min(4, digitsOnly.Length - 4))
        End If
        If digitsOnly.Length > 8 Then
            formattedDate &= digitsOnly.Substring(8)
        End If

        ' Update the text box with the formatted date
        textBox.Text = formattedDate
        textBox.SelectionStart = textBox.Text.Length ' Set the cursor to the end of the text
    End Sub

    Private Sub txtStartDate_TextChanged(sender As Object, e As EventArgs) Handles txtStartDate.TextChanged
        FormatDateTextBox(txtStartDate, lblInvalidDate)
    End Sub

    Private Sub txtEndDate_TextChanged(sender As Object, e As EventArgs) Handles txtEndDate.TextChanged
        FormatDateTextBox(txtEndDate, lblInvalidDate)
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

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit")
        If response = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class