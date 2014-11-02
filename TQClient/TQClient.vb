Imports System.IO
Imports Microsoft.Win32
Public Class TQClient
  Dim SharedDir As String
  Dim MsgDir As String
  Dim ID As String
  Dim QueueFile As String
  Dim MostRecentRead As Date
  Dim RefreshRate As Integer
  Dim Remotes(5) As Integer
  Dim Tables(5) As String
  Dim SecondRemotes(5) As Integer
  Dim OtherKeypad(256) As Integer
  Dim IsSecondaryKeypad(256) As Boolean
  Dim ButtonNumbers() As Integer
  Dim ButtonStrings() As String
  Dim ARequestIsOutThere As Boolean


  Private Sub TQClient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    CleanUpRequests()
  End Sub

  Private Sub TQClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim Buttons2Txt As String
    Dim Remotes2Tables As String
    Dim Admin As Boolean
    Dim regKey As RegistryKey
    Dim tutorqKey As RegistryKey
    Dim UsingRegistry As String
    Dim ItOpened As Boolean

    ARequestIsOutThere = False
    regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", False)
    tutorqKey = regKey.OpenSubKey("TutorQ", RegistryKeyPermissionCheck.ReadSubTree)
    'tutorqKey = Registry.LocalMachine.OpenSubKey("TutorQ", False)
    Try
      'MsgBox("1")
      UsingRegistry = tutorqKey.GetValue("UseRegistry", "No")
    Catch
      UsingRegistry = "No"
      'MsgBox("1.5")
    End Try

    'MsgBox("2")
    If UsingRegistry = "No" Then 'lab computer
      Dim Mn As String
      'MsgBox("3")
      Mn = My.Computer.Name
      Dim Ach As String
      Do While Mn.Length > 0
        Ach = Mn.Substring(Mn.Length - 1)
        If IsDigit(Ach) Then
          ID = Mn.Substring(Mn.Length - 2)
          Exit Do
        Else
          Mn = Mn.Substring(0, Mn.Length - 1)
        End If
      Loop
      Mn = Application.StartupPath

      'ID += 100 'lab computers are in the 101-199 rangebut where is that 100 appended?
      'MsgBox("ID = " & Format(ID))
      'if not using registry, we can try a configuration file.
      ItOpened = True
      Try
        FileOpen(1, Mn & "\Config.txt", OpenMode.Input)
      Catch ex As Exception
        ItOpened = False
      End Try

      If ItOpened Then
        MsgDir = Trim(LineInput(1))
        SharedDir = Trim(LineInput(1))
        QueueFile = SharedDir + "\QueueFile.txt"
        RefreshRate = Val(LineInput(1))
        FileClose(1)
      Else
        MsgDir = "\\19-22-tutorq\MessageBox"
        SharedDir = "\\19-22-tutorq\TutorQ-Shared"
        QueueFile = SharedDir + "\QueueFile.txt"
        RefreshRate = 750
      End If

      Admin = False
    Else
      ID = tutorqKey.GetValue("ID", "99")
      MsgDir = tutorqKey.GetValue("MsgDir", "C:\MsgDir")
      SharedDir = tutorqKey.GetValue("Shared", "C:\Shared")
      QueueFile = SharedDir + "\QueueFile.txt"
      RefreshRate = Val(tutorqKey.GetValue("Refresh", "2000"))
      Admin = (GetSetting("TQClient", "S", "Admin", "No") = "Yes")
    End If
    If Admin Then
      cmdDelete.Visible = True
    End If
    Timer1.Enabled = False
    Timer1.Interval = RefreshRate
    Buttons2Txt = SharedDir & " \Buttons2Types.csv"
    Remotes2Tables = SharedDir & " \Remotes2Tables.csv"

    ReadButtons2Types(Buttons2Txt, ButtonNumbers, ButtonStrings)
    ReadRemotes2Tables(Remotes2Tables, Remotes, Tables, secondremotes)
    cmd1.Text = ButtonStrings(1)
    cmd2.Text = ButtonStrings(2)
    cmd3.Text = ButtonStrings(3)
    cmd4.Text = ButtonStrings(4)
    cmd5.Text = ButtonStrings(5)
    cmd6.Text = ButtonStrings(6)
    cmd7.Text = ButtonStrings(7)
    cmd8.Text = ButtonStrings(8)
    cmd9.Text = ButtonStrings(9)
    cmdA.Text = ButtonStrings(10)

    'note: in TutorQ, button 1 is pretty much hard coded as the cancel button
    MostRecentRead = "1/1/2002"
    lblStation.Text = "Computer " & Format(ID)
    DoResize()
    Timer1.Enabled = True

    'MsgBox("ID: " & Format(ID))
  End Sub
  Function IsDigit(ByVal Ch As String) As Boolean
    Dim Ich As Integer
    Ich = Asc(Ch)
    If Ich > Asc("9") Then Return False
    If Ich < Asc("0") Then Return False
    Return True
  End Function

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
      ParseCSV(L, F)
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
      ParseCSV(L, F)
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


  Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
    CleanUpRequests()
    End
  End Sub
  Sub CleanUpRequests()
    'This is a general-purpose cleanup.  It won't handle if the client has put in multiple
    'different requests, but will handle most situations.
    If ARequestIsOutThere Then WriteMsg(ID, 1) ' 1 is the end button.
  End Sub
  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    Dim FileTime As Date
    Dim Std As StreamReader
    Dim F As String
    Dim L As String
    Dim Loc As Integer
    Timer1.Enabled = False
    FileTime = FileSystem.FileDateTime(QueueFile)
    If FileTime > MostRecentRead Then
      Std = New StreamReader(QueueFile)
      F = Std.ReadToEnd
      Std.Close()
      F &= vbCrLf
      ListBox1.Items.Clear()
      Do While F.Length > 0
        Loc = InStr(F, vbCrLf)
        If Loc = 0 Then Exit Do
        L = F.Substring(0, Loc - 1)
        If Trim(L) = "" Then Exit Do
        F = F.Substring(Loc)
        ListBox1.Items.Add(L)
      Loop
      MostRecentRead = FileTime
    End If
    Timer1.Enabled = True
  End Sub
  Public Sub ParseCSV(ByVal L As String, ByRef F() As String)
    Dim nF As Integer
    Dim NextCSV As String = ""
    Dim Rest As String = ""
    'L = """bla = """"bla,fred"""""""
    L &= "," 'put in a terminating comma so we always get one safely
    nF = 0
    ReDim F(nF)
    Do
      GetNextCSV(L, NextCSV, Rest)
      nF += 1
      ReDim Preserve F(nF)
      F(nF) = NextCSV
      If Rest = "" Then Exit Do
      L = Rest
    Loop
  End Sub
  Sub GetNextCSV(ByVal L As String, ByRef NextCSV As String, ByRef Rest As String)
    Dim LocC As Integer
    Dim A As String
    LocC = NextCommaNotInQuotes(L)
    If L.Substring(0, 1) = """" Then
      'this is the tricky one, processing a quoted field
      A = L.Substring(1, LocC - 2) ' remove the open quote
      A = Trim(A)
      If A.Substring(A.Length - 1) <> """" Then
        MsgBox("The last character before the comma should have been a quote: " & L)
        End
      End If
      A = Trim(A.Substring(0, A.Length - 1))
      NextCSV = DeDoubleQuote(A)
      Rest = Trim(L.Substring(LocC))

    Else
      NextCSV = Trim(L.Substring(0, LocC - 1))
      Rest = Trim(L.Substring(LocC))

    End If

  End Sub
  Function NextCommaNotInQuotes(ByVal L As String) As Integer
    Dim LocEndQ As Integer
    Dim LocStartQ As Integer
    Dim LocComma As Integer
    LocStartQ = InStr(L, """")
    LocEndQ = 0
    Do While LocStartQ > 0
      LocEndQ = LocStartQ + FindEndQ(L.Substring(LocStartQ), """") ' find the close quote
      LocStartQ = InStr(LocEndQ + 1, L, """")
      LocComma = InStr(LocEndQ + 1, L, ",")
      If LocStartQ <> 0 Then
        If LocComma < LocStartQ Then
          Exit Do
        End If
      End If
    Loop
    LocComma = InStr(LocEndQ + 1, L, ",")
    Return LocComma
  End Function
  Function FindEndQ(ByVal L As String, ByVal Delim As String) As Integer
    Dim I As Integer
    Dim J As Integer
    Dim A As String
    Dim LocQ As Integer
    Dim LocDoubleQ As Integer
    L = L
    I = 1
    Do
      LocDoubleQ = InStr(I, L, Delim & Delim)
      LocQ = InStr(I, L, Delim)
      If LocQ = 0 Then
        MsgBox("Unterminated quote in " & L)
        Return -1
      End If
      If LocDoubleQ = LocQ Then
        'we need to recurse this string-within a string
        A = L.Substring(LocQ)
        J = FindEndQ(A.Substring(Delim.Length), Delim & Delim)
        I = J + LocQ + 2 * Delim.Length + 1
      Else
        Return LocQ
      End If
    Loop

  End Function
  Function DeDoubleQuote(ByVal L As String) As String
    L = SubstituteStr(L, """""", """")
    Return L
  End Function
  Function SubstituteStr(ByVal Lin As String, ByVal Find As String, ByVal ReplaceWith As String)
    Dim I As Integer
    Dim L As String
    L = Lin
    I = 1
    Do
      I = InStr(I, L, Find)
      If I = 0 Then Exit Do
      L = L.Substring(0, I - 1) & ReplaceWith & L.Substring(I + Find.Length - 1)
      I += ReplaceWith.Length - Find.Length + 1
    Loop
    Return L
  End Function
  Sub WriteMsg(ByVal theID As Integer, ByVal theButton As Integer)
    Dim F As String
    Dim MD As String
    MD = MsgDir
    If MD.Substring(MD.Length - 1) <> "\" Then
      MD &= "\"
    End If
    'note: in TutorQ, button 1 is pretty much hard coded as the cancel button
    'ensure not double backslash!!!!
    If theButton > 0 Then
      F = MD & "S" & Format(theID, "00") & "B" & Format(theButton) & ".txt"
    Else
      F = MD & "S" & Format(theID, "00") & "K" & Format(-theButton) & ".txt"
    End If
    If theButton = 1 Then  'because button 1 is the cancel button
      ARequestIsOutThere = False
      lblCloseWarning.Visible = False
    Else
      ARequestIsOutThere = True
      lblCloseWarning.Visible = True
    End If
    Try
      FileOpen(2, F, OpenMode.Output, OpenAccess.Write)
    Catch ex As Exception
      'MsgBox("Tried and failed to open for write: " & vbCrLf & F)
    End Try

    FileClose(2)
  End Sub
  Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
    WriteMsg(ID, 1)
  End Sub
  Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
    WriteMsg(ID, 2)
  End Sub
  Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
    WriteMsg(ID, 3)
  End Sub
  Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
    WriteMsg(ID, 4)
  End Sub
  Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
    WriteMsg(ID, 5)
  End Sub
  Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
    WriteMsg(ID, 6)
  End Sub
  Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
    WriteMsg(ID, 7)
  End Sub
  Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
    WriteMsg(ID, 8)
  End Sub
  Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
    WriteMsg(ID, 9)
  End Sub
  Private Sub cmdA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdA.Click
    WriteMsg(ID, 10)
  End Sub

  Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    Dim I As Integer
    Dim T As Integer
    Dim B As Integer

    'For I = 0 To ListBox1.Items.Count - 1
    'T = ListBox1.Items(I)
    'Next
    I = ListBox1.SelectedIndex
    If I = -1 Then
      MsgBox("To delete a request, select it first, then press the Delete key.")
      Exit Sub
    End If
    T = GetClickerID(ListBox1.Items(I))
    B = GetButtonID(ListBox1.Items(I))
    ' we now know that the clicker ID corresponding the request we want to delete
    ' is in "T".  make up a fake "OK message" and put it in the queue.
    'we are using the actual button number, made negative, so that the correct element in the queue can be
    'deleted when there are more than one elements from the same table.
    If T = 0 Then
      MsgBox("Can't figure out table number for: " & vbCrLf & ListBox1.Items(I))
    End If
    WriteMsg(T, -B)
  End Sub
  Function GetClickerID(ByVal L As String) As Integer
    ' get the table id number
    Dim I As Integer
    Dim TableString As String
    Dim LocColon As Integer
    LocColon = InStrRev(L, ":")
    If LocColon < 1 Then
      MsgBox("no colon in queue line in GetTable:  & l)")
      Return 0
    End If
    TableString = Trim(L.Substring(LocColon))
    For I = 1 To Tables.Length - 1
      If Trim(Tables(I)) = TableString Then
        Return Remotes(I)
      End If

    Next
    Return 0
  End Function
  Function GetButtonID(ByVal L As String) As Integer
    ' get the table id number
    Dim I As Integer
    Dim ButtonString As String
    Dim LocColon As Integer
    LocColon = InStrRev(L, ":")
    If LocColon < 1 Then
      MsgBox("no colon in queue line in GetTable:  & l)")
      Return 0
    End If
    L = L.Substring(0, LocColon - 1)
    LocColon = InStrRev(L, ":")
    If LocColon < 1 Then
      MsgBox("no colon in queue line in GetTable:  & l)")
      Return 0
    End If
    ButtonString = Trim(L.Substring(LocColon))
    For I = 1 To ButtonStrings.Length - 1
      If Trim(ButtonStrings(I)) = ButtonString Then
        Return ButtonNumbers(I)
      End If

    Next
    Return 0
  End Function

  Private Sub TQClient_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
    DoResize()
  End Sub
  Sub DoResize()

    Dim Fnt As Font
    Dim Hgt As Single
    Dim LBwidth As Single
    Dim LineWidth As Single
    If Me.Height > 80 Then
      ListBox1.Height = Me.Height - 35
      Hgt = (Me.Height - 70) / 15
      'hmmm  that height may be a bit big if the window is narrow
      ' lets use "xxxxxxxxxxxxxxxxx" and make sure it fits
      LBwidth = ListBox1.Width
      Fnt = New Font("Arial", Hgt)
      LineWidth = TextRenderer.MeasureText("xxxxxxxxxxxxxxXXXXXXXXXXXXXXxxxxxxxx", Fnt).Width
      If LineWidth > LBwidth Then
        Hgt = Hgt * LBwidth / LineWidth
        Fnt = New Font("Arial", Hgt)
      End If

      ListBox1.Font = Fnt
    End If
  End Sub


End Class
