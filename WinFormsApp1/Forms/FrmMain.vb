Public Class FrmMain
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TEXT1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TEXT1ToolStripMenuItem.Click

    End Sub

    Private Sub VIEWUNPAIDREMITTANCEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWUNPAIDREMITTANCEToolStripMenuItem.Click
        closeme()
    End Sub

    Private Sub COLLECTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLLECTIONToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        mylogin.VerifyUser()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        MsgBox("Connected!")
        con.Close()
        panelMenu.Visible = False
        ' panelTop.Visible = False
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
End Class
