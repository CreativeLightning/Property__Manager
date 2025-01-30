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
        Me.btnPrintRentHistory = New System.Windows.Forms.Button()
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
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gboxPaymentInformation.SuspendLayout()
        Me.grpPropertyPayments.SuspendLayout()
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
        Me.gboxPaymentInformation.Location = New System.Drawing.Point(142, 15)
        Me.gboxPaymentInformation.Name = "gboxPaymentInformation"
        Me.gboxPaymentInformation.Size = New System.Drawing.Size(441, 202)
        Me.gboxPaymentInformation.TabIndex = 2
        Me.gboxPaymentInformation.TabStop = False
        Me.gboxPaymentInformation.Text = "Payment - Rent Information"
        '
        'grpPropertyPayments
        '
        Me.grpPropertyPayments.Controls.Add(Me.btnPrintRentHistory)
        Me.grpPropertyPayments.Location = New System.Drawing.Point(233, 84)
        Me.grpPropertyPayments.Name = "grpPropertyPayments"
        Me.grpPropertyPayments.Size = New System.Drawing.Size(193, 97)
        Me.grpPropertyPayments.TabIndex = 9
        Me.grpPropertyPayments.TabStop = False
        Me.grpPropertyPayments.Text = "Payments by Property"
        Me.grpPropertyPayments.Visible = False
        '
        'btnPrintRentHistory
        '
        Me.btnPrintRentHistory.Location = New System.Drawing.Point(16, 20)
        Me.btnPrintRentHistory.Name = "btnPrintRentHistory"
        Me.btnPrintRentHistory.Size = New System.Drawing.Size(170, 23)
        Me.btnPrintRentHistory.TabIndex = 1
        Me.btnPrintRentHistory.Text = "Print All Rent History"
        Me.btnPrintRentHistory.UseVisualStyleBackColor = True
        '
        'grpTenantPayments
        '
        Me.grpTenantPayments.Controls.Add(Me.btnAllTenantPayments)
        Me.grpTenantPayments.Location = New System.Drawing.Point(28, 85)
        Me.grpTenantPayments.Name = "grpTenantPayments"
        Me.grpTenantPayments.Size = New System.Drawing.Size(184, 96)
        Me.grpTenantPayments.TabIndex = 8
        Me.grpTenantPayments.TabStop = False
        Me.grpTenantPayments.Text = "Payments by Tenant"
        Me.grpTenantPayments.Visible = False
        '
        'btnAllTenantPayments
        '
        Me.btnAllTenantPayments.Location = New System.Drawing.Point(6, 19)
        Me.btnAllTenantPayments.Name = "btnAllTenantPayments"
        Me.btnAllTenantPayments.Size = New System.Drawing.Size(167, 23)
        Me.btnAllTenantPayments.TabIndex = 0
        Me.btnAllTenantPayments.Text = "Print All Payment History"
        Me.btnAllTenantPayments.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Select:"
        '
        'cboProperties
        '
        Me.cboProperties.FormattingEnabled = True
        Me.cboProperties.Location = New System.Drawing.Point(266, 48)
        Me.cboProperties.Name = "cboProperties"
        Me.cboProperties.Size = New System.Drawing.Size(160, 21)
        Me.cboProperties.TabIndex = 6
        '
        'txtSearchByStreet
        '
        Me.txtSearchByStreet.Location = New System.Drawing.Point(317, 22)
        Me.txtSearchByStreet.Name = "txtSearchByStreet"
        Me.txtSearchByStreet.Size = New System.Drawing.Size(109, 20)
        Me.txtSearchByStreet.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Property Street:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select:"
        '
        'cboTenants
        '
        Me.cboTenants.FormattingEnabled = True
        Me.cboTenants.Location = New System.Drawing.Point(56, 48)
        Me.cboTenants.Name = "cboTenants"
        Me.cboTenants.Size = New System.Drawing.Size(156, 21)
        Me.cboTenants.TabIndex = 2
        '
        'txtSearchByTenant
        '
        Me.txtSearchByTenant.Location = New System.Drawing.Point(106, 22)
        Me.txtSearchByTenant.Name = "txtSearchByTenant"
        Me.txtSearchByTenant.Size = New System.Drawing.Size(106, 20)
        Me.txtSearchByTenant.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tenant Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnHome)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 202)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(6, 49)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(7, 20)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(57, 23)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = ""
        Me.dtpStart.Location = New System.Drawing.Point(7, 106)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(99, 20)
        Me.dtpStart.TabIndex = 2
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = ""
        Me.dtpEnd.Location = New System.Drawing.Point(6, 152)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(99, 20)
        Me.dtpEnd.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Start Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "End Date:"
        '
        'frmPaymentHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gboxPaymentInformation)
        Me.Name = "frmPaymentHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment History"
        Me.gboxPaymentInformation.ResumeLayout(False)
        Me.gboxPaymentInformation.PerformLayout()
        Me.grpPropertyPayments.ResumeLayout(False)
        Me.grpTenantPayments.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents btnPrintRentHistory As Button
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
