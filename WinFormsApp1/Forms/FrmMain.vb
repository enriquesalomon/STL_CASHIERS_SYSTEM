Public Class FrmMain
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TEXT1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TEXT1ToolStripMenuItem.Click

    End Sub

    Private Sub VIEWUNPAIDREMITTANCEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWUNPAIDREMITTANCEToolStripMenuItem.Click
        PanelLogin.Visible = True
        panelMenu.Enabled = False
    End Sub

    Private Sub COLLECTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLLECTIONToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        '    Dim currentDate As String = "03/03/2019"
        '    'Dim convertedDate As DateTime = Convert.ToDateTime(currentDate, "dd-MM-yyyy")
        '    Dim convertedDate As DateTime = Format(CDate(currentDate), "yyyy-MM-dd").ToString()
        '    MessageBox.Show(convertedDate)
        '    'MessageBox.Show("Day: " & convertedDate.Day & " Month: " & convertedDate.Month & " Year: " & convertedDate.Year)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        mylogin.VerifyUser()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'openCon()
        'MsgBox("Connected!")
        'con.Close()
        'panelMenu.Visible = False
        ' panelTop.Visible = False

        Me.KeyPreview = True
        PanelLogin.Location = New Point((Me.Width - PanelLogin.Width) \ 2, (Me.Height - PanelLogin.Height) \ 2)
    End Sub

    Private Sub closeme()
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to close this application?",
                          vbYesNo + vbExclamation + vbApplicationModal +
                          vbDefaultButton2, "Close confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Visible = False
            Me.Dispose()
            Me.Close()
            End
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        closeme()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        BackForeColorMe(txtUsername, True)
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        BackForeColorMe(txtPassword, True)
    End Sub

    Private Sub IMPORTSALESREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IMPORTSALESREPORTToolStripMenuItem.Click
        FrmImportExcelSales.ShowDialog()
    End Sub

    Private Sub GameAccountsSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameAccountsSummaryToolStripMenuItem.Click
        FrmGameAccountsSummary.ShowDialog()
    End Sub

    Private Sub ListOfReceiversFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfReceiversFormToolStripMenuItem.Click
        FrmReceiversEntry.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        PanelLogin.Visible = True
        panelMenu.Enabled = False
        btnLogout.Visible = False
    End Sub
End Class
