<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRidersDailySummary
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtgRidersCollection = New System.Windows.Forms.DataGridView()
        Me.PanelRider = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboRiders = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblridername = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgRidersCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRider.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 31)
        Me.Panel1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(937, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 31)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "x"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Goldenrod
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RIDER'S DAILY SUMMARY"
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
        Me.dtgRidersCollection.EnableHeadersVisualStyles = False
        Me.dtgRidersCollection.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgRidersCollection.Location = New System.Drawing.Point(7, 89)
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
        Me.dtgRidersCollection.Size = New System.Drawing.Size(642, 437)
        Me.dtgRidersCollection.TabIndex = 6
        '
        'PanelRider
        '
        Me.PanelRider.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRider.Controls.Add(Me.Button1)
        Me.PanelRider.Controls.Add(Me.Label2)
        Me.PanelRider.Controls.Add(Me.Label4)
        Me.PanelRider.Controls.Add(Me.cboRiders)
        Me.PanelRider.Controls.Add(Me.DateTimePicker1)
        Me.PanelRider.Controls.Add(Me.Panel4)
        Me.PanelRider.Location = New System.Drawing.Point(27, 34)
        Me.PanelRider.Name = "PanelRider"
        Me.PanelRider.Size = New System.Drawing.Size(298, 141)
        Me.PanelRider.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 37)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Load Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "RIDER:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "DATE:"
        '
        'cboRiders
        '
        Me.cboRiders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRiders.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cboRiders.FormattingEnabled = True
        Me.cboRiders.Location = New System.Drawing.Point(66, 70)
        Me.cboRiders.Name = "cboRiders"
        Me.cboRiders.Size = New System.Drawing.Size(223, 24)
        Me.cboRiders.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(65, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(224, 22)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(296, 27)
        Me.Panel4.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Goldenrod
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SELECT RIDERS DAILY SUMMARY RECORD"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblridername)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1001, 58)
        Me.Panel2.TabIndex = 14
        '
        'lblridername
        '
        Me.lblridername.AutoSize = True
        Me.lblridername.BackColor = System.Drawing.Color.Transparent
        Me.lblridername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblridername.ForeColor = System.Drawing.Color.Black
        Me.lblridername.Location = New System.Drawing.Point(406, 34)
        Me.lblridername.Name = "lblridername"
        Me.lblridername.Size = New System.Drawing.Size(48, 17)
        Me.lblridername.TabIndex = 12
        Me.lblridername.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(352, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "RIDER:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(55, 34)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 17)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "DATE:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.PanelRider)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(649, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 449)
        Me.Panel3.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(29, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(296, 75)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Generate Receivers Form"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 89)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(649, 449)
        Me.Panel5.TabIndex = 16
        '
        'FrmRidersDailySummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 538)
        Me.Controls.Add(Me.dtgRidersCollection)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRidersDailySummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRidersDailySummary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgRidersCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRider.ResumeLayout(False)
        Me.PanelRider.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtgRidersCollection As DataGridView
    Friend WithEvents PanelRider As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboRiders As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblridername As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
End Class
