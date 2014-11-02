<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TQConfig
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
    Me.txtRemotes2Tables = New System.Windows.Forms.TextBox
    Me.cmdFindRemotes2Tables = New System.Windows.Forms.Button
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtButtons2Types = New System.Windows.Forms.TextBox
    Me.cmdFindButtons2Types = New System.Windows.Forms.Button
    Me.OFd = New System.Windows.Forms.OpenFileDialog
    Me.cmdExit = New System.Windows.Forms.Button
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtSerialPort = New System.Windows.Forms.TextBox
    Me.chkSimulateHardware = New System.Windows.Forms.CheckBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtFontSize = New System.Windows.Forms.TextBox
    Me.txtLog = New System.Windows.Forms.TextBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.cmdFindLog = New System.Windows.Forms.Button
    Me.SFd = New System.Windows.Forms.SaveFileDialog
    Me.Label6 = New System.Windows.Forms.Label
    Me.txtQueueFile = New System.Windows.Forms.TextBox
    Me.Label7 = New System.Windows.Forms.Label
    Me.txtMsgDir = New System.Windows.Forms.TextBox
    Me.cmdFindQueueFile = New System.Windows.Forms.Button
    Me.cmdFindMsgDir = New System.Windows.Forms.Button
    Me.FBd = New System.Windows.Forms.FolderBrowserDialog
    Me.Label8 = New System.Windows.Forms.Label
    Me.txtMaxKeyPad = New System.Windows.Forms.TextBox
    Me.Label9 = New System.Windows.Forms.Label
    Me.txtWinLocX = New System.Windows.Forms.TextBox
    Me.txtWinLocY = New System.Windows.Forms.TextBox
    Me.Label10 = New System.Windows.Forms.Label
    Me.txtWinWidth = New System.Windows.Forms.TextBox
    Me.txtWinHeight = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(8, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(242, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = ".CSV of Remote - Table number correspondences"
    '
    'txtRemotes2Tables
    '
    Me.txtRemotes2Tables.Location = New System.Drawing.Point(11, 29)
    Me.txtRemotes2Tables.Name = "txtRemotes2Tables"
    Me.txtRemotes2Tables.Size = New System.Drawing.Size(224, 20)
    Me.txtRemotes2Tables.TabIndex = 1
    '
    'cmdFindRemotes2Tables
    '
    Me.cmdFindRemotes2Tables.Location = New System.Drawing.Point(242, 28)
    Me.cmdFindRemotes2Tables.Name = "cmdFindRemotes2Tables"
    Me.cmdFindRemotes2Tables.Size = New System.Drawing.Size(30, 20)
    Me.cmdFindRemotes2Tables.TabIndex = 2
    Me.cmdFindRemotes2Tables.Text = "..."
    Me.cmdFindRemotes2Tables.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(8, 62)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(220, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = ".CSV of Button to help type correspondences"
    '
    'txtButtons2Types
    '
    Me.txtButtons2Types.Location = New System.Drawing.Point(11, 78)
    Me.txtButtons2Types.Name = "txtButtons2Types"
    Me.txtButtons2Types.Size = New System.Drawing.Size(224, 20)
    Me.txtButtons2Types.TabIndex = 4
    '
    'cmdFindButtons2Types
    '
    Me.cmdFindButtons2Types.Location = New System.Drawing.Point(242, 78)
    Me.cmdFindButtons2Types.Name = "cmdFindButtons2Types"
    Me.cmdFindButtons2Types.Size = New System.Drawing.Size(30, 20)
    Me.cmdFindButtons2Types.TabIndex = 5
    Me.cmdFindButtons2Types.Text = "..."
    Me.cmdFindButtons2Types.UseVisualStyleBackColor = True
    '
    'OFd
    '
    Me.OFd.FileName = "OpenFileDialog1"
    '
    'cmdExit
    '
    Me.cmdExit.Location = New System.Drawing.Point(211, 363)
    Me.cmdExit.Name = "cmdExit"
    Me.cmdExit.Size = New System.Drawing.Size(79, 46)
    Me.cmdExit.TabIndex = 6
    Me.cmdExit.Text = "Save all and Exit"
    Me.cmdExit.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(11, 288)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(53, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Com Port:"
    '
    'txtSerialPort
    '
    Me.txtSerialPort.Location = New System.Drawing.Point(91, 285)
    Me.txtSerialPort.Name = "txtSerialPort"
    Me.txtSerialPort.Size = New System.Drawing.Size(35, 20)
    Me.txtSerialPort.TabIndex = 8
    Me.txtSerialPort.Text = "88"
    '
    'chkSimulateHardware
    '
    Me.chkSimulateHardware.AutoSize = True
    Me.chkSimulateHardware.Location = New System.Drawing.Point(172, 328)
    Me.chkSimulateHardware.Name = "chkSimulateHardware"
    Me.chkSimulateHardware.Size = New System.Drawing.Size(112, 17)
    Me.chkSimulateHardware.TabIndex = 9
    Me.chkSimulateHardware.Text = "SimulateHardware"
    Me.chkSimulateHardware.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(15, 331)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(54, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Font Size:"
    '
    'txtFontSize
    '
    Me.txtFontSize.Location = New System.Drawing.Point(86, 326)
    Me.txtFontSize.Name = "txtFontSize"
    Me.txtFontSize.Size = New System.Drawing.Size(62, 20)
    Me.txtFontSize.TabIndex = 11
    '
    'txtLog
    '
    Me.txtLog.Location = New System.Drawing.Point(14, 126)
    Me.txtLog.Name = "txtLog"
    Me.txtLog.Size = New System.Drawing.Size(221, 20)
    Me.txtLog.TabIndex = 12
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(12, 106)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(100, 13)
    Me.Label5.TabIndex = 13
    Me.Label5.Text = "TutorQueue.log file:"
    '
    'cmdFindLog
    '
    Me.cmdFindLog.Location = New System.Drawing.Point(242, 126)
    Me.cmdFindLog.Name = "cmdFindLog"
    Me.cmdFindLog.Size = New System.Drawing.Size(30, 20)
    Me.cmdFindLog.TabIndex = 14
    Me.cmdFindLog.Text = "..."
    Me.cmdFindLog.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(11, 159)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(104, 13)
    Me.Label6.TabIndex = 15
    Me.Label6.Text = "PublishedQueueFile:"
    '
    'txtQueueFile
    '
    Me.txtQueueFile.Location = New System.Drawing.Point(14, 187)
    Me.txtQueueFile.Name = "txtQueueFile"
    Me.txtQueueFile.Size = New System.Drawing.Size(221, 20)
    Me.txtQueueFile.TabIndex = 16
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(12, 221)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(158, 13)
    Me.Label7.TabIndex = 17
    Me.Label7.Text = "Directory for network messages:"
    '
    'txtMsgDir
    '
    Me.txtMsgDir.Location = New System.Drawing.Point(15, 247)
    Me.txtMsgDir.Name = "txtMsgDir"
    Me.txtMsgDir.Size = New System.Drawing.Size(219, 20)
    Me.txtMsgDir.TabIndex = 18
    '
    'cmdFindQueueFile
    '
    Me.cmdFindQueueFile.Location = New System.Drawing.Point(242, 187)
    Me.cmdFindQueueFile.Name = "cmdFindQueueFile"
    Me.cmdFindQueueFile.Size = New System.Drawing.Size(30, 20)
    Me.cmdFindQueueFile.TabIndex = 19
    Me.cmdFindQueueFile.Text = "..."
    Me.cmdFindQueueFile.UseVisualStyleBackColor = True
    '
    'cmdFindMsgDir
    '
    Me.cmdFindMsgDir.Location = New System.Drawing.Point(242, 247)
    Me.cmdFindMsgDir.Name = "cmdFindMsgDir"
    Me.cmdFindMsgDir.Size = New System.Drawing.Size(30, 20)
    Me.cmdFindMsgDir.TabIndex = 20
    Me.cmdFindMsgDir.Text = "..."
    Me.cmdFindMsgDir.UseVisualStyleBackColor = True
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(143, 289)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(79, 13)
    Me.Label8.TabIndex = 21
    Me.Label8.Text = "Max Keypad #:"
    '
    'txtMaxKeyPad
    '
    Me.txtMaxKeyPad.Location = New System.Drawing.Point(237, 289)
    Me.txtMaxKeyPad.Name = "txtMaxKeyPad"
    Me.txtMaxKeyPad.Size = New System.Drawing.Size(47, 20)
    Me.txtMaxKeyPad.TabIndex = 22
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(10, 370)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(92, 13)
    Me.Label9.TabIndex = 23
    Me.Label9.Text = "Window Top Left:"
    '
    'txtWinLocX
    '
    Me.txtWinLocX.Location = New System.Drawing.Point(108, 363)
    Me.txtWinLocX.Name = "txtWinLocX"
    Me.txtWinLocX.Size = New System.Drawing.Size(40, 20)
    Me.txtWinLocX.TabIndex = 24
    '
    'txtWinLocY
    '
    Me.txtWinLocY.Location = New System.Drawing.Point(159, 363)
    Me.txtWinLocY.Name = "txtWinLocY"
    Me.txtWinLocY.Size = New System.Drawing.Size(46, 20)
    Me.txtWinLocY.TabIndex = 25
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(15, 403)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(75, 13)
    Me.Label10.TabIndex = 26
    Me.Label10.Text = "Window Size: "
    '
    'txtWinWidth
    '
    Me.txtWinWidth.Location = New System.Drawing.Point(108, 401)
    Me.txtWinWidth.Name = "txtWinWidth"
    Me.txtWinWidth.Size = New System.Drawing.Size(39, 20)
    Me.txtWinWidth.TabIndex = 27
    '
    'txtWinHeight
    '
    Me.txtWinHeight.Location = New System.Drawing.Point(162, 402)
    Me.txtWinHeight.Name = "txtWinHeight"
    Me.txtWinHeight.Size = New System.Drawing.Size(42, 20)
    Me.txtWinHeight.TabIndex = 28
    '
    'TQConfig
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(300, 444)
    Me.Controls.Add(Me.txtWinHeight)
    Me.Controls.Add(Me.txtWinWidth)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.txtWinLocY)
    Me.Controls.Add(Me.txtWinLocX)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.txtMaxKeyPad)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.cmdFindMsgDir)
    Me.Controls.Add(Me.cmdFindQueueFile)
    Me.Controls.Add(Me.txtMsgDir)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtQueueFile)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cmdFindLog)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtLog)
    Me.Controls.Add(Me.txtFontSize)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.chkSimulateHardware)
    Me.Controls.Add(Me.txtSerialPort)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.cmdExit)
    Me.Controls.Add(Me.cmdFindButtons2Types)
    Me.Controls.Add(Me.txtButtons2Types)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cmdFindRemotes2Tables)
    Me.Controls.Add(Me.txtRemotes2Tables)
    Me.Controls.Add(Me.Label1)
    Me.Name = "TQConfig"
    Me.ShowIcon = False
    Me.Text = "TutorQ_Config"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtRemotes2Tables As System.Windows.Forms.TextBox
  Friend WithEvents cmdFindRemotes2Tables As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtButtons2Types As System.Windows.Forms.TextBox
  Friend WithEvents cmdFindButtons2Types As System.Windows.Forms.Button
  Friend WithEvents OFd As System.Windows.Forms.OpenFileDialog
  Friend WithEvents cmdExit As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtSerialPort As System.Windows.Forms.TextBox
  Friend WithEvents chkSimulateHardware As System.Windows.Forms.CheckBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtFontSize As System.Windows.Forms.TextBox
  Friend WithEvents txtLog As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cmdFindLog As System.Windows.Forms.Button
  Friend WithEvents SFd As System.Windows.Forms.SaveFileDialog
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtQueueFile As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtMsgDir As System.Windows.Forms.TextBox
  Friend WithEvents cmdFindQueueFile As System.Windows.Forms.Button
  Friend WithEvents cmdFindMsgDir As System.Windows.Forms.Button
  Friend WithEvents FBd As System.Windows.Forms.FolderBrowserDialog
  Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMaxKeyPad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWinLocX As System.Windows.Forms.TextBox
    Friend WithEvents txtWinLocY As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtWinWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtWinHeight As System.Windows.Forms.TextBox

End Class
