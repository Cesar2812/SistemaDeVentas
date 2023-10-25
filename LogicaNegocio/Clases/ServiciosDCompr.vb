Imports AccesoDatos

Public Class ServiciosDCompr
    Private DetalleCompraDatos As DCompraDetalle = New DCompraDetalle()

    Public Function GenerarCodigoDetalleVenta() As String
        Return DetalleCompraDatos.GenerarCodigoDetallecompra()
    End Function

    Public Sub InsertarDetalleVenta(CodDetalle As String, Factura As String, CodProducto As String, Cantidad As Double, MontoxProducto As Double)
        DetalleCompraDatos.Insertar_DetalleCompra(CodDetalle, Factura, CodProducto, Cantidad, MontoxProducto)
    End Sub

    Public Sub EditarDetalleVenta(CodDetalle As String, Factura As String, CodProducto As String, Cantidad As Double, MontoxProducto As Double)
        DetalleCompraDatos.Editar_DetalleCompra(CodDetalle, Factura, CodProducto, Cantidad, MontoxProducto)
    End Sub

    Public Sub EliminarDetalleVenta(CodDetalle As String)
        DetalleCompraDatos.Eliminar_DetalleCompra(CodDetalle)
    End Sub

    Public Function ObtenerDetallesPorFactura(Factura As String) As DataTable
        Return DetalleCompraDatos.ObtenerDetallesPorFactura(Factura)
    End Function

    Public Function ObtenerTablaDetalleCompra(Query As String)
        Return DetalleCompraDatos.Tablas(Query)
    End Function

End Class
