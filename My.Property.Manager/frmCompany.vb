Imports System.Data.OleDb

Public Class frmCompany
    Private CompanyTableAdapter As New OleDbDataAdapter()
    Private PropertyDataSet As New DataSet()

    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If HelpMessages Then
            ' Show a message box
            MessageBox.Show("This form allows you to edit the company information.  Click the Save button to save changes. THIS INFORMATION WILL DISPLAY ON RECEIPTS AND REPORTS.", "Company Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        'format phone number as (xxx) xxx-xxxx
        Dim numericText As String = New String(txtPhone.Text.Where(AddressOf Char.IsDigit).ToArray())
        Dim formattedText As String = txtPhone.Text

        If numericText.Length >= 4 Then
            formattedText = "(" & numericText.Substring(0, 3) & ") " & numericText.Substring(3)
        End If

        If numericText.Length >= 7 Then
            formattedText = formattedText.Substring(0, 9) & "-" & numericText.Substring(6)
        End If

        txtPhone.Text = formattedText
        txtPhone.SelectionStart = txtPhone.Text.Length
    End Sub

    Private Sub txtFax_TextChanged(sender As Object, e As EventArgs) Handles txtFax.TextChanged
        'format phone number as (xxx) xxx-xxxx
        Dim numericText As String = New String(txtFax.Text.Where(AddressOf Char.IsDigit).ToArray())
        Dim formattedText As String = txtFax.Text
        If numericText.Length >= 4 Then
            formattedText = "(" & numericText.Substring(0, 3) & ") " & numericText.Substring(3)
        End If
        If numericText.Length >= 7 Then
            formattedText = formattedText.Substring(0, 9) & "-" & numericText.Substring(6)
        End If
        txtFax.Text = formattedText
        txtFax.SelectionStart = txtFax.Text.Length
    End Sub
End Class