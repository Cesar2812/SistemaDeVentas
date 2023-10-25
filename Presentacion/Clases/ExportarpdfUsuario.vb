Imports System
Imports System.IO
Imports System.Windows.Forms
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml

Public Class ExportarpdfUsuario
    Private dataGridView As DataGridView
    Private frmusuario As FrmUsuario

    Public Sub New(dataGridView As DataGridView, frmusuario As FrmUsuario)
        Me.dataGridView = dataGridView
        Me.frmusuario = frmusuario
    End Sub

    Public Sub ExportarPDF()
        Try
            ' Crear el contenido HTML para el PDF
            Dim htmlContent As String = My.Resources.Usuario

            ' Rellenar la plantilla HTML con los datos obtenidos del DataGridView
            Dim tableContent As String = ""
            For Each row As DataGridViewRow In dataGridView.Rows
                Dim ID As String = row.Cells("IdUsuario").Value.ToString()
                Dim Rol As String = row.Cells("IdRol").Value.ToString()
                Dim Fecha As String = row.Cells("FechaCreacion").Value.ToString()
                Dim Nombre As String = row.Cells("NombreCompleto").Value.ToString()
                Dim Username As String = row.Cells("Username").Value.ToString()
                Dim Celular As String = row.Cells("Clave").Value.ToString()
                tableContent += $"<tr><td>{ID}</td><td>{Rol}</td><td>{Fecha}</td><td>{Nombre}</td><td>{Username}</td><td>{Celular}</td></tr>"
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