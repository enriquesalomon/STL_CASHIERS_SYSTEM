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
        Me.SalesdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClusterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MunicipalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RiderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoordinatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Draw1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comm1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Net1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hits1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Draw2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comm2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Net2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hits2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Draw3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comm3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Net3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hits3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverallgrossDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverallcommDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverallnetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverallhitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.panelbottom.BackColor = System.Drawing.Color.White
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
        Me.btnImport.Size = New System.Drawing.Size(127, 26)
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = "Import to Database"
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
        Me.Label2.Location = New System.Drawing.Point(32, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sheet:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(497, 6)
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
        Me.txtFilename.Size = New System.Drawing.Size(422, 23)
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
        Me.dtgImportSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalesdateDataGridViewTextBoxColumn, Me.ClusterDataGridViewTextBoxColumn, Me.MunicipalityDataGridViewTextBoxColumn, Me.RiderDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.CoordinatorDataGridViewTextBoxColumn, Me.AgentDataGridViewTextBoxColumn, Me.CommDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.Draw1DataGridViewTextBoxColumn, Me.Comm1DataGridViewTextBoxColumn, Me.Net1DataGridViewTextBoxColumn, Me.Hits1DataGridViewTextBoxColumn, Me.Total1DataGridViewTextBoxColumn, Me.Draw2DataGridViewTextBoxColumn, Me.Comm2DataGridViewTextBoxColumn, Me.Net2DataGridViewTextBoxColumn, Me.Hits2DataGridViewTextBoxColumn, Me.Total2DataGridViewTextBoxColumn, Me.Draw3DataGridViewTextBoxColumn, Me.Comm3DataGridViewTextBoxColumn, Me.Net3DataGridViewTextBoxColumn, Me.Hits3DataGridViewTextBoxColumn, Me.Total3DataGridViewTextBoxColumn, Me.OverallgrossDataGridViewTextBoxColumn, Me.OverallcommDataGridViewTextBoxColumn, Me.OverallnetDataGridViewTextBoxColumn, Me.OverallhitsDataGridViewTextBoxColumn, Me.RevenueDataGridViewTextBoxColumn})
        Me.dtgImportSales.DataSource = Me.ImportTableBindingSource
        Me.dtgImportSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgImportSales.Location = New System.Drawing.Point(0, 0)
        Me.dtgImportSales.Name = "dtgImportSales"
        Me.dtgImportSales.RowTemplate.Height = 25
        Me.dtgImportSales.Size = New System.Drawing.Size(1042, 427)
        Me.dtgImportSales.TabIndex = 0
        '
        'ImportTableBindingSource
        '
        Me.ImportTableBindingSource.DataSource = GetType(WinFormsApp1.ImportTable)
        '
        'SalesdateDataGridViewTextBoxColumn
        '
        Me.SalesdateDataGridViewTextBoxColumn.DataPropertyName = "salesdate"
        Me.SalesdateDataGridViewTextBoxColumn.HeaderText = "salesdate"
        Me.SalesdateDataGridViewTextBoxColumn.Name = "SalesdateDataGridViewTextBoxColumn"
        '
        'ClusterDataGridViewTextBoxColumn
        '
        Me.ClusterDataGridViewTextBoxColumn.DataPropertyName = "cluster"
        Me.ClusterDataGridViewTextBoxColumn.HeaderText = "cluster"
        Me.ClusterDataGridViewTextBoxColumn.Name = "ClusterDataGridViewTextBoxColumn"
        '
        'MunicipalityDataGridViewTextBoxColumn
        '
        Me.MunicipalityDataGridViewTextBoxColumn.DataPropertyName = "municipality"
        Me.MunicipalityDataGridViewTextBoxColumn.HeaderText = "municipality"
        Me.MunicipalityDataGridViewTextBoxColumn.Name = "MunicipalityDataGridViewTextBoxColumn"
        '
        'RiderDataGridViewTextBoxColumn
        '
        Me.RiderDataGridViewTextBoxColumn.DataPropertyName = "rider"
        Me.RiderDataGridViewTextBoxColumn.HeaderText = "rider"
        Me.RiderDataGridViewTextBoxColumn.Name = "RiderDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'CoordinatorDataGridViewTextBoxColumn
        '
        Me.CoordinatorDataGridViewTextBoxColumn.DataPropertyName = "coordinator"
        Me.CoordinatorDataGridViewTextBoxColumn.HeaderText = "coordinator"
        Me.CoordinatorDataGridViewTextBoxColumn.Name = "CoordinatorDataGridViewTextBoxColumn"
        '
        'AgentDataGridViewTextBoxColumn
        '
        Me.AgentDataGridViewTextBoxColumn.DataPropertyName = "agent"
        Me.AgentDataGridViewTextBoxColumn.HeaderText = "agent"
        Me.AgentDataGridViewTextBoxColumn.Name = "AgentDataGridViewTextBoxColumn"
        '
        'CommDataGridViewTextBoxColumn
        '
        Me.CommDataGridViewTextBoxColumn.DataPropertyName = "comm"
        Me.CommDataGridViewTextBoxColumn.HeaderText = "comm"
        Me.CommDataGridViewTextBoxColumn.Name = "CommDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'Draw1DataGridViewTextBoxColumn
        '
        Me.Draw1DataGridViewTextBoxColumn.DataPropertyName = "draw1"
        Me.Draw1DataGridViewTextBoxColumn.HeaderText = "draw1"
        Me.Draw1DataGridViewTextBoxColumn.Name = "Draw1DataGridViewTextBoxColumn"
        '
        'Comm1DataGridViewTextBoxColumn
        '
        Me.Comm1DataGridViewTextBoxColumn.DataPropertyName = "comm1"
        Me.Comm1DataGridViewTextBoxColumn.HeaderText = "comm1"
        Me.Comm1DataGridViewTextBoxColumn.Name = "Comm1DataGridViewTextBoxColumn"
        '
        'Net1DataGridViewTextBoxColumn
        '
        Me.Net1DataGridViewTextBoxColumn.DataPropertyName = "net1"
        Me.Net1DataGridViewTextBoxColumn.HeaderText = "net1"
        Me.Net1DataGridViewTextBoxColumn.Name = "Net1DataGridViewTextBoxColumn"
        '
        'Hits1DataGridViewTextBoxColumn
        '
        Me.Hits1DataGridViewTextBoxColumn.DataPropertyName = "hits1"
        Me.Hits1DataGridViewTextBoxColumn.HeaderText = "hits1"
        Me.Hits1DataGridViewTextBoxColumn.Name = "Hits1DataGridViewTextBoxColumn"
        '
        'Total1DataGridViewTextBoxColumn
        '
        Me.Total1DataGridViewTextBoxColumn.DataPropertyName = "total1"
        Me.Total1DataGridViewTextBoxColumn.HeaderText = "total1"
        Me.Total1DataGridViewTextBoxColumn.Name = "Total1DataGridViewTextBoxColumn"
        '
        'Draw2DataGridViewTextBoxColumn
        '
        Me.Draw2DataGridViewTextBoxColumn.DataPropertyName = "draw2"
        Me.Draw2DataGridViewTextBoxColumn.HeaderText = "draw2"
        Me.Draw2DataGridViewTextBoxColumn.Name = "Draw2DataGridViewTextBoxColumn"
        '
        'Comm2DataGridViewTextBoxColumn
        '
        Me.Comm2DataGridViewTextBoxColumn.DataPropertyName = "comm2"
        Me.Comm2DataGridViewTextBoxColumn.HeaderText = "comm2"
        Me.Comm2DataGridViewTextBoxColumn.Name = "Comm2DataGridViewTextBoxColumn"
        '
        'Net2DataGridViewTextBoxColumn
        '
        Me.Net2DataGridViewTextBoxColumn.DataPropertyName = "net2"
        Me.Net2DataGridViewTextBoxColumn.HeaderText = "net2"
        Me.Net2DataGridViewTextBoxColumn.Name = "Net2DataGridViewTextBoxColumn"
        '
        'Hits2DataGridViewTextBoxColumn
        '
        Me.Hits2DataGridViewTextBoxColumn.DataPropertyName = "hits2"
        Me.Hits2DataGridViewTextBoxColumn.HeaderText = "hits2"
        Me.Hits2DataGridViewTextBoxColumn.Name = "Hits2DataGridViewTextBoxColumn"
        '
        'Total2DataGridViewTextBoxColumn
        '
        Me.Total2DataGridViewTextBoxColumn.DataPropertyName = "total2"
        Me.Total2DataGridViewTextBoxColumn.HeaderText = "total2"
        Me.Total2DataGridViewTextBoxColumn.Name = "Total2DataGridViewTextBoxColumn"
        '
        'Draw3DataGridViewTextBoxColumn
        '
        Me.Draw3DataGridViewTextBoxColumn.DataPropertyName = "draw3"
        Me.Draw3DataGridViewTextBoxColumn.HeaderText = "draw3"
        Me.Draw3DataGridViewTextBoxColumn.Name = "Draw3DataGridViewTextBoxColumn"
        '
        'Comm3DataGridViewTextBoxColumn
        '
        Me.Comm3DataGridViewTextBoxColumn.DataPropertyName = "comm3"
        Me.Comm3DataGridViewTextBoxColumn.HeaderText = "comm3"
        Me.Comm3DataGridViewTextBoxColumn.Name = "Comm3DataGridViewTextBoxColumn"
        '
        'Net3DataGridViewTextBoxColumn
        '
        Me.Net3DataGridViewTextBoxColumn.DataPropertyName = "net3"
        Me.Net3DataGridViewTextBoxColumn.HeaderText = "net3"
        Me.Net3DataGridViewTextBoxColumn.Name = "Net3DataGridViewTextBoxColumn"
        '
        'Hits3DataGridViewTextBoxColumn
        '
        Me.Hits3DataGridViewTextBoxColumn.DataPropertyName = "hits3"
        Me.Hits3DataGridViewTextBoxColumn.HeaderText = "hits3"
        Me.Hits3DataGridViewTextBoxColumn.Name = "Hits3DataGridViewTextBoxColumn"
        '
        'Total3DataGridViewTextBoxColumn
        '
        Me.Total3DataGridViewTextBoxColumn.DataPropertyName = "total3"
        Me.Total3DataGridViewTextBoxColumn.HeaderText = "total3"
        Me.Total3DataGridViewTextBoxColumn.Name = "Total3DataGridViewTextBoxColumn"
        '
        'OverallgrossDataGridViewTextBoxColumn
        '
        Me.OverallgrossDataGridViewTextBoxColumn.DataPropertyName = "overallgross"
        Me.OverallgrossDataGridViewTextBoxColumn.HeaderText = "overallgross"
        Me.OverallgrossDataGridViewTextBoxColumn.Name = "OverallgrossDataGridViewTextBoxColumn"
        '
        'OverallcommDataGridViewTextBoxColumn
        '
        Me.OverallcommDataGridViewTextBoxColumn.DataPropertyName = "overallcomm"
        Me.OverallcommDataGridViewTextBoxColumn.HeaderText = "overallcomm"
        Me.OverallcommDataGridViewTextBoxColumn.Name = "OverallcommDataGridViewTextBoxColumn"
        '
        'OverallnetDataGridViewTextBoxColumn
        '
        Me.OverallnetDataGridViewTextBoxColumn.DataPropertyName = "overallnet"
        Me.OverallnetDataGridViewTextBoxColumn.HeaderText = "overallnet"
        Me.OverallnetDataGridViewTextBoxColumn.Name = "OverallnetDataGridViewTextBoxColumn"
        '
        'OverallhitsDataGridViewTextBoxColumn
        '
        Me.OverallhitsDataGridViewTextBoxColumn.DataPropertyName = "overallhits"
        Me.OverallhitsDataGridViewTextBoxColumn.HeaderText = "overallhits"
        Me.OverallhitsDataGridViewTextBoxColumn.Name = "OverallhitsDataGridViewTextBoxColumn"
        '
        'RevenueDataGridViewTextBoxColumn
        '
        Me.RevenueDataGridViewTextBoxColumn.DataPropertyName = "revenue"
        Me.RevenueDataGridViewTextBoxColumn.HeaderText = "revenue"
        Me.RevenueDataGridViewTextBoxColumn.Name = "RevenueDataGridViewTextBoxColumn"
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
    Friend WithEvents BarangayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClusterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MunicipalityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RiderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CoordinatorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Draw1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Comm1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Net1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Hits1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Total1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Draw2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Comm2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Net2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Hits2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Total2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Draw3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Comm3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Net3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Hits3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Total3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverallgrossDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverallcommDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverallnetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverallhitsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RevenueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImportTableBindingSource As BindingSource
End Class
