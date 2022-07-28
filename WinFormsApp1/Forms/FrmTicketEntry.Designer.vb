<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.paneldtgList = New System.Windows.Forms.Panel()
        Me.Panelentry = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.txtWinningAmount = New System.Windows.Forms.TextBox()
        Me.dtpOndateDrawDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSaveOndate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgTickets = New System.Windows.Forms.DataGridView()
        Me.Panel4.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.panelBottom.SuspendLayout()
        Me.paneldtgList.SuspendLayout()
        Me.Panelentry.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(471, 41)
        Me.Panel4.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(2, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TICKET ENTRY"
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.SystemColors.Control
        Me.PanelSearch.Controls.Add(Me.txtSearch)
        Me.PanelSearch.Controls.Add(Me.Label9)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 41)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(471, 55)
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
        Me.txtSearch.Size = New System.Drawing.Size(320, 23)
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
        Me.panelBottom.Controls.Add(Me.btnDelete)
        Me.panelBottom.Controls.Add(Me.btnEdit)
        Me.panelBottom.Controls.Add(Me.btnAdd)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 518)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(471, 41)
        Me.panelBottom.TabIndex = 17
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(298, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 27)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(196, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 27)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(94, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 27)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'paneldtgList
        '
        Me.paneldtgList.Controls.Add(Me.Panelentry)
        Me.paneldtgList.Controls.Add(Me.dtgTickets)
        Me.paneldtgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.paneldtgList.Location = New System.Drawing.Point(0, 96)
        Me.paneldtgList.Name = "paneldtgList"
        Me.paneldtgList.Size = New System.Drawing.Size(471, 422)
        Me.paneldtgList.TabIndex = 18
        '
        'Panelentry
        '
        Me.Panelentry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelentry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelentry.Controls.Add(Me.Label1)
        Me.Panelentry.Controls.Add(Me.cmbSearch)
        Me.Panelentry.Controls.Add(Me.txtWinningAmount)
        Me.Panelentry.Controls.Add(Me.dtpOndateDrawDate)
        Me.Panelentry.Controls.Add(Me.btnSaveOndate)
        Me.Panelentry.Controls.Add(Me.Label2)
        Me.Panelentry.Controls.Add(Me.Label4)
        Me.Panelentry.Controls.Add(Me.Panel2)
        Me.Panelentry.Location = New System.Drawing.Point(76, 81)
        Me.Panelentry.Name = "Panelentry"
        Me.Panelentry.Size = New System.Drawing.Size(318, 170)
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
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"ONDATE", "PREVIOUS"})
        Me.cmbSearch.Location = New System.Drawing.Point(132, 38)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(174, 23)
        Me.cmbSearch.TabIndex = 49
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
        'dtpOndateDrawDate
        '
        Me.dtpOndateDrawDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOndateDrawDate.Location = New System.Drawing.Point(132, 67)
        Me.dtpOndateDrawDate.Name = "dtpOndateDrawDate"
        Me.dtpOndateDrawDate.Size = New System.Drawing.Size(174, 23)
        Me.dtpOndateDrawDate.TabIndex = 19
        '
        'btnSaveOndate
        '
        Me.btnSaveOndate.Location = New System.Drawing.Point(132, 120)
        Me.btnSaveOndate.Name = "btnSaveOndate"
        Me.btnSaveOndate.Size = New System.Drawing.Size(174, 37)
        Me.btnSaveOndate.TabIndex = 17
        Me.btnSaveOndate.Text = "Save"
        Me.btnSaveOndate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "WINNING AMOUNT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(50, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "DRAW DATE:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(316, 27)
        Me.Panel2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Goldenrod
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(288, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "X"
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
        Me.dtgTickets.Size = New System.Drawing.Size(471, 422)
        Me.dtgTickets.TabIndex = 4
        '
        'FrmTicketEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 559)
        Me.Controls.Add(Me.paneldtgList)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmTicketEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTicketEntry"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.panelBottom.ResumeLayout(False)
        Me.paneldtgList.ResumeLayout(False)
        Me.Panelentry.ResumeLayout(False)
        Me.Panelentry.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents panelBottom As Panel
    Friend WithEvents paneldtgList As Panel
    Friend WithEvents dtgTickets As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panelentry As Panel
    Friend WithEvents txtWinningAmount As TextBox
    Friend WithEvents dtpOndateDrawDate As DateTimePicker
    Friend WithEvents btnSaveOndate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSearch As ComboBox
End Class
