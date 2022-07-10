Public Class FrmReceiversForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnLoadRidersSummary_Click(sender As Object, e As EventArgs) Handles btnLoadRidersSummary.Click
        PanelRider.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelRider.Visible = False
    End Sub

    Private Sub FrmReceiversForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myriders.loadridersList()
    End Sub
End Class