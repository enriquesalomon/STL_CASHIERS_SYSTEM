<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceiversEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceiversEntry))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelbottom = New System.Windows.Forms.Panel()
        Me.lblrec = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtgReceiversFormList = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ManageRemittanceFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRemittanceFormRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.panelbottom.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dtgReceiversFormList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1238, 43)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "LIST OF RECEIVERS FORM"
        '
        'panelbottom
        '
        Me.panelbottom.BackColor = System.Drawing.Color.White
        Me.panelbottom.Controls.Add(Me.lblrec)
        Me.panelbottom.Controls.Add(Me.Button6)
        Me.panelbottom.Controls.Add(Me.Button5)
        Me.panelbottom.Controls.Add(Me.Button3)
        Me.panelbottom.Controls.Add(Me.Button1)
        Me.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelbottom.Location = New System.Drawing.Point(0, 483)
        Me.panelbottom.Name = "panelbottom"
        Me.panelbottom.Size = New System.Drawing.Size(1238, 42)
        Me.panelbottom.TabIndex = 5
        '
        'lblrec
        '
        Me.lblrec.AutoSize = True
        Me.lblrec.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblrec.Location = New System.Drawing.Point(1197, 0)
        Me.lblrec.Name = "lblrec"
        Me.lblrec.Size = New System.Drawing.Size(41, 15)
        Me.lblrec.TabIndex = 5
        Me.lblrec.Text = "Label1"
        Me.lblrec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(286, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 31)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Print"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(192, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 31)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Delete"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(98, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 31)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Edit"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "New"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.dtgReceiversFormList)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1238, 440)
        Me.Panel3.TabIndex = 6
        '
        'dtgReceiversFormList
        '
        Me.dtgReceiversFormList.AllowUserToAddRows = False
        Me.dtgReceiversFormList.AllowUserToDeleteRows = False
        Me.dtgReceiversFormList.AllowUserToResizeColumns = False
        Me.dtgReceiversFormList.AllowUserToResizeRows = False
        Me.dtgReceiversFormList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgReceiversFormList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgReceiversFormList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgReceiversFormList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgReceiversFormList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgReceiversFormList.ColumnHeadersHeight = 35
        Me.dtgReceiversFormList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgReceiversFormList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtgReceiversFormList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgReceiversFormList.EnableHeadersVisualStyles = False
        Me.dtgReceiversFormList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgReceiversFormList.Location = New System.Drawing.Point(0, 0)
        Me.dtgReceiversFormList.MultiSelect = False
        Me.dtgReceiversFormList.Name = "dtgReceiversFormList"
        Me.dtgReceiversFormList.ReadOnly = True
        Me.dtgReceiversFormList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgReceiversFormList.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgReceiversFormList.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        Me.dtgReceiversFormList.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgReceiversFormList.RowTemplate.Height = 25
        Me.dtgReceiversFormList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgReceiversFormList.Size = New System.Drawing.Size(1238, 440)
        Me.dtgReceiversFormList.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageRemittanceFormToolStripMenuItem, Me.DeleteRemittanceFormRecordToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(242, 48)
        '
        'ManageRemittanceFormToolStripMenuItem
        '
        Me.ManageRemittanceFormToolStripMenuItem.Name = "ManageRemittanceFormToolStripMenuItem"
        Me.ManageRemittanceFormToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ManageRemittanceFormToolStripMenuItem.Text = "Manage Remittance Form"
        '
        'DeleteRemittanceFormRecordToolStripMenuItem
        '
        Me.DeleteRemittanceFormRecordToolStripMenuItem.Name = "DeleteRemittanceFormRecordToolStripMenuItem"
        Me.DeleteRemittanceFormRecordToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.DeleteRemittanceFormRecordToolStripMenuItem.Text = "Delete Remittance Form Record"
        '
        'FrmReceiversEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 525)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panelbottom)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "FrmReceiversEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIVING"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelbottom.ResumeLayout(False)
        Me.panelbottom.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dtgReceiversFormList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelbottom As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtgReceiversFormList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ManageRemittanceFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRemittanceFormRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblrec As Label
End Class
