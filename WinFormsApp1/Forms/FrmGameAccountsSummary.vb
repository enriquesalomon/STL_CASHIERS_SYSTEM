Public Class FrmGameAccountsSummary
    Private Sub FrmGameAccountsSummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        mysalessummary.LoadRecord()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Me.Close()
    End Sub

    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        BackForeColorMe(txtSearch, True)
        lfind = True
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        BackForeColorMe(txtSearch, False)
        lfind = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If lfind Then
            mysalessummary.LoadRecord()
        End If
    End Sub

    Private Sub dtgSummary_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtgSummary.CellEnter
        If dtgSummary.Rows.Count > 0 Then
            lblrec.Text = "RECORD COUNT: " & (dtgSummary.CurrentRow.Index) + 1 & " of " & dtgSummary.Rows.Count
        End If
    End Sub
End Class