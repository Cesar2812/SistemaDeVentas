Imports System.Data.SqlClient

Public Class DTelefono
    Private query As String
    Private conexion As ConexionSql = New ConexionSql()

    Public Sub Cerrar()
        conexion.CerrarConexion()
    End Sub

    Public Function GenerarCodigoTele() As String
        Dim IdTele As String = ""
        Try
            conexion.AbrirConexion()
            query = "SELECT TOP 1 Cod_telefono FROM Telefono ORDER BY Cod_telefono DESC"
            Dim comando As SqlCommand = New SqlCommand(query, conexion.ObtenerConexion())
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim ultimoCodigo As Integer = Convert.ToInt32(reader("Cod_telefono").ToString().Substring(6))
                IdTele = "TELEF-" & (ultimoCodigo + 1).ToString("D5") ' Utiliza D5 para asegurarte de tener códigos únicos de 5 dígitos.
            Else
                IdTele = "TELEF-00001" ' Inicializa con el primer código.
            End If

            reader.Close()
        Catch ex As Exception
            MsgBox("Error al generar el código de teléfono: " & ex.Message)
        End Try

        Return IdTele
    End Function
    Private Function VerificarClienteExistente(Cod_cliente As String) As Boolean
        Try
            conexion.AbrirConexion()
            Dim query As String = "SELECT COUNT(*) FROM Cliente WHERE Cod_cliente = @Cod_cliente"

            Using comando As New SqlCommand(query, conexion.ObtenerConexion())
                comando.Parameters.AddWithValue("@Cod_cliente", Cod_cliente)
                Dim rowCount As Integer = CInt(comando.ExecuteScalar())
                ' Si rowCount es mayor que cero, el cliente existe.
                Return rowCount > 0
            End Using
        Catch ex As Exception
            ' Manejar la excepción, por ejemplo, mostrar un mensaje de error o registrar el error.
            MsgBox("Error al verificar la existencia del cliente: " & ex.Message)
            Return False ' En caso de error, consideramos que el cliente no existe.
        Finally
            ' Asegurarse de cerrar la conexión, incluso en caso de excepción.
            conexion.CerrarConexion()
        End Try
    End Function

    Public Sub Insertar_Telefono(Cod_cliente As String, Telefonos As List(Of String), Companias As List(Of String))

        Try
            ' Verificar que el cliente exista en la tabla Cliente.
            If Not VerificarClienteExistente(Cod_cliente) Then
                MsgBox("El cliente no existe en la base de datos.")
                Return
            End If

            conexion.AbrirConexion()
            Dim query As String = "INSERT INTO Telefono(Cod_telefono, CodCliente, Numero, Compania) VALUES (@Cod_telefono, @CodCliente, @Numero, @Compania)"

            For i As Integer = 0 To Telefonos.Count - 1
                Dim numero As String = Telefonos(i)
                Dim compania As String = Companias(i)
                Dim CodTelefono As String = GenerarCodigoTele()

                Using comando As New SqlCommand(query, conexion.ObtenerConexion())
                    comando.Parameters.AddWithValue("@Cod_telefono", CodTelefono)
                    comando.Parameters.AddWithValue("@CodCliente", Cod_cliente)
                    comando.Parameters.AddWithValue("@Numero", numero)
                    comando.Parameters.AddWithValue("@Compania", compania)
                    comando.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            ' Manejar la excepción, por ejemplo, mostrar un mensaje de error o registrar el error.
            MsgBox("Error al insertar datos en la tabla Telefono: " & ex.Message)
        Finally
            ' Asegurarse de cerrar la conexión, incluso en caso de excepción.
            conexion.CerrarConexion()
        End Try
    End Sub

    Public Sub Editar_Telefono(ByVal id As String, ByVal CodCliente As String, ByVal Numero As String, Compania As String)
        conexion.AbrirConexion()
        Dim query As String = "UPDATE Telefono SET CodCliente=@CodCliente, Numero=@Numero, Compania= @Compania WHERE Cod_telefono = @Cod_telefono"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())

        comando.Parameters.AddWithValue("Cod_telefono", id)
        comando.Parameters.AddWithValue("@CodCliente", CodCliente)
        comando.Parameters.AddWithValue("@Numero", Numero)
        comando.Parameters.AddWithValue("@Compania", Compania)

        comando.ExecuteNonQuery()
        conexion.CerrarConexion()
    End Sub

    'Public Sub Eliminar_Telefono_PorNumero(ByVal Numero As String)
    '    conexion.AbrirConexion()
    '    query = "DELETE FROM Telefono WHERE Numero = @Numero"
    '    Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
    '    comando.Parameters.AddWithValue("@Numero", Numero)

    '    Dim rowaffected As Integer = comando.ExecuteNonQuery()
    '    If rowaffected > 0 Then
    '        MsgBox("El teléfono ha sido eliminado correctamente.")
    '    End If
    '    conexion.CerrarConexion()
    'End Sub
    Function NoEsUltimoTelefonoDelUsuario(codTelefono As String) As Boolean
        ' Establece una variable para indicar si el teléfono no es el último
        Dim noEsUltimo As Boolean = False

        conexion.AbrirConexion()

        ' Consulta para contar el número de teléfonos del usuario
        Dim selectQuery As String = "SELECT COUNT(*) FROM Telefono WHERE CodCliente = (SELECT CodCliente FROM Telefono WHERE Cod_telefono = @Cod_telefono)"

        Using cmd As New SqlCommand(selectQuery, conexion.ObtenerConexion())
            cmd.Parameters.AddWithValue("@Cod_telefono", codTelefono)

            Dim telefonoCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Verifica si hay más de un teléfono asociado al usuario
            If telefonoCount > 1 Then
                noEsUltimo = True
            End If
        End Using

        conexion.CerrarConexion()
        Return noEsUltimo
    End Function
    Sub Eliminar_Telefono_PorNumero(codTelefono As String)
        If NoEsUltimoTelefonoDelUsuario(codTelefono) Then
            conexion.AbrirConexion()

            ' Define una consulta SQL para eliminar el teléfono
            Dim deleteQuery As String = "DELETE FROM Telefono WHERE Cod_telefono = @Cod_telefono"

            ' Crea un comando SQL
            Using cmd As New SqlCommand(deleteQuery, conexion.ObtenerConexion())
                cmd.Parameters.AddWithValue("@Cod_telefono", codTelefono)

                ' Ejecuta la consulta de eliminación
                cmd.ExecuteNonQuery()

                ' Cierra la conexión a la base de datos
                conexion.CerrarConexion()

                ' Muestra un mensaje después de la eliminación
                MsgBox("El teléfono ha sido eliminado exitosamente.")
            End Using
        Else
            MsgBox("No se puede eliminar el último teléfono del usuario.")
        End If
    End Sub

    Public Function BuscarPorId(ByVal id As Integer) As SqlDataReader
        Dim query As String = "SELECT * FROM Telefono WHERE ID = @ID"
        Dim comando As New SqlCommand(query, conexion.ObtenerConexion())
        comando.Parameters.AddWithValue("@ID", id)
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

    Public Function ObtenerTelefonosPorCliente(codcliente As String) As DataTable
        Dim telefonos As New DataTable()

        Try
            Dim query As String = "SELECT * FROM Telefono WHERE CodCliente = @CodCliente"

            conexion.AbrirConexion()

            Using command As New SqlCommand(query, conexion.ObtenerConexion())
                command.Parameters.AddWithValue("@CodCliente", codcliente)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(telefonos)
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error al obtener los teléfonos del cliente:: " & ex.Message)
        End Try

        Return telefonos
    End Function

End Class
