Public Class FrmTicketEntry
    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub panelBottom_Paint(sender As Object, e As PaintEventArgs) Handles panelBottom.Paint

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panelentry.Visible = True
    End Sub

    Private Sub FrmTicketEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panelentry.Location = New Point((Me.Width - Panelentry.Width) \ 2, (Me.Height - Panelentry.Height) \ 2)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Panelentry.Visible = False
    End Sub

    Private Sub btnSaveOndate_Click(sender As Object, e As EventArgs) Handles btnSaveOndate.Click
        Panelentry.Visible = False
    End Sub
End Class