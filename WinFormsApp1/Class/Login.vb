Imports MySql.Data.MySqlClient
Public Class Login
    Sub VerifyUser()

        Try
            If FrmMain.txtPassword.Text = "" And FrmMain.txtUsername.Text = "" Then
                MessageBox.Show("Please enter username or password", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            openCon()
            Dim READER As MySqlDataReader


            Dim Query As String
            Query = "SELECT * FROM useraccounts WHERE UserName='" & FrmMain.txtUsername.Text & "' AND  UserPassword ='" & FrmMain.txtPassword.Text & "'"
            cmd = New MySqlCommand(Query, con)
            READER = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Access successfully Granted", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                FrmMain.txtUsername.Clear()
                FrmMain.txtPassword.Clear()
                FrmMain.PanelLogin.Visible = False
                FrmMain.panelMenu.Visible = True
                '   FrmMain.panelTop.Visible = True
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Access denied! Invalid username or password", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                FrmMain.txtPassword.Focus()

            End If

            con.Close()


        Catch ex As Exception

        End Try



    End Sub
End Class
