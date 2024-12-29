Public Class frmCharges
    Private Sub frmCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Property_ManagerDataSet.Charges' table. You can move, or remove it, as needed.
        Me.ChargesTableAdapter.Fill(Me.Property_ManagerDataSet.Charges)
        If WOID = 0 Then
            MsgBox("Please select a work order first.", MsgBoxStyle.Exclamation, "No Work Order Selected")
            Me.Close()
        ElseIf WOID > 0 Then
            Me.Text = "Charges For Work Order #" & WOID
            AddChargesDataGridView()
        End If
    End Sub

    Private Sub AddChargesDataGridView()
        Dim dgvCharges As New DataGridView
        dgvCharges.Dock = DockStyle.Fill
        dgvCharges.DataSource = GetFilteredCharges()
        Me.Controls.Add(dgvCharges)
        dgvCharges.Columns("ChargeNotes").HeaderText = "Charge Notes"
        dgvCharges.Columns("Total").HeaderText = "Total"
        dgvCharges.Columns("DateBilled").HeaderText = "Date Billed"
        dgvCharges.Columns("DatePaid").HeaderText = "Date Paid"
        dgvCharges.Columns("DateBilled").DefaultCellStyle.Format = "MM/dd/yyyy"
        dgvCharges.Columns("DatePaid").DefaultCellStyle.Format = "MM/dd/yyyy"
        dgvCharges.Columns("ChargeNotes").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Fill remaining space with  Charge Notes
    End Sub

    Private Function GetFilteredCharges() As DataTable
        Dim filteredCharges As New DataTable
        filteredCharges = Me.Property_ManagerDataSet.Charges.Clone()
        ' Remove primary key constraint to allow clearing
        If filteredCharges.PrimaryKey.Length > 0 Then
            filteredCharges.PrimaryKey = Nothing
        End If
        filteredCharges.Columns.Clear()
        filteredCharges.Columns.Add("ChargeNotes", GetType(String))
        filteredCharges.Columns.Add("Total", GetType(String))
        filteredCharges.Columns.Add("DateBilled", GetType(String))
        filteredCharges.Columns.Add("DatePaid", GetType(String))

        For Each row As DataRow In Me.Property_ManagerDataSet.Charges.Rows
            If row("WOID") = WOID Then
                Dim newRow As DataRow = filteredCharges.NewRow()
                newRow("ChargeNotes") = row("ChargeNotes")
                newRow("Total") = FormatCurrency(row("Total"))
                newRow("DateBilled") = row("DateBilled")
                newRow("DatePaid") = row("DatePaid")
                filteredCharges.Rows.Add(newRow)
            End If
        Next
        Return filteredCharges
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddCharge_Click(sender As Object, e As EventArgs) Handles btnAddCharge.Click
        frmWorkOrders.btnAddCharges_Click(sender, e)
        Me.Close()
    End Sub
End Class