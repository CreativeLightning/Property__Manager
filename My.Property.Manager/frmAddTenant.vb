Imports System.Windows.Forms

Public Class frmAddTenant
    Private TenantsTableAdapter As New Property_ManagerDataSetTableAdapters.TenantsTableAdapter()
    Public Property Property_ManagerDataSet As New Property_ManagerDataSet()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmAddTenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the 'Property_ManagerDataSet.Tenants' table
        Me.TenantsTableAdapter.Fill(Me.Property_ManagerDataSet.Tenants)
    End Sub

    Private Sub DOB_TextChanged(sender As Object, e As EventArgs) Handles DOB.TextChanged
        Dim text As String = DOB.Text
        If text.Length = 2 OrElse text.Length = 5 Then
            If Not text.EndsWith("/") Then
                DOB.Text = text & "/"
                DOB.SelectionStart = DOB.Text.Length
            End If
        End If
    End Sub

    Private Sub SSN_TextChanged(sender As Object, e As EventArgs) Handles SSN.TextChanged
        Dim text As String = SSN.Text.Replace("-", "")
        If text.Length > 3 Then
            text = text.Insert(3, "-")
        End If
        If text.Length > 6 Then
            text = text.Insert(6, "-")
        End If
        If text.Length <= 11 Then
            lblInvalidSSN.Visible = False
        End If
        If text.Length > 11 Then
            lblInvalidSSN.Visible = True
            lblInvalidSSN.Text = "Too Many Numbers"
        End If
        SSN.Text = text
        SSN.SelectionStart = text.Length
    End Sub

    Private Sub Phone_TextChanged(sender As Object, e As EventArgs) Handles Phone.TextChanged
        FormatPhoneNumber(Phone)
    End Sub

    Private Sub Phone2_TextChanged(sender As Object, e As EventArgs) Handles Phone2.TextChanged
        FormatPhoneNumber(Phone2)
    End Sub

    Private Sub Phone3_TextChanged(sender As Object, e As EventArgs) Handles Phone3.TextChanged
        FormatPhoneNumber(Phone3)
    End Sub

    Private Sub FormatPhoneNumber(textBox As TextBox)
        Dim text As String = textBox.Text.Replace("-", "")
        If text.Length > 3 Then
            text = text.Insert(3, "-")
        End If
        If text.Length > 7 Then
            text = text.Insert(7, "-")
        End If
        If text.Length <= 12 Then
            lblInvalidPhone.Visible = False
        End If
        If text.Length > 12 Then
            lblInvalidPhone.Visible = True
            lblInvalidPhone.Text = "Too Many Numbers"
        End If
        textBox.Text = text
        textBox.SelectionStart = text.Length ' Move cursor to the end
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        ' Validate Fname
        If String.IsNullOrEmpty(FName.Text) Then
            MessageBox.Show("Please enter a valid First Name.")
            Return
        End If

        ' Validate Lname
        If String.IsNullOrEmpty(LName.Text) Then
            MessageBox.Show("Please enter a valid Last Name.")
            Return
        End If

        ' Validate SSN
        Dim ssnValue As String = RemoveNonNumeric(SSN.Text)
        If String.IsNullOrEmpty(ssnValue) OrElse Not IsNumeric(ssnValue) Then
            MessageBox.Show("Please enter a valid SSN.")
            Return
        End If

        ' Validate Phone
        Dim phoneValue As String = RemoveNonNumeric(Phone.Text)
        If Not String.IsNullOrEmpty(phoneValue) AndAlso Not IsNumeric(phoneValue) Then
            MessageBox.Show("Please enter a valid Phone number.")
            Return
        End If

        ' Validate Phone2
        Dim phone2Value As String = RemoveNonNumeric(Phone2.Text)
        If Not String.IsNullOrEmpty(phone2Value) AndAlso Not IsNumeric(phone2Value) Then
            MessageBox.Show("Please enter a valid Phone2 number.")
            Return
        End If

        ' Validate Phone3
        Dim phone3Value As String = RemoveNonNumeric(Phone3.Text)
        If Not String.IsNullOrEmpty(phone3Value) AndAlso Not IsNumeric(phone3Value) Then
            MessageBox.Show("Please enter a valid Phone3 number.")
            Return
        End If

        ' Validate DOB
        Dim dobValue As Date
        If Not Date.TryParse(DOB.Text, dobValue) Then
            MessageBox.Show("Please enter a valid Date of Birth in the format MM/DD/YYYY.")
            Return
        End If

        ' Set additional fields
        Dim notesValue As String = Notes.Text
        Dim activeValue As String = "y"
        Dim propertyIDValue As String = "1" ' or some default value
        Dim userIDValue As String = "1" ' or some default value

        ' Define the connection string
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db\Property_Manager.accdb"

        ' Create a connection object
        Using connection As New OleDb.OleDbConnection(connectionString)
            connection.Open()
            Dim transaction As OleDb.OleDbTransaction = connection.BeginTransaction()

            Try
                ' Create a command object
                Dim command As New OleDb.OleDbCommand("INSERT INTO Tenants (Fname, Lname, SSN, Phone, Phone2, Phone3, DOB, Notes, Active, PropertyID, UserID) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", connection, transaction)

                ' Add parameters to the command
                command.Parameters.Add(New OleDb.OleDbParameter("Fname", FName.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Lname", LName.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("SSN", SSN.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone", Phone.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone2", Phone2.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Phone3", Phone3.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("DOB", DOB.Text))
                command.Parameters.Add(New OleDb.OleDbParameter("Notes", Notes.Text))
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

    Private Function RemoveNonNumeric(input As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(input, "[^\d]", "")
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class