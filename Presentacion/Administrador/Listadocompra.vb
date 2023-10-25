
Imports LogicaNegocio
Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Public Class Listadocompra

    Private compra As New ServiciosCompras()
    Private detalle_compra As New ServiciosDCompr()


    'Private Sub ExportarTablasAExcel()
    '    ' Crear una instancia de SaveFileDialog para que el usuario elija la ubicación y el nombre del archivo
    '    Dim saveFileDialog As New SaveFileDialog()
    '    saveFileDialog.Filter = "Archivos de Excel|*.xlsx"
    '    saveFileDialog.Title = "Guardar archivo de Excel"
    '    saveFileDialog.ShowDialog()

    '    ' Comprobar si el usuario hizo una selección
    '    If saveFileDialog.FileName <> "" Then
    '        ' Crear una instancia de Excel
    '        Dim excelApp As New Excel.Application()
    '        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
    '        Dim excelWorksheet1 As Excel.Worksheet = excelWorkbook.Sheets.Add()
    '        Dim excelWorksheet2 As Excel.Worksheet = excelWorkbook.Sheets.Add()

    '        '' Aquí debes tener las dos tablas: detallecompra y compra
    '        '' Asumiendo que estas tablas son DataTables
    '        'Dim detalleCompraTable As DataTable ' Rellena con tus datos
    '        'Dim compraTable As DataTable ' Rellena con tus datos

    '        ' Exportar la primera tabla a la primera hoja de Excel
    '        ExportarTablaAExcel(dg_compras, excelWorksheet1)

    '        ' Exportar la segunda tabla a la segunda hoja de Excel
    '        ExportarTablaAExcel(dt_detallecompra, excelWorksheet2)

    '        ' Guardar el archivo Excel en la ubicación seleccionada por el usuario
    '        excelWorkbook.SaveAs(saveFileDialog.FileName)

    '        ' Cerrar Excel
    '        excelWorkbook.Close()
    '        excelApp.Quit()
    '    End If
    'End Sub

    'Private Sub ExportarTablaAExcel(dataGridView As DataGridView, excelWorksheet As Excel.Worksheet)
    '    Dim rowIndex As Integer = 1
    '    Dim columnIndex As Integer = 1

    '    ' Copiar los datos de la DataGridView a Excel
    '    For Each row As DataGridViewRow In dataGridView.Rows
    '        If Not row.IsNewRow Then
    '            columnIndex = 1
    '            For Each cell As DataGridViewCell In row.Cells
    '                excelWorksheet.Cells(rowIndex, columnIndex) = cell.Value
    '                columnIndex += 1
    '            Next
    '            rowIndex += 1
    '        End If
    '    Next
    'End Sub




    Private Function ObtenerIDSeleccionado(dataGridView As DataGridView) As String

        If dataGridView.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = dataGridView.SelectedRows(0)
            Dim columnaID As Integer = 0
            Dim valorID As String = filaSeleccionada.Cells(columnaID).Value.ToString()
            Return valorID
        Else
            Return String.Empty
        End If
    End Function

    Public Sub Mostrartodatabla()
        dg_compras.DataSource = compra.TablaCompras("SELECT * FROM Compra")

    End Sub

    Public Sub MostrarTablaDetalleVenta()
        dt_detallecompra.DataSource = detalle_compra.ObtenerTablaDetalleCompra("SELECT * FROM DetalleCompras")
    End Sub

    Private Sub Listadocompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub CargarTelefonosPorCliente(codCliente As String)

        'Dim telefonosDataTable As DataTable = telefono.ObtenercelularPorId(codCliente)
        'Datos_telefono_dgv.DataSource = telefonosDataTable
    End Sub
    Private Sub dg_compras_CellClick(sender As Object, e As DataGridViewCellEventArgs)


        If e.RowIndex >= 0 Then
            Dim NFactura As String = dg_compras.CurrentRow.Cells(0).Value.ToString()
            Dim telefonosDataTable As DataTable = compra.ObtenerdetalleporId(NFactura)

            dt_detallecompra.DataSource = telefonosDataTable
        End If
    End Sub

    Private Sub btn_ListaProductos_Click(sender As Object, e As EventArgs) Handles btn_ListaCompra.Click
        Mostrartodatabla()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Buscar_txt_TextChanged(sender As Object, e As EventArgs) Handles Buscar_txt.TextChanged
    End Sub

    Private Sub dt_detalleventa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dt_detallecompra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_detallecompra.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub dg_compras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dg_compras_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExportarExcel_btn.Click

        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a Excel?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then

            If dg_compras.Rows.Count > 0 AndAlso dt_detallecompra.Rows.Count > 0 Then
                Dim exportadorExce As New ExportarExcel
                exportadorExce.ExportarDataExcel(dt_detallecompra, dg_compras)
            Else
                MessageBox.Show("Ambos DataGridView deben contener datos para exportar a Excel.", "Advertencia")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarTablaDetalleVenta()
    End Sub

    Private Sub Exportarpdf_btn_Click(sender As Object, e As EventArgs) Handles Exportarpdf_btn.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a PDF?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si los DataGridView tienen filas
            If dg_compras.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a PDF.")
            Else
                ' Crear una instancia de la clase ExportarpdfListaCompras
                Dim exportadorPDF As New ExportarpdfListaCompras(dg_compras, dt_detallecompra)

                ' Llamar al método ExportarPDF para permitir al usuario especificar la ruta
                exportadorPDF.ExportarPDF()
            End If
        End If
    End Sub
End Class