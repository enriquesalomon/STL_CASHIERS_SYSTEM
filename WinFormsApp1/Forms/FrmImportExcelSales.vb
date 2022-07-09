Imports System.IO
Imports ExcelDataReader
Imports Z.Dapper.Plus
Public Class FrmImportExcelSales
    Dim tables As DataTableCollection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"}
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
    End Sub

    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        'dtgImportSales.DataSource = dt
        If dt IsNot Nothing Then
            Dim list As List(Of ImportTable) = New List(Of ImportTable)()
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim importable As ImportTable = New ImportTable()
                importable.Cluster = dt.Rows(i)("CLUSTER").ToString()
                importable.Barangay = dt.Rows(i)("BARANGAY").ToString()
                importable.Rider = dt.Rows(i)("RIDER").ToString()
                importable.Type = dt.Rows(i)("TYPE").ToString()
                importable.Coordinator = dt.Rows(i)("COORDINATOR").ToString()
                importable.Agent = dt.Rows(i)("AGENT").ToString()
                importable.Comm = dt.Rows(i)("COMM").ToString()
                importable.Username = dt.Rows(i)("USERNAME").ToString()
                list.Add(importable)
            Next
            ImportTableBindingSource.DataSource = list

        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        'Try
        Dim list As List(Of ImportTable) = TryCast(ImportTableBindingSource.DataSource, List(Of ImportTable))
        If list IsNot Nothing Then
            DapperPlusManager.Entity(Of ImportTable).Table("tbl_SampleImport")
            Using db As IDbConnection = New SqlClient.SqlConnection(mstring)
                db.BulkInsert(list)

            End Using
            MessageBox.Show("Finish !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If



        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End Try
    End Sub
End Class