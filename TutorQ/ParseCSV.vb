Module ParseCSV
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

End Module
