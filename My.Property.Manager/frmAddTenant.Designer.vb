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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblInvalidPhone = New System.Windows.Forms.Label()
        Me.lblInvalidSSN = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Notes = New System.Windows.Forms.RichTextBox()
        Me.Phone3 = New System.Windows.Forms.TextBox()
        Me.Phone2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Phone = New System.Windows.Forms.TextBox()
        Me.SSN = New System.Windows.Forms.TextBox()
        Me.LName = New System.Windows.Forms.TextBox()
        Me.FName = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblInvalidPhone)
        Me.GroupBox2.Controls.Add(Me.lblInvalidSSN)
        Me.GroupBox2.Controls.Add(Me.DOB)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Notes)
        Me.GroupBox2.Controls.Add(Me.Phone3)
        Me.GroupBox2.Controls.Add(Me.Phone2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Phone)
        Me.GroupBox2.Controls.Add(Me.SSN)
        Me.GroupBox2.Controls.Add(Me.LName)
        Me.GroupBox2.Controls.Add(Me.FName)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 415)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Tenant Information"
        '
        'lblInvalidPhone
        '
        Me.lblInvalidPhone.AutoSize = True
        Me.lblInvalidPhone.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidPhone.Location = New System.Drawing.Point(219, 152)
        Me.lblInvalidPhone.Name = "lblInvalidPhone"
        Me.lblInvalidPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblInvalidPhone.TabIndex = 19
        Me.lblInvalidPhone.Text = "Invalid"
        Me.lblInvalidPhone.Visible = False
        '
        'lblInvalidSSN
        '
        Me.lblInvalidSSN.AutoSize = True
        Me.lblInvalidSSN.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidSSN.Location = New System.Drawing.Point(219, 94)
        Me.lblInvalidSSN.Name = "lblInvalidSSN"
        Me.lblInvalidSSN.Size = New System.Drawing.Size(38, 13)
        Me.lblInvalidSSN.TabIndex = 18
        Me.lblInvalidSSN.Text = "Invalid"
        Me.lblInvalidSSN.Visible = False
        '
        'DOB
        '
        Me.DOB.Location = New System.Drawing.Point(100, 118)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(113, 20)
        Me.DOB.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Notes"
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(36, 282)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(274, 119)
        Me.Notes.TabIndex = 8
        Me.Notes.Text = ""
        '
        'Phone3
        '
        Me.Phone3.Location = New System.Drawing.Point(101, 203)
        Me.Phone3.Name = "Phone3"
        Me.Phone3.Size = New System.Drawing.Size(112, 20)
        Me.Phone3.TabIndex = 7
        '
        'Phone2
        '
        Me.Phone2.Location = New System.Drawing.Point(101, 176)
        Me.Phone2.Name = "Phone2"
        Me.Phone2.Size = New System.Drawing.Size(112, 20)
        Me.Phone2.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Date of Birth:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Phone 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Phone 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Social Security:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name:"
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(100, 145)
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(113, 20)
        Me.Phone.TabIndex = 5
        '
        'SSN
        '
        Me.SSN.Location = New System.Drawing.Point(100, 91)
        Me.SSN.Name = "SSN"
        Me.SSN.Size = New System.Drawing.Size(113, 20)
        Me.SSN.TabIndex = 3
        '
        'LName
        '
        Me.LName.Location = New System.Drawing.Point(100, 64)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(113, 20)
        Me.LName.TabIndex = 2
        '
        'FName
        '
        Me.FName.Location = New System.Drawing.Point(100, 37)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(113, 20)
        Me.FName.TabIndex = 1
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(30, 431)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 9
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(113, 431)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAddTenant
        '
        Me.ClientSize = New System.Drawing.Size(376, 466)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAddTenant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Tenant"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub




    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FName As TextBox
    Friend WithEvents Phone As TextBox
    Friend WithEvents SSN As TextBox
    Friend WithEvents LName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Phone3 As TextBox
    Friend WithEvents Phone2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Notes As RichTextBox
    Friend WithEvents DOB As TextBox
    Friend WithEvents lblInvalidSSN As Label
    Friend WithEvents lblInvalidPhone As Label
End Class
