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

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Public rfnumber As String = ""
    Public rfsalesdate As String = ""
    Public rfridername As String = ""
    Public rfreceivername As String = ""

    Private Sub dtgReceiversFormList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgReceiversFormList.CellClick
        'Dim rowcount As Integer = dtgPaymentSchedule.Rows.Count
        'If e.RowIndex = rowcount - 1 Then
        '    Dim GridRow As DataGridViewRow = dtgPaymentSchedule.CurrentRow
        '    For Each datagrd As DataGridViewRow In dtgPaymentSchedule.SelectedRows
        '        lblSchedID.Text = CStr(GridRow.Cells.Item("id").Value)
        '    Next datagrd
        'Else
        '    lblSchedID.Text = "SCHED ID"
        'End If

        If e.ColumnIndex = 8 Then

            Dim GridRow As DataGridViewRow = dtgReceiversFormList.CurrentRow
            For Each datagrd As DataGridViewRow In dtgReceiversFormList.SelectedRows
                rfnumber = CStr(GridRow.Cells.Item("formnum").Value)
                rfsalesdate = CStr(GridRow.Cells.Item("salesdate").Value)
                rfridername = CStr(GridRow.Cells.Item("rider").Value)
                rfreceivername = CStr(GridRow.Cells.Item("receiver").Value)
            Next datagrd


            FrmReceiversForm.ShowDialog()

        End If
    End Sub

    Private Sub dtgReceiversFormList_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtgReceiversFormList.CellEnter
        If dtgReceiversFormList.Rows.Count > 0 Then
            lblrec.Text = "RECORD COUNT: " & (dtgReceiversFormList.CurrentRow.Index) + 1 & " of " & dtgReceiversFormList.Rows.Count
        End If
    End Sub
End Class