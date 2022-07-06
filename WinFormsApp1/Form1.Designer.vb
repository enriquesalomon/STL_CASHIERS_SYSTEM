<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TEXT1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TEXT2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UNPAIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REMITTANCEWITHBALANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RIDERSREMITTANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TEXT1ToolStripMenuItem, Me.TEXT2ToolStripMenuItem, Me.RIDERSREMITTANCEToolStripMenuItem, Me.VIEWUNPAIDREMITTANCEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 31)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1253, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TEXT1ToolStripMenuItem
        '
        Me.TEXT1ToolStripMenuItem.Name = "TEXT1ToolStripMenuItem"
        Me.TEXT1ToolStripMenuItem.Size = New System.Drawing.Size(194, 21)
        Me.TEXT1ToolStripMenuItem.Text = "GENERATE RECEIVERS FORM"
        '
        'TEXT2ToolStripMenuItem
        '
        Me.TEXT2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAIDToolStripMenuItem, Me.UNPAIDToolStripMenuItem, Me.REMITTANCEWITHBALANCEToolStripMenuItem})
        Me.TEXT2ToolStripMenuItem.Name = "TEXT2ToolStripMenuItem"
        Me.TEXT2ToolStripMenuItem.Size = New System.Drawing.Size(96, 21)
        Me.TEXT2ToolStripMenuItem.Text = "REMITTANCE"
        '
        'PAIDToolStripMenuItem
        '
        Me.PAIDToolStripMenuItem.Name = "PAIDToolStripMenuItem"
        Me.PAIDToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.PAIDToolStripMenuItem.Text = "PAID"
        '
        'UNPAIDToolStripMenuItem
        '
        Me.UNPAIDToolStripMenuItem.Name = "UNPAIDToolStripMenuItem"
        Me.UNPAIDToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.UNPAIDToolStripMenuItem.Text = "UNPAID"
        '
        'REMITTANCEWITHBALANCEToolStripMenuItem
        '
        Me.REMITTANCEWITHBALANCEToolStripMenuItem.Name = "REMITTANCEWITHBALANCEToolStripMenuItem"
        Me.REMITTANCEWITHBALANCEToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.REMITTANCEWITHBALANCEToolStripMenuItem.Text = "REMITTANCE WITH BALANCE"
        '
        'RIDERSREMITTANCEToolStripMenuItem
        '
        Me.RIDERSREMITTANCEToolStripMenuItem.Name = "RIDERSREMITTANCEToolStripMenuItem"
        Me.RIDERSREMITTANCEToolStripMenuItem.Size = New System.Drawing.Size(142, 21)
        Me.RIDERSREMITTANCEToolStripMenuItem.Text = "RIDERS REMITTANCE"
        '
        'VIEWUNPAIDREMITTANCEToolStripMenuItem
        '
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem.Name = "VIEWUNPAIDREMITTANCEToolStripMenuItem"
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem.Size = New System.Drawing.Size(76, 21)
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem.Text = "LOG-OUT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1253, 31)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.Location = New System.Drawing.Point(1178, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 31)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PanelLogin
        '
        Me.PanelLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.TextBox2)
        Me.PanelLogin.Controls.Add(Me.TextBox1)
        Me.PanelLogin.Controls.Add(Me.Button2)
        Me.PanelLogin.Controls.Add(Me.Button1)
        Me.PanelLogin.Controls.Add(Me.Panel2)
        Me.PanelLogin.Location = New System.Drawing.Point(374, 198)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(411, 139)
        Me.PanelLogin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Goldenrod
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(109, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password   :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Goldenrod
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(205, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 23)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(205, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(312, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(218, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(409, 27)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Goldenrod
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LOGIN ACCOUNT"
        '
        'PanelBottom
        '
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 716)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1253, 33)
        Me.PanelBottom.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1253, 749)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TEXT1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TEXT2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PAIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UNPAIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REMITTANCEWITHBALANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RIDERSREMITTANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWUNPAIDREMITTANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
