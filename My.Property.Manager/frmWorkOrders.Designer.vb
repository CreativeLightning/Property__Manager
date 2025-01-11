<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkOrders
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
        Me.grpStartHere = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnWOByNumber = New System.Windows.Forms.Button()
        Me.btnWOByVendor = New System.Windows.Forms.Button()
        Me.btnWOByEmployee = New System.Windows.Forms.Button()
        Me.btnWOByProperty = New System.Windows.Forms.Button()
        Me.btnClosedWO = New System.Windows.Forms.Button()
        Me.btnOpenWO = New System.Windows.Forms.Button()
        Me.btnNewWO = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.cboSelections = New System.Windows.Forms.ComboBox()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.grpNewWO = New System.Windows.Forms.GroupBox()
        Me.btnVendors = New System.Windows.Forms.Button()
        Me.btnGetByProperty = New System.Windows.Forms.Button()
        Me.btnViewCharges = New System.Windows.Forms.Button()
        Me.btnAddCharges = New System.Windows.Forms.Button()
        Me.btnSaveNewWO = New System.Windows.Forms.Button()
        Me.btnGetByVendor = New System.Windows.Forms.Button()
        Me.btnGetByEmployee = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnCancelWO = New System.Windows.Forms.Button()
        Me.btnSaveWO = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboVendors = New System.Windows.Forms.ComboBox()
        Me.cboEmployees = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkCompleted = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProperties = New System.Windows.Forms.Label()
        Me.cboProperties = New System.Windows.Forms.ComboBox()
        Me.txtCloseDate = New System.Windows.Forms.TextBox()
        Me.txtOpenDate = New System.Windows.Forms.TextBox()
        Me.grpNewCharge = New System.Windows.Forms.GroupBox()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.btnCancelCharge = New System.Windows.Forms.Button()
        Me.btnSaveCharge = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtChargeNotes = New System.Windows.Forms.TextBox()
        Me.txtDatePaid = New System.Windows.Forms.TextBox()
        Me.txtDateBilled = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpByNumber = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtWOID = New System.Windows.Forms.TextBox()
        Me.grpCharges = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboCharges = New System.Windows.Forms.ComboBox()
        Me.chkThePaid = New System.Windows.Forms.CheckBox()
        Me.btnUpdateCharge = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTheNotes = New System.Windows.Forms.TextBox()
        Me.txtTheDatePaid = New System.Windows.Forms.TextBox()
        Me.txtTheDateBilled = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTheTotal = New System.Windows.Forms.TextBox()
        Me.txtTheLabor = New System.Windows.Forms.TextBox()
        Me.txtTheParts = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.grpStartHere.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpNewWO.SuspendLayout()
        Me.grpNewCharge.SuspendLayout()
        Me.grpByNumber.SuspendLayout()
        Me.grpCharges.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStartHere
        '
        Me.grpStartHere.Controls.Add(Me.btnExit)
        Me.grpStartHere.Controls.Add(Me.btnHome)
        Me.grpStartHere.Controls.Add(Me.btnWOByNumber)
        Me.grpStartHere.Controls.Add(Me.btnWOByVendor)
        Me.grpStartHere.Controls.Add(Me.btnWOByEmployee)
        Me.grpStartHere.Controls.Add(Me.btnWOByProperty)
        Me.grpStartHere.Controls.Add(Me.btnClosedWO)
        Me.grpStartHere.Controls.Add(Me.btnOpenWO)
        Me.grpStartHere.Controls.Add(Me.btnNewWO)
        Me.grpStartHere.Location = New System.Drawing.Point(13, 13)
        Me.grpStartHere.Name = "grpStartHere"
        Me.grpStartHere.Size = New System.Drawing.Size(146, 309)
        Me.grpStartHere.TabIndex = 0
        Me.grpStartHere.TabStop = False
        Me.grpStartHere.Text = "Start Here"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(7, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(7, 19)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(133, 23)
        Me.btnHome.TabIndex = 7
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnWOByNumber
        '
        Me.btnWOByNumber.Location = New System.Drawing.Point(7, 228)
        Me.btnWOByNumber.Name = "btnWOByNumber"
        Me.btnWOByNumber.Size = New System.Drawing.Size(133, 23)
        Me.btnWOByNumber.TabIndex = 6
        Me.btnWOByNumber.Text = "WO By Number"
        Me.btnWOByNumber.UseVisualStyleBackColor = True
        '
        'btnWOByVendor
        '
        Me.btnWOByVendor.Location = New System.Drawing.Point(6, 199)
        Me.btnWOByVendor.Name = "btnWOByVendor"
        Me.btnWOByVendor.Size = New System.Drawing.Size(133, 23)
        Me.btnWOByVendor.TabIndex = 5
        Me.btnWOByVendor.Text = "WO By Vendor"
        Me.btnWOByVendor.UseVisualStyleBackColor = True
        '
        'btnWOByEmployee
        '
        Me.btnWOByEmployee.Location = New System.Drawing.Point(6, 170)
        Me.btnWOByEmployee.Name = "btnWOByEmployee"
        Me.btnWOByEmployee.Size = New System.Drawing.Size(133, 23)
        Me.btnWOByEmployee.TabIndex = 4
        Me.btnWOByEmployee.Text = "WO By Employee"
        Me.btnWOByEmployee.UseVisualStyleBackColor = True
        '
        'btnWOByProperty
        '
        Me.btnWOByProperty.Location = New System.Drawing.Point(7, 141)
        Me.btnWOByProperty.Name = "btnWOByProperty"
        Me.btnWOByProperty.Size = New System.Drawing.Size(133, 23)
        Me.btnWOByProperty.TabIndex = 3
        Me.btnWOByProperty.Text = "WO By Property"
        Me.btnWOByProperty.UseVisualStyleBackColor = True
        '
        'btnClosedWO
        '
        Me.btnClosedWO.Location = New System.Drawing.Point(6, 112)
        Me.btnClosedWO.Name = "btnClosedWO"
        Me.btnClosedWO.Size = New System.Drawing.Size(133, 23)
        Me.btnClosedWO.TabIndex = 2
        Me.btnClosedWO.Text = "Closed Work Orders"
        Me.btnClosedWO.UseVisualStyleBackColor = True
        '
        'btnOpenWO
        '
        Me.btnOpenWO.Location = New System.Drawing.Point(6, 83)
        Me.btnOpenWO.Name = "btnOpenWO"
        Me.btnOpenWO.Size = New System.Drawing.Size(133, 23)
        Me.btnOpenWO.TabIndex = 1
        Me.btnOpenWO.Text = "Open Work Orders"
        Me.btnOpenWO.UseVisualStyleBackColor = True
        '
        'btnNewWO
        '
        Me.btnNewWO.Location = New System.Drawing.Point(7, 54)
        Me.btnNewWO.Name = "btnNewWO"
        Me.btnNewWO.Size = New System.Drawing.Size(133, 23)
        Me.btnNewWO.TabIndex = 0
        Me.btnNewWO.Text = "New Work Order"
        Me.btnNewWO.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.cboSelections)
        Me.grpSearch.Controls.Add(Me.lblChoose)
        Me.grpSearch.Location = New System.Drawing.Point(166, 13)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(462, 62)
        Me.grpSearch.TabIndex = 1
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Make Selection"
        '
        'cboSelections
        '
        Me.cboSelections.FormattingEnabled = True
        Me.cboSelections.Location = New System.Drawing.Point(124, 21)
        Me.cboSelections.Name = "cboSelections"
        Me.cboSelections.Size = New System.Drawing.Size(274, 21)
        Me.cboSelections.TabIndex = 1
        '
        'lblChoose
        '
        Me.lblChoose.Location = New System.Drawing.Point(7, 20)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(110, 23)
        Me.lblChoose.TabIndex = 0
        Me.lblChoose.Text = "Choose:"
        Me.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblChoose.Visible = False
        '
        'grpNewWO
        '
        Me.grpNewWO.Controls.Add(Me.btnVendors)
        Me.grpNewWO.Controls.Add(Me.btnGetByProperty)
        Me.grpNewWO.Controls.Add(Me.btnViewCharges)
        Me.grpNewWO.Controls.Add(Me.btnAddCharges)
        Me.grpNewWO.Controls.Add(Me.btnSaveNewWO)
        Me.grpNewWO.Controls.Add(Me.btnGetByVendor)
        Me.grpNewWO.Controls.Add(Me.btnGetByEmployee)
        Me.grpNewWO.Controls.Add(Me.txtNotes)
        Me.grpNewWO.Controls.Add(Me.Label7)
        Me.grpNewWO.Controls.Add(Me.Label6)
        Me.grpNewWO.Controls.Add(Me.txtDescription)
        Me.grpNewWO.Controls.Add(Me.btnCancelWO)
        Me.grpNewWO.Controls.Add(Me.btnSaveWO)
        Me.grpNewWO.Controls.Add(Me.Label5)
        Me.grpNewWO.Controls.Add(Me.cboVendors)
        Me.grpNewWO.Controls.Add(Me.cboEmployees)
        Me.grpNewWO.Controls.Add(Me.Label4)
        Me.grpNewWO.Controls.Add(Me.chkCompleted)
        Me.grpNewWO.Controls.Add(Me.Label3)
        Me.grpNewWO.Controls.Add(Me.Label2)
        Me.grpNewWO.Controls.Add(Me.lblProperties)
        Me.grpNewWO.Controls.Add(Me.cboProperties)
        Me.grpNewWO.Controls.Add(Me.txtCloseDate)
        Me.grpNewWO.Controls.Add(Me.txtOpenDate)
        Me.grpNewWO.Location = New System.Drawing.Point(166, 81)
        Me.grpNewWO.Name = "grpNewWO"
        Me.grpNewWO.Size = New System.Drawing.Size(462, 241)
        Me.grpNewWO.TabIndex = 2
        Me.grpNewWO.TabStop = False
        Me.grpNewWO.Text = "Work Order Details"
        Me.grpNewWO.Visible = False
        '
        'btnVendors
        '
        Me.btnVendors.Location = New System.Drawing.Point(372, 70)
        Me.btnVendors.Name = "btnVendors"
        Me.btnVendors.Size = New System.Drawing.Size(75, 23)
        Me.btnVendors.TabIndex = 24
        Me.btnVendors.Text = "Vendors"
        Me.btnVendors.UseVisualStyleBackColor = True
        '
        'btnGetByProperty
        '
        Me.btnGetByProperty.Location = New System.Drawing.Point(372, 44)
        Me.btnGetByProperty.Name = "btnGetByProperty"
        Me.btnGetByProperty.Size = New System.Drawing.Size(75, 23)
        Me.btnGetByProperty.TabIndex = 23
        Me.btnGetByProperty.Text = "Get WOs"
        Me.btnGetByProperty.UseVisualStyleBackColor = True
        Me.btnGetByProperty.Visible = False
        '
        'btnViewCharges
        '
        Me.btnViewCharges.Location = New System.Drawing.Point(388, 124)
        Me.btnViewCharges.Name = "btnViewCharges"
        Me.btnViewCharges.Size = New System.Drawing.Size(56, 23)
        Me.btnViewCharges.TabIndex = 22
        Me.btnViewCharges.Text = "Charges"
        Me.btnViewCharges.UseVisualStyleBackColor = True
        Me.btnViewCharges.Visible = False
        '
        'btnAddCharges
        '
        Me.btnAddCharges.Location = New System.Drawing.Point(298, 122)
        Me.btnAddCharges.Name = "btnAddCharges"
        Me.btnAddCharges.Size = New System.Drawing.Size(84, 23)
        Me.btnAddCharges.TabIndex = 21
        Me.btnAddCharges.Text = "Add Charges"
        Me.btnAddCharges.UseVisualStyleBackColor = True
        Me.btnAddCharges.Visible = False
        '
        'btnSaveNewWO
        '
        Me.btnSaveNewWO.Location = New System.Drawing.Point(277, 94)
        Me.btnSaveNewWO.Name = "btnSaveNewWO"
        Me.btnSaveNewWO.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNewWO.TabIndex = 20
        Me.btnSaveNewWO.Text = "Save New"
        Me.btnSaveNewWO.UseVisualStyleBackColor = True
        Me.btnSaveNewWO.Visible = False
        '
        'btnGetByVendor
        '
        Me.btnGetByVendor.Location = New System.Drawing.Point(38, 124)
        Me.btnGetByVendor.Name = "btnGetByVendor"
        Me.btnGetByVendor.Size = New System.Drawing.Size(34, 23)
        Me.btnGetByVendor.TabIndex = 19
        Me.btnGetByVendor.Text = "Get"
        Me.btnGetByVendor.UseVisualStyleBackColor = True
        '
        'btnGetByEmployee
        '
        Me.btnGetByEmployee.Location = New System.Drawing.Point(16, 96)
        Me.btnGetByEmployee.Name = "btnGetByEmployee"
        Me.btnGetByEmployee.Size = New System.Drawing.Size(37, 23)
        Me.btnGetByEmployee.TabIndex = 18
        Me.btnGetByEmployee.Text = "Get"
        Me.btnGetByEmployee.UseVisualStyleBackColor = True
        Me.btnGetByEmployee.Visible = False
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(104, 184)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(343, 49)
        Me.txtNotes.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Notes:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Short Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(153, 153)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(294, 20)
        Me.txtDescription.TabIndex = 14
        '
        'btnCancelWO
        '
        Me.btnCancelWO.Location = New System.Drawing.Point(307, 124)
        Me.btnCancelWO.Name = "btnCancelWO"
        Me.btnCancelWO.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelWO.TabIndex = 13
        Me.btnCancelWO.Text = "Cancel WO"
        Me.btnCancelWO.UseVisualStyleBackColor = True
        '
        'btnSaveWO
        '
        Me.btnSaveWO.Location = New System.Drawing.Point(307, 93)
        Me.btnSaveWO.Name = "btnSaveWO"
        Me.btnSaveWO.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveWO.TabIndex = 12
        Me.btnSaveWO.Text = "Save WO"
        Me.btnSaveWO.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Vendor:"
        '
        'cboVendors
        '
        Me.cboVendors.FormattingEnabled = True
        Me.cboVendors.Location = New System.Drawing.Point(130, 126)
        Me.cboVendors.Name = "cboVendors"
        Me.cboVendors.Size = New System.Drawing.Size(134, 21)
        Me.cboVendors.TabIndex = 10
        '
        'cboEmployees
        '
        Me.cboEmployees.FormattingEnabled = True
        Me.cboEmployees.Location = New System.Drawing.Point(130, 96)
        Me.cboEmployees.Name = "cboEmployees"
        Me.cboEmployees.Size = New System.Drawing.Size(134, 21)
        Me.cboEmployees.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Assigned To:"
        '
        'chkCompleted
        '
        Me.chkCompleted.AutoSize = True
        Me.chkCompleted.Location = New System.Drawing.Point(268, 46)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Size = New System.Drawing.Size(76, 17)
        Me.chkCompleted.TabIndex = 7
        Me.chkCompleted.Text = "Completed"
        Me.chkCompleted.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Close Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Open Date:"
        '
        'lblProperties
        '
        Me.lblProperties.AutoSize = True
        Me.lblProperties.Location = New System.Drawing.Point(67, 20)
        Me.lblProperties.Name = "lblProperties"
        Me.lblProperties.Size = New System.Drawing.Size(88, 13)
        Me.lblProperties.TabIndex = 3
        Me.lblProperties.Text = "Choose Property:"
        '
        'cboProperties
        '
        Me.cboProperties.FormattingEnabled = True
        Me.cboProperties.Location = New System.Drawing.Point(161, 17)
        Me.cboProperties.Name = "cboProperties"
        Me.cboProperties.Size = New System.Drawing.Size(286, 21)
        Me.cboProperties.TabIndex = 2
        '
        'txtCloseDate
        '
        Me.txtCloseDate.Location = New System.Drawing.Point(130, 70)
        Me.txtCloseDate.Name = "txtCloseDate"
        Me.txtCloseDate.Size = New System.Drawing.Size(100, 20)
        Me.txtCloseDate.TabIndex = 4
        '
        'txtOpenDate
        '
        Me.txtOpenDate.Location = New System.Drawing.Point(130, 44)
        Me.txtOpenDate.Name = "txtOpenDate"
        Me.txtOpenDate.Size = New System.Drawing.Size(100, 20)
        Me.txtOpenDate.TabIndex = 3
        '
        'grpNewCharge
        '
        Me.grpNewCharge.Controls.Add(Me.chkPaid)
        Me.grpNewCharge.Controls.Add(Me.btnCancelCharge)
        Me.grpNewCharge.Controls.Add(Me.btnSaveCharge)
        Me.grpNewCharge.Controls.Add(Me.Label12)
        Me.grpNewCharge.Controls.Add(Me.txtChargeNotes)
        Me.grpNewCharge.Controls.Add(Me.txtDatePaid)
        Me.grpNewCharge.Controls.Add(Me.txtDateBilled)
        Me.grpNewCharge.Controls.Add(Me.Label11)
        Me.grpNewCharge.Controls.Add(Me.Label10)
        Me.grpNewCharge.Controls.Add(Me.txtTotal)
        Me.grpNewCharge.Controls.Add(Me.txtLabor)
        Me.grpNewCharge.Controls.Add(Me.txtParts)
        Me.grpNewCharge.Controls.Add(Me.Label9)
        Me.grpNewCharge.Controls.Add(Me.Label8)
        Me.grpNewCharge.Controls.Add(Me.Label1)
        Me.grpNewCharge.Location = New System.Drawing.Point(166, 328)
        Me.grpNewCharge.Name = "grpNewCharge"
        Me.grpNewCharge.Size = New System.Drawing.Size(462, 161)
        Me.grpNewCharge.TabIndex = 3
        Me.grpNewCharge.TabStop = False
        Me.grpNewCharge.Text = "New Charge Information"
        Me.grpNewCharge.Visible = False
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(335, 22)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(47, 17)
        Me.chkPaid.TabIndex = 13
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'btnCancelCharge
        '
        Me.btnCancelCharge.Location = New System.Drawing.Point(28, 128)
        Me.btnCancelCharge.Name = "btnCancelCharge"
        Me.btnCancelCharge.Size = New System.Drawing.Size(102, 23)
        Me.btnCancelCharge.TabIndex = 12
        Me.btnCancelCharge.Text = "Cancel Charge"
        Me.btnCancelCharge.UseVisualStyleBackColor = True
        '
        'btnSaveCharge
        '
        Me.btnSaveCharge.Location = New System.Drawing.Point(28, 99)
        Me.btnSaveCharge.Name = "btnSaveCharge"
        Me.btnSaveCharge.Size = New System.Drawing.Size(102, 23)
        Me.btnSaveCharge.TabIndex = 11
        Me.btnSaveCharge.Text = "Save Charge"
        Me.btnSaveCharge.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(168, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Charge Notes:"
        '
        'txtChargeNotes
        '
        Me.txtChargeNotes.Location = New System.Drawing.Point(168, 99)
        Me.txtChargeNotes.Multiline = True
        Me.txtChargeNotes.Name = "txtChargeNotes"
        Me.txtChargeNotes.Size = New System.Drawing.Size(254, 56)
        Me.txtChargeNotes.TabIndex = 9
        '
        'txtDatePaid
        '
        Me.txtDatePaid.Location = New System.Drawing.Point(228, 46)
        Me.txtDatePaid.Name = "txtDatePaid"
        Me.txtDatePaid.Size = New System.Drawing.Size(100, 20)
        Me.txtDatePaid.TabIndex = 8
        '
        'txtDateBilled
        '
        Me.txtDateBilled.Location = New System.Drawing.Point(228, 20)
        Me.txtDateBilled.Name = "txtDateBilled"
        Me.txtDateBilled.Size = New System.Drawing.Size(100, 20)
        Me.txtDateBilled.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(165, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Date Paid:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(161, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Date Billed:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(55, 72)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.Visible = False
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(55, 46)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 20)
        Me.txtLabor.TabIndex = 4
        Me.txtLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(55, 20)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 20)
        Me.txtParts.TabIndex = 3
        Me.txtParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total:"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Labor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parts:"
        '
        'grpByNumber
        '
        Me.grpByNumber.Controls.Add(Me.btnSearch)
        Me.grpByNumber.Controls.Add(Me.txtWOID)
        Me.grpByNumber.Location = New System.Drawing.Point(13, 332)
        Me.grpByNumber.Name = "grpByNumber"
        Me.grpByNumber.Size = New System.Drawing.Size(146, 75)
        Me.grpByNumber.TabIndex = 4
        Me.grpByNumber.TabStop = False
        Me.grpByNumber.Text = "Enter WO Number"
        Me.grpByNumber.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(7, 46)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtWOID
        '
        Me.txtWOID.Location = New System.Drawing.Point(6, 19)
        Me.txtWOID.Name = "txtWOID"
        Me.txtWOID.Size = New System.Drawing.Size(100, 20)
        Me.txtWOID.TabIndex = 0
        '
        'grpCharges
        '
        Me.grpCharges.Controls.Add(Me.Label19)
        Me.grpCharges.Controls.Add(Me.cboCharges)
        Me.grpCharges.Controls.Add(Me.chkThePaid)
        Me.grpCharges.Controls.Add(Me.btnUpdateCharge)
        Me.grpCharges.Controls.Add(Me.Label13)
        Me.grpCharges.Controls.Add(Me.txtTheNotes)
        Me.grpCharges.Controls.Add(Me.txtTheDatePaid)
        Me.grpCharges.Controls.Add(Me.txtTheDateBilled)
        Me.grpCharges.Controls.Add(Me.Label14)
        Me.grpCharges.Controls.Add(Me.Label15)
        Me.grpCharges.Controls.Add(Me.txtTheTotal)
        Me.grpCharges.Controls.Add(Me.txtTheLabor)
        Me.grpCharges.Controls.Add(Me.txtTheParts)
        Me.grpCharges.Controls.Add(Me.Label16)
        Me.grpCharges.Controls.Add(Me.Label17)
        Me.grpCharges.Controls.Add(Me.Label18)
        Me.grpCharges.Location = New System.Drawing.Point(648, 332)
        Me.grpCharges.Name = "grpCharges"
        Me.grpCharges.Size = New System.Drawing.Size(462, 157)
        Me.grpCharges.TabIndex = 5
        Me.grpCharges.TabStop = False
        Me.grpCharges.Text = "Charge Information"
        Me.grpCharges.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Choose:"
        '
        'cboCharges
        '
        Me.cboCharges.FormattingEnabled = True
        Me.cboCharges.Location = New System.Drawing.Point(56, 20)
        Me.cboCharges.Name = "cboCharges"
        Me.cboCharges.Size = New System.Drawing.Size(99, 21)
        Me.cboCharges.TabIndex = 14
        '
        'chkThePaid
        '
        Me.chkThePaid.AutoSize = True
        Me.chkThePaid.Location = New System.Drawing.Point(335, 22)
        Me.chkThePaid.Name = "chkThePaid"
        Me.chkThePaid.Size = New System.Drawing.Size(47, 17)
        Me.chkThePaid.TabIndex = 13
        Me.chkThePaid.Text = "Paid"
        Me.chkThePaid.UseVisualStyleBackColor = True
        '
        'btnUpdateCharge
        '
        Me.btnUpdateCharge.Location = New System.Drawing.Point(335, 70)
        Me.btnUpdateCharge.Name = "btnUpdateCharge"
        Me.btnUpdateCharge.Size = New System.Drawing.Size(102, 23)
        Me.btnUpdateCharge.TabIndex = 11
        Me.btnUpdateCharge.Text = "Update Charge"
        Me.btnUpdateCharge.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(168, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Charge Notes:"
        '
        'txtTheNotes
        '
        Me.txtTheNotes.Location = New System.Drawing.Point(168, 99)
        Me.txtTheNotes.Multiline = True
        Me.txtTheNotes.Name = "txtTheNotes"
        Me.txtTheNotes.Size = New System.Drawing.Size(254, 56)
        Me.txtTheNotes.TabIndex = 9
        '
        'txtTheDatePaid
        '
        Me.txtTheDatePaid.Location = New System.Drawing.Point(228, 46)
        Me.txtTheDatePaid.Name = "txtTheDatePaid"
        Me.txtTheDatePaid.Size = New System.Drawing.Size(100, 20)
        Me.txtTheDatePaid.TabIndex = 8
        '
        'txtTheDateBilled
        '
        Me.txtTheDateBilled.Location = New System.Drawing.Point(228, 20)
        Me.txtTheDateBilled.Name = "txtTheDateBilled"
        Me.txtTheDateBilled.Size = New System.Drawing.Size(100, 20)
        Me.txtTheDateBilled.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(165, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Date Paid:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(161, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Date Billed:"
        '
        'txtTheTotal
        '
        Me.txtTheTotal.Location = New System.Drawing.Point(56, 101)
        Me.txtTheTotal.Name = "txtTheTotal"
        Me.txtTheTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTheTotal.TabIndex = 5
        Me.txtTheTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTheTotal.Visible = False
        '
        'txtTheLabor
        '
        Me.txtTheLabor.Location = New System.Drawing.Point(56, 75)
        Me.txtTheLabor.Name = "txtTheLabor"
        Me.txtTheLabor.Size = New System.Drawing.Size(100, 20)
        Me.txtTheLabor.TabIndex = 4
        Me.txtTheLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTheParts
        '
        Me.txtTheParts.Location = New System.Drawing.Point(56, 49)
        Me.txtTheParts.Name = "txtTheParts"
        Me.txtTheParts.Size = New System.Drawing.Size(100, 20)
        Me.txtTheParts.TabIndex = 3
        Me.txtTheParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Total:"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Labor:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Parts:"
        '
        'frmWorkOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 493)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpCharges)
        Me.Controls.Add(Me.grpByNumber)
        Me.Controls.Add(Me.grpNewCharge)
        Me.Controls.Add(Me.grpNewWO)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpStartHere)
        Me.Name = "frmWorkOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Order Management"
        Me.grpStartHere.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpNewWO.ResumeLayout(False)
        Me.grpNewWO.PerformLayout()
        Me.grpNewCharge.ResumeLayout(False)
        Me.grpNewCharge.PerformLayout()
        Me.grpByNumber.ResumeLayout(False)
        Me.grpByNumber.PerformLayout()
        Me.grpCharges.ResumeLayout(False)
        Me.grpCharges.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpStartHere As GroupBox
    Friend WithEvents btnWOByVendor As Button
    Friend WithEvents btnWOByEmployee As Button
    Friend WithEvents btnWOByProperty As Button
    Friend WithEvents btnClosedWO As Button
    Friend WithEvents btnOpenWO As Button
    Friend WithEvents btnNewWO As Button
    Friend WithEvents btnWOByNumber As Button
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents cboSelections As ComboBox
    Friend WithEvents lblChoose As Label
    Friend WithEvents grpNewWO As GroupBox
    Friend WithEvents txtOpenDate As TextBox
    Friend WithEvents txtCloseDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProperties As Label
    Friend WithEvents cboProperties As ComboBox
    Friend WithEvents chkCompleted As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboEmployees As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboVendors As ComboBox
    Friend WithEvents btnCancelWO As Button
    Friend WithEvents btnSaveWO As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnGetByEmployee As Button
    Friend WithEvents btnGetByVendor As Button
    Friend WithEvents btnSaveNewWO As Button
    Friend WithEvents btnAddCharges As Button
    Friend WithEvents grpNewCharge As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtChargeNotes As TextBox
    Friend WithEvents txtDatePaid As TextBox
    Friend WithEvents txtDateBilled As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCancelCharge As Button
    Friend WithEvents btnSaveCharge As Button
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnViewCharges As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGetByProperty As Button
    Friend WithEvents grpByNumber As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtWOID As TextBox
    Friend WithEvents btnVendors As Button
    Friend WithEvents grpCharges As GroupBox
    Friend WithEvents chkThePaid As CheckBox
    Friend WithEvents btnUpdateCharge As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTheNotes As TextBox
    Friend WithEvents txtTheDatePaid As TextBox
    Friend WithEvents txtTheDateBilled As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTheTotal As TextBox
    Friend WithEvents txtTheLabor As TextBox
    Friend WithEvents txtTheParts As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cboCharges As ComboBox
End Class
