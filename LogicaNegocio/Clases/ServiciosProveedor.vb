Imports System.Data.SqlClient
Imports AccesoDatos

Public Class ServiciosProveedor

    Private ProveedorDatos As DProveedor = New DProveedor()

    Public Function ObtenerProveedorPorId(IdPropietario As String) As SqlDataReader
        Return ProveedorDatos.BuscarxId(IdPropietario)
    End Function
    Public Sub EditarProveedor(codProveedor As String, nombre As String, ruc As String, direccion As String, telefono As String, pagina As String)
        ProveedorDatos.Editar_Proveedor(codProveedor, nombre, ruc, direccion, telefono, pagina)
    End Sub
    Public Sub EliminarProveedor(IdProveedor As String)
        ProveedorDatos.Eliminar_Proveedor(IdProveedor)
    End Sub
    Public Sub InsertarNuevoPropietario(Nombre As String, RUC As String, Direccion As String, Telefono As String, Pagina As String, Estado As String)
        Dim nuevoCodigo As String = ProveedorDatos.GenerarCodigoProveedor()
        ProveedorDatos.Insertar_Proveedor(nuevoCodigo, Nombre, RUC, Direccion, Telefono, Pagina, Estado)
    End Sub
    Public Function GenerarCodigoProveedor() As String
        Return ProveedorDatos.GenerarCodigoProveedor()
    End Function

    Public Function TablaProveedor(query As String) As DataTable
        Return ProveedorDatos.Tabla(query)
    End Function
End Class
