Public Class FrmGameAccountsSummary
    Private Sub FrmGameAccountsSummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        mysalessummary.LoadRecord()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class