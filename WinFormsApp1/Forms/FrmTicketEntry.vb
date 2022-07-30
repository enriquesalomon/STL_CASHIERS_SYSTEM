Public Class FrmTicketEntry
    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub panelBottom_Paint(sender As Object, e As PaintEventArgs) Handles panelBottom.Paint

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        mytickets.Delete()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panelentry.Visible = True
    End Sub

    Private Sub FrmTicketEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panelentry.Location = New Point((Me.Width - Panelentry.Width) \ 2, (Me.Height - Panelentry.Height) \ 2)
        dtpDrawDate.CustomFormat = "MM/dd/yyyy"
        lblagentcode.Text = FrmReceiversForm.txtAgentCode.Text
        mytickets.LoadRecord()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)


    End Sub


    Dim dateValueinDrawdate As Date
    Dim dateFormat As String = "MM/dd/yyyy"
    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTicketType.SelectedIndexChanged
        If cmbTicketType.Text = "ONDATE" Then
            Dim dateString As String = FrmReceiversForm.txtDateofSales.Text
            dateValueinDrawdate = DateTime.ParseExact(dateString, dateFormat, Globalization.CultureInfo.InvariantCulture)
            dtpDrawDate.Value = dateValueinDrawdate
            dtpDrawDate.Enabled = False
        ElseIf cmbTicketType.Text = "PREVIOUS" Then
            Dim dateString As String = FrmReceiversForm.txtDateofSales.Text
            dateValueinDrawdate = DateTime.ParseExact(dateString, dateFormat, Globalization.CultureInfo.InvariantCulture)
            dtpDrawDate.Enabled = True
        Else
        End If
    End Sub
    Private Sub btnSaveOndate_Click(sender As Object, e As EventArgs) Handles btnSaveOndate.Click
        If cmbTicketType.Text = Nothing Then
            MessageBox.Show("Please Select Ticket Type", "Ticket Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtWinningAmount.Text = "" Then
            Exit Sub
        End If
        'validate draw date inputted is previous
        If cmbTicketType.Text = "PREVIOUS" Then
            If dateValueinDrawdate = dtpDrawDate.Value Then
                MessageBox.Show("Ticket is not a Previous", "Ticket Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If dateValueinDrawdate < dtpDrawDate.Value Then
                MessageBox.Show("Ticket is not a Previous", "Ticket Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If dateValueinDrawdate > dtpDrawDate.Value Then
                'saving
                mytickets.Save()
            End If
            If dateValueinDrawdate < dtpDrawDate.Value Then
                'saving
                mytickets.Save()
            End If

        ElseIf cmbTicketType.Text = "ONDATE" Then
            'saving
            If CDbl(FrmReceiversForm.txtHitsOndate.Text) = 0 Then
                MessageBox.Show("No record found of ondate hits", "Ticket Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            mytickets.Save()
        End If



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtWinningAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWinningAmount.KeyPress
        Try
            If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
                MsgBox("Input Only Number Value", MsgBoxStyle.Information)
                e.Handled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmTicketEntry_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Panelentry.Visible = False
        cmbTicketType.Text = Nothing
        txtWinningAmount.Clear()
        txtSearch.Clear()

    End Sub

    Private Sub txtWinningAmount_GotFocus(sender As Object, e As EventArgs) Handles txtWinningAmount.GotFocus
        BackForeColorMe(txtWinningAmount, True)
    End Sub

    Private Sub txtWinningAmount_LostFocus(sender As Object, e As EventArgs) Handles txtWinningAmount.LostFocus
        BackForeColorMe(txtWinningAmount, False)
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
            mytickets.LoadRecord()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panelentry.Visible = False
        cmbTicketType.Text = Nothing
        txtWinningAmount.Clear()
    End Sub
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point
    Private Sub Panelentry_MouseDown(sender As Object, e As MouseEventArgs) Handles Panelentry.MouseDown
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub
    Private Sub Panelentry_MouseMove(sender As Object, e As MouseEventArgs) Handles Panelentry.MouseMove
        If allowCoolMove = True Then
            Panelentry.Location = New Point(Panelentry.Location.X + e.X - myCoolPoint.X, Panelentry.Location.Y + e.Y - myCoolPoint.Y)
        End If
    End Sub

    Private Sub Panelentry_MouseUp(sender As Object, e As MouseEventArgs) Handles Panelentry.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub


End Class