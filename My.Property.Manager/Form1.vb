Public Class Form1
    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        frmPayments.Show()
    End Sub

    Private Sub btnWorkOrders_Click(sender As Object, e As EventArgs) Handles btnWorkOrders.Click
        frmWorkOrders.Show()
    End Sub

    Private Sub btnTenants_Click(sender As Object, e As EventArgs) Handles btnTenants.Click
        frmTenants.Show()
    End Sub

    Private Sub btnProperties_Click(sender As Object, e As EventArgs) Handles btnProperties.Click
        frmProperties.Show()
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        frmEmployees.Show()
    End Sub

    Private Sub btnVendors_Click(sender As Object, e As EventArgs) Handles btnVendors.Click
        frmVendors.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
