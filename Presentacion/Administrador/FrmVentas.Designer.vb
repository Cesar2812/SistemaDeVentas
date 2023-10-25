<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tb_cliente = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Vender = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_Verfactura = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CheckBoxDescuento = New System.Windows.Forms.CheckBox()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_descuento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_subtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tb_cambios = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_pago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_factura = New System.Windows.Forms.TextBox()
        Me.dt_detalleventa = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.tb_precioventa = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_descripcion = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_ListaProductos = New System.Windows.Forms.Button()
        Me.dtg_Productos = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dt_detalleventa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtg_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.tb_cliente)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(771, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 73)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(183, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tb_cliente
        '
        Me.tb_cliente.Location = New System.Drawing.Point(16, 42)
        Me.tb_cliente.Name = "tb_cliente"
        Me.tb_cliente.Size = New System.Drawing.Size(161, 20)
        Me.tb_cliente.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Eras Demi ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(61, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Clientes"
        '
        'btn_Vender
        '
        Me.btn_Vender.BackColor = System.Drawing.Color.Teal
        Me.btn_Vender.FlatAppearance.BorderSize = 0
        Me.btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Vender.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Vender.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Vender.Image = CType(resources.GetObject("btn_Vender.Image"), System.Drawing.Image)
        Me.btn_Vender.Location = New System.Drawing.Point(78, 216)
        Me.btn_Vender.Name = "btn_Vender"
        Me.btn_Vender.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_Vender.Size = New System.Drawing.Size(126, 37)
        Me.btn_Vender.TabIndex = 12
        Me.btn_Vender.Text = "Vender"
        Me.btn_Vender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_Vender.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.btn_Verfactura)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.tb_factura)
        Me.Panel2.Controls.Add(Me.btn_Vender)
        Me.Panel2.Controls.Add(Me.dt_detalleventa)
        Me.Panel2.Location = New System.Drawing.Point(354, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(660, 308)
        Me.Panel2.TabIndex = 2
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(504, 185)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(63, 24)
        Me.NumericUpDown1.TabIndex = 49
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(456, 164)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 24)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Especifica descuento"
        '
        'btn_Verfactura
        '
        Me.btn_Verfactura.BackColor = System.Drawing.Color.Teal
        Me.btn_Verfactura.FlatAppearance.BorderSize = 0
        Me.btn_Verfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Verfactura.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Verfactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Verfactura.Image = CType(resources.GetObject("btn_Verfactura.Image"), System.Drawing.Image)
        Me.btn_Verfactura.Location = New System.Drawing.Point(221, 211)
        Me.btn_Verfactura.Name = "btn_Verfactura"
        Me.btn_Verfactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_Verfactura.Size = New System.Drawing.Size(128, 42)
        Me.btn_Verfactura.TabIndex = 36
        Me.btn_Verfactura.Text = "Factura"
        Me.btn_Verfactura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_Verfactura.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.CheckBoxDescuento)
        Me.Panel6.Controls.Add(Me.tb_total)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.tb_descuento)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.tb_subtotal)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Location = New System.Drawing.Point(419, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(226, 107)
        Me.Panel6.TabIndex = 27
        '
        'CheckBoxDescuento
        '
        Me.CheckBoxDescuento.AutoSize = True
        Me.CheckBoxDescuento.Location = New System.Drawing.Point(205, 53)
        Me.CheckBoxDescuento.Name = "CheckBoxDescuento"
        Me.CheckBoxDescuento.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxDescuento.TabIndex = 46
        Me.CheckBoxDescuento.UseVisualStyleBackColor = True
        '
        'tb_total
        '
        Me.tb_total.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total.Location = New System.Drawing.Point(104, 76)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.Size = New System.Drawing.Size(95, 24)
        Me.tb_total.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaShell
        Me.Label3.Location = New System.Drawing.Point(28, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Total"
        '
        'tb_descuento
        '
        Me.tb_descuento.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_descuento.Location = New System.Drawing.Point(104, 46)
        Me.tb_descuento.Name = "tb_descuento"
        Me.tb_descuento.Size = New System.Drawing.Size(95, 24)
        Me.tb_descuento.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.Location = New System.Drawing.Point(11, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 24)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Descuento"
        '
        'tb_subtotal
        '
        Me.tb_subtotal.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_subtotal.Location = New System.Drawing.Point(104, 12)
        Me.tb_subtotal.Name = "tb_subtotal"
        Me.tb_subtotal.Size = New System.Drawing.Size(95, 24)
        Me.tb_subtotal.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SeaShell
        Me.Label12.Location = New System.Drawing.Point(28, 8)
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
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Turquoise
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.tb_cambios)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.tb_pago)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Location = New System.Drawing.Point(433, 215)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(186, 78)
        Me.Panel7.TabIndex = 31
        '
        'tb_cambios
        '
        Me.tb_cambios.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_cambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cambios.Location = New System.Drawing.Point(75, 47)
        Me.tb_cambios.Name = "tb_cambios"
        Me.tb_cambios.Size = New System.Drawing.Size(95, 24)
        Me.tb_cambios.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(14, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Pagó"
        '
        'tb_pago
        '
        Me.tb_pago.BackColor = System.Drawing.Color.PapayaWhip
        Me.tb_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pago.Location = New System.Drawing.Point(75, 13)
        Me.tb_pago.Name = "tb_pago"
        Me.tb_pago.Size = New System.Drawing.Size(95, 24)
        Me.tb_pago.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(5, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Cambio"
        '
        'tb_factura
        '
        Me.tb_factura.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tb_factura.Location = New System.Drawing.Point(504, 12)
        Me.tb_factura.Multiline = True
        Me.tb_factura.Name = "tb_factura"
        Me.tb_factura.Size = New System.Drawing.Size(124, 29)
        Me.tb_factura.TabIndex = 33
        '
        'dt_detalleventa
        '
        Me.dt_detalleventa.AllowUserToAddRows = False
        Me.dt_detalleventa.AllowUserToDeleteRows = False
        Me.dt_detalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_detalleventa.Location = New System.Drawing.Point(12, 12)
        Me.dt_detalleventa.Name = "dt_detalleventa"
        Me.dt_detalleventa.ReadOnly = True
        Me.dt_detalleventa.Size = New System.Drawing.Size(398, 163)
        Me.dt_detalleventa.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.NumericUpDown2)
        Me.Panel3.Controls.Add(Me.tb_precioventa)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.tb_descripcion)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Location = New System.Drawing.Point(354, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(411, 95)
        Me.Panel3.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(57, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 24)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Descripción"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(217, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Cst. Unitario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(310, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Cantidad:"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(319, 66)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(63, 24)
        Me.NumericUpDown2.TabIndex = 22
        '
        'tb_precioventa
        '
        Me.tb_precioventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_precioventa.Location = New System.Drawing.Point(221, 65)
        Me.tb_precioventa.Name = "tb_precioventa"
        Me.tb_precioventa.Size = New System.Drawing.Size(92, 24)
        Me.tb_precioventa.TabIndex = 21
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(9, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Demi ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(49, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Productos"
        '
        'tb_descripcion
        '
        Me.tb_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_descripcion.Location = New System.Drawing.Point(5, 66)
        Me.tb_descripcion.Name = "tb_descripcion"
        Me.tb_descripcion.Size = New System.Drawing.Size(210, 24)
        Me.tb_descripcion.TabIndex = 18
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.Control
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(146, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button8.Size = New System.Drawing.Size(38, 38)
        Me.Button8.TabIndex = 11
        Me.Button8.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(977, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(553, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 46)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Nueva venta"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(122, 408)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 24)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Categoria"
        '
        'btn_ListaProductos
        '
        Me.btn_ListaProductos.BackColor = System.Drawing.Color.Transparent
        Me.btn_ListaProductos.FlatAppearance.BorderSize = 0
        Me.btn_ListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ListaProductos.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ListaProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_ListaProductos.Image = CType(resources.GetObject("btn_ListaProductos.Image"), System.Drawing.Image)
        Me.btn_ListaProductos.Location = New System.Drawing.Point(57, 12)
        Me.btn_ListaProductos.Name = "btn_ListaProductos"
        Me.btn_ListaProductos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_ListaProductos.Size = New System.Drawing.Size(222, 40)
        Me.btn_ListaProductos.TabIndex = 50
        Me.btn_ListaProductos.Text = "Listado productos"
        Me.btn_ListaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ListaProductos.UseVisualStyleBackColor = False
        '
        'dtg_Productos
        '
        Me.dtg_Productos.AllowUserToAddRows = False
        Me.dtg_Productos.AllowUserToDeleteRows = False
        Me.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Productos.Location = New System.Drawing.Point(10, 88)
        Me.dtg_Productos.Name = "dtg_Productos"
        Me.dtg_Productos.ReadOnly = True
        Me.dtg_Productos.Size = New System.Drawing.Size(324, 300)
        Me.dtg_Productos.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 15)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Buscar:"
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Location = New System.Drawing.Point(80, 58)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(235, 20)
        Me.Buscar_txt.TabIndex = 52
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1026, 480)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Buscar_txt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_ListaProductos)
        Me.Controls.Add(Me.dtg_Productos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmVentas"
        Me.Text = "FrmVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dt_detalleventa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtg_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents tb_cliente As TextBox
    Friend WithEvents btn_Vender As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tb_cambios As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_pago As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_factura As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents tb_precioventa As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_descripcion As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents dt_detalleventa As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tb_descuento As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_subtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_total As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Verfactura As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_ListaProductos As Button
    Friend WithEvents dtg_Productos As DataGridView
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents CheckBoxDescuento As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Buscar_txt As TextBox
End Class
