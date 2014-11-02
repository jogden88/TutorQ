Public Class TutorQ
    Dim UseHardware As Boolean = True
  Dim QueueFile As String
  Dim MsgDir As String
  Dim LastFileName As String
  Dim AmRunning As Boolean = False
  Dim TableStack(200) As String
  Dim TableNumberStack(200) As Integer
  Dim TypeNumberStack(200) As Integer
  Dim TypeStack(200) As String
  Dim StartTimeStack(200) As Date
  Dim KeyPadIDStack(200) As Integer
  Dim ColorStack(200) As SolidBrush
  Dim StackPointer As Integer = 0
  Dim RemoveValue As Integer = 1
  Dim myFont As System.Drawing.Font
  Dim Buttons() As Integer
  Dim Types() As String
  Dim Remotes() As Integer
  Dim SecondRemotes() As Integer
  Dim MyColors() As SolidBrush
  Dim Times() As Single
  Dim OtherKeypad(256) As Integer
  Dim IsSecondaryKeypad(256) As Boolean
  Dim Tables() As String
  Dim SerialPort As Integer
  Dim MaxKeyPad As Integer
  Dim FontSize As Single
  Dim MyFontHeight As Single
  Dim TooMany As Boolean
  Dim HowMany As Integer
  Dim SafeAmount As Integer
  Dim LogFile As String
  Dim DummyTime As Date = "1/1/2001"
  Dim Version As String = "3.1"
  ' 3.0 Sept 2011 added colors and second clicker full of buttons
  ' 3.1 9/14/2011 added hours to time color calculation so they don't go back to black
  Dim WinLocX As Integer
  Dim WinLocY As Integer
  Dim WinWidth As Integer
  Dim WinHeight As Integer
  Dim DailyMessage As String
  Dim DMFile As String


  Sub StartUp()
    Dim returnValue As Rectangle
    Dim Pt As Point
    Dim Mg As String
    'Me.Width = 500
    If UseHardware Then
      Try
        reply.ReplyModel = ReplyXControl1.TxrstReplyModel.mAutoDetect
      Catch ex As Exception
        Mg = "First attempt to access Reply.ocx failed.  Perhaps not installed?" + vbCrLf
        Mg = Mg & "'reply.ReplyModel = ReplyXControl1.TxrstReplyModel.mAutoDetect' failed."
        Mg = Mg & vbCrLf & ex.ToString
        MsgBox(Mg)
        End
      End Try
      Try
        reply.SerialPort = SerialPort
      Catch ex As Exception
        Mg = "Attempt to set SerialPort (" + Format(SerialPort) + ") failed." + vbCrLf
        Mg = Mg & "'reply.SerialPort = SerialPort'"
        Mg = Mg & vbCrLf & ex.ToString
        MsgBox(Mg)
        End
      End Try
      Try
        reply.AddKeypad(1, MaxKeyPad)
      Catch ex As Exception
        Mg = "'reply.AddKeypad(1, MaxKeyPad)' failed."
        Mg = Mg & vbCrLf & ex.ToString
        MsgBox(Mg)
        End
      End Try
      Try
        reply.Connect()
      Catch ex As Exception
        MsgBox("reply.Connect( ) failure " & vbCrLf & ex.ToString)
        End
      End Try
      Try
        reply.StartPolling()
      Catch ex As Exception
        Mg = "'reply.StartPolling()' failed."
        Mg = Mg & vbCrLf & ex.ToString
        MsgBox(Mg)
        End
      End Try

    Else
      SimulatedKeypad.Show()
      SimulatedKeypad.Left = Me.Left + Me.Width + 50
      returnValue = Screen.GetWorkingArea(Pt)
      If SimulatedKeypad.Left + SimulatedKeypad.Width > returnValue.Right Then
        SimulatedKeypad.Left = returnValue.Right = SimulatedKeypad.Width
      End If
      'MsgBox(Format(SimulatedKeypad.Left))
      SimulatedKeypad.Top = Me.Top
    End If
    StackPointer = 0
    Me.Text = "TutorQ " & Version & ": Connected"
    'Me.Width = 400
    RecordLog(0, -98, "Startup", DummyTime)
    AmRunning = True
    Do While AmRunning
      Application.DoEvents()
      'check to see if there is a message file there.
      'if so, process it, and delete it
      CheckForMessageFile()
    Loop

    ' should never get here - shutdown is handled as an event.
    reply.StopPolling()
    reply.Disconnect()
    RecordLog(0, -97, "Shutdown", DummyTime)
    End
  End Sub
  Sub CheckForMessageFile()
    Dim F As String
    Dim SimKeyPad As Integer
    Dim TheKey As Integer
    Dim Gone As Boolean
    Dim DelTries As Integer
    Dim KillFile As String
    Dim G As String
    F = Dir(MsgDir & "\*.*")
    If F <> "" Then
      RecordLog(0, -94, "MessageFileName: " & F, DummyTime)
      'MsgBox(F)
      If IsLegit(F) Then
        LastFileName = F 'remember for debug output
        Dim locBorK As Integer
        locBorK = InStr(F, "B")
        If locBorK = 0 Then locBorK = InStr(F, "K")
        SimKeyPad = 100 + Val(F.Substring(1, locBorK - 1)) 'put client keypads in 100-200 range
        G = F.Substring(locBorK)

        TheKey = Val(G.Substring(0, InStr(G, ".") - 1))
        If F.Substring(locBorK - 1, 1) = "K" Then
          KillAnEntry(SimKeyPad, TheKey)
        Else
          ButtonPress(SimKeyPad, TheKey)
        End If
      End If
      Gone = False
      DelTries = 0
      KillFile = MsgDir & "\" & F
      Do Until Gone
        If DelTries > 2000 Then
          'MsgBox("System problem trying to delete: " & KillFile)
          Gone = True
        End If
        Try
          DelTries += 1
          FileSystem.Kill(KillFile)
          Gone = True
        Catch ex As Exception

        End Try
      Loop
    End If

  End Sub
  Sub KillAnEntry(ByVal TableNum As Integer, ByVal KeyNum As Integer)
    Dim LineNo As Integer
    LineNo = LocationInQueue(TableNum, KeyNum)
    If LineNo < 0 Then Exit Sub 'cant find it, forget it
    KillStackItem(LineNo)
  End Sub
  Function IsLegit(ByVal F As String) As Boolean
    'legit pattern: SddBdd.txt or SddKdd.txt where first digit string 2 or 3 chars, second one 1 or 2 chars.
    If F.Length < 8 Then Return False
    If F.Length > 11 Then Return False
    If F.Substring(0, 1) <> "S" Then Return False
    Dim locB As Integer
    locB = InStr(F, "B")
    If (locB < 4 Or locB > 5) Then
      Dim locK As Integer
      locK = InStr(F, "K")
      If (locK < 4 Or locK > 5) Then Return False
    End If
    If LCase(F.Substring(F.Length - 4, 4)) <> ".txt" Then Return False
    Return True
  End Function
  Private Sub reply_OnKeypadDataReceived(ByVal sender As Object, ByVal e As AxReplyXControl1.IReplyXEvents_OnKeypadDataReceivedEvent) Handles reply.OnKeypadDataReceived
    Dim KeypadID As Integer
    Dim Value As Integer
    KeypadID = e.keypadID
    Value = e.value
    If IsSecondaryKeypad(KeypadID) Then
      Value = Value + 5
      KeypadID = OtherKeypad(KeypadID)
    End If
    ButtonPress(KeypadID, Value)
  End Sub

  Sub RecordLog(ByVal LogType As Integer, ByVal KeypadID As Integer, ByVal Value As String, ByVal WhenStarted As Date)
    Dim L As String
    Try
      FileOpen(1, LogFile, OpenMode.Append)
    Catch ex As Exception
      MsgBox("Cannot open log file: " & LogFile)
      End
    End Try
    Dim currentTime As System.DateTime = System.DateTime.Now
    L = ""
    L = L & currentTime.ToString & ","
    L = L & Format(LogType) & ","
    L = L & Format(KeypadID) & ","
    L = L & Value & "," & WhenStarted.ToString & vbCrLf
    Print(1, L)
    FileClose(1)
  End Sub

  Sub ButtonPress(ByVal KeypadID As Integer, ByVal Value As Integer)
    Dim I As Integer
    Dim GotIt As Boolean
    If Value <> RemoveValue Then 'add a new request to the queue
      StackPush(KeypadID, Value)
    Else
      GotIt = False
      For I = 1 To UBound(KeyPadIDStack)
        If KeypadID = KeyPadIDStack(I) Then
          GotIt = True
          Exit For
        End If
      Next
      If GotIt Then
        RecordLog(2, KeypadID, TypeStack(I), StartTimeStack(I))
        StackPop(I)
      End If
    End If
    Application.DoEvents()

  End Sub

  Sub StackPush(ByVal KeyPadID As Integer, ByVal ButtonID As Integer)
    Dim TableN As String
    Dim RequestType As String
    'OK, students get impatient.  If this is a repeat push, then
    ' just ignore it.
    TableN = GetTable(KeyPadID)
    RequestType = GetRequestType(ButtonID)
    If LocationInQueue(TableN, RequestType) = -1 Then
      RecordLog(1, KeyPadID, RequestType, DummyTime)
      StackPointer += 1
      TableStack(StackPointer) = TableN
      TableNumberStack(StackPointer) = KeyPadID
      StartTimeStack(StackPointer) = Now
      KeyPadIDStack(StackPointer) = KeyPadID
      TypeStack(StackPointer) = RequestType
      TypeNumberStack(StackPointer) = ButtonID
      UpdateDisplay()
    End If
  End Sub
  Function LocationInQueue(ByVal TableString As String, ByVal RequestTypeString As String) As Integer
    Dim I As Integer
    For I = 1 To UBound(TableStack)
      If TableStack(I) = TableString And TypeStack(I) = RequestTypeString Then
        Return I
      End If
    Next
    Return -1
  End Function
  Function LocationInQueue(ByVal TableAsInteger As Integer, ByVal RequestTypeInteger As Integer) As Integer
    Dim I As Integer
    For I = 1 To UBound(TableStack)
      If TableNumberStack(I) = TableAsInteger And TypeNumberStack(I) = RequestTypeInteger Then
        Return I
      End If
    Next
    Return -1
  End Function
  Sub StackPop(ByVal StackMember As Integer)
    Dim I As Integer
    For I = StackMember To StackPointer
      KeyPadIDStack(I) = KeyPadIDStack(I + 1)
      TableStack(I) = TableStack(I + 1)
      TableNumberStack(I) = TableNumberStack(I + 1)
      StartTimeStack(I) = StartTimeStack(I + 1)
      TypeStack(I) = TypeStack(I + 1)
      TypeNumberStack(I) = TypeNumberStack(I + 1)
    Next
    StackPointer -= 1
    UpdateDisplay()
  End Sub

  Sub UpdateDisplay()
    UpdateSharedQueue()
    Me.Invalidate()  'this causes a re-paint of the display
  End Sub
  Sub UpdateSharedQueue()
    Dim I As Integer
    Dim L As String
    FileOpen(1, QueueFile, OpenMode.Output, OpenAccess.Write, OpenShare.LockReadWrite)
    For I = 1 To StackPointer
      If (I <= SafeAmount) Or ((StackPointer + 1 - I) <= SafeAmount) Or (Not TooMany) Then
        L = DisplayFormat(I, TypeStack(I), TableStack(I))
        L &= vbCrLf
        Print(1, L)
      End If
      If I = SafeAmount And TooMany Then
        L = "=======================" & vbCrLf
        Print(1, L)
      End If

    Next
    FileClose(1)
  End Sub
  Function GetTable(ByVal KeypadID As Integer) As String
    Dim I As Integer
    For I = 1 To UBound(Tables)
      If KeypadID = Remotes(I) Or KeypadID = SecondRemotes(I) Then
        Return Tables(I)
      End If
    Next
    RecordLog(0, -96, "Can't find table number " & Format(KeypadID), DummyTime)
    Return Format(KeypadID, "000")
  End Function
  Function GetRequestType(ByVal ButtonID As Integer) As String
    Dim I As Integer
    For I = 1 To UBound(Buttons)
      If ButtonID = Buttons(I) Then
        Return Types(I)
      End If
    Next
    Return "Button: " & Format(ButtonID)
  End Function

  Private Sub TutorQ_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    'MsgBox(" formclosed")
    If UseHardware Then
      reply.StopPolling()
      reply.Disconnect()
    End If
    RecordLog(0, -97, "Shutdown", DummyTime)
    End
  End Sub



  Private Sub TutorQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim Buttons2Types As String
    Dim Remotes2Tables As String
    Dim Colors2Times As String
    Dim SharedPath As String
    AmRunning = False
    'MsgBox("checkpoint 1")
    Me.Show()
    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    Me.Text = "TutorQ " & Version & ": Trying to connect"
    Remotes2Tables = GetSetting("TutorQ", "Files", "Remotes2Tables", "x")
    Buttons2Types = GetSetting("TutorQ", "Files", "Buttons2Types", "x")
    If Remotes2Tables = "x" Or Buttons2Types = "x" Then
      MsgBox("Must run TQConfig to set up file names, etc.")
      End
    End If
    SharedPath = Buttons2Types.Substring(0, InStrRev(Buttons2Types, "\"))
    DMFile = "DailyMessage.txt"
    DMFile = SharedPath & DMFile
    Colors2Times = "Colors2Times.csv"
    Colors2Times = SharedPath & Colors2Times
    QueueFile = GetSetting("TutorQ", "Files", "QueueFile", "C:\QueueFile.txt")
    MsgDir = GetSetting("TutorQ", "Files", "MsgDir", "C:\MsgDir\")
    LogFile = GetSetting("TutorQ", "Files", "LogFile", "C:\TutorQ.log")
    SerialPort = Val(GetSetting("TutorQ", "Ports", "Port", "99"))
    MaxKeyPad = Val(GetSetting("TutorQ", "Ports", "MaxKeyPad", "30"))
    UseHardware = (GetSetting("TutorQ", "Simulate", "SimulateHardware", "No") = "No")
        FontSize = GetSetting("TutorQ", "Info", "FontSize", "18")
    WinLocX = GetSetting("TutorQ", "Window", "WinLocX", "0")
    WinLocY = GetSetting("TutorQ", "Window", "WinLocY", "0")
    WinWidth = GetSetting("TutorQ", "Window", "WinWidth", "800")
    WinHeight = GetSetting("TutorQ", "Window", "WinHeight", "600")


    ' GetDailyMessage()   put off getting the daily message until first screen re-build
    DailyMessage = "Version: " + Version + " (Daily message in < 60 secs)"

    Timer1.Interval = 1000 * 60   ' EVERY 1 MINUTE now because it is adjusting colors
    Timer1.Enabled = True

    'WinLocX = 1280
    'WinWidth = 1280
        'WinHeight = 800
    'WinLocY = 0

        Me.Left = WinLocX
    Me.Top = WinLocY
    Me.Width = WinWidth
    Me.Height = WinHeight
    ReadButtons2Types(Buttons2Types, Buttons, Types)
    ReadRemotes2Tables(Remotes2Tables, Remotes, Tables, SecondRemotes)
    ReadColors2Times(Colors2Times, MyColors, Times)
    StartUp()
    StackPointer = 0
    UpdateSharedQueue()
  End Sub
  Sub GetDailyMessage()
    DailyMessage = ""
    Dim IsOpen As Boolean

    IsOpen = False
    If My.Computer.FileSystem.FileExists(DMFile) Then
      Try
        FileOpen(11, DMFile, OpenMode.Input)
        IsOpen = True
        DailyMessage = "  " + Trim(LineInput(11))
      Catch ex As Exception
      End Try
      If IsOpen Then
        FileClose(11)
      End If
    End If
  End Sub
  Sub ReadButtons2Types(ByVal Fl As String, ByRef Indx() As Integer, ByRef Str() As String)
    Dim L As String = ""
    Dim F() As String
    Dim I As Integer
    ReDim F(0)
    ReDim Indx(0)
    ReDim Str(0)
    Try
      FileOpen(1, Fl, OpenMode.Input)
    Catch ex As Exception
      MsgBox(Fl & "Did not open correctly.")
      End
    End Try
    Do Until EOF(1)
      L = LineInput(1)
      ParseCSV.ParseCSV(L, F)
      If IsCleanNumber(F(1)) Then
        I = UBound(Indx) + 1
        ReDim Preserve Indx(I)
        ReDim Preserve Str(I)
        Indx(I) = Val(F(1))
        Str(I) = F(2)
      End If

    Loop
    FileClose(1)

  End Sub
  Sub ReadColors2Times(ByVal Fl As String, ByRef myColor() As SolidBrush, ByRef Time() As Single)
    Dim L As String = ""
    Dim F() As String
    Dim I As Integer
    Dim Red As Integer
    Dim Green As Integer
    Dim Blue As Integer
    ReDim F(0)
    ReDim myColor(0)
    ReDim Time(0)
    Try
      FileOpen(1, Fl, OpenMode.Input)
    Catch ex As Exception
      MsgBox(Fl & "Did not open correctly.")
      End
    End Try
    Do Until EOF(1)
      L = LineInput(1)
      ParseCSV.ParseCSV(L, F)
      If IsCleanNumber(F(1)) Then
        I = UBound(myColor) + 1
        ReDim Preserve myColor(I)
        ReDim Preserve Time(I)
        Red = Val(F(2))
        Green = Val(F(3))
        Blue = Val(F(4))
        myColor(I) = New SolidBrush(Color.FromArgb(Red, Green, Blue))
        Time(I) = Val(F(1))
      End If
    Loop
    myColor(0) = New SolidBrush(Color.FromArgb(0, 0, 0))
    FileClose(1)
  End Sub
  Sub ReadRemotes2Tables(ByVal Fl As String, ByRef Indx() As Integer, ByRef Str() As String, ByRef Clicker2() As Integer)
    Dim L As String = ""
    Dim F() As String
    Dim I As Integer
    ReDim F(0)
    ReDim Indx(0)
    ReDim Str(0)
    Try
      FileOpen(1, Fl, OpenMode.Input)
    Catch ex As Exception
      MsgBox(Fl & "Did not open correctly.")
      End
    End Try
    Do Until EOF(1)
      L = LineInput(1)
      ParseCSV.ParseCSV(L, F)
      If IsCleanNumber(F(1)) Then
        I = UBound(Indx) + 1
        ReDim Preserve Indx(I)
        ReDim Preserve Str(I)
        ReDim Preserve Clicker2(I)
        Indx(I) = Val(F(1))
        Str(I) = F(2)
        Clicker2(I) = Val(F(3))
        OtherKeypad(Indx(I)) = Clicker2(I)
        OtherKeypad(Clicker2(I)) = Indx(I)
        IsSecondaryKeypad(Indx(I)) = False
        IsSecondaryKeypad(Clicker2(I)) = True
      End If
    Loop
    FileClose(1)
  End Sub
  Function IsCleanNumber(ByVal S As String) As Boolean
    Dim I As Integer
    Dim J As Integer
    For I = 1 To Len(S)
      J = Asc(Mid(S, I, 1))
      If J <> Asc(".") Then
        If J < Asc("0") Or J > Asc("9") Then Return False
      End If
    Next
    Return True
  End Function

  Function GetLineNo(ByVal y As Single) As Integer
    Return Int(((y - 5) / MyFontHeight) + 1)
  End Function

  Private Sub TutorQ_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
    Dim x As Single
    Dim y As Single
    Dim LineNo As Integer
    x = e.X
    y = e.Y
    LineNo = GetLineNo(y)
    KillStackItem(LineNo)
  End Sub
  Sub KillStackItem(ByVal LineNo As Integer)
    If ((Not TooMany) Or LineNo <= SafeAmount) And LineNo <= StackPointer And LineNo > 0 Then
      RecordLog(0, -95, "KillStackitem lineno " & Format(LineNo), DummyTime)
      StackPop(LineNo)
    End If
  End Sub

  Private Sub TutorQ_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Dim I As Integer
    Dim J As Integer
    Dim NN As Integer
    Dim returnValue As SizeF
    Dim L As String
    Dim X, Y As Single
    Dim SaveWidth As Integer
    Dim SaveHeight As Integer
    Dim StaleTime As Single
    Dim StaleSystem As TimeSpan

    NN = StackPointer + 2
    myFont = New System.Drawing.Font("Arial", FontSize)
    SaveWidth = Me.Width
    SaveHeight = Me.Height
    Me.Font = myFont
    Me.Width = SaveWidth
    Me.Height = SaveHeight
    returnValue = e.Graphics.MeasureString("AAAA", Font)
    MyFontHeight = returnValue.Height * 1.05
    HowMany = Int((Me.Height - 64) / MyFontHeight) - 1
    TooMany = HowMany < StackPointer
    SafeAmount = HowMany / 2
    If SafeAmount * 2 + 1 > HowMany Then
      SafeAmount -= 1
    End If

    X = 5
    Y = 5
    For I = 1 To StackPointer
      StaleSystem = Now().Subtract(StartTimeStack(I))
      StaleTime = (60 * StaleSystem.Hours) + StaleSystem.Minutes + StaleSystem.Seconds / 60.0
      ColorStack(I) = MyColors(0) ' initially all start at color = 0 black
      For J = 1 To UBound(MyColors)
        If StaleTime > Times(J) Then
          ColorStack(I) = MyColors(J)
        End If
      Next

      If (I <= SafeAmount) Or ((StackPointer + 1 - I) <= SafeAmount) Or (Not TooMany) Then
        L = DisplayFormat(I, TypeStack(I), TableStack(I))
        e.Graphics.DrawString(L, myFont, ColorStack(I), X, Y)
        Y += MyFontHeight
      End If
      If I = SafeAmount And TooMany Then
        L = "======================="
        e.Graphics.DrawString(L, myFont, ColorStack(I), X, Y)
        Y += MyFontHeight
      End If
    Next
    NN = StackPointer + 1
    Y = Me.Height - MyFontHeight - 3
    If DailyMessage <> "" Then
      e.Graphics.DrawString(DailyMessage, myFont, Brushes.Chocolate, X, Y)
    End If
    Application.DoEvents()

  End Sub

  Function DisplayFormat(ByVal I As Integer, ByVal theType As String, ByVal theTableIN As String)
    Dim theTable As String
    theTable = theTableIN
    If IsCleanNumber(theTableIN) Then
      If Val(theTableIN) > 100 Then
        theTable = "Computer " + Format(Val(theTableIN) - 100)
      End If
    End If
    Return "  " & Format(I, "00") & ": " & theType + ": " & theTable
  End Function

  Private Sub TutorQ_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
    Dim pt As Point
    Dim returnValue As Rectangle
    Me.Invalidate()
    If Not UseHardware Then
      SimulatedKeypad.Left = Me.Right + 50
      SimulatedKeypad.Top = Me.Top
      returnValue = Screen.GetWorkingArea(pt)
      If SimulatedKeypad.Right > returnValue.Right Then
        SimulatedKeypad.Left = returnValue.Right - SimulatedKeypad.Width - 10
      End If
    End If
  End Sub

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    GetDailyMessage()
    UpdateDisplay()
  End Sub
End Class
