Imports System.Data.OleDb

Public Class frmUsers
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load users into combobox
        Using Conn As OleDbConnection = New OleDbConnection(connectionString)
            Conn.Open()
            Dim SQL As String = "SELECT Username FROM Users"
            Using cmd As OleDbCommand = New OleDbCommand(SQL, Conn)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr("Username") <> "CreativeLightning" Then
                            cboUsers.Items.Add(dr("Username"))
                        End If
                    End While
                End Using
            End Using
        End Using
        cboUsers.SelectedIndex = 0
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'bring up message box to confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            'delete user
            Using Conn As OleDbConnection = New OleDbConnection(connectionString)
                Conn.Open()
                Dim SQL As String = "DELETE FROM Users WHERE Username = @Username"
                Using cmd As OleDbCommand = New OleDbCommand(SQL, Conn)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub cboUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsers.SelectedIndexChanged
        If cboUsers.SelectedIndex = 0 Then
            btnDelete.Enabled = False
            btnSave.Enabled = False
        Else
            btnDelete.Enabled = True
            btnSave.Enabled = True
        End If
        'load user info into textboxes
        Using Conn As OleDbConnection = New OleDbConnection(connectionString)
            Conn.Open()
            Dim SQL As String = "SELECT * FROM Users WHERE Username = @Username"
            Using cmd As OleDbCommand = New OleDbCommand(SQL, Conn)
                cmd.Parameters.AddWithValue("@Username", cboUsers.SelectedItem)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    If dr.Read Then
                        If dr("Phone") Is DBNull.Value Then
                            txtPhone.Clear()
                        Else
                            txtPhone.Text = dr("Phone")
                        End If
                        If dr("FName") Is DBNull.Value Then
                            txtFName.Clear()
                        Else
                            txtFName.Text = dr("FName")
                        End If
                        If dr("LName") Is DBNull.Value Then
                            txtLName.Clear()
                        Else
                            txtLName.Text = dr("LName")
                        End If
                        txtUsername.Text = dr("Username")
                        txtPassword.Text = dr("Password")

                        chkAdmin.Checked = dr("Admin")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'if txtpassword is not empty then compare it to txtpassword2, if they are not the same then show message box and exit sub
        'if password is empty then do not update password in database need two routines one for updating password and one for not updating password
        If txtPassword.Text <> txtPassword2.Text Then
            MessageBox.Show("Passwords do not match.")
            Exit Sub
        End If
        'update user info
        'if password is empty then do not update password in database
        If txtPassword.Text Or txtPassword2.Text = "" Then
            Using Conn As OleDbConnection = New OleDbConnection(connectionString)
                Conn.Open()
                Dim SQL As String = "UPDATE Users SET Phone = @Phone, FName = @FName, LName = @LName, Username = @Username, Admin = @Admin WHERE Username = @Username"
                Using cmd As OleDbCommand = New OleDbCommand(SQL, Conn)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@FName", txtFName.Text)
                    cmd.Parameters.AddWithValue("@LName", txtLName.Text)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Admin", chkAdmin.Checked)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Else
            Using Conn As OleDbConnection = New OleDbConnection(connectionString)
                Conn.Open()
                Dim SQL As String = "UPDATE Users SET Phone = @Phone, FName = @FName, LName = @LName, Username = @Username, Password = @Password, Admin = @Admin WHERE Username = @Username"
                Using cmd As OleDbCommand = New OleDbCommand(SQL, Conn)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@FName", txtFName.Text)
                    cmd.Parameters.AddWithValue("@LName", txtLName.Text)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@Admin", chkAdmin.Checked)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ClearTextBoxes()
        txtUsername.Focus()
        btnSave.Visible = False
        btnDelete.Visible = False
        btnSaveNew.Visible = True
    End Sub
    Private Sub ClearTextBoxes()
        txtUsername.Clear()
        txtPassword.Clear()
        txtPassword2.Clear()
        txtPhone.Clear()
        txtFName.Clear()
        txtLName.Clear()
        chkAdmin.Checked = False
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        'save new user
        'if txtpassword is empty then show message box and exit sub
        If txtPassword.Text = "" Then
            MessageBox.Show("Password cannot be empty.")
            Exit Sub
        End If
        If txtPassword.Text <> txtPassword2.Text Then
            MessageBox.Show("Passwords do not match.")
            Exit Sub
        End If
        Using Conn As OleDbConnection = New OleDbConnection(connectionString)
            Conn.Open()
            Dim SQL As String = "INSERT INTO Users (Phone, FName, LName, Username, Password, Admin) VALUES (@Phone, @FName, @LName, @Username, @Password, @Admin)"
            Using cmd As OleDbCommand = New OleDbCommand(SQL, Conn)
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@FName", txtFName.Text)
                cmd.Parameters.AddWithValue("@LName", txtLName.Text)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                cmd.Parameters.AddWithValue("@Admin", chkAdmin.Checked)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        ClearTextBoxes()
        cboUsers.Items.Clear()
        btnSaveNew.Visible = False
        btnSave.Visible = True
        btnDelete.Visible = True
        Using Conn As OleDbConnection = New OleDbConnection(connectionString)
            Conn.Open()
            Dim SQL As String = "SELECT Username FROM Users"
            Using cmd As OleDbCommand = New OleDbCommand(SQL, Conn)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr("Username") <> "CreativeLightning" Then
                            cboUsers.Items.Add(dr("Username"))
                        End If
                    End While
                End Using
            End Using
        End Using
        cboUsers.SelectedIndex = 0
    End Sub
End Class