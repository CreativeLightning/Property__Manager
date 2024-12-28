Imports System.Windows.Forms

Public Class frmLogin
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db\Property_Manager.accdb"
    Private UsersTableAdapter As New Property_ManagerDataSetTableAdapters.UsersTableAdapter()
    Public Property Property_ManagerDataSet As New Property_ManagerDataSet()

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial state of the form
        Me.Text = "Login Form"
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Initialize any controls or variables
        txtUsername.Text = String.Empty
        txtPassword.Text = String.Empty

        ' Optionally, set focus to the username textbox
        txtUsername.Focus()

        ' Fill the Users table
        Me.UsersTableAdapter.Fill(Me.Property_ManagerDataSet.Users)

        ' Check if there is only one user in the table
        If Me.Property_ManagerDataSet.Users.Count = 1 Then
            Dim frmSetupUser As New frmSetupUser()
            frmSetupUser.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim userRow As Property_ManagerDataSet.UsersRow = Me.Property_ManagerDataSet.Users.
           Where(Function(u) u.Username = username AndAlso u.Password = password).FirstOrDefault()

        If userRow IsNot Nothing Then
            User = userRow.ID
            Dim form1 As New Form1()
            form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Check if there are any other open forms
        If Application.OpenForms.Count = 0 Then
            Application.Exit()
        End If
    End Sub

End Class
