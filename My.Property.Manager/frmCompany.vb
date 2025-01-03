Imports System.Data.OleDb

Public Class frmCompany
    Private CompanyTableAdapter As New OleDbDataAdapter()
    Private PropertyDataSet As New DataSet()

    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand("SELECT * FROM Company", connection)
        CompanyTableAdapter.SelectCommand = command

        connection.Open()
        CompanyTableAdapter.Fill(PropertyDataSet, "Company")
        txtCompany.Text = PropertyDataSet.Tables("Company").Rows(0)("Company").ToString()
        txtAddress.Text = PropertyDataSet.Tables("Company").Rows(0)("Address").ToString()
        txtAddress2.Text = PropertyDataSet.Tables("Company").Rows(0)("Address2").ToString()
        txtCity.Text = PropertyDataSet.Tables("Company").Rows(0)("City").ToString()
        txtState.Text = PropertyDataSet.Tables("Company").Rows(0)("State").ToString()
        txtZip.Text = PropertyDataSet.Tables("Company").Rows(0)("Zip").ToString()
        txtPhone.Text = PropertyDataSet.Tables("Company").Rows(0)("Phone").ToString()
        txtFax.Text = PropertyDataSet.Tables("Company").Rows(0)("Fax").ToString()
        txtNotes.Text = PropertyDataSet.Tables("Company").Rows(0)("Notes").ToString()
        connection.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCompany.Text = "" Then
            MsgBox("Company Name is required.", MsgBoxStyle.Exclamation, "Save Company")
            Exit Sub
        End If
        If txtAddress.Text = "" Then
            MsgBox("Address is required.", MsgBoxStyle.Exclamation, "Save Company")
            Exit Sub
        End If
        If txtCity.Text = "" Then
            MsgBox("City is required.", MsgBoxStyle.Exclamation, "Save Company")
            Exit Sub
        End If
        If txtState.Text = "" Then
            MsgBox("State is required.", MsgBoxStyle.Exclamation, "Save Company")
            Exit Sub
        End If
        If txtZip.Text = "" Then
            MsgBox("Zip Code is required.", MsgBoxStyle.Exclamation, "Save Company")
            Exit Sub
        End If
        If txtPhone.Text = "" Then
            MsgBox("Phone Number is required.", MsgBoxStyle.Exclamation, "Save Company")
            Exit Sub
        End If

        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand("UPDATE Company SET Company = @CompanyName, Address = @Address, Address2 = @Address2, City = @City, State = @State, Zip = @Zip, Phone = @Phone, Fax = @Fax, Notes = @Notes WHERE ID = @ID", connection)
        command.Parameters.AddWithValue("@CompanyName", txtCompany.Text)
        command.Parameters.AddWithValue("@Address", txtAddress.Text)
        command.Parameters.AddWithValue("@Address2", txtAddress2.Text)
        command.Parameters.AddWithValue("@City", txtCity.Text)
        command.Parameters.AddWithValue("@State", txtState.Text)
        command.Parameters.AddWithValue("@Zip", txtZip.Text)
        command.Parameters.AddWithValue("@Phone", txtPhone.Text)
        command.Parameters.AddWithValue("@Fax", txtFax.Text)
        command.Parameters.AddWithValue("@Notes", txtNotes.Text)
        command.Parameters.AddWithValue("@ID", CompanyID)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        End Try
        connection.Close()

        ' Refresh the dataset to reflect changes
        PropertyDataSet.Tables("Company").Clear()
        CompanyTableAdapter.Fill(PropertyDataSet, "Company")
        If HelpMessages Then
            ' Show a message box
            MessageBox.Show("Company information saved.", "Save Company", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub
End Class