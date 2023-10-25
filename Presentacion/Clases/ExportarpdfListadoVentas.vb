Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
Imports System.IO
Imports System.Text

Public Class ExportarpdfListadoVentas
    Private dataGridView1 As DataGridView
    Private dataGridView2 As DataGridView

    Public Sub New(dataGridView1 As DataGridView, dataGridView2 As DataGridView)
        Me.dataGridView1 = dataGridView1
        Me.dataGridView2 = dataGridView2
    End Sub

    Public Sub ExportarPDF()
        Try
            ' Mostrar el cuadro de diálogo de guardar archivo
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos PDF (.pdf)|.pdf"
            saveFileDialog.Title = "Guardar PDF"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName

                Dim document As New Document()
                Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))
                document.Open()

                ' Leer el contenido de tu plantilla HTML desde los recursos del sistema
                Dim plantillaHTML As String = My.Resources.ExportarpdfListaVenta

                ' Reemplazar las etiquetas {TablaDatos} o {Tabla_Datos} según corresponda
                Dim etiquetaTabla1 As String = "{TablaDatos}"
                Dim etiquetaTabla2 As String = "{Tabla_Datos}"
                Dim contenidoHTML As String = plantillaHTML.Replace(etiquetaTabla1, ObtenerTablaHTML(dataGridView1))
                contenidoHTML = contenidoHTML.Replace(etiquetaTabla2, ObtenerTablaHTML(dataGridView2))

                ' Agregar un espacio entre las tablas
                contenidoHTML = contenidoHTML.Replace("{EspacioEntreTablas}", "<div style='margin-top: 20px;'></div>")

                ' Crear un lector de HTML
                Dim sr As New StringReader(contenidoHTML)
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr)

                ' Cerrar el documento
                document.Close()

                MessageBox.Show("PDF generado correctamente en: " & filePath)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al generar el PDF: " & ex.ToString)
        End Try
    End Sub

    Private Sub CrearTablaPDF(writer As PdfWriter, document As Document, tablaHTML As String)
        ' Crear un lector de HTML
        Dim sr As New StringReader(tablaHTML)
        XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr)
    End Sub

    ' Método para convertir un DataGridView en una tabla HTML
    Private Function ObtenerTablaHTML(dataGridView As DataGridView) As String
        Dim tableHTML As New StringBuilder()

        ' Iniciar la tabla
        tableHTML.Append("<table>")

        ' Agregar encabezados de columna
        tableHTML.Append("<thead><tr>")
        For Each column As DataGridViewColumn In dataGridView.Columns
            tableHTML.AppendFormat("<th>{0}</th>", column.HeaderText)
        Next
        tableHTML.Append("</tr></thead>")

        ' Agregar filas de datos
        tableHTML.Append("<tbody>")
        For Each row As DataGridViewRow In dataGridView.Rows
            tableHTML.Append("<tr>")
            For Each cell As DataGridViewCell In row.Cells
                tableHTML.AppendFormat("<td>{0}</td>", cell.Value.ToString())
            Next
            tableHTML.Append("</tr>")
        Next
        tableHTML.Append("</tbody>")

        ' Cerrar la tabla
        tableHTML.Append("</table>")

        Return tableHTML.ToString()
    End Function

    Private Sub CrearHojaPDF(writer As PdfWriter, document As Document, dataGridView As DataGridView, hojaNombre As String)
        ' Agregar una nueva página antes de crear la hoja
        document.NewPage()

        ' Leer el contenido de tu plantilla HTML desde los recursos del sistema
        Dim plantillaHTML As String = My.Resources.ExportarpdfListadoCompras

        ' Reemplazar las etiquetas {TablaDatos} o {Tabla_Datos} según corresponda
        Dim etiquetaTabla As String = If(dataGridView Is dataGridView1, "{TablaDatos}", "{Tabla_Datos}")
        Dim contenidoHTML As String = plantillaHTML.Replace(etiquetaTabla, ObtenerTablaHTML(dataGridView))

        ' Agregar el nombre de la hoja como título
        contenidoHTML = "<h1>" & hojaNombre & "</h1>" & contenidoHTML

        ' Crear un lector de HTML
        Dim sr As New StringReader(contenidoHTML)
        XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr)
    End Sub
End Class
