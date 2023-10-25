Imports System.Data.SqlClient

Public Class DProductos
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()

    Public Sub Cerrar()
        conexion.CerrarConexion()
    End Sub

    Public Sub Insertar_Producto(Cod_producto As String, Nombre As String, Stock As Double, Precio_compra As Double, Precio_venta As Double, CodCategoria As String, CodProveedor As String, Preciodefinido As Boolean)
        conexion.AbrirConexion()
        query = "SELECT COUNT(*) FROM Productos WHERE Cod_producto = @Cod_producto"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Cod_producto", Cod_producto)
        Dim cantidad As Integer = CInt(comando.ExecuteScalar())
        If cantidad = 0 Then
            query = "INSERT INTO Productos (Cod_producto, Nombre, Stock, Precio_compra,Precio_venta, CodCategoria, CodProveedor,PDefinido) VALUES " &
                "(@Cod_producto, @Nombre, @Stock, @Precio_compra,@Precio_venta, @CodCategoria, @CodProveedor,@PDefinido)"
            comando = New SqlCommand(query, conexion.ObtenerConexion())

            comando.Parameters.AddWithValue("@Cod_producto", Cod_producto)
            comando.Parameters.AddWithValue("@Nombre", Nombre)
            comando.Parameters.AddWithValue("@Stock", Stock)
            comando.Parameters.AddWithValue("@Precio_compra", Precio_compra)
            comando.Parameters.AddWithValue("@Precio_venta", Precio_venta)
            comando.Parameters.AddWithValue("@CodCategoria", CodCategoria)
            comando.Parameters.AddWithValue("@CodProveedor", CodProveedor)


            If Preciodefinido Then
                comando.Parameters.AddWithValue("@PDefinido", "Sí")
            Else
                comando.Parameters.AddWithValue("@PDefinido", "No")
            End If


            comando.ExecuteNonQuery()
            MsgBox("El producto " & Cod_producto & " ha sido insertado correctamente.")
        Else
            MsgBox("No se puede insertar el producto porque ya existe un registro con el mismo código.")
        End If

        conexion.CerrarConexion()
    End Sub

    'Public Sub Editar_Producto(Cod_producto As String, Nombre As String, Stock As Double, Valor_producto As Double, CodCategoria As String, CodProveedor As String)
    '    conexion.AbrirConexion()
    '    Dim query As String = "UPDATE Productos SET Nombre=@Nombre, Stock=@Stock, Valor_producto=@Valor_producto, CodCategoria=@CodCategoria, CodProveedor=@CodProveedor WHERE Cod_producto = @Cod_producto"
    '    Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

    '    comando.Parameters.AddWithValue("@Cod_producto", Cod_producto)
    '    comando.Parameters.AddWithValue("@Nombre", Nombre)
    '    comando.Parameters.AddWithValue("@Stock", Stock)
    '    comando.Parameters.AddWithValue("@Valor_producto", Valor_producto)
    '    comando.Parameters.AddWithValue("@CodCategoria", CodCategoria)
    '    comando.Parameters.AddWithValue("@CodProveedor", CodProveedor)

    '    comando.ExecuteNonQuery()
    '    conexion.CerrarConexion()
    'End Sub





    Private Function VerificarVentaExistente(numeroFactura As String) As Boolean
        Try
            ' Abre una conexión a la base de datos
            conexion.AbrirConexion()

            ' Consulta SQL para verificar si existe una factura con el mismo número
            Dim query As String = "SELECT COUNT(*) FROM Compra WHERE NFactura = @NFactura"
            Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
            comando.Parameters.AddWithValue("@NFactura", numeroFactura)

            ' Ejecuta la consulta y obtiene el número de filas coincidentes
            Dim filasCoincidentes As Integer = CInt(comando.ExecuteScalar())

            ' Si hay al menos una fila coincidente, significa que la factura ya existe
            Return filasCoincidentes > 0
        Catch ex As Exception
            ' Manejar errores de base de datos u otros errores
            MsgBox($"Error al verificar compra existente: {ex.Message}", MsgBoxStyle.Exclamation, "Error")
            Return False ' En caso de error, asumimos que no hay venta existente
        Finally
            ' Asegurarse de cerrar la conexión
            conexion.CerrarConexion()
        End Try
    End Function


    Public Sub ActualizarPrecioCVStock(Codigo As String, PrecioCompraNuevo As Double, PrecioVentaNuevo As Double, Cantidad As Double, PDefinido As String, CodDetalle As String, NFactura As String)
        Try
            ' Validar la entrada
            If String.IsNullOrEmpty(Codigo) OrElse PrecioCompraNuevo < 0 Or PrecioVentaNuevo < 0 OrElse Cantidad <= 0 Then
                MsgBox("Los parámetros de entrada no son válidos.", MsgBoxStyle.Exclamation, "Error de entrada")
                Return
            End If

            ' Verificar si hay registros en DetalleCompras con el mismo Cod_detalle
            Dim queryExistencia As String = "SELECT COUNT(*) FROM DetalleCompras WHERE Cod_detalle = @Cod_detalle"
            Dim comandoExistencia As New SqlCommand(queryExistencia, conexion.ObtenerConexion())
            comandoExistencia.Parameters.AddWithValue("@Cod_detalle", CodDetalle)
            conexion.AbrirConexion()

            Dim cantidadExistencia As Integer = CInt(comandoExistencia.ExecuteScalar())

            If cantidadExistencia > 0 Then
                ' Registro existente con el mismo Cod_detalle

                ' Ahora, verifica si la factura es diferente
                Dim queryFacturaDiferente As String = "SELECT COUNT(*) FROM DetalleCompras WHERE Factura <> @Factura AND Cod_detalle = @Cod_detalle"
                Dim comandoFacturaDiferente As New SqlCommand(queryFacturaDiferente, conexion.ObtenerConexion())
                comandoFacturaDiferente.Parameters.AddWithValue("@Cod_detalle", CodDetalle)
                comandoFacturaDiferente.Parameters.AddWithValue("@Factura", NFactura)

                Dim cantidadFacturaDiferente As Integer = CInt(comandoFacturaDiferente.ExecuteScalar())

                If cantidadFacturaDiferente > 0 Then
                    ' Factura diferente, actualizamos el stock

                    ' Añade una condición adicional para evitar la actualización si la factura ya existe
                    Dim queryFacturaIgual As String = "SELECT COUNT(*) FROM DetalleCompras WHERE Factura = @Factura AND Cod_detalle = @Cod_detalle"
                    Dim comandoFacturaIgual As New SqlCommand(queryFacturaIgual, conexion.ObtenerConexion())
                    comandoFacturaIgual.Parameters.AddWithValue("@Cod_detalle", CodDetalle)
                    comandoFacturaIgual.Parameters.AddWithValue("@Factura", NFactura)

                    Dim cantidadFacturaIgual As Integer = CInt(comandoFacturaIgual.ExecuteScalar())

                    If cantidadFacturaIgual = 0 Then
                        ' La factura es diferente, pero el Cod_detalle ya existe, actualiza el stock

                        ' Ejemplo: ActualizarStock(CodDetalle, Cantidad)

                        ' Resto de tu código de actualización
                        Dim query As String = "UPDATE Productos SET Stock = Stock + @Cantidad, Precio_compra = @Precio_compra, Precio_venta = @Precio_venta, PDefinido=@PDefinido WHERE Cod_producto = @Cod_producto"
                        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
                        comando.Parameters.AddWithValue("@Cantidad", Cantidad)
                        comando.Parameters.AddWithValue("@Precio_compra", PrecioCompraNuevo)
                        comando.Parameters.AddWithValue("@Precio_venta", PrecioVentaNuevo)
                        comando.Parameters.AddWithValue("@Cod_producto", Codigo)
                        comando.Parameters.AddWithValue("@PDefinido", PDefinido)
                        Dim filasActualizadas As Integer = comando.ExecuteNonQuery()

                        If filasActualizadas > 0 Then
                            Dim mensaje As String = $"Se han actualizado los datos para el producto con código {Codigo}:" & vbCrLf &
                                    $"Nuevo Precio de Compra: {PrecioCompraNuevo:C}" & vbCrLf &
                                    $"Nuevo Precio de Venta: {PrecioVentaNuevo:C}" & vbCrLf &
                                    $"Cantidad Agregada al Stock: {Cantidad}"
                            MsgBox(mensaje, MsgBoxStyle.Information, "Actualización Exitosa")
                        Else
                            MsgBox("No se realizaron actualizaciones.", MsgBoxStyle.Information, "Sin Cambios")
                        End If
                    Else
                        ' Factura igual, no actualizamos el stock
                        MsgBox("La factura y el código de detalle son iguales. No se actualizará el stock.", MsgBoxStyle.Information, "Registro Existente")
                    End If
                Else
                    ' Factura igual, no actualizamos el stock
                    MsgBox("La factura y el código de detalle son iguales. No se actualizará el stock.", MsgBoxStyle.Information, "Registro Existente")
                End If
            Else
                ' No hay registros en DetalleCompras con el mismo Cod_detalle, actualiza el stock sin verificar la factura
                ' Ejemplo: ActualizarStock(CodDetalle, Cantidad)

                ' Resto de tu código de actualización
                Dim query As String = "UPDATE Productos SET Stock = Stock + @Cantidad, Precio_compra = @Precio_compra, Precio_venta = @Precio_venta, PDefinido=@PDefinido WHERE Cod_producto = @Cod_producto"
                Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
                comando.Parameters.AddWithValue("@Cantidad", Cantidad)
                comando.Parameters.AddWithValue("@Precio_compra", PrecioCompraNuevo)
                comando.Parameters.AddWithValue("@Precio_venta", PrecioVentaNuevo)
                comando.Parameters.AddWithValue("@Cod_producto", Codigo)
                comando.Parameters.AddWithValue("@PDefinido", PDefinido)
                Dim filasActualizadas As Integer = comando.ExecuteNonQuery()

                If filasActualizadas > 0 Then
                    Dim mensaje As String = $"Se han actualizado los datos para el producto con código {Codigo}:" & vbCrLf &
                            $"Nuevo Precio de Compra: {PrecioCompraNuevo:C}" & vbCrLf &
                            $"Nuevo Precio de Venta: {PrecioVentaNuevo:C}" & vbCrLf &
                            $"Cantidad Agregada al Stock: {Cantidad}"
                    MsgBox(mensaje, MsgBoxStyle.Information, "Actualización Exitosa")
                Else
                    MsgBox("No se realizaron actualizaciones.", MsgBoxStyle.Information, "Sin Cambios")
                End If
            End If
        Catch ex As Exception
            ' Manejar errores de base de datos u otros errores
            MsgBox($"Error: {ex.Message}", MsgBoxStyle.Exclamation, "Error")
        Finally
            ' Asegurarse de cerrar la conexión, incluso si se produce una excepción
            conexion.CerrarConexion()
        End Try
    End Sub




    Public Sub DescontaStock(Codigo As String, Cantidad As Double)
        Try
            ' Validar la entrada
            If String.IsNullOrEmpty(Codigo) OrElse Cantidad <= 0 Then
                MsgBox("Los parámetros de entrada no son válidos.", MsgBoxStyle.Exclamation, "Error de entrada")
                Return
            End If

            conexion.AbrirConexion()

            Dim query As String = "UPDATE Productos SET Stock = Stock - @Cantidad WHERE Cod_producto = @Cod_producto"
            Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
            comando.Parameters.AddWithValue("@Cantidad", Cantidad)
            comando.Parameters.AddWithValue("@Cod_producto", Codigo)

            Dim filasActualizadas As Integer = comando.ExecuteNonQuery()

            If filasActualizadas > 0 Then
                Dim mensaje As String = $"Se han descontado {Cantidad} para el producto con código {Codigo}."
                MsgBox(mensaje, MsgBoxStyle.Information, "Actualización Exitosa")
            Else
                MsgBox("No se realizaron actualizaciones para el producto con código especificado.", MsgBoxStyle.Information, "Sin Cambios")
            End If
        Catch ex As Exception
            ' Manejar errores de base de datos u otros errores
            MsgBox($"Error: {ex.Message}", MsgBoxStyle.Exclamation, "Error")
        Finally
            ' Asegurarse de cerrar la conexión
            conexion.CerrarConexion()
        End Try
    End Sub


    Public Sub Editar_Producto(Codigo As String, Nombre As String, Precio_compra As Double, Precio_venta As Double, CodCategoria As String, CodProveedor As String, PDefinido As String)
        conexion.AbrirConexion()
        Dim query As String = "UPDATE Productos SET Nombre=@Nombre, Precio_compra = @Precio_compra, Precio_venta = @Precio_venta,CodCategoria=@CodCategoria, CodProveedor=@CodProveedor,PDefinido=@PDefinido WHERE Cod_producto = @Cod_producto"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Nombre", Nombre)
        comando.Parameters.AddWithValue("@Precio_compra", Precio_compra)
        comando.Parameters.AddWithValue("@Precio_venta", Precio_venta)
        comando.Parameters.AddWithValue("@CodCategoria", CodCategoria)
        comando.Parameters.AddWithValue("@CodProveedor", CodProveedor)
        comando.Parameters.AddWithValue("@Cod_producto", Codigo)
        comando.Parameters.AddWithValue("@PDefinido", PDefinido)
        comando.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    Public Sub Eliminar_Producto(CodProducto As String)
        conexion.AbrirConexion()

        ' Verificar si hay relaciones en otras tablas antes de eliminar
        Dim tieneRelaciones As Boolean = TieneRelacionesConAlgunaTabla(CodProducto)

        If Not tieneRelaciones Then
            Dim query As String = "DELETE FROM Productos WHERE Cod_producto = @CodProducto"
            Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
            comando.Parameters.AddWithValue("@CodProducto", CodProducto)

            Dim rowAffected As Integer = comando.ExecuteNonQuery()

            If rowAffected > 0 Then
                MsgBox("El producto ha sido eliminado correctamente.")
            End If
        Else
            MsgBox("No se puede eliminar el producto porque tiene relaciones en otras tablas.")
        End If

        conexion.CerrarConexion()
    End Sub

    Private Function TieneRelacionesConAlgunaTabla(CodProducto As String) As Boolean
        Dim query As String =
                         "SELECT 1 FROM DetalleVentas WHERE CodProducto = @CodProducto " &
                         "UNION " &
                         "SELECT 1 FROM DetalleCompras WHERE CodProducto = @CodProducto"

        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@CodProducto", CodProducto)

        Dim reader As SqlDataReader = comando.ExecuteReader()

        If reader.Read() Then
            reader.Close()
            Return True
        Else
            reader.Close()
            Return False
        End If
    End Function



    Public Function BuscarPorId(Cod_producto As String) As SqlDataReader
        Dim query As String = "SELECT * FROM Productos WHERE Cod_producto = @Cod_producto"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Cod_producto", Cod_producto)
        conexion.AbrirConexion()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        Return reader
    End Function

    Public Function GenerarCodigoProducto() As String
        Dim IdProducto As String = ""
        query = "SELECT TOP 1 Cod_producto FROM Productos ORDER BY Cod_producto DESC"
        Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
        conexion.AbrirConexion()

        Dim reader As SqlDataReader = comando.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim ultimoCodigo As Integer = Convert.ToInt32(reader("Cod_producto").ToString().Substring(5))
            IdProducto = "PROD-" & (ultimoCodigo + 1).ToString("D4")
        Else
            IdProducto = "PROD-0001"
        End If

        reader.Close()
        conexion.CerrarConexion()
        Return IdProducto
    End Function

    Public Function Tabla(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Dim conexion As New ConexionSql()
        Dim adapter As New SqlDataAdapter(query, conexion.ObtenerConexion())
        adapter.Fill(table)
        Return table
    End Function
End Class
