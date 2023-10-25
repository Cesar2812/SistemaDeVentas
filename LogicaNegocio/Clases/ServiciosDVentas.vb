Imports AccesoDatos

Public Class ServiciosDVentas


    Private DetalleVentaDatos As DVentadetalle = New DVentadetalle()

    Public Function GenerarCodigoDetalleVenta() As String
        Return DetalleVentaDatos.GenerarCodigoDetalleVenta()
    End Function

    Public Sub InsertarDetalleVenta(CodDetalle As String, Factura As String, CodProducto As String, Cantidad As Double, MontoxProducto As Double)
        DetalleVentaDatos.Insertar_DetalleVenta(CodDetalle, Factura, CodProducto, Cantidad, MontoxProducto)
    End Sub

    Public Sub EditarDetalleVenta(CodDetalle As String, Factura As String, CodProducto As String, Cantidad As Double, MontoxProducto As Double)
        DetalleVentaDatos.Editar_DetalleVenta(CodDetalle, Factura, CodProducto, Cantidad, MontoxProducto)
    End Sub

    Public Sub EliminarDetalleVenta(CodDetalle As String)
        DetalleVentaDatos.Eliminar_DetalleVenta(CodDetalle)
    End Sub

    Public Function ObtenerDetallesPorFactura(Factura As String) As DataTable
        Return DetalleVentaDatos.ObtenerDetallesPorFactura(Factura)
    End Function



End Class
