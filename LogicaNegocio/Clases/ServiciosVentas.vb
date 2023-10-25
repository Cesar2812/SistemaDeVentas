Imports AccesoDatos
Imports System.Data.SqlClient
Public Class ServiciosVentas
    Private VentaDatos As DVentas = New DVentas()

    Public Function BuscarVentaPorNFactura(NFactura As String) As SqlDataReader
        Return VentaDatos.BuscarPorNFactura(NFactura)
    End Function

    Public Sub EditarVenta(NFactura As String, Fecha As String, CodCliente As String, Descuento As Double, MontoTotal As Double)
        VentaDatos.Editar_Venta(NFactura, Fecha, CodCliente, Descuento, MontoTotal)
    End Sub

    Public Sub EliminarVenta(NFactura As String)
        VentaDatos.Eliminar_Venta(NFactura)
    End Sub

    Public Sub InsertarNuevaVenta(NFactura As String, Fecha As String, CodCliente As String, Descuento As Double, MontoTotal As Double, Estado As String)
        VentaDatos.Insertar_Venta(NFactura, Fecha, CodCliente, Descuento, MontoTotal, Estado)
    End Sub

    Public Function GenerarCodigoVentas() As String
        Return VentaDatos.GenerarCodigoVenta()
    End Function

    Public Function TablaVentas(query As String) As DataTable
        Return VentaDatos.Tabla(query)
    End Function
    Public Function ObtenerdetalleporId(NFactura As String) As DataTable
        Return VentaDatos.ObtenerDetallePorCompra(NFactura)
    End Function
End Class
