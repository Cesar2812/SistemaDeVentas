
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml


Public Class MostrarebWeb
    'Private dataGridView As DataGridView

    'Public Sub New(dataGridView As DataGridView, frmProductos As FrmProductos)
    '    Me.dataGridView = dataGridView
    'End Sub

    Public Sub MostrarFacturaEnWebBrowser(dt_compra As DataGridView, dt_detallecompra As DataGridView, web As WebBrowser)
        Try
            ' Crear el contenido HTML para la factura
            Dim htmlContent As String = My.Resources.Factura

            ' Obtener los datos de la fila seleccionada en el DataGridView de Compra
            If dt_compra.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dt_compra.SelectedRows(0)
                Dim NFactura As String = selectedRow.Cells("NFactura").Value.ToString()
                Dim Fecha As String = selectedRow.Cells("Fecha").Value.ToString()
                Dim CodProveedor As String = selectedRow.Cells("CodProveedor").Value.ToString()
                Dim Descuento As String = selectedRow.Cells("Descuento").Value.ToString()
                Dim MontoTotal As String = selectedRow.Cells("MontoTotal").Value.ToString()

                ' Reemplazar los marcadores de posición en la plantilla HTML con los datos
                htmlContent = htmlContent.Replace("{NFactura}", NFactura)
                htmlContent = htmlContent.Replace("{Fecha}", Fecha)
                htmlContent = htmlContent.Replace("{CodProveedor}", CodProveedor)
                htmlContent = htmlContent.Replace("{Descuento}", Descuento)
                htmlContent = htmlContent.Replace("{MontoTotal}", MontoTotal)

                ' Construir el contenido de la tabla de detalles de compra desde el DataGridView de DetalleCompra
                Dim tableContent As String = ""
                For Each row As DataGridViewRow In dt_detallecompra.Rows
                    Dim Cod_detalle As String = row.Cells("Cod_detalle").Value.ToString()
                    Dim Factura As String = row.Cells("Factura").Value.ToString()
                    Dim CodProducto As String = row.Cells("CodProducto").Value.ToString()
                    Dim MontoxProducto As String = row.Cells("MontoxProducto").Value.ToString()

                    tableContent += $"<tr><td>{CodProducto}</td><td>{Factura}</td><td>{Cod_detalle}</td><td>{MontoxProducto}</td></tr>"
                Next

                ' Reemplazar el marcador de posición de la tabla de detalles en la plantilla HTML
                htmlContent = htmlContent.Replace("{TablaDatos}", tableContent)

                ' Cargar el contenido HTML en el control WebBrowser
                web.DocumentText = htmlContent
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al mostrar la factura en el WebBrowser: " & ex.Message)
        End Try
    End Sub

End Class
