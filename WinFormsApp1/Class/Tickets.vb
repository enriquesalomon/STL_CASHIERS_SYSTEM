Public Class Tickets

    Public Sub LoadRecord()
        Try
            FrmTicketEntry.dtgTickets.ColumnCount = 6
            FrmTicketEntry.dtgTickets.RowsDefaultCellStyle.BackColor = Color.White
            FrmTicketEntry.dtgTickets.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            FrmTicketEntry.dtgTickets.Columns(0).HeaderText = "ID"
            FrmTicketEntry.dtgTickets.Columns(0).Width = 70
            FrmTicketEntry.dtgTickets.Columns(0).Name = "id"
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



            If lfind Then
                'qryStatement = "select * from [stl_cashier_db].[dbo].[tbl_ClaimedTicket] where RFID ='" & FrmReceiversForm.txtrfNum.Text & "' AND   order by Coordinator ASC"
                qryStatement = "select * from [stl_cashier_db].[dbo].[tbl_ClaimedTicket] where AMOUNT ='" & FrmTicketEntry.txtSearch.Text & "' OR TICKET_TYPE LIKE '%" & FrmTicketEntry.txtSearch.Text & "%' OR AMOUNT LIKE '%" & FrmReceiversForm.txtAgentCode.Text & "%' AND  RFID ='" & FrmReceiversForm.txtrfNum.Text & "' order by ID ASC"

            Else
                qryStatement = "select * from [stl_cashier_db].[dbo].[tbl_ClaimedTicket] where RFID ='" & FrmReceiversForm.txtrfNum.Text & "' AND RIDER = '" & FrmReceiversForm.txtCollector.Text & "' AND AGENTCODE = '" & FrmReceiversForm.txtAgentCode.Text & "'order by ID ASC"
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
                    'Format(CDate(lrow("DRAWDATE")), "MM/dd/yyyy")
                    Dim row As String() = New String() {lrow("ID").ToString, Format(CDate(lrow("DRAWDATE")), "yyyy-MM-dd"), lrow("AGENTCODE").ToString, Format(CDbl(lrow("AMOUNT").ToString), "###,###,###.#0"), Format(CDate(lrow("CLAIMEDDATE")), "MM/dd/yyyy").ToString, lrow("TICKET_TYPE").ToString}

                    FrmTicketEntry.dtgTickets.Rows.Add(row)
                Next
            End If

            If FrmTicketEntry.dtgTickets.Rows.Count > 0 Then
                Dim i As Integer = 0
                Dim TotalOndate As Double = 0
                Dim TotalPrevious As Double = 0
                Dim TotalTIckets As DueDate = 0

                For Each RW As DataGridViewRow In FrmTicketEntry.dtgTickets.Rows


                    If RW.Cells(5).Value.ToString = "ONDATE" Then
                        TotalOndate += CDbl(RW.Cells(3).Value.ToString)
                    ElseIf RW.Cells(5).Value.ToString = "PREVIOUS" Then
                        TotalPrevious += CDbl(RW.Cells(3).Value.ToString)

                    End If : i += 1
                    TotalTIckets = TotalOndate + TotalPrevious

                    FrmTicketEntry.lblondateticket.Text = Format(CDbl(TotalOndate), "###,###,###.#0")
                    FrmTicketEntry.lblprevticket.Text = Format(CDbl(TotalPrevious), "###,###,###.#0")
                    FrmTicketEntry.lbltotalticket.Text = Format(CDbl(TotalTIckets), "###,###,###.#0")


                Next
            Else
                FrmTicketEntry.lblondateticket.Text = 0.00
                FrmTicketEntry.lblprevticket.Text = 0.00
                FrmTicketEntry.lbltotalticket.Text = 0.00

            End If
            globalAgentCode = FrmTicketEntry.lblagentcode.Text
            getClaimedHits()


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
            "Values ('" & FrmTicketEntry.lblagentcode.Text & "','" & agenttype & "','" & FrmTicketEntry.txtWinningAmount.Text & "','" & Format(CDate(FrmTicketEntry.dtpDrawDate.Text), "yyyy-MM-dd").ToString & "','" & Format(CDate(Date.Now), "yyyy-MM-dd").ToString & "','" & FrmTicketEntry.cmbTicketType.Text & "','" & "" & "','" & FrmReceiversForm.txtCollector.Text & "','" & cashier & "','" & FrmReceiversForm.txtrfNum.Text & "')"
            mycommand.ExecuteNonQuery()
            MsgBox("New Receivers Form has been successfully Saved ", MsgBoxStyle.OkOnly, "Message")
            mytickets.LoadRecord()

        End If
    End Sub




    Public Sub Delete()

        Dim amountwon As Double
        Dim datestring As String
        Dim agentcode As String
        Dim claimeddate As String
        Dim rfid As String
        Dim id As String

        Dim GridRow As DataGridViewRow = FrmTicketEntry.dtgTickets.CurrentRow


        For Each datagrd As DataGridViewRow In FrmTicketEntry.dtgTickets.SelectedRows
            id = CStr(GridRow.Cells.Item("id").Value)
            amountwon = CStr(GridRow.Cells.Item("amountwon").Value)
            datestring = CStr(GridRow.Cells.Item("drawdate").Value)
            agentcode = CStr(GridRow.Cells.Item("agentcode").Value)
            claimeddate = CStr(GridRow.Cells.Item("claimeddate").Value)
            rfid = FrmReceiversForm.txtrfNum.Text


        Next datagrd
        If datestring = "" Then
            Exit Sub
        End If




        If MessageBox.Show("Are you sure you want to Delete this Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "DELETE TOP(1) FROM tbl_ClaimedTicket WHERE AMOUNT='" & amountwon & "' AND DRAWDATE='" & datestring & "'  AND ID='" & id & "' "
            mycommand.ExecuteNonQuery()
            LoadRecord()
            FrmTicketEntry.txtWinningAmount.Clear()
            FrmTicketEntry.txtWinningAmount.Focus()
            MsgBox("Ticket  record has been successfully Deleted", MsgBoxStyle.OkOnly, "Message")


        End If
    End Sub

    Public Function checkHasOndateHits() As Boolean
        Dim ntable As New DataTable
        Dim ndataset As New DataSet



        'Try
        Call connectSQL(conString)
        mycommand = mysqlconn.CreateCommand
        'mycommand.CommandText = "select  *  from tbl_ReceiversForm  where SALESDATE='" & (Format(CDate(FrmRidersDailySummary.lblDate.Text), "yyyy-MM-dd").ToString) & "' and RIDER='" & (FrmRidersDailySummary.lblridername.Text) & "' "
        mycommand.CommandText = "select  *  from tbl_ReceiversForm  where SALESDATE='" & Format(CDate(FrmRidersDailySummary.lblDate.Text), "yyyy-MM-dd") & "' and RIDER='" & (FrmRidersDailySummary.lblridername.Text) & "' "

        myadapter.SelectCommand = mycommand
        myadapter.Fill(ndataset, "tbl_ReceiversForm")
        ntable = ndataset.Tables("tbl_ReceiversForm")

        If ntable.Rows.Count > 0 Then
            checkHasOndateHits = True
        Else
            checkHasOndateHits = False
        End If
        ntable.Rows.Clear()
        ndataset.Clear()

        'Catch ex As Exception
        '    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        'End Try

    End Function


    Sub getClaimedHits()
        'GET TOTAL CLAIMED ONDATE--------------
        mydataTable.Rows.Clear()
        mydataset.Clear()
        Call connectSQL(conString)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * FROM tbl_ClaimedTicket  where TICKET_TYPE='ONDATE' AND AGENTCODE='" & globalAgentCode & "'"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "tbl_ClaimedTicket")
        mydataTable = mydataset.Tables("tbl_ClaimedTicket")
        Dim ondateamount As Double = 0

        If mydataTable.Rows.Count > 0 Then
            For Each mrow As DataRow In mydataTable.Rows
                ondateamount += CDbl(mrow("AMOUNT").ToString)
            Next

        End If
        FrmReceiversForm.txtOndateHitsClaimed.Text = Format(ondateamount, "###,###,###.#0")
        'GET TOTAL CLAIMED PREVIOUS--------------
        mydataTable.Rows.Clear()
        mydataset.Clear()
        Call connectSQL(conString)
        mycommand = mysqlconn.CreateCommand
        mycommand.CommandText = "Select * FROM tbl_ClaimedTicket  where TICKET_TYPE='PREVIOUS' AND AGENTCODE='" & globalAgentCode & "'"
        myadapter.SelectCommand = mycommand
        myadapter.Fill(mydataset, "tbl_ClaimedTicket")
        mydataTable = mydataset.Tables("tbl_ClaimedTicket")
        Dim prevhits As Double = 0
        If mydataTable.Rows.Count > 0 Then
            For Each mrow As DataRow In mydataTable.Rows
                prevhits += CDbl(mrow("AMOUNT").ToString)
            Next

        End If
        FrmReceiversForm.txtPreviousHitsClaimed.Text = Format(prevhits, "###,###,###.#0")

        FrmReceiversForm.txtTotalHitsClaimed.Text = Format(ondateamount + prevhits, "###,###,###.#0")

    End Sub

End Class
