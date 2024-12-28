Public Class Form1

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Login = False Then
            frmLogin.Show()
            Me.Hide()
        End If
        If Admin = False Then
            btnEmployees.Enabled = False
            btnVendors.Enabled = False
            btnPayments.Enabled = False
            btnProperties.Enabled = False
        End If
    End Sub

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
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class
