Imports System.Data
Imports System.Data.SqlClient


Public Class Credenciales

    Dim conexion As New ConexionSql()
    Public Function VerificarCredenciales(ByVal usuario As String, ByVal contraseña As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Usuario WHERE Username = @Username AND Clave = @Clave"
        Using cmd As New SqlCommand(query, conexion.ObtenerConexion())
            cmd.Parameters.AddWithValue("@Username", usuario)
            cmd.Parameters.AddWithValue("@Clave", contraseña)
            conexion.AbrirConexion()
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            'conexion.CerrarConexion()
            Return result > 0
        End Using
    End Function
    Public Function ObtenerRol(ByVal usuario As String) As String
        Dim query As String = "SELECT IdRol FROM Usuario WHERE Username = @Username"
        Using cmd As New SqlCommand(query, conexion.ObtenerConexion())
            cmd.Parameters.AddWithValue("@Username", usuario)
            conexion.AbrirConexion()
            Dim rol As String = Convert.ToString(cmd.ExecuteScalar())
            'conexion.CerrarConexion()
            Return rol
        End Using
    End Function

    Public Function ObtenerNombrePersona(ByVal usuario As String) As String
        Dim query As String = "SELECT NombreCompleto  FROM Usuario WHERE Username = @Username"
        Using cmd As New SqlCommand(query, conexion.ObtenerConexion())
            cmd.Parameters.AddWithValue("@Username", usuario)
            conexion.AbrirConexion()
            Dim nombrePersona As String = Convert.ToString(cmd.ExecuteScalar())
            'conexion.CerrarConexion()
            Return nombrePersona
        End Using
    End Function
    Public Function ExisteUsuario(username As String) As Boolean

        Dim query As String = "SELECT COUNT(*) FROM Usuario WHERE Username = @Username"
        Using cmd As New SqlCommand(query, conexion.ObtenerConexion())
            cmd.Parameters.AddWithValue("@Username", username)
            conexion.AbrirConexion()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function
End Class
