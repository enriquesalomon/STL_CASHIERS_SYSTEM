<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCollector = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDateofSales = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelInputRemittance = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAgentCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtgRidersCollection = New System.Windows.Forms.DataGridView()
        Me.txtrfNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelInputRemittance.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dtgRidersCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1019, 31)
        Me.Panel1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(955, 0)
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
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RECEIVERS FORM"
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
        Me.Panel2.Location = New System.Drawing.Point(685, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 576)
        Me.Panel2.TabIndex = 5
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
        Me.txtDateofSales.Location = New System.Drawing.Point(97, 73)
        Me.txtDateofSales.Name = "txtDateofSales"
        Me.txtDateofSales.ReadOnly = True
        Me.txtDateofSales.Size = New System.Drawing.Size(191, 23)
        Me.txtDateofSales.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PanelInputRemittance)
        Me.Panel3.Controls.Add(Me.dtgRidersCollection)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(685, 576)
        Me.Panel3.TabIndex = 6
        '
        'PanelInputRemittance
        '
        Me.PanelInputRemittance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelInputRemittance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInputRemittance.Controls.Add(Me.TextBox1)
        Me.PanelInputRemittance.Controls.Add(Me.Label8)
        Me.PanelInputRemittance.Controls.Add(Me.txtAgentCode)
        Me.PanelInputRemittance.Controls.Add(Me.Label4)
        Me.PanelInputRemittance.Controls.Add(Me.btnLoad)
        Me.PanelInputRemittance.Controls.Add(Me.Panel4)
        Me.PanelInputRemittance.Location = New System.Drawing.Point(109, 122)
        Me.PanelInputRemittance.Name = "PanelInputRemittance"
        Me.PanelInputRemittance.Size = New System.Drawing.Size(428, 169)
        Me.PanelInputRemittance.TabIndex = 14
        Me.PanelInputRemittance.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(102, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(305, 23)
        Me.TextBox1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Coor:"
        '
        'txtAgentCode
        '
        Me.txtAgentCode.BackColor = System.Drawing.Color.White
        Me.txtAgentCode.Location = New System.Drawing.Point(102, 43)
        Me.txtAgentCode.Name = "txtAgentCode"
        Me.txtAgentCode.ReadOnly = True
        Me.txtAgentCode.Size = New System.Drawing.Size(114, 23)
        Me.txtAgentCode.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Agent Code:"
        '
        'btnLoad
        '
        Me.btnLoad.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLoad.Location = New System.Drawing.Point(0, 130)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(426, 37)
        Me.btnLoad.TabIndex = 17
        Me.btnLoad.Text = "Load Record"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(426, 27)
        Me.Panel4.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(2, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "INPUT REMITTANCE DETAILS"
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
        Me.dtgRidersCollection.Size = New System.Drawing.Size(685, 576)
        Me.dtgRidersCollection.TabIndex = 3
        '
        'txtrfNum
        '
        Me.txtrfNum.BackColor = System.Drawing.Color.White
        Me.txtrfNum.Location = New System.Drawing.Point(97, 44)
        Me.txtrfNum.Name = "txtrfNum"
        Me.txtrfNum.ReadOnly = True
        Me.txtrfNum.Size = New System.Drawing.Size(191, 23)
        Me.txtrfNum.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "RF #:"
        '
        'FrmReceiversForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 607)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReceiversForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReceiversForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PanelInputRemittance.ResumeLayout(False)
        Me.PanelInputRemittance.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dtgRidersCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtgRidersCollection As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDateofSales As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCollector As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelInputRemittance As Panel
    Friend WithEvents btnLoad As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAgentCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtrfNum As TextBox
    Friend WithEvents Label6 As Label
End Class
