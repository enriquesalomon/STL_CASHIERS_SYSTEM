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
        'PanelInputRemittance.Location = New Point((Me.Width - PanelInputRemittance.Width) \ 2, (Me.Height - PanelInputRemittance.Height) \ 2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs)

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

        Dim GridRow As DataGridViewRow = dtgRidersCollection.CurrentRow
        Dim num As String = ""
        Dim username As String = ""
        Dim coordinator As String = ""
        For Each datagrd As DataGridViewRow In dtgRidersCollection.SelectedRows
            num = CStr(GridRow.Cells.Item("num").Value)
            username = CStr(GridRow.Cells.Item("username").Value)
            coordinator = CStr(GridRow.Cells.Item("coordinator").Value)
        Next datagrd

        If num = "==========" Or num = "" Then
            Exit Sub
        End If

        If username = "==========" Or username = "" Then
            Exit Sub
        End If
        If coordinator = "==========" Or coordinator = " TOTAL:" Then
            Exit Sub
        End If

        PanelInputRemittance.Visible = True
        myreceiver.LoadCoorSalesRecord()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        PanelInputRemittance.Visible = False
        txtAgentCode.Clear()
        txtCoor.Clear()
        txtNetOndate.Clear()
    End Sub

    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point

    Private Sub PanelInputRemittance_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelInputRemittance.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PanelInputRemittance_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelInputRemittance.MouseMove
        If allowCoolMove = True Then
            PanelInputRemittance.Location = New Point(PanelInputRemittance.Location.X + e.X - myCoolPoint.X, PanelInputRemittance.Location.Y + e.Y - myCoolPoint.Y)
        End If
    End Sub

    Private Sub PanelInputRemittance_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelInputRemittance.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub
End Class