<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharges
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
        Me.Property_ManagerDataSet = New My_Property_Manager.Property_ManagerDataSet()
        Me.ChargesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChargesTableAdapter = New My_Property_Manager.Property_ManagerDataSetTableAdapters.ChargesTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddCharge = New System.Windows.Forms.Button()
        CType(Me.Property_ManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChargesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Property_ManagerDataSet
        '
        Me.Property_ManagerDataSet.DataSetName = "Property_ManagerDataSet"
        Me.Property_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChargesBindingSource
        '
        Me.ChargesBindingSource.DataMember = "Charges"
        Me.ChargesBindingSource.DataSource = Me.Property_ManagerDataSet
        '
        'ChargesTableAdapter
        '
        Me.ChargesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddCharge)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(6, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAddCharge
        '
        Me.btnAddCharge.Location = New System.Drawing.Point(87, 16)
        Me.btnAddCharge.Name = "btnAddCharge"
        Me.btnAddCharge.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCharge.TabIndex = 1
        Me.btnAddCharge.Text = "Add Charge"
        Me.btnAddCharge.UseVisualStyleBackColor = True
        '
        'frmCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 263)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCharges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Order ID Charges"
        CType(Me.Property_ManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChargesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Property_ManagerDataSet As Property_ManagerDataSet
    Friend WithEvents ChargesBindingSource As BindingSource
    Friend WithEvents ChargesTableAdapter As Property_ManagerDataSetTableAdapters.ChargesTableAdapter
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAddCharge As Button
End Class
