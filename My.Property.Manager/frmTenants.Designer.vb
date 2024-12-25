<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTenants
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Property_ManagerDataSet = New My_Property_Manager.Property_ManagerDataSet()
        Me.TenantsTableAdapter = New My_Property_Manager.Property_ManagerDataSetTableAdapters.TenantsTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddTenant = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Property_ManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.PropertyDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.Phone2DataGridViewTextBoxColumn, Me.Phone3DataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TenantsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(149, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(848, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'PropertyDataGridViewTextBoxColumn
        '
        Me.PropertyDataGridViewTextBoxColumn.DataPropertyName = "Property"
        Me.PropertyDataGridViewTextBoxColumn.HeaderText = "Property"
        Me.PropertyDataGridViewTextBoxColumn.Name = "PropertyDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'Phone2DataGridViewTextBoxColumn
        '
        Me.Phone2DataGridViewTextBoxColumn.DataPropertyName = "Phone2"
        Me.Phone2DataGridViewTextBoxColumn.HeaderText = "Phone2"
        Me.Phone2DataGridViewTextBoxColumn.Name = "Phone2DataGridViewTextBoxColumn"
        '
        'Phone3DataGridViewTextBoxColumn
        '
        Me.Phone3DataGridViewTextBoxColumn.DataPropertyName = "Phone3"
        Me.Phone3DataGridViewTextBoxColumn.HeaderText = "Phone3"
        Me.Phone3DataGridViewTextBoxColumn.Name = "Phone3DataGridViewTextBoxColumn"
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'TenantsBindingSource
        '
        Me.TenantsBindingSource.DataMember = "Tenants"
        Me.TenantsBindingSource.DataSource = Me.Property_ManagerDataSet
        '
        'Property_ManagerDataSet
        '
        Me.Property_ManagerDataSet.DataSetName = "Property_ManagerDataSet"
        Me.Property_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TenantsTableAdapter
        '
        Me.TenantsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddTenant)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 186)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Begin Here"
        '
        'btnAddTenant
        '
        Me.btnAddTenant.Location = New System.Drawing.Point(26, 47)
        Me.btnAddTenant.Name = "btnAddTenant"
        Me.btnAddTenant.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTenant.TabIndex = 0
        Me.btnAddTenant.Text = "Add Tenant"
        Me.btnAddTenant.UseVisualStyleBackColor = True
        '
        'frmTenants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 453)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmTenants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tenant Management"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Property_ManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Property_ManagerDataSet As Property_ManagerDataSet
    Friend WithEvents TenantsBindingSource As BindingSource
    Friend WithEvents TenantsTableAdapter As Property_ManagerDataSetTableAdapters.TenantsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PropertyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Phone2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Phone3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddTenant As Button
End Class
