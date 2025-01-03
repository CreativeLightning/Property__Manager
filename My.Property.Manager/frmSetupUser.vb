Public Class frmSetupUser
    Private UsersTableAdapter As New Property_ManagerDataSetTableAdapters.UsersTableAdapter()
    Public Property Property_ManagerDataSet As New Property_ManagerDataSet()
    Private Sub frmSetupUser_Shown(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InsertUser()
        If txtPassword.Text <> txtPassword2.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If
        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters.")
            Return
        End If
        If txtUsername.Text.Length < 5 Then
            MessageBox.Show("Username must be at least 5 characters.")
            Return
        End If
        Try
            Dim newRow As Property_ManagerDataSet.UsersRow = Property_ManagerDataSet.Users.NewUsersRow()
            newRow.Username = txtUsername.Text
            newRow.Password = txtPassword.Text

            newRow.Admin = True
            Property_ManagerDataSet.Users.AddUsersRow(newRow)
            UsersTableAdapter.Update(Property_ManagerDataSet.Users)
            MsgBox("Please login with your new credentials.")
            frmLogin.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error inserting user: " & ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        InsertUser()
    End Sub

End Class
