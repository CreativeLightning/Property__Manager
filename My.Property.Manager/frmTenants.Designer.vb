<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTenants
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.lblNoneFound = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboTenants = New System.Windows.Forms.ComboBox()
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.btnTakePayment = New System.Windows.Forms.Button()
        Me.grpTenantInfo = New System.Windows.Forms.GroupBox()
        Me.txtRentAmount = New System.Windows.Forms.TextBox()
        Me.lblRentAmount = New System.Windows.Forms.Label()
        Me.lblInvalidDOB = New System.Windows.Forms.Label()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.lblInvalidPhone = New System.Windows.Forms.Label()
        Me.lblInvalidSSN = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.btnRecordPaymentPrintReceipt = New System.Windows.Forms.Button()
        Me.txtPaymentDate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtPaymentIDNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTenantName = New System.Windows.Forms.Label()
        Me.btnRecordPayment = New System.Windows.Forms.Button()
        Me.cboPickProperty = New System.Windows.Forms.ComboBox()
        Me.grpRentInfo = New System.Windows.Forms.GroupBox()
        Me.chkDepositPaid = New System.Windows.Forms.CheckBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtRent = New System.Windows.Forms.TextBox()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblRent = New System.Windows.Forms.Label()
        Me.lblInvalidRentDue = New System.Windows.Forms.Label()
        Me.lblRentDue = New System.Windows.Forms.Label()
        Me.txtRentDue = New System.Windows.Forms.TextBox()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpTenantInfo.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.grpRentInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(54, 336)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(164, 106)
        Me.txtNotes.TabIndex = 30
        Me.txtNotes.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnHome)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 186)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(6, 103)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(6, 74)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
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
        Me.lblNoneFound.Location = New System.Drawing.Point(257, 16)
        Me.lblNoneFound.Name = "lblNoneFound"
        Me.lblNoneFound.Size = New System.Drawing.Size(66, 13)
        Me.lblNoneFound.TabIndex = 41
        Me.lblNoneFound.Text = "None Found"
        Me.lblNoneFound.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(124, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(127, 20)
        Me.txtSearch.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(20, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Type Tenant Name:"
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
        'lblProperty
        '
        Me.lblProperty.AutoSize = True
        Me.lblProperty.Location = New System.Drawing.Point(117, 312)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(0, 13)
        Me.lblProperty.TabIndex = 45
        '
        'btnTakePayment
        '
        Me.btnTakePayment.Location = New System.Drawing.Point(18, 307)
        Me.btnTakePayment.Name = "btnTakePayment"
        Me.btnTakePayment.Size = New System.Drawing.Size(88, 23)
        Me.btnTakePayment.TabIndex = 46
        Me.btnTakePayment.Text = "Take Payment"
        Me.btnTakePayment.UseVisualStyleBackColor = True
        Me.btnTakePayment.Visible = False
        '
        'grpTenantInfo
        '
        Me.grpTenantInfo.Controls.Add(Me.txtRentAmount)
        Me.grpTenantInfo.Controls.Add(Me.lblRentAmount)
        Me.grpTenantInfo.Controls.Add(Me.lblInvalidDOB)
        Me.grpTenantInfo.Controls.Add(Me.btnSaveNew)
        Me.grpTenantInfo.Controls.Add(Me.lblInvalidPhone)
        Me.grpTenantInfo.Controls.Add(Me.lblInvalidSSN)
        Me.grpTenantInfo.Controls.Add(Me.txtDOB)
        Me.grpTenantInfo.Controls.Add(Me.txtPhone3)
        Me.grpTenantInfo.Controls.Add(Me.txtPhone2)
        Me.grpTenantInfo.Controls.Add(Me.Label8)
        Me.grpTenantInfo.Controls.Add(Me.Label7)
        Me.grpTenantInfo.Controls.Add(Me.Label6)
        Me.grpTenantInfo.Controls.Add(Me.Label5)
        Me.grpTenantInfo.Controls.Add(Me.Label4)
        Me.grpTenantInfo.Controls.Add(Me.Label3)
        Me.grpTenantInfo.Controls.Add(Me.Label1)
        Me.grpTenantInfo.Controls.Add(Me.txtPhone)
        Me.grpTenantInfo.Controls.Add(Me.txtSSN)
        Me.grpTenantInfo.Controls.Add(Me.txtLName)
        Me.grpTenantInfo.Controls.Add(Me.txtFName)
        Me.grpTenantInfo.Controls.Add(Me.btnCancel)
        Me.grpTenantInfo.Controls.Add(Me.btnSave)
        Me.grpTenantInfo.Location = New System.Drawing.Point(111, 92)
        Me.grpTenantInfo.Name = "grpTenantInfo"
        Me.grpTenantInfo.Size = New System.Drawing.Size(336, 213)
        Me.grpTenantInfo.TabIndex = 47
        Me.grpTenantInfo.TabStop = False
        Me.grpTenantInfo.Text = "Tenant Information"
        '
        'txtRentAmount
        '
        Me.txtRentAmount.Location = New System.Drawing.Point(214, 184)
        Me.txtRentAmount.Name = "txtRentAmount"
        Me.txtRentAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtRentAmount.TabIndex = 56
        '
        'lblRentAmount
        '
        Me.lblRentAmount.AutoSize = True
        Me.lblRentAmount.Location = New System.Drawing.Point(222, 164)
        Me.lblRentAmount.Name = "lblRentAmount"
        Me.lblRentAmount.Size = New System.Drawing.Size(72, 13)
        Me.lblRentAmount.TabIndex = 65
        Me.lblRentAmount.Text = "Rent Amount:"
        '
        'lblInvalidDOB
        '
        Me.lblInvalidDOB.AutoSize = True
        Me.lblInvalidDOB.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidDOB.Location = New System.Drawing.Point(211, 103)
        Me.lblInvalidDOB.Name = "lblInvalidDOB"
        Me.lblInvalidDOB.Size = New System.Drawing.Size(64, 13)
        Me.lblInvalidDOB.TabIndex = 64
        Me.lblInvalidDOB.Text = "Invalid DOB"
        Me.lblInvalidDOB.Visible = False
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(249, 43)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNew.TabIndex = 63
        Me.btnSaveNew.Text = "Save New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        Me.btnSaveNew.Visible = False
        '
        'lblInvalidPhone
        '
        Me.lblInvalidPhone.AutoSize = True
        Me.lblInvalidPhone.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidPhone.Location = New System.Drawing.Point(211, 129)
        Me.lblInvalidPhone.Name = "lblInvalidPhone"
        Me.lblInvalidPhone.Size = New System.Drawing.Size(112, 13)
        Me.lblInvalidPhone.TabIndex = 62
        Me.lblInvalidPhone.Text = "Invalid Phone Number"
        Me.lblInvalidPhone.Visible = False
        '
        'lblInvalidSSN
        '
        Me.lblInvalidSSN.AutoSize = True
        Me.lblInvalidSSN.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidSSN.Location = New System.Drawing.Point(211, 75)
        Me.lblInvalidSSN.Name = "lblInvalidSSN"
        Me.lblInvalidSSN.Size = New System.Drawing.Size(38, 13)
        Me.lblInvalidSSN.TabIndex = 61
        Me.lblInvalidSSN.Text = "Invalid"
        Me.lblInvalidSSN.Visible = False
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(92, 99)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(113, 20)
        Me.txtDOB.TabIndex = 50
        '
        'txtPhone3
        '
        Me.txtPhone3.Location = New System.Drawing.Point(93, 184)
        Me.txtPhone3.Name = "txtPhone3"
        Me.txtPhone3.Size = New System.Drawing.Size(112, 20)
        Me.txtPhone3.TabIndex = 55
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(93, 157)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(112, 20)
        Me.txtPhone2.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Date of Birth:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Phone 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Phone 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Social Security:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "First Name:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(92, 126)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(113, 20)
        Me.txtPhone.TabIndex = 51
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(92, 72)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(113, 20)
        Me.txtSSN.TabIndex = 49
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(92, 45)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(113, 20)
        Me.txtLName.TabIndex = 48
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(92, 18)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(113, 20)
        Me.txtFName.TabIndex = 47
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(249, 70)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 46
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(249, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 45
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.btnRecordPaymentPrintReceipt)
        Me.grpPayment.Controls.Add(Me.txtPaymentDate)
        Me.grpPayment.Controls.Add(Me.Label13)
        Me.grpPayment.Controls.Add(Me.btnBack)
        Me.grpPayment.Controls.Add(Me.txtPaymentIDNumber)
        Me.grpPayment.Controls.Add(Me.Label12)
        Me.grpPayment.Controls.Add(Me.cboPaymentType)
        Me.grpPayment.Controls.Add(Me.Label11)
        Me.grpPayment.Controls.Add(Me.txtAmount)
        Me.grpPayment.Controls.Add(Me.Label10)
        Me.grpPayment.Controls.Add(Me.lblTenantName)
        Me.grpPayment.Controls.Add(Me.btnRecordPayment)
        Me.grpPayment.Location = New System.Drawing.Point(467, 92)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(309, 213)
        Me.grpPayment.TabIndex = 48
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Information"
        '
        'btnRecordPaymentPrintReceipt
        '
        Me.btnRecordPaymentPrintReceipt.Location = New System.Drawing.Point(87, 181)
        Me.btnRecordPaymentPrintReceipt.Name = "btnRecordPaymentPrintReceipt"
        Me.btnRecordPaymentPrintReceipt.Size = New System.Drawing.Size(192, 23)
        Me.btnRecordPaymentPrintReceipt.TabIndex = 63
        Me.btnRecordPaymentPrintReceipt.Text = "Record Payment and Print Receipt"
        Me.btnRecordPaymentPrintReceipt.UseVisualStyleBackColor = True
        '
        'txtPaymentDate
        '
        Me.txtPaymentDate.Location = New System.Drawing.Point(84, 46)
        Me.txtPaymentDate.Name = "txtPaymentDate"
        Me.txtPaymentDate.Size = New System.Drawing.Size(121, 20)
        Me.txtPaymentDate.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Date:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(6, 154)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 56
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtPaymentIDNumber
        '
        Me.txtPaymentIDNumber.Location = New System.Drawing.Point(83, 126)
        Me.txtPaymentIDNumber.Name = "txtPaymentIDNumber"
        Me.txtPaymentIDNumber.Size = New System.Drawing.Size(122, 20)
        Me.txtPaymentIDNumber.TabIndex = 61
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "ID Number:"
        '
        'cboPaymentType
        '
        Me.cboPaymentType.FormattingEnabled = True
        Me.cboPaymentType.Location = New System.Drawing.Point(84, 97)
        Me.cboPaymentType.Name = "cboPaymentType"
        Me.cboPaymentType.Size = New System.Drawing.Size(121, 21)
        Me.cboPaymentType.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Type:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(83, 72)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(122, 20)
        Me.txtAmount.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Amount:"
        '
        'lblTenantName
        '
        Me.lblTenantName.AutoSize = True
        Me.lblTenantName.Location = New System.Drawing.Point(28, 25)
        Me.lblTenantName.Name = "lblTenantName"
        Me.lblTenantName.Size = New System.Drawing.Size(72, 13)
        Me.lblTenantName.TabIndex = 48
        Me.lblTenantName.Text = "Tenant Name"
        '
        'btnRecordPayment
        '
        Me.btnRecordPayment.Location = New System.Drawing.Point(87, 152)
        Me.btnRecordPayment.Name = "btnRecordPayment"
        Me.btnRecordPayment.Size = New System.Drawing.Size(105, 23)
        Me.btnRecordPayment.TabIndex = 62
        Me.btnRecordPayment.Text = "Record Payment"
        Me.btnRecordPayment.UseVisualStyleBackColor = True
        '
        'cboPickProperty
        '
        Me.cboPickProperty.FormattingEnabled = True
        Me.cboPickProperty.Location = New System.Drawing.Point(251, 311)
        Me.cboPickProperty.Name = "cboPickProperty"
        Me.cboPickProperty.Size = New System.Drawing.Size(193, 21)
        Me.cboPickProperty.TabIndex = 49
        Me.cboPickProperty.Visible = False
        '
        'grpRentInfo
        '
        Me.grpRentInfo.Controls.Add(Me.btnAssign)
        Me.grpRentInfo.Controls.Add(Me.chkDepositPaid)
        Me.grpRentInfo.Controls.Add(Me.txtDeposit)
        Me.grpRentInfo.Controls.Add(Me.txtRent)
        Me.grpRentInfo.Controls.Add(Me.lblDeposit)
        Me.grpRentInfo.Controls.Add(Me.lblRent)
        Me.grpRentInfo.Controls.Add(Me.lblInvalidRentDue)
        Me.grpRentInfo.Controls.Add(Me.lblRentDue)
        Me.grpRentInfo.Controls.Add(Me.txtRentDue)
        Me.grpRentInfo.Location = New System.Drawing.Point(228, 339)
        Me.grpRentInfo.Name = "grpRentInfo"
        Me.grpRentInfo.Size = New System.Drawing.Size(219, 125)
        Me.grpRentInfo.TabIndex = 59
        Me.grpRentInfo.TabStop = False
        Me.grpRentInfo.Text = "Rent Info"
        Me.grpRentInfo.Visible = False
        '
        'chkDepositPaid
        '
        Me.chkDepositPaid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDepositPaid.AutoSize = True
        Me.chkDepositPaid.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkDepositPaid.Checked = True
        Me.chkDepositPaid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDepositPaid.Location = New System.Drawing.Point(25, 99)
        Me.chkDepositPaid.Name = "chkDepositPaid"
        Me.chkDepositPaid.Size = New System.Drawing.Size(89, 17)
        Me.chkDepositPaid.TabIndex = 67
        Me.chkDepositPaid.Text = "Deposit Paid:"
        Me.chkDepositPaid.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(41, 71)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(73, 20)
        Me.txtDeposit.TabIndex = 66
        Me.txtDeposit.WordWrap = False
        '
        'txtRent
        '
        Me.txtRent.Location = New System.Drawing.Point(41, 45)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(73, 20)
        Me.txtRent.TabIndex = 65
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(5, 71)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(30, 13)
        Me.lblDeposit.TabIndex = 64
        Me.lblDeposit.Text = "Dep:"
        '
        'lblRent
        '
        Me.lblRent.AutoSize = True
        Me.lblRent.Location = New System.Drawing.Point(1, 48)
        Me.lblRent.Name = "lblRent"
        Me.lblRent.Size = New System.Drawing.Size(33, 13)
        Me.lblRent.TabIndex = 63
        Me.lblRent.Text = "Rent:"
        '
        'lblInvalidRentDue
        '
        Me.lblInvalidRentDue.AutoSize = True
        Me.lblInvalidRentDue.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidRentDue.Location = New System.Drawing.Point(136, 45)
        Me.lblInvalidRentDue.Name = "lblInvalidRentDue"
        Me.lblInvalidRentDue.Size = New System.Drawing.Size(67, 13)
        Me.lblInvalidRentDue.TabIndex = 62
        Me.lblInvalidRentDue.Text = "Invalid Date:"
        Me.lblInvalidRentDue.Visible = False
        '
        'lblRentDue
        '
        Me.lblRentDue.AutoSize = True
        Me.lblRentDue.Location = New System.Drawing.Point(17, 16)
        Me.lblRentDue.Name = "lblRentDue"
        Me.lblRentDue.Size = New System.Drawing.Size(81, 13)
        Me.lblRentDue.TabIndex = 61
        Me.lblRentDue.Text = "Next Date Due:"
        '
        'txtRentDue
        '
        Me.txtRentDue.Location = New System.Drawing.Point(101, 13)
        Me.txtRentDue.Name = "txtRentDue"
        Me.txtRentDue.Size = New System.Drawing.Size(100, 20)
        Me.txtRentDue.TabIndex = 60
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(132, 64)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(67, 39)
        Me.btnAssign.TabIndex = 68
        Me.btnAssign.Text = "Assign Property"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'frmTenants
        '
        Me.ClientSize = New System.Drawing.Size(458, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpRentInfo)
        Me.Controls.Add(Me.cboPickProperty)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.grpTenantInfo)
        Me.Controls.Add(Me.btnTakePayment)
        Me.Controls.Add(Me.lblProperty)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNotes)
        Me.Name = "frmTenants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tenant Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.grpTenantInfo.ResumeLayout(False)
        Me.grpTenantInfo.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.grpRentInfo.ResumeLayout(False)
        Me.grpRentInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub




    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents lblNoneFound As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cboTenants As ComboBox
    Friend WithEvents lblProperty As Label
    Friend WithEvents btnTakePayment As Button
    Friend WithEvents grpTenantInfo As GroupBox
    Friend WithEvents lblInvalidDOB As Label
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents lblInvalidPhone As Label
    Friend WithEvents lblInvalidSSN As Label
    Friend WithEvents txtDOB As TextBox
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
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents btnRecordPayment As Button
    Friend WithEvents lblTenantName As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboPaymentType As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPaymentIDNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtPaymentDate As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboPickProperty As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtRentAmount As TextBox
    Friend WithEvents lblRentAmount As Label
    Friend WithEvents btnRecordPaymentPrintReceipt As Button
    Friend WithEvents grpRentInfo As GroupBox
    Friend WithEvents chkDepositPaid As CheckBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtRent As TextBox
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblRent As Label
    Friend WithEvents lblInvalidRentDue As Label
    Friend WithEvents lblRentDue As Label
    Friend WithEvents txtRentDue As TextBox
    Friend WithEvents btnAssign As Button
End Class
