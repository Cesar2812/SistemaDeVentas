Imports System.IO
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml

Public Class ExportarpdfListaCompras
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
                Dim plantillaHTML As String = My.Resources.ExportarpdfListadoCompras

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
            MessageBox.Show("Ocurrió un error al generar el PDF: " & ex.Message)
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









'Imports System.IO
'Imports System.Text
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
'Imports iTextSharp.tool.xml

'Public Class ExportarpdfListaCompras
'    Private dataGridView As DataGridView
'    Private dataGridView2 As DataGridView

'    Public Sub New(dataGridView As DataGridView, dataGridView2 As DataGridView)
'        Me.dataGridView = dataGridView
'        Me.dataGridView2 = dataGridView2
'    End Sub

'    Public Sub ExportarPDF()
'        Try
'            ' Mostrar el cuadro de diálogo de guardar archivo
'            Dim saveFileDialog As New SaveFileDialog()
'            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
'            saveFileDialog.Title = "Guardar PDF"
'            If saveFileDialog.ShowDialog() = DialogResult.OK Then
'                Dim filePath As String = saveFileDialog.FileName

'                Dim document As New Document()
'                Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))
'                document.Open()

'                ' Leer el contenido de tu plantilla HTML
'                Dim plantillaHTML As String = File.ReadAllText("C:\Users\cesar\Desktop\Ventitas\Presentacion\Resources\ExportarpdfListadoCompras.html")

'                ' Reemplazar las etiquetas {TablaDatos} y {Tabla_Datos} con las tablas generadas
'                Dim contenidoHTML As String = plantillaHTML.Replace("{TablaDatos}", ObtenerTablaHTML(dataGridView)).Replace("{Tabla_Datos}", ObtenerTablaHTML(dataGridView2))

'                ' Crear un lector de HTML
'                Dim sr As New StringReader(contenidoHTML)
'                XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr)

'                ' Cerrar el documento
'                document.Close()

'                MessageBox.Show("PDF generado correctamente en: " & filePath)
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Ocurrió un error al generar el PDF: " & ex.Message)
'        End Try
'    End Sub

'    ' Método para convertir un DataGridView en una tabla HTML
'    Private Function ObtenerTablaHTML(dataGridView As DataGridView) As String
'        Dim tableHTML As New StringBuilder()
'        'tableHTML.Append("<table>")
'        'tableHTML.Append("<thead>")
'        'tableHTML.Append("<tr>")
'        For Each column As DataGridViewColumn In dataGridView.Columns
'            tableHTML.AppendFormat("<th>{0}</th>", column.HeaderText)
'        Next
'        'tableHTML.Append("</tr>")
'        'tableHTML.Append("</thead>")
'        'tableHTML.Append("<tbody>")
'        For Each row As DataGridViewRow In dataGridView.Rows
'            tableHTML.Append("<tr>")
'            For Each cell As DataGridViewCell In row.Cells
'                tableHTML.AppendFormat("<td>{0}</td>", cell.Value.ToString())
'            Next
'            tableHTML.Append("</tr>")
'        Next
'        'tableHTML.Append("</tbody>")
'        'tableHTML.Append("</table>")
'        Return tableHTML.ToString()
'    End Function
'End Class


'Public Class ExportarpdfListaCompras
'    Private dataGridView As DataGridView
'    Private dataGridView2 As DataGridView
'    Private frmclistadocompra As Listadocompra

'    Public Sub New(dataGridView As DataGridView, dataGridView2 As DataGridView, frmlistadocompra As Listadocompra)
'        Me.dataGridView = dataGridView
'        Me.dataGridView2 = dataGridView2
'        Me.frmclistadocompra = Listadocompra
'    End Sub

'    Public Sub ExportarPDF()
'        Try
'            ' Crear el contenido HTML para el PDF
'            Dim htmlContent As String = My.Resources.ExportarpdfListadoCompras

'            ' Rellenar la plantilla HTML con los datos obtenidos del DataGridView
'            Dim tableContent As String = ""
'            For Each row As DataGridViewRow In dataGridView.Rows
'                Dim FAC As String = row.Cells("NFactura").Value.ToString()
'                Dim Fecha As String = row.Cells("Fecha").Value.ToString()
'                Dim CodProveedor As String = row.Cells("CodProveedor").Value.ToString()
'                Dim Descuento As String = row.Cells("Descuento").Value.ToString()
'                Dim Monto As String = row.Cells("MontoTotal").Value.ToString()
'                Dim Estado As String = row.Cells("Estado").Value.ToString()
'                tableContent += $"<tr><td>{FAC}</td><td>{Fecha}</td><td>{CodProveedor}</td><td>{Descuento}</td><td>{Monto}</td><td>{Estado}</td></tr>"
'            Next

'            htmlContent = htmlContent.Replace("{TablaDatos}", tableContent)

'            Dim tableConten As String = ""
'            For Each row As DataGridViewRow In dataGridView2.Rows
'                Dim COD As String = row.Cells("Cod_detalle").Value.ToString()
'                Dim Fac As String = row.Cells("Factura").Value.ToString()
'                Dim CodPro As String = row.Cells("CodProducto").Value.ToString()
'                Dim Cantidad As String = row.Cells("Cantidad").Value.ToString()
'                Dim MontoPro As String = row.Cells("MontoxProducto").Value.ToString()
'                tableContent += $"<tr><td>{COD}</td><td>{Fac}</td><td>{CodPro}</td><td>{Cantidad}</td><td>{MontoPro}</td></tr>"
'            Next

'            htmlContent = htmlContent.Replace("{Tabla_Datos}", tableContent)

'            ' Generar el PDF usando iTextSharp
'            Dim pdfBytes As Byte()
'            Using stream As New MemoryStream()
'                Using document As New Document()
'                    Using writer As PdfWriter = PdfWriter.GetInstance(document, stream)
'                        document.Open()

'                        Using stringReader As New StringReader(htmlContent)
'                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, stringReader)
'                        End Using

'                        document.Close()
'                    End Using
'                End Using

'                pdfBytes = stream.ToArray()
'            End Using

'            ' Mostrar el cuadro de diálogo de guardar archivo
'            Dim saveFileDialog As New SaveFileDialog()
'            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
'            saveFileDialog.Title = "Guardar PDF"
'            saveFileDialog.ShowDialog()

'            If Not String.IsNullOrEmpty(saveFileDialog.FileName) Then
'                File.WriteAllBytes(saveFileDialog.FileName, pdfBytes)
'                MessageBox.Show("PDF generado correctamente.")
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Ocurrió un error al generar el PDF: " & ex.ToString)
'        End Try
'    End Sub
'End Class
