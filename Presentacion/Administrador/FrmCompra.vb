Imports System.ComponentModel
Imports System.IO
Imports System.Text
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
Imports System.Drawing
Imports LogicaNegocio
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.tool.xml.parser
Imports iTextSharp.tool.xml.pipeline.html

Public Class FrmCompra


    ' Declaración de variables de clase
    Private compra As New ServiciosCompras()
    Private detallecompra As New ServiciosDCompr()
    Private productos As New ServiciosProductos()
    Private descuentoAplicado As Double = 0.0
    Private descuentoEspecificado As Double = 0.0
    Private total As Double = 0.0
    Dim codigoProveedor As String = ""



    Public Sub New()
        InitializeComponent()
        NumericUpDown1.Value = 2
        NumericUpDown1.Minimum = 2
        AddHandler dt_detallecompra.CellPainting, AddressOf dt_detallecompra_CellPainting
    End Sub
    Private Sub btn_ListaProductos_Click(sender As Object, e As EventArgs) Handles btn_ListaProductos.Click
        Mostrartodatabla()
    End Sub
    Public Sub Mostrartodatabla()
        dtg_Productos.DataSource = productos.TablaProducto("SELECT Cod_producto,Nombre,Stock,Precio_compra,Precio_venta,CodCategoria,CodProveedor,PDefinido FROM Productos")
        dtg_Productos.Columns("Cod_producto").Visible = False
        dtg_Productos.Columns("PDefinido").Visible = False
        dtg_Productos.Columns("CodCategoria").Visible = False
        dtg_Productos.Columns("Precio_venta").Visible = False
        dtg_Productos.Columns("CodProveedor").Visible = False
        'Cod_producto, Nombre, Stock, Precio_compra, Precio_venta, CodCategoria, CodProveedor
    End Sub
    Private Sub ConfigurarTextBoxes()
        tx_precioventa.ReadOnly = True
        tx_precioventa.BackColor = Color.White
        tx_preciocompra.ReadOnly = True
        tx_preciocompra.BackColor = Color.White
        tb_descripcion.ReadOnly = True
        tb_descripcion.BackColor = Color.White

        tb_subtotal.ReadOnly = True
        tb_subtotal.BackColor = Color.PapayaWhip
        tbxAplicado.ReadOnly = True
        tbxAplicado.BackColor = Color.PapayaWhip
        tb_total.ReadOnly = True
        tb_total.BackColor = Color.PapayaWhip

        tb_Proveedor.ReadOnly = True
        tb_Proveedor.BackColor = Color.PapayaWhip
        tb_Categoria.ReadOnly = True
        tb_Categoria.BackColor = Color.PapayaWhip
    End Sub

    Private Sub FrmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        NumericUpDown2.Value = 2
        btn_verfactura.Visible = False
        ConfigurarTextBoxes()
        NumericUpDown1.Visible = False
        Label13.Visible = False
        Label14.Visible = False
    End Sub

    Private Sub dtg_Productos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Productos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dtg_Productos.Rows(e.RowIndex)
            tb_descripcion.Text = fila.Cells(1).Value.ToString()
            tb_Categoria.Text = fila.Cells(5).Value.ToString()
            tb_Proveedor.Text = fila.Cells(6).Value.ToString()
            Label14.Text = fila.Cells(0).Value.ToString()

            Dim valorPDefinido As String = fila.Cells("PDefinido").Value.ToString()

            If valorPDefinido = "Sí" Then
                tx_preciocompra.Text = fila.Cells(3).Value.ToString()
                tx_precioventa.Text = fila.Cells(4).Value.ToString()
                ' Configura los campos en modo lectura
                tb_descripcion.ReadOnly = True
                tb_Categoria.ReadOnly = True
                tb_Proveedor.ReadOnly = True
                tx_preciocompra.ReadOnly = True
                tx_precioventa.ReadOnly = True
            Else
                ' Cuando el valor es "No", los campos de precio compra y precio venta están vacíos
                tx_preciocompra.Text = ""
                tx_precioventa.Text = ""
                ' Quita el modo lectura solo del texbox "precio_compra"
                tx_preciocompra.ReadOnly = False
            End If
        End If

    End Sub
    Private Sub tx_preciocompra_TextChanged(sender As Object, e As EventArgs) Handles tx_preciocompra.TextChanged

        If Not String.IsNullOrEmpty(tx_preciocompra.Text) Then
            Dim precioCompra As Double
            If Double.TryParse(tx_preciocompra.Text, precioCompra) Then
                Dim precioVenta As Double = precioCompra + 3.0
                tx_precioventa.Text = precioVenta.ToString()
            Else
                ' Si el valor ingresado no es un número válido, puedes manejarlo aquí
                MessageBox.Show("Por favor, ingrese un valor numérico válido en tx_preciocompra.")
            End If
        Else
            tx_precioventa.Text = ""
        End If
    End Sub

    'Private Sub RealizarCompra()
    '    Try
    '        Try
    '            Dim NFactura As String = tb_factura.Text ' Obtener el número de factura desde la interfaz de usuario
    '            Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd") ' Obtener la fecha actual
    '            Dim estado As String = "Realizada"
    '            ' Inicializar descuento en 0 por defecto
    '            Dim descuento As Double = 0
    '            ' Verificar si el CheckBox está marcado
    '            If CheckBoxDescuento.Checked Then
    '                ' Convertir el descuento solo si el CheckBox está marcado
    '                If Double.TryParse(tbxAplicado.Text, descuento) Then
    '                    ' La conversión fue exitosa, "descuento" contiene el valor convertido
    '                Else
    '                    ' El contenido de tbxAplicado.Text no es válido
    '                    MessageBox.Show("El descuento no es un número válido.")
    '                    Return ' Salir de la función debido al error
    '                End If
    '            End If

    '            ' Convertir el monto total
    '            Dim montototal As Double
    '            If Double.TryParse(tb_total.Text, montototal) Then
    '            Else
    '                ' El contenido de tb_total.Text no es válido
    '                MessageBox.Show("El monto total no es un número válido.")
    '                Return ' Salir de la función debido al error
    '            End If

    '            compra.InsertarNuevaCompra(NFactura, Fecha, codigoProveedor, descuento, montototal, estado)

    '            For Each row As DataGridViewRow In dt_detallecompra.Rows
    '                If Not row.IsNewRow Then ' Verificar si la fila no es una fila nueva (si se utiliza una fila para agregar nuevos datos)
    '                    Dim CodDetalle As String = row.Cells("Cod_detalle").Value.ToString()
    '                    Dim Factura As String = row.Cells("Factura").Value.ToString()
    '                    Dim Codigo As String = row.Cells("Cod_Producto").Value.ToString()

    '                    Dim PrecioCompraNuevocodigo As String = row.Cells("Precio").Value.ToString()
    '                    Dim PrecioVentaNuevocodigo As String = row.Cells("PrecioV").Value.ToString()
    '                    ' Convertir la cantidad y MontoxProducto solo si los valores son numéricos
    '                    Dim Cantidad As Double
    '                    Dim MontoxProducto As Double

    '                    If Double.TryParse(row.Cells("Cantidad").Value.ToString(), Cantidad) AndAlso Double.TryParse(row.Cells("MontoxProducto").Value.ToString(), MontoxProducto) Then
    '                        Dim PDefinido As String = "Sí"

    '                        productos.ActualizarPrecioCVStock(Codigo, PrecioVentaNuevocodigo, PrecioCompraNuevocodigo, Cantidad, PDefinido)
    '                        detallecompra.InsertarDetalleVenta(CodDetalle, NFactura, Codigo, Cantidad, MontoxProducto)
    '                    Else
    '                        ' Manejar el caso en que los valores no sean numéricos
    '                        MessageBox.Show("Error en los datos numéricos de la fila: " & row.Index + 1)
    '                    End If
    '                Else
    '                    ' Manejar el caso en que los valores no sean numéricos
    '                    MessageBox.Show("Error en los datos numéricos de la fila: " & row.Index + 1)
    '                End If

    '            Next



    '        Catch ex As Exception
    '            MessageBox.Show("Se produjo un error al insertar en la base de datos: " & ex.Message)
    '        End Try

    '    Catch ex As Exception
    '        MessageBox.Show("Se produjo un error al realizar la venta: " & ex.Message)
    '    End Try
    'End Sub

    Private Sub RealizarCompra()
        Try
            Dim NFactura As String = tb_factura.Text ' Obtener el número de factura desde la interfaz de usuario
            Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd") ' Obtener la fecha actual
            Dim estado As String = "Realizada"
            ' Inicializar descuento en 0 por defecto
            Dim descuento As Double = 0
            ' Verificar si el CheckBox está marcado
            If CheckBoxDescuento.Checked Then
                ' Convertir el descuento solo si el CheckBox está marcado
                If Double.TryParse(tbxAplicado.Text, descuento) Then
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

            compra.InsertarNuevaCompra(NFactura, Fecha, codigoProveedor, descuento, montototal, estado)

            For Each row As DataGridViewRow In dt_detallecompra.Rows
                If Not row.IsNewRow Then ' Verificar si la fila no es una fila nueva (si se utiliza una fila para agregar nuevos datos)
                    Dim CodDetalle As String = row.Cells("Cod_detalle").Value.ToString()
                    Dim Factura As String = row.Cells("Factura").Value.ToString()
                    Dim Codigo As String = row.Cells("Cod_Producto").Value.ToString()

                    Dim PrecioCompraNuevocodigo As String = row.Cells("Precio").Value.ToString()
                    Dim PrecioVentaNuevocodigo As String = row.Cells("PrecioV").Value.ToString()
                    ' Convertir la cantidad y MontoxProducto solo si los valores son numéricos
                    Dim Cantidad As Double
                    Dim MontoxProducto As Double

                    If Double.TryParse(row.Cells("Cantidad").Value.ToString(), Cantidad) AndAlso Double.TryParse(row.Cells("MontoxProducto").Value.ToString(), MontoxProducto) Then

                        Dim PDefinido As String = "Sí"
                        productos.ActualizarPrecioCVStock(Codigo, PrecioVentaNuevocodigo, PrecioCompraNuevocodigo, Cantidad, PDefinido, CodDetalle, NFactura)
                        detallecompra.InsertarDetalleVenta(CodDetalle, NFactura, Codigo, Cantidad, MontoxProducto)


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
            MessageBox.Show("Se produjo un error al realizar la compra: " & ex.Message)
        End Try
    End Sub


    Public Sub Limpiar()
        tb_Proveedor.Clear()
        tb_descripcion.Clear()
        tb_Categoria.Clear()
        tb_descripcion.Clear()
        NumericUpDown2.Value = 0
        tx_preciocompra.Clear()
    End Sub
    Private Function GenerarCodigoDetallecompra() As String
        If dt_detallecompra.Rows.Count > 0 Then
            ' Si hay filas en el DataGridView, determinar el último código de detalle existente
            Dim ultimaFila As DataGridViewRow = dt_detallecompra.Rows(dt_detallecompra.Rows.Count - 1)
            Dim ultimoCodigoDetalle As String = ultimaFila.Cells("Cod_detalle").Value.ToString()
            ' Extraer el número de detalle actual
            Dim numeroActual As Integer = Integer.Parse(ultimoCodigoDetalle.Substring(3))
            ' Calcular el próximo código de detalle
            Dim numeroSiguiente As Integer = numeroActual + 1
            Dim codigoDetalle As String = "DC-" & numeroSiguiente.ToString("D4")
            Return codigoDetalle
        Else
            ' Si no hay filas en el DataGridView, establecer el código de detalle inicial
            Return "DC-0001"
        End If
    End Function
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            ' Verificar que ningún campo esté vacío y que la cantidad no sea 0
            If Not String.IsNullOrEmpty(tb_factura.Text) AndAlso
       Not String.IsNullOrEmpty(tb_descripcion.Text) AndAlso
       NumericUpDown2.Value > 0 AndAlso
       Not String.IsNullOrEmpty(tx_preciocompra.Text) Then

                tb_factura.ReadOnly = True
                Dim codDetalle As String = GenerarCodigoDetallecompra()
                codigoProveedor = tb_Proveedor.Text
                Dim factura As String = tb_factura.Text

                Dim codproducto As String = Label14.Text
                Dim nombre As String = tb_descripcion.Text
                Dim cantidad As Double = Convert.ToDouble(NumericUpDown2.Value)
                Dim precio As Double = Convert.ToDouble(tx_preciocompra.Text)
                Dim precioV As Double = Convert.ToDouble(tx_precioventa.Text)
                Dim montoPorProducto As Double = cantidad * precio
                Dim dt As DataTable = DirectCast(dt_detallecompra.DataSource, DataTable)
                ' Comprobar si ya hay registros en dt_detallecompra
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then


                    ' Eliminar la columna de botones si ya existe
                    If dt_detallecompra.Columns.Contains("Eliminar") Then
                        dt_detallecompra.Columns.Remove("Eliminar")
                    End If
                    ' Crear un nuevo DataTable y enlazarlo al DataGridView
                    dt = New DataTable()

                    dt.Columns.Add("Cod_detalle", GetType(String))
                    dt.Columns.Add("Proveedor", GetType(String))
                    dt.Columns.Add("Factura", GetType(String))
                    dt.Columns.Add("Cod_Producto", GetType(String))
                    dt.Columns.Add("Nombre", GetType(String))
                    dt.Columns.Add("Cantidad", GetType(Double))
                    dt.Columns.Add("Precio", GetType(Double))
                    dt.Columns.Add("PrecioV", GetType(Double))
                    dt.Columns.Add("MontoxProducto", GetType(Double))
                    ' Agregar una columna para el proveedor
                    dt_detallecompra.DataSource = dt
                    tb_descripcion.Focus()
                    dt_detallecompra.Columns("Cod_detalle").Visible = True
                    dt_detallecompra.Columns("Cod_Producto").Visible = False
                    dt_detallecompra.Columns("Proveedor").Visible = False
                    dt_detallecompra.Columns("Factura").Visible = False
                    dt_detallecompra.Columns("PrecioV").Visible = True

                    ' Crear la columna de botones "Eliminar" y establecer su posición en la primera posición (0)
                    Dim btnColumn As New DataGridViewButtonColumn()
                    btnColumn.Name = "Eliminar"
                    btnColumn.FlatStyle = FlatStyle.Flat
                    btnColumn.UseColumnTextForButtonValue = False

                    ' Insertar la columna de botones en la primera posición (0)
                    dt_detallecompra.Columns.Insert(0, btnColumn)

                Else
                    ' Verificar si el proveedor actual coincide con el proveedor en los registros existentes
                    Dim proveedorEnRegistros As String = dt.Rows(0)("Proveedor").ToString() ' Suponiendo que el proveedor se encuentra en la columna "Proveedor"

                    If codigoProveedor <> proveedorEnRegistros Then
                        MessageBox.Show("No puedes agregar productos de un proveedor diferente en la misma compra.")
                        Return
                    End If
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
                    newRow("Proveedor") = codigoProveedor
                    newRow("Factura") = factura

                    newRow("Cod_Producto") = codproducto
                    newRow("Nombre") = nombre
                    newRow("Cantidad") = cantidad
                    newRow("Precio") = precio
                    newRow("PrecioV") = precioV
                    newRow("MontoxProducto") = montoPorProducto
                    ' Agregar la fila al DataTable
                    dt.Rows.Add(newRow)
                    CalcularSubtotal()
                    CalcularDes()

                End If
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then

                    btn_verfactura.Visible = False


                Else

                    btn_verfactura.Visible = True

                End If


                Limpiar()
            Else

                MessageBox.Show("Por favor, complete todos los campos y asegúrese de que la cantidad no sea 0.")
            End If

        Catch ex As Exception
            MessageBox.Show("Se produjo un error: " & ex.Message)
        End Try

    End Sub
    Private Sub CalcularSubtotal()
        Dim subtotal As Double = 0.0
        Dim dt As DataTable = DirectCast(dt_detallecompra.DataSource, DataTable)
        For Each row As DataGridViewRow In dt_detallecompra.Rows
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
                    tbxAplicado.Text = descuentoAplicado.ToString()
                    tb_total.Text = total.ToString()

                Else
                    MessageBox.Show("El valor debe estar en el rango de 2% a 80%.")
                End If
            Else
                MessageBox.Show("El valor ingresado no es válido.")
            End If
        Else
            tbxAplicado.Text = ""
            'tb_total.Text = tb_subtotal.Text
        End If
    End Sub
    Private Sub dt_detallecompra_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dt_detallecompra.CellPainting

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dt_detallecompra.Columns("Eliminar").Index Then
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

    Private Sub dt_detallecompra_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_detallecompra.CellClick
        If e.ColumnIndex = dt_detallecompra.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                dt_detallecompra.Rows.RemoveAt(e.RowIndex)
                CalcularSubtotal()
                CalcularDes()
                If dt_detallecompra.Rows.Count = 0 Then
                    ' Desmarcar el checkbox fuera de la tabla
                    btn_verfactura.Visible = False
                    CheckBoxDescuento.Checked = False
                    tb_subtotal.Clear()
                    tb_total.Clear()
                    tb_factura.Clear()
                    tb_factura.ReadOnly = False
                Else
                    btn_verfactura.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDescuento.CheckedChanged
        If dt_detallecompra.RowCount > 0 Then
            ' Hay datos en el DataGridView
            If CheckBoxDescuento.Checked Then
                NumericUpDown1.Visible = True
                Label13.Visible = True
                CalcularDes()
            Else
                NumericUpDown1.Visible = False
                Label13.Visible = False
                tbxAplicado.Clear()
                tb_total.Text = tb_subtotal.Text
            End If
        Else
            ' No hay datos en el DataGridView, muestra un MessageBox con el mensaje de error
            MessageBox.Show("No se pueden aplicar descuentos porque no hay datos insertados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                tbxAplicado.Text = descuentoAplicado.ToString()
                tb_total.Text = total.ToString()
            Else
                tbxAplicado.Text = ""
                tb_total.Text = tb_subtotal.Text
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_vender.Click

        If dt_detallecompra.RowCount > 0 Then
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea comprar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                RealizarCompra()

                ' Desmarca el CheckBox solo si está marcado
                If CheckBoxDescuento.Checked Then
                    CheckBoxDescuento.Checked = False
                End If

                ' Elimina la columna "Eliminar" del DataGridView si existe
                If dt_detallecompra.Columns.Contains("Eliminar") Then
                    dt_detallecompra.Columns.Remove("Eliminar")
                End If

                ' Limpia el DataGridView
                dt_detallecompra.DataSource = Nothing

                ' Establece el valor del NumericUpDown a 2
                NumericUpDown2.Value = 2 ' Puedes establecerlo en 2 como mencionaste

                ' Limpia todos los TextBox en el formulario, incluyendo los que están dentro de paneles
                For Each ctrl As Control In Me.Controls
                    If TypeOf ctrl Is TextBox Then
                        DirectCast(ctrl, TextBox).Text = ""
                    End If

                    ' Si el control actual es un Panel, recorre sus controles internos
                    If TypeOf ctrl Is Panel Then
                        For Each innerCtrl As Control In ctrl.Controls
                            If TypeOf innerCtrl Is TextBox Then
                                DirectCast(innerCtrl, TextBox).Text = ""
                            End If
                        Next
                    End If
                Next

                tb_subtotal.Clear()
                tb_total.Clear()
                tb_factura.ReadOnly = False
                Mostrartodatabla()
            End If
        Else
            ' No hay datos en el DataGridView, muestra un MessageBox con el mensaje de error
            MessageBox.Show("No se puede realizar venta sin eleccion de productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_verfactura.Click
        Dim facturaHTML As String = ObtenerDatosFactura()

        ' Crear una instancia del formulario frmfactura
        Dim frmFactura As New Factura()

        ' Configurar el control WebBrowser para mostrar la factura HTML
        frmFactura.WebBrowser1.DocumentText = facturaHTML

        ' Mostrar el formulario frmfactura como cuadro de diálogo
        frmFactura.ShowDialog()

    End Sub

    Private Function ObtenerDatosFactura() As String
        Dim plantillaFactura As String = My.Resources.Factura
        Dim tablaDatosHTML As New StringBuilder()

        Dim Subtotal As Double
        Dim Descuento As Double
        Dim MontoTotal As Double

        ' Verificar si el CheckBox está marcado
        If CheckBoxDescuento.Checked Then
            ' Intentar analizar el valor del TextBox para el descuento
            If Double.TryParse(tbxAplicado.Text, Descuento) AndAlso Double.TryParse(tb_subtotal.Text, Subtotal) Then
                MontoTotal = Subtotal - Descuento
            Else
                MessageBox.Show("Error en el descuento: Valor no válido")
                Return ""
            End If
        Else
            Descuento = 0
            If Double.TryParse(tb_subtotal.Text, Subtotal) Then
                MontoTotal = Subtotal ' Si no hay descuento, MontoTotal es igual a Subtotal
            Else
                MessageBox.Show("Error en el subtotal: Valor no válido")
                Return ""
            End If
        End If

        For Each row As DataGridViewRow In dt_detallecompra.Rows
            If Not row.IsNewRow Then
                Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd") '
                Dim Factura As String = row.Cells("Factura").Value.ToString()
                Dim Codigo As String = row.Cells("Cod_Producto").Value.ToString()
                Dim CodProveedor As String = row.Cells("Cod_detalle").Value.ToString()

                plantillaFactura = plantillaFactura.Replace("{NFactura}", Factura)
                plantillaFactura = plantillaFactura.Replace("{Fecha}", Fecha)
                plantillaFactura = plantillaFactura.Replace("{CodProveedor}", CodProveedor)
                plantillaFactura = plantillaFactura.Replace("{SubTotal}", Subtotal)
                plantillaFactura = plantillaFactura.Replace("{Descuento}", Descuento)
                plantillaFactura = plantillaFactura.Replace("{MontoTotal}", MontoTotal)

                Dim CodigoDetalle As String = row.Cells("Cod_detalle").Value.ToString()
                Dim CodigoProducto As String = row.Cells("Cod_Producto").Value.ToString()
                Dim Cantidad As String = row.Cells("Cantidad").Value.ToString()
                Dim MontoPorProducto As String = row.Cells("MontoxProducto").Value.ToString()

                ' Construir una fila de la tabla HTML con los datos de la fila actual
                Dim filaHTML As String = $"<tr><td>{CodigoDetalle}</td><td>{Factura}</td><td>{CodigoProducto}</td><td>{Cantidad}</td><td>{MontoPorProducto}</td></tr>"
                tablaDatosHTML.Append(filaHTML)
            Else
                MessageBox.Show("Error en los datos de la fila: " & row.Index + 1)
            End If
        Next

        plantillaFactura = plantillaFactura.Replace("{TablaDatos}", tablaDatosHTML.ToString())
        Return plantillaFactura
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Buscar_txt_TextChanged(sender As Object, e As EventArgs) Handles Buscar_txt.TextChanged
        Dim NombreBuscado As String = Buscar_txt.Text
        If NombreBuscado <> "" Then
            dtg_Productos.DataSource = compra.TablaCompras("SELECT Nombre,Stock,Precio_compra FROM Productos WHERE Nombre LIKE '%" + NombreBuscado + "%'")
        Else
            Mostrartodatabla()
        End If
    End Sub
    'Private Function ConvertirHTMLaPDF(html As String) As Byte()
    '    Dim ms As New MemoryStream()
    '    Dim document As New Document()
    '    Dim writer As PdfWriter = PdfWriter.GetInstance(document, ms)
    '    document.Open()

    '    ' Parsear el HTML y convertirlo a PDF
    '    XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, New StringReader(html))

    '    document.Close()
    '    Return ms.ToArray()
    'End Function
End Class