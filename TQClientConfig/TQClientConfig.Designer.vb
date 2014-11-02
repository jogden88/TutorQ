<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TQClientConfig
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
    Me.fBD = New System.Windows.Forms.FolderBrowserDialog
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtID = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtShared = New System.Windows.Forms.TextBox
    Me.cmdFindShared = New System.Windows.Forms.Button
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtMsgDir = New System.Windows.Forms.TextBox
    Me.cmdFindMsgDir = New System.Windows.Forms.Button
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtRefresh = New System.Windows.Forms.TextBox
    Me.chkAdmin = New System.Windows.Forms.CheckBox
    Me.cmdExit = New System.Windows.Forms.Button
    Me.lblWarn = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(8, 17)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(57, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Station ID:"
    '
    'txtID
    '
    Me.txtID.Location = New System.Drawing.Point(78, 16)
    Me.txtID.Name = "txtID"
    Me.txtID.Size = New System.Drawing.Size(44, 20)
    Me.txtID.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(14, 48)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(294, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Shared Directory with QueueFile.txt and  Buttons2Types.csv:"
    '
    'txtShared
    '
    Me.txtShared.Location = New System.Drawing.Point(13, 73)
    Me.txtShared.Name = "txtShared"
    Me.txtShared.Size = New System.Drawing.Size(440, 20)
    Me.txtShared.TabIndex = 3
    '
    'cmdFindShared
    '
    Me.cmdFindShared.Location = New System.Drawing.Point(460, 72)
    Me.cmdFindShared.Name = "cmdFindShared"
    Me.cmdFindShared.Size = New System.Drawing.Size(33, 20)
    Me.cmdFindShared.TabIndex = 4
    Me.cmdFindShared.Text = "..."
    Me.cmdFindShared.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(16, 117)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(219, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Shared Writeable Directory for Message files:"
    '
    'txtMsgDir
    '
    Me.txtMsgDir.Location = New System.Drawing.Point(14, 147)
    Me.txtMsgDir.Name = "txtMsgDir"
    Me.txtMsgDir.Size = New System.Drawing.Size(438, 20)
    Me.txtMsgDir.TabIndex = 6
    '
    'cmdFindMsgDir
    '
    Me.cmdFindMsgDir.Location = New System.Drawing.Point(463, 146)
    Me.cmdFindMsgDir.Name = "cmdFindMsgDir"
    Me.cmdFindMsgDir.Size = New System.Drawing.Size(29, 20)
    Me.cmdFindMsgDir.TabIndex = 7
    Me.cmdFindMsgDir.Text = "..."
    Me.cmdFindMsgDir.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(138, 19)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(115, 13)
    Me.Label4.TabIndex = 8
    Me.Label4.Text = "Refresh (milliseconds): "
    '
    'txtRefresh
    '
    Me.txtRefresh.Location = New System.Drawing.Point(259, 16)
    Me.txtRefresh.Name = "txtRefresh"
    Me.txtRefresh.Size = New System.Drawing.Size(49, 20)
    Me.txtRefresh.TabIndex = 9
    Me.txtRefresh.Text = "1500"
    '
    'chkAdmin
    '
    Me.chkAdmin.AutoSize = True
    Me.chkAdmin.Location = New System.Drawing.Point(338, 19)
    Me.chkAdmin.Name = "chkAdmin"
    Me.chkAdmin.Size = New System.Drawing.Size(130, 17)
    Me.chkAdmin.TabIndex = 10
    Me.chkAdmin.Text = "Administration Rights?"
    Me.chkAdmin.UseVisualStyleBackColor = True
    '
    'cmdExit
    '
    Me.cmdExit.Location = New System.Drawing.Point(28, 183)
    Me.cmdExit.Name = "cmdExit"
    Me.cmdExit.Size = New System.Drawing.Size(150, 31)
    Me.cmdExit.TabIndex = 11
    Me.cmdExit.Text = "Save and Exit"
    Me.cmdExit.UseVisualStyleBackColor = True
    '
    'lblWarn
    '
    Me.lblWarn.AutoSize = True
    Me.lblWarn.ForeColor = System.Drawing.Color.Red
    Me.lblWarn.Location = New System.Drawing.Point(184, 170)
    Me.lblWarn.Name = "lblWarn"
    Me.lblWarn.Size = New System.Drawing.Size(30, 13)
    Me.lblWarn.TabIndex = 12
    Me.lblWarn.Text = "warn"
    '
    'TQClientConfig
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(524, 225)
    Me.Controls.Add(Me.lblWarn)
    Me.Controls.Add(Me.cmdExit)
    Me.Controls.Add(Me.chkAdmin)
    Me.Controls.Add(Me.txtRefresh)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cmdFindMsgDir)
    Me.Controls.Add(Me.txtMsgDir)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.cmdFindShared)
    Me.Controls.Add(Me.txtShared)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtID)
    Me.Controls.Add(Me.Label1)
    Me.Name = "TQClientConfig"
    Me.Text = "TQClientConfig"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents fBD As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtID As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtShared As System.Windows.Forms.TextBox
  Friend WithEvents cmdFindShared As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtMsgDir As System.Windows.Forms.TextBox
  Friend WithEvents cmdFindMsgDir As System.Windows.Forms.Button
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtRefresh As System.Windows.Forms.TextBox
  Friend WithEvents chkAdmin As System.Windows.Forms.CheckBox
  Friend WithEvents cmdExit As System.Windows.Forms.Button
  Friend WithEvents lblWarn As System.Windows.Forms.Label

End Class
