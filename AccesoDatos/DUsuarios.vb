Imports System.Data.SqlClient
Public Class DUsuarios
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()

    Public Sub Cerrar()
        conexion.CerrarConexion()
    End Sub

    Public Sub Insertar_Usuario(IdUsuario As String, IdRol As String, Fecha As DateTime, Nombre As String, Username As String, Clave As String)
        conexion.AbrirConexion()
        query = "SELECT COUNT(*) FROM Usuario WHERE Username = @Username"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Username", Username)
        Dim cantidad As Integer = CInt(comando.ExecuteScalar())
        If cantidad = 0 Then
            query = "INSERT INTO Usuario(IdUsuario, IdRol, FechaCreacion, NombreCompleto, Username, Clave) VALUES " &
                "(@IdUsuario, @IdRol, @FechaCreacion, @NombreCompleto, @Username, @Clave)"
            comando = New SqlCommand(query, conexion.ObtenerConexion())
            comando.Parameters.AddWithValue("@IdUsuario", IdUsuario)
            comando.Parameters.AddWithValue("@IdRol", IdRol)
            comando.Parameters.AddWithValue("@FechaCreacion", Fecha)
            comando.Parameters.AddWithValue("@NombreCompleto", Nombre)
            comando.Parameters.AddWithValue("@Username", Username)
            comando.Parameters.AddWithValue("@Clave", Clave)
            comando.ExecuteNonQuery()
            MsgBox("El usuario: " & Username & " ha sido insertado correctamente.")
        Else
            MsgBox("No se puede insertar el usuario porque ya existe un registro con el mismo nombre de usuario.")
        End If
        conexion.CerrarConexion()
    End Sub

    Public Sub Editar_Usuario(IdUsuario As String, IdRol As String, Fecha As DateTime, Nombre As String, Username As String, Clave As String)
        conexion.AbrirConexion()
        Dim query As String = "UPDATE Usuario SET  IdRol=@IdRol, Fecha=@Fecha, NombreCompleto=@NombreCompleto, Username=@Username, Clave=@Clave WHERE IdUsuario = @IdUsuario"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@IdUsuario", IdUsuario)
        comando.Parameters.AddWithValue("@IdRol", IdRol)
        comando.Parameters.AddWithValue("@Fecha", Fecha)
        comando.Parameters.AddWithValue("@NombreCompleto", Nombre)
        comando.Parameters.AddWithValue("@Username", Username)
        comando.Parameters.AddWithValue("@Clave", Clave)
        comando.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub
    Private Function Administrador(IdUsuario As String) As Boolean

        Dim esAdmin As Boolean = False
        conexion.AbrirConexion()
        query = "SELECT IdRol FROM Usuario WHERE IdUsuario = @IdUsuario"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@IdUsuario", IdUsuario)
        Dim rol As String = Convert.ToString(comando.ExecuteScalar())
        If String.Equals(rol, "admin", StringComparison.OrdinalIgnoreCase) Then
            esAdmin = True
        End If
        Return esAdmin
    End Function

    Public Sub Eliminar_Usuario(IdUsuario As String)
        conexion.AbrirConexion()
        Dim esAdministrador As Boolean = Administrador(IdUsuario)


        'query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario"
        'Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        'comando.Parameters.AddWithValue("@IdUsuario", IdUsuario)
        'Dim rowaffected As Integer = comando.ExecuteNonQuery()
        'If rowaffected > 0 Then
        '    MsgBox("El usuario ha sido eliminado correctamente.")
        'End If
        'conexion.CerrarConexion()


        If esAdministrador Then
            MsgBox("No puedes eliminar a un administrador.")
        Else
            ' Si no es un administrador, procede a eliminar
            query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario"
            Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
            comando.Parameters.AddWithValue("@IdUsuario", IdUsuario)
            Dim rowaffected As Integer = comando.ExecuteNonQuery()
            If rowaffected > 0 Then
                MsgBox("El usuario ha sido eliminado correctamente.")
            End If
        End If

        conexion.CerrarConexion()



    End Sub

    Public Function BuscarPorId(IdUsuario As String) As SqlDataReader
        Dim query As String = "SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@IdUsuario", IdUsuario)
        conexion.AbrirConexion()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        Return reader
    End Function

    Public Function GenerarCodigoUsuario() As String
        Dim IdUsuario As String = ""
        query = "SELECT TOP 1 IdUsuario FROM Usuario ORDER BY IdUsuario DESC"
        Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
        conexion.AbrirConexion()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim ultimoCodigo As Integer = Convert.ToInt32(reader("IdUsuario").ToString().Substring(4))
            IdUsuario = "USU-" & (ultimoCodigo + 1).ToString("D4")
        Else
            IdUsuario = "USU-0001"
        End If
        reader.Close()
        conexion.CerrarConexion()
        Return IdUsuario
    End Function

    Public Function Tabla(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Dim conexion As New ConexionSql()
        Dim adapter As New SqlDataAdapter(query, conexion.ObtenerConexion())
        adapter.Fill(table)
        Return table
    End Function
End Class
