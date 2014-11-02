Public Class TQConfig
  Dim SaveEligible As Boolean = False

  Private Sub txtRemotes2Tables_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemotes2Tables.TextChanged
    If SaveEligible Then
      SaveSetting("TutorQ", "Files", "Remotes2Tables", txtRemotes2Tables.Text)
    End If
  End Sub

  Private Sub txtButtons2Types_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtButtons2Types.TextChanged
    If SaveEligible Then
      SaveSetting("TutorQ", "Files", "Buttons2Types", txtButtons2Types.Text)
    End If
  End Sub

  Private Sub cmdFindRemotes2Tables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindRemotes2Tables.Click
    OFd.DefaultExt = "csv"
    OFd.ShowDialog()
    If OFd.FileName <> "" Then txtRemotes2Tables.Text = OFd.FileName
  End Sub

  Private Sub cmdFindButtons2Types_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindButtons2Types.Click
    OFd.DefaultExt = "csv"
    OFd.ShowDialog()
    If OFd.FileName <> "" Then txtButtons2Types.Text = OFd.FileName

  End Sub

  Private Sub TutorQueueConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    SaveEligible = False
    txtRemotes2Tables.Text = GetSetting("TutorQ", "Files", "Remotes2Tables", "C:\Remotes2Tables.csv")
    txtButtons2Types.Text = GetSetting("TutorQ", "Files", "Buttons2Types", "C:\Buttons2Types.csv")
    txtLog.Text = GetSetting("TutorQ", "Files", "LogFile", "C:\TutorQueue.log")
    txtSerialPort.Text = GetSetting("TutorQ", "Ports", "Port", "99")
    txtMaxKeyPad.Text = Val(GetSetting("TutorQ", "Ports", "MaxKeyPad", "30"))
    txtQueueFile.Text = GetSetting("TutorQ", "Files", "QueueFile", "C:\QueueFile.txt")
    txtMsgDir.Text = GetSetting("TutorQ", "Files", "MsgDir", "C:\MsgDir\")
    txtWinLocX.Text = GetSetting("TutorQ", "Window", "WinLocX", "0")
    txtWinLocY.Text = GetSetting("TutorQ", "Window", "WinLocY", "0")
    txtWinWidth.Text = GetSetting("TutorQ", "Window", "WinWidth", "800")
    txtWinHeight.Text = GetSetting("TutorQ", "Window", "WinHeight", "600")
    chkSimulateHardware.Checked = (GetSetting("TutorQ", "Simulate", "SimulateHardware", "No") = "Yes")
    txtFontSize.Text = GetSetting("TutorQ", "Info", "FontSize", "20")
    SaveEligible = True
  End Sub

  Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
    End
  End Sub

  Private Sub txtSerialPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerialPort.TextChanged
    If SaveEligible Then
      SaveSetting("TutorQ", "Ports", "Port", txtSerialPort.Text)
    End If


  End Sub

  Private Sub chkSimulateHardware_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSimulateHardware.CheckedChanged
    Dim State As String
    If SaveEligible Then

      If chkSimulateHardware.Checked Then
        State = "Yes"
      Else
        State = "No"
      End If

      SaveSetting("TutorQ", "Simulate", "SimulateHardware", State)
    End If
  End Sub

  Private Sub txtFontSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFontSize.TextChanged
    If SaveEligible Then
      SaveSetting("TutorQ", "Info", "FontSize", txtFontSize.Text)
    End If
  End Sub

  Private Sub txtLog_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLog.TextChanged
    If SaveEligible Then
      SaveSetting("TutorQ", "Files", "LogFile", txtLog.Text)
    End If

  End Sub

  Private Sub cmdFindLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindLog.Click
    SFd.DefaultExt = "log"
    SFd.ShowDialog()
    If SFd.FileName <> "" Then txtLog.Text = SFd.FileName

  End Sub

  Private Sub txtQueueFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQueueFile.TextChanged
    SaveSetting("TutorQ", "Files", "QueueFile", txtQueueFile.Text)
  End Sub

  Private Sub txtMsgDir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMsgDir.TextChanged
    SaveSetting("TutorQ", "Files", "MsgDir", txtMsgDir.Text)
  End Sub

  Private Sub cmdFindQueueFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindQueueFile.Click
    SFd.DefaultExt = "txt"
    SFd.ShowDialog()
    If SFd.FileName <> "" Then txtQueueFile.Text = SFd.FileName
  End Sub

  Private Sub cmdFindMsgDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindMsgDir.Click
    FBd.ShowDialog()
    If FBd.SelectedPath <> "" Then txtMsgDir.Text = FBd.SelectedPath
  End Sub

  Private Sub txtMaxKeyPad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaxKeyPad.TextChanged
    SaveSetting("TutorQ", "Ports", "MaxKeyPad", txtMaxKeyPad.Text)
  End Sub

  Private Sub txtWinLocX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWinLocX.TextChanged
    SaveSetting("TutorQ", "Window", "WinLocX", txtWinLocX.Text)
  End Sub

  Private Sub txtWinLocY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWinLocY.TextChanged
    SaveSetting("TutorQ", "Window", "WinLocY", txtWinLocY.Text)
  End Sub

  Private Sub txtWinWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWinWidth.TextChanged
    SaveSetting("TutorQ", "Window", "WinWidth", txtWinWidth.Text)
  End Sub

  Private Sub txtWinHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWinHeight.TextChanged
    SaveSetting("TutorQ", "Window", "WinHeight", txtWinHeight.Text)
  End Sub
End Class
