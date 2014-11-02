<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimulatedKeypad
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.Button1 = New System.Windows.Forms.Button
    Me.Button2 = New System.Windows.Forms.Button
    Me.Button3 = New System.Windows.Forms.Button
    Me.Button4 = New System.Windows.Forms.Button
    Me.Button5 = New System.Windows.Forms.Button
    Me.txtID = New System.Windows.Forms.TextBox
    Me.Button6 = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(11, 8)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(83, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Keypad Number"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(23, 50)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(73, 34)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(23, 90)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(72, 35)
    Me.Button2.TabIndex = 2
    Me.Button2.Text = "Button2"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(23, 131)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(71, 33)
    Me.Button3.TabIndex = 3
    Me.Button3.Text = "Button3"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button4
    '
    Me.Button4.Location = New System.Drawing.Point(24, 170)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(71, 36)
    Me.Button4.TabIndex = 4
    Me.Button4.Text = "Button4"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'Button5
    '
    Me.Button5.Location = New System.Drawing.Point(26, 212)
    Me.Button5.Name = "Button5"
    Me.Button5.Size = New System.Drawing.Size(68, 38)
    Me.Button5.TabIndex = 5
    Me.Button5.Text = "Button5"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'txtID
    '
    Me.txtID.Location = New System.Drawing.Point(26, 24)
    Me.txtID.Name = "txtID"
    Me.txtID.Size = New System.Drawing.Size(41, 20)
    Me.txtID.TabIndex = 6
    Me.txtID.Text = "1"
    '
    'Button6
    '
    Me.Button6.Location = New System.Drawing.Point(26, 256)
    Me.Button6.Name = "Button6"
    Me.Button6.Size = New System.Drawing.Size(69, 28)
    Me.Button6.TabIndex = 7
    Me.Button6.Text = "End"
    Me.Button6.UseVisualStyleBackColor = True
    '
    'SimulatedKeypad
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(125, 287)
    Me.Controls.Add(Me.Button6)
    Me.Controls.Add(Me.txtID)
    Me.Controls.Add(Me.Button5)
    Me.Controls.Add(Me.Button4)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "SimulatedKeypad"
    Me.Text = "SimulatedKeypad"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents Button4 As System.Windows.Forms.Button
  Friend WithEvents Button5 As System.Windows.Forms.Button
  Friend WithEvents txtID As System.Windows.Forms.TextBox
  Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
