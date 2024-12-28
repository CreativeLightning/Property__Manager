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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblInvalidPhone = New System.Windows.Forms.Label()
        Me.lblInvalidSSN = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.txtPhone3 = New System.Windows.Forms.TextBox()
        Me.txtPhone2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.lblNoneFound = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboTenants = New System.Windows.Forms.ComboBox()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.lblInvalidDOB = New System.Windows.Forms.Label()
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(352, 98)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(352, 152)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'lblInvalidPhone
        '
        Me.lblInvalidPhone.AutoSize = True
        Me.lblInvalidPhone.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidPhone.Location = New System.Drawing.Point(314, 211)
        Me.lblInvalidPhone.Name = "lblInvalidPhone"
        Me.lblInvalidPhone.Size = New System.Drawing.Size(112, 13)
        Me.lblInvalidPhone.TabIndex = 37
        Me.lblInvalidPhone.Text = "Invalid Phone Number"
        Me.lblInvalidPhone.Visible = False
        '
        'lblInvalidSSN
        '
        Me.lblInvalidSSN.AutoSize = True
        Me.lblInvalidSSN.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidSSN.Location = New System.Drawing.Point(314, 157)
        Me.lblInvalidSSN.Name = "lblInvalidSSN"
        Me.lblInvalidSSN.Size = New System.Drawing.Size(38, 13)
        Me.lblInvalidSSN.TabIndex = 36
        Me.lblInvalidSSN.Text = "Invalid"
        Me.lblInvalidSSN.Visible = False
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(195, 181)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(113, 20)
        Me.txtDOB.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(18, 313)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(426, 98)
        Me.txtNotes.TabIndex = 30
        Me.txtNotes.Text = ""
        '
        'txtPhone3
        '
        Me.txtPhone3.Location = New System.Drawing.Point(196, 266)
        Me.txtPhone3.Name = "txtPhone3"
        Me.txtPhone3.Size = New System.Drawing.Size(112, 20)
        Me.txtPhone3.TabIndex = 28
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(196, 239)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(112, 20)
        Me.txtPhone2.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Date of Birth:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(139, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Phone 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Phone 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Social Security:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "First Name:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(195, 208)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(113, 20)
        Me.txtPhone.TabIndex = 24
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(195, 154)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(113, 20)
        Me.txtSSN.TabIndex = 22
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(195, 127)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(113, 20)
        Me.txtLName.TabIndex = 21
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(195, 100)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(113, 20)
        Me.txtFName.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHome)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 186)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(6, 19)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 45)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Tenant"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.lblNoneFound)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.Label18)
        Me.grpSearch.Controls.Add(Me.Label17)
        Me.grpSearch.Controls.Add(Me.cboTenants)
        Me.grpSearch.Location = New System.Drawing.Point(111, 12)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(333, 74)
        Me.grpSearch.TabIndex = 42
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'lblNoneFound
        '
        Me.lblNoneFound.AutoSize = True
        Me.lblNoneFound.ForeColor = System.Drawing.Color.Red
        Me.lblNoneFound.Location = New System.Drawing.Point(250, 19)
        Me.lblNoneFound.Name = "lblNoneFound"
        Me.lblNoneFound.Size = New System.Drawing.Size(66, 13)
        Me.lblNoneFound.TabIndex = 41
        Me.lblNoneFound.Text = "None Found"
        Me.lblNoneFound.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(107, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(127, 20)
        Me.txtSearch.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(20, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Tenant Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Select Tenant:"
        '
        'cboTenants
        '
        Me.cboTenants.FormattingEnabled = True
        Me.cboTenants.Location = New System.Drawing.Point(106, 41)
        Me.cboTenants.Name = "cboTenants"
        Me.cboTenants.Size = New System.Drawing.Size(210, 21)
        Me.cboTenants.TabIndex = 38
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(352, 124)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNew.TabIndex = 43
        Me.btnSaveNew.Text = "Save New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        Me.btnSaveNew.Visible = False
        '
        'lblInvalidDOB
        '
        Me.lblInvalidDOB.AutoSize = True
        Me.lblInvalidDOB.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidDOB.Location = New System.Drawing.Point(314, 185)
        Me.lblInvalidDOB.Name = "lblInvalidDOB"
        Me.lblInvalidDOB.Size = New System.Drawing.Size(64, 13)
        Me.lblInvalidDOB.TabIndex = 44
        Me.lblInvalidDOB.Text = "Invalid DOB"
        Me.lblInvalidDOB.Visible = False
        '
        'lblProperty
        '
        Me.lblProperty.AutoSize = True
        Me.lblProperty.Location = New System.Drawing.Point(142, 294)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(0, 13)
        Me.lblProperty.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTenants
        '
        Me.ClientSize = New System.Drawing.Size(456, 424)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblProperty)
        Me.Controls.Add(Me.lblInvalidDOB)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblInvalidPhone)
        Me.Controls.Add(Me.lblInvalidSSN)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtPhone3)
        Me.Controls.Add(Me.txtPhone2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmTenants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tenant Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub




    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblInvalidPhone As Label
    Friend WithEvents lblInvalidSSN As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents txtPhone3 As TextBox
    Friend WithEvents txtPhone2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtSSN As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents lblNoneFound As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cboTenants As ComboBox
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents lblInvalidDOB As Label
    Friend WithEvents lblProperty As Label
    Friend WithEvents Button1 As Button
End Class
