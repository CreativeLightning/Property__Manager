<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentHistory
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
        Me.gboxPaymentInformation = New System.Windows.Forms.GroupBox()
        Me.grpPropertyPayments = New System.Windows.Forms.GroupBox()
        Me.grpTenantPayments = New System.Windows.Forms.GroupBox()
        Me.btnAllTenantPayments = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProperties = New System.Windows.Forms.ComboBox()
        Me.txtSearchByStreet = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTenants = New System.Windows.Forms.ComboBox()
        Me.txtSearchByTenant = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.gboxPaymentInformation.SuspendLayout()
        Me.grpTenantPayments.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxPaymentInformation
        '
        Me.gboxPaymentInformation.Controls.Add(Me.grpPropertyPayments)
        Me.gboxPaymentInformation.Controls.Add(Me.grpTenantPayments)
        Me.gboxPaymentInformation.Controls.Add(Me.Label3)
        Me.gboxPaymentInformation.Controls.Add(Me.cboProperties)
        Me.gboxPaymentInformation.Controls.Add(Me.txtSearchByStreet)
        Me.gboxPaymentInformation.Controls.Add(Me.Label4)
        Me.gboxPaymentInformation.Controls.Add(Me.Label2)
        Me.gboxPaymentInformation.Controls.Add(Me.cboTenants)
        Me.gboxPaymentInformation.Controls.Add(Me.txtSearchByTenant)
        Me.gboxPaymentInformation.Controls.Add(Me.Label1)
        Me.gboxPaymentInformation.Location = New System.Drawing.Point(140, 16)
        Me.gboxPaymentInformation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxPaymentInformation.Name = "gboxPaymentInformation"
        Me.gboxPaymentInformation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboxPaymentInformation.Size = New System.Drawing.Size(630, 336)
        Me.gboxPaymentInformation.TabIndex = 2
        Me.gboxPaymentInformation.TabStop = False
        Me.gboxPaymentInformation.Text = "Payment Information"
        '
        'grpPropertyPayments
        '
        Me.grpPropertyPayments.Location = New System.Drawing.Point(342, 120)
        Me.grpPropertyPayments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPropertyPayments.Name = "grpPropertyPayments"
        Me.grpPropertyPayments.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPropertyPayments.Size = New System.Drawing.Size(257, 186)
        Me.grpPropertyPayments.TabIndex = 9
        Me.grpPropertyPayments.TabStop = False
        Me.grpPropertyPayments.Text = "Payments by Property"
        Me.grpPropertyPayments.Visible = False
        '
        'grpTenantPayments
        '
        Me.grpTenantPayments.Controls.Add(Me.btnAllTenantPayments)
        Me.grpTenantPayments.Location = New System.Drawing.Point(37, 122)
        Me.grpTenantPayments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTenantPayments.Name = "grpTenantPayments"
        Me.grpTenantPayments.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTenantPayments.Size = New System.Drawing.Size(267, 186)
        Me.grpTenantPayments.TabIndex = 8
        Me.grpTenantPayments.TabStop = False
        Me.grpTenantPayments.Text = "Payments by Tenant"
        Me.grpTenantPayments.Visible = False
        '
        'btnAllTenantPayments
        '
        Me.btnAllTenantPayments.Location = New System.Drawing.Point(8, 23)
        Me.btnAllTenantPayments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAllTenantPayments.Name = "btnAllTenantPayments"
        Me.btnAllTenantPayments.Size = New System.Drawing.Size(251, 28)
        Me.btnAllTenantPayments.TabIndex = 0
        Me.btnAllTenantPayments.Text = "Print All Payment History"
        Me.btnAllTenantPayments.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Select:"
        '
        'cboProperties
        '
        Me.cboProperties.FormattingEnabled = True
        Me.cboProperties.Location = New System.Drawing.Point(367, 53)
        Me.cboProperties.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboProperties.Name = "cboProperties"
        Me.cboProperties.Size = New System.Drawing.Size(221, 24)
        Me.cboProperties.TabIndex = 6
        '
        'txtSearchByStreet
        '
        Me.txtSearchByStreet.Location = New System.Drawing.Point(434, 21)
        Me.txtSearchByStreet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchByStreet.Name = "txtSearchByStreet"
        Me.txtSearchByStreet.Size = New System.Drawing.Size(155, 22)
        Me.txtSearchByStreet.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Property Street:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select:"
        '
        'cboTenants
        '
        Me.cboTenants.FormattingEnabled = True
        Me.cboTenants.Location = New System.Drawing.Point(75, 59)
        Me.cboTenants.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTenants.Name = "cboTenants"
        Me.cboTenants.Size = New System.Drawing.Size(221, 24)
        Me.cboTenants.TabIndex = 2
        '
        'txtSearchByTenant
        '
        Me.txtSearchByTenant.Location = New System.Drawing.Point(141, 27)
        Me.txtSearchByTenant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearchByTenant.Name = "txtSearchByTenant"
        Me.txtSearchByTenant.Size = New System.Drawing.Size(155, 22)
        Me.txtSearchByTenant.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tenant Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnHome)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(97, 336)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(8, 60)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 28)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(9, 25)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(76, 28)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'frmPaymentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gboxPaymentInformation)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPaymentHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment History"
        Me.gboxPaymentInformation.ResumeLayout(False)
        Me.gboxPaymentInformation.PerformLayout()
        Me.grpTenantPayments.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gboxPaymentInformation As GroupBox
    Friend WithEvents grpPropertyPayments As GroupBox
    Friend WithEvents grpTenantPayments As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboProperties As ComboBox
    Friend WithEvents txtSearchByStreet As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTenants As ComboBox
    Friend WithEvents txtSearchByTenant As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAllTenantPayments As Button
End Class
