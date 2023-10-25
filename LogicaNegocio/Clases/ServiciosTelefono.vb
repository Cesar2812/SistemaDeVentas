Imports AccesoDatos
Imports System.Data.SqlClient

Public Class ServiciosTelefono

    Private TelefonoDatos As DTelefono = New DTelefono()

    'Public Function ObtenerProveedorPorId(IdTelefono As String) As SqlDataReader
    '    Return TelefonoDatos.BuscarPorId(IdTelefono)
    'End Function
    Public Sub EditarProveedor(Id As String, CodCliente As String, Numero As String, Compania As String)
        TelefonoDatos.Editar_Telefono(Id, CodCliente, Numero, Compania)
    End Sub
    Public Sub EliminarProveedor(Numero As String)
        TelefonoDatos.Eliminar_Telefono_PorNumero(Numero)
    End Sub
    Public Sub InsertarTelefono(Cod_cliente As String, Telefonos As List(Of String), Companias As List(Of String))
        TelefonoDatos.Insertar_Telefono(Cod_cliente, Telefonos, Companias)
    End Sub
    Public Function ObtenercelularPorId(codcliente As String) As DataTable
        Return TelefonoDatos.ObtenerTelefonosPorCliente(codcliente)
    End Function
    Public Function TablaTeñefono(query As String) As DataTable
        Return TelefonoDatos.Tabla(query)
    End Function
End Class
