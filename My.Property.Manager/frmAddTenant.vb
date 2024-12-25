Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class frmAddTenant
    Private TenantsTableAdapter As New Property_ManagerDataSetTableAdapters.TenantsTableAdapter()


    Private Sub frmAddTenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the 'Property_ManagerDataSet.Tenants' table
        Me.TenantsTableAdapter.Fill(Me.Property_ManagerDataSet.Tenants)
    End Sub
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        ' Create a new row
        Dim newRow As Property_ManagerDataSet.TenantsRow = Me.Property_ManagerDataSet.Tenants.NewTenantsRow()

        ' Set the values for the new row
        newRow.Fname = FName.Text ' Replace with the actual TextBox control and column name
        newRow.Lname = lblLName.Text ' Replace with the actual TextBox control and column name

        ' Add the new row to the DataTable
        Me.Property_ManagerDataSet.Tenants.Rows.Add(newRow)

        ' Save the changes to the database
        Me.TenantsTableAdapter.Update(Me.Property_ManagerDataSet.Tenants)
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class