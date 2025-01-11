Imports System.Data.OleDb
Imports System.Net.Http.Headers
Imports My_Property_Manager.frmProperties

Public Class frmWorkOrders
    Public Class WorkOrder
        Public Property ID As Integer
        Public Property Description As String

        Public Overrides Function ToString() As String
            Return "#" & ID & " - " & Description
        End Function
    End Class
    Public Class ComboBoxItem
        Public Property Text As String
        Public Property Value As Integer

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

    Private Sub btnNewWO_Click(sender As Object, e As EventArgs) Handles btnNewWO.Click
        ClearAll()
        If HelpMessages = True Then
            MsgBox("After you save the Work Order, you can add charges. Create Work Orders for Internal Charges to allow for easy expense tracking and filing taxes.")
        End If
        btnSaveNewWO.Visible = True
        btnCancelWO.Visible = True
        txtOpenDate.Text = Date.Today
        txtCloseDate.Text = ""
        grpNewWO.Visible = True
        chkCompleted.Checked = False
        txtDescription.Text = ""
        txtNotes.Text = ""
        lblProperties.Visible = True
        cboProperties.Visible = True
        FillcboProperties()
        FillCboEmployees()
        FillcboVendors()
    End Sub
    Private Sub frmWorkOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpCharges.Location = New Point(166, 328)
    End Sub

    Private Sub FillcboVendors()
        cboVendors.Items.Clear()
        Dim dt As DataTable = Globals.VendorsTableAdapter.GetData()
        Dim dr As DataRow = dt.NewRow
        For Each dr In dt.Rows
            If dr.Item("VendorName") Is DBNull.Value Then
                dr.Item("VendorName") = ""
            Else
                dr.Item("VendorName") = dr.Item("VendorName")
            End If
            If dr.Item("ID") Is DBNull.Value Then
                dr.Item("ID") = 0
            Else
                dr.Item("ID") = dr.Item("ID")
            End If
            Dim vendorName As String = dr.Item("VendorName")
            Dim ID As Integer = dr.Item("ID")
            cboVendors.Items.Add(ID & " - " & vendorName)
        Next
        cboVendors.SelectedIndex = 0
    End Sub
    Private Sub FillCboEmployees()
        cboEmployees.Items.Clear()
        Dim dt As DataTable = Globals.EmployeesTableAdapter.GetData()
        Dim dr As DataRow = dt.NewRow
        For Each dr In dt.Rows
            If dr.Item("FName") Is DBNull.Value Then
                dr.Item("FName") = ""
            Else
                dr.Item("FName") = dr.Item("FName")
            End If
            If dr.Item("LName") Is DBNull.Value Then
                dr.Item("LName") = ""
            Else
                dr.Item("LName") = dr.Item("LName")
            End If
            If dr.Item("ID") Is DBNull.Value Then
                dr.Item("ID") = 0
            Else
                dr.Item("ID") = dr.Item("ID")
            End If
            Dim employeeName As String = dr.Item("FName") & " " & dr.Item("LName")
            Dim ID As Integer = dr.Item("ID")
            cboEmployees.Items.Add(ID & " - " & employeeName)
        Next
        cboEmployees.SelectedIndex = 0
    End Sub
    Private Sub FillcboProperties()
        cboProperties.Items.Clear()
        Dim dt As DataTable = Globals.PropertiesTableAdapter.GetData()
        Dim dr As DataRow = dt.NewRow


        For Each dr In dt.Rows
            If dr.Item("StreetNumber") Is DBNull.Value Then
                dr.Item("StreetNumber") = ""
            Else
                dr.Item("StreetNumber") = dr.Item("StreetNumber")
            End If
            If dr.Item("StreetName") Is DBNull.Value Then
                dr.Item("StreetName") = ""
            Else
                dr.Item("StreetName") = dr.Item("StreetName")
            End If
            If dr.Item("AptSuiteNumber") Is DBNull.Value Then
                dr.Item("AptSuiteNumber") = ""
            Else
                dr.Item("AptSuiteNumber") = dr.Item("AptSuiteNumber")
            End If
            If dr.Item("ID") Is DBNull.Value Then
                dr.Item("ID") = 0
            Else
                dr.Item("ID") = dr.Item("ID")
            End If
            Dim address As String = dr.Item("StreetNumber") & " " & dr.Item("StreetName") & " " & dr.Item("AptSuiteNumber")
            Dim ID As Integer = dr.Item("ID")
            cboProperties.Items.Add(ID & " - " & address)
        Next
        If cboProperties.Items.Count = 0 Then
            MessageBox.Show("No Properties Found")
        Else
            cboProperties.SelectedIndex = 0
        End If
    End Sub
    Private Sub chkCompleted_CheckedChanged(sender As Object, e As EventArgs) Handles chkCompleted.CheckedChanged
        If False = chkCompleted.Checked Then
            txtCloseDate.Text = ""
        ElseIf True = chkCompleted.Checked Then
            txtCloseDate.Text = Date.Today
        End If
    End Sub
    Private Sub cboProperties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProperties.SelectedIndexChanged
        WOProperty = cboProperties.SelectedItem.substring(0, cboProperties.SelectedItem.IndexOf(" "))
    End Sub
    Private Sub btnCancelWO_Click(sender As Object, e As EventArgs) Handles btnCancelWO.Click
        Dim msgboxresult = MsgBox("Do you want to cancel the Work Order?", MsgBoxStyle.YesNo)
        If msgboxresult.ToString = "Yes" Then
            grpNewWO.Visible = False
            cboVendors.Items.Clear()
            cboEmployees.Items.Clear()
            cboProperties.Items.Clear()
        End If

    End Sub
    Private Sub btnSaveNewWO_Click(sender As Object, e As EventArgs) Handles btnSaveNewWO.Click
        SaveWO()
    End Sub
    Private Sub SaveWO()
        Dim openDate As String = txtOpenDate.Text
        Dim closeDate As String = txtCloseDate.Text
        Dim propertyID As Integer = WOProperty
        If propertyID = 0 Then
            MsgBox("Choose a Property")
        End If
        Dim employeeID As Integer = cboEmployees.SelectedItem.substring(0, cboEmployees.SelectedItem.IndexOf(" "))
        Dim vendorID As Integer = cboVendors.SelectedItem.substring(0, cboVendors.SelectedItem.IndexOf(" "))
        Dim description As String = txtDescription.Text
        Dim completed As Boolean = chkCompleted.Checked
        Dim notes As String = txtNotes.Text
        If notes Is DBNull.Value Then
            MsgBox("notes is null")
            notes = ""
        End If
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "INSERT INTO WorkOrders (OpenDate, CloseDate, PropertyID, AssignedTo, VendorID, Description, Completed, Notes) VALUES (@OpenDate, @CloseDate, @PropertyID, @EmployeeID, @VendorID, @Description, @Completed, @Notes)"
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@OpenDate", openDate)
                cmd.Parameters.AddWithValue("@CloseDate", closeDate)
                cmd.Parameters.AddWithValue("@PropertyID", propertyID)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                cmd.Parameters.AddWithValue("@VendorID", vendorID)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.Parameters.AddWithValue("@Completed", completed)
                cmd.Parameters.AddWithValue("@Notes", notes)
                connection.Open()
                Try
                    cmd.ExecuteNonQuery()
                    If HelpMessages = True Then
                        MsgBox("You can now add charges to this Work Order.")
                    End If
                    cboProperties.Items.Clear()
                    cboProperties.Text = ""
                    ClearAll()
                Catch ex As Exception
                    MessageBox.Show("Error Saving Work Order")
                End Try

            End Using
        End Using
    End Sub
    Private Sub btnsaveWO_Click(sender As Object, e As EventArgs) Handles btnSaveWO.Click
        Dim openDate As String = txtOpenDate.Text
        Dim closeDate As String = txtCloseDate.Text
        Dim propertyID As Integer = WOProperty
        Dim employeeID As Integer = cboEmployees.SelectedItem.substring(0, cboEmployees.SelectedItem.IndexOf(" "))
        Dim vendorID As Integer = cboVendors.SelectedItem.substring(0, cboVendors.SelectedItem.IndexOf(" "))
        Dim description As String = txtDescription.Text
        Dim completed As Boolean = chkCompleted.Checked
        Dim notes As String = txtNotes.Text
        If notes Is DBNull.Value Then
            MsgBox("notes is null")
            notes = ""
        End If
        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "UPDATE WorkOrders SET OpenDate = @OpenDate, CloseDate = @CloseDate, PropertyID = @PropertyID, AssignedTo = @EmployeeID, VendorID = @VendorID, Description = @Description, Completed = @Completed, Notes = @Notes WHERE ID = " & WOID
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@OpenDate", openDate)
                cmd.Parameters.AddWithValue("@CloseDate", closeDate)
                cmd.Parameters.AddWithValue("@PropertyID", propertyID)
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
                cmd.Parameters.AddWithValue("@VendorID", vendorID)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.Parameters.AddWithValue("@Completed", completed)
                cmd.Parameters.AddWithValue("@Notes", notes)
                connection.Open()
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Work Order Updated")
                Catch ex As Exception
                    MessageBox.Show("Error Updating Work Order")
                    End
                End Try
            End Using
        End Using
    End Sub
    Private Sub btnOpenWO_Click(sender As Object, e As EventArgs) Handles btnOpenWO.Click
        ClearAll()
        lblProperties.Visible = False
        lblChoose.Visible = True
        cboProperties.Visible = False
        grpNewWO.Visible = True
        FillcboSelections(1)

    End Sub
    Private Sub FillcboSelections(TheType As Integer)
        cboSelections.Items.Clear()
        cboSelections.Text = ""
        If TheType = 1 Then 'All Open Work Orders
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT ID, Description, PropertyID FROM WorkOrders WHERE Completed = False ORDER BY ID"
                Using cmd As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ID As Integer = reader.GetInt32(0)
                        Dim description As String = "#" & reader.GetInt32(0).ToString & " " & reader.GetString(1)
                        Dim query2 As String = "SELECT StreetNumber, StreetName, AptSuiteNumber FROM Properties WHERE ID = " & reader.GetInt32(2)
                        Using cmd2 As New OleDbCommand(query2, connection)
                            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()
                            While reader2.Read()
                                Dim StreetNumber As String = reader2.GetString(0)
                                Dim StreetName As String = reader2.GetString(1)
                                description = description & " - " & StreetNumber & " " & StreetName
                                Dim NextItem As New ComboBoxItem() With {.Text = description, .Value = ID}
                                cboSelections.Items.Add(NextItem)
                            End While
                        End Using
                    End While
                End Using
            End Using
            If cboSelections.Items.Count = 0 Then
                MessageBox.Show("No Open Work Orders")
            Else
                cboSelections.SelectedIndex = 0
            End If
        ElseIf TheType = 2 Then 'Closed Work Orders
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT ID, Description, PropertyID FROM WorkOrders WHERE Completed = True ORDER BY ID"
                Using cmd As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ID As Integer = reader.GetInt32(0)
                        Dim description As String = "#" & reader.GetInt32(0).ToString & " " & reader.GetString(1)
                        Dim query2 As String = "SELECT StreetNumber, StreetName, AptSuiteNumber FROM Properties WHERE ID = " & reader.GetInt32(2)
                        Using cmd2 As New OleDbCommand(query2, connection)
                            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()
                            While reader2.Read()
                                Dim StreetNumber As String = reader2.GetString(0)
                                Dim StreetName As String = reader2.GetString(1)
                                description = description & " - " & StreetNumber & " " & StreetName
                                Dim NextItem As New ComboBoxItem() With {.Text = description, .Value = ID}
                                cboSelections.Items.Add(NextItem)
                            End While
                        End Using
                    End While
                End Using
            End Using
            If cboSelections.Items.Count = 0 Then
                MessageBox.Show("No Closed Work Orders")
            Else
                cboSelections.SelectedIndex = 0
            End If
        ElseIf TheType = 3 Then 'Work Orders by Employee ID

            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT ID, Description, PropertyID FROM WorkOrders WHERE AssignedTo = " & cboEmployees.SelectedItem.substring(0, cboEmployees.SelectedItem.IndexOf(" ")) & " ORDER BY ID"
                Using cmd As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ID As Integer = reader.GetInt32(0)
                        Dim description As String = "#" & reader.GetInt32(0).ToString & " " & reader.GetString(1)
                        Dim query2 As String = "SELECT StreetNumber, StreetName, AptSuiteNumber FROM Properties WHERE ID = " & reader.GetInt32(2)
                        Using cmd2 As New OleDbCommand(query2, connection)
                            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()
                            While reader2.Read()
                                Dim StreetNumber As String = reader2.GetString(0)
                                Dim StreetName As String = reader2.GetString(1)
                                description = description & " - " & StreetNumber & " " & StreetName
                                Dim NextItem As New ComboBoxItem() With {.Text = description, .Value = ID}
                                cboSelections.Items.Add(NextItem)
                            End While
                        End Using
                    End While
                End Using
            End Using
            If cboSelections.Items.Count = 0 Then
                MessageBox.Show("No Work Orders for Employee")
            Else
                cboSelections.SelectedIndex = 0
            End If
        ElseIf TheType = 4 Then 'Work Orders by Vendor ID
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT ID, Description, PropertyID FROM WorkOrders WHERE VendorID = " & cboVendors.SelectedItem.substring(0, cboVendors.SelectedItem.IndexOf(" ")) & " ORDER BY ID"
                Using cmd As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ID As Integer = reader.GetInt32(0)
                        Dim description As String = "#" & reader.GetInt32(0).ToString & " " & reader.GetString(1)
                        Dim query2 As String = "SELECT StreetNumber, StreetName, AptSuiteNumber FROM Properties WHERE ID = " & reader.GetInt32(2)
                        Using cmd2 As New OleDbCommand(query2, connection)
                            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()
                            While reader2.Read()
                                Dim StreetNumber As String = reader2.GetString(0)
                                Dim StreetName As String = reader2.GetString(1)
                                description = description & " - " & StreetNumber & " " & StreetName
                                Dim NextItem As New ComboBoxItem() With {.Text = description, .Value = ID}
                                cboSelections.Items.Add(NextItem)
                            End While
                        End Using
                    End While
                End Using
            End Using
            If cboSelections.Items.Count = 0 Then
                MessageBox.Show("No Work Orders for Vendor")
            Else
                cboSelections.SelectedIndex = 0
            End If
        ElseIf TheType = 5 Then 'Work Orders by Property ID
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT ID, Description, PropertyID FROM WorkOrders WHERE PropertyID = " & cboProperties.SelectedItem.substring(0, cboProperties.SelectedItem.IndexOf(" ")) & " ORDER BY ID"
                PropertyID = cboProperties.SelectedItem.substring(0, cboProperties.SelectedItem.IndexOf(" "))
                Using cmd As New OleDbCommand(query, connection)
                    connection.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ID As Integer = reader.GetInt32(0)
                        Dim description As String = "#" & reader.GetInt32(0).ToString & " " & reader.GetString(1)
                        Dim query2 As String = "SELECT StreetNumber, StreetName, AptSuiteNumber FROM Properties WHERE ID = " & reader.GetInt32(2)
                        Using cmd2 As New OleDbCommand(query2, connection)
                            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()
                            While reader2.Read()
                                Dim StreetNumber As String = reader2.GetString(0)
                                Dim StreetName As String = reader2.GetString(1)
                                description = description & " - " & StreetNumber & " " & StreetName
                                Dim NextItem As New ComboBoxItem() With {.Text = description, .Value = ID}
                                cboSelections.Items.Add(NextItem)

                            End While
                        End Using
                    End While
                End Using
            End Using
            If cboSelections.Items.Count = 0 Then
                MessageBox.Show("No Work Orders for Property")
            Else
                cboSelections.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnClosedWO_Click(sender As Object, e As EventArgs) Handles btnClosedWO.Click
        ClearAll()
        'Select all closed work orders
        FillcboSelections(2)
    End Sub
    Private Sub btnWOByEmployee_Click(sender As Object, e As EventArgs) Handles btnWOByEmployee.Click
        ClearAll()
        cboSelections.Items.Clear()
        cboSelections.Text = ""
        grpNewWO.Visible = True
        If HelpMessages = True Then
            MsgBox("Select Employee and Press Get.")
        End If
        btnSaveWO.Visible = False
        btnGetByEmployee.Visible = True
        btnGetByVendor.Visible = False
        lblProperties.Visible = False
        cboProperties.Visible = False
        btnCancelWO.Visible = False
        FillCboEmployees()
    End Sub
    Private Sub btnGetByEmployee_Click(sender As Object, e As EventArgs) Handles btnGetByEmployee.Click
        FillcboSelections(3)
    End Sub
    Private Sub btnWOByVendor_Click(sender As Object, e As EventArgs) Handles btnWOByVendor.Click
        ClearAll()
        cboSelections.Items.Clear()
        cboSelections.Text = ""
        ByVendor = True
        grpNewWO.Visible = True
        If HelpMessages = True Then
            MsgBox("Select Vendor and Press Get.")
        End If
        btnSaveWO.Visible = False
        btnGetByVendor.Visible = True
        btnGetByEmployee.Visible = False
        lblProperties.Visible = False
        cboProperties.Visible = False
        btnCancelWO.Visible = False
        FillcboVendors()
    End Sub
    Private Sub btnGetByVendor_Click(sender As Object, e As EventArgs) Handles btnGetByVendor.Click
        'Select all work orders by vendor
        FillcboSelections(4)
        ByVendor = False
    End Sub
    Private Sub ClearAll()
        'cboSelections.Items.Clear()
        cboSelections.Text = ""
        'cboEmployees.Items.Clear()
        cboEmployees.Text = ""
        'cboProperties.Items.Clear()
        cboProperties.Text = ""
        'cboVendors.Items.Clear()
        cboVendors.Text = ""
        txtLabor.Text = ""
        txtParts.Text = ""
        txtDescription.Text = ""
        txtNotes.Text = ""
        txtOpenDate.Text = ""
        txtCloseDate.Text = ""
        txtDateBilled.Text = ""
        txtDatePaid.Text = ""
        txtChargeNotes.Text = ""
        chkPaid.Checked = False
        chkCompleted.Checked = False
        btnGetByEmployee.Visible = False
        btnGetByVendor.Visible = False
        btnSaveWO.Visible = False
        btnCancelWO.Visible = False
        btnSaveNewWO.Visible = False
        btnAddCharges.Visible = False
        grpNewCharge.Visible = False
        grpByNumber.Visible = False
        btnViewCharges.Visible = False
    End Sub

    Public Sub btnAddCharges_Click(sender As Object, e As EventArgs) Handles btnAddCharges.Click
        'Open the charges form
        grpNewCharge.Visible = True
        grpCharges.Visible = False
        txtDateBilled.Text = Date.Today
    End Sub
    Private Sub btnCancelCharge_Click(sender As Object, e As EventArgs) Handles btnCancelCharge.Click
        grpNewCharge.Visible = False
    End Sub
    Private Sub cboVendors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendors.SelectedIndexChanged
        'Get the ID of the selected vendor
        Dim WOVendor As Integer = cboVendors.SelectedItem.substring(0, cboVendors.SelectedItem.IndexOf(" "))
        If ByVendor = False Then
            If WOVendor <> 1 Then
                cboEmployees.SelectedIndex = 0
            End If
        End If
        If cboVendors.SelectedIndex = 0 Then
            If cboEmployees.Items.Count > 0 Then
                cboEmployees.SelectedIndex = 1
            End If
        End If
    End Sub
    Private Sub btnSaveCharge_Click(sender As Object, e As EventArgs) Handles btnSaveCharge.Click
        'Save the charges entered on grpNewCharge
        If txtLabor.Text = "" Then
            txtLabor.Text = 0
        End If
        If txtParts.Text = "" Then
            txtParts.Text = 0
        End If
        Dim labor As Decimal = txtLabor.Text
        Dim parts As Decimal = txtParts.Text
        Dim total As Decimal = labor + parts
        Dim DateBilled As Date = Date.Parse(txtDateBilled.Text)
        Dim DatePaid As Date
        If txtDatePaid.Text <> "" Then
            DatePaid = Date.Parse(txtDatePaid.Text)
        End If
        Dim Paid As Boolean = chkPaid.Checked
            Dim ChargeNotes As String = txtChargeNotes.Text
        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            Dim query As String = "INSERT INTO Charges (WOID, Labor, Parts, Total, DateBilled, DatePaid, Paid, ChargeNotes) VALUES (@WorkOrderID, @Labor, @Parts, @Total, @DateBilled, @DatePaid, @Paid, @Notes)"
            Using cmd As OleDbCommand = New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@WorkOrderID", WOID)
                cmd.Parameters.AddWithValue("@Labor", labor)
                cmd.Parameters.AddWithValue("@Parts", parts)
                cmd.Parameters.AddWithValue("@Total", total)
                cmd.Parameters.AddWithValue("@DateBilled", DateBilled)
                cmd.Parameters.AddWithValue("@DatePaid", DatePaid)
                cmd.Parameters.AddWithValue("@Paid", Paid)
                cmd.Parameters.AddWithValue("@Notes", ChargeNotes)
                connection.Open()
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Charges Saved")
                Catch ex As Exception
                    MessageBox.Show("Error Saving Charges")
                End Try
            End Using
        End Using
        ClearAll()
        If HelpMessages = True Then
            MsgBox("You should mark this work order completed if the problem is resolved.")
        End If
    End Sub
    Private Sub chkPaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaid.CheckedChanged
        If chkPaid.Checked = True Then
            txtDatePaid.Text = Date.Today
        Else
            txtDatePaid.Text = ""
        End If
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnViewCharges_Click(sender As Object, e As EventArgs) Handles btnViewCharges.Click
        'hide new charges group and show charges for the selected work order
        grpNewCharge.Visible = False
        grpCharges.Visible = True
        'Get charges for selected work order,WOID and fill cboCharges
        cboCharges.Items.Clear()
        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            Dim query As String = "SELECT ID, dateBilled, Total FROM Charges WHERE WOID = " & WOID
            Using cmd As OleDbCommand = New OleDbCommand(query, connection)
                connection.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                Dim hasCharges As Boolean = False
                While reader.Read()
                    hasCharges = True
                    Dim ID As Integer = reader.GetInt32(0)
                    Dim dateBilled As Date = reader.GetDateTime(1)
                    Dim total As Decimal = reader.GetDecimal(2)
                    Dim charge As String = dateBilled.ToString & " " & total.ToString("C")
                    Dim NextItem As New ComboBoxItem() With {.Text = charge, .Value = ID}
                    cboCharges.Items.Add(NextItem)
                End While
                If Not hasCharges Then
                    cboCharges.Text = "No Charges"
                Else
                    cboCharges.SelectedIndex = 0
                End If
            End Using
        End Using
    End Sub

    Private Sub btnWOByProperty_Click(sender As Object, e As EventArgs) Handles btnWOByProperty.Click
        ClearAll()
        cboSelections.Items.Clear()
        cboSelections.Text = ""
        grpNewWO.Visible = True
        If HelpMessages = True Then
            MsgBox("Select Property THEN PRESS Get Wos")
        End If
        btnSaveWO.Visible = False
        btnGetByProperty.Visible = True
        btnGetByEmployee.Visible = False
        btnGetByVendor.Visible = False
        lblProperties.Visible = True
        cboProperties.Visible = True
        btnCancelWO.Visible = False
        FillcboProperties()

    End Sub

    Private Sub btnGetByProperty_Click(sender As Object, e As EventArgs) Handles btnGetByProperty.Click
        FillcboSelections(5) 'Work Orders by Property
    End Sub

    Private Sub cboSelections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelections.SelectedIndexChanged
        'Get the ID of the selected work order
        If cboSelections.Items.Count = 0 Then
            Exit Sub
        End If
        Dim selectedItem As ComboBoxItem = CType(cboSelections.SelectedItem, ComboBoxItem)
        WOID = selectedItem.Value

        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            Dim query As String = "SELECT OpenDate, CloseDate, PropertyID, AssignedTo, VendorID, Description, Completed, Notes FROM WorkOrders WHERE ID = " & WOID
            Using cmd As OleDbCommand = New OleDbCommand(query, connection)
                connection.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    txtOpenDate.Text = reader.GetString(0)
                    If reader.IsDBNull(1) Then
                        txtCloseDate.Text = ""
                    Else
                        txtCloseDate.Text = reader.GetString(1)
                    End If
                    WOProperty = reader.GetInt32(2)
                    FillCboEmployees()
                    FillcboVendors()
                    cboEmployees.SelectedIndex = cboEmployees.FindString(reader.GetInt32(3).ToString())
                    cboVendors.SelectedIndex = cboVendors.FindString(reader.GetInt32(4).ToString())
                    txtDescription.Text = reader.GetString(5)
                    chkCompleted.Checked = reader.GetBoolean(6)
                    txtNotes.Text = reader.GetString(7)
                    btnSaveWO.Visible = True
                    grpNewWO.Visible = True
                    btnAddCharges.Visible = True
                    btnViewCharges.Visible = True
                End While
            End Using
        End Using
    End Sub

    Private Sub btnWOByNumber_Click(sender As Object, e As EventArgs) Handles btnWOByNumber.Click
        ClearAll()
        grpByNumber.Visible = True
        btnSaveWO.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Search for a work order by number using txtWOID using Like operator and fill cboSelections
        cboSelections.Items.Clear()
        cboSelections.Text = ""
        Dim WOID As Integer = txtWOID.Text
        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            Dim query As String = "SELECT ID, Description, PropertyID FROM WorkOrders WHERE ID LIKE '%" & WOID & "%' ORDER BY ID"
            Using cmd As OleDbCommand = New OleDbCommand(query, connection)
                connection.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim ID As Integer = reader.GetInt32(0)
                    Dim description As String = "#" & reader.GetInt32(0).ToString & " " & reader.GetString(1)
                    Dim query2 As String = "SELECT StreetNumber, StreetName, AptSuiteNumber FROM Properties WHERE ID = " & reader.GetInt32(2)
                    Using cmd2 As OleDbCommand = New OleDbCommand(query2, connection)
                        Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()
                        While reader2.Read()
                            Dim StreetNumber As String = reader2.GetString(0)
                            Dim StreetName As String = reader2.GetString(1)
                            description = description & " - " & StreetNumber & " " & StreetName
                            Dim NextItem As New ComboBoxItem() With {.Text = description, .Value = ID}
                            cboSelections.Items.Add(NextItem)
                        End While
                    End Using
                End While
            End Using
        End Using
        If cboSelections.Items.Count = 0 Then
            MessageBox.Show("No Work Orders Found")
        Else
            cboSelections.SelectedIndex = 0
        End If
        grpNewWO.Visible = True
        lblChoose.Visible = False
        cboProperties.Visible = False
    End Sub

    Private Sub btnVendors_Click(sender As Object, e As EventArgs) Handles btnVendors.Click
        frmVendors.Show()
    End Sub

    Private Sub cboCharges_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCharges.SelectedIndexChanged
        'Get the ID of the selected charge, fill the charge fields txtTheParts , txtTheLabor, txtTheTotal, txtTheDateBilled, txtTheDatePaid, chkThePaid, txtTheChargeNotes
        Dim selectedItem As ComboBoxItem = CType(cboCharges.SelectedItem, ComboBoxItem)
        Dim chgID As Integer = selectedItem.Value
        ChargeID = chgID
        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            Dim query As String = "SELECT Labor, Parts, Total, DateBilled, DatePaid, Paid, ChargeNotes FROM Charges WHERE ID = " & ChargeID
            Using cmd As OleDbCommand = New OleDbCommand(query, connection)
                connection.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    txtTheLabor.Text = reader.GetDecimal(0)
                    txtTheParts.Text = reader.GetDecimal(1)
                    txtTheTotal.Text = reader.GetDecimal(2)
                    txtTheDateBilled.Text = reader.GetDateTime(3)
                    If reader.IsDBNull(4) Then
                        txtTheDatePaid.Text = ""
                    Else
                        txtTheDatePaid.Text = reader.GetDateTime(4)
                    End If
                    chkThePaid.Checked = reader.GetBoolean(5)
                    txtTheNotes.Text = reader.GetString(6)
                End While
            End Using
        End Using
    End Sub

    Private Sub btnUpdateCharge_Click(sender As Object, e As EventArgs) Handles btnUpdateCharge.Click
        'Update the selected charge using ChargeID
        If txtTheLabor.Text = "" Then
            txtTheLabor.Text = 0
        End If
        If txtTheParts.Text = "" Then
            txtTheParts.Text = 0
        End If
        If txtTheTotal.Text = "" Then
            txtTheTotal.Text = 0
        End If
        Dim labor As Decimal = txtTheLabor.Text
        Dim parts As Decimal = txtTheParts.Text
        Dim total As Decimal = txtTheTotal.Text
        Dim DateBilled As String = Date.Parse(txtTheDateBilled.Text)
        Dim DatePaid As Date
        If txtDatePaid.Text <> "" Then
            DatePaid = Date.Parse(txtTheDatePaid.Text)
        End If
        Dim Paid As Boolean = chkThePaid.Checked
        Dim ChargeNotes As String = txtTheNotes.Text
        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            Dim query As String = "UPDATE Charges SET Labor = @Labor, Parts = @Parts, Total = @Total, DateBilled = @DateBilled, DatePaid = @DatePaid, Paid = @Paid, ChargeNotes = @Notes WHERE ID = " & ChargeID
            Using cmd As OleDbCommand = New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@Labor", labor)
                cmd.Parameters.AddWithValue("@Parts", parts)
                cmd.Parameters.AddWithValue("@Total", total)
                cmd.Parameters.AddWithValue("@DateBilled", DateBilled)
                cmd.Parameters.AddWithValue("@DatePaid", DatePaid)
                cmd.Parameters.AddWithValue("@Paid", Paid)
                cmd.Parameters.AddWithValue("@Notes", ChargeNotes)
                connection.Open()
                Try
                    cmd.ExecuteNonQuery()
                    If HelpMessages = True Then
                        MsgBox("Charge Updated")
                        txtTheTotal.Clear()
                        txtTheLabor.Clear()
                        txtTheParts.Clear()
                        txtTheDateBilled.Clear()
                        txtTheDatePaid.Clear()
                        txtTheNotes.Clear()
                        chkThePaid.Checked = False
                        grpCharges.Visible = False
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Updating Charge")
                End Try
            End Using
        End Using
    End Sub

    Private Sub chkThePaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkThePaid.CheckedChanged
        'If chkThePaid is checked, set txtTheDatePaid to today, else clear txtTheDatePaid
        If chkThePaid.Checked = True Then
            txtTheDatePaid.Text = Date.Today
        Else
            txtTheDatePaid.Text = ""
        End If
    End Sub

    Private Sub cboEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmployees.SelectedIndexChanged
        If cboEmployees.SelectedIndex = 0 Then
            If cboVendors.Items.Count > 0 Then
                Try
                    cboVendors.SelectedIndex = 1
                Catch ex As Exception

                End Try

            End If
        End If
        If cboEmployees.SelectedIndex <> 0 Then
            cboVendors.SelectedIndex = 0
        End If
    End Sub
End Class