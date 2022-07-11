Public Class FrmRidersDailySummary
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dtgRidersCollection.Rows.Clear()
        Me.Close()
    End Sub

    Sub loadridersList()
        cboRiders.Items.Clear()

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
                cboRiders.Items.Add(mysqlreader("Rider").ToString)
            End While
        Else
        End If
        mysqlreader.Close()
        mysqlconn.Close()
    End Sub

    Private Sub FrmRidersDailySummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadridersList()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myriders.LoadRidersDailySummary()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cboRiders.Text = "" Then
            Exit Sub
        End If
    End Sub
End Class