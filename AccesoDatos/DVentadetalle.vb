Imports System.Data.SqlClient

Public Class DVentadetalle
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()

    Public Function GenerarCodigoDetalleVenta() As String
        Dim IdProveedor As String = ""
        query = "SELECT TOP 1 Cod_detalle FROM DetalleVentas ORDER BY Cod_detalle DESC"
        Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
        conexion.AbrirConexion()

        Dim reader As SqlDataReader = comando.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim ultimoCodigo As Integer = Convert.ToInt32(reader("Cod_detalle").ToString().Substring(3))
            IdProveedor = "DV-" & (ultimoCodigo + 1).ToString("D4")
        Else
            IdProveedor = "DV-0001"
        End If

        reader.Close()
        conexion.CerrarConexion()
        Return IdProveedor
    End Function

    'Public Sub Insertar_DetalleVenta(ByVal CodDetalle As String, ByVal Factura As String, ByVal CodProducto As String, ByVal Cantidad As Double, ByVal MontoxProducto As Double)
    '    conexion.AbrirConexion()

    '    ' Verificar si ya existe un registro con el mismo Cod_detalle
    '    query = "SELECT COUNT(*) FROM DetalleVentas WHERE Cod_detalle = @Cod_detalle"
    '    Dim comandoExistencia As New SqlCommand(query, conexion.ObtenerConexion())
    '    comandoExistencia.Parameters.AddWithValue("@Cod_detalle", CodDetalle)
    '    Dim cantidadExistencia As Integer = CInt(comandoExistencia.ExecuteScalar())

    '    If cantidadExistencia = 0 Then
    '        ' Insertar el detalle de venta si no existe un registro con el mismo Cod_detalle
    '        query = "INSERT INTO DetalleVentas (Cod_detalle, Factura, CodProducto, Cantidad, MontoxProducto) VALUES " &
    '            "(@Cod_detalle, @Factura, @CodProducto, @Cantidad, @MontoxProducto)"
    '        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

    '        comando.Parameters.AddWithValue("@Cod_detalle", CodDetalle)
    '        comando.Parameters.AddWithValue("@Factura", Factura)
    '        comando.Parameters.AddWithValue("@CodProducto", CodProducto)
    '        comando.Parameters.AddWithValue("@Cantidad", Cantidad)
    '        comando.Parameters.AddWithValue("@MontoxProducto", MontoxProducto)

    '        comando.ExecuteNonQuery()
    '        MsgBox("El detalle de venta " & CodDetalle & " para la factura " & Factura & " ha sido insertado correctamente.")
    '    Else
    '        MsgBox("No se puede insertar el detalle de venta porque ya existe un registro con el mismo código.")
    '    End If

    '    conexion.CerrarConexion()
    'End Sub


    Public Sub Insertar_DetalleVenta(ByVal CodDetalle As String, ByVal Factura As String, ByVal CodProducto As String, ByVal Cantidad As Double, ByVal MontoxProducto As Double)
        ' Abre la conexión a la base de datos
        conexion.AbrirConexion()

        ' Verificar si ya existe un registro con el mismo Cod_detalle y Factura
        Dim queryExistencia As String = "SELECT COUNT(*) FROM DetalleVentas WHERE Cod_detalle = @Cod_detalle AND Factura = @Factura"
        Dim comandoExistencia As New SqlCommand(queryExistencia, conexion.ObtenerConexion())
        comandoExistencia.Parameters.AddWithValue("@Cod_detalle", CodDetalle)
        comandoExistencia.Parameters.AddWithValue("@Factura", Factura)
        Dim cantidadExistencia As Integer = CInt(comandoExistencia.ExecuteScalar())

        If cantidadExistencia = 0 Then
            ' Insertar el detalle de venta si no existe un registro con el mismo Cod_detalle y Factura
            Dim queryInsercion As String = "INSERT INTO DetalleVentas (Cod_detalle, Factura, CodProducto, Cantidad, MontoxProducto) " &
                                   "VALUES (@Cod_detalle, @Factura, @CodProducto, @Cantidad, @MontoxProducto)"
            Dim comandoInsercion As New SqlCommand(queryInsercion, conexion.ObtenerConexion())

            comandoInsercion.Parameters.AddWithValue("@Cod_detalle", CodDetalle)
            comandoInsercion.Parameters.AddWithValue("@Factura", Factura)
            comandoInsercion.Parameters.AddWithValue("@CodProducto", CodProducto)
            comandoInsercion.Parameters.AddWithValue("@Cantidad", Cantidad)
            comandoInsercion.Parameters.AddWithValue("@MontoxProducto", MontoxProducto)

            comandoInsercion.ExecuteNonQuery()
            MsgBox("El detalle de venta " & CodDetalle & " para la factura " & Factura & " ha sido insertado correctamente.")
        Else
            MsgBox("No se puede insertar el detalle de venta porque ya existe un registro con el mismo código de detalle y número de factura.")
        End If

        ' Cierra la conexión a la base de datos
        conexion.CerrarConexion()
    End Sub

    Public Sub Editar_DetalleVenta(ByVal CodDetalle As String, ByVal Factura As String, ByVal CodProducto As String, ByVal Cantidad As Double, ByVal MontoxProducto As Double)
        conexion.AbrirConexion()
        Dim query As String = "UPDATE DetalleVentas SET Factura=@Factura, CodProducto=@CodProducto, Cantidad=@Cantidad, MontoxProducto=@MontoxProducto WHERE Cod_detalle = @Cod_detalle"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

        comando.Parameters.AddWithValue("@Cod_detalle", CodDetalle)
        comando.Parameters.AddWithValue("@Factura", Factura)
        comando.Parameters.AddWithValue("@CodProducto", CodProducto)
        comando.Parameters.AddWithValue("@Cantidad", Cantidad)
        comando.Parameters.AddWithValue("@MontoxProducto", MontoxProducto)

        comando.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar_DetalleVenta(ByVal CodDetalle As String)
        conexion.AbrirConexion()
        query = "DELETE FROM DetalleVentas WHERE Cod_detalle = @Cod_detalle"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Cod_detalle", CodDetalle)

        Dim rowaffected As Integer = comando.ExecuteNonQuery()
        If rowaffected > 0 Then
            MsgBox("El detalle de venta ha sido eliminado correctamente.")
        End If
        conexion.CerrarConexion()
    End Sub
    Public Function ObtenerDetallesPorFactura(ByVal Factura As String) As DataTable
        Dim query As String = "SELECT * FROM DetalleVentas WHERE Factura = @Factura"
        Return Tabla(query, Factura)
    End Function
    Private Function Tabla(ByVal query As String, ByVal Factura As String) As DataTable
        Dim table As New DataTable()
        Dim conexion As New ConexionSql()
        Dim adapter As New SqlDataAdapter(query, conexion.ObtenerConexion())
        adapter.SelectCommand.Parameters.AddWithValue("@Factura", Factura)
        adapter.Fill(table)
        Return table
    End Function

End Class
