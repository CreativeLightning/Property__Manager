Public Class frmPayments
    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Property_ManagerDataSet.Tenants' table. You can move, or remove it, as needed.
        Me.TenantsTableAdapter.Fill(Me.Property_ManagerDataSet.Tenants)
        ' Add a new column to the DataTable to hold the concatenated names
        Me.Property_ManagerDataSet.Tenants.Columns.Add("FullName", GetType(String), "FName + ' ' + LName")

        ' Set the ComboBox DataSource to the Tenants table
        ComboBox1.DataSource = Me.Property_ManagerDataSet.Tenants
        ComboBox1.DisplayMember = "FullName" ' The new concatenated column
        ComboBox1.ValueMember = "ID" ' Replace with the actual column name for the value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gboxPaymentInformation.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class