<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendors
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboVendors = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVendorName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtPhone2 = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.chkVendorType = New System.Windows.Forms.CheckBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.lblInvalid = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTaxID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTaxID)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblInvalid)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.chkVendorType)
        Me.GroupBox1.Controls.Add(Me.txtFax)
        Me.GroupBox1.Controls.Add(Me.txtPhone2)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtAddress2)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtVendorName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboVendors)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 441)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vendors Information"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(13, 460)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(277, 460)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(94, 460)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(175, 460)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboVendors
        '
        Me.cboVendors.FormattingEnabled = True
        Me.cboVendors.Location = New System.Drawing.Point(81, 26)
        Me.cboVendors.Name = "cboVendors"
        Me.cboVendors.Size = New System.Drawing.Size(239, 21)
        Me.cboVendors.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "State"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Zip:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total Billed:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(179, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total Paid:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Notes:"
        '
        'txtVendorName
        '
        Me.txtVendorName.Location = New System.Drawing.Point(81, 52)
        Me.txtVendorName.Name = "txtVendorName"
        Me.txtVendorName.Size = New System.Drawing.Size(156, 20)
        Me.txtVendorName.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(81, 79)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(156, 20)
        Me.txtAddress.TabIndex = 12
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(81, 105)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(156, 20)
        Me.txtAddress2.TabIndex = 13
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(81, 131)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(156, 20)
        Me.txtCity.TabIndex = 14
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(81, 157)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(156, 20)
        Me.txtState.TabIndex = 15
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(81, 183)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(156, 20)
        Me.txtZip.TabIndex = 16
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(81, 235)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(156, 20)
        Me.txtPhone.TabIndex = 18
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(81, 261)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(156, 20)
        Me.txtPhone2.TabIndex = 19
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(81, 287)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(156, 20)
        Me.txtFax.TabIndex = 20
        '
        'chkVendorType
        '
        Me.chkVendorType.AutoSize = True
        Me.chkVendorType.Location = New System.Drawing.Point(81, 212)
        Me.chkVendorType.Name = "chkVendorType"
        Me.chkVendorType.Size = New System.Drawing.Size(61, 17)
        Me.chkVendorType.TabIndex = 21
        Me.chkVendorType.Text = "Internal"
        Me.chkVendorType.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(81, 354)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(239, 81)
        Me.txtNotes.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Phone:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Phone 2:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Fax:"
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(94, 460)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNew.TabIndex = 5
        Me.btnSaveNew.Text = "Save New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        Me.btnSaveNew.Visible = False
        '
        'lblInvalid
        '
        Me.lblInvalid.AutoSize = True
        Me.lblInvalid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInvalid.ForeColor = System.Drawing.Color.Red
        Me.lblInvalid.Location = New System.Drawing.Point(243, 238)
        Me.lblInvalid.Name = "lblInvalid"
        Me.lblInvalid.Size = New System.Drawing.Size(38, 13)
        Me.lblInvalid.TabIndex = 26
        Me.lblInvalid.Text = "Invalid"
        Me.lblInvalid.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 316)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Tax ID:"
        '
        'txtTaxID
        '
        Me.txtTaxID.Location = New System.Drawing.Point(82, 314)
        Me.txtTaxID.Name = "txtTaxID"
        Me.txtTaxID.Size = New System.Drawing.Size(155, 20)
        Me.txtTaxID.TabIndex = 28
        '
        'frmVendors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 495)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmVendors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendor Managment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cboVendors As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtVendorName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtPhone2 As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents chkVendorType As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents lblInvalid As Label
    Friend WithEvents txtTaxID As TextBox
    Friend WithEvents Label14 As Label
End Class
