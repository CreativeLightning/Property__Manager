<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounting
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
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.grpReports = New System.Windows.Forms.GroupBox()
        Me.btnFullReport = New System.Windows.Forms.Button()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.btnFullReport)
        Me.grpOptions.Controls.Add(Me.dtpEnd)
        Me.grpOptions.Controls.Add(Me.dtpStart)
        Me.grpOptions.Controls.Add(Me.Label2)
        Me.grpOptions.Controls.Add(Me.Label1)
        Me.grpOptions.Controls.Add(Me.btnExit)
        Me.grpOptions.Controls.Add(Me.btnHome)
        Me.grpOptions.Location = New System.Drawing.Point(13, 13)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(156, 322)
        Me.grpOptions.TabIndex = 0
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(7, 20)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(7, 50)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "End Date:"
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "MM/dd/yyyy"
        Me.dtpStart.Location = New System.Drawing.Point(10, 97)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(103, 20)
        Me.dtpStart.TabIndex = 4
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "MM/dd/yyyy"
        Me.dtpEnd.Location = New System.Drawing.Point(10, 146)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(103, 20)
        Me.dtpEnd.TabIndex = 5
        '
        'grpReports
        '
        Me.grpReports.Location = New System.Drawing.Point(193, 13)
        Me.grpReports.Name = "grpReports"
        Me.grpReports.Size = New System.Drawing.Size(423, 322)
        Me.grpReports.TabIndex = 1
        Me.grpReports.TabStop = False
        Me.grpReports.Text = "Reports"
        '
        'btnFullReport
        '
        Me.btnFullReport.Location = New System.Drawing.Point(10, 172)
        Me.btnFullReport.Name = "btnFullReport"
        Me.btnFullReport.Size = New System.Drawing.Size(103, 23)
        Me.btnFullReport.TabIndex = 6
        Me.btnFullReport.Text = "Full Report"
        Me.btnFullReport.UseVisualStyleBackColor = True
        '
        'frmAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpReports)
        Me.Controls.Add(Me.grpOptions)
        Me.Name = "frmAccounting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounting Reports"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpReports As GroupBox
    Friend WithEvents btnFullReport As Button
End Class
