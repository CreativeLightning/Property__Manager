Imports My_Property_Manager.frmProperties

Public Class frmWorkOrders
    Private Sub btnNewWO_Click(sender As Object, e As EventArgs) Handles btnNewWO.Click
        txtOpenDate.Text = Date.Today
        txtCloseDate.Text = ""

        chkCompleted.Checked = False
        FillcboProperties()
    End Sub
    Private Sub frmWorkOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    End Sub
    Private Sub chkCompleted_CheckedChanged(sender As Object, e As EventArgs) Handles chkCompleted.CheckedChanged
        txtCloseDate.Text = Date.Today
    End Sub

    Private Sub cboProperties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProperties.SelectedIndexChanged
        WOProperty = cboProperties.SelectedItem.substring(0, cboProperties.SelectedItem.IndexOf(" "))
    End Sub
End Class