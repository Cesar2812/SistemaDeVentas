Imports LogicaNegocio


Public Class FrmAlmacen
    Private productos As New ServiciosProductos()

    Private Sub FrmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrartodatabla()
    End Sub

    Public Sub Mostrartodatabla()
        dg_Productos.DataSource = productos.TablaProducto("SELECT * FROM Productos")
        'Cod_producto, Nombre, Stock, Precio_compra, Precio_venta, CodCategoria, CodProveedor, PDefinido
        dg_Productos.Columns("CodProveedor").Visible = False
        dg_Productos.Columns("Precio_compra").Visible = False
        dg_Productos.Columns("Precio_venta").Visible = False
        dg_Productos.Columns("CodCategoria").Visible = False
    End Sub

    Private Sub Buscar_Medidas_TextChanged(sender As Object, e As EventArgs) Handles Buscar_Medidas.TextChanged
        If dg_productos.Rows.Count > 0 Then
            ' Verificar si el TextBox no está vacío después de eliminar espacios en blanco
            Dim textoBuscado As String = Buscar_Medidas.Text.Trim()
            If textoBuscado <> "" Then
                ' Realizar la búsqueda y mostrar los resultados
                Dim resultados = productos.TablaProducto("SELECT Cod_producto, Nombre,CodCategoria, CodProveedor FROM Productos WHERE TRIM(Nombre) LIKE '%" + textoBuscado + "%'")
                If resultados.Rows.Count > 0 Then
                    dg_productos.DataSource = resultados
                Else
                    ' Mostrar un mensaje de error si no se encontraron resultados
                    MessageBox.Show("No se encontraron resultados.", "Error")
                    Buscar_Medidas.Clear()

                End If
            Else
                ' Mostrar toda la tabla
                Mostrartodatabla()
            End If
        Else
            ' Mostrar un mensaje de error si no hay datos en la tabla
            MessageBox.Show("No hay datos en la tabla.", "Error")
        End If

    End Sub

End Class