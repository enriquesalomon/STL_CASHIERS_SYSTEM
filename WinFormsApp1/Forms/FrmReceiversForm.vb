Public Class FrmReceiversForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dtgRidersCollection.Rows.Clear()
        Me.Close()
    End Sub

    Private Sub btnLoadRidersSummary_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmReceiversForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myriders.LoadRidersCollectionRecord()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        PanelInputRemittance.Visible = False
    End Sub

    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        BackForeColorMe(txtSearch, True)
        lfind = True
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If lfind Then
            myriders.LoadRidersCollectionRecord()
        End If
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        BackForeColorMe(txtSearch, False)
        lfind = False
    End Sub

    Private Sub dtgRidersCollection_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRidersCollection.CellDoubleClick
        PanelInputRemittance.Visible = True
        myreceiver.LoadCoorSalesRecord()

    End Sub
End Class