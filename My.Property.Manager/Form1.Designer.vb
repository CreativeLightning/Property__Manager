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
        Me.btnVendors = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnWorkOrders = New System.Windows.Forms.Button()
        Me.btnProperties = New System.Windows.Forms.Button()
        Me.btnTenants = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCharges = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCharges)
        Me.GroupBox1.Controls.Add(Me.btnVendors)
        Me.GroupBox1.Controls.Add(Me.btnEmployees)
        Me.GroupBox1.Controls.Add(Me.btnWorkOrders)
        Me.GroupBox1.Controls.Add(Me.btnProperties)
        Me.GroupBox1.Controls.Add(Me.btnTenants)
        Me.GroupBox1.Controls.Add(Me.btnPayments)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Begin Here"
        '
        'btnVendors
        '
        Me.btnVendors.Location = New System.Drawing.Point(87, 108)
        Me.btnVendors.Name = "btnVendors"
        Me.btnVendors.Size = New System.Drawing.Size(75, 23)
        Me.btnVendors.TabIndex = 8
        Me.btnVendors.Text = "Vendors"
        Me.btnVendors.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Location = New System.Drawing.Point(6, 108)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(75, 23)
        Me.btnEmployees.TabIndex = 7
        Me.btnEmployees.Text = "Employees"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'btnWorkOrders
        '
        Me.btnWorkOrders.Location = New System.Drawing.Point(88, 21)
        Me.btnWorkOrders.Name = "btnWorkOrders"
        Me.btnWorkOrders.Size = New System.Drawing.Size(75, 23)
        Me.btnWorkOrders.TabIndex = 2
        Me.btnWorkOrders.Text = "Work Orders"
        Me.btnWorkOrders.UseVisualStyleBackColor = True
        '
        'btnProperties
        '
        Me.btnProperties.Location = New System.Drawing.Point(87, 79)
        Me.btnProperties.Name = "btnProperties"
        Me.btnProperties.Size = New System.Drawing.Size(75, 23)
        Me.btnProperties.TabIndex = 6
        Me.btnProperties.Text = "Properties"
        Me.btnProperties.UseVisualStyleBackColor = True
        '
        'btnTenants
        '
        Me.btnTenants.Location = New System.Drawing.Point(7, 21)
        Me.btnTenants.Name = "btnTenants"
        Me.btnTenants.Size = New System.Drawing.Size(75, 23)
        Me.btnTenants.TabIndex = 1
        Me.btnTenants.Text = "Tenants"
        Me.btnTenants.UseVisualStyleBackColor = True
        '
        'btnPayments
        '
        Me.btnPayments.Location = New System.Drawing.Point(7, 50)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(75, 23)
        Me.btnPayments.TabIndex = 3
        Me.btnPayments.Text = "Payments"
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(66, 166)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCharges
        '
        Me.btnCharges.Location = New System.Drawing.Point(6, 79)
        Me.btnCharges.Name = "btnCharges"
        Me.btnCharges.Size = New System.Drawing.Size(75, 23)
        Me.btnCharges.TabIndex = 5
        Me.btnCharges.Text = "Charges"
        Me.btnCharges.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Property Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPayments As Button
    Friend WithEvents btnProperties As Button
    Friend WithEvents btnTenants As Button
    Friend WithEvents btnWorkOrders As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnVendors As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCharges As Button
End Class
