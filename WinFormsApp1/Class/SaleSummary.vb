Public Class SaleSummary


    Public Sub LoadRecord()
        Try
            FrmGameAccountsSummary.dtgSummary.ColumnCount = 14
            FrmGameAccountsSummary.dtgSummary.RowsDefaultCellStyle.BackColor = Color.White
            FrmGameAccountsSummary.dtgSummary.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            FrmGameAccountsSummary.dtgSummary.Columns(0).HeaderText = "NO.O"
            FrmGameAccountsSummary.dtgSummary.Columns(0).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(0).Name = "seqnox"
            FrmGameAccountsSummary.dtgSummary.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmGameAccountsSummary.dtgSummary.Columns(1).HeaderText = "DATE"
            FrmGameAccountsSummary.dtgSummary.Columns(1).Width = 100
            FrmGameAccountsSummary.dtgSummary.Columns(1).Name = "salesdate"
            FrmGameAccountsSummary.dtgSummary.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            FrmGameAccountsSummary.dtgSummary.Columns(2).HeaderText = "CLUSTER"
            FrmGameAccountsSummary.dtgSummary.Columns(2).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(2).Name = "cluster"
            FrmGameAccountsSummary.dtgSummary.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmGameAccountsSummary.dtgSummary.Columns(3).HeaderText = "MUNICIPALITY"
            FrmGameAccountsSummary.dtgSummary.Columns(3).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(3).Name = "municipality"
            FrmGameAccountsSummary.dtgSummary.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmGameAccountsSummary.dtgSummary.Columns(4).HeaderText = "COORDINATOR"
            FrmGameAccountsSummary.dtgSummary.Columns(4).Width = 100
            FrmGameAccountsSummary.dtgSummary.Columns(4).Name = "coordinator"
            FrmGameAccountsSummary.dtgSummary.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmGameAccountsSummary.dtgSummary.Columns(5).HeaderText = "AGENT"
            FrmGameAccountsSummary.dtgSummary.Columns(5).Width = 120
            FrmGameAccountsSummary.dtgSummary.Columns(5).Name = "agent"
            FrmGameAccountsSummary.dtgSummary.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            FrmGameAccountsSummary.dtgSummary.Columns(6).HeaderText = "COMM(%)"
            FrmGameAccountsSummary.dtgSummary.Columns(6).Width = 50
            FrmGameAccountsSummary.dtgSummary.Columns(6).Name = "comm"
            FrmGameAccountsSummary.dtgSummary.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmGameAccountsSummary.dtgSummary.Columns(7).HeaderText = "USERNAME"
            FrmGameAccountsSummary.dtgSummary.Columns(7).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(7).Name = "username"
            FrmGameAccountsSummary.dtgSummary.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmGameAccountsSummary.dtgSummary.Columns(8).HeaderText = "OVERALL GROSS"
            FrmGameAccountsSummary.dtgSummary.Columns(8).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(8).Name = "overallgross"
            FrmGameAccountsSummary.dtgSummary.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


            FrmGameAccountsSummary.dtgSummary.Columns(9).HeaderText = "OVERALL COMM."
            FrmGameAccountsSummary.dtgSummary.Columns(9).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(9).Name = "overallcomm"
            FrmGameAccountsSummary.dtgSummary.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmGameAccountsSummary.dtgSummary.Columns(10).HeaderText = "OVERALL NET"
            FrmGameAccountsSummary.dtgSummary.Columns(10).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(10).Name = "overallnet"
            FrmGameAccountsSummary.dtgSummary.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmGameAccountsSummary.dtgSummary.Columns(11).HeaderText = "OVERALL HITS"
            FrmGameAccountsSummary.dtgSummary.Columns(11).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(11).Name = "overallhits"
            FrmGameAccountsSummary.dtgSummary.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmGameAccountsSummary.dtgSummary.Columns(12).HeaderText = "REVENUE"
            FrmGameAccountsSummary.dtgSummary.Columns(12).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(12).Name = "revenue"
            FrmGameAccountsSummary.dtgSummary.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            FrmGameAccountsSummary.dtgSummary.Columns(13).HeaderText = "RIDER"
            FrmGameAccountsSummary.dtgSummary.Columns(13).Width = 70
            FrmGameAccountsSummary.dtgSummary.Columns(13).Name = "rider"
            FrmGameAccountsSummary.dtgSummary.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            FrmGameAccountsSummary.dtgSummary.Rows.Clear()
            mydataTable.Rows.Clear()
            mydataset.Clear()
            qryStatement = ""



            If lfind Then
                qryStatement = "select * from [stl_cashier_db].[dbo].[tb_SalesSummaryImported] where CLUSTER like '%" & FrmGameAccountsSummary.txtSearch.Text & "%' or  MUNICIPALITY like '%" & FrmGameAccountsSummary.txtSearch.Text & "%' or  RIDER like '%" & FrmGameAccountsSummary.txtSearch.Text & "%'  or  COORDINATOR like '%" & FrmGameAccountsSummary.txtSearch.Text & "%'  or  AGENT like '%" & FrmGameAccountsSummary.txtSearch.Text & "%'  or  USERNAME like '%" & FrmGameAccountsSummary.txtSearch.Text & "%'   order by Coordinator ASC"

            Else
                qryStatement = "select salesdate,cluster,municipality,rider,coordinator,agent,comm,username,overallgross,overallcomm,overallnet,overallhits,revenue from tb_SalesSummaryImported "

            End If
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

                    recCounter += 1

                    Dim row As String() = New String() {recCounter & ".", Format(CDate(lrow("salesdate")), "MM/dd/yyyy").ToString, lrow("cluster").ToString, lrow("municipality").ToString, lrow("coordinator").ToString, lrow("agent").ToString, lrow("comm").ToString, lrow("username").ToString, Format(CDbl(lrow("overallgross").ToString), "###,###,###.#0"), Format(CDbl(lrow("overallcomm").ToString), "###,###,###.#0"), Format(CDbl(lrow("overallnet").ToString), "###,###,###.#0"), Format(CDbl(lrow("overallhits").ToString), "###,###,###.#0"), Format(CDbl(lrow("revenue").ToString), "###,###,###.#0"), lrow("rider").ToString}
                    FrmGameAccountsSummary.dtgSummary.Rows.Add(row)
                Next
            End If



        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try
    End Sub


End Class
