Public Class FrmReceiversEntry
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmRidersDailySummary.ShowDialog()
    End Sub

    Private Sub FrmReceiversEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        myreceiver.LoadRFList()
    End Sub
End Class