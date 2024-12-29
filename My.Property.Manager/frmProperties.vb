Imports System.Data.OleDb

Public Class frmProperties
    Private Sub frmProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearFields()
        FillBathrooms()
        FillBedrooms()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Public Class Properties
        Public Property StreetNumber As String
        Public Property StreetName As String
        Public Property AptSuiteNumber As String
        Public Property City As String
        Public Property State As String
        Public Property Zip As String
        Public Property Rent As String
        Public Property Deposit As String
        Public Property Parcel As String
        Public Property PurchaseDate As String
        Public Property PurchasePrice As String
        Public Property HomeShortName As String
        Public Property Notes As String
        Public Property Bathrooms As Decimal
        Public Property Bedrooms As Decimal
        Public Property ID As Integer
        Public Property Vacant As Boolean
    End Class

    Private Sub ClearFields()
        txtHomeShortName.Text = ""
        txtStreetNumber.Text = ""
        txtStreetName.Text = ""
        txtAptSuiteNumber.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtRent.Text = ""
        txtDeposit.Text = ""
        txtParcel.Text = ""
        txtPurchaseDate.Text = ""
        txtPurchasePrice.Text = ""
        txtSearch.Text = ""
        txtNotes.Text = ""
        cboPropertyAddress.Text = ""
        cboBathrooms.SelectedIndex = -1
        cboBedrooms.SelectedIndex = -1
    End Sub
    Private Sub FillBathrooms()
        cboBathrooms.Items.Clear()
        For i As Decimal = 1 To 10 Step 0.5
            cboBathrooms.Items.Add(i)
        Next
    End Sub
    Private Sub FillBedrooms()
        cboBedrooms.Items.Clear()
        For i As Integer = 1 To 10
            cboBedrooms.Items.Add(i)
        Next
    End Sub
    Private Function GetPropertiesByStreetName(streetName As String) As List(Of Properties)
        Dim properties As New List(Of Properties)

        ' Replace with your actual database connection and query logic
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT ID, StreetNumber, StreetName, AptSuiteNumber FROM Properties WHERE StreetName LIKE @StreetName"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@StreetName", "%" & streetName & "%")
                connection.Open()
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim prop As New Properties()
                        prop.ID = Convert.ToInt32(reader("ID"))
                        prop.StreetNumber = reader("StreetNumber").ToString()
                        prop.StreetName = reader("StreetName").ToString()
                        prop.AptSuiteNumber = reader("AptSuiteNumber").ToString()
                        properties.Add(prop)
                    End While
                End Using
            End Using
        End Using

        Return properties
    End Function
    Private Function GetSelectedPropertyByID(sender As Object, e As EventArgs) As Properties
        Dim selectedProperty As Properties = Nothing
        Dim selectedID As Integer = CType(cboPropertyAddress.SelectedItem, Object).ID

        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT ID, StreetNumber, StreetName, AptSuiteNumber, City, State, Zip, Rent, Deposit, Parcel, PurchaseDate, PurchasePrice, HomeShortName, Notes, Bathrooms, Bedrooms, Vacant FROM Properties WHERE ID = @ID"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@ID", selectedID)
                connection.Open()
                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        selectedProperty = New Properties()
                        selectedProperty.ID = Convert.ToInt32(reader("ID"))
                        selectedProperty.StreetNumber = reader("StreetNumber").ToString()
                        selectedProperty.StreetName = reader("StreetName").ToString()
                        selectedProperty.AptSuiteNumber = reader("AptSuiteNumber").ToString()
                        selectedProperty.City = reader("City").ToString()
                        selectedProperty.State = reader("State").ToString()
                        selectedProperty.Zip = reader("Zip").ToString()
                        selectedProperty.Rent = reader("Rent").ToString()
                        selectedProperty.Deposit = reader("Deposit").ToString()
                        selectedProperty.Parcel = reader("Parcel").ToString()
                        selectedProperty.PurchaseDate = reader("PurchaseDate").ToString()
                        selectedProperty.PurchasePrice = reader("PurchasePrice").ToString()
                        selectedProperty.HomeShortName = reader("HomeShortName").ToString()
                        selectedProperty.Notes = reader("Notes").ToString()
                        selectedProperty.Bathrooms = Convert.ToDecimal(reader("Bathrooms"))
                        selectedProperty.Bedrooms = Convert.ToDecimal(reader("Bedrooms"))
                        selectedProperty.Vacant = Convert.ToBoolean(reader("Vacant"))
                    End If
                End Using
            End Using
        End Using

        Return selectedProperty
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get the values from the text boxes and combo boxes
        Dim streetNumber As String = txtStreetNumber.Text
        Dim streetName As String = txtStreetName.Text
        Dim aptSuiteNumber As String = txtAptSuiteNumber.Text
        Dim city As String = txtCity.Text
        Dim state As String = txtState.Text
        Dim zip As String = txtZip.Text
        Dim rent As String = txtRent.Text
        Dim deposit As String = txtDeposit.Text
        Dim parcel As String = txtParcel.Text
        Dim purchaseDate As String = txtPurchaseDate.Text
        Dim purchasePrice As String = txtPurchasePrice.Text
        Dim homeShortName As String = txtHomeShortName.Text
        Dim notes As String = txtNotes.Text
        Dim bathrooms As Decimal = Convert.ToDecimal(cboBathrooms.SelectedIndex)
        Dim bedrooms As Integer = Convert.ToDecimal(cboBedrooms.SelectedIndex)
        Dim vacant As Boolean = chkVacant.Checked
        Dim selectedID As Integer = CType(cboPropertyAddress.SelectedItem, Object).ID
        ' Update the database with the new values
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "UPDATE Properties SET StreetNumber = @StreetNumber, StreetName = @StreetName, AptSuiteNumber = @AptSuiteNumber, City = @City, State = @State, Zip = @Zip, Rent = @Rent, Deposit = @Deposit, Parcel = @Parcel, PurchaseDate = @PurchaseDate, PurchasePrice = @PurchasePrice, HomeShortName = @HomeShortName, Notes = @Notes, Bathrooms = @Bathrooms, Bedrooms = @Bedrooms, Vacant = @Vacant WHERE ID = @ID"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@StreetNumber", If(String.IsNullOrEmpty(streetNumber), "N/A", streetNumber))
                command.Parameters.AddWithValue("@StreetName", If(String.IsNullOrEmpty(streetName), "N/A", streetName))
                command.Parameters.AddWithValue("@AptSuiteNumber", If(String.IsNullOrEmpty(aptSuiteNumber), "N/A", aptSuiteNumber))
                command.Parameters.AddWithValue("@City", If(String.IsNullOrEmpty(city), "N/A", city))
                command.Parameters.AddWithValue("@State", If(String.IsNullOrEmpty(state), "N/A", state))
                command.Parameters.AddWithValue("@Zip", If(String.IsNullOrEmpty(zip), "N/A", zip))
                command.Parameters.AddWithValue("@Rent", If(String.IsNullOrEmpty(rent), "0", rent))
                command.Parameters.AddWithValue("@Deposit", If(String.IsNullOrEmpty(deposit), "0", deposit))
                command.Parameters.AddWithValue("@Parcel", If(String.IsNullOrEmpty(parcel), "N/A", parcel))
                command.Parameters.AddWithValue("@PurchaseDate", If(String.IsNullOrEmpty(purchaseDate), "01/01/1900", purchaseDate))
                command.Parameters.AddWithValue("@PurchasePrice", If(String.IsNullOrEmpty(purchasePrice), "0", purchasePrice))
                command.Parameters.AddWithValue("@HomeShortName", If(String.IsNullOrEmpty(homeShortName), "N/A", homeShortName))
                command.Parameters.AddWithValue("@Notes", If(String.IsNullOrEmpty(notes), "N/A", notes))
                command.Parameters.AddWithValue("@Bathrooms", bathrooms)
                command.Parameters.AddWithValue("@Bedrooms", bedrooms)
                command.Parameters.AddWithValue("@Vacant", vacant)
                command.Parameters.AddWithValue("@ID", selectedID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
        ClearFields()
        cboPropertyAddress.Items.Clear()
        ClearFields()
        MessageBox.Show("Property details updated successfully.")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ClearFields()
        cboPropertyAddress.Items.Clear()
        btnSaveNew.Visible = True
        btnCancel.Visible = True
        btnSave.Visible = False
        grpSearch.Visible = False
        ClearFields()
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        ' Get the values from the text boxes and combo boxes
        Dim streetNumber As String = txtStreetNumber.Text
        Dim streetName As String = txtStreetName.Text
        Dim aptSuiteNumber As String = txtAptSuiteNumber.Text
        Dim city As String = txtCity.Text
        Dim state As String = txtState.Text
        Dim zip As String = txtZip.Text
        Dim rent As String = txtRent.Text
        Dim deposit As String = txtDeposit.Text
        Dim parcel As String = txtParcel.Text
        Dim purchaseDate As String = txtPurchaseDate.Text
        Dim purchasePrice As String = txtPurchasePrice.Text
        Dim homeShortName As String = txtHomeShortName.Text
        Dim notes As String = txtNotes.Text
        Dim bathrooms As Decimal = Convert.ToDecimal(cboBathrooms.SelectedIndex)
        Dim bedrooms As Integer = Convert.ToDecimal(cboBedrooms.SelectedIndex)

        ' Insert the new property into the database
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "INSERT INTO Properties (StreetNumber, StreetName, AptSuiteNumber, City, State, Zip, Rent, Deposit, Parcel, PurchaseDate, PurchasePrice, HomeShortName, Notes, Bathrooms, Bedrooms) VALUES (@StreetNumber, @StreetName, @AptSuiteNumber, @City, @State, @Zip, @Rent, @Deposit, @Parcel, @PurchaseDate, @PurchasePrice, @HomeShortName, @Notes, @Bathrooms, @Bedrooms)"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@StreetNumber", If(String.IsNullOrEmpty(streetNumber), "N/A", streetNumber))
                command.Parameters.AddWithValue("@StreetName", If(String.IsNullOrEmpty(streetName), "N/A", streetName))
                command.Parameters.AddWithValue("@AptSuiteNumber", If(String.IsNullOrEmpty(aptSuiteNumber), "N/A", aptSuiteNumber))
                command.Parameters.AddWithValue("@City", If(String.IsNullOrEmpty(city), "N/A", city))
                command.Parameters.AddWithValue("@State", If(String.IsNullOrEmpty(state), "N/A", state))
                command.Parameters.AddWithValue("@Zip", If(String.IsNullOrEmpty(zip), "N/A", zip))
                command.Parameters.AddWithValue("@Rent", If(String.IsNullOrEmpty(rent), "0", rent))
                command.Parameters.AddWithValue("@Deposit", If(String.IsNullOrEmpty(deposit), "0", deposit))
                command.Parameters.AddWithValue("@Parcel", If(String.IsNullOrEmpty(parcel), "N/A", parcel))
                command.Parameters.AddWithValue("@PurchaseDate", If(String.IsNullOrEmpty(purchaseDate), "01/01/1900", purchaseDate))
                command.Parameters.AddWithValue("@PurchasePrice", If(String.IsNullOrEmpty(purchasePrice), "0", purchasePrice))
                command.Parameters.AddWithValue("@HomeShortName", If(String.IsNullOrEmpty(homeShortName), "N/A", homeShortName))
                command.Parameters.AddWithValue("@Notes", If(String.IsNullOrEmpty(notes), "N/A", notes))
                command.Parameters.AddWithValue("@Bathrooms", bathrooms)
                command.Parameters.AddWithValue("@Bedrooms", bedrooms)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        ClearFields()
        cboPropertyAddress.Items.Clear()
        btnSaveNew.Visible = False
        btnCancel.Visible = False
        btnSave.Visible = True
        grpSearch.Visible = True
        MessageBox.Show("New property added successfully.")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel and clear all fields?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            btnSaveNew.Visible = False
            btnCancel.Visible = False
            btnSave.Visible = True
            grpSearch.Visible = True
            ClearFields()
            cboPropertyAddress.Items.Clear()
            txtSearch.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Clear the combo box before adding new items
        cboPropertyAddress.Items.Clear()

        ' Get the search text
        Dim searchText As String = txtSearch.Text

        ' Assuming you have a method to get the properties from the database
        Dim properties As List(Of Properties) = GetPropertiesByStreetName(searchText)

        ' Loop through the properties and add them to the combo box
        For Each prop As Properties In properties
            Dim address As String = $"{prop.StreetNumber} {prop.StreetName} {prop.AptSuiteNumber}"
            cboPropertyAddress.Items.Add(New With {.Address = address, .ID = prop.ID})
            cboPropertyAddress.DisplayMember = "Address"
        Next

        ' Make lblNoneFound visible if no properties are found
        lblNoneFound.Visible = (properties.Count = 0)
        If properties.Count = 0 Then
            ClearFields()
            cboPropertyAddress.Items.Clear()
            cboPropertyAddress.Text = ""
            lblNoneFound.Visible = True
        Else
            cboPropertyAddress.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboPropertyAddress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPropertyAddress.SelectedIndexChanged
        If cboPropertyAddress.SelectedIndex <> -1 Then
            Dim selectedProperty As Properties = GetSelectedPropertyByID(sender, e)

            If selectedProperty IsNot Nothing Then
                txtStreetNumber.Text = selectedProperty.StreetNumber
                txtStreetName.Text = selectedProperty.StreetName
                txtAptSuiteNumber.Text = selectedProperty.AptSuiteNumber
                txtCity.Text = selectedProperty.City
                txtState.Text = selectedProperty.State
                txtZip.Text = selectedProperty.Zip
                txtRent.Text = selectedProperty.Rent
                txtDeposit.Text = selectedProperty.Deposit
                txtParcel.Text = selectedProperty.Parcel
                txtPurchaseDate.Text = selectedProperty.PurchaseDate
                txtPurchasePrice.Text = selectedProperty.PurchasePrice
                txtHomeShortName.Text = selectedProperty.HomeShortName
                txtNotes.Text = selectedProperty.Notes
                cboBathrooms.SelectedIndex = selectedProperty.Bathrooms
                cboBedrooms.SelectedIndex = selectedProperty.Bedrooms
                chkVacant.Checked = selectedProperty.Vacant
            End If
        End If
    End Sub
End Class