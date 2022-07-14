Public Class Riders
    'Sub loadridersList()
    '    FrmReceiversForm.cboRiders.Items.Clear()

    '    qryStatement = "select DISTINCT Rider from tb_SalesSummaryImported "

    '    Call connectSQL(conString)
    '    mycommand = mysqlconn.CreateCommand
    '    mycommand.CommandText = qryStatement
    '    myadapter.SelectCommand = mycommand
    '    myadapter.Fill(mydataset, "tb_SalesSummaryImported")
    '    mydataTable = mydataset.Tables("tb_SalesSummaryImported")
    '    mysqlreader = mycommand.ExecuteReader
    '    If mydataTable.Rows.Count > 0 Then
    '        While mysqlreader.Read()
    '            FrmReceiversForm.cboRiders.Items.Add(mysqlreader("Rider").ToString)
    '        End While
    '    Else
    '    End If
    '    mysqlreader.Close()
    '    mysqlconn.Close()
    'End Sub

    Public Function checkExisting() As Boolean
        Dim ntable As New DataTable
        Dim ndataset As New DataSet



        Try
            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "select  *  from tbl_ReceiversForm  where SALESDATE='" & (Format(CDate(FrmRidersDailySummary.lblDate.Text), "yyyy-MM-dd").ToString) & "' and RIDER='" & (FrmRidersDailySummary.lblridername.Text) & "' "

            myadapter.SelectCommand = mycommand
            myadapter.Fill(ndataset, "tbl_ReceiversForm")
            ntable = ndataset.Tables("tbl_ReceiversForm")

            If ntable.Rows.Count > 0 Then
                checkExisting = True
            Else
                checkExisting = False
            End If
            ntable.Rows.Clear()
            ndataset.Clear()

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try

    End Function


    Sub LoadRidersCollectionRecord()
        Try



            FrmReceiversForm.dtgRidersCollection.ColumnCount = 8
            FrmReceiversForm.dtgRidersCollection.RowsDefaultCellStyle.BackColor = Color.White
            FrmReceiversForm.dtgRidersCollection.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            FrmReceiversForm.dtgRidersCollection.Columns(0).HeaderText = "USERNAME"
            FrmReceiversForm.dtgRidersCollection.Columns(0).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(0).Name = "username"
            FrmReceiversForm.dtgRidersCollection.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversForm.dtgRidersCollection.Columns(1).HeaderText = "COORDINATOR"
            FrmReceiversForm.dtgRidersCollection.Columns(1).Width = 100
            FrmReceiversForm.dtgRidersCollection.Columns(1).Name = "coordinator"
            FrmReceiversForm.dtgRidersCollection.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmReceiversForm.dtgRidersCollection.Columns(2).HeaderText = "OVERALL NET"
            FrmReceiversForm.dtgRidersCollection.Columns(2).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(2).Name = "overallnet"
            FrmReceiversForm.dtgRidersCollection.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversForm.dtgRidersCollection.Columns(3).HeaderText = "ONDATE HITS"
            FrmReceiversForm.dtgRidersCollection.Columns(3).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(3).Name = "ondatehits"
            FrmReceiversForm.dtgRidersCollection.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversForm.dtgRidersCollection.Columns(4).HeaderText = "PREVIOUS HITS"
            FrmReceiversForm.dtgRidersCollection.Columns(4).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(4).Name = "previoushits"
            FrmReceiversForm.dtgRidersCollection.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


            FrmReceiversForm.dtgRidersCollection.Columns(5).HeaderText = "CLAIMED HITS"
            FrmReceiversForm.dtgRidersCollection.Columns(5).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(5).Name = "claimedhits"
            FrmReceiversForm.dtgRidersCollection.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversForm.dtgRidersCollection.Columns(6).HeaderText = "TAPADA"
            FrmReceiversForm.dtgRidersCollection.Columns(6).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(6).Name = "tapada"
            FrmReceiversForm.dtgRidersCollection.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            FrmReceiversForm.dtgRidersCollection.Columns(7).HeaderText = "COLLECTIBLES"
            FrmReceiversForm.dtgRidersCollection.Columns(7).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(7).Name = "collictibles"
            FrmReceiversForm.dtgRidersCollection.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            FrmReceiversForm.dtgRidersCollection.Rows.Clear()
            mydataTable.Rows.Clear()
            mydataset.Clear()
            qryStatement = ""


            'If filterByTestSite Then
            '    qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where AdmissionSchedNo ='" & Trim(AdmissionSched) & "' and TestingSite ='" & Trim(cboFilterTestSite.Text) & "'  order by ExamineeInfo.ExamineeNo ASC "
            '    'qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where between'" & Format(CDate(dtFromdate.Text), "yyyy-MM-dd").ToString & "' and '" & Format(CDate(dtTodate.Text), "yyyy-MM-dd").ToString & "'  order by ExamineeInfo.ExamineeNo ASC "

            'Else
            '    If lfind Then
            '        'qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where AdmissionSchedNo ='" & Trim(sched) & "' and Lastname like '%" & txtsearch.Text & "%' or ExamineeInfo.Examineeno  like '%" & txtsearch.Text & "%' or Firstname like '%" & txtsearch.Text & "%'"
            '        qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where AdmissionSchedNo ='" & Trim(AdmissionSched) & "' and Lastname like '%" & txtsearch.Text & "%' "

            '    Else
            '        qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where AdmissionSchedNo ='" & Trim(AdmissionSched) & "'  order by Lastname ASC"

            '    End If
            'End If
            qryStatement = "select salesdate,cluster,municipality,rider,coordinator,agent,comm,username,overallgross,overallcomm,overallnet,overallhits,revenue from tb_SalesSummaryImported  where SALESDATE ='" & Format(CDate(FrmReceiversEntry.rfsalesdate), "yyyy-MM-dd").ToString & "' and RIDER ='" & FrmReceiversEntry.rfridername.ToString & "'  order by Coordinator ASC"

            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = qryStatement
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "tb_SalesSummaryImported")
            mydataTable = mydataset.Tables("tb_SalesSummaryImported")
            recCounter = 0
            tempName = ""
            If mydataTable.Rows.Count > 0 Then
                For Each lrow As DataRow In mydataTable.Rows
                    Dim tapada As String = "0"
                    Dim claimedhits As String = "0"
                    Dim previoushits As String = "0"
                    Dim collectibles As String = "0"

                    'Format(CDate(lrow("salesdate")), "MM/dd/yyyy").ToString,
                    Dim row As String() = New String() {lrow("username").ToString, lrow("coordinator").ToString, Format(CDbl(lrow("overallnet").ToString), "###,###,###.#0"), Format(CDbl(lrow("overallhits").ToString), "###,###,###.#0"), Format(CDbl(previoushits), "###,###,###.#0"), Format(CDbl(claimedhits), "###,###,###.#0"), Format(CDbl(tapada), "###,###,###.#0"), Format(CDbl(collectibles), "###,###,###.#0")}
                    FrmReceiversForm.dtgRidersCollection.Rows.Add(row)

                Next
            End If
            FrmReceiversForm.txtCollector.Text = FrmReceiversEntry.rfridername
            FrmReceiversForm.txtDateofSales.Text = FrmReceiversEntry.rfsalesdate

            'If viewWithSched = True Then
            '    Dim i As Integer = 0
            '    For Each RW As DataGridViewRow In FrmRidersDailySummary.dtgRidersCollection.Rows

            '        If RW.Cells(8).Value.ToString = "NONE" Then
            '            FrmRidersDailySummary.dtgRidersCollection.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
            '            FrmRidersDailySummary.dtgRidersCollection.Rows(i).DefaultCellStyle.ForeColor = Color.White
            '        Else
            '            FrmRidersDailySummary.dtgRidersCollection.Rows(i).DefaultCellStyle.BackColor = Color.White
            '            FrmRidersDailySummary.dtgRidersCollection.Rows(i).DefaultCellStyle.ForeColor = Color.Black

            '        End If : i += 1


            '        'totdiscount += CDbl(RW.Cells(4).Value.ToString)
            '    Next

            'End If

            If FrmReceiversForm.dtgRidersCollection.Rows.Count <> 0 Then
                Dim totalnet As Double = 0
                Dim totaltotalondatehits As Double = 0
                Dim totalprevioushits As Double = 0
                Dim totalclaimedhits As Double = 0
                Dim totaltapada As Double = 0
                Dim totalcollectibles As Double = 0
                Dim i As Integer = 0

                For Each RW As DataGridViewRow In FrmReceiversForm.dtgRidersCollection.Rows
                    totalnet += CDbl(RW.Cells(2).Value)
                    totaltotalondatehits += CDbl(RW.Cells(3).Value)
                    totalprevioushits += CDbl(RW.Cells(4).Value)
                    totalclaimedhits += CDbl(RW.Cells(5).Value)
                    totaltapada += CDbl(RW.Cells(6).Value)
                    totalcollectibles += CDbl(RW.Cells(7).Value)

                Next : i += 1
                Dim linerow As String() = New String() {"==========", "==========", "==========", "==========", "==========", "==========", "==========", "=========="}
                FrmReceiversForm.dtgRidersCollection.Rows.Add(linerow)

                Dim nrow As String() = New String() {"", " TOTAL:", Format(totalnet, "###,###,###.#0"), Format(totaltotalondatehits, "###,###,###.#0"), Format(totalprevioushits, "###,###,###.#0"), Format(totalclaimedhits, "###,###,###.#0"), Format(totaltapada, "###,###,###.#0"), Format(totalcollectibles, "###,###,###.#0")}
                FrmReceiversForm.dtgRidersCollection.Rows.Add(nrow)

            End If
            'frmClientLedger.txtRunningBalance.Text = Format(CDbl(totalplanamount - (totalpaid - totalpenalty)), "###,###,###.#0")
            'Dim remainno As Integer = 0
            'remainno = CDbl(totalplanamount - (totalpaid - totalpenalty)) / CDbl(frmClientLedger.txtAmortPayable.Text)
            'frmClientLedger.txtRemaingNumPayment.Text = remainno


        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

    Sub LoadRidersDailySummary()
        Try

            FrmRidersDailySummary.dtgRidersCollection.Rows.Clear()

            FrmRidersDailySummary.dtgRidersCollection.ColumnCount = 7
            FrmRidersDailySummary.dtgRidersCollection.RowsDefaultCellStyle.BackColor = Color.White
            FrmRidersDailySummary.dtgRidersCollection.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            FrmRidersDailySummary.dtgRidersCollection.Columns(0).HeaderText = "NO."
            FrmRidersDailySummary.dtgRidersCollection.Columns(0).Width = 50
            FrmRidersDailySummary.dtgRidersCollection.Columns(0).Name = "num"
            FrmRidersDailySummary.dtgRidersCollection.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmRidersDailySummary.dtgRidersCollection.Columns(1).HeaderText = "USERNAME"
            FrmRidersDailySummary.dtgRidersCollection.Columns(1).Width = 70
            FrmRidersDailySummary.dtgRidersCollection.Columns(1).Name = "username"
            FrmRidersDailySummary.dtgRidersCollection.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmRidersDailySummary.dtgRidersCollection.Columns(2).HeaderText = "COORDINATOR"
            FrmRidersDailySummary.dtgRidersCollection.Columns(2).Width = 100
            FrmRidersDailySummary.dtgRidersCollection.Columns(2).Name = "coordinator"
            FrmRidersDailySummary.dtgRidersCollection.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmRidersDailySummary.dtgRidersCollection.Columns(3).HeaderText = "GROSS"
            FrmRidersDailySummary.dtgRidersCollection.Columns(3).Width = 70
            FrmRidersDailySummary.dtgRidersCollection.Columns(3).Name = "gross"
            FrmRidersDailySummary.dtgRidersCollection.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmRidersDailySummary.dtgRidersCollection.Columns(4).HeaderText = "COMMS"
            FrmRidersDailySummary.dtgRidersCollection.Columns(4).Width = 70
            FrmRidersDailySummary.dtgRidersCollection.Columns(4).Name = "comm"
            FrmRidersDailySummary.dtgRidersCollection.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmRidersDailySummary.dtgRidersCollection.Columns(5).HeaderText = "NET"
            FrmRidersDailySummary.dtgRidersCollection.Columns(5).Width = 70
            FrmRidersDailySummary.dtgRidersCollection.Columns(5).Name = "net"
            FrmRidersDailySummary.dtgRidersCollection.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


            FrmRidersDailySummary.dtgRidersCollection.Columns(6).HeaderText = "HITS"
            FrmRidersDailySummary.dtgRidersCollection.Columns(6).Width = 70
            FrmRidersDailySummary.dtgRidersCollection.Columns(6).Name = "hits"
            FrmRidersDailySummary.dtgRidersCollection.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


            FrmRidersDailySummary.dtgRidersCollection.Rows.Clear()
            mydataTable.Rows.Clear()
            mydataset.Clear()
            qryStatement = ""


            'If filterByTestSite Then
            '    qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where AdmissionSchedNo ='" & Trim(AdmissionSched) & "' and TestingSite ='" & Trim(cboFilterTestSite.Text) & "'  order by ExamineeInfo.ExamineeNo ASC "
            '    'qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where between'" & Format(CDate(dtFromdate.Text), "yyyy-MM-dd").ToString & "' and '" & Format(CDate(dtTodate.Text), "yyyy-MM-dd").ToString & "'  order by ExamineeInfo.ExamineeNo ASC "

            'Else
            '    If lfind Then
            '        'qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where AdmissionSchedNo ='" & Trim(sched) & "' and Lastname like '%" & txtsearch.Text & "%' or ExamineeInfo.Examineeno  like '%" & txtsearch.Text & "%' or Firstname like '%" & txtsearch.Text & "%'"
            '        qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where AdmissionSchedNo ='" & Trim(AdmissionSched) & "' and Lastname like '%" & txtsearch.Text & "%' "

            '    Else
            '        qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where AdmissionSchedNo ='" & Trim(AdmissionSched) & "'  order by Lastname ASC"

            '    End If
            'End If
            qryStatement = "select salesdate,cluster,municipality,rider,coordinator,agent,comm,username,overallgross,overallcomm,overallnet,overallhits,revenue from tb_SalesSummaryImported where Rider ='" & Trim(FrmRidersDailySummary.cboRiders.Text) & "' AND salesdate= '" & Format(CDate(FrmRidersDailySummary.DateTimePicker1.Text), "yyyy-MM-dd").ToString & "'  order by Coordinator ASC"

            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = qryStatement
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "tb_SalesSummaryImported")
            mydataTable = mydataset.Tables("tb_SalesSummaryImported")
            recCounter = 0
            tempName = ""
            If mydataTable.Rows.Count > 0 Then
                Dim num As Integer = 0
                For Each lrow As DataRow In mydataTable.Rows
                    num += 1
                    Dim tapada As String = "0"
                    Dim claimedhits As String = "0"
                    Dim collectibles As String = "0"

                    'Format(CDate(lrow("salesdate")), "MM/dd/yyyy").ToString,
                    Dim row As String() = New String() {num, lrow("username").ToString, lrow("coordinator").ToString, Format(CDbl(lrow("overallgross").ToString), "###,###,###.#0"), Format(CDbl(lrow("overallcomm").ToString), "###,###,###.#0"), Format(CDbl(lrow("overallnet").ToString), "###,###,###.#0"), Format(CDbl(lrow("overallhits").ToString), "###,###,###.#0")}
                    FrmRidersDailySummary.dtgRidersCollection.Rows.Add(row)
                Next
            End If

            'If viewWithSched = True Then
            '    Dim i As Integer = 0
            '    For Each RW As DataGridViewRow In FrmReceiversForm.dtgRidersCollection.Rows

            '        If RW.Cells(8).Value.ToString = "NONE" Then
            '            FrmReceiversForm.dtgRidersCollection.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
            '            FrmReceiversForm.dtgRidersCollection.Rows(i).DefaultCellStyle.ForeColor = Color.White
            '        Else
            '            FrmReceiversForm.dtgRidersCollection.Rows(i).DefaultCellStyle.BackColor = Color.White
            '            FrmReceiversForm.dtgRidersCollection.Rows(i).DefaultCellStyle.ForeColor = Color.Black

            '        End If : i += 1


            '        'totdiscount += CDbl(RW.Cells(4).Value.ToString)
            '    Next

            'End If

            FrmRidersDailySummary.lblDate.Text = FrmRidersDailySummary.DateTimePicker1.Value.Date

            FrmRidersDailySummary.lblridername.Text = FrmRidersDailySummary.cboRiders.Text

            If FrmRidersDailySummary.dtgRidersCollection.Rows.Count = 0 Then
                MessageBox.Show("No Record Found", "System Response", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

End Class
