Public Class Tickets

    Public Sub LoadRecord()
        Try
            FrmTicketEntry.dtgTickets.ColumnCount = 6
            FrmTicketEntry.dtgTickets.RowsDefaultCellStyle.BackColor = Color.White
            FrmTicketEntry.dtgTickets.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            FrmTicketEntry.dtgTickets.Columns(0).HeaderText = "NO.O"
            FrmTicketEntry.dtgTickets.Columns(0).Width = 70
            FrmTicketEntry.dtgTickets.Columns(0).Name = "seqnox"
            FrmTicketEntry.dtgTickets.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmTicketEntry.dtgTickets.Columns(1).HeaderText = "DRAW DATE"
            FrmTicketEntry.dtgTickets.Columns(1).Width = 100
            FrmTicketEntry.dtgTickets.Columns(1).Name = "drawdate"
            FrmTicketEntry.dtgTickets.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            FrmTicketEntry.dtgTickets.Columns(2).HeaderText = "AGENT CODE"
            FrmTicketEntry.dtgTickets.Columns(2).Width = 70
            FrmTicketEntry.dtgTickets.Columns(2).Name = "agentcode"
            FrmTicketEntry.dtgTickets.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmTicketEntry.dtgTickets.Columns(3).HeaderText = "AMOUNT WON"
            FrmTicketEntry.dtgTickets.Columns(3).Width = 70
            FrmTicketEntry.dtgTickets.Columns(3).Name = "amountwon"
            FrmTicketEntry.dtgTickets.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmTicketEntry.dtgTickets.Columns(4).HeaderText = "CLAIMED DATE"
            FrmTicketEntry.dtgTickets.Columns(4).Width = 100
            FrmTicketEntry.dtgTickets.Columns(4).Name = "claimeddate"
            FrmTicketEntry.dtgTickets.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            FrmTicketEntry.dtgTickets.Columns(5).HeaderText = "TICKET TYPE"
            FrmTicketEntry.dtgTickets.Columns(5).Width = 100
            FrmTicketEntry.dtgTickets.Columns(5).Name = "tickettype"
            FrmTicketEntry.dtgTickets.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            FrmTicketEntry.dtgTickets.Rows.Clear()
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


            'qryStatement = "Select * from ExamineeInfo inner join Address on ExamineeInfo.Examineeno=Address.Examineeno where DateInserted between'" & Format(CDate(dtFromdate.Text), "yyyy-MM-dd").ToString & "' and '" & Format(CDate(dtTodate.Text), "yyyy-MM-dd").ToString & "'  order by ExamineeInfo.ExamineeNo ASC "


            If lfind Then
                'qryStatement = "select * from [stl_cashier_db].[dbo].[tbl_ClaimedTicket] where RFID ='" & FrmReceiversForm.txtrfNum.Text & "' AND   order by Coordinator ASC"

            Else
                qryStatement = "select * from [stl_cashier_db].[dbo].[tbl_ClaimedTicket] where RFID ='" & FrmReceiversForm.txtrfNum.Text & "' AND RIDER = '" & FrmReceiversForm.txtCollector.Text & "' order by ID ASC"
            End If
            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = qryStatement
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "tbl_ClaimedTicket")
            mydataTable = mydataset.Tables("tbl_ClaimedTicket")
            recCounter = 0
            tempName = ""
            If mydataTable.Rows.Count > 0 Then
                For Each lrow As DataRow In mydataTable.Rows

                    recCounter += 1

                    Dim row As String() = New String() {recCounter & ".", Format(CDate(lrow("DRAWDATE")), "MM/dd/yyyy").ToString, lrow("AGENTCODE").ToString, Format(CDbl(lrow("AMOUNT").ToString), "###,###,###.#0"), Format(CDate(lrow("CLAIMEDDATE")), "MM/dd/yyyy").ToString, lrow("TICKET_TYPE").ToString}
                    FrmTicketEntry.dtgTickets.Rows.Add(row)
                Next
            End If

            'If viewWithSched = True Then
            '    Dim i As Integer = 0
            '    For Each RW As DataGridViewRow In FrmTicketEntry.dtgTickets.Rows

            '        If RW.Cells(8).Value.ToString = "NONE" Then
            '            FrmTicketEntry.dtgTickets.Rows(i).DefaultCellStyle.BackColor = Color.IndianRed
            '            FrmTicketEntry.dtgTickets.Rows(i).DefaultCellStyle.ForeColor = Color.White
            '        Else
            '            FrmTicketEntry.dtgTickets.Rows(i).DefaultCellStyle.BackColor = Color.White
            '            FrmTicketEntry.dtgTickets.Rows(i).DefaultCellStyle.ForeColor = Color.Black

            '        End If : i += 1


            '        'totdiscount += CDbl(RW.Cells(4).Value.ToString)
            '    Next

            'End If



        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub



    Sub Save()
        If CDbl(FrmTicketEntry.txtWinningAmount.Text) <= 0 Then
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to save this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Call connectSQL(conString)

            mycommand = mysqlconn.CreateCommand
            Dim agenttype As String = ""
            mycommand.CommandText = "Insert into tbl_ClaimedTicket (AGENTCODE,AGENTTYPE,AMOUNT,DRAWDATE,CLAIMEDDATE,TICKET_TYPE,OFFICE_SHARE,RIDER,CASHIER,RFID)" &
            "Values ('" & FrmTicketEntry.lblagentcode.Text & "','" & FrmTicketEntry.txtWinningAmount.Text & "','" & agenttype & "','" & Format(CDate(FrmTicketEntry.dtpDrawDate.Text), "yyyy-MM-dd").ToString & "','" & Format(CDate(Date.Now), "yyyy-MM-dd").ToString & "','" & FrmTicketEntry.cmbTicketType.Text & "','" & "" & "','" & FrmReceiversForm.txtCollector.Text & "','" & cashier & "','" & FrmReceiversForm.txtrfNum.Text & "')"
            mycommand.ExecuteNonQuery()





            MsgBox("New Receivers Form has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
            mytickets.LoadRecord()

        End If
    End Sub
End Class
