﻿Public Class FrmReceiversEntry
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmReceiversForm.ShowDialog()
    End Sub
End Class