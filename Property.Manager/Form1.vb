Public Class Form1
    Private Sub Main()

    End Sub
    Private Sub btnTenants_Click(sender As Object, e As EventArgs) Handles btnTenants.Click
        frmTenants.Show()
    End Sub

    Private Sub btnProperties_Click(sender As Object, e As EventArgs) Handles btnProperties.Click
        frmProperties.Show()
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        frmPayments.Show()
    End Sub

    Private Sub btnWordOrders_Click(sender As Object, e As EventArgs) Handles btnWordOrders.Click
        frmWorkOrders.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
