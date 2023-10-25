Imports System
Imports System.IO
Imports System.Windows.Forms
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml

Public Class ExportarpdfProveedor
    Private dataGridView As DataGridView
    Private frmproveedor As FrmProveedor

    Public Sub New(dataGridView As DataGridView, frmproveedor As FrmProveedor)
        Me.dataGridView = dataGridView
        Me.frmproveedor = frmproveedor
    End Sub

    Public Sub ExportarPDF()
        Try
            ' Crear el contenido HTML para el PDF
            Dim htmlContent As String = My.Resources.Proveedor

            ' Rellenar la plantilla HTML con los datos obtenidos del DataGridView
            Dim tableContent As String = ""
            For Each row As DataGridViewRow In dataGridView.Rows
                Dim COD As String = row.Cells("Cod_proveedor").Value.ToString()
                Dim Nombre As String = row.Cells("Nombre").Value.ToString()
                Dim RUC As String = row.Cells("RUC").Value.ToString()
                Dim Dirrecion As String = row.Cells("Direccion").Value.ToString()
                Dim Telefono As String = row.Cells("Telefono").Value.ToString()
                Dim Pagina As String = row.Cells("Pagina").Value.ToString()
                Dim Estado As String = row.Cells("Estado").Value.ToString()
                tableContent += $"<tr><td>{COD}</td><td>{Nombre}</td><td>{RUC}</td><td>{Dirrecion}</td><td>{Telefono}</td><td>{Pagina}</td><td>{Estado}</td></tr>"
            Next

            htmlContent = htmlContent.Replace("{TablaDatos}", tableContent)

            ' Generar el PDF usando iTextSharp
            Dim pdfBytes As Byte()
            Using stream As New MemoryStream()
                Using document As New Document()
                    Using writer As PdfWriter = PdfWriter.GetInstance(document, stream)
                        document.Open()

                        Using stringReader As New StringReader(htmlContent)
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, stringReader)
                        End Using

                        document.Close()
                    End Using
                End Using

                pdfBytes = stream.ToArray()
            End Using

            ' Mostrar el cuadro de diálogo de guardar archivo
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
            saveFileDialog.Title = "Guardar PDF"
            saveFileDialog.ShowDialog()

            If Not String.IsNullOrEmpty(saveFileDialog.FileName) Then
                File.WriteAllBytes(saveFileDialog.FileName, pdfBytes)
                MessageBox.Show("PDF generado correctamente.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al generar el PDF: " & ex.Message)
        End Try
    End Sub
End Class