<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.panelMenu = New System.Windows.Forms.MenuStrip()
        Me.TEXT1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfReceiversFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateReceiversFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrossSalesReportSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLLECTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameAccountsSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RIDERSREMITTANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RidersShortOverRemittancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceivableLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfficeShareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnpaidBalanceRemittancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaidRemittancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClaimedAndUnclaimHitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMPORTSALESREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.Transparent
        Me.panelMenu.Enabled = False
        Me.panelMenu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.panelMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.panelMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TEXT1ToolStripMenuItem, Me.COLLECTIONToolStripMenuItem, Me.RIDERSREMITTANCEToolStripMenuItem, Me.IMPORTSALESREPORTToolStripMenuItem, Me.VIEWUNPAIDREMITTANCEToolStripMenuItem})
        Me.panelMenu.Location = New System.Drawing.Point(0, 31)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(1253, 58)
        Me.panelMenu.Stretch = False
        Me.panelMenu.TabIndex = 0
        Me.panelMenu.Text = "MenuStrip1"
        '
        'TEXT1ToolStripMenuItem
        '
        Me.TEXT1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfReceiversFormToolStripMenuItem, Me.GenerateReceiversFormToolStripMenuItem, Me.GrossSalesReportSummaryToolStripMenuItem})
        Me.TEXT1ToolStripMenuItem.Image = CType(resources.GetObject("TEXT1ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TEXT1ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TEXT1ToolStripMenuItem.Name = "TEXT1ToolStripMenuItem"
        Me.TEXT1ToolStripMenuItem.Size = New System.Drawing.Size(151, 54)
        Me.TEXT1ToolStripMenuItem.Text = "COLLECTION"
        Me.TEXT1ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListOfReceiversFormToolStripMenuItem
        '
        Me.ListOfReceiversFormToolStripMenuItem.Name = "ListOfReceiversFormToolStripMenuItem"
        Me.ListOfReceiversFormToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ListOfReceiversFormToolStripMenuItem.Text = "Receivers Entry"
        '
        'GenerateReceiversFormToolStripMenuItem
        '
        Me.GenerateReceiversFormToolStripMenuItem.Name = "GenerateReceiversFormToolStripMenuItem"
        Me.GenerateReceiversFormToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.GenerateReceiversFormToolStripMenuItem.Text = "Generate Receivers Form"
        '
        'GrossSalesReportSummaryToolStripMenuItem
        '
        Me.GrossSalesReportSummaryToolStripMenuItem.Name = "GrossSalesReportSummaryToolStripMenuItem"
        Me.GrossSalesReportSummaryToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.GrossSalesReportSummaryToolStripMenuItem.Text = "Gross Sales Summary"
        '
        'COLLECTIONToolStripMenuItem
        '
        Me.COLLECTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameAccountsSummaryToolStripMenuItem})
        Me.COLLECTIONToolStripMenuItem.Image = CType(resources.GetObject("COLLECTIONToolStripMenuItem.Image"), System.Drawing.Image)
        Me.COLLECTIONToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.COLLECTIONToolStripMenuItem.Name = "COLLECTIONToolStripMenuItem"
        Me.COLLECTIONToolStripMenuItem.Size = New System.Drawing.Size(214, 54)
        Me.COLLECTIONToolStripMenuItem.Text = "GROSS SALES SUMMARY"
        '
        'GameAccountsSummaryToolStripMenuItem
        '
        Me.GameAccountsSummaryToolStripMenuItem.Name = "GameAccountsSummaryToolStripMenuItem"
        Me.GameAccountsSummaryToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.GameAccountsSummaryToolStripMenuItem.Text = "Game Accounts Summary"
        '
        'RIDERSREMITTANCEToolStripMenuItem
        '
        Me.RIDERSREMITTANCEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RidersShortOverRemittancesToolStripMenuItem, Me.ReceivableLedgerToolStripMenuItem, Me.OfficeShareToolStripMenuItem, Me.UnpaidBalanceRemittancesToolStripMenuItem, Me.PaidRemittancesToolStripMenuItem, Me.ClaimedAndUnclaimHitsToolStripMenuItem})
        Me.RIDERSREMITTANCEToolStripMenuItem.Image = CType(resources.GetObject("RIDERSREMITTANCEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RIDERSREMITTANCEToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RIDERSREMITTANCEToolStripMenuItem.Name = "RIDERSREMITTANCEToolStripMenuItem"
        Me.RIDERSREMITTANCEToolStripMenuItem.Size = New System.Drawing.Size(123, 54)
        Me.RIDERSREMITTANCEToolStripMenuItem.Text = "REPORTS"
        '
        'RidersShortOverRemittancesToolStripMenuItem
        '
        Me.RidersShortOverRemittancesToolStripMenuItem.Name = "RidersShortOverRemittancesToolStripMenuItem"
        Me.RidersShortOverRemittancesToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.RidersShortOverRemittancesToolStripMenuItem.Text = "Riders Short/Over Remittances"
        '
        'ReceivableLedgerToolStripMenuItem
        '
        Me.ReceivableLedgerToolStripMenuItem.Name = "ReceivableLedgerToolStripMenuItem"
        Me.ReceivableLedgerToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ReceivableLedgerToolStripMenuItem.Text = "Receivable Ledger"
        '
        'OfficeShareToolStripMenuItem
        '
        Me.OfficeShareToolStripMenuItem.Name = "OfficeShareToolStripMenuItem"
        Me.OfficeShareToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.OfficeShareToolStripMenuItem.Text = "Office Share"
        '
        'UnpaidBalanceRemittancesToolStripMenuItem
        '
        Me.UnpaidBalanceRemittancesToolStripMenuItem.Name = "UnpaidBalanceRemittancesToolStripMenuItem"
        Me.UnpaidBalanceRemittancesToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.UnpaidBalanceRemittancesToolStripMenuItem.Text = "Unpaid/Balance Remittances"
        '
        'PaidRemittancesToolStripMenuItem
        '
        Me.PaidRemittancesToolStripMenuItem.Name = "PaidRemittancesToolStripMenuItem"
        Me.PaidRemittancesToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.PaidRemittancesToolStripMenuItem.Text = "Paid Remittances"
        '
        'ClaimedAndUnclaimHitsToolStripMenuItem
        '
        Me.ClaimedAndUnclaimHitsToolStripMenuItem.Name = "ClaimedAndUnclaimHitsToolStripMenuItem"
        Me.ClaimedAndUnclaimHitsToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ClaimedAndUnclaimHitsToolStripMenuItem.Text = "Claimed and Unclaim Hits"
        '
        'IMPORTSALESREPORTToolStripMenuItem
        '
        Me.IMPORTSALESREPORTToolStripMenuItem.Image = CType(resources.GetObject("IMPORTSALESREPORTToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IMPORTSALESREPORTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IMPORTSALESREPORTToolStripMenuItem.Name = "IMPORTSALESREPORTToolStripMenuItem"
        Me.IMPORTSALESREPORTToolStripMenuItem.Size = New System.Drawing.Size(218, 54)
        Me.IMPORTSALESREPORTToolStripMenuItem.Text = "IMPORT SALES SUMMARY"
        '
        'VIEWUNPAIDREMITTANCEToolStripMenuItem
        '
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem.Name = "VIEWUNPAIDREMITTANCEToolStripMenuItem"
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem.Size = New System.Drawing.Size(76, 54)
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem.Text = "LOG-OUT"
        Me.VIEWUNPAIDREMITTANCEToolStripMenuItem.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1253, 31)
        Me.Panel1.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(1217, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(36, 31)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.UseVisualStyleBackColor = True
        Me.btnLogout.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Goldenrod
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SALES COLLECTION SYSTEM"
        '
        'PanelLogin
        '
        Me.PanelLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLogin.Controls.Add(Me.PictureBox1)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.txtPassword)
        Me.PanelLogin.Controls.Add(Me.txtUsername)
        Me.PanelLogin.Controls.Add(Me.Button2)
        Me.PanelLogin.Controls.Add(Me.Button1)
        Me.PanelLogin.Controls.Add(Me.Panel2)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Location = New System.Drawing.Point(415, 248)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(411, 144)
        Me.PanelLogin.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
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
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(205, 72)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(195, 23)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(205, 43)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(195, 23)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(312, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(222, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Login"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.Label4)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 716)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1253, 33)
        Me.PanelBottom.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(865, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(388, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Copyrights 2022 @ 1028 GAMING AND ENTERTAINMENT CORPORATION"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1253, 749)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.panelMenu
        Me.Name = "FrmMain"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMenu As MenuStrip
    Friend WithEvents TEXT1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RIDERSREMITTANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWUNPAIDREMITTANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListOfReceiversFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateReceiversFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RidersShortOverRemittancesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents COLLECTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IMPORTSALESREPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrossSalesReportSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameAccountsSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceivableLedgerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OfficeShareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnpaidBalanceRemittancesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaidRemittancesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClaimedAndUnclaimHitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLogout As Button
End Class
