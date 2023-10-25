Imports System.Data.SqlClient

Public Class DCategorias
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()

    Public Sub Cerrar()

        conexion.CerrarConexion()
    End Sub
    Public Sub Insertar_Categoria(ByVal Cod_categoria As String, ByVal Nombre As String)
        ' No generaremos el código del propietario aquí, ya que lo recibimos como parámetro
        conexion.AbrirConexion()
        query = "SELECT COUNT(*) FROM Categorias WHERE Nombre = @Nombre"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Nombre", Nombre)
        Dim cantidad As Integer = CInt(comando.ExecuteScalar())
        If cantidad = 0 Then
            query = "INSERT INTO Categorias (Cod_categoria,Nombre) VALUES " &
                "(@Cod_categoria,@Nombre)"
            comando = New SqlCommand(query, conexion.ObtenerConexion())

            comando.Parameters.AddWithValue("@Cod_categoria", Cod_categoria)
            comando.Parameters.AddWithValue("@Nombre", Nombre)
            comando.ExecuteNonQuery()
            MsgBox("La categoria " & Cod_categoria & " ha sido insertado correctamente.")
        Else
            MsgBox("No se puede insertar la categoria porque ya existe un registro con el mismo nombre.")
        End If

        conexion.CerrarConexion()
    End Sub
    Public Sub Editar_Categoria(Cod_categoria As String, nombre As String)

        ' Verificar si ya existe un registro con el mismo código de proveedor
        conexion.AbrirConexion()
        Dim query As String = "UPDATE Categorias SET Nombre=@Nombre WHERE Cod_categoria = @Cod_categoria"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

        comando.Parameters.AddWithValue("Cod_categoria", Cod_categoria)
        comando.Parameters.AddWithValue("Nombre", nombre)


        comando.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar_Categoria(IdCategoria As String)
        conexion.AbrirConexion()
        query = "DELETE FROM Categorias WHERE Cod_categoria = @Cod_categoria"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Cod_categoria", IdCategoria)

        Dim rowaffected As Integer = comando.ExecuteNonQuery()
        If rowaffected > 0 Then
            MsgBox("La categoria ha sido insertada correctamente.")
        End If
        conexion.CerrarConexion()
    End Sub
    Public Function BuscarxId(IdCategoria As String) As SqlDataReader
        Dim query As String = "SELECT * FROM Categorias WHERE Cod_categoria = @Cod_categoria"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Cod_categoria", IdCategoria)
        conexion.AbrirConexion()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        Return reader
    End Function

    Public Function GenerarCodigoCategoria() As String
        Dim IdProveedor As String = ""
        query = "SELECT TOP 1 Cod_categoria FROM Categorias ORDER BY Cod_categoria DESC"
        Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
        conexion.AbrirConexion()

        Dim reader As SqlDataReader = comando.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim ultimoCodigo As Integer = Convert.ToInt32(reader("Cod_categoria").ToString().Substring(5))
            IdProveedor = "CATE-" & (ultimoCodigo + 1).ToString("D4")
        Else
            IdProveedor = "CATE-0001"
        End If

        reader.Close()
        conexion.CerrarConexion()
        Return IdProveedor
    End Function

    Public Function Tabla(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Dim conexion As New ConexionSql()
        Dim adapter As New SqlDataAdapter(query, conexion.ObtenerConexion())
        adapter.Fill(table)
        Return table
    End Function

End Class
