Imports AccesoDatos
Imports System.Data.SqlClient
Public Class ServiciosClientes
    Private ClienteDatos As DClientes = New DClientes()
    Public Sub InsertarCliente(Cod_cliente As String, RUC As String, Nombre As String, Calle As String, Comuna As String, Ciudad As String, CodigoT As List(Of String), Telefonos As List(Of String), Companias As List(Of String), TieneCelular As Boolean)
        ClienteDatos.InsertarCliente(Cod_cliente, RUC, Nombre, Calle, Comuna, Ciudad, CodigoT, Telefonos, Companias, TieneCelular)
    End Sub

    Public Sub EditarCliente(Cod_cliente As String, RUC As String, Nombre As String, Calle As String, Comuna As String, Ciudad As String, TieneCelular As Boolean, Telefonos As List(Of String), CodigoT As List(Of String), Companias As List(Of String))
        ClienteDatos.Editar_Cliente(Cod_cliente, RUC, Nombre, Calle, Comuna, Ciudad, TieneCelular, Telefonos, CodigoT, Companias)
    End Sub

    Public Sub EliminarCliente(Cod_cliente As String)
        ClienteDatos.Eliminar_Cliente(Cod_cliente)
    End Sub

    Public Function BuscarClientePorId(Cod_cliente As String) As SqlDataReader
        Return ClienteDatos.BuscarPorId(Cod_cliente)
    End Function

    Public Function GenerarCodigoCliente() As String
        Return ClienteDatos.GenerarCodigoCliente()
    End Function

    Public Function TablaCliente(query As String) As DataTable
        Return ClienteDatos.Tabla(query)
    End Function

    Public Function CodigoTelefono(numeroEtiqueta As Integer) As String
        Return ClienteDatos.GenerarCodigoTele(numeroEtiqueta)
    End Function


End Class
