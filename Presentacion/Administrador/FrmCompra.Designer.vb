<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompra))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tx_precioventa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_descripcion = New System.Windows.Forms.TextBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.tx_preciocompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_verfactura = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_vender = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CheckBoxDescuento = New System.Windows.Forms.CheckBox()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.tbxAplicado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_subtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_factura = New System.Windows.Forms.TextBox()
        Me.dt_detallecompra = New System.Windows.Forms.DataGridView()
        Me.btn_ListaProductos = New System.Windows.Forms.Button()
        Me.dtg_Productos = New System.Windows.Forms.DataGridView()
        Me.tb_Proveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Categoria = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.dt_detallecompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(584, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(286, 46)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Nueva compra"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(977, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tx_precioventa)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.tb_descripcion)
        Me.Panel3.Controls.Add(Me.NumericUpDown2)
        Me.Panel3.Controls.Add(Me.tx_preciocompra)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(387, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(603, 67)
        Me.Panel3.TabIndex = 39
        '
        'tx_precioventa
        '
        Me.tx_precioventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_precioventa.Location = New System.Drawing.Point(367, 31)
        Me.tx_precioventa.Name = "tx_precioventa"
        Me.tx_precioventa.Size = New System.Drawing.Size(92, 24)
        Me.tx_precioventa.TabIndex = 38
        Me.tx_precioventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(365, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 24)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Precio venta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(66, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 24)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Descripción"
        '
        'tb_descripcion
        '
        Me.tb_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_descripcion.Location = New System.Drawing.Point(17, 30)
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(220, 24)
        Me.tb_descripcion.TabIndex = 23
        Me.tb_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(492, 31)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(63, 24)
        Me.NumericUpDown2.TabIndex = 22
        '
        'tx_preciocompra
        '
        Me.tx_preciocompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_preciocompra.Location = New System.Drawing.Point(254, 30)
        Me.tx_preciocompra.Name = "tx_preciocompra"
        Me.tx_preciocompra.Size = New System.Drawing.Size(92, 24)
        Me.tx_preciocompra.TabIndex = 21
        Me.tx_preciocompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(483, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Cantidad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(249, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 24)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Precio compra"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.Control
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(552, 54)
        Me.Button8.Name = "Button8"
        Me.Button8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button8.Size = New System.Drawing.Size(35, 38)
        Me.Button8.TabIndex = 11
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button8.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(417, 54)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 33)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Demi ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(457, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Productos"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_verfactura)
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.btn_vender)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tb_factura)
        Me.Panel2.Controls.Add(Me.dt_detallecompra)
        Me.Panel2.Location = New System.Drawing.Point(371, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(645, 248)
        Me.Panel2.TabIndex = 36
        '
        'btn_verfactura
        '
        Me.btn_verfactura.BackColor = System.Drawing.Color.Teal
        Me.btn_verfactura.FlatAppearance.BorderSize = 0
        Me.btn_verfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verfactura.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verfactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_verfactura.Image = CType(resources.GetObject("btn_verfactura.Image"), System.Drawing.Image)
        Me.btn_verfactura.Location = New System.Drawing.Point(219, 193)
        Me.btn_verfactura.Name = "btn_verfactura"
        Me.btn_verfactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_verfactura.Size = New System.Drawing.Size(132, 37)
        Me.btn_verfactura.TabIndex = 48
        Me.btn_verfactura.Text = "Factura"
        Me.btn_verfactura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_verfactura.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(493, 193)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(63, 24)
        Me.NumericUpDown1.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(445, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(157, 24)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Especifica descuento"
        '
        'btn_vender
        '
        Me.btn_vender.BackColor = System.Drawing.Color.Teal
        Me.btn_vender.FlatAppearance.BorderSize = 0
        Me.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vender.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vender.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_vender.Image = CType(resources.GetObject("btn_vender.Image"), System.Drawing.Image)
        Me.btn_vender.Location = New System.Drawing.Point(60, 193)
        Me.btn_vender.Name = "btn_vender"
        Me.btn_vender.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_vender.Size = New System.Drawing.Size(144, 37)
        Me.btn_vender.TabIndex = 35
        Me.btn_vender.Text = "Comprar"
        Me.btn_vender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_vender.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.CheckBoxDescuento)
        Me.Panel6.Controls.Add(Me.tb_total)
        Me.Panel6.Controls.Add(Me.tbxAplicado)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.tb_subtotal)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Location = New System.Drawing.Point(412, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(219, 112)
        Me.Panel6.TabIndex = 27
        '
        'CheckBoxDescuento
        '
        Me.CheckBoxDescuento.AutoSize = True
        Me.CheckBoxDescuento.Location = New System.Drawing.Point(190, 51)
        Me.CheckBoxDescuento.Name = "CheckBoxDescuento"
        Me.CheckBoxDescuento.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxDescuento.TabIndex = 45
        Me.CheckBoxDescuento.UseVisualStyleBackColor = True
        '
        'tb_total
        '
        Me.tb_total.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total.Location = New System.Drawing.Point(89, 80)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.Size = New System.Drawing.Size(95, 24)
        Me.tb_total.TabIndex = 28
        '
        'tbxAplicado
        '
        Me.tbxAplicado.BackColor = System.Drawing.Color.PapayaWhip
        Me.tbxAplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAplicado.Location = New System.Drawing.Point(89, 44)
        Me.tbxAplicado.Name = "tbxAplicado"
        Me.tbxAplicado.Size = New System.Drawing.Size(95, 24)
        Me.tbxAplicado.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaShell
        Me.Label3.Location = New System.Drawing.Point(14, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.Location = New System.Drawing.Point(2, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 24)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Descuento"
        '
        'tb_subtotal
        '
        Me.tb_subtotal.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_subtotal.Location = New System.Drawing.Point(90, 12)
        Me.tb_subtotal.Name = "tb_subtotal"
        Me.tb_subtotal.Size = New System.Drawing.Size(95, 24)
        Me.tb_subtotal.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SeaShell
        Me.Label12.Location = New System.Drawing.Point(14, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 24)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Subtotal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(430, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Factura:"
        '
        'tb_factura
        '
        Me.tb_factura.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tb_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_factura.Location = New System.Drawing.Point(504, 12)
        Me.tb_factura.Multiline = True
        Me.tb_factura.Name = "tb_factura"
        Me.tb_factura.Size = New System.Drawing.Size(124, 29)
        Me.tb_factura.TabIndex = 33
        '
        'dt_detallecompra
        '
        Me.dt_detallecompra.AllowUserToAddRows = False
        Me.dt_detallecompra.AllowUserToDeleteRows = False
        Me.dt_detallecompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_detallecompra.Location = New System.Drawing.Point(15, 24)
        Me.dt_detallecompra.Name = "dt_detallecompra"
        Me.dt_detallecompra.ReadOnly = True
        Me.dt_detallecompra.Size = New System.Drawing.Size(378, 163)
        Me.dt_detallecompra.TabIndex = 1
        '
        'btn_ListaProductos
        '
        Me.btn_ListaProductos.BackColor = System.Drawing.Color.Transparent
        Me.btn_ListaProductos.FlatAppearance.BorderSize = 0
        Me.btn_ListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ListaProductos.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ListaProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_ListaProductos.Image = CType(resources.GetObject("btn_ListaProductos.Image"), System.Drawing.Image)
        Me.btn_ListaProductos.Location = New System.Drawing.Point(68, 8)
        Me.btn_ListaProductos.Name = "btn_ListaProductos"
        Me.btn_ListaProductos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_ListaProductos.Size = New System.Drawing.Size(222, 40)
        Me.btn_ListaProductos.TabIndex = 43
        Me.btn_ListaProductos.Text = "Listado productos"
        Me.btn_ListaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ListaProductos.UseVisualStyleBackColor = False
        '
        'dtg_Productos
        '
        Me.dtg_Productos.AllowUserToAddRows = False
        Me.dtg_Productos.AllowUserToDeleteRows = False
        Me.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Productos.Location = New System.Drawing.Point(13, 84)
        Me.dtg_Productos.Name = "dtg_Productos"
        Me.dtg_Productos.ReadOnly = True
        Me.dtg_Productos.Size = New System.Drawing.Size(352, 284)
        Me.dtg_Productos.TabIndex = 42
        '
        'tb_Proveedor
        '
        Me.tb_Proveedor.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Proveedor.Location = New System.Drawing.Point(15, 402)
        Me.tb_Proveedor.Name = "tb_Proveedor"
        Me.tb_Proveedor.Size = New System.Drawing.Size(179, 26)
        Me.tb_Proveedor.TabIndex = 13
        Me.tb_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(64, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(233, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Categoria"
        '
        'tb_Categoria
        '
        Me.tb_Categoria.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_Categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Categoria.Location = New System.Drawing.Point(200, 402)
        Me.tb_Categoria.Name = "tb_Categoria"
        Me.tb_Categoria.Size = New System.Drawing.Size(164, 26)
        Me.tb_Categoria.TabIndex = 39
        Me.tb_Categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(151, 431)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 24)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Categoria"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(31, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 15)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Buscar:"
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Location = New System.Drawing.Point(91, 54)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(235, 20)
        Me.Buscar_txt.TabIndex = 45
        '
        'FrmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1027, 459)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Buscar_txt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_ListaProductos)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.tb_Categoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtg_Productos)
        Me.Controls.Add(Me.tb_Proveedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompra"
        Me.Text = "FrmCompra"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dt_detallecompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents tx_preciocompra As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tb_total As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_subtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_factura As TextBox
    Friend WithEvents dt_detallecompra As DataGridView
    Friend WithEvents btn_ListaProductos As Button
    Friend WithEvents dtg_Productos As DataGridView
    Friend WithEvents tb_descripcion As TextBox
    Friend WithEvents btn_vender As Button
    Friend WithEvents tb_Proveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_Categoria As TextBox
    Friend WithEvents tx_precioventa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxAplicado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBoxDescuento As CheckBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_verfactura As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Buscar_txt As TextBox
End Class
