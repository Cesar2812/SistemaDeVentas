Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports LogicaNegocio
Imports Org.BouncyCastle.Utilities

Public Class FrmProductos
    Private productos As New ServiciosProductos()
    Private proveedor As New ServiciosProveedor()
    Private categorias As New ServiciosCategorias()
    Dim validador As Boolean

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cancelar_btn.Enabled = False
        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Agregar_btn.Enabled = False

        label10.Visible = False
        Label2.Visible = False
        Proveedor_cmbx.Visible = False
        Categorias_cmbx.Visible = False



        pnPrecio.Visible = False
        Mostrartodatabla()
        mostrarcodi()
        Cargarcategorias()
        Cargarproveedor()
        'Proveedor_cmbx.SelectedIndex = 0
    End Sub
    Public Sub Cargarproveedor()
        Proveedor_cmbx.DataSource = proveedor.TablaProveedor("SELECT * FROM Proveedor")
        Proveedor_cmbx.DisplayMember = "Nombre"
        Proveedor_cmbx.ValueMember = "Cod_proveedor"
    End Sub

    Public Sub Cargarcategorias()
        Categorias_cmbx.DataSource = categorias.TablaCategoria("SELECT * FROM Categorias")
        Categorias_cmbx.DisplayMember = "Nombre"
        Categorias_cmbx.ValueMember = "Cod_categoria"
    End Sub
    Public Sub mostrarcodi()
        Dim codigo As String = productos.GenerarCodigoProducto()
        Id_Producto.Clear()
        Id_Producto.Text = codigo
    End Sub
    Private Sub Limpiar()
        Descripcion_Producto.Clear()
        Valor_Producto.Clear()

        For Each control As Control In Me.Controls ' Recorre todos los controles en el formulario actual.
            If TypeOf control Is RadioButton Then ' Verifica si el control es un RadioButton.
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                radioButton.Checked = False ' Desmarca el RadioButton.
            End If
        Next

    End Sub
    Private Sub Cancelar_btn_Click(sender As Object, e As EventArgs) Handles Cancelar_btn.Click

        Limpiar()
        Descripcion_Producto.ReadOnly = True
        Valor_Producto.ReadOnly = True

        pnPrecio.Visible = False
        rb_pd.Visible = True
        rbTieneCelular.Visible = True

        label10.Visible = False
        Label2.Visible = False
        Proveedor_cmbx.Visible = False
        Categorias_cmbx.Visible = False


        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Agregar_btn.Enabled = False
        Cancelar_btn.Enabled = False
        Nuevo_btn.Enabled = True
        mostrarcodi()
    End Sub
    Public Sub Mostrartodatabla()
        dg_Productos.DataSource = productos.TablaProducto("SELECT * FROM Productos")
        'Cod_producto, Nombre, Stock, Precio_compra, Precio_venta, CodCategoria, CodProveedor, PDefinido
        dg_Productos.Columns("CodProveedor").Visible = False
        dg_Productos.Columns("Precio_compra").Visible = False
        dg_Productos.Columns("Precio_venta").Visible = False
        dg_Productos.Columns("CodCategoria").Visible = False
    End Sub
    Private Function Validar_Campos() As Boolean
        If String.IsNullOrWhiteSpace(Descripcion_Producto.Text) Then
            validador = False
            MessageBox.Show("Rellene los campos antes de realizar una operacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            validador = True
        End If
        Return validador
    End Function
    Private Sub Eliminar_btn_Click(sender As Object, e As EventArgs) Handles Eliminar_btn.Click
        Try

            If Validar_Campos() = True Then
                productos.EliminarProducto(Id_Producto.Text)
                Mostrartodatabla()
                'Editar_btn.Enabled = False
                'Eliminar_btn.Enabled = False
                'Agregar_btn.Enabled = False
                Cancelar_btn.PerformClick()
                Limpiar()
                mostrarcodi()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Editar_btn_Click(sender As Object, e As EventArgs) Handles Editar_btn.Click
        Try
            If Validar_Campos() = True Then
                Dim codigo As String = Id_Producto.Text
                Dim descripcion As String = Descripcion_Producto.Text
                Dim categoria As String = Categorias_cmbx.Text
                Dim proveedor As String = Proveedor_cmbx.Text

                Dim PDefinido As String = "Sí"
                Dim valor_compra As String = "0"
                Dim valor_venta As String = "0"



                productos.EditarProducto(codigo, descripcion, valor_compra, valor_venta, categoria, proveedor, PDefinido)
                MessageBox.Show("Producto actualizado con exito", "Proceso culminado existosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Mostrartodatabla()
                Cancelar_btn.PerformClick()
                mostrarcodi()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Nuevo_btn_Click(sender As Object, e As EventArgs) Handles Nuevo_btn.Click
        Editar_btn.Enabled = False
        Agregar_btn.Enabled = True
        Eliminar_btn.Enabled = False
        Cancelar_btn.Enabled = True


        label10.Visible = True
        Label2.Visible = True
        Proveedor_cmbx.Visible = True
        Categorias_cmbx.Visible = True


        Descripcion_Producto.ReadOnly = False
        Valor_Producto.ReadOnly = False
        mostrarcodi()
    End Sub

    Private Sub Agregar_btn_Click(sender As Object, e As EventArgs) Handles Agregar_btn.Click
        Try
            If Validar_Campos() = True Then
                Dim codigo As String = Id_Producto.Text
                Dim nombre As String = Descripcion_Producto.Text
                Dim categoria As String = Categorias_cmbx.SelectedValue
                Dim proveedor As String = Proveedor_cmbx.SelectedValue

                Dim stock As String = "0"
                Dim valor_compra As String = "0"
                Dim valor_venta As String = "0"

                Dim preciodefinido As Boolean

                If rb_pd.Checked Then
                    preciodefinido = True
                    valor_compra = Valor_Producto.Text ' Tomar el valor de compra del TextBox
                    valor_venta = TextBox1.Text   ' Tomar el valor de venta del TextBox

                ElseIf rbTieneCelular.Checked Then
                    preciodefinido = False
                Else
                    MsgBox("Por favor, seleccione si el cliente tiene o no tiene celular.")
                    Return
                End If
                productos.InsertarProducto(codigo, nombre, stock, valor_compra, valor_venta, categoria, proveedor, preciodefinido)
                Mostrartodatabla()
                label10.Visible = False
                Label2.Visible = False
                Proveedor_cmbx.Visible = False
                Categorias_cmbx.Visible = False
                Limpiar()
                mostrarcodi()
                Descripcion_Producto.ReadOnly = True
                Valor_Producto.ReadOnly = True
                Id_Producto.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub dtg_Productos_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dg_Productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Productos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dg_Productos.Rows(e.RowIndex)

            Id_Producto.Text = fila.Cells(0).Value.ToString()
            Descripcion_Producto.Text = fila.Cells(1).Value.ToString()
            Categorias_cmbx.Text = fila.Cells(4).Value.ToString()
            Proveedor_cmbx.Text = fila.Cells(5).Value.ToString()
            Valor_Producto.Text = fila.Cells(3).Value.ToString()
            TextBox1.Text = fila.Cells(2).Value.ToString()

            label10.Visible = True
            Label2.Visible = True
            Proveedor_cmbx.Visible = True
            Categorias_cmbx.Visible = True

            pnPrecio.Visible = True
            rb_pd.Visible = False
            rbTieneCelular.Visible = False

            Descripcion_Producto.ReadOnly = False
            Valor_Producto.ReadOnly = False

            Agregar_btn.Enabled = False
            Nuevo_btn.Enabled = False

            Editar_btn.Enabled = True
            Eliminar_btn.Enabled = True
            Cancelar_btn.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btn_Exporta_Click(sender As Object, e As EventArgs) Handles btn_Exporta.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a Excel?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If dg_Productos.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a Excel.")
            Else
                Dim exportadorExce As New ExportarExcel
                exportadorExce.ExportarDataExcel(dg_Productos)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a pdf?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If dg_Productos.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a PDF.")
            Else
                Dim exportadorPDF As New Exportarpdf(dg_Productos, Me)
                exportadorPDF.ExportarPDF()
            End If
        End If
    End Sub

    Private Sub rbNotieneCelular_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pd.CheckedChanged
        pnPrecio.Visible = True
    End Sub

    Private Sub rbTieneCelular_CheckedChanged(sender As Object, e As EventArgs) Handles rbTieneCelular.CheckedChanged
        pnPrecio.Visible = False
    End Sub

    Private Sub Valor_Producto_TextChanged(sender As Object, e As EventArgs) Handles Valor_Producto.TextChanged
        If Not String.IsNullOrEmpty(Valor_Producto.Text) Then
            Dim precioCompra As Double
            If Double.TryParse(Valor_Producto.Text, precioCompra) Then
                Dim precioVenta As Double = precioCompra + 3.0
                TextBox1.Text = precioVenta.ToString()
            Else
                ' Si el valor ingresado no es un número válido, puedes manejarlo aquí
                MessageBox.Show("Por favor, ingrese un valor numérico válido en tx_preciocompra.")
            End If
        Else
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FrmCategorias As New FrmCategorias()
        FrmCategorias.ShowDialog()
    End Sub

    Private Sub panel9_Paint(sender As Object, e As PaintEventArgs) Handles panel9.Paint

    End Sub

    Private Sub btnBuscar_Medidas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Buscar_Medidas_TextChanged(sender As Object, e As EventArgs) Handles Buscar_Medidas.TextChanged
        If dg_Productos.Rows.Count > 0 Then
            ' Verificar si el TextBox no está vacío después de eliminar espacios en blanco
            Dim textoBuscado As String = Buscar_Medidas.Text.Trim()
            If textoBuscado <> "" Then
                ' Realizar la búsqueda y mostrar los resultados
                Dim resultados = productos.TablaProducto("SELECT Cod_producto, Nombre,CodCategoria, CodProveedor FROM Productos WHERE TRIM(Nombre) LIKE '%" + textoBuscado + "%'")
                If resultados.Rows.Count > 0 Then
                    dg_Productos.DataSource = resultados
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