
Imports System.Data.SqlClient


Public Class DCompra
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()



    Public Sub Insertar_Compra(NFactura As String, Fecha As String, CodProveedor As String, Descuento As Double, MontoTotal As Double, Estado As String)
        conexion.AbrirConexion()
        query = "SELECT COUNT(*) FROM Compra WHERE NFactura = @NFactura"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@NFactura", NFactura)
        Dim cantidad As Integer = CInt(comando.ExecuteScalar())
        If cantidad = 0 Then
            query = "INSERT INTO Compra (NFactura, Fecha, CodProveedor, Descuento, MontoTotal, Estado) VALUES " &
                    "(@NFactura, @Fecha, @CodProveedor, @Descuento, @MontoTotal, @Estado)"
            comando = New SqlCommand(query, conexion.ObtenerConexion())

            comando.Parameters.AddWithValue("@NFactura", NFactura)
            comando.Parameters.AddWithValue("@Fecha", Fecha)
            comando.Parameters.AddWithValue("@CodProveedor", CodProveedor)
            comando.Parameters.AddWithValue("@Descuento", Descuento)
            comando.Parameters.AddWithValue("@MontoTotal", MontoTotal)
            comando.Parameters.AddWithValue("@Estado", Estado)

            comando.ExecuteNonQuery()
            MsgBox("La compra con Número de Factura " & NFactura & " ha sido insertada correctamente.")
        Else
            MsgBox("No se puede insertar la venta porque ya existe un registro con el mismo número de factura.")
        End If

        conexion.CerrarConexion()
    End Sub

    Public Sub Editar_Compra(NFactura As String, Fecha As String, CodProveedor As String, MontoTotal As Double)
        conexion.AbrirConexion()
        Dim query As String = "UPDATE Compra SET Fecha=@Fecha, CodProveedor=@CodProveedor, MontoTotal=@MontoTotal WHERE NFactura = @NFactura"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

        comando.Parameters.AddWithValue("@NFactura", NFactura)
        comando.Parameters.AddWithValue("@Fecha", Fecha)
        comando.Parameters.AddWithValue("@CodProveedor", CodProveedor)
        comando.Parameters.AddWithValue("@MontoTotal", MontoTotal)

        comando.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar_Compra(NFactura As String)
        conexion.AbrirConexion()
        query = "DELETE FROM Compra WHERE NFactura = @NFactura"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@NFactura", NFactura)

        Dim rowaffected As Integer = comando.ExecuteNonQuery()
        If rowaffected > 0 Then
            MsgBox("La compra ha sido eliminada correctamente.")
        End If
        conexion.CerrarConexion()
    End Sub


    Public Function BuscarPorNFactura(NFactura As String) As SqlDataReader
        Dim query As String = "SELECT * FROM Compra WHERE NFactura = @NFactura"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@NFactura", NFactura)
        conexion.AbrirConexion()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        Return reader
    End Function

    Public Function Tabla(query As String) As DataTable
        Dim table As New DataTable()
        Dim conexion As New ConexionSql()
        Dim adapter As New SqlDataAdapter(query, conexion.ObtenerConexion())
        adapter.Fill(table)
        Return table
    End Function

    Public Function ObtenerDetallePorCompra(NFactura As String) As DataTable
        Dim Detalle As New DataTable()

        Try
            Dim query As String = "SELECT Cod_detalle, Factura, CodProducto, Cantidad, MontoxProducto FROM DetalleCompras WHERE Factura = @Factura"

            conexion.AbrirConexion()

            Using command As New SqlCommand(query, conexion.ObtenerConexion())
                command.Parameters.AddWithValue("@Factura", NFactura)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(Detalle)
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error al obtener los detalles de la compra: " & ex.Message)
        End Try

        Return Detalle
    End Function


End Class
