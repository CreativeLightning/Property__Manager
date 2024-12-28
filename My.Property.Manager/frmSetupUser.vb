Public Class frmSetupUser
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db\Property_Manager.accdb"
    Private UsersTableAdapter As New Property_ManagerDataSetTableAdapters.UsersTableAdapter()
    Public Property Property_ManagerDataSet As New Property_ManagerDataSet()
    Private Sub frmSetupUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial state of the form
        Me.Text = "Setup User"
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub InsertUser()
        Try
            Dim newRow As Property_ManagerDataSet.UsersRow = Property_ManagerDataSet.Users.NewUsersRow()
            newRow.Username = txtUsername.Text
            newRow.Password = txtPassword.Text
            newRow.Fname = ""
            newRow.Lname = ""
            newRow.Address = ""
            newRow.Address2 = ""
            newRow.City = ""
            newRow.State = ""
            newRow.Zip = ""
            newRow.Phone = ""
            newRow.Phone2 = ""
            newRow.Phone3 = ""
            newRow.Notes = ""
            newRow.Admin = True
            Property_ManagerDataSet.Users.AddUsersRow(newRow)
            UsersTableAdapter.Update(Property_ManagerDataSet.Users)
            MessageBox.Show("User inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error inserting user: " & ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        InsertUser()
    End Sub
    Private Sub frmSetupUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Check if there are any other open forms
        If Application.OpenForms.Count = 0 Then
            Application.Exit()
        End If
    End Sub
End Class
