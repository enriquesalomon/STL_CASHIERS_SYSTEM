<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGameAccountsSummary
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
        Me.panelbottom = New System.Windows.Forms.Panel()
        Me.lblrec = New System.Windows.Forms.Label()
        Me.panelcenter = New System.Windows.Forms.Panel()
        Me.dtgSummary = New System.Windows.Forms.DataGridView()
        Me.paneltop = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelbottom.SuspendLayout()
        Me.panelcenter.SuspendLayout()
        CType(Me.dtgSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneltop.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelbottom
        '
        Me.panelbottom.BackColor = System.Drawing.Color.White
        Me.panelbottom.Controls.Add(Me.lblrec)
        Me.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelbottom.Location = New System.Drawing.Point(0, 508)
        Me.panelbottom.Name = "panelbottom"
        Me.panelbottom.Size = New System.Drawing.Size(1058, 29)
        Me.panelbottom.TabIndex = 5
        '
        'lblrec
        '
        Me.lblrec.AutoSize = True
        Me.lblrec.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblrec.Location = New System.Drawing.Point(1017, 0)
        Me.lblrec.Name = "lblrec"
        Me.lblrec.Size = New System.Drawing.Size(41, 15)
        Me.lblrec.TabIndex = 0
        Me.lblrec.Text = "Label1"
        Me.lblrec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelcenter
        '
        Me.panelcenter.Controls.Add(Me.dtgSummary)
        Me.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcenter.Location = New System.Drawing.Point(0, 44)
        Me.panelcenter.Name = "panelcenter"
        Me.panelcenter.Size = New System.Drawing.Size(1058, 464)
        Me.panelcenter.TabIndex = 6
        '
        'dtgSummary
        '
        Me.dtgSummary.AllowUserToAddRows = False
        Me.dtgSummary.AllowUserToDeleteRows = False
        Me.dtgSummary.AllowUserToResizeColumns = False
        Me.dtgSummary.AllowUserToResizeRows = False
        Me.dtgSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgSummary.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgSummary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgSummary.ColumnHeadersHeight = 35
        Me.dtgSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgSummary.EnableHeadersVisualStyles = False
        Me.dtgSummary.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgSummary.Location = New System.Drawing.Point(0, 0)
        Me.dtgSummary.MultiSelect = False
        Me.dtgSummary.Name = "dtgSummary"
        Me.dtgSummary.ReadOnly = True
        Me.dtgSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSummary.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgSummary.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        Me.dtgSummary.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgSummary.RowTemplate.Height = 25
        Me.dtgSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgSummary.Size = New System.Drawing.Size(1058, 464)
        Me.dtgSummary.TabIndex = 1
        '
        'paneltop
        '
        Me.paneltop.BackColor = System.Drawing.Color.White
        Me.paneltop.Controls.Add(Me.txtSearch)
        Me.paneltop.Controls.Add(Me.Label9)
        Me.paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltop.Location = New System.Drawing.Point(0, 0)
        Me.paneltop.Name = "paneltop"
        Me.paneltop.Size = New System.Drawing.Size(1058, 44)
        Me.paneltop.TabIndex = 7
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(319, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(468, 23)
        Me.txtSearch.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Search:"
        '
        'FrmGameAccountsSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 537)
        Me.Controls.Add(Me.panelcenter)
        Me.Controls.Add(Me.panelbottom)
        Me.Controls.Add(Me.paneltop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "FrmGameAccountsSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Accounts Summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelbottom.ResumeLayout(False)
        Me.panelbottom.PerformLayout()
        Me.panelcenter.ResumeLayout(False)
        CType(Me.dtgSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneltop.ResumeLayout(False)
        Me.paneltop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelbottom As Panel
    Friend WithEvents panelcenter As Panel
    Friend WithEvents dtgSummary As DataGridView
    Friend WithEvents paneltop As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblrec As Label
End Class
