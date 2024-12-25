<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gboxPaymentInformation = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TenantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Property_ManagerDataSet = New My_Property_Manager.Property_ManagerDataSet()
        Me.PropertyManagerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TenantsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TenantsTableAdapter = New My_Property_Manager.Property_ManagerDataSetTableAdapters.TenantsTableAdapter()
        Me.Property_ManagerDataSet2 = New My_Property_Manager.Property_ManagerDataSet()
        Me.TenantsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.gboxPaymentInformation.SuspendLayout()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Property_ManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyManagerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Property_ManagerDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 425)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Begin Here"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Take Payment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gboxPaymentInformation
        '
        Me.gboxPaymentInformation.Controls.Add(Me.ComboBox1)
        Me.gboxPaymentInformation.Controls.Add(Me.TextBox1)
        Me.gboxPaymentInformation.Controls.Add(Me.Label1)
        Me.gboxPaymentInformation.Location = New System.Drawing.Point(135, 13)
        Me.gboxPaymentInformation.Name = "gboxPaymentInformation"
        Me.gboxPaymentInformation.Size = New System.Drawing.Size(653, 425)
        Me.gboxPaymentInformation.TabIndex = 1
        Me.gboxPaymentInformation.TabStop = False
        Me.gboxPaymentInformation.Text = "Payment Information"
        Me.gboxPaymentInformation.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tenant Last Name"
        '
        'Property_ManagerDataSet
        '
        Me.Property_ManagerDataSet.DataSetName = "Property_ManagerDataSet"
        Me.Property_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropertyManagerDataSetBindingSource
        '
        Me.PropertyManagerDataSetBindingSource.DataSource = Me.Property_ManagerDataSet
        Me.PropertyManagerDataSetBindingSource.Position = 0
        '
        'TenantsBindingSource1
        '
        Me.TenantsBindingSource1.DataMember = "Tenants"
        Me.TenantsBindingSource1.DataSource = Me.Property_ManagerDataSet
        '
        'TenantsTableAdapter
        '
        Me.TenantsTableAdapter.ClearBeforeFill = True
        '
        'Property_ManagerDataSet2
        '
        Me.Property_ManagerDataSet2.DataSetName = "Property_ManagerDataSet"
        Me.Property_ManagerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TenantsBindingSource2
        '
        Me.TenantsBindingSource2.DataMember = "Tenants"
        Me.TenantsBindingSource2.DataSource = Me.Property_ManagerDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TenantsBindingSource
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(126, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gboxPaymentInformation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.gboxPaymentInformation.ResumeLayout(False)
        Me.gboxPaymentInformation.PerformLayout()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Property_ManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyManagerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Property_ManagerDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents gboxPaymentInformation As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TenantsBindingSource As BindingSource
    Friend WithEvents Property_ManagerDataSet As Property_ManagerDataSet
    Friend WithEvents PropertyManagerDataSetBindingSource As BindingSource
    Friend WithEvents TenantsBindingSource1 As BindingSource
    Friend WithEvents TenantsTableAdapter As Property_ManagerDataSetTableAdapters.TenantsTableAdapter
    Friend WithEvents Property_ManagerDataSet2 As Property_ManagerDataSet
    Friend WithEvents TenantsBindingSource2 As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
