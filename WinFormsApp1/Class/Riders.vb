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

End Class
