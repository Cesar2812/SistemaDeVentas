Imports LogicaNegocio

Public Class ListadoCategoria
    Private categorias As New ServiciosCategorias()
    Public Sub Mostrartodatabla()
        dtg_Categorias.DataSource = categorias.TablaCategoria("SELECT * FROM Categoria")
    End Sub
    Private Sub btn_ListaProductos_Click(sender As Object, e As EventArgs) Handles btn_ListaProductos.Click
        Mostrartodatabla()
    End Sub

    Private Sub ListadoCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class