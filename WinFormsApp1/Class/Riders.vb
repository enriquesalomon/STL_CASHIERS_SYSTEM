Public Class Riders
    Sub loadridersList()
        FrmReceiversForm.cboRiders.Items.Clear()

        qryStatement = "select DISTINCT Rider from tb_SalesSummaryImported "

        Call connectSQL(conString)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = qryStatement
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "tb_SalesSummaryImported")
        mydataTable = mydataset.Tables("tb_SalesSummaryImported")
        mysqlreader = mycommand.ExecuteReader
        If mydataTable.Rows.Count > 0 Then
            While mysqlreader.Read()
                FrmReceiversForm.cboRiders.Items.Add(mysqlreader("Rider").ToString)
            End While
        Else
        End If
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub


    Sub LoadRidersCollectionRecord()
        Try

            FrmReceiversForm.dtgRidersCollection.ColumnCount = 7
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


            FrmReceiversForm.dtgRidersCollection.Columns(5).HeaderText = "TAPADA"
            FrmReceiversForm.dtgRidersCollection.Columns(5).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(5).Name = "tapada"
            FrmReceiversForm.dtgRidersCollection.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversForm.dtgRidersCollection.Columns(6).HeaderText = "COLLECTIBLES"
            FrmReceiversForm.dtgRidersCollection.Columns(6).Width = 70
            FrmReceiversForm.dtgRidersCollection.Columns(6).Name = "collictibles"
            FrmReceiversForm.dtgRidersCollection.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


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
            qryStatement = "select salesdate,cluster,municipality,rider,coordinator,agent,comm,username,overallgross,overallcomm,overallnet,overallhits,revenue from tb_SalesSummaryImported where Rider ='" & Trim(FrmReceiversForm.cboRiders.Text) & "' order by Coordinator ASC"

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
                    Dim collectibles As String = "0"

                    'Format(CDate(lrow("salesdate")), "MM/dd/yyyy").ToString,
                    Dim row As String() = New String() {lrow("username").ToString, lrow("coordinator").ToString, lrow("overallnet").ToString, lrow("overallhits").ToString, tapada, collectibles}
                    FrmReceiversForm.dtgRidersCollection.Rows.Add(row)
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



        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub

End Class
