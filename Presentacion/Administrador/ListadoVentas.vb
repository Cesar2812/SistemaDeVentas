Imports LogicaNegocio

Public Class ListadoVentas

    Private venta As New ServiciosVentas()
    Public Sub Mostrartodatabla()
        dg_compras.DataSource = venta.TablaVentas("SELECT * FROM Ventas")

    End Sub
    Private Sub btn_ListaCompra_Click(sender As Object, e As EventArgs) Handles btn_ListaCompra.Click
        Mostrartodatabla()
    End Sub

    Private Sub dg_compras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_detalleventa.CellClick, dg_compras.CellClick
        If e.RowIndex >= 0 Then
            Dim NFactura As String = dg_compras.CurrentRow.Cells(0).Value.ToString()
            Dim telefonosDataTable As DataTable = venta.ObtenerdetalleporId(NFactura)

            dt_detalleventa.DataSource = telefonosDataTable
        End If
    End Sub

    Private Sub dg_compras_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dg_compras.CellFormatting
        If e.ColumnIndex = dg_compras.Columns("Estado").Index Then
            ' Verifica que e.Value no sea nulo
            If e.Value IsNot Nothing Then
                ' Obtén el valor de la celda actual
                Dim cellValue As String = e.Value.ToString()

                If cellValue = "Realizada" Then
                    e.CellStyle.BackColor = Color.Green
                    e.CellStyle.ForeColor = Color.White
                ElseIf cellValue = "Cancelada" Then
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.ForeColor = Color.White
                End If
            End If
        End If
        'If e.ColumnIndex = dg_compras.Columns("Estado").Index Then
        '    ' Obtén el valor de la celda actual
        '    Dim cellValue As String = e.Value.ToString()
        '    If cellValue = "Realizada" Then
        '        e.CellStyle.BackColor = Color.Green
        '        e.CellStyle.ForeColor = Color.White
        '    ElseIf cellValue = "Cancelada" Then
        '        e.CellStyle.BackColor = Color.Red
        '        e.CellStyle.ForeColor = Color.White
        '    End If
        'End If
    End Sub

    Private Sub ExportarExcel_btn_Click(sender As Object, e As EventArgs) Handles ExportarExcel_btn.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a Excel?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then

            If dg_compras.Rows.Count > 0 AndAlso dt_detalleventa.Rows.Count > 0 Then
                Dim exportadorExce As New ExportarExcel
                exportadorExce.ExportarDataExcel(dt_detalleventa, dg_compras)
            Else
                MessageBox.Show("Ambos DataGridView deben contener datos para exportar a Excel.", "Advertencia")
            End If
        End If
    End Sub

    Private Sub Exportarpdf_btn_Click(sender As Object, e As EventArgs) Handles Exportarpdf_btn.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a PDF?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si los DataGridView tienen filas
            If dg_compras.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a PDF.")
            Else
                ' Crear una instancia de la clase ExportarpdfListaCompras
                Dim exportadorPDF As New ExportarpdfListadoVentas(dg_compras, dt_detalleventa)

                ' Llamar al método ExportarPDF para permitir al usuario especificar la ruta
                exportadorPDF.ExportarPDF()
            End If
        End If
    End Sub
End Class