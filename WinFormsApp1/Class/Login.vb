Imports System.Net.Sockets
Imports System.Text
Imports System.Data.SqlClient
Public Class Login
    Sub VerifyUser()
        Try

            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "SELECT * FROM tbl_UserAccount where  Username='" & Trim(FrmMain.txtUsername.Text) & "' and  UserPassword='" & Trim(FrmMain.txtPassword.Text) & "'"
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydataset, "tbl_UserAccount")
            mydataTable = mydataset.Tables("tbl_UserAccount")
            mysqlreader = mycommand.ExecuteReader
            If mydataTable.Rows.Count > 0 Then
                tempName = ""
                While mysqlreader.Read()
                    username = mysqlreader("Username").ToString
                    password = mysqlreader("UserPassword").ToString
                    'tempName = (mysqlreader("Fullname")).ToString & Space(1) & Mid((mysqlreader("Mname")), 1, 1).ToString & "." & Space(1) & (mysqlreader("Lname")).ToString & "  "
                    cashier = (mysqlreader("Fullname")).ToString
                End While
            Else
                password = password
            End If
            If FrmMain.txtPassword.Text = "" And FrmMain.txtUsername.Text = "" Then
                MessageBox.Show("Please enter username or password", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Trim(password) = Trim(FrmMain.txtPassword.Text) And FrmMain.txtUsername.Text = Trim(username) Then
                MessageBox.Show("Access successfully Granted", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                FrmMain.txtPassword.Text = ""
                FrmMain.txtUsername.Text = ""
                FrmMain.Enabled = True
                FrmMain.PanelLogin.Visible = False
                FrmMain.panelMenu.Enabled = True
            Else
                MessageBox.Show("Access denied Invalid username or password", "Validation Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                FrmMain.txtPassword.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, " Error !!")
        End Try


    End Sub
End Class
