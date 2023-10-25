Imports AccesoDatos
Imports System.Data.SqlClient
Public Class ServiciosDUsuarios
    Private UsuariosDatos As DUsuarios = New DUsuarios()
    Public Sub InsertarUsuario(IdUsuario As String, IdRol As String, Fecha As DateTime, Nombre As String, Username As String, Clave As String)
        UsuariosDatos.Insertar_Usuario(IdUsuario, IdRol, Fecha, Nombre, Username, Clave)
    End Sub

    Public Sub EditarUsuario(IdUsuario As String, IdRol As String, Fecha As DateTime, Nombre As String, Username As String, Clave As String)
        UsuariosDatos.Editar_Usuario(IdUsuario, IdRol, Fecha, Nombre, Username, Clave)
    End Sub

    Public Sub EliminarUsuario(IdUsuario As String)
        UsuariosDatos.Eliminar_Usuario(IdUsuario)
    End Sub

    Public Function BuscarUsuarioPorId(IdUsuario As String) As SqlDataReader
        Return UsuariosDatos.BuscarPorId(IdUsuario)
    End Function

    Public Function GenerarCodigoUsuario() As String
        Return UsuariosDatos.GenerarCodigoUsuario()
    End Function

    Public Function TablaUsuario(query As String) As DataTable
        Return UsuariosDatos.Tabla(query)
    End Function
End Class