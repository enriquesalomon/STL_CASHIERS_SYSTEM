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
        dtpDrawDate.CustomFormat = "MM/dd/yyyy"
        lblagentcode.Text = FrmReceiversForm.txtAgentCode.Text
        mytickets.LoadRecord()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Panelentry.Visible = False
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

        Else
            'saving
            mytickets.Save()
        End If



    End Sub
    Dim dateValueinDrawdate As Date
    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTicketType.SelectedIndexChanged
        If cmbTicketType.Text = "ONDATE" Then
            Dim dateString As String = FrmReceiversForm.txtDateofSales.Text
            Dim dateFormat As String = "MM/dd/yyyy"

            dateValueinDrawdate = DateTime.ParseExact(dateString, dateFormat, Globalization.CultureInfo.InvariantCulture)
            dtpDrawDate.Value = dateValueinDrawdate
            dtpDrawDate.Enabled = False
        ElseIf cmbTicketType.Text = "PREVIOUS" Then
            dtpDrawDate.Enabled = True


        Else

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
End Class