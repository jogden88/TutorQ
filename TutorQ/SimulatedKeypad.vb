Public Class SimulatedKeypad
  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    TutorQ.ButtonPress(Val(txtID.Text), 1)
  End Sub
  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    TutorQ.ButtonPress(Val(txtID.Text), 2)
  End Sub
  Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    TutorQ.ButtonPress(Val(txtID.Text), 3)
  End Sub
  Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    TutorQ.ButtonPress(Val(txtID.Text), 4)
  End Sub
  Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    TutorQ.ButtonPress(Val(txtID.Text), 5)
  End Sub

  Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
    End
  End Sub
End Class