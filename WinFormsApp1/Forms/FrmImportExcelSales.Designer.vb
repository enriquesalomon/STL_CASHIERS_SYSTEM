<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImportExcelSales
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelbottom = New System.Windows.Forms.Panel()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.cboSheet = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelcenter = New System.Windows.Forms.Panel()
        Me.dtgImportSales = New System.Windows.Forms.DataGridView()
        Me.ImportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClusterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarangayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RiderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoordinatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.panelbottom.SuspendLayout()
        Me.panelcenter.SuspendLayout()
        CType(Me.dtgImportSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1042, 31)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(978, 0)
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
        Me.Label5.Size = New System.Drawing.Size(147, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "IMPORT SALES REPORT"
        '
        'panelbottom
        '
        Me.panelbottom.Controls.Add(Me.btnImport)
        Me.panelbottom.Controls.Add(Me.cboSheet)
        Me.panelbottom.Controls.Add(Me.Label2)
        Me.panelbottom.Controls.Add(Me.btnBrowse)
        Me.panelbottom.Controls.Add(Me.txtFilename)
        Me.panelbottom.Controls.Add(Me.Label1)
        Me.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelbottom.Location = New System.Drawing.Point(0, 458)
        Me.panelbottom.Name = "panelbottom"
        Me.panelbottom.Size = New System.Drawing.Size(1042, 84)
        Me.panelbottom.TabIndex = 4
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(232, 35)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(82, 26)
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'cboSheet
        '
        Me.cboSheet.FormattingEnabled = True
        Me.cboSheet.Location = New System.Drawing.Point(70, 36)
        Me.cboSheet.Name = "cboSheet"
        Me.cboSheet.Size = New System.Drawing.Size(156, 23)
        Me.cboSheet.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sheet:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(863, 6)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(95, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(70, 6)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(787, 23)
        Me.txtFilename.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filename:"
        '
        'panelcenter
        '
        Me.panelcenter.Controls.Add(Me.dtgImportSales)
        Me.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcenter.Location = New System.Drawing.Point(0, 31)
        Me.panelcenter.Name = "panelcenter"
        Me.panelcenter.Size = New System.Drawing.Size(1042, 427)
        Me.panelcenter.TabIndex = 5
        '
        'dtgImportSales
        '
        Me.dtgImportSales.AutoGenerateColumns = False
        Me.dtgImportSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgImportSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClusterDataGridViewTextBoxColumn, Me.BarangayDataGridViewTextBoxColumn, Me.RiderDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.CoordinatorDataGridViewTextBoxColumn, Me.AgentDataGridViewTextBoxColumn, Me.CommDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn})
        Me.dtgImportSales.DataSource = Me.ImportTableBindingSource
        Me.dtgImportSales.Location = New System.Drawing.Point(13, 6)
        Me.dtgImportSales.Name = "dtgImportSales"
        Me.dtgImportSales.RowTemplate.Height = 25
        Me.dtgImportSales.Size = New System.Drawing.Size(957, 403)
        Me.dtgImportSales.TabIndex = 0
        '
        'ImportTableBindingSource
        '
        Me.ImportTableBindingSource.DataSource = GetType(WinFormsApp1.ImportTable)
        '
        'ClusterDataGridViewTextBoxColumn
        '
        Me.ClusterDataGridViewTextBoxColumn.DataPropertyName = "Cluster"
        Me.ClusterDataGridViewTextBoxColumn.HeaderText = "Cluster"
        Me.ClusterDataGridViewTextBoxColumn.Name = "ClusterDataGridViewTextBoxColumn"
        '
        'BarangayDataGridViewTextBoxColumn
        '
        Me.BarangayDataGridViewTextBoxColumn.DataPropertyName = "Barangay"
        Me.BarangayDataGridViewTextBoxColumn.HeaderText = "Barangay"
        Me.BarangayDataGridViewTextBoxColumn.Name = "BarangayDataGridViewTextBoxColumn"
        '
        'RiderDataGridViewTextBoxColumn
        '
        Me.RiderDataGridViewTextBoxColumn.DataPropertyName = "Rider"
        Me.RiderDataGridViewTextBoxColumn.HeaderText = "Rider"
        Me.RiderDataGridViewTextBoxColumn.Name = "RiderDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'CoordinatorDataGridViewTextBoxColumn
        '
        Me.CoordinatorDataGridViewTextBoxColumn.DataPropertyName = "Coordinator"
        Me.CoordinatorDataGridViewTextBoxColumn.HeaderText = "Coordinator"
        Me.CoordinatorDataGridViewTextBoxColumn.Name = "CoordinatorDataGridViewTextBoxColumn"
        '
        'AgentDataGridViewTextBoxColumn
        '
        Me.AgentDataGridViewTextBoxColumn.DataPropertyName = "Agent"
        Me.AgentDataGridViewTextBoxColumn.HeaderText = "Agent"
        Me.AgentDataGridViewTextBoxColumn.Name = "AgentDataGridViewTextBoxColumn"
        '
        'CommDataGridViewTextBoxColumn
        '
        Me.CommDataGridViewTextBoxColumn.DataPropertyName = "Comm"
        Me.CommDataGridViewTextBoxColumn.HeaderText = "Comm"
        Me.CommDataGridViewTextBoxColumn.Name = "CommDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'FrmImportExcelSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 542)
        Me.Controls.Add(Me.panelcenter)
        Me.Controls.Add(Me.panelbottom)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmImportExcelSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmImportExcelSales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelbottom.ResumeLayout(False)
        Me.panelbottom.PerformLayout()
        Me.panelcenter.ResumeLayout(False)
        CType(Me.dtgImportSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents panelbottom As Panel
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelcenter As Panel
    Friend WithEvents cboSheet As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents dtgImportSales As DataGridView
    Friend WithEvents DatereportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImportTableBindingSource As BindingSource
    Friend WithEvents ClusterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarangayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RiderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoordinatorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
