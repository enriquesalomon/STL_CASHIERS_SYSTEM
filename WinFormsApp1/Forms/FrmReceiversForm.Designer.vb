﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReceiversForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceiversForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtrfNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCollector = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDateofSales = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaneldtgRemittances = New System.Windows.Forms.Panel()
        Me.dtgRidersCollection = New System.Windows.Forms.DataGridView()
        Me.PanelInputRemittance = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalHitsClaimed = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNetRemittance = New System.Windows.Forms.TextBox()
        Me.btnPostRemittance = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnManageUnremitted = New System.Windows.Forms.Button()
        Me.btnManagePrevtickets = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPreviousHitsClaimed = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOndateHitsClaimed = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtHitsOndate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAgentCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNetOndate = New System.Windows.Forms.TextBox()
        Me.txtCoor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.PaneldtgRemittances.SuspendLayout()
        CType(Me.dtgRidersCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInputRemittance.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtrfNum)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtCollector)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtDateofSales)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(685, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 749)
        Me.Panel2.TabIndex = 5
        '
        'txtrfNum
        '
        Me.txtrfNum.BackColor = System.Drawing.Color.White
        Me.txtrfNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtrfNum.Location = New System.Drawing.Point(97, 46)
        Me.txtrfNum.Name = "txtrfNum"
        Me.txtrfNum.ReadOnly = True
        Me.txtrfNum.Size = New System.Drawing.Size(191, 23)
        Me.txtrfNum.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "RF #:"
        '
        'txtCollector
        '
        Me.txtCollector.BackColor = System.Drawing.Color.White
        Me.txtCollector.Location = New System.Drawing.Point(97, 98)
        Me.txtCollector.Name = "txtCollector"
        Me.txtCollector.ReadOnly = True
        Me.txtCollector.Size = New System.Drawing.Size(191, 23)
        Me.txtCollector.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Collector:"
        '
        'txtDateofSales
        '
        Me.txtDateofSales.BackColor = System.Drawing.Color.White
        Me.txtDateofSales.Location = New System.Drawing.Point(97, 72)
        Me.txtDateofSales.Name = "txtDateofSales"
        Me.txtDateofSales.ReadOnly = True
        Me.txtDateofSales.Size = New System.Drawing.Size(191, 23)
        Me.txtDateofSales.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Date of Sales: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(97, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "REMMITANCE DETAILS"
        '
        'PaneldtgRemittances
        '
        Me.PaneldtgRemittances.Controls.Add(Me.dtgRidersCollection)
        Me.PaneldtgRemittances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaneldtgRemittances.Location = New System.Drawing.Point(0, 55)
        Me.PaneldtgRemittances.Name = "PaneldtgRemittances"
        Me.PaneldtgRemittances.Size = New System.Drawing.Size(685, 694)
        Me.PaneldtgRemittances.TabIndex = 6
        '
        'dtgRidersCollection
        '
        Me.dtgRidersCollection.AllowUserToAddRows = False
        Me.dtgRidersCollection.AllowUserToDeleteRows = False
        Me.dtgRidersCollection.AllowUserToResizeColumns = False
        Me.dtgRidersCollection.AllowUserToResizeRows = False
        Me.dtgRidersCollection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgRidersCollection.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgRidersCollection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgRidersCollection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgRidersCollection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgRidersCollection.ColumnHeadersHeight = 35
        Me.dtgRidersCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgRidersCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgRidersCollection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgRidersCollection.EnableHeadersVisualStyles = False
        Me.dtgRidersCollection.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgRidersCollection.Location = New System.Drawing.Point(0, 0)
        Me.dtgRidersCollection.MultiSelect = False
        Me.dtgRidersCollection.Name = "dtgRidersCollection"
        Me.dtgRidersCollection.ReadOnly = True
        Me.dtgRidersCollection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgRidersCollection.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgRidersCollection.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        Me.dtgRidersCollection.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgRidersCollection.RowTemplate.Height = 25
        Me.dtgRidersCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgRidersCollection.Size = New System.Drawing.Size(685, 694)
        Me.dtgRidersCollection.TabIndex = 3
        '
        'PanelInputRemittance
        '
        Me.PanelInputRemittance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInputRemittance.Controls.Add(Me.Panel6)
        Me.PanelInputRemittance.Controls.Add(Me.Panel5)
        Me.PanelInputRemittance.Controls.Add(Me.Label15)
        Me.PanelInputRemittance.Controls.Add(Me.txtTotalHitsClaimed)
        Me.PanelInputRemittance.Controls.Add(Me.Label12)
        Me.PanelInputRemittance.Controls.Add(Me.txtNetRemittance)
        Me.PanelInputRemittance.Controls.Add(Me.btnPostRemittance)
        Me.PanelInputRemittance.Controls.Add(Me.Panel3)
        Me.PanelInputRemittance.Controls.Add(Me.btnManageUnremitted)
        Me.PanelInputRemittance.Controls.Add(Me.btnManagePrevtickets)
        Me.PanelInputRemittance.Controls.Add(Me.Label16)
        Me.PanelInputRemittance.Controls.Add(Me.txtPreviousHitsClaimed)
        Me.PanelInputRemittance.Controls.Add(Me.Label14)
        Me.PanelInputRemittance.Controls.Add(Me.txtOndateHitsClaimed)
        Me.PanelInputRemittance.Controls.Add(Me.Label13)
        Me.PanelInputRemittance.Controls.Add(Me.txtHitsOndate)
        Me.PanelInputRemittance.Controls.Add(Me.Label10)
        Me.PanelInputRemittance.Controls.Add(Me.txtAgentCode)
        Me.PanelInputRemittance.Controls.Add(Me.Label4)
        Me.PanelInputRemittance.Controls.Add(Me.txtNetOndate)
        Me.PanelInputRemittance.Controls.Add(Me.txtCoor)
        Me.PanelInputRemittance.Controls.Add(Me.Label8)
        Me.PanelInputRemittance.Controls.Add(Me.Panel4)
        Me.PanelInputRemittance.Location = New System.Drawing.Point(169, 79)
        Me.PanelInputRemittance.Name = "PanelInputRemittance"
        Me.PanelInputRemittance.Size = New System.Drawing.Size(551, 419)
        Me.PanelInputRemittance.TabIndex = 14
        Me.PanelInputRemittance.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(19, 178)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(509, 2)
        Me.Panel6.TabIndex = 52
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(159, 240)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(117, 2)
        Me.Panel5.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 15)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "TOTAL CLAIMED HITS:"
        '
        'txtTotalHitsClaimed
        '
        Me.txtTotalHitsClaimed.BackColor = System.Drawing.Color.White
        Me.txtTotalHitsClaimed.Location = New System.Drawing.Point(160, 246)
        Me.txtTotalHitsClaimed.Name = "txtTotalHitsClaimed"
        Me.txtTotalHitsClaimed.ReadOnly = True
        Me.txtTotalHitsClaimed.Size = New System.Drawing.Size(116, 23)
        Me.txtTotalHitsClaimed.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 15)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "NET AMOUNT REMITTED:"
        '
        'txtNetRemittance
        '
        Me.txtNetRemittance.BackColor = System.Drawing.Color.White
        Me.txtNetRemittance.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNetRemittance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNetRemittance.Location = New System.Drawing.Point(23, 363)
        Me.txtNetRemittance.Name = "txtNetRemittance"
        Me.txtNetRemittance.Size = New System.Drawing.Size(242, 43)
        Me.txtNetRemittance.TabIndex = 47
        Me.txtNetRemittance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPostRemittance
        '
        Me.btnPostRemittance.Location = New System.Drawing.Point(271, 342)
        Me.btnPostRemittance.Name = "btnPostRemittance"
        Me.btnPostRemittance.Size = New System.Drawing.Size(255, 64)
        Me.btnPostRemittance.TabIndex = 46
        Me.btnPostRemittance.Text = "Post Remittance"
        Me.btnPostRemittance.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Location = New System.Drawing.Point(10, 325)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(529, 5)
        Me.Panel3.TabIndex = 45
        '
        'btnManageUnremitted
        '
        Me.btnManageUnremitted.Location = New System.Drawing.Point(298, 279)
        Me.btnManageUnremitted.Name = "btnManageUnremitted"
        Me.btnManageUnremitted.Size = New System.Drawing.Size(217, 34)
        Me.btnManageUnremitted.TabIndex = 44
        Me.btnManageUnremitted.Text = "Manage Unremitted Net"
        Me.btnManageUnremitted.UseVisualStyleBackColor = True
        '
        'btnManagePrevtickets
        '
        Me.btnManagePrevtickets.Location = New System.Drawing.Point(298, 239)
        Me.btnManagePrevtickets.Name = "btnManagePrevtickets"
        Me.btnManagePrevtickets.Size = New System.Drawing.Size(217, 34)
        Me.btnManagePrevtickets.TabIndex = 43
        Me.btnManagePrevtickets.Text = "Manage Tickets"
        Me.btnManagePrevtickets.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 216)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 15)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "PREVIOUS CLAIMED HITS:"
        '
        'txtPreviousHitsClaimed
        '
        Me.txtPreviousHitsClaimed.BackColor = System.Drawing.Color.White
        Me.txtPreviousHitsClaimed.Location = New System.Drawing.Point(160, 213)
        Me.txtPreviousHitsClaimed.Name = "txtPreviousHitsClaimed"
        Me.txtPreviousHitsClaimed.ReadOnly = True
        Me.txtPreviousHitsClaimed.Size = New System.Drawing.Size(116, 23)
        Me.txtPreviousHitsClaimed.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 15)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "ONDATE CLAIMED HITS:"
        '
        'txtOndateHitsClaimed
        '
        Me.txtOndateHitsClaimed.BackColor = System.Drawing.Color.White
        Me.txtOndateHitsClaimed.Location = New System.Drawing.Point(160, 187)
        Me.txtOndateHitsClaimed.Name = "txtOndateHitsClaimed"
        Me.txtOndateHitsClaimed.ReadOnly = True
        Me.txtOndateHitsClaimed.Size = New System.Drawing.Size(116, 23)
        Me.txtOndateHitsClaimed.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(72, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "ONDATE HITS:"
        '
        'txtHitsOndate
        '
        Me.txtHitsOndate.BackColor = System.Drawing.Color.White
        Me.txtHitsOndate.Location = New System.Drawing.Point(160, 149)
        Me.txtHitsOndate.Name = "txtHitsOndate"
        Me.txtHitsOndate.ReadOnly = True
        Me.txtHitsOndate.Size = New System.Drawing.Size(116, 23)
        Me.txtHitsOndate.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "OVERALL NET:"
        '
        'txtAgentCode
        '
        Me.txtAgentCode.BackColor = System.Drawing.Color.White
        Me.txtAgentCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAgentCode.Location = New System.Drawing.Point(160, 71)
        Me.txtAgentCode.Name = "txtAgentCode"
        Me.txtAgentCode.ReadOnly = True
        Me.txtAgentCode.Size = New System.Drawing.Size(116, 23)
        Me.txtAgentCode.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "AGENT CODE:"
        '
        'txtNetOndate
        '
        Me.txtNetOndate.BackColor = System.Drawing.Color.White
        Me.txtNetOndate.Location = New System.Drawing.Point(160, 123)
        Me.txtNetOndate.Name = "txtNetOndate"
        Me.txtNetOndate.ReadOnly = True
        Me.txtNetOndate.Size = New System.Drawing.Size(116, 23)
        Me.txtNetOndate.TabIndex = 19
        '
        'txtCoor
        '
        Me.txtCoor.BackColor = System.Drawing.Color.White
        Me.txtCoor.Location = New System.Drawing.Point(160, 97)
        Me.txtCoor.Name = "txtCoor"
        Me.txtCoor.ReadOnly = True
        Me.txtCoor.Size = New System.Drawing.Size(327, 23)
        Me.txtCoor.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "COORDINATOR:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(549, 41)
        Me.Panel4.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(512, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 39)
        Me.Button2.TabIndex = 19
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(2, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(283, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "INPUT REMITTANCE DETAILS"
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.SystemColors.Control
        Me.PanelSearch.Controls.Add(Me.Button1)
        Me.PanelSearch.Controls.Add(Me.cmbSearch)
        Me.PanelSearch.Controls.Add(Me.txtSearch)
        Me.PanelSearch.Controls.Add(Me.Label9)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 0)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(685, 55)
        Me.PanelSearch.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(569, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 29)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Refresh"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"AGENT CODE", "COORDINATOR"})
        Me.cmbSearch.Location = New System.Drawing.Point(13, 13)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 23)
        Me.cmbSearch.TabIndex = 26
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(192, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(371, 23)
        Me.txtSearch.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(145, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Search:"
        '
        'FrmReceiversForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 749)
        Me.Controls.Add(Me.PanelInputRemittance)
        Me.Controls.Add(Me.PaneldtgRemittances)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "FrmReceiversForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIVERS FORM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PaneldtgRemittances.ResumeLayout(False)
        CType(Me.dtgRidersCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInputRemittance.ResumeLayout(False)
        Me.PanelInputRemittance.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PaneldtgRemittances As Panel
    Friend WithEvents dtgRidersCollection As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDateofSales As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCollector As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelInputRemittance As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtrfNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAgentCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNetOndate As TextBox
    Friend WithEvents txtCoor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtHitsOndate As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPreviousHitsClaimed As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtOndateHitsClaimed As TextBox
    Friend WithEvents btnManageUnremitted As Button
    Friend WithEvents btnManagePrevtickets As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNetRemittance As TextBox
    Friend WithEvents btnPostRemittance As Button
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotalHitsClaimed As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
End Class
