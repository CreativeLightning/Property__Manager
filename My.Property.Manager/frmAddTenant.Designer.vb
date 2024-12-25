<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTenant
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
        Me.lblPhone2 = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.LName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.FName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Property_ManagerDataSet = New My_Property_Manager.Property_ManagerDataSet()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SSN = New System.Windows.Forms.TextBox()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.Phone2 = New System.Windows.Forms.TextBox()
        Me.Phone3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Property_ManagerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DOB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Phone3)
        Me.GroupBox1.Controls.Add(Me.Phone2)
        Me.GroupBox1.Controls.Add(Me.Phone)
        Me.GroupBox1.Controls.Add(Me.SSN)
        Me.GroupBox1.Controls.Add(Me.lblPhone2)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblSSN)
        Me.GroupBox1.Controls.Add(Me.LName)
        Me.GroupBox1.Controls.Add(Me.lblLName)
        Me.GroupBox1.Controls.Add(Me.FName)
        Me.GroupBox1.Controls.Add(Me.lblFName)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 355)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tenant Information"
        '
        'lblPhone2
        '
        Me.lblPhone2.AutoSize = True
        Me.lblPhone2.Location = New System.Drawing.Point(27, 134)
        Me.lblPhone2.Name = "lblPhone2"
        Me.lblPhone2.Size = New System.Drawing.Size(50, 13)
        Me.lblPhone2.TabIndex = 6
        Me.lblPhone2.Text = "Phone 2:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(36, 106)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone:"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(45, 77)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(32, 13)
        Me.lblSSN.TabIndex = 4
        Me.lblSSN.Text = "SSN:"
        '
        'LName
        '
        Me.LName.Location = New System.Drawing.Point(83, 49)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(115, 20)
        Me.LName.TabIndex = 3
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(16, 49)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(61, 13)
        Me.lblLName.TabIndex = 2
        Me.lblLName.Text = "Last Name:"
        '
        'FName
        '
        Me.FName.Location = New System.Drawing.Point(83, 20)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(115, 20)
        Me.FName.TabIndex = 1
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(17, 23)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(60, 13)
        Me.lblFName.TabIndex = 0
        Me.lblFName.Text = "First Name:"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(23, 379)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "&Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.Property_ManagerDataSet
        Me.BindingSource1.Position = 0
        '
        'Property_ManagerDataSet
        '
        Me.Property_ManagerDataSet.DataSetName = "Property_ManagerDataSet"
        Me.Property_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(124, 379)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'SSN
        '
        Me.SSN.Location = New System.Drawing.Point(83, 77)
        Me.SSN.Name = "SSN"
        Me.SSN.Size = New System.Drawing.Size(115, 20)
        Me.SSN.TabIndex = 7
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(83, 106)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(115, 20)
        Me.Phone.TabIndex = 8
        '
        'Phone2
        '
        Me.Phone2.Location = New System.Drawing.Point(83, 134)
        Me.Phone2.Name = "Phone2"
        Me.Phone2.Size = New System.Drawing.Size(115, 20)
        Me.Phone2.TabIndex = 9
        '
        'Phone3
        '
        Me.Phone3.Location = New System.Drawing.Point(83, 161)
        Me.Phone3.Name = "Phone3"
        Me.Phone3.Size = New System.Drawing.Size(115, 20)
        Me.Phone3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Phone 3:"
        '
        'DOB
        '
        Me.DOB.Location = New System.Drawing.Point(83, 197)
        Me.DOB.MaxDate = New Date(2071, 2, 1, 0, 0, 0, 0)
        Me.DOB.MinDate = New Date(1940, 2, 1, 0, 0, 0, 0)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(200, 20)
        Me.DOB.TabIndex = 12
        Me.DOB.Value = New Date(2024, 2, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Date of Birth:"
        '
        'frmAddTenant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 414)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddTenant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Tenant"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Property_ManagerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFName As Label
    Friend WithEvents FName As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Property_ManagerDataSet As Property_ManagerDataSet
    Friend WithEvents LName As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblPhone2 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblSSN As Label
    Friend WithEvents SSN As TextBox
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Phone3 As TextBox
    Friend WithEvents Phone2 As TextBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents Label2 As Label
End Class
