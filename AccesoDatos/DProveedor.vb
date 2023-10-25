
Imports System.Data
Imports System.Data.SqlClient
Public Class DProveedor
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()


    Public Sub Cerrar()

        conexion.CerrarConexion()
    End Sub
    Public Sub Insertar_Proveedor(Cod_proveedor As String, Nombre As String, RUC As String, Direccion As String, Telefono As String, Pagina As String, Estado As String)
        ' No generaremos el código del propietario aquí, ya que lo recibimos como parámetro
        conexion.AbrirConexion()
        query = "SELECT COUNT(*) FROM Proveedor WHERE Nombre = @Nombre"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Nombre", Nombre)
        Dim cantidad As Integer = CInt(comando.ExecuteScalar())
        If cantidad = 0 Then
            query = "INSERT INTO Proveedor (Cod_proveedor,Nombre,RUC,Direccion,Telefono,Pagina,Estado) VALUES " &
                "(@Cod_proveedor,@Nombre,@RUC,@Direccion,@Telefono,@Pagina,@Estado)"
            comando = New SqlCommand(query, conexion.ObtenerConexion())

            comando.Parameters.AddWithValue("@Cod_proveedor", Cod_proveedor)
            comando.Parameters.AddWithValue("@Nombre", Nombre)
            comando.Parameters.AddWithValue("@RUC", RUC)
            comando.Parameters.AddWithValue("@Direccion", Direccion)
            comando.Parameters.AddWithValue("@Telefono", Telefono)
            comando.Parameters.AddWithValue("@Pagina", Pagina)
            comando.Parameters.AddWithValue("@Estado", Estado)
            comando.ExecuteNonQuery()
            MsgBox("El proveedor " & Cod_proveedor & " ha sido insertado correctamente.")
        Else
            MsgBox("No se puede insertar el proveedor porque ya existe un registro con el mismo nombre.")
        End If

        conexion.CerrarConexion()
    End Sub
    Public Sub Editar_Proveedor(codProveedor As String, nombre As String, ruc As String, direccion As String, telefono As String, pagina As String)

        ' Verificar si ya existe un registro con el mismo código de proveedor
        conexion.AbrirConexion()
        Dim query As String = "UPDATE Proveedor SET Nombre=@Nombre, RUC=@RUC, Direccion=@Direccion, Telefono=@Telefono, Pagina=@Pagina WHERE Cod_proveedor = @Cod_proveedor"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

        comando.Parameters.AddWithValue("Cod_proveedor", codProveedor)
        comando.Parameters.AddWithValue("Nombre", nombre)
        comando.Parameters.AddWithValue("RUC", ruc)
        comando.Parameters.AddWithValue("Direccion", direccion)
        comando.Parameters.AddWithValue("Telefono", telefono)
        comando.Parameters.AddWithValue("Pagina", pagina)

        comando.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar_Proveedor(IdProveedor As String)
        conexion.AbrirConexion()
        query = "DELETE FROM Proveedor WHERE Cod_proveedor = @Cod_proveedor"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Cod_proveedor", IdProveedor)

        Dim rowaffected As Integer = comando.ExecuteNonQuery()
        If rowaffected > 0 Then
            MsgBox("El proveedor ha sido eliminado correctamente.")
        End If
        conexion.CerrarConexion()
    End Sub
    Public Function BuscarxId(IdProveedor As String) As SqlDataReader
        Dim query As String = "SELECT * FROM Proveedor WHERE Cod_proveedor = @Cod_proveedor"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Cod_proveedor", IdProveedor)
        conexion.AbrirConexion()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        Return reader
    End Function

    Public Function GenerarCodigoProveedor() As String
        Dim IdProveedor As String = ""
        query = "SELECT TOP 1 Cod_proveedor FROM Proveedor ORDER BY Cod_proveedor DESC"
        Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
        conexion.AbrirConexion()

        Dim reader As SqlDataReader = comando.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim ultimoCodigo As Integer = Convert.ToInt32(reader("Cod_proveedor").ToString().Substring(6))
            IdProveedor = "PROVE-" & (ultimoCodigo + 1).ToString("D4")
        Else
            IdProveedor = "PROVE-0001"
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
