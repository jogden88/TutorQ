Imports Microsoft.Win32
Public Class TQClientConfig
  Dim IamReady As Boolean
  Dim regKey As RegistryKey
  Dim tutorqKey As RegistryKey
  Private Sub TQClientConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim ComputerNameKey As RegistryKey
    Dim ComputerName As String
    Dim DefaultID As String
    IamReady = False
    Me.Visible = True
    lblWarn.Text = "Warning - unless you run in Admin mode" + vbCrLf
    lblWarn.Text &= "settings will just go into some virtual" + vbCrLf
    lblWarn.Text &= "wastland!"

    regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
    ComputerNameKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName", False)
    ComputerName = ComputerNameKey.GetValue("ComputerName", "X")
    DefaultID = "99"
    If ComputerName.Length > 2 Then
      DefaultID = ComputerName.Substring(ComputerName.Length - 2) 'We'll try to use last two chars of computerid if we can find it.
    End If
    Try
      tutorqKey = regKey.CreateSubKey("TutorQ")
    Catch ex As Exception 'probably existed already, ignore exception
      MsgBox("Probable second try to create")
    End Try
    txtID.Text = tutorqKey.GetValue("ID", DefaultID)
    txtMsgDir.Text = tutorqKey.GetValue("MsgDir", "\\19-22-TutorQ\MessageBox")
    txtShared.Text = tutorqKey.GetValue("Shared", "\\19-22-TutorQ\TutorQ-Shared")
    txtRefresh.Text = tutorqKey.GetValue("Refresh", "800")
    chkAdmin.Checked = (GetSetting("TQClient", "S", "Admin", "No") = "Yes")
    IamReady = True
  End Sub
  Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
    tutorqKey.SetValue("ID", txtID.Text)
  End Sub

  Private Sub txtShared_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShared.TextChanged
    tutorqKey.SetValue("Shared", txtShared.Text)
  End Sub

  Private Sub txtMsgDir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMsgDir.TextChanged
    tutorqKey.SetValue("MsgDir", txtMsgDir.Text)
  End Sub
  Private Sub txtRefresh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefresh.TextChanged
    If IamReady Then
      tutorqKey.SetValue("Refresh", txtRefresh.Text)
    End If
  End Sub
  Private Sub chkAdmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdmin.CheckedChanged
    SaveSetting("TQClient", "S", "Admin", IIf(chkAdmin.Checked, "Yes", "No"))
  End Sub

  Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
    tutorqKey.SetValue("UseRegistry", "Yes")
    tutorqKey.SetValue("ID", txtID.Text)
    tutorqKey.SetValue("Shared", txtShared.Text)
    tutorqKey.SetValue("MsgDir", txtMsgDir.Text)
    tutorqKey.SetValue("Refresh", txtRefresh.Text)
    SaveSetting("TQClient", "S", "Admin", IIf(chkAdmin.Checked, "Yes", "No"))
    End
  End Sub
  Private Sub cmdFindShared_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindShared.Click
    fBD.ShowDialog()
    If fBD.SelectedPath <> "" Then
      txtShared.Text = fBD.SelectedPath
    End If
  End Sub
  Private Sub cmdFindMsgDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindMsgDir.Click
    fBD.ShowDialog()
    If fBD.SelectedPath <> "" Then
      txtMsgDir.Text = fBD.SelectedPath
    End If
  End Sub

End Class
