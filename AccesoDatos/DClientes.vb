Imports System.Data.SqlClient

Public Class DClientes
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()

    Public Sub Cerrar()
        conexion.CerrarConexion()
    End Sub

    'Public Function GenerarCodigoTele() As String
    '    Dim IdTele As String = ""
    '    Try
    '        conexion.AbrirConexion()
    '        query = "SELECT TOP 1 Cod_telefono FROM Telefono ORDER BY Cod_telefono DESC"
    '        Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
    '        Dim reader As SqlDataReader = comando.ExecuteReader()

    '        If reader.HasRows Then
    '            reader.Read()
    '            Dim ultimoCodigo As Integer = Convert.ToInt32(reader("Cod_telefono").ToString().Substring(6))
    '            IdTele = "TELEF-" & (ultimoCodigo + 1).ToString("D5") ' Utiliza D5 para asegurarte de tener códigos únicos de 5 dígitos.
    '        Else
    '            IdTele = "TELEF-00001" ' Inicializa con el primer código.
    '        End If

    '        reader.Close()
    '    Catch ex As Exception
    '        MsgBox("Error al generar el código de teléfono: " & ex.Message)
    '    End Try

    '    Return IdTele
    'End Function
    Public Function GenerarCodigoTele(numeroEtiqueta As Integer) As String
        Dim IdTele As String = ""
        Try
            conexion.AbrirConexion()
            query = "SELECT TOP 1 Cod_telefono FROM Telefono ORDER BY Cod_telefono DESC"
            Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim ultimoCodigo As Integer = Convert.ToInt32(reader("Cod_telefono").ToString().Substring(6))
                IdTele = "TELEF-" & (ultimoCodigo + numeroEtiqueta).ToString("D5")
            Else
                IdTele = "TELEF-" & (numeroEtiqueta).ToString("D5")
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Error al generar el código de teléfono: " & ex.Message)
        End Try

        Return IdTele
    End Function

    Public Sub InsertarCliente(Cod_cliente As String, RUC As String, Nombre As String, Calle As String, Comuna As String, Ciudad As String, CodigoT As List(Of String), Telefonos As List(Of String), Companias As List(Of String), TieneCelular As Boolean)
        ' Asegúrate de que las listas de teléfonos y compañías tengan la misma cantidad de elementos
        If Telefonos.Count <> Companias.Count Then
            MsgBox("La cantidad de teléfonos y compañías no coincide.")
            Return
        End If

        Try
            ' Abrir la conexión
            conexion.AbrirConexion()

            ' Comprobar si ya existe un cliente con el mismo RUC
            query = "SELECT COUNT(*) FROM Cliente WHERE RUC = @RUC"
            Using comando As New SqlCommand(query, conexion.ObtenerConexion())
                comando.Parameters.AddWithValue("@RUC", RUC)
                Dim cantidad As Integer = CInt(comando.ExecuteScalar())
                If cantidad > 0 Then
                    MsgBox("No se puede insertar el cliente porque ya existe un registro con el mismo RUC.")
                    Return
                End If
            End Using

            ' Insertar el cliente en la tabla "Cliente" con el valor correspondiente en la columna "Celular"
            query = "INSERT INTO Cliente (Cod_cliente, RUC, Nombre, Calle, Comuna, Ciudad, Celular) VALUES " &
            "(@Cod_cliente, @RUC, @Nombre, @Calle, @Comuna, @Ciudad, @Celular)"
            Using comando As New SqlCommand(query, conexion.ObtenerConexion())
                comando.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
                comando.Parameters.AddWithValue("@RUC", RUC)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@Calle", Calle)
                comando.Parameters.AddWithValue("@Comuna", Comuna)
                comando.Parameters.AddWithValue("@Ciudad", Ciudad)

                ' Establecer el valor de la columna "Celular" en función de la variable TieneCelular
                If TieneCelular Then
                    comando.Parameters.AddWithValue("@Celular", "Sí")
                Else
                    comando.Parameters.AddWithValue("@Celular", "No")
                End If

                comando.ExecuteNonQuery()
            End Using

            ' Insertar los teléfonos en la tabla "Telefono" si el cliente tiene celular
            If TieneCelular Then
                query = "INSERT INTO Telefono(Cod_telefono, CodCliente, Numero, Compania) VALUES (@Cod_telefono, @CodCliente, @Numero, @Compania)"
                For i As Integer = 0 To Telefonos.Count - 1
                    Dim codigo As String = CodigoT(i)
                    Dim numero As String = Telefonos(i)
                    Dim compania As String = Companias(i)

                    Using comando As New SqlCommand(query, conexion.ObtenerConexion())
                        comando.Parameters.AddWithValue("@Cod_telefono", codigo)
                        comando.Parameters.AddWithValue("@CodCliente", Cod_cliente)
                        comando.Parameters.AddWithValue("@Numero", numero)
                        comando.Parameters.AddWithValue("@Compania", compania)
                        comando.ExecuteNonQuery()
                    End Using
                Next
            End If

        Catch ex As Exception
            MsgBox("Error al insertar datos en la base de datos: " & ex.Message)
        Finally
            ' Cerrar la conexión
            conexion.CerrarConexion()
        End Try
    End Sub



    'Public Sub Editar_Cliente(Cod_cliente As String, RUC As String, Nombre As String, Calle As String, Comuna As String, Ciudad As String)
    '    conexion.AbrirConexion()
    '    Dim query As String = "UPDATE Cliente SET RUC=@RUC, Nombre=@Nombre, Calle=@Calle, Comuna=@Comuna, Ciudad=@Ciudad WHERE Cod_cliente = @Cod_cliente"
    '    Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

    '    comando.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
    '    comando.Parameters.AddWithValue("@RUC", RUC)
    '    comando.Parameters.AddWithValue("@Nombre", Nombre)
    '    comando.Parameters.AddWithValue("@Calle", Calle)
    '    comando.Parameters.AddWithValue("@Comuna", Comuna)
    '    comando.Parameters.AddWithValue("@Ciudad", Ciudad)

    '    comando.ExecuteNonQuery()
    '    conexion.CerrarConexion()
    'End Sub

    'Public Sub Editar_Cliente(Cod_cliente As String, RUC As String, Nombre As String, Calle As String, Comuna As String, Ciudad As String, TieneCelular As Boolean)
    '    conexion.AbrirConexion()
    '    Dim query As String = "UPDATE Cliente SET RUC=@RUC, Nombre=@Nombre, Calle=@Calle, Comuna=@Comuna, Ciudad=@Ciudad WHERE Cod_cliente = @Cod_cliente"
    '    Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

    '    comando.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
    '    comando.Parameters.AddWithValue("@RUC", RUC)
    '    comando.Parameters.AddWithValue("@Nombre", Nombre)
    '    comando.Parameters.AddWithValue("@Calle", Calle)
    '    comando.Parameters.AddWithValue("@Comuna", Comuna)
    '    comando.Parameters.AddWithValue("@Ciudad", Ciudad)

    '    ' Comprobar si el cliente tenía celular y cambió a "No tiene" celular
    '    If Not TieneCelular Then
    '        ' Eliminar los registros de teléfonos del cliente
    '        Dim deleteQuery As String = "DELETE FROM Telefono WHERE CodCliente = @CodCliente"
    '        Dim deleteCommand As New SqlCommand(deleteQuery, conexion.ObtenerConexion())
    '        deleteCommand.Parameters.AddWithValue("@CodCliente", Cod_cliente)
    '        deleteCommand.ExecuteNonQuery()

    '        ' Establecer la columna "Celular" en "Sí" en la tabla de Cliente
    '        Dim updateCelularQuery As String = "UPDATE Cliente SET Celular = 'No' WHERE Cod_cliente = @Cod_cliente"
    '        Dim updateCelularCommand As New SqlCommand(updateCelularQuery, conexion.ObtenerConexion())
    '        updateCelularCommand.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
    '        updateCelularCommand.ExecuteNonQuery()
    '    Else
    '        ' Si el cliente tenía celular, asegurarse de que el estado de "Celular" sea "Sí"
    '        Dim updateCelularQuery As String = "UPDATE Cliente SET Celular = 'Sí' WHERE Cod_cliente = @Cod_cliente"
    '        Dim updateCelularCommand As New SqlCommand(updateCelularQuery, conexion.ObtenerConexion())
    '        updateCelularCommand.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
    '        updateCelularCommand.ExecuteNonQuery()



    '    End If

    '    comando.ExecuteNonQuery()

    '    conexion.CerrarConexion()
    'End Sub
    'Public Sub Editar_Cliente(Cod_cliente As String, RUC As String, Nombre As String, Calle As String, Comuna As String, Ciudad As String, TieneCelular As Boolean, Telefonos As List(Of String), CodigoT As List(Of String), Companias As List(Of String))
    '    conexion.AbrirConexion()
    '    Dim query As String = "UPDATE Cliente SET RUC=@RUC, Nombre=@Nombre, Calle=@Calle, Comuna=@Comuna, Ciudad=@Ciudad, Celular=@Celular WHERE Cod_cliente = @Cod_cliente"
    '    Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

    '    comando.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
    '    comando.Parameters.AddWithValue("@RUC", RUC)
    '    comando.Parameters.AddWithValue("@Nombre", Nombre)
    '    comando.Parameters.AddWithValue("@Calle", Calle)
    '    comando.Parameters.AddWithValue("@Comuna", Comuna)
    '    comando.Parameters.AddWithValue("@Ciudad", Ciudad)
    '    comando.Parameters.AddWithValue("@Celular", If(TieneCelular, "No", "Sí"))

    '    ' Comprobar si el cliente tenía celular y cambió a "No tiene" celular
    '    If TieneCelular Then
    '        ' Eliminar los registros de teléfonos del cliente
    '        Dim deleteQuery As String = "DELETE FROM Telefono WHERE CodCliente = @CodCliente"
    '        Dim deleteCommand As New SqlCommand(deleteQuery, conexion.ObtenerConexion())
    '        deleteCommand.Parameters.AddWithValue("@CodCliente", Cod_cliente)
    '        deleteCommand.ExecuteNonQuery()
    '    Else
    '        ' Si el cliente no tenía celular, asegurarse de que el estado de "Celular" sea "Sí"
    '        Dim updateCelularQuery As String = "UPDATE Cliente SET Celular = 'Sí' WHERE Cod_cliente = @Cod_cliente"
    '        Dim updateCelularCommand As New SqlCommand(updateCelularQuery, conexion.ObtenerConexion())
    '        updateCelularCommand.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
    '        updateCelularCommand.ExecuteNonQuery()

    '        ' Insertar registros de teléfonos en la tabla "Telefono"
    '        Dim insertTelefonoQuery As String = "INSERT INTO Telefono(Cod_telefono, CodCliente, Numero, Compania) VALUES (@Cod_telefono, @CodCliente, @Numero, @Compania)"
    '        For i As Integer = 0 To Telefonos.Count - 1
    '            Dim codigo As String = CodigoT(i)
    '            Dim numero As String = Telefonos(i)
    '            Dim compania As String = Companias(i)

    '            Using telefonoCommand As New SqlCommand(insertTelefonoQuery, conexion.ObtenerConexion())
    '                telefonoCommand.Parameters.AddWithValue("@Cod_telefono", codigo)
    '                telefonoCommand.Parameters.AddWithValue("@CodCliente", Cod_cliente)
    '                telefonoCommand.Parameters.AddWithValue("@Numero", numero)
    '                telefonoCommand.Parameters.AddWithValue("@Compania", compania)
    '                telefonoCommand.ExecuteNonQuery()
    '            End Using
    '        Next
    '    End If

    '    comando.ExecuteNonQuery()

    '    conexion.CerrarConexion()
    'End Sub
    Public Sub Editar_Cliente(Cod_cliente As String, RUC As String, Nombre As String, Calle As String, Comuna As String, Ciudad As String, TieneCelular As Boolean, Telefonos As List(Of String), CodigoT As List(Of String), Companias As List(Of String))
        conexion.AbrirConexion()

        ' Verificar el estado actual de "Celular"
        Dim estadoActual As String
        Dim estadoCelularQuery As String = "SELECT Celular FROM Cliente WHERE Cod_cliente = @Cod_cliente"
        Dim estadoCelularCommand As New SqlCommand(estadoCelularQuery, conexion.ObtenerConexion())
        estadoCelularCommand.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
        estadoActual = estadoCelularCommand.ExecuteScalar().ToString()

        ' Actualizar el estado de "Celular" solo si cambia
        If (estadoActual = "Sí" AndAlso Not TieneCelular) OrElse (estadoActual = "No" AndAlso TieneCelular) Then
            ' Actualizar el estado de "Celular"
            Dim nuevoEstado As String = If(TieneCelular, "Sí", "No")
            Dim actualizarCelularQuery As String = "UPDATE Cliente SET Celular = @Celular WHERE Cod_cliente = @Cod_cliente"
            Dim actualizarCelularCommand As New SqlCommand(actualizarCelularQuery, conexion.ObtenerConexion())
            actualizarCelularCommand.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
            actualizarCelularCommand.Parameters.AddWithValue("@Celular", nuevoEstado)
            actualizarCelularCommand.ExecuteNonQuery()

            ' Si cambia a "No tiene" celular, eliminar los registros de teléfonos del cliente
            If Not TieneCelular Then
                Dim eliminarTelefonosQuery As String = "DELETE FROM Telefono WHERE CodCliente = @CodCliente"
                Dim eliminarTelefonosCommand As New SqlCommand(eliminarTelefonosQuery, conexion.ObtenerConexion())
                eliminarTelefonosCommand.Parameters.AddWithValue("@CodCliente", Cod_cliente)
                eliminarTelefonosCommand.ExecuteNonQuery()
            End If
        End If

        ' Ahora puedes actualizar otros campos y agregar registros de teléfonos si es necesario
        Dim query As String = "UPDATE Cliente SET RUC=@RUC, Nombre=@Nombre, Calle=@Calle, Comuna=@Comuna, Ciudad=@Ciudad WHERE Cod_cliente = @Cod_cliente"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

        comando.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
        comando.Parameters.AddWithValue("@RUC", RUC)
        comando.Parameters.AddWithValue("@Nombre", Nombre)
        comando.Parameters.AddWithValue("@Calle", Calle)
        comando.Parameters.AddWithValue("@Comuna", Comuna)
        comando.Parameters.AddWithValue("@Ciudad", Ciudad)
        comando.ExecuteNonQuery()

        ' Insertar registros de teléfonos en la tabla "Telefono"
        Dim insertTelefonoQuery As String = "INSERT INTO Telefono(Cod_telefono, CodCliente, Numero, Compania) VALUES (@Cod_telefono, @CodCliente, @Numero, @Compania)"
        For i As Integer = 0 To Telefonos.Count - 1
            Dim codigo As String = CodigoT(i)
            Dim numero As String = Telefonos(i)
            Dim compania As String = Companias(i)

            Using telefonoCommand As New SqlCommand(insertTelefonoQuery, conexion.ObtenerConexion())
                telefonoCommand.Parameters.AddWithValue("@Cod_telefono", codigo)
                telefonoCommand.Parameters.AddWithValue("@CodCliente", Cod_cliente)
                telefonoCommand.Parameters.AddWithValue("@Numero", numero)
                telefonoCommand.Parameters.AddWithValue("@Compania", compania)
                telefonoCommand.ExecuteNonQuery()
            End Using
        Next

        conexion.CerrarConexion()
    End Sub


    Public Sub Eliminar_Cliente(Cod_cliente As String)
        conexion.AbrirConexion()

        ' Verificar si hay relaciones en otras tablas antes de eliminar
        Dim tieneRelaciones As Boolean = TieneRelacionesConAlgunaTabla(Cod_cliente)

        If Not tieneRelaciones Then
            Dim query As String = "DELETE FROM Cliente WHERE Cod_cliente = @Cod_cliente"
            Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
            comando.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)

            Dim rowAffected As Integer = comando.ExecuteNonQuery()

            If rowAffected > 0 Then
                MsgBox("El cliente ha sido eliminado correctamente.")
            End If
        Else
            MsgBox("No se puede eliminar el cliente porque tiene relaciones en otras tablas.")
        End If

        conexion.CerrarConexion()
    End Sub

    Private Function TieneRelacionesConAlgunaTabla(CodCliente As String) As Boolean
        Dim query As String =
                         "SELECT 1 FROM Ventas WHERE CodCliente = @CodCliente "

        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@CodCliente", CodCliente)

        Dim reader As SqlDataReader = comando.ExecuteReader()

        If reader.Read() Then
            reader.Close()
            Return True
        End If

        reader.Close()
        Return False

    End Function

    Public Function BuscarPorId(Cod_cliente As String) As SqlDataReader
        Dim query As String = "SELECT * FROM Cliente WHERE Cod_cliente = @Cod_cliente"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
        conexion.AbrirConexion()
        Dim reader As SqlDataReader = comando.ExecuteReader()
        Return reader
    End Function

    Public Function GenerarCodigoCliente() As String
        Dim IdCliente As String = ""
        query = "SELECT TOP 1 Cod_cliente FROM Cliente ORDER BY Cod_cliente DESC"
        Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
        conexion.AbrirConexion()

        Dim reader As SqlDataReader = comando.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim ultimoCodigo As Integer = Convert.ToInt32(reader("Cod_cliente").ToString().Substring(8))
            IdCliente = "CLIENTE-" & (ultimoCodigo + 1).ToString("D4")
        Else
            IdCliente = "CLIENTE-0001"
        End If

        reader.Close()
        conexion.CerrarConexion()
        Return IdCliente
    End Function

    Public Function Tabla(ByVal query As String) As DataTable
        Dim table As New DataTable()
        Dim conexion As New ConexionSql()
        Dim adapter As New SqlDataAdapter(query, conexion.ObtenerConexion())
        adapter.Fill(table)
        Return table
    End Function
End Class
