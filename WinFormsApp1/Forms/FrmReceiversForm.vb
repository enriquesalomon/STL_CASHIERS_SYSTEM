﻿Public Class FrmReceiversForm
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'dtgRidersCollection.Rows.Clear()
        'clearTxt("frmreceiversform_inputremittancePanel")
        'Me.Close()
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

    Public searchagentcode As Boolean
    Public searchcoor As Boolean
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If lfind Then
            If cmbSearch.Text <> Nothing Then
                If cmbSearch.Text = "AGENT CODE" Then
                    searchagentcode = True
                    searchcoor = False
                Else
                    searchagentcode = False
                    searchcoor = True
                End If
                myriders.LoadRidersCollectionRecord()
            End If

        End If
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        BackForeColorMe(txtSearch, False)
        lfind = False
    End Sub

    Private Sub dtgRidersCollection_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRidersCollection.CellDoubleClick
        clearTxt("frmreceiversform_inputremittancePanel")
        Dim GridRow As DataGridViewRow = dtgRidersCollection.CurrentRow
        Dim num As String = ""
        Dim username As String = ""
        Dim coordinator As String = ""
        Dim ondatehits As Double = 0
        For Each datagrd As DataGridViewRow In dtgRidersCollection.SelectedRows
            num = CStr(GridRow.Cells.Item("num").Value)
            username = CStr(GridRow.Cells.Item("username").Value)
            coordinator = CStr(GridRow.Cells.Item("coordinator").Value)
            ondatehits = CStr(GridRow.Cells.Item("ondatehits").Value)
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

        globalAgentCode = username
        mytickets.getClaimedHits()
        PanelInputRemittance.Visible = True
        myreceiver.LoadCoorSalesRecord()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

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

    Private Sub txtClaimed_OndateHits_GotFocus(sender As Object, e As EventArgs) Handles txtNetRemittance.GotFocus
        BackForeColorMeDigitTextbox(txtNetRemittance, True)

    End Sub

    Private Sub txtClaimed_OndateHits_LostFocus(sender As Object, e As EventArgs) Handles txtNetRemittance.LostFocus
        BackForeColorMeDigitTextbox(txtNetRemittance, False)
    End Sub

    Private Sub btnPostRemittance_Click(sender As Object, e As EventArgs) Handles btnPostRemittance.Click
        'If txtNetRemittance.Text = "" Then

        '    Exit Sub
        'Else
        '    btnManagePrevtickets.Enabled = True
        '    btnManageUnremitted.Enabled = True
        'End If
    End Sub

    Private Sub PanelInputRemittance_LostFocus(sender As Object, e As EventArgs) Handles PanelInputRemittance.LostFocus

    End Sub

    Private Sub PanelInputRemittance_MouseLeave(sender As Object, e As EventArgs) Handles PanelInputRemittance.MouseLeave

    End Sub

    Private Sub dtgRidersCollection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRidersCollection.CellClick
        'btnManagePrevtickets.Enabled = False
        'btnManageUnremitted.Enabled = False
    End Sub

    Private Sub dtgRidersCollection_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRidersCollection.CellEnter
        'btnManagePrevtickets.Enabled = False
        'btnManageUnremitted.Enabled = False
    End Sub

    Private Sub txtClaimed_OndateHits_TextChanged(sender As Object, e As EventArgs) Handles txtNetRemittance.TextChanged

    End Sub

    Private Sub txtClaimed_OndateHits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNetRemittance.KeyPress
        Try
            If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
                MsgBox("Input Only Number Value", MsgBoxStyle.Information)
                e.Handled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnManagePrevtickets_Click(sender As Object, e As EventArgs) Handles btnManagePrevtickets.Click
        FrmTicketEntry.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        cmbSearch.Text = Nothing
        txtSearch.Clear()
        myriders.LoadRidersCollectionRecord()
    End Sub

    Private Sub FrmReceiversForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dtgRidersCollection.Rows.Clear()
        clearTxt("frmreceiversform_inputremittancePanel")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        PanelInputRemittance.Visible = False
        'txtAgentCode.Clear()
        'txtCoor.Clear()
        'txtNetOndate.Clear()
        clearTxt("frmreceiversform_inputremittancePanel")
    End Sub
End Class