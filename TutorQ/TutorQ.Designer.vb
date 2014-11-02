<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorQ
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutorQ))
    Me.reply = New AxReplyXControl1.AxReplyX
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    CType(Me.reply, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'reply
    '
    Me.reply.Enabled = True
    Me.reply.Location = New System.Drawing.Point(2, 3)
    Me.reply.Name = "reply"
    Me.reply.OcxState = CType(resources.GetObject("reply.OcxState"), System.Windows.Forms.AxHost.State)
    Me.reply.Size = New System.Drawing.Size(28, 28)
    Me.reply.TabIndex = 0
    Me.reply.Visible = False
    '
    'Timer1
    '
    '
    'TutorQ
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.BackgroundImage = Global.TutorQ.My.Resources.Resources.Background
    Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
    Me.ClientSize = New System.Drawing.Size(739, 245)
    Me.Controls.Add(Me.reply)
    Me.DoubleBuffered = True
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "TutorQ"
    Me.Text = "TutorQ 1.1"
    CType(Me.reply, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents reply As AxReplyXControl1.AxReplyX
  Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
