﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTicketEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTicketEntry))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblagentcode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.lbltotalticket = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblprevticket = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblondateticket = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.paneldtgList = New System.Windows.Forms.Panel()
        Me.dtgTickets = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drawdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agentcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountwon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claimeddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tickettype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panelentry = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTicketType = New System.Windows.Forms.ComboBox()
        Me.txtWinningAmount = New System.Windows.Forms.TextBox()
        Me.dtpDrawDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSaveOndate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.panelBottom.SuspendLayout()
        Me.paneldtgList.SuspendLayout()
        CType(Me.dtgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelentry.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblagentcode)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 35)
        Me.Panel4.TabIndex = 1
        '
        'lblagentcode
        '
        Me.lblagentcode.AutoSize = True
        Me.lblagentcode.BackColor = System.Drawing.Color.Goldenrod
        Me.lblagentcode.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblagentcode.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblagentcode.ForeColor = System.Drawing.Color.White
        Me.lblagentcode.Location = New System.Drawing.Point(154, 0)
        Me.lblagentcode.Name = "lblagentcode"
        Me.lblagentcode.Size = New System.Drawing.Size(154, 25)
        Me.lblagentcode.TabIndex = 9
        Me.lblagentcode.Text = "AGENT CODE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Goldenrod
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "AGENT CODE:"
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.SystemColors.Control
        Me.PanelSearch.Controls.Add(Me.txtSearch)
        Me.PanelSearch.Controls.Add(Me.Label9)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 35)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(690, 55)
        Me.PanelSearch.TabIndex = 16
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(94, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(539, 23)
        Me.txtSearch.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Search:"
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.SystemColors.Control
        Me.panelBottom.Controls.Add(Me.lbltotalticket)
        Me.panelBottom.Controls.Add(Me.Label12)
        Me.panelBottom.Controls.Add(Me.lblprevticket)
        Me.panelBottom.Controls.Add(Me.Label10)
        Me.panelBottom.Controls.Add(Me.lblondateticket)
        Me.panelBottom.Controls.Add(Me.Label8)
        Me.panelBottom.Controls.Add(Me.btnAdd)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 507)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(690, 52)
        Me.panelBottom.TabIndex = 17
        '
        'lbltotalticket
        '
        Me.lbltotalticket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotalticket.AutoSize = True
        Me.lbltotalticket.ForeColor = System.Drawing.Color.Maroon
        Me.lbltotalticket.Location = New System.Drawing.Point(240, 25)
        Me.lbltotalticket.Name = "lbltotalticket"
        Me.lbltotalticket.Size = New System.Drawing.Size(13, 15)
        Me.lbltotalticket.TabIndex = 30
        Me.lbltotalticket.Text = "0"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(239, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 15)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "TOTAL CLAIMED"
        '
        'lblprevticket
        '
        Me.lblprevticket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblprevticket.AutoSize = True
        Me.lblprevticket.ForeColor = System.Drawing.Color.Maroon
        Me.lblprevticket.Location = New System.Drawing.Point(119, 25)
        Me.lblprevticket.Name = "lblprevticket"
        Me.lblprevticket.Size = New System.Drawing.Size(13, 15)
        Me.lblprevticket.TabIndex = 28
        Me.lblprevticket.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(116, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 15)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "PREVIOUS TICKET"
        '
        'lblondateticket
        '
        Me.lblondateticket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblondateticket.AutoSize = True
        Me.lblondateticket.ForeColor = System.Drawing.Color.Maroon
        Me.lblondateticket.Location = New System.Drawing.Point(9, 25)
        Me.lblondateticket.Name = "lblondateticket"
        Me.lblondateticket.Size = New System.Drawing.Size(13, 15)
        Me.lblondateticket.TabIndex = 26
        Me.lblondateticket.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(9, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "ONDATE TICKET"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(590, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'paneldtgList
        '
        Me.paneldtgList.Controls.Add(Me.dtgTickets)
        Me.paneldtgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneldtgList.Location = New System.Drawing.Point(0, 90)
        Me.paneldtgList.Name = "paneldtgList"
        Me.paneldtgList.Size = New System.Drawing.Size(690, 417)
        Me.paneldtgList.TabIndex = 18
        '
        'dtgTickets
        '
        Me.dtgTickets.AllowUserToAddRows = False
        Me.dtgTickets.AllowUserToDeleteRows = False
        Me.dtgTickets.AllowUserToResizeColumns = False
        Me.dtgTickets.AllowUserToResizeRows = False
        Me.dtgTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgTickets.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgTickets.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgTickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgTickets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgTickets.ColumnHeadersHeight = 35
        Me.dtgTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgTickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.drawdate, Me.agentcode, Me.amountwon, Me.claimeddate, Me.tickettype, Me.delete})
        Me.dtgTickets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgTickets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgTickets.EnableHeadersVisualStyles = False
        Me.dtgTickets.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgTickets.Location = New System.Drawing.Point(0, 0)
        Me.dtgTickets.MultiSelect = False
        Me.dtgTickets.Name = "dtgTickets"
        Me.dtgTickets.ReadOnly = True
        Me.dtgTickets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgTickets.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgTickets.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        Me.dtgTickets.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgTickets.RowTemplate.Height = 25
        Me.dtgTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTickets.Size = New System.Drawing.Size(690, 417)
        Me.dtgTickets.TabIndex = 4
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 42
        '
        'drawdate
        '
        Me.drawdate.HeaderText = "DRAWDATE"
        Me.drawdate.Name = "drawdate"
        Me.drawdate.ReadOnly = True
        Me.drawdate.Width = 92
        '
        'agentcode
        '
        Me.agentcode.HeaderText = "AGENTCODE"
        Me.agentcode.Name = "agentcode"
        Me.agentcode.ReadOnly = True
        '
        'amountwon
        '
        Me.amountwon.HeaderText = "AMOUNT WON"
        Me.amountwon.Name = "amountwon"
        Me.amountwon.ReadOnly = True
        Me.amountwon.Width = 102
        '
        'claimeddate
        '
        Me.claimeddate.HeaderText = "CLAIMED DATE"
        Me.claimeddate.Name = "claimeddate"
        Me.claimeddate.ReadOnly = True
        '
        'tickettype
        '
        Me.tickettype.HeaderText = "TICKET TYPE"
        Me.tickettype.Name = "tickettype"
        Me.tickettype.ReadOnly = True
        Me.tickettype.Width = 86
        '
        'delete
        '
        Me.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.delete.HeaderText = ""
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.delete.ToolTipText = "DELETE"
        Me.delete.Width = 19
        '
        'Panelentry
        '
        Me.Panelentry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelentry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelentry.Controls.Add(Me.Label1)
        Me.Panelentry.Controls.Add(Me.cmbTicketType)
        Me.Panelentry.Controls.Add(Me.txtWinningAmount)
        Me.Panelentry.Controls.Add(Me.dtpDrawDate)
        Me.Panelentry.Controls.Add(Me.btnSaveOndate)
        Me.Panelentry.Controls.Add(Me.Label2)
        Me.Panelentry.Controls.Add(Me.Label4)
        Me.Panelentry.Controls.Add(Me.Panel2)
        Me.Panelentry.Location = New System.Drawing.Point(152, 170)
        Me.Panelentry.Name = "Panelentry"
        Me.Panelentry.Size = New System.Drawing.Size(332, 165)
        Me.Panelentry.TabIndex = 17
        Me.Panelentry.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "TICKET TYPE:"
        '
        'cmbTicketType
        '
        Me.cmbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTicketType.FormattingEnabled = True
        Me.cmbTicketType.Items.AddRange(New Object() {"ONDATE", "PREVIOUS"})
        Me.cmbTicketType.Location = New System.Drawing.Point(132, 38)
        Me.cmbTicketType.Name = "cmbTicketType"
        Me.cmbTicketType.Size = New System.Drawing.Size(174, 23)
        Me.cmbTicketType.TabIndex = 49
        '
        'txtWinningAmount
        '
        Me.txtWinningAmount.BackColor = System.Drawing.Color.White
        Me.txtWinningAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtWinningAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtWinningAmount.Location = New System.Drawing.Point(132, 94)
        Me.txtWinningAmount.Name = "txtWinningAmount"
        Me.txtWinningAmount.Size = New System.Drawing.Size(174, 23)
        Me.txtWinningAmount.TabIndex = 48
        Me.txtWinningAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpDrawDate
        '
        Me.dtpDrawDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDrawDate.Location = New System.Drawing.Point(132, 67)
        Me.dtpDrawDate.Name = "dtpDrawDate"
        Me.dtpDrawDate.Size = New System.Drawing.Size(174, 23)
        Me.dtpDrawDate.TabIndex = 19
        '
        'btnSaveOndate
        '
        Me.btnSaveOndate.Image = CType(resources.GetObject("btnSaveOndate.Image"), System.Drawing.Image)
        Me.btnSaveOndate.Location = New System.Drawing.Point(132, 120)
        Me.btnSaveOndate.Name = "btnSaveOndate"
        Me.btnSaveOndate.Size = New System.Drawing.Size(174, 34)
        Me.btnSaveOndate.TabIndex = 17
        Me.btnSaveOndate.Text = "Save"
        Me.btnSaveOndate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveOndate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveOndate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "WON AMOUNT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(49, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "DRAW DATE:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 32)
        Me.Panel2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(293, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Goldenrod
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TICKET ENTRY"
        '
        'FrmTicketEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 559)
        Me.Controls.Add(Me.Panelentry)
        Me.Controls.Add(Me.paneldtgList)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTicketEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TICKET ENTRY"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.panelBottom.ResumeLayout(False)
        Me.panelBottom.PerformLayout()
        Me.paneldtgList.ResumeLayout(False)
        CType(Me.dtgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelentry.ResumeLayout(False)
        Me.Panelentry.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents panelBottom As Panel
    Friend WithEvents paneldtgList As Panel
    Friend WithEvents dtgTickets As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panelentry As Panel
    Friend WithEvents txtWinningAmount As TextBox
    Friend WithEvents dtpDrawDate As DateTimePicker
    Friend WithEvents btnSaveOndate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTicketType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblagentcode As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblondateticket As Label
    Friend WithEvents lbltotalticket As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblprevticket As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents drawdate As DataGridViewTextBoxColumn
    Friend WithEvents agentcode As DataGridViewTextBoxColumn
    Friend WithEvents amountwon As DataGridViewTextBoxColumn
    Friend WithEvents claimeddate As DataGridViewTextBoxColumn
    Friend WithEvents tickettype As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewImageColumn
End Class
