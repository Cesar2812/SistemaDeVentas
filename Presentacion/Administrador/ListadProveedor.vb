Imports LogicaNegocio

Public Class ListadProveedor
    Private datos As New ServiciosProveedor()
    Public Sub Mostrartodatabla()
        dg_Proveedor.DataSource = datos.TablaProveedor("SELECT * FROM Proveedor")
    End Sub
    Private Sub btn_ListaProductos_Click(sender As Object, e As EventArgs) Handles btn_ListaProductos.Click
        Mostrartodatabla()
    End Sub
End Class