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
        Me.grpWOInfo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboVendors = New System.Windows.Forms.ComboBox()
        Me.cboEmployees = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkCompleted = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboProperties = New System.Windows.Forms.ComboBox()
        Me.txtCloseDate = New System.Windows.Forms.TextBox()
        Me.txtOpenDate = New System.Windows.Forms.TextBox()
        Me.grpStartHere.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpWOInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStartHere
        '
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
        'btnWOByNumber
        '
        Me.btnWOByNumber.Location = New System.Drawing.Point(7, 194)
        Me.btnWOByNumber.Name = "btnWOByNumber"
        Me.btnWOByNumber.Size = New System.Drawing.Size(133, 23)
        Me.btnWOByNumber.TabIndex = 6
        Me.btnWOByNumber.Text = "WO By Number"
        Me.btnWOByNumber.UseVisualStyleBackColor = True
        '
        'btnWOByVendor
        '
        Me.btnWOByVendor.Location = New System.Drawing.Point(6, 165)
        Me.btnWOByVendor.Name = "btnWOByVendor"
        Me.btnWOByVendor.Size = New System.Drawing.Size(133, 23)
        Me.btnWOByVendor.TabIndex = 5
        Me.btnWOByVendor.Text = "WO By Vendor"
        Me.btnWOByVendor.UseVisualStyleBackColor = True
        '
        'btnWOByEmployee
        '
        Me.btnWOByEmployee.Location = New System.Drawing.Point(6, 136)
        Me.btnWOByEmployee.Name = "btnWOByEmployee"
        Me.btnWOByEmployee.Size = New System.Drawing.Size(133, 23)
        Me.btnWOByEmployee.TabIndex = 4
        Me.btnWOByEmployee.Text = "WO By Employee"
        Me.btnWOByEmployee.UseVisualStyleBackColor = True
        '
        'btnWOByProperty
        '
        Me.btnWOByProperty.Location = New System.Drawing.Point(7, 107)
        Me.btnWOByProperty.Name = "btnWOByProperty"
        Me.btnWOByProperty.Size = New System.Drawing.Size(133, 23)
        Me.btnWOByProperty.TabIndex = 3
        Me.btnWOByProperty.Text = "WO By Property"
        Me.btnWOByProperty.UseVisualStyleBackColor = True
        '
        'btnClosedWO
        '
        Me.btnClosedWO.Location = New System.Drawing.Point(6, 78)
        Me.btnClosedWO.Name = "btnClosedWO"
        Me.btnClosedWO.Size = New System.Drawing.Size(133, 23)
        Me.btnClosedWO.TabIndex = 2
        Me.btnClosedWO.Text = "Closed Work Orders"
        Me.btnClosedWO.UseVisualStyleBackColor = True
        '
        'btnOpenWO
        '
        Me.btnOpenWO.Location = New System.Drawing.Point(6, 49)
        Me.btnOpenWO.Name = "btnOpenWO"
        Me.btnOpenWO.Size = New System.Drawing.Size(133, 23)
        Me.btnOpenWO.TabIndex = 1
        Me.btnOpenWO.Text = "Open Work Orders"
        Me.btnOpenWO.UseVisualStyleBackColor = True
        '
        'btnNewWO
        '
        Me.btnNewWO.Location = New System.Drawing.Point(7, 20)
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
        'grpWOInfo
        '
        Me.grpWOInfo.Controls.Add(Me.Label5)
        Me.grpWOInfo.Controls.Add(Me.cboVendors)
        Me.grpWOInfo.Controls.Add(Me.cboEmployees)
        Me.grpWOInfo.Controls.Add(Me.Label4)
        Me.grpWOInfo.Controls.Add(Me.chkCompleted)
        Me.grpWOInfo.Controls.Add(Me.Label3)
        Me.grpWOInfo.Controls.Add(Me.Label2)
        Me.grpWOInfo.Controls.Add(Me.Label1)
        Me.grpWOInfo.Controls.Add(Me.cboProperties)
        Me.grpWOInfo.Controls.Add(Me.txtCloseDate)
        Me.grpWOInfo.Controls.Add(Me.txtOpenDate)
        Me.grpWOInfo.Location = New System.Drawing.Point(166, 81)
        Me.grpWOInfo.Name = "grpWOInfo"
        Me.grpWOInfo.Size = New System.Drawing.Size(417, 241)
        Me.grpWOInfo.TabIndex = 2
        Me.grpWOInfo.TabStop = False
        Me.grpWOInfo.Text = "Work Order Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Vendor:"
        '
        'cboVendors
        '
        Me.cboVendors.FormattingEnabled = True
        Me.cboVendors.Location = New System.Drawing.Point(93, 128)
        Me.cboVendors.Name = "cboVendors"
        Me.cboVendors.Size = New System.Drawing.Size(139, 21)
        Me.cboVendors.TabIndex = 10
        '
        'cboEmployees
        '
        Me.cboEmployees.FormattingEnabled = True
        Me.cboEmployees.Location = New System.Drawing.Point(93, 98)
        Me.cboEmployees.Name = "cboEmployees"
        Me.cboEmployees.Size = New System.Drawing.Size(139, 21)
        Me.cboEmployees.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Assigned To:"
        '
        'chkCompleted
        '
        Me.chkCompleted.AutoSize = True
        Me.chkCompleted.Location = New System.Drawing.Point(231, 48)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Size = New System.Drawing.Size(76, 17)
        Me.chkCompleted.TabIndex = 7
        Me.chkCompleted.Text = "Completed"
        Me.chkCompleted.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Close Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Open Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose Property:"
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
        Me.txtCloseDate.Location = New System.Drawing.Point(93, 72)
        Me.txtCloseDate.Name = "txtCloseDate"
        Me.txtCloseDate.Size = New System.Drawing.Size(100, 20)
        Me.txtCloseDate.TabIndex = 4
        '
        'txtOpenDate
        '
        Me.txtOpenDate.Location = New System.Drawing.Point(93, 46)
        Me.txtOpenDate.Name = "txtOpenDate"
        Me.txtOpenDate.Size = New System.Drawing.Size(100, 20)
        Me.txtOpenDate.TabIndex = 3
        '
        'frmWorkOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 438)
        Me.Controls.Add(Me.grpWOInfo)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpStartHere)
        Me.Name = "frmWorkOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Work Order Management"
        Me.grpStartHere.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpWOInfo.ResumeLayout(False)
        Me.grpWOInfo.PerformLayout()
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
    Friend WithEvents grpWOInfo As GroupBox
    Friend WithEvents txtOpenDate As TextBox
    Friend WithEvents txtCloseDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboProperties As ComboBox
    Friend WithEvents chkCompleted As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboEmployees As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboVendors As ComboBox
End Class
