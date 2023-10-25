Imports AccesoDatos
Imports System.Data.SqlClient
Public Class ServiciosProductos
    Private ProductoDatos As DProductos = New DProductos()

    Public Sub InsertarProducto(Cod_producto As String, Nombre As String, Stock As Double, Precio_compra As Double, Precio_venta As Double, CodCategoria As String, CodProveedor As String, PDefinido As Boolean)
        ProductoDatos.Insertar_Producto(Cod_producto, Nombre, Stock, Precio_compra, Precio_venta, CodCategoria, CodProveedor, PDefinido)
    End Sub
    Public Sub ActualizarPrecioCVStock(Codigo As String, PrecioCompraNuevo As Double, PrecioVentaNuevo As Double, Cantidad As Double, PDefinido As String, CodDetalle As String, NFactura As String)
        ProductoDatos.ActualizarPrecioCVStock(Codigo, PrecioCompraNuevo, PrecioVentaNuevo, Cantidad, PDefinido, CodDetalle, NFactura)
    End Sub

    Public Sub DescontarStock(Codigo As String, Cantidad As Double)
        ProductoDatos.DescontaStock(Codigo, Cantidad)
    End Sub


    Public Sub EditarProducto(Cod_producto As String, Nombre As String, Precio_compra As Double, Precio_venta As Double, CodCategoria As String, CodProveedor As String, PDefinido As String)
        ProductoDatos.Editar_Producto(Cod_producto, Nombre, Precio_compra, Precio_venta, CodCategoria, CodProveedor, PDefinido)
    End Sub

    Public Sub EliminarProducto(Cod_producto As String)
        ProductoDatos.Eliminar_Producto(Cod_producto)
    End Sub

    Public Function BuscarProductoPorId(Cod_producto As String) As SqlDataReader
        Return ProductoDatos.BuscarPorId(Cod_producto)
    End Function

    Public Function GenerarCodigoProducto() As String
        Return ProductoDatos.GenerarCodigoProducto()
    End Function

    Public Function TablaProducto(query As String) As DataTable
        Return ProductoDatos.Tabla(query)
    End Function

End Class
