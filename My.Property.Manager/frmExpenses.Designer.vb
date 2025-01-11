<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Me.grpReports = New System.Windows.Forms.GroupBox()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnTotalWOs = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpReports.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnHome)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(69, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(7, 20)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(54, 23)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(6, 49)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(54, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpReports
        '
        Me.grpReports.Controls.Add(Me.btnTotalWOs)
        Me.grpReports.Controls.Add(Me.dtpEnd)
        Me.grpReports.Controls.Add(Me.Label2)
        Me.grpReports.Controls.Add(Me.Label1)
        Me.grpReports.Controls.Add(Me.dtpStart)
        Me.grpReports.Location = New System.Drawing.Point(105, 13)
        Me.grpReports.Name = "grpReports"
        Me.grpReports.Size = New System.Drawing.Size(231, 202)
        Me.grpReports.TabIndex = 2
        Me.grpReports.TabStop = False
        Me.grpReports.Text = "Report Options"
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "MMM dd yyyy"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(10, 45)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(99, 20)
        Me.dtpStart.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End Date:"
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "MMM dd yyyy"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(125, 45)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(99, 20)
        Me.dtpEnd.TabIndex = 5
        '
        'btnTotalWOs
        '
        Me.btnTotalWOs.Location = New System.Drawing.Point(10, 72)
        Me.btnTotalWOs.Name = "btnTotalWOs"
        Me.btnTotalWOs.Size = New System.Drawing.Size(75, 23)
        Me.btnTotalWOs.TabIndex = 6
        Me.btnTotalWOs.Text = "Total WOs"
        Me.btnTotalWOs.UseVisualStyleBackColor = True
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 225)
        Me.Controls.Add(Me.grpReports)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmExpenses"
        Me.Text = "Expense Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpReports.ResumeLayout(False)
        Me.grpReports.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents grpReports As GroupBox
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents btnTotalWOs As Button
End Class
