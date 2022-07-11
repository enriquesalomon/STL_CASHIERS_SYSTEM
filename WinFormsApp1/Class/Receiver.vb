Public Class Receiver
    Sub LoadRFList()
        Try

            FrmReceiversEntry.dtgReceiversFormList.Rows.Clear()

            FrmReceiversEntry.dtgReceiversFormList.ColumnCount = 7
            FrmReceiversEntry.dtgReceiversFormList.RowsDefaultCellStyle.BackColor = Color.White
            FrmReceiversEntry.dtgReceiversFormList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            FrmReceiversEntry.dtgReceiversFormList.Columns(0).HeaderText = "NO."
            FrmReceiversEntry.dtgReceiversFormList.Columns(0).Width = 50
            FrmReceiversEntry.dtgReceiversFormList.Columns(0).Name = "num"
            FrmReceiversEntry.dtgReceiversFormList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversEntry.dtgReceiversFormList.Columns(1).HeaderText = "FORM#"
            FrmReceiversEntry.dtgReceiversFormList.Columns(1).Width = 70
            FrmReceiversEntry.dtgReceiversFormList.Columns(1).Name = "formnum"
            FrmReceiversEntry.dtgReceiversFormList.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversEntry.dtgReceiversFormList.Columns(2).HeaderText = "SALESDATE"
            FrmReceiversEntry.dtgReceiversFormList.Columns(2).Width = 100
            FrmReceiversEntry.dtgReceiversFormList.Columns(2).Name = "coordinator"
            FrmReceiversEntry.dtgReceiversFormList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmReceiversEntry.dtgReceiversFormList.Columns(3).HeaderText = "RIDER/COLLECTOR"
            FrmReceiversEntry.dtgReceiversFormList.Columns(3).Width = 70
            FrmReceiversEntry.dtgReceiversFormList.Columns(3).Name = "rider"
            FrmReceiversEntry.dtgReceiversFormList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversEntry.dtgReceiversFormList.Columns(4).HeaderText = "RECEIVER"
            FrmReceiversEntry.dtgReceiversFormList.Columns(4).Width = 70
            FrmReceiversEntry.dtgReceiversFormList.Columns(4).Name = "receiver"
            FrmReceiversEntry.dtgReceiversFormList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmReceiversEntry.dtgReceiversFormList.Columns(5).HeaderText = "DATE CREATED"
            FrmReceiversEntry.dtgReceiversFormList.Columns(5).Width = 70
            FrmReceiversEntry.dtgReceiversFormList.Columns(5).Name = "datecreated"
            FrmReceiversEntry.dtgReceiversFormList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


            FrmReceiversEntry.dtgReceiversFormList.Columns(6).HeaderText = "DATE REMMITED"
            FrmReceiversEntry.dtgReceiversFormList.Columns(6).Width = 70
            FrmReceiversEntry.dtgReceiversFormList.Columns(6).Name = "dateremitted"
            FrmReceiversEntry.dtgReceiversFormList.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


            FrmReceiversEntry.dtgReceiversFormList.Rows.Clear()
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
            qryStatement = "select ID,SALESDATE,RIDER,CASHIER,DATECREATED,DATERECEIVED from tbl_ReceiversForm order by DATECREATED DESC"

            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = qryStatement
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "tbl_ReceiversForm")
            mydataTable = mydataset.Tables("tbl_ReceiversForm")
            recCounter = 0
            tempName = ""
            If mydataTable.Rows.Count > 0 Then
                Dim num As Integer = 0
                For Each lrow As DataRow In mydataTable.Rows
                    num += 1


                    'Format(CDate(lrow("salesdate")), "MM/dd/yyyy").ToString,
                    Dim row As String() = New String() {num, lrow("ID").ToString, Format(CDate(lrow("SALESDATE")), "MM/dd/yyyy").ToString, lrow("RIDER").ToString, lrow("CASHIER").ToString, Format(CDate(lrow("DATECREATED")), "MM/dd/yyyy").ToString, Format(CDate(lrow("DATERECEIVED")), "MM/dd/yyyy").ToString}
                    FrmReceiversEntry.dtgReceiversFormList.Rows.Add(row)
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


            'If FrmReceiversEntry.dtgReceiversFormList.Rows.Count = 0 Then
            '    MessageBox.Show("No Record Found", "System Response", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub
End Class
