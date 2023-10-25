Imports AccesoDatos
Imports System.Data.SqlClient
Public Class ServiciosCategorias
    Private CategoriaDatos As DCategorias = New DCategorias()

    Public Sub InsertarCategoria(Cod_categoria As String, Nombre As String)
        CategoriaDatos.Insertar_Categoria(Cod_categoria, Nombre)
    End Sub

    Public Sub EditarCategoria(Cod_categoria As String, Nombre As String)
        CategoriaDatos.Editar_Categoria(Cod_categoria, Nombre)
    End Sub

    Public Sub EliminarCategoria(Cod_categoria As String)
        CategoriaDatos.Eliminar_Categoria(Cod_categoria)
    End Sub

    Public Function BuscarCategoriaPorId(Cod_categoria As String) As SqlDataReader
        Return CategoriaDatos.BuscarxId(Cod_categoria)
    End Function

    Public Function GenerarCodigoCategoria() As String
        Return CategoriaDatos.GenerarCodigoCategoria()
    End Function

    Public Function TablaCategoria(query As String) As DataTable
        Return CategoriaDatos.Tabla(query)
    End Function

End Class
