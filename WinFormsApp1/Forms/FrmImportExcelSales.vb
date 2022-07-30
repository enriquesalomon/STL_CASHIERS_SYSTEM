Imports System.IO
Imports ExcelDataReader
Imports Z.Dapper.Plus
Public Class FrmImportExcelSales
    Dim tables As DataTableCollection

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try

            dtgImportSales.Rows.Clear()
            txtFilename.Text = ""

            Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls"}
                If ofd.ShowDialog = DialogResult.OK Then
                    txtFilename.Text = ofd.FileName
                    Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                        Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                            Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                    .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                    .UseHeaderRow = True}})
                            tables = result.Tables
                            cboSheet.Items.Clear()
                            For Each table As DataTable In tables
                                cboSheet.Items.Add(table.TableName)
                            Next
                        End Using
                    End Using

                End If
            End Using
        Catch ex As Exception


            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Try




            Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
            'dtgImportSales.DataSource = dt
            If dt IsNot Nothing Then



                Dim list As List(Of ImportTable) = New List(Of ImportTable)()


                For i As Integer = 0 To dt.Rows.Count - 1

                    Dim importable As ImportTable = New ImportTable()
                    importable.salesdate = dt.Rows(i)("DATE").ToString()
                    importable.cluster = dt.Rows(i)("CLUSTER").ToString()
                    importable.municipality = dt.Rows(i)("BARANGAY").ToString()
                    importable.rider = dt.Rows(i)("RIDER").ToString()
                    importable.type = dt.Rows(i)("TYPE").ToString()
                    importable.coordinator = dt.Rows(i)("COORDINATOR").ToString()
                    importable.agent = dt.Rows(i)("AGENT").ToString()
                    importable.comm = dt.Rows(i)("COMM.(%)").ToString()
                    importable.username = dt.Rows(i)("USERNAME").ToString()

                    importable.draw1 = dt.Rows(i)("DRAW 1").ToString()
                    importable.comm1 = dt.Rows(i)("COMM").ToString()
                    importable.net1 = dt.Rows(i)("NET").ToString()
                    importable.hits1 = dt.Rows(i)("HITS").ToString()
                    importable.total1 = dt.Rows(i)("TOTAL").ToString()

                    importable.draw2 = dt.Rows(i)("DRAW 2").ToString()
                    importable.comm2 = dt.Rows(i)("COMM").ToString()
                    importable.net2 = dt.Rows(i)("NET").ToString()
                    importable.hits2 = dt.Rows(i)("HITS").ToString()
                    importable.total2 = dt.Rows(i)("TOTAL").ToString()

                    importable.draw3 = dt.Rows(i)("DRAW 3").ToString()
                    importable.comm3 = dt.Rows(i)("COMM").ToString()
                    importable.net3 = dt.Rows(i)("NET").ToString()
                    importable.hits3 = dt.Rows(i)("HITS").ToString()
                    importable.total3 = dt.Rows(i)("TOTAL").ToString()

                    importable.overallgross = dt.Rows(i)("OVERALL GROSS").ToString()
                    importable.overallcomm = dt.Rows(i)("OVERALL COMM").ToString()
                    importable.overallnet = dt.Rows(i)("OVERALL NET").ToString()
                    importable.overallhits = dt.Rows(i)("OVERALL HITS").ToString()
                    importable.revenue = dt.Rows(i)("REVENUE").ToString()




                    list.Add(importable)
                Next

                ImportTableBindingSource.DataSource = list

            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)

            MessageBox.Show("Invalid Report Format!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        If myimporttable.checkExistingSalesImport Then
            MsgBox("Sales Report already exist!", MsgBoxStyle.Exclamation, "Message")
            Exit Sub
        End If

        Try

            Dim list As List(Of ImportTable) = TryCast(ImportTableBindingSource.DataSource, List(Of ImportTable))
            If list IsNot Nothing Then


                DapperPlusManager.Entity(Of ImportTable).Table("tb_SalesSummaryImported")
                Using db As IDbConnection = New SqlClient.SqlConnection(mstring)

                    db.BulkInsert(list)


                End Using
                MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtgImportSales.Rows.Clear()
                txtFilename.Clear()
                cboSheet.Text = ""

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
        '    ProgressBar1.Value += 10
        'End If
    End Sub

    Private Sub FrmImportExcelSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Location = New Point((Me.Width - ProgressBar1.Width) \ 2, (Me.Height - ProgressBar1.Height) \ 2)
    End Sub

    Private Sub dtgImportSales_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtgImportSales.CellEnter
        If dtgImportSales.Rows.Count > 0 Then
            lblrec.Text = "RECORD COUNT: " & (dtgImportSales.CurrentRow.Index) + 1 & " of " & dtgImportSales.Rows.Count
        End If
    End Sub
End Class