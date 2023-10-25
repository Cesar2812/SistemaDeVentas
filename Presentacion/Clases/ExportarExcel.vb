Imports Microsoft.Office.Interop.Excel
Public Class ExportarExcel
    Public Sub ExportarDataExcel(grd As DataGridView)
        Try
            Dim fichero As New SaveFileDialog()
            fichero.Filter = "Excel (.xlsx)|*.xlsx"
            fichero.FileName = "ArchivoExportado"
            If fichero.ShowDialog() = DialogResult.OK Then
                Dim aplicacion As New Microsoft.Office.Interop.Excel.Application()
                Dim libros_trabajo As Workbook = aplicacion.Workbooks.Add()
                Dim hoja_trabajo As Worksheet = DirectCast(libros_trabajo.Worksheets.Item(1), Worksheet)

                ' Obtener los títulos de columna
                For j As Integer = 0 To grd.Columns.Count - 1
                    hoja_trabajo.Cells(1, j + 1) = grd.Columns(j).HeaderText
                Next

                ' Recorrer los datos y rellenar la hoja de trabajo
                Dim valorFila As Integer = 2 ' Comenzar en la fila 2 (debajo del encabezado)
                For i As Integer = 0 To grd.Rows.Count - 1
                    For j As Integer = 0 To grd.Columns.Count - 1
                        If grd.Rows(i).Cells(j).Value IsNot Nothing Then
                            hoja_trabajo.Cells(valorFila, j + 1) = grd.Rows(i).Cells(j).Value.ToString()
                        End If
                    Next
                    valorFila += 1
                Next

                ' Ajustar el ancho de las columnas automáticamente
                hoja_trabajo.Columns.AutoFit()

                ' Obtener el rango de la tabla de datos
                Dim tablaRange As Range = hoja_trabajo.Range(hoja_trabajo.Cells(1, 1), hoja_trabajo.Cells(valorFila - 1, grd.Columns.Count))

                ' Establecer el formato del encabezado
                Dim encabezadoRange As Range = hoja_trabajo.Range(hoja_trabajo.Cells(1, 1), hoja_trabajo.Cells(1, grd.Columns.Count))
                encabezadoRange.Font.Bold = True
                encabezadoRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue)
                encabezadoRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                encabezadoRange.HorizontalAlignment = XlHAlign.xlHAlignCenter

                ' Agregar bordes a toda la tabla
                tablaRange.Borders.LineStyle = XlLineStyle.xlContinuous
                tablaRange.Borders.Weight = XlBorderWeight.xlThin

                ' Guardar el archivo
                libros_trabajo.SaveAs(fichero.FileName, XlFileFormat.xlOpenXMLWorkbook)
                Dim rutaArchivo As String = System.IO.Path.GetFullPath(fichero.FileName) ' Obtener la ruta completa del archivo

                ' Cerrar el archivo
                libros_trabajo.Close()
                aplicacion.Quit()

                MessageBox.Show("La información se exportó correctamente." & vbNewLine & "Archivo guardado en: " & rutaArchivo)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al exportar la información debido a: " & ex.ToString())
        End Try
    End Sub


    Public Sub ExportarDataExcel(ByVal grd1 As DataGridView, ByVal grd2 As DataGridView)
        Try
            Dim fichero As New SaveFileDialog()
            fichero.Filter = "Excel (.xlsx)|*.xlsx"
            fichero.FileName = "ArchivoExportado"
            If fichero.ShowDialog() = DialogResult.OK Then
                Dim aplicacion As New Microsoft.Office.Interop.Excel.Application()
                Dim libros_trabajo As Workbook = aplicacion.Workbooks.Add()

                ' Exportar el primer DataGridView a la primera hoja con un título
                ExportarDataGridViewAGrilla(grd1, libros_trabajo.Worksheets.Item(1), "Listado compra")

                ' Crear una nueva hoja de trabajo para el segundo DataGridView
                Dim hoja_trabajo2 As Worksheet = DirectCast(libros_trabajo.Worksheets.Add(), Worksheet)

                ' Exportar el segundo DataGridView a la segunda hoja con un título
                ExportarDataGridViewAGrilla(grd2, hoja_trabajo2, "Listado detallecompra")

                ' Guardar el archivo
                libros_trabajo.SaveAs(fichero.FileName, XlFileFormat.xlOpenXMLWorkbook)
                Dim rutaArchivo As String = System.IO.Path.GetFullPath(fichero.FileName) ' Obtener la ruta completa del archivo

                ' Cerrar el archivo
                libros_trabajo.Close()
                aplicacion.Quit()

                MessageBox.Show("La información se exportó correctamente." & vbNewLine & "Archivo guardado en: " & rutaArchivo)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al exportar la información debido a: " & ex.ToString())
        End Try
    End Sub

    Private Sub ExportarDataGridViewAGrilla(ByVal grd As DataGridView, ByVal hoja_trabajo As Worksheet, ByVal sheetTitle As String)
        ' Agregar un título a la hoja de trabajo
        hoja_trabajo.Name = sheetTitle

        ' Obtener los encabezados de las columnas
        For j As Integer = 0 To grd.Columns.Count - 1
            hoja_trabajo.Cells(2, j + 1) = grd.Columns(j).HeaderText
        Next


        For j As Integer = 0 To grd.Columns.Count - 1
            hoja_trabajo.Cells(1, j + 1) = grd.Columns(j).HeaderText
        Next

        ' Recorrer los datos y rellenar la hoja de trabajo
        Dim valorFila As Integer = 2 ' Comenzar en la fila 2 (debajo del encabezado)
        For i As Integer = 0 To grd.Rows.Count - 1
            For j As Integer = 0 To grd.Columns.Count - 1
                If grd.Rows(i).Cells(j).Value IsNot Nothing Then
                    hoja_trabajo.Cells(valorFila, j + 1) = grd.Rows(i).Cells(j).Value.ToString()
                End If
            Next
            valorFila += 1
        Next

        ' Ajustar el ancho de las columnas automáticamente
        hoja_trabajo.Columns.AutoFit()

        ' Obtener el rango de la tabla de datos
        Dim tablaRange As Range = hoja_trabajo.Range(hoja_trabajo.Cells(1, 1), hoja_trabajo.Cells(valorFila - 1, grd.Columns.Count))

        ' Establecer el formato del encabezado
        Dim encabezadoRange As Range = hoja_trabajo.Range(hoja_trabajo.Cells(1, 1), hoja_trabajo.Cells(1, grd.Columns.Count))
        encabezadoRange.Font.Bold = True
        encabezadoRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue)
        encabezadoRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
        encabezadoRange.HorizontalAlignment = XlHAlign.xlHAlignCenter

        ' Agregar bordes a toda la tabla
        tablaRange.Borders.LineStyle = XlLineStyle.xlContinuous
        tablaRange.Borders.Weight = XlBorderWeight.xlThin
    End Sub




End Class
