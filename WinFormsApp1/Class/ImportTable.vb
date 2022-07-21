Public Class ImportTable
    'Public Property Cluster As String
    'Public Property Barangay As String
    'Public Property Rider As String
    'Public Property Type As String
    'Public Property Coordinator As String
    'Public Property Agent As String
    'Public Property Comm As String
    'Public Property Username As String



    Public Property salesdate As Date
    Public Property cluster As String
    Public Property municipality As String
    Public Property rider As String
    Public Property type As String
    Public Property coordinator As String
    Public Property agent As String
    Public Property comm As String
    Public Property username As String
    Public Property draw1 As String
    Public Property comm1 As String
    Public Property net1 As String
    Public Property hits1 As String
    Public Property total1 As String
    Public Property draw2 As String
    Public Property comm2 As String
    Public Property net2 As String
    Public Property hits2 As String
    Public Property total2 As String
    Public Property draw3 As String
    Public Property comm3 As String
    Public Property net3 As String
    Public Property hits3 As String
    Public Property total3 As String
    Public Property overallgross As String
    Public Property overallcomm As String
    Public Property overallnet As String
    Public Property overallhits As String
    Public Property revenue As String



    Public Function checkExistingSalesImport() As Boolean

        Dim salesdatInExceltoImport As String
        Dim GridRow As DataGridViewRow = FrmImportExcelSales.dtgImportSales.CurrentRow
        For Each datagrd As DataGridViewRow In FrmImportExcelSales.dtgImportSales.SelectedRows
            salesdatInExceltoImport = Format(CDate(FrmImportExcelSales.dtgImportSales.Item(0, 0).Value.ToString()), "yyyy-MM-dd")

        Next datagrd



        Dim ntable As New DataTable
        Dim ndataset As New DataSet



        Try
            Call connectSQL(conString)
            mycommand = mysqlconn.CreateCommand
            mycommand.CommandText = "select  *  from [tb_SalesSummaryImported]  where SALESDATE='" & salesdatInExceltoImport & "'"

            myadapter.SelectCommand = mycommand
            myadapter.Fill(ndataset, "tb_SalesSummaryImported")
            ntable = ndataset.Tables("tb_SalesSummaryImported")

            If ntable.Rows.Count > 0 Then
                checkExistingSalesImport = True
            Else
                checkExistingSalesImport = False
            End If
            ntable.Rows.Clear()
            ndataset.Clear()

        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Error !!")
        End Try

    End Function
End Class
