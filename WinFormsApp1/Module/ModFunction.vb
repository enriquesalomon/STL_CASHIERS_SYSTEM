'Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.Text
Imports System.Data.SqlClient
Module ModFunction
    'Public con As New MySqlConnection
    'Public cmd As New MySqlCommand
    'Public adapter As New MySqlDataAdapter
    'Public data As New DataSet
    'Public table As New DataTable

    'Public mylogin As New Login
    'Sub openCon()
    '    con.ConnectionString = "server=localhost;username=root;password=;database=wt_db"
    '    con.Open()
    'End Sub

    Public mylogin As New Login

    Public mysqlconn As New SqlClient.SqlConnection
    Public conString As String = getConnectionPATH()
    Public cServername, mstring, strquery As String
    Public lconection As Boolean
    'Public ReportPath As String = "\\WINSERVER\REPORTS\CAT"
    'Public ReportPath As String = "C:\Users\Admin Staff\Desktop\CET EDITED\CET UPDATED\CET SCHEDULING AND RESULTS EVALUATION SYSTEM\CET SCHEDULING AND RESULTS EVALUATION SYSTEM\Reports"




    Public Function getConnectionPATH() As String
        mstring = ""
        'Local==============

        cServername = "VIPOFFICE\SQLEXPRESS"
        'cServername = "(localdb)\Projects"
        mstring = "server=" & cServername & ";Database=stl_cashier_db;Integrated security=true;"

        ''SERVER===============
        'mstring = "Network Library=DBMSSOCN;Data Source=192.168.1.42,1433;Initial Catalog=JHCSC_CET; Integrated security=true;"

        'other
        'mstring = "Network Library=DBMSSOCN;Data Source= 127.0.0.1,1433;Initial Catalog=JHCSC_CET; Integrated security=true;"

        Return mstring
    End Function

    'Public Function getRecentAdmissionSched(ByVal Controlnumber As String, ByVal tablename As String) As Boolean

    '    ntable.Rows.Clear()
    '    ndataset.Clear()
    '    Call connectSQL(conString)
    '    mycommand = mysqlconn.CreateCommand
    '    mycommand.CommandText = "select  *  from " & tablename & " where SchedNo ='" & (Controlnumber) & "'"
    '    myadapter.SelectCommand = mycommand
    '    myadapter.Fill(ndataset, tablename)
    '    ntable = ndataset.Tables(tablename)
    '    If mydataTable.Rows.Count > 0 Then
    '        For Each lrow As DataRow In mydataTable.Rows

    '            Homeaddress = lrow("Baranggay").ToString & Space(1) & lrow("City").ToString & Space(1) & "," & lrow("Province").ToString

    '        Next
    '    End If

    'End Function

    Public AdmissionSched As String
    Public Function getRecentAdmissionSched() As String
        'Try


        '    ntable.Rows.Clear()
        '    ndataset.Clear()
        '    Call connectSQL(conString)
        '    mycommand = mysqlconn.CreateCommand
        '    mycommand.CommandText = "Select Top 1  * from AdmissionSchedule  order by SchedNo DESC"
        '    myadapter.SelectCommand = mycommand
        '    myadapter.Fill(mydataset, "AdmissionSchedule")
        '    mydataTable = mydataset.Tables("AdmissionSchedule")

        '    For Each mrow As DataRow In mydataTable.Rows
        '        AdmissionSched = mrow("SchedNo").ToString
        '    Next
        'Catch ex As Exception

        'End Try
    End Function
    Public Sub connectSQL(ByVal lconString As String)
        Try
            With mysqlconn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = lconString
                .Open()
                lconection = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Function FileExists(ByVal filename) As Boolean
        On Error Resume Next
        FileExists = (Dir$(filename) <> "")
    End Function
End Module
