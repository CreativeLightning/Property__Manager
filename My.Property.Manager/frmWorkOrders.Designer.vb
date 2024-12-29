<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkOrders
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
        Me.grpCharges = New System.Windows.Forms.GroupBox()
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
        Me.btnGetByProperty = New System.Windows.Forms.Button()
        Me.grpStartHere.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpNewWO.SuspendLayout()
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
        Me.grpSearch.Size = New System.Drawing.Size(417, 62)
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
        Me.grpNewWO.Size = New System.Drawing.Size(417, 241)
        Me.grpNewWO.TabIndex = 2
        Me.grpNewWO.TabStop = False
        Me.grpNewWO.Text = "Work Order Details"
        Me.grpNewWO.Visible = False
        '
        'btnViewCharges
        '
        Me.btnViewCharges.Location = New System.Drawing.Point(314, 126)
        Me.btnViewCharges.Name = "btnViewCharges"
        Me.btnViewCharges.Size = New System.Drawing.Size(84, 23)
        Me.btnViewCharges.TabIndex = 22
        Me.btnViewCharges.Text = "Charges"
        Me.btnViewCharges.UseVisualStyleBackColor = True
        Me.btnViewCharges.Visible = False
        '
        'btnAddCharges
        '
        Me.btnAddCharges.Location = New System.Drawing.Point(228, 126)
        Me.btnAddCharges.Name = "btnAddCharges"
        Me.btnAddCharges.Size = New System.Drawing.Size(84, 23)
        Me.btnAddCharges.TabIndex = 21
        Me.btnAddCharges.Text = "Add Charges"
        Me.btnAddCharges.UseVisualStyleBackColor = True
        Me.btnAddCharges.Visible = False
        '
        'btnSaveNewWO
        '
        Me.btnSaveNewWO.Location = New System.Drawing.Point(228, 96)
        Me.btnSaveNewWO.Name = "btnSaveNewWO"
        Me.btnSaveNewWO.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveNewWO.TabIndex = 20
        Me.btnSaveNewWO.Text = "Save New"
        Me.btnSaveNewWO.UseVisualStyleBackColor = True
        Me.btnSaveNewWO.Visible = False
        '
        'btnGetByVendor
        '
        Me.btnGetByVendor.Location = New System.Drawing.Point(258, 126)
        Me.btnGetByVendor.Name = "btnGetByVendor"
        Me.btnGetByVendor.Size = New System.Drawing.Size(75, 23)
        Me.btnGetByVendor.TabIndex = 19
        Me.btnGetByVendor.Text = "Get WOs"
        Me.btnGetByVendor.UseVisualStyleBackColor = True
        '
        'btnGetByEmployee
        '
        Me.btnGetByEmployee.Location = New System.Drawing.Point(258, 95)
        Me.btnGetByEmployee.Name = "btnGetByEmployee"
        Me.btnGetByEmployee.Size = New System.Drawing.Size(75, 23)
        Me.btnGetByEmployee.TabIndex = 18
        Me.btnGetByEmployee.Text = "Get WOs"
        Me.btnGetByEmployee.UseVisualStyleBackColor = True
        Me.btnGetByEmployee.Visible = False
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(55, 186)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(343, 49)
        Me.txtNotes.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Notes:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Short Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(104, 155)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(294, 20)
        Me.txtDescription.TabIndex = 14
        '
        'btnCancelWO
        '
        Me.btnCancelWO.Location = New System.Drawing.Point(258, 126)
        Me.btnCancelWO.Name = "btnCancelWO"
        Me.btnCancelWO.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelWO.TabIndex = 13
        Me.btnCancelWO.Text = "Cancel WO"
        Me.btnCancelWO.UseVisualStyleBackColor = True
        '
        'btnSaveWO
        '
        Me.btnSaveWO.Location = New System.Drawing.Point(258, 95)
        Me.btnSaveWO.Name = "btnSaveWO"
        Me.btnSaveWO.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveWO.TabIndex = 12
        Me.btnSaveWO.Text = "Save WO"
        Me.btnSaveWO.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Vendor:"
        '
        'cboVendors
        '
        Me.cboVendors.FormattingEnabled = True
        Me.cboVendors.Location = New System.Drawing.Point(81, 128)
        Me.cboVendors.Name = "cboVendors"
        Me.cboVendors.Size = New System.Drawing.Size(139, 21)
        Me.cboVendors.TabIndex = 10
        '
        'cboEmployees
        '
        Me.cboEmployees.FormattingEnabled = True
        Me.cboEmployees.Location = New System.Drawing.Point(81, 98)
        Me.cboEmployees.Name = "cboEmployees"
        Me.cboEmployees.Size = New System.Drawing.Size(139, 21)
        Me.cboEmployees.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Assigned To:"
        '
        'chkCompleted
        '
        Me.chkCompleted.AutoSize = True
        Me.chkCompleted.Location = New System.Drawing.Point(219, 48)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Size = New System.Drawing.Size(76, 17)
        Me.chkCompleted.TabIndex = 7
        Me.chkCompleted.Text = "Completed"
        Me.chkCompleted.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Close Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Open Date:"
        '
        'lblProperties
        '
        Me.lblProperties.AutoSize = True
        Me.lblProperties.Location = New System.Drawing.Point(18, 22)
        Me.lblProperties.Name = "lblProperties"
        Me.lblProperties.Size = New System.Drawing.Size(88, 13)
        Me.lblProperties.TabIndex = 3
        Me.lblProperties.Text = "Choose Property:"
        '
        'cboProperties
        '
        Me.cboProperties.FormattingEnabled = True
        Me.cboProperties.Location = New System.Drawing.Point(112, 19)
        Me.cboProperties.Name = "cboProperties"
        Me.cboProperties.Size = New System.Drawing.Size(286, 21)
        Me.cboProperties.TabIndex = 2
        '
        'txtCloseDate
        '
        Me.txtCloseDate.Location = New System.Drawing.Point(81, 72)
        Me.txtCloseDate.Name = "txtCloseDate"
        Me.txtCloseDate.Size = New System.Drawing.Size(100, 20)
        Me.txtCloseDate.TabIndex = 4
        '
        'txtOpenDate
        '
        Me.txtOpenDate.Location = New System.Drawing.Point(81, 46)
        Me.txtOpenDate.Name = "txtOpenDate"
        Me.txtOpenDate.Size = New System.Drawing.Size(100, 20)
        Me.txtOpenDate.TabIndex = 3
        '
        'grpCharges
        '
        Me.grpCharges.Controls.Add(Me.chkPaid)
        Me.grpCharges.Controls.Add(Me.btnCancelCharge)
        Me.grpCharges.Controls.Add(Me.btnSaveCharge)
        Me.grpCharges.Controls.Add(Me.Label12)
        Me.grpCharges.Controls.Add(Me.txtChargeNotes)
        Me.grpCharges.Controls.Add(Me.txtDatePaid)
        Me.grpCharges.Controls.Add(Me.txtDateBilled)
        Me.grpCharges.Controls.Add(Me.Label11)
        Me.grpCharges.Controls.Add(Me.Label10)
        Me.grpCharges.Controls.Add(Me.txtTotal)
        Me.grpCharges.Controls.Add(Me.txtLabor)
        Me.grpCharges.Controls.Add(Me.txtParts)
        Me.grpCharges.Controls.Add(Me.Label9)
        Me.grpCharges.Controls.Add(Me.Label8)
        Me.grpCharges.Controls.Add(Me.Label1)
        Me.grpCharges.Location = New System.Drawing.Point(166, 328)
        Me.grpCharges.Name = "grpCharges"
        Me.grpCharges.Size = New System.Drawing.Size(417, 161)
        Me.grpCharges.TabIndex = 3
        Me.grpCharges.TabStop = False
        Me.grpCharges.Text = "New Charge Information"
        Me.grpCharges.Visible = False
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
        Me.txtChargeNotes.Size = New System.Drawing.Size(230, 56)
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
        'btnGetByProperty
        '
        Me.btnGetByProperty.Location = New System.Drawing.Point(323, 46)
        Me.btnGetByProperty.Name = "btnGetByProperty"
        Me.btnGetByProperty.Size = New System.Drawing.Size(75, 23)
        Me.btnGetByProperty.TabIndex = 23
        Me.btnGetByProperty.Text = "Get WOs"
        Me.btnGetByProperty.UseVisualStyleBackColor = True
        Me.btnGetByProperty.Visible = False
        '
        'frmWorkOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpCharges)
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
    Friend WithEvents grpCharges As GroupBox
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
End Class
