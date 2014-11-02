<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TQClient
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
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TQClient))
    Me.cmd1 = New System.Windows.Forms.Button
    Me.cmd2 = New System.Windows.Forms.Button
    Me.cmd3 = New System.Windows.Forms.Button
    Me.cmd4 = New System.Windows.Forms.Button
    Me.cmd5 = New System.Windows.Forms.Button
    Me.cmdExit = New System.Windows.Forms.Button
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.lblStation = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.ListBox1 = New System.Windows.Forms.ListBox
    Me.cmdDelete = New System.Windows.Forms.Button
    Me.lblCloseWarning = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.cmd6 = New System.Windows.Forms.Button
    Me.cmd7 = New System.Windows.Forms.Button
    Me.cmd8 = New System.Windows.Forms.Button
    Me.cmd9 = New System.Windows.Forms.Button
    Me.cmdA = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'cmd1
    '
    Me.cmd1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd1.Location = New System.Drawing.Point(368, 295)
    Me.cmd1.Name = "cmd1"
    Me.cmd1.Size = New System.Drawing.Size(95, 41)
    Me.cmd1.TabIndex = 1
    Me.cmd1.Text = "Button1"
    Me.cmd1.UseVisualStyleBackColor = True
    '
    'cmd2
    '
    Me.cmd2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd2.Location = New System.Drawing.Point(368, 248)
    Me.cmd2.Name = "cmd2"
    Me.cmd2.Size = New System.Drawing.Size(95, 41)
    Me.cmd2.TabIndex = 2
    Me.cmd2.Text = "Button2"
    Me.cmd2.UseVisualStyleBackColor = True
    '
    'cmd3
    '
    Me.cmd3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd3.Location = New System.Drawing.Point(368, 201)
    Me.cmd3.Name = "cmd3"
    Me.cmd3.Size = New System.Drawing.Size(95, 41)
    Me.cmd3.TabIndex = 3
    Me.cmd3.Text = "Button3"
    Me.cmd3.UseVisualStyleBackColor = True
    '
    'cmd4
    '
    Me.cmd4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd4.Location = New System.Drawing.Point(370, 154)
    Me.cmd4.Name = "cmd4"
    Me.cmd4.Size = New System.Drawing.Size(95, 41)
    Me.cmd4.TabIndex = 4
    Me.cmd4.Text = "Button4"
    Me.cmd4.UseVisualStyleBackColor = True
    '
    'cmd5
    '
    Me.cmd5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd5.Location = New System.Drawing.Point(370, 107)
    Me.cmd5.Name = "cmd5"
    Me.cmd5.Size = New System.Drawing.Size(95, 41)
    Me.cmd5.TabIndex = 5
    Me.cmd5.Text = "Button5"
    Me.cmd5.UseVisualStyleBackColor = True
    '
    'cmdExit
    '
    Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdExit.Location = New System.Drawing.Point(369, 464)
    Me.cmdExit.Name = "cmdExit"
    Me.cmdExit.Size = New System.Drawing.Size(198, 40)
    Me.cmdExit.TabIndex = 6
    Me.cmdExit.Text = "Exit"
    Me.cmdExit.UseVisualStyleBackColor = True
    '
    'Timer1
    '
    '
    'lblStation
    '
    Me.lblStation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblStation.AutoSize = True
    Me.lblStation.Location = New System.Drawing.Point(418, 32)
    Me.lblStation.Name = "lblStation"
    Me.lblStation.Size = New System.Drawing.Size(89, 13)
    Me.lblStation.TabIndex = 7
    Me.lblStation.Text = "Unknown Station"
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(416, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(78, 13)
    Me.Label1.TabIndex = 8
    Me.Label1.Text = "Your Station is:"
    '
    'ListBox1
    '
    Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ListBox1.FormattingEnabled = True
    Me.ListBox1.ItemHeight = 16
    Me.ListBox1.Location = New System.Drawing.Point(8, 10)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(345, 500)
    Me.ListBox1.TabIndex = 9
    '
    'cmdDelete
    '
    Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDelete.Location = New System.Drawing.Point(369, 342)
    Me.cmdDelete.Name = "cmdDelete"
    Me.cmdDelete.Size = New System.Drawing.Size(197, 41)
    Me.cmdDelete.TabIndex = 10
    Me.cmdDelete.Text = "Delete Selected"
    Me.cmdDelete.UseVisualStyleBackColor = True
    Me.cmdDelete.Visible = False
    '
    'lblCloseWarning
    '
    Me.lblCloseWarning.Location = New System.Drawing.Point(370, 406)
    Me.lblCloseWarning.Name = "lblCloseWarning"
    Me.lblCloseWarning.Size = New System.Drawing.Size(196, 55)
    Me.lblCloseWarning.TabIndex = 11
    Me.lblCloseWarning.Text = "Note: if you close this window, your request will be cancelled.  If you minimize " & _
        "it, it will remain active."
    Me.lblCloseWarning.Visible = False
    '
    'Label3
    '
    Me.Label3.Location = New System.Drawing.Point(421, 63)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 31)
    Me.Label3.TabIndex = 12
    Me.Label3.Text = "Request a tutor for help in:"
    '
    'cmd6
    '
    Me.cmd6.Location = New System.Drawing.Point(471, 295)
    Me.cmd6.Name = "cmd6"
    Me.cmd6.Size = New System.Drawing.Size(96, 41)
    Me.cmd6.TabIndex = 13
    Me.cmd6.Text = "Button6"
    Me.cmd6.UseVisualStyleBackColor = True
    '
    'cmd7
    '
    Me.cmd7.Location = New System.Drawing.Point(469, 248)
    Me.cmd7.Name = "cmd7"
    Me.cmd7.Size = New System.Drawing.Size(96, 41)
    Me.cmd7.TabIndex = 14
    Me.cmd7.Text = "Button7"
    Me.cmd7.UseVisualStyleBackColor = True
    '
    'cmd8
    '
    Me.cmd8.Location = New System.Drawing.Point(469, 201)
    Me.cmd8.Name = "cmd8"
    Me.cmd8.Size = New System.Drawing.Size(96, 41)
    Me.cmd8.TabIndex = 15
    Me.cmd8.Text = "Button8"
    Me.cmd8.UseVisualStyleBackColor = True
    '
    'cmd9
    '
    Me.cmd9.Location = New System.Drawing.Point(469, 154)
    Me.cmd9.Name = "cmd9"
    Me.cmd9.Size = New System.Drawing.Size(96, 41)
    Me.cmd9.TabIndex = 16
    Me.cmd9.Text = "Button9"
    Me.cmd9.UseVisualStyleBackColor = True
    '
    'cmdA
    '
    Me.cmdA.Location = New System.Drawing.Point(471, 107)
    Me.cmdA.Name = "cmdA"
    Me.cmdA.Size = New System.Drawing.Size(96, 41)
    Me.cmdA.TabIndex = 17
    Me.cmdA.Text = "Button10"
    Me.cmdA.UseVisualStyleBackColor = True
    '
    'TQClient
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(578, 516)
    Me.Controls.Add(Me.cmdA)
    Me.Controls.Add(Me.cmd9)
    Me.Controls.Add(Me.cmd8)
    Me.Controls.Add(Me.cmd7)
    Me.Controls.Add(Me.cmd6)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.lblCloseWarning)
    Me.Controls.Add(Me.cmdDelete)
    Me.Controls.Add(Me.ListBox1)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblStation)
    Me.Controls.Add(Me.cmdExit)
    Me.Controls.Add(Me.cmd5)
    Me.Controls.Add(Me.cmd4)
    Me.Controls.Add(Me.cmd3)
    Me.Controls.Add(Me.cmd2)
    Me.Controls.Add(Me.cmd1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "TQClient"
    Me.Text = "TQClient"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmd1 As System.Windows.Forms.Button
  Friend WithEvents cmd2 As System.Windows.Forms.Button
  Friend WithEvents cmd3 As System.Windows.Forms.Button
  Friend WithEvents cmd4 As System.Windows.Forms.Button
  Friend WithEvents cmd5 As System.Windows.Forms.Button
  Friend WithEvents cmdExit As System.Windows.Forms.Button
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents lblStation As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
  Friend WithEvents cmdDelete As System.Windows.Forms.Button
  Friend WithEvents lblCloseWarning As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cmd6 As System.Windows.Forms.Button
  Friend WithEvents cmd7 As System.Windows.Forms.Button
  Friend WithEvents cmd8 As System.Windows.Forms.Button
  Friend WithEvents cmd9 As System.Windows.Forms.Button
  Friend WithEvents cmdA As System.Windows.Forms.Button

End Class
