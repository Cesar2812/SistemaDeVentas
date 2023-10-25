Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Importar
    Public Shared Sub ImportExcelToDataGridView(ByVal filePath As String, ByVal dataGridView As DataGridView)
        Dim excelApp As Excel.Application = Nothing
        Dim excelWorkbook As Excel.Workbook = Nothing
        Dim excelWorksheet As Excel.Worksheet = Nothing

        Try
            excelApp = New Excel.Application()
            excelWorkbook = excelApp.Workbooks.Open(filePath)
            excelWorksheet = CType(excelWorkbook.Sheets(1), Excel.Worksheet) ' Suponiendo que los datos están en la primera hoja.

            Dim rowCount As Integer = excelWorksheet.UsedRange.Rows.Count
            Dim colCount As Integer = excelWorksheet.UsedRange.Columns.Count

            dataGridView.Rows.Clear()
            dataGridView.Columns.Clear()

            For col As Integer = 1 To colCount
                dataGridView.Columns.Add("Column" & col, "Column" & col)
            Next

            For row As Integer = 1 To rowCount
                Dim dataGridViewRow As New DataGridViewRow()
                For col As Integer = 1 To colCount
                    dataGridViewRow.Cells.Add(New DataGridViewTextBoxCell() With {
                        .Value = excelWorksheet.Cells(row, col).Value
                    })
                Next
                dataGridView.Rows.Add(dataGridViewRow)
            Next
        Catch ex As Exception
            MessageBox.Show("Error al importar el archivo Excel: " & ex.Message)
        Finally
            Marshal.ReleaseComObject(excelWorksheet)
            excelWorkbook.Close()
            Marshal.ReleaseComObject(excelWorkbook)
            excelApp.Quit()
            Marshal.ReleaseComObject(excelApp)
        End Try
    End Sub
End Class
