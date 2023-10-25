Imports System.Data.SqlClient


Public Class PCajero
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()
    Public Function HaRealizadoConteo(nombreUsuario As String) As Boolean
        conexion.AbrirConexion()
        query = "SELECT COUNT(*) FROM Turno WHERE Fecha = @Fecha AND NombreUsuario = @NombreUsuario"

        Using comando As New SqlCommand(query, conexion.ObtenerConexion)
            comando.Parameters.AddWithValue("@Fecha", DateTime.Now.Date)
            comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)
            Dim conteosRealizados As Integer = DirectCast(comando.ExecuteScalar(), Integer)
            Return conteosRealizados > 0
        End Using
    End Function
End Class
