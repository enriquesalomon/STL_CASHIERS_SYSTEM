Imports System.Data.SqlClient
Module ModVariablesFunctions
    Public username, password, cashier, tempName, strprefix, Homeaddress, examineeno, qryStatement, printDoc As String
    Public mycommand As New SqlCommand
    Public myadapter As New SqlDataAdapter
    Public mysqlreader As SqlDataReader
    Public mydataset, ndataset As New DataSet
    Public mydataTable, ntable As New DataTable

    Public lsaving, lfind, xkey As Boolean
    Public recCounter, tempCounter As Integer

    Public cMonth, nday, nYear, mmonth As Integer
    Public tempcurrDate, strTemp, verifyExaminee As String
    Public currDate As Date

    Public rfID As String



    Public Function TrapKeyVer2(ByVal KCode As String, ByVal Textbox As Object) As Boolean
        'For numeric input only
        '//textbox keypress event insert numeric only
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then

            'ASCII Code for numeric
            TrapKeyVer2 = False
        ElseIf KCode = 46 Then
            'ASCII Code for decimal character
            TrapKeyVer2 = False

        Else
            'ASCII Code If user Key IN non-numeric value
            TrapKeyVer2 = True


        End If
        xkey = TrapKeyVer2
    End Function
    Public Function TrapKeyVer3(ByVal KCode As String, ByVal Textbox As Object) As Boolean

        '//textbox keypress event insert numeric only
        If (KCode >= 1 Or KCode <= 127) Then

            'ASCII Code If user Key IN non-numeric value
            TrapKeyVer3 = True


        End If
        xkey = TrapKeyVer3
    End Function
    Public Sub BackForeColorMe(ByVal Textbox As Object, ByVal lfocus As Boolean)

        If lfocus Then
            Textbox.backcolor = Color.Black
            Textbox.forecolor = Color.White
        Else
            Textbox.backcolor = Color.White
            Textbox.forecolor = Color.Black
        End If

    End Sub

    Public Sub BackForeColorMeDigitTextbox(ByVal Textbox As Object, ByVal lfocus As Boolean)

        If lfocus Then
            Textbox.backcolor = Color.Black
            Textbox.forecolor = Color.White
        Else
            Textbox.backcolor = Color.White
            Textbox.forecolor = Color.Black
        End If

    End Sub
    Public Function remove_mask(ByVal m_parameter As String) As Object
        Dim retval As String, ctr As Integer
        Dim mskval As Double
        retval = ""
        If Len(m_parameter) > 0 Then
            For ctr = 1 To Len(m_parameter)
                If Mid(m_parameter, ctr, 1) <> m_parameter Then
                    If ctr <= 2 Then
                        retval = retval & Mid(m_parameter, ctr, 1)

                    ElseIf ctr = 3 Then
                        retval = retval & Mid(m_parameter, 4, 4)

                    End If
                    mskval = retval
                End If
            Next
            remove_mask = retval
        Else
            remove_mask = m_parameter
        End If
    End Function
    Public Function remove_mask2(ByVal m_parameter As String) As Object
        Dim strText, textlenght, strChar As String
        Dim i As Integer
        Dim tempText As Char
        strText = ""
        textlenght = ""
        tempText = ""
        strChar = ""
        strText = Trim(m_parameter)
        textlenght = Trim(strText.Length)
        For i = 0 To textlenght - 1
            tempText = strText.Chars(i)
            If tempText = ":" Or tempText = "-" Or tempText = "" Then
            Else
                strChar &= Trim(tempText)
            End If
        Next
        remove_mask2 = Trim(strChar)
    End Function
    Public Function getCurrday(ByVal currdate As Date) As Integer
        Dim cday As Integer
        If Not IsDate(currdate) Then
            Exit Function
        Else
            getCurrday = String.Format("{0:dd}", currdate)
        End If

        cday = CInt(getCurrday)
    End Function
    Public Function getCurryear(ByVal currdate As Date) As Integer
        Dim cyear As Integer
        If Not IsDate(currdate) Then
            Exit Function
        Else
            getCurryear = String.Format("{0:yyyy}", Date.Now)
        End If
        cyear = CInt(getCurryear)

    End Function
    Public Function getCurrmonth(ByVal currdate As Date) As Integer
        Dim cmonth As Integer
        If Not IsDate(currdate) Then
            Exit Function
        Else
            getCurrmonth = String.Format("{0:MM}", currdate)
        End If
        cmonth = CInt(getCurrmonth)
    End Function
    Public Function ComputeAge(ByVal nbirthdate As Date, ByVal lTrue As Boolean) As String



        currDate = String.Format("{0:MM/dd/yyyy}", Date.Now)
        strTemp = ""
        If Not IsDate(nbirthdate) Then
            ' Exit Function
        End If
        On Error Resume Next
        If Month(nbirthdate) Like Month(currDate) And getCurrday(nbirthdate) Like getCurrday(nbirthdate) Then

            '   MsgBox ("Happy Happy Happy Birthday!....")
        Else
            tempcurrDate = Str(Month(nbirthdate)) & "/" & Str(getCurrday(nbirthdate)) & "/" & Str(getCurryear(nbirthdate))


            If getCurrday(nbirthdate) <> getCurrday(currDate) Then

                nday = DateTime.DaysInMonth(getCurryear(nbirthdate), getCurrmonth(nbirthdate)) ' ' to be able to know numbers days of the month.
            End If
            nday = ((IIf(getCurrday(currDate) > getCurrday(nbirthdate), 0, nday) + getCurrday(currDate) - getCurrday(nbirthdate)))
            If (Month(currDate) > Month(nbirthdate)) Then
                cMonth = (Month(currDate) - Month(nbirthdate)) - IIf(getCurrday(nbirthdate) > getCurrday(currDate), 1, 0)
            ElseIf (Month(currDate) Like Month(nbirthdate)) Then
                cMonth = IIf(getCurrday(nbirthdate) > getCurrday(currDate), 11, 0)
            Else
                cMonth = ((Month(currDate) + 12) - Month(nbirthdate))
            End If
        End If
        nYear = DateDiff("YYYY", nbirthdate, currDate) - IIf(currDate >= currDate, 1, 0)
        'strTemp = "You are " & nYear & " Year(s), " & cMonth & " Month(s), and " & nDay & IIf(lTrue = True, " day(s) old", " day(s)")

        If nYear > 0 And cMonth > 0 And nday <= 0 Then
            ' strTemp = " " & nYear & " year(s) and " & cMonth & " month(s)"
            strTemp = " " & nYear
        ElseIf nYear > 0 And cMonth <= 0 And nday > 0 Then
            'strTemp = " " & nYear & " year(s) and " & nDay & IIf(lTrue = True, " day(s) old", " day(s)")
            strTemp = " " & nYear
        ElseIf nYear <= 0 And cMonth > 0 And nday > 0 Then
            ' strTemp = " " & cMonth & " month(s) and " & nDay & IIf(lTrue = True, " day(s) old", " day(s)")
        ElseIf nYear <= 0 And cMonth <= 0 And nday > 0 Then

            strTemp = " " & nday & IIf(lTrue = True, " day(s) old", " day(s)")
        ElseIf nYear <= 0 And cMonth > 0 And nday <= 0 Then
            'strTemp = " " & cMonth & " month(s)"
            strTemp = " " & cMonth
        ElseIf nYear > 0 And cMonth <= 0 And nday <= 0 Then
            'strTemp = " " & nYear & " year(s)"
            strTemp = " " & nYear
        Else
            ' strTemp = " " & nYear & " year(s), " & cMonth & " month(s),& " & nDay & IIf(lTrue = True, " day(s) old", " day(s)")
            ' strTemp = " " & nYear
            strTemp = " " & nYear & " year(s), " & cMonth & " month(s)"
        End If

        mmonth = cMonth
        ComputeAge = strTemp + 1
        strTemp = strTemp + 1
    End Function


    Public Function getRFNumber(ByVal ID As String) As Boolean
        strprefix = "RF"
        Try
            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "Select Top 1  * from tbl_ReceiversForm  order by ID DESC"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "tbl_ReceiversForm")
            mydataTable = mydataset.Tables("tbl_ReceiversForm")

            For Each mrow As DataRow In mydataTable.Rows
                ID = String.Format("{0:000000}", mrow("ID"))
            Next
            If mydataTable.Rows.Count = 0 Then
                ID = strprefix & "000001"
            Else
                ID = strprefix & String.Format("{0:000000}", Mid(Trim(ID), 3, 8) + 1)
            End If
            rfID = Trim(ID)
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Function
End Module
