<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnWordOrders = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnProperties = New System.Windows.Forms.Button()
        Me.btnTenants = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnWordOrders)
        Me.GroupBox1.Controls.Add(Me.btnPayments)
        Me.GroupBox1.Controls.Add(Me.btnProperties)
        Me.GroupBox1.Controls.Add(Me.btnTenants)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Begin Here"
        '
        'btnWordOrders
        '
        Me.btnWordOrders.Location = New System.Drawing.Point(7, 107)
        Me.btnWordOrders.Name = "btnWordOrders"
        Me.btnWordOrders.Size = New System.Drawing.Size(75, 23)
        Me.btnWordOrders.TabIndex = 3
        Me.btnWordOrders.Text = "Work Orders"
        Me.btnWordOrders.UseVisualStyleBackColor = True
        '
        'btnPayments
        '
        Me.btnPayments.Location = New System.Drawing.Point(7, 78)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(75, 23)
        Me.btnPayments.TabIndex = 2
        Me.btnPayments.Text = "Payments"
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'btnProperties
        '
        Me.btnProperties.Location = New System.Drawing.Point(7, 49)
        Me.btnProperties.Name = "btnProperties"
        Me.btnProperties.Size = New System.Drawing.Size(75, 23)
        Me.btnProperties.TabIndex = 1
        Me.btnProperties.Text = "Properties"
        Me.btnProperties.UseVisualStyleBackColor = True
        '
        'btnTenants
        '
        Me.btnTenants.Location = New System.Drawing.Point(7, 20)
        Me.btnTenants.Name = "btnTenants"
        Me.btnTenants.Size = New System.Drawing.Size(75, 23)
        Me.btnTenants.TabIndex = 0
        Me.btnTenants.Text = "Tenants"
        Me.btnTenants.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Property Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTenants As Button
    Friend WithEvents btnProperties As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnWordOrders As Button
End Class
