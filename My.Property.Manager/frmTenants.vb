Public Class frmTenants
    Private Sub frmTenants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Property_ManagerDataSet.Tenants' table. You can move, or remove it, as needed.
        Me.TenantsTableAdapter.Fill(Me.Property_ManagerDataSet.Tenants)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnAddTenant_Click(sender As Object, e As EventArgs) Handles btnAddTenant.Click
        frmAddTenant.Show()
    End Sub
End Class