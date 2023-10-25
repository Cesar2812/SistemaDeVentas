Imports AccesoDatos
Imports System.Data.SqlClient

Public Class ServiciosCompras
    Private CompraDatos As DCompra = New DCompra()

    Public Function BuscarCompraPorNFactura(NFactura As String) As SqlDataReader
        Return CompraDatos.BuscarPorNFactura(NFactura)
    End Function

    Public Sub EditarCompra(NFactura As String, Fecha As String, CodCliente As String, MontoTotal As Double)
        CompraDatos.Editar_Compra(NFactura, Fecha, CodCliente, MontoTotal)
    End Sub

    Public Sub EliminarCompra(NFactura As String)
        CompraDatos.Eliminar_Compra(NFactura)
    End Sub

    Public Sub InsertarNuevaCompra(NFactura As String, Fecha As String, CodCliente As String, Descuento As Double, MontoTotal As Double, Estado As String)
        CompraDatos.Insertar_Compra(NFactura, Fecha, CodCliente, Descuento, MontoTotal, Estado)
    End Sub
    Public Function TablaCompras(query As String) As DataTable
        Return CompraDatos.Tabla(query)
    End Function
    Public Function ObtenerdetalleporId(NFactura As String) As DataTable
        Return CompraDatos.ObtenerDetallePorCompra(NFactura)
    End Function
End Class
