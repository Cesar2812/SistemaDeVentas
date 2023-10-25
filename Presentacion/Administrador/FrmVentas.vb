Imports System.Net.Http
Imports System.Reflection.Emit
Imports System.Text
Imports iTextSharp
Imports LogicaNegocio
Imports Org.BouncyCastle.Utilities

Public Class FrmVentas
    Public Sub SetLabelValues(valorLabel1 As String)
        tb_cliente.Text = valorLabel1
    End Sub

    Private venta As New ServiciosVentas()
    Private detalleventa As New ServiciosDVentas()
    Private productos As New ServiciosProductos()

    Dim codigoCliente As String = ""
    Private descuentoAplicado As Double = 0.0
    Private descuentoEspecificado As Double = 0.0
    Private total As Double = 0.0

    Public Sub New()
        InitializeComponent()
        NumericUpDown1.Value = 2
        NumericUpDown1.Minimum = 2
        AddHandler dt_detalleventa.CellPainting, AddressOf dt_detalleventa_CellPainting
    End Sub
    Private Sub ConfigurarTextBoxes()
        tb_precioventa.ReadOnly = True
        tb_precioventa.BackColor = Color.White
        tb_cliente.ReadOnly = True
        tb_cliente.BackColor = Color.White
        tb_descripcion.ReadOnly = True
        tb_descripcion.BackColor = Color.White

        tb_factura.ReadOnly = True
        tb_factura.BackColor = Color.PaleTurquoise

        tb_subtotal.ReadOnly = True
        tb_subtotal.BackColor = Color.PapayaWhip
        tb_descuento.ReadOnly = True
        tb_descuento.BackColor = Color.PapayaWhip
        tb_total.ReadOnly = True
        tb_total.BackColor = Color.PapayaWhip
        tb_pago.ReadOnly = True
        tb_pago.BackColor = Color.PapayaWhip
        tb_cambios.ReadOnly = True
        tb_cambios.BackColor = Color.PapayaWhip
        'tb_Proveedor.ReadOnly = True
        'tb_Proveedor.BackColor = Color.PapayaWhip
        'tb_Categoria.ReadOnly = True
        'tb_Categoria.BackColor = Color.PapayaWhip
    End Sub

    Public Sub mostrarcodi()
        Dim codigo As String = venta.GenerarCodigoVentas()
        tb_factura.Clear()
        tb_factura.Text = codigo
    End Sub


    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        btn_Verfactura.Visible = False
        mostrarcodi()
        Label14.Visible = False
        mostrarcodi()
        ConfigurarTextBoxes()

    End Sub
    Public Sub Mostrartodatabla()
        dtg_Productos.DataSource = venta.TablaVentas("SELECT Cod_producto,Nombre,Precio_venta,Stock FROM Productos")
        dtg_Productos.Columns("Cod_producto").Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ListaCliente As New ListadoCliente(Me)
        ListaCliente.ShowDialog()
    End Sub

    Private Function ObtenerDatosFactura() As String
        Dim plantillaFactura As String = My.Resources.FacturaV
        Dim tablaDatosHTML As New StringBuilder()

        Dim Subtotal As Double
        Dim Descuento As Double
        Dim MontoTotal As Double
        Dim Pago As Double
        Dim Cambio As Double



        ' Verificar si el CheckBox está marcado
        If CheckBoxDescuento.Checked Then
            ' Intentar analizar el valor del TextBox para el descuento
            If Double.TryParse(tb_descuento.Text, Descuento) AndAlso Double.TryParse(tb_subtotal.Text, Subtotal) AndAlso Double.TryParse(tb_pago.Text, Pago) AndAlso Double.TryParse(tb_cambios.Text, Cambio) Then

                MontoTotal = Subtotal - Descuento
                Cambio = Pago - MontoTotal
            Else
                MessageBox.Show("Error en el descuento: Valor no válido")
                Return ""
            End If
        Else
            Descuento = 0
            If Double.TryParse(tb_subtotal.Text, Subtotal) AndAlso Double.TryParse(tb_pago.Text, Pago) AndAlso Double.TryParse(tb_cambios.Text, Cambio) Then
                MontoTotal = Subtotal ' Si no hay descuento, MontoTotal es igual a Subtotal
                Cambio = Pago - MontoTotal
            Else
                MessageBox.Show("Error en el subtotal: Valor no válido")
                Return ""
            End If
        End If

        For Each row As DataGridViewRow In dt_detalleventa.Rows
            If Not row.IsNewRow Then
                Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd") '
                Dim Factura As String = row.Cells("Factura").Value.ToString()
                Dim Codigo As String = row.Cells("Cod_Producto").Value.ToString()
                Dim CodCliente As String = row.Cells("Cliente").Value.ToString()

                plantillaFactura = plantillaFactura.Replace("{NFactura}", Factura)
                plantillaFactura = plantillaFactura.Replace("{Fecha}", Fecha)
                plantillaFactura = plantillaFactura.Replace("{CodCliente}", CodCliente)
                plantillaFactura = plantillaFactura.Replace("{Subtotal}", Subtotal)
                plantillaFactura = plantillaFactura.Replace("{Descuento}", Descuento)
                plantillaFactura = plantillaFactura.Replace("{Total}", MontoTotal)
                plantillaFactura = plantillaFactura.Replace("{Cambio}", Cambio)
                plantillaFactura = plantillaFactura.Replace("{Pago}", Pago)

                Dim CodigoDetalle As String = row.Cells("Cod_detalle").Value.ToString()
                Dim CodigoProducto As String = row.Cells("Cod_Producto").Value.ToString()
                Dim Cantidad As String = row.Cells("Cantidad").Value.ToString()
                Dim MontoPorProducto As String = row.Cells("MontoxProducto").Value.ToString()

                ' Construir una fila de la tabla HTML con los datos de la fila actual
                Dim filaHTML As String = $"<tr><td>{CodigoDetalle}</td><td>{CodigoProducto}</td><td>{Cantidad}</td><td>{MontoPorProducto}</td></tr>"
                tablaDatosHTML.Append(filaHTML)
            Else
                MessageBox.Show("Error en los datos de la fila: " & row.Index + 1)
            End If
        Next

        plantillaFactura = plantillaFactura.Replace("{TablaDatos}", tablaDatosHTML.ToString())
        Return plantillaFactura
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_Verfactura.Click
        Dim facturaHTML As String = ObtenerDatosFactura()

        ' Crear una instancia del formulario frmfactura
        Dim frmFactura As New Factura()

        ' Configurar el control WebBrowser para mostrar la factura HTML
        frmFactura.WebBrowser1.DocumentText = facturaHTML

        ' Mostrar el formulario frmfactura como cuadro de diálogo
        frmFactura.ShowDialog()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btn_ListaProductos_Click(sender As Object, e As EventArgs) Handles btn_ListaProductos.Click
        Mostrartodatabla()
    End Sub

    Private Sub CheckBoxDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDescuento.CheckedChanged
        If dt_detalleventa.RowCount > 0 Then
            ' Hay datos en el DataGridView
            If CheckBoxDescuento.Checked Then
                NumericUpDown1.Visible = True
                Label13.Visible = True
                CalcularDes()
            Else
                NumericUpDown1.Visible = False
                Label13.Visible = False
                tb_descuento.Clear()
                tb_total.Text = tb_subtotal.Text
            End If
        Else
            ' No hay datos en el DataGridView, muestra un MessageBox con el mensaje de error
            MessageBox.Show("No se pueden aplicar descuentos porque no hay datos insertados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dtg_Productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Productos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dtg_Productos.Rows(e.RowIndex)
            tb_descripcion.Text = fila.Cells(1).Value.ToString()
            tb_precioventa.Text = fila.Cells(2).Value.ToString()
            Label14.Text = fila.Cells(0).Value.ToString()

        End If
    End Sub
    Private Sub RealizarVenta()
        Try
            Try
                Dim NFactura As String = tb_factura.Text ' Obtener el número de factura desde la interfaz de usuario
                Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd") ' Obtener la fecha actual
                Dim estado As String = "Realizada"
                ' Inicializar descuento en 0 por defecto
                Dim descuento As Double = 0
                ' Verificar si el CheckBox está marcado
                If CheckBoxDescuento.Checked Then
                    ' Convertir el descuento solo si el CheckBox está marcado
                    If Double.TryParse(tb_descuento.Text, descuento) Then
                        ' La conversión fue exitosa, "descuento" contiene el valor convertido
                    Else
                        ' El contenido de tbxAplicado.Text no es válido
                        MessageBox.Show("El descuento no es un número válido.")
                        Return ' Salir de la función debido al error
                    End If
                End If

                ' Convertir el monto total
                Dim montototal As Double
                If Double.TryParse(tb_total.Text, montototal) Then
                Else
                    ' El contenido de tb_total.Text no es válido
                    MessageBox.Show("El monto total no es un número válido.")
                    Return ' Salir de la función debido al error
                End If

                venta.InsertarNuevaVenta(NFactura, Fecha, codigoCliente, descuento, montototal, estado)

                For Each row As DataGridViewRow In dt_detalleventa.Rows
                    If Not row.IsNewRow Then ' Verificar si la fila no es una fila nueva (si se utiliza una fila para agregar nuevos datos)
                        Dim CodDetalle As String = row.Cells("Cod_detalle").Value.ToString()
                        Dim Factura As String = row.Cells("Factura").Value.ToString()
                        Dim Codigo As String = row.Cells("Cod_Producto").Value.ToString()
                        Dim PrecioVentaNuevocodigo As String = row.Cells("PrecioV").Value.ToString()
                        ' Convertir la cantidad y MontoxProducto solo si los valores son numéricos
                        Dim Cantidad As Double
                        Dim MontoxProducto As Double

                        If Double.TryParse(row.Cells("Cantidad").Value.ToString(), Cantidad) AndAlso Double.TryParse(row.Cells("MontoxProducto").Value.ToString(), MontoxProducto) Then

                            productos.DescontarStock(Codigo, Cantidad)
                            detalleventa.InsertarDetalleVenta(CodDetalle, NFactura, Codigo, Cantidad, MontoxProducto)
                        Else
                            ' Manejar el caso en que los valores no sean numéricos
                            MessageBox.Show("Error en los datos numéricos de la fila: " & row.Index + 1)
                        End If
                    Else
                        ' Manejar el caso en que los valores no sean numéricos
                        MessageBox.Show("Error en los datos numéricos de la fila: " & row.Index + 1)
                    End If

                Next



            Catch ex As Exception
                MessageBox.Show("Se produjo un error al insertar en la base de datos: " & ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show("Se produjo un error al realizar la venta: " & ex.Message)
        End Try
    End Sub
    Private Sub btn_Vender_Click(sender As Object, e As EventArgs) Handles btn_Vender.Click

        If dt_detalleventa.RowCount > 0 Then
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea realizar venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                RealizarVenta()

                ' Desmarca el CheckBox solo si está marcado
                If CheckBoxDescuento.Checked Then
                    CheckBoxDescuento.Checked = False
                End If

                ' Elimina la columna "Eliminar" del DataGridView si existe
                If dt_detalleventa.Columns.Contains("Eliminar") Then
                    dt_detalleventa.Columns.Remove("Eliminar")
                End If

                ' Limpia el DataGridView
                dt_detalleventa.DataSource = Nothing

                ' Establece el valor del NumericUpDown a 2
                NumericUpDown2.Value = 2 ' Puedes establecerlo en 2 como mencionaste

                ' Limpia todos los TextBox en el formulario, incluyendo los que están dentro de paneles
                For Each ctrl As Control In Me.Controls
                    If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "tb_factura" Then
                        DirectCast(ctrl, TextBox).Text = ""
                    End If
                Next


                tb_subtotal.Clear()
                tb_total.Clear()
                tb_cambios.Clear()
                tb_pago.Clear()
                Mostrartodatabla()
                mostrarcodi()
            End If
        Else
            ' No hay datos en el DataGridView, muestra un MessageBox con el mensaje de error
            MessageBox.Show("No se puede realizar venta sin eleccion de productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub
    Private Sub CalcularSubtotal()
        Dim subtotal As Double = 0.0
        Dim dt As DataTable = DirectCast(dt_detalleventa.DataSource, DataTable)
        For Each row As DataGridViewRow In dt_detalleventa.Rows
            If Not row.IsNewRow Then
                subtotal += Convert.ToDouble(row.Cells("MontoxProducto").Value)
            End If
        Next
        tb_subtotal.Text = subtotal.ToString()
        tb_total.Text = tb_subtotal.Text
    End Sub

    Private Sub CalcularDes()
        If CheckBoxDescuento.Checked AndAlso Not String.IsNullOrEmpty(NumericUpDown1.Text) Then
            Dim valorDouble As Double
            If Double.TryParse(NumericUpDown1.Text, valorDouble) Then
                If valorDouble >= 2 AndAlso valorDouble <= 80 Then
                    descuentoEspecificado = valorDouble / 100
                    Dim subtotal As Double = Double.Parse(tb_subtotal.Text)

                    descuentoAplicado = subtotal * descuentoEspecificado
                    total = subtotal - descuentoAplicado
                    tb_descuento.Text = descuentoAplicado.ToString()
                    tb_total.Text = total.ToString()

                Else
                    MessageBox.Show("El valor debe estar en el rango de 2% a 80%.")
                End If
            Else
                MessageBox.Show("El valor ingresado no es válido.")
            End If
        Else
            tb_descuento.Text = ""

        End If
    End Sub

    Public Sub Limpiar()
        tb_descripcion.Clear()
        tb_descripcion.Clear()
        NumericUpDown2.Value = 0
        tb_precioventa.Clear()
    End Sub
    Private Function GenerarCodigoDetallecompra() As String
        If dt_detalleventa.Rows.Count > 0 Then
            ' Si hay filas en el DataGridView, determinar el último código de detalle existente
            Dim ultimaFila As DataGridViewRow = dt_detalleventa.Rows(dt_detalleventa.Rows.Count - 1)
            Dim ultimoCodigoDetalle As String = ultimaFila.Cells("Cod_detalle").Value.ToString()
            ' Extraer el número de detalle actual
            Dim numeroActual As Integer = Integer.Parse(ultimoCodigoDetalle.Substring(3))
            ' Calcular el próximo código de detalle
            Dim numeroSiguiente As Integer = numeroActual + 1
            Dim codigoDetalle As String = "DV-" & numeroSiguiente.ToString("D4")
            Return codigoDetalle
        Else
            ' Si no hay filas en el DataGridView, establecer el código de detalle inicial
            Return "DV-0001"
        End If
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        tb_pago.ReadOnly = False
        Try
            ' Verificar que ningún campo esté vacío y que la cantidad no sea 0
            If Not String.IsNullOrEmpty(tb_factura.Text) AndAlso Not String.IsNullOrEmpty(tb_cliente.Text) AndAlso
                Not String.IsNullOrEmpty(tb_precioventa.Text) AndAlso
        Not String.IsNullOrEmpty(tb_descripcion.Text) AndAlso NumericUpDown2.Value > 0 Then

                Dim codDetalle As String = GenerarCodigoDetallecompra()
                codigoCliente = tb_cliente.Text
                'codigoProveedor = tb_Proveedor.Text
                Dim factura As String = tb_factura.Text

                Dim codproducto As String = Label14.Text

                Dim nombre As String = tb_descripcion.Text

                Dim cantidad As Double = Convert.ToDouble(NumericUpDown2.Value)

                Dim precioV As Double = Convert.ToDouble(tb_precioventa.Text)

                Dim montoPorProducto As Double = cantidad * precioV

                Dim dt As DataTable = DirectCast(dt_detalleventa.DataSource, DataTable)

                ' Comprobar si ya hay registros en dt_detalleventa
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                    ' Eliminar la columna de botones si ya existe
                    If dt_detalleventa.Columns.Contains("Eliminar") Then
                        dt_detalleventa.Columns.Remove("Eliminar")
                    End If

                    ' Crear un nuevo DataTable y enlazarlo al DataGridView
                    dt = New DataTable()
                    dt.Columns.Add("Cod_detalle", GetType(String))
                    dt.Columns.Add("Factura", GetType(String))
                    dt.Columns.Add("Cod_Producto", GetType(String))
                    dt.Columns.Add("Cliente", GetType(String))
                    dt.Columns.Add("Nombre", GetType(String))
                    dt.Columns.Add("Cantidad", GetType(Double))
                    dt.Columns.Add("PrecioV", GetType(Double))
                    dt.Columns.Add("MontoxProducto", GetType(Double)) ' Añadir la columna "MontoxProducto"

                    ' Agregar una columna para el proveedor
                    dt_detalleventa.DataSource = dt
                    tb_descripcion.Focus()
                    dt_detalleventa.Columns("Cod_detalle").Visible = True
                    dt_detalleventa.Columns("Factura").Visible = True
                    dt_detalleventa.Columns("Cod_Producto").Visible = True
                    dt_detalleventa.Columns("Cliente").Visible = True
                    dt_detalleventa.Columns("PrecioV").Visible = True

                    ' Crear la columna de botones "Eliminar" y establecer su posición en la primera posición (0)
                    Dim btnColumn As New DataGridViewButtonColumn()
                    btnColumn.Name = "Eliminar"
                    btnColumn.FlatStyle = FlatStyle.Flat
                    btnColumn.UseColumnTextForButtonValue = False

                    ' Insertar la columna de botones en la primera posición (0)
                    dt_detalleventa.Columns.Insert(0, btnColumn)
                End If

                ' Buscar si ya existe una fila con el mismo nombre
                Dim existingRow As DataRow = dt.AsEnumerable().FirstOrDefault(Function(row) row.Field(Of String)("Nombre") = nombre)

                If existingRow IsNot Nothing Then
                    ' Si ya existe una fila con el mismo nombre, actualiza la cantidad y el total
                    Dim cantidadExistente As Double = Convert.ToDouble(existingRow("Cantidad"))
                    Dim totalExistente As Double = Convert.ToDouble(existingRow("MontoxProducto"))
                    existingRow("Cantidad") = cantidadExistente + cantidad
                    'existingRow("Precio") = precio ' Puedes elegir si deseas actualizar el precio o mantener el existente
                    existingRow("MontoxProducto") = totalExistente + montoPorProducto
                    CalcularSubtotal()
                    CalcularDes()
                Else
                    ' Si no existe una fila con el mismo nombre, crea una nueva fila
                    Dim newRow As DataRow = dt.NewRow()
                    newRow("Cod_detalle") = codDetalle
                    newRow("Factura") = factura
                    newRow("Cod_Producto") = codproducto
                    newRow("Cliente") = codigoCliente
                    newRow("Nombre") = nombre
                    newRow("Cantidad") = cantidad
                    newRow("PrecioV") = precioV
                    newRow("MontoxProducto") = montoPorProducto
                    ' Agregar la fila al DataTable
                    dt.Rows.Add(newRow)
                    CalcularSubtotal()
                    CalcularDes()
                End If

                ' Comprueba si el DataTable está vacío y actualiza la visibilidad del botón
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                    btn_Verfactura.Visible = False
                Else
                    btn_Verfactura.Visible = True
                    btn_Verfactura.Enabled = False
                End If

                Limpiar()
            Else
                MessageBox.Show("Por favor, complete todos los campos y asegúrese de que la cantidad no sea 0.")
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo un error: " & ex.Message)
        End Try

    End Sub





    Private Sub dt_detalleventa_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dt_detalleventa.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dt_detalleventa.Columns("Eliminar").Index Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            ' Establecer el color de fondo de la celda en transparente
            e.CellStyle.BackColor = Color.Transparent

            ' Obtener la posición para dibujar la imagen
            Dim imageX As Integer = e.CellBounds.Left + (e.CellBounds.Width - My.Resources.boton_eliminar.Width) / 2
            Dim imageY As Integer = e.CellBounds.Top + (e.CellBounds.Height - My.Resources.boton_eliminar.Height) / 2

            ' Verificar si la imagen es válida antes de dibujarla
            If My.Resources.boton_eliminar IsNot Nothing AndAlso TypeOf My.Resources.boton_eliminar Is System.Drawing.Image Then
                Dim botonEliminarImage As System.Drawing.Image = DirectCast(My.Resources.boton_eliminar, System.Drawing.Image)
                ' Dibujar la imagen en lugar del fondo predeterminado del botón
                e.Graphics.DrawImage(botonEliminarImage, New System.Drawing.Rectangle(imageX, imageY, botonEliminarImage.Width, botonEliminarImage.Height))
            End If

            e.Handled = True
            tb_descripcion.Focus()
        End If
    End Sub

    Private Sub dt_detalleventa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_detalleventa.CellClick
        If e.ColumnIndex = dt_detalleventa.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                dt_detalleventa.Rows.RemoveAt(e.RowIndex)
                CalcularSubtotal()
                CalcularDes()
                If dt_detalleventa.Rows.Count = 0 Then
                    ' Desmarcar el checkbox fuera de la tabla
                    btn_Verfactura.Visible = False
                    CheckBoxDescuento.Checked = False
                    tb_subtotal.Clear()
                    tb_total.Clear()
                Else
                    btn_Verfactura.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim valor As Double = NumericUpDown1.Value
        If valor > 80 Then
            MessageBox.Show("El valor no puede ser mayor que 80.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumericUpDown1.Value = 80 ' Restablece el valor a 80 si es mayor
        Else
            If CheckBoxDescuento.Checked AndAlso valor >= 2 Then
                descuentoEspecificado = valor / 100
                Dim subtotal As Double = Double.Parse(tb_subtotal.Text)
                descuentoAplicado = subtotal * descuentoEspecificado
                total = subtotal - descuentoAplicado

                tb_descuento.Text = descuentoAplicado.ToString()
                tb_total.Text = total.ToString()
            Else
                tb_descuento.Text = ""
                tb_total.Text = tb_subtotal.Text
            End If
        End If
    End Sub

    Private Sub Buscar_txt_TextChanged(sender As Object, e As EventArgs) Handles Buscar_txt.TextChanged
        Dim NombreBuscado As String = Buscar_txt.Text
        If NombreBuscado <> "" Then
            dtg_Productos.DataSource = venta.TablaVentas("SELECT Nombre,Precio_venta,Stock FROM Productos WHERE Nombre LIKE '%" + NombreBuscado + "%'")
        Else
            Mostrartodatabla()
        End If
    End Sub

    Private Sub tb_pago_TextChanged(sender As Object, e As EventArgs) Handles tb_pago.TextChanged



        If Not String.IsNullOrEmpty(tb_pago.Text) Then
            btn_Verfactura.Enabled = True
            Dim precioCompra, total As Double
            If Double.TryParse(tb_pago.Text, precioCompra) AndAlso Double.TryParse(tb_total.Text, total) Then
                Dim cambio As Double = precioCompra - total
                tb_cambios.Text = cambio.ToString()
            Else
                ' Si el valor ingresado no es un número válido, puedes manejarlo aquí
                MessageBox.Show("Por favor, ingrese un valor numérico válido en pago.")
            End If
        Else
            tb_cambios.Text = ""
            btn_Verfactura.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class