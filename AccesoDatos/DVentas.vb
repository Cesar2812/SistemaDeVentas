Imports System.Data.SqlClient

Public Class DVentas
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()

    Public Sub Cerrar()
        conexion.CerrarConexion()
    End Sub

    Public Sub Insertar_Venta(ByVal NFactura As String, ByVal Fecha As String, ByVal CodCliente As String, ByVal Descuento As Double, ByVal MontoTotal As Double, Estado As String)
        conexion.AbrirConexion()
        query = "SELECT COUNT(*) FROM Ventas WHERE NFactura = @NFactura"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@NFactura", NFactura)
        Dim cantidad As Integer = CInt(comando.ExecuteScalar())
        If cantidad = 0 Then
            query = "INSERT INTO Ventas (NFactura, Fecha, CodCliente, Descuento, MontoTotal,Estado) VALUES " &
                "(@NFactura, @Fecha, @CodCliente, @Descuento, @MontoTotal,@Estado)"
            comando = New SqlCommand(query, conexion.ObtenerConexion())

            comando.Parameters.AddWithValue("@NFactura", NFactura)
            comando.Parameters.AddWithValue("@Fecha", Fecha)
            comando.Parameters.AddWithValue("@CodCliente", CodCliente)
            comando.Parameters.AddWithValue("@Descuento", Descuento)
            comando.Parameters.AddWithValue("@MontoTotal", MontoTotal)
            comando.Parameters.AddWithValue("@Estado", Estado)

            comando.ExecuteNonQuery()
            MsgBox("La venta con Número de Factura " & NFactura & " ha sido insertada correctamente.")
        Else
            MsgBox("No se puede insertar la venta porque ya existe un registro con el mismo número de factura.")
        End If

        conexion.CerrarConexion()
    End Sub

    Public Sub Editar_Venta(ByVal NFactura As String, ByVal Fecha As String, ByVal CodCliente As String, ByVal Descuento As Double, ByVal MontoTotal As Double)
        conexion.AbrirConexion()
        Dim query As String = "UPDATE Ventas SET Fecha=@Fecha, CodCliente=@CodCliente, Descuento=@Descuento, MontoTotal=@MontoTotal WHERE NFactura = @NFactura"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

        comando.Parameters.AddWithValue("@NFactura", NFactura)
        comando.Parameters.AddWithValue("@Fecha", Fecha)
        comando.Parameters.AddWithValue("@CodCliente", CodCliente)
        comando.Parameters.AddWithValue("@Descuento", Descuento)
        comando.Parameters.AddWithValue("@MontoTotal", MontoTotal)

        comando.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar_Venta(ByVal NFactura As String)
        conexion.AbrirConexion()
        query = "DELETE FROM Ventas WHERE NFactura = @NFactura"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@NFactura", NFactura)

        Dim rowaffected As Integer = comando.ExecuteNonQuery()
        If rowaffected > 0 Then
            MsgBox("La venta ha sido eliminada correctamente.")
        End If
        conexion.CerrarConexion()
    End Sub

    'Public Function GenerarCodigoVenta() As String
    '    Dim NFactura As String = ""
    '    Dim añoActual As String = DateTime.Now.ToString("yyyy")
    '    Dim diaMesActual As String = DateTime.Now.ToString("ddMM")

    '    Dim query As String = "SELECT TOP 1 NFactura FROM Ventas ORDER BY NFactura DESC"
    '    Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
    '    conexion.AbrirConexion()

    '    Dim reader As SqlDataReader = comando.ExecuteReader()

    '    If reader.HasRows Then
    '        reader.Read()
    '        Dim ultimoCodigo As Integer = Convert.ToInt32(reader("NFactura").ToString().Substring(10)) + 1
    '        NFactura = $"VF-{diaMesActual}{ultimoCodigo.ToString("D3")}"
    '    Else
    '        NFactura = $"VF-{diaMesActual}001"
    '    End If

    '    reader.Close()
    '    conexion.CerrarConexion()
    '    Return NFactura
    'End Function

    Public Function GenerarCodigoVenta() As String

        Dim NFactura As String = ""
        Dim query As String = "SELECT TOP 1 NFactura FROM Ventas ORDER BY NFactura DESC"
        Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
        conexion.AbrirConexion()

        Dim reader As SqlDataReader = comando.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim ultimoCodigo As Integer = Convert.ToInt32(reader("NFactura").ToString().Substring(3))
            NFactura = "DV-" & (ultimoCodigo + 1).ToString("D4")
        Else
            NFactura = "DV-0001"
        End If
        reader.Close()
        conexion.CerrarConexion()
        Return NFactura
    End Function


    Public Function BuscarPorNFactura(ByVal NFactura As String) As SqlDataReader
        Dim query As String = "SELECT * FROM Ventas WHERE NFactura = @NFactura"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@NFactura", NFactura)
        conexion.AbrirConexion()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        Return reader
    End Function

    Public Function Tabla(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Dim conexion As New ConexionSql()
        Dim adapter As New SqlDataAdapter(query, conexion.ObtenerConexion())
        adapter.Fill(table)
        Return table
    End Function
    Public Function ObtenerDetallePorCompra(NFactura As String) As DataTable
        Dim Detalle As New DataTable()

        Try
            Dim query As String = "SELECT Cod_detalle, Factura, CodProducto, Cantidad, MontoxProducto FROM DetalleVentas WHERE Factura = @Factura"

            conexion.AbrirConexion()

            Using command As New SqlCommand(query, conexion.ObtenerConexion())
                command.Parameters.AddWithValue("@Factura", NFactura)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(Detalle)
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error al obtener los detalles de la vemta: " & ex.Message)
        End Try

        Return Detalle
    End Function



End Class
