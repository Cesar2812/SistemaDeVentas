<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.Proveedor_cmbx = New System.Windows.Forms.ComboBox()
        Me.Categorias_cmbx = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Descripcion_Producto = New System.Windows.Forms.TextBox()
        Me.Id_Producto = New System.Windows.Forms.TextBox()
        Me.Valor_Producto = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Buscar_Medidas = New System.Windows.Forms.TextBox()
        Me.Cancelar_btn = New System.Windows.Forms.Button()
        Me.Eliminar_btn = New System.Windows.Forms.Button()
        Me.Editar_btn = New System.Windows.Forms.Button()
        Me.Agregar_btn = New System.Windows.Forms.Button()
        Me.Nuevo_btn = New System.Windows.Forms.Button()
        Me.btn_Exporta = New System.Windows.Forms.Button()
        Me.dg_Productos = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pnPrecio = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbTieneCelular = New System.Windows.Forms.RadioButton()
        Me.rb_pd = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel8.SuspendLayout()
        Me.panel9.SuspendLayout()
        CType(Me.dg_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnPrecio.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel7
        '
        Me.panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel7.BackColor = System.Drawing.Color.Maroon
        Me.panel7.Controls.Add(Me.PictureBox1)
        Me.panel7.Controls.Add(Me.label9)
        Me.panel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel7.Location = New System.Drawing.Point(16, 11)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(652, 40)
        Me.panel7.TabIndex = 324
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(612, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 353
        Me.PictureBox1.TabStop = False
        '
        'label9
        '
        Me.label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Snow
        Me.label9.Location = New System.Drawing.Point(30, 4)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(144, 32)
        Me.label9.TabIndex = 269
        Me.label9.Text = "Productos"
        '
        'panel8
        '
        Me.panel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel8.BackColor = System.Drawing.Color.Maroon
        Me.panel8.Controls.Add(Me.Proveedor_cmbx)
        Me.panel8.Controls.Add(Me.Categorias_cmbx)
        Me.panel8.Controls.Add(Me.Label2)
        Me.panel8.Controls.Add(Me.label10)
        Me.panel8.Controls.Add(Me.label11)
        Me.panel8.Controls.Add(Me.label12)
        Me.panel8.Controls.Add(Me.Descripcion_Producto)
        Me.panel8.Controls.Add(Me.Id_Producto)
        Me.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel8.Location = New System.Drawing.Point(21, 274)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(430, 101)
        Me.panel8.TabIndex = 323
        '
        'Proveedor_cmbx
        '
        Me.Proveedor_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Proveedor_cmbx.FormattingEnabled = True
        Me.Proveedor_cmbx.Location = New System.Drawing.Point(231, 72)
        Me.Proveedor_cmbx.Name = "Proveedor_cmbx"
        Me.Proveedor_cmbx.Size = New System.Drawing.Size(183, 21)
        Me.Proveedor_cmbx.TabIndex = 321
        '
        'Categorias_cmbx
        '
        Me.Categorias_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Categorias_cmbx.FormattingEnabled = True
        Me.Categorias_cmbx.Location = New System.Drawing.Point(20, 72)
        Me.Categorias_cmbx.Name = "Categorias_cmbx"
        Me.Categorias_cmbx.Size = New System.Drawing.Size(190, 21)
        Me.Categorias_cmbx.TabIndex = 320
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 279
        Me.Label2.Text = "Proveedor"
        '
        'label10
        '
        Me.label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(55, 48)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(82, 21)
        Me.label10.TabIndex = 274
        Me.label10.Text = "Categoria"
        '
        'label11
        '
        Me.label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(263, 2)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(102, 21)
        Me.label11.TabIndex = 273
        Me.label11.Text = "Descripcion"
        '
        'label12
        '
        Me.label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(40, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(61, 21)
        Me.label12.TabIndex = 272
        Me.label12.Text = "Codigo"
        '
        'Descripcion_Producto
        '
        Me.Descripcion_Producto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Descripcion_Producto.Location = New System.Drawing.Point(212, 24)
        Me.Descripcion_Producto.Name = "Descripcion_Producto"
        Me.Descripcion_Producto.ReadOnly = True
        Me.Descripcion_Producto.Size = New System.Drawing.Size(204, 20)
        Me.Descripcion_Producto.TabIndex = 269
        Me.Descripcion_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Id_Producto
        '
        Me.Id_Producto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Id_Producto.Location = New System.Drawing.Point(24, 25)
        Me.Id_Producto.Name = "Id_Producto"
        Me.Id_Producto.ReadOnly = True
        Me.Id_Producto.Size = New System.Drawing.Size(135, 20)
        Me.Id_Producto.TabIndex = 268
        Me.Id_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Valor_Producto
        '
        Me.Valor_Producto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Valor_Producto.Location = New System.Drawing.Point(86, 7)
        Me.Valor_Producto.Name = "Valor_Producto"
        Me.Valor_Producto.ReadOnly = True
        Me.Valor_Producto.Size = New System.Drawing.Size(77, 20)
        Me.Valor_Producto.TabIndex = 275
        Me.Valor_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(-2, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(84, 21)
        Me.label1.TabIndex = 276
        Me.label1.Text = "P.Compra"
        '
        'panel9
        '
        Me.panel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel9.Controls.Add(Me.Label7)
        Me.panel9.Controls.Add(Me.Buscar_Medidas)
        Me.panel9.Location = New System.Drawing.Point(19, 67)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(367, 37)
        Me.panel9.TabIndex = 322
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Buscar:"
        '
        'Buscar_Medidas
        '
        Me.Buscar_Medidas.Location = New System.Drawing.Point(121, 8)
        Me.Buscar_Medidas.Name = "Buscar_Medidas"
        Me.Buscar_Medidas.Size = New System.Drawing.Size(217, 20)
        Me.Buscar_Medidas.TabIndex = 83
        '
        'Cancelar_btn
        '
        Me.Cancelar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancelar_btn.FlatAppearance.BorderSize = 0
        Me.Cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_btn.Image = CType(resources.GetObject("Cancelar_btn.Image"), System.Drawing.Image)
        Me.Cancelar_btn.Location = New System.Drawing.Point(190, 233)
        Me.Cancelar_btn.Name = "Cancelar_btn"
        Me.Cancelar_btn.Size = New System.Drawing.Size(45, 33)
        Me.Cancelar_btn.TabIndex = 321
        Me.Cancelar_btn.UseVisualStyleBackColor = True
        '
        'Eliminar_btn
        '
        Me.Eliminar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Eliminar_btn.FlatAppearance.BorderSize = 0
        Me.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar_btn.Image = CType(resources.GetObject("Eliminar_btn.Image"), System.Drawing.Image)
        Me.Eliminar_btn.Location = New System.Drawing.Point(298, 230)
        Me.Eliminar_btn.Name = "Eliminar_btn"
        Me.Eliminar_btn.Size = New System.Drawing.Size(36, 39)
        Me.Eliminar_btn.TabIndex = 320
        Me.Eliminar_btn.UseVisualStyleBackColor = True
        '
        'Editar_btn
        '
        Me.Editar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Editar_btn.FlatAppearance.BorderSize = 0
        Me.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_btn.Image = CType(resources.GetObject("Editar_btn.Image"), System.Drawing.Image)
        Me.Editar_btn.Location = New System.Drawing.Point(254, 230)
        Me.Editar_btn.Name = "Editar_btn"
        Me.Editar_btn.Size = New System.Drawing.Size(39, 39)
        Me.Editar_btn.TabIndex = 319
        Me.Editar_btn.UseVisualStyleBackColor = True
        '
        'Agregar_btn
        '
        Me.Agregar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Agregar_btn.FlatAppearance.BorderSize = 0
        Me.Agregar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar_btn.Image = CType(resources.GetObject("Agregar_btn.Image"), System.Drawing.Image)
        Me.Agregar_btn.Location = New System.Drawing.Point(140, 229)
        Me.Agregar_btn.Name = "Agregar_btn"
        Me.Agregar_btn.Size = New System.Drawing.Size(44, 40)
        Me.Agregar_btn.TabIndex = 318
        Me.Agregar_btn.UseVisualStyleBackColor = True
        '
        'Nuevo_btn
        '
        Me.Nuevo_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Nuevo_btn.FlatAppearance.BorderSize = 0
        Me.Nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo_btn.Image = CType(resources.GetObject("Nuevo_btn.Image"), System.Drawing.Image)
        Me.Nuevo_btn.Location = New System.Drawing.Point(89, 226)
        Me.Nuevo_btn.Name = "Nuevo_btn"
        Me.Nuevo_btn.Size = New System.Drawing.Size(45, 39)
        Me.Nuevo_btn.TabIndex = 317
        Me.Nuevo_btn.UseVisualStyleBackColor = True
        '
        'btn_Exporta
        '
        Me.btn_Exporta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Exporta.FlatAppearance.BorderSize = 0
        Me.btn_Exporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exporta.Image = CType(resources.GetObject("btn_Exporta.Image"), System.Drawing.Image)
        Me.btn_Exporta.Location = New System.Drawing.Point(427, 66)
        Me.btn_Exporta.Name = "btn_Exporta"
        Me.btn_Exporta.Size = New System.Drawing.Size(44, 35)
        Me.btn_Exporta.TabIndex = 316
        Me.btn_Exporta.UseVisualStyleBackColor = True
        '
        'dg_Productos
        '
        Me.dg_Productos.AllowUserToAddRows = False
        Me.dg_Productos.AllowUserToDeleteRows = False
        Me.dg_Productos.AllowUserToResizeColumns = False
        Me.dg_Productos.AllowUserToResizeRows = False
        Me.dg_Productos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dg_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Productos.Location = New System.Drawing.Point(21, 116)
        Me.dg_Productos.Name = "dg_Productos"
        Me.dg_Productos.ReadOnly = True
        Me.dg_Productos.RowHeadersVisible = False
        Me.dg_Productos.ShowCellErrors = False
        Me.dg_Productos.Size = New System.Drawing.Size(628, 107)
        Me.dg_Productos.TabIndex = 338
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(478, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 35)
        Me.Button3.TabIndex = 339
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pnPrecio
        '
        Me.pnPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnPrecio.BackColor = System.Drawing.Color.Maroon
        Me.pnPrecio.Controls.Add(Me.TextBox1)
        Me.pnPrecio.Controls.Add(Me.Label3)
        Me.pnPrecio.Controls.Add(Me.Valor_Producto)
        Me.pnPrecio.Controls.Add(Me.label1)
        Me.pnPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnPrecio.Location = New System.Drawing.Point(471, 298)
        Me.pnPrecio.Name = "pnPrecio"
        Me.pnPrecio.Size = New System.Drawing.Size(182, 64)
        Me.pnPrecio.TabIndex = 340
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(80, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(77, 20)
        Me.TextBox1.TabIndex = 277
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 278
        Me.Label3.Text = "P.Venta"
        '
        'rbTieneCelular
        '
        Me.rbTieneCelular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbTieneCelular.AutoSize = True
        Me.rbTieneCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTieneCelular.Location = New System.Drawing.Point(484, 264)
        Me.rbTieneCelular.Name = "rbTieneCelular"
        Me.rbTieneCelular.Size = New System.Drawing.Size(145, 22)
        Me.rbTieneCelular.TabIndex = 343
        Me.rbTieneCelular.TabStop = True
        Me.rbTieneCelular.Text = "Precio no definido"
        Me.rbTieneCelular.UseVisualStyleBackColor = True
        '
        'rb_pd
        '
        Me.rb_pd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rb_pd.AutoSize = True
        Me.rb_pd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_pd.Location = New System.Drawing.Point(484, 243)
        Me.rb_pd.Name = "rb_pd"
        Me.rb_pd.Size = New System.Drawing.Size(124, 22)
        Me.rb_pd.TabIndex = 342
        Me.rb_pd.TabStop = True
        Me.rb_pd.Text = "Precio definido"
        Me.rb_pd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(594, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 35)
        Me.Button1.TabIndex = 344
        Me.Button1.Text = "Categorias"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(686, 394)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rbTieneCelular)
        Me.Controls.Add(Me.pnPrecio)
        Me.Controls.Add(Me.rb_pd)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dg_Productos)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.panel8)
        Me.Controls.Add(Me.panel9)
        Me.Controls.Add(Me.Cancelar_btn)
        Me.Controls.Add(Me.Eliminar_btn)
        Me.Controls.Add(Me.Editar_btn)
        Me.Controls.Add(Me.Agregar_btn)
        Me.Controls.Add(Me.Nuevo_btn)
        Me.Controls.Add(Me.btn_Exporta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductos"
        Me.Text = "FrmProductos"
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        CType(Me.dg_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnPrecio.ResumeLayout(False)
        Me.pnPrecio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel7 As Panel
    Private WithEvents label9 As Label
    Private WithEvents panel8 As Panel
    Private WithEvents label1 As Label
    Private WithEvents Valor_Producto As TextBox
    Private WithEvents label10 As Label
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Private WithEvents Descripcion_Producto As TextBox
    Private WithEvents Id_Producto As TextBox
    Private WithEvents panel9 As Panel
    Private WithEvents Buscar_Medidas As TextBox
    Private WithEvents Cancelar_btn As Button
    Private WithEvents Eliminar_btn As Button
    Private WithEvents Editar_btn As Button
    Private WithEvents Agregar_btn As Button
    Private WithEvents Nuevo_btn As Button
    Private WithEvents btn_Exporta As Button
    Private WithEvents Label2 As Label
    Friend WithEvents Proveedor_cmbx As ComboBox
    Friend WithEvents Categorias_cmbx As ComboBox
    Friend WithEvents dg_Productos As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Button3 As Button
    Private WithEvents pnPrecio As Panel
    Friend WithEvents rbTieneCelular As RadioButton
    Friend WithEvents rb_pd As RadioButton
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
End Class
