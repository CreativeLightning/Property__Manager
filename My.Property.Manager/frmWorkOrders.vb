Imports System.Data.OleDb
Imports My_Property_Manager.frmProperties

Public Class frmWorkOrders
    Private Sub btnNewWO_Click(sender As Object, e As EventArgs) Handles btnNewWO.Click
        txtOpenDate.Text = Date.Today
        txtCloseDate.Text = ""
        grpNewWO.Visible = True
        chkCompleted.Checked = False
        txtDescription.Text = ""
        txtNotes.Text = ""
        FillcboProperties()
        FillCboEmployees()
        FillcboVendors()
    End Sub
    Private Sub frmWorkOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        cboVendors.SelectedIndex = -1
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
        cboEmployees.SelectedIndex = -1
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
        cboProperties.SelectedIndex = -1
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
        grpNewWO.Visible = False
    End Sub

    Private Sub btnSaveWO_Click(sender As Object, e As EventArgs) Handles btnSaveWO.Click
        SaveWO()

    End Sub
    Private Sub SaveWO()
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
                    MessageBox.Show("Work Order Saved")
                    grpNewWO.Visible = False
                    cboVendors.Items.Clear()
                    cboEmployees.Items.Clear()
                    cboProperties.Items.Clear()
                Catch ex As Exception
                    MessageBox.Show("Error Saving Work Order")
                End Try

            End Using
        End Using
    End Sub
End Class