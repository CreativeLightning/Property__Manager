Imports System.Data.OleDb

Public Class frmVendors
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmVendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill cboVendor with Vendor names from the Vendors table
        Using conn As New OleDbConnection(connectionString)
            Dim commandString As String = "SELECT VendorName FROM Vendors"
            Dim command As New OleDbCommand(commandString, conn)
            conn.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            While reader.Read()
                cboVendors.Items.Add(reader("VendorName"))
            End While
            reader.Close()
            conn.Close()
        End Using
        cboVendors.SelectedIndex = 0
    End Sub

    Private Sub cboVendors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendors.SelectedIndexChanged
        'Fill the textboxes with the selected Vendor's information
        Using conn As New OleDbConnection(connectionString)
            Dim commandString As String = "SELECT * FROM Vendors WHERE VendorName = @VendorName"
            Dim command As New OleDbCommand(commandString, conn)
            command.Parameters.AddWithValue("@VendorName", cboVendors.SelectedItem)
            conn.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            reader.Read()
            If IsDBNull(reader("VendorName")) OrElse reader("VendorName") = "" Then
                txtVendorName.Text = ""
            Else
                txtVendorName.Text = reader("VendorName")
            End If
            If IsDBNull(reader("Address")) OrElse reader("Address") = "" Then
                txtAddress.Text = ""
            Else
                txtAddress.Text = reader("Address")
            End If
            If IsDBNull(reader("Address2")) OrElse reader("Address2") = "" Then
                txtAddress2.Text = ""
            Else
                txtAddress2.Text = reader("Address2")
            End If
            If IsDBNull(reader("City")) OrElse reader("City") = "" Then
                txtCity.Text = ""
            Else
                txtCity.Text = reader("City")
            End If
            If IsDBNull(reader("State")) OrElse reader("State") = "" Then
                txtState.Text = ""
            Else
                txtState.Text = reader("State")
            End If
            If IsDBNull(reader("Zip")) OrElse reader("Zip") = "" Then
                txtZip.Text = ""
            Else
                txtZip.Text = reader("Zip")
            End If
            If IsDBNull(reader("Phone")) OrElse reader("Phone") = "" Then
                txtPhone.Text = ""
            Else
                txtPhone.Text = reader("Phone")
            End If
            If IsDBNull(reader("Phone2")) OrElse reader("Phone2") = "" Then
                txtPhone2.Text = ""
            Else
                txtPhone2.Text = reader("Phone2")
            End If
            If IsDBNull(reader("Fax")) OrElse reader("Fax") = "" Then
                txtFax.Text = ""
            Else
                txtFax.Text = reader("Fax")
            End If
            If IsDBNull(reader("Notes")) OrElse reader("Notes") = "" Then
                txtNotes.Text = ""
            Else
                txtNotes.Text = reader("Notes")
            End If
            If IsDBNull(reader("TaxID")) OrElse reader("TaxID") = "" Then
                txtTaxID.Text = ""
            Else
                txtTaxID.Text = reader("TaxID")
            End If
            chkVendorType.Checked = reader("VendorType")
            reader.Close()
            conn.Close()
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Update the selected Vendor's information
        Using conn As New OleDbConnection(connectionString)
            Dim commandString As String = "UPDATE Vendors SET VendorName = @VendorName, Address = @Address, Address2 = @Address2, City = @City, State = @State, Zip = @Zip, Phone = @Phone, Phone2 = @Phone2, Fax = @Fax, Notes = @Notes, VendorType = @VendorType, TaxID = @TaxID WHERE VendorName = @VendorName"
            Dim command As New OleDbCommand(commandString, conn)
            command.Parameters.AddWithValue("@VendorName", txtVendorName.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Address2", txtAddress2.Text)
            command.Parameters.AddWithValue("@City", txtCity.Text)
            command.Parameters.AddWithValue("@State", txtState.Text)
            command.Parameters.AddWithValue("@Zip", txtZip.Text)
            command.Parameters.AddWithValue("@Phone", txtPhone.Text)
            command.Parameters.AddWithValue("@Phone2", txtPhone2.Text)
            command.Parameters.AddWithValue("@Fax", txtFax.Text)
            command.Parameters.AddWithValue("@Notes", txtNotes.Text)
            command.Parameters.AddWithValue("@VendorType", chkVendorType.Checked)
            command.Parameters.AddWithValue("@TaxID", txtTaxID.Text)
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
        End Using
        If HelpMessages = True Then
            MsgBox("The Vendor information has been updated.")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Visible = False
        btnSaveNew.Visible = True
        cboVendors.Visible = False
        ClearAll()
    End Sub
    Private Sub ClearAll()
        'Clear all textboxes
        txtVendorName.Text = ""
        txtAddress.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtPhone.Text = ""
        txtPhone2.Text = ""
        txtFax.Text = ""
        txtNotes.Text = ""
        chkVendorType.Checked = False
        lblInvalid.Visible = False
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        If txtVendorName.Text = "" Then
            MsgBox("Please enter a Vendor Name.")
            Exit Sub
        End If
        If txtAddress.Text = "" Then
            MsgBox("Please enter an Address.")
            Exit Sub
        End If
        If txtPhone.Text = "" Then
            MsgBox("Please enter a Phone Number.")
            Exit Sub
        End If
        'Add a new Vendor
        Using conn As New OleDbConnection(connectionString)
            Dim commandString As String = "INSERT INTO Vendors (VendorName, Address, Address2, City, State, Zip, Phone, Phone2, Fax, Notes, VendorType, TaxID) VALUES (@VendorName, @Address, @Address2, @City, @State, @Zip, @Phone, @Phone2, @Fax, @Notes, @VendorType, @TaxID)"
            Dim command As New OleDbCommand(commandString, conn)
            command.Parameters.AddWithValue("@VendorName", txtVendorName.Text)
            command.Parameters.AddWithValue("@Address", txtAddress.Text)
            command.Parameters.AddWithValue("@Address2", txtAddress2.Text)
            command.Parameters.AddWithValue("@City", txtCity.Text)
            command.Parameters.AddWithValue("@State", txtState.Text)
            command.Parameters.AddWithValue("@Zip", txtZip.Text)
            command.Parameters.AddWithValue("@Phone", txtPhone.Text)
            command.Parameters.AddWithValue("@Phone2", txtPhone2.Text)
            command.Parameters.AddWithValue("@Fax", txtFax.Text)
            command.Parameters.AddWithValue("@Notes", txtNotes.Text)
            command.Parameters.AddWithValue("@VendorType", chkVendorType.Checked)
            command.Parameters.AddWithValue("@TaxID", txtTaxID.Text)
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
        End Using
        ClearAll()
        btnSaveNew.Visible = False
        btnSave.Visible = True
        cboVendors.Visible = True
        'Refresh the cboVendors
        cboVendors.Items.Clear()
        Using conn As New OleDbConnection(connectionString)
            Dim commandString As String = "SELECT VendorName FROM Vendors"
            Dim command As New OleDbCommand(commandString, conn)
            conn.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()
            While reader.Read()
                cboVendors.Items.Add(reader("VendorName"))
            End While
            reader.Close()
            conn.Close()
        End Using
        cboVendors.SelectedIndex = 0
        If HelpMessages = True Then
            MsgBox("The new Vendor has been added. If you added this Vendor to create a New Work Order, Click on New Work Order again.")
        End If
    End Sub

    Private Sub FormatPhoneNumber(textBox As TextBox)
        ' Remove any non-numeric characters
        Dim digitsOnly As String = New String(textBox.Text.Where(Function(c) Char.IsDigit(c)).ToArray())


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
        FormatPhoneNumber(txtPhone)
    End Sub

    Private Sub txtPhone2_TextChanged(sender As Object, e As EventArgs) Handles txtPhone2.TextChanged
        FormatPhoneNumber(txtPhone2)
    End Sub

    Private Sub txtFax_TextChanged(sender As Object, e As EventArgs) Handles txtFax.TextChanged
        FormatPhoneNumber(txtFax)
    End Sub
End Class