<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cuidad_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Comuna_txt = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Ruc_txt = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Calle_txt = New System.Windows.Forms.TextBox()
        Me.Nombre_txt = New System.Windows.Forms.TextBox()
        Me.Cod_cliente_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cantidad_txb = New System.Windows.Forms.TextBox()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Buscar_Medidas = New System.Windows.Forms.TextBox()
        Me.Cancelar_btn = New System.Windows.Forms.Button()
        Me.Eliminar_btn = New System.Windows.Forms.Button()
        Me.Editar_btn = New System.Windows.Forms.Button()
        Me.Insertar_btn = New System.Windows.Forms.Button()
        Me.Nuevo_btn = New System.Windows.Forms.Button()
        Me.Datos_cliente_dgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelcelular = New System.Windows.Forms.Panel()
        Me.rbNotieneCelular = New System.Windows.Forms.RadioButton()
        Me.rbTieneCelular = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BotonCelular = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel8.SuspendLayout()
        Me.panel9.SuspendLayout()
        CType(Me.Datos_cliente_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcelular.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel7.Controls.Add(Me.PictureBox2)
        Me.panel7.Controls.Add(Me.label9)
        Me.panel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel7.Location = New System.Drawing.Point(12, 12)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(659, 39)
        Me.panel7.TabIndex = 336
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(618, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.TabIndex = 355
        Me.PictureBox2.TabStop = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Snow
        Me.label9.Location = New System.Drawing.Point(30, 2)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(124, 32)
        Me.label9.TabIndex = 269
        Me.label9.Text = "Clientes"
        '
        'panel8
        '
        Me.panel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel8.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel8.Controls.Add(Me.Label4)
        Me.panel8.Controls.Add(Me.Cuidad_txt)
        Me.panel8.Controls.Add(Me.Label3)
        Me.panel8.Controls.Add(Me.Comuna_txt)
        Me.panel8.Controls.Add(Me.label1)
        Me.panel8.Controls.Add(Me.Ruc_txt)
        Me.panel8.Controls.Add(Me.label10)
        Me.panel8.Controls.Add(Me.label11)
        Me.panel8.Controls.Add(Me.label12)
        Me.panel8.Controls.Add(Me.Calle_txt)
        Me.panel8.Controls.Add(Me.Nombre_txt)
        Me.panel8.Controls.Add(Me.Cod_cliente_txt)
        Me.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel8.Location = New System.Drawing.Point(21, 246)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(396, 164)
        Me.panel8.TabIndex = 335
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 283
        Me.Label4.Text = "Ciudad"
        '
        'Cuidad_txt
        '
        Me.Cuidad_txt.Location = New System.Drawing.Point(135, 126)
        Me.Cuidad_txt.Name = "Cuidad_txt"
        Me.Cuidad_txt.Size = New System.Drawing.Size(111, 20)
        Me.Cuidad_txt.TabIndex = 282
        Me.Cuidad_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 281
        Me.Label3.Text = "Comuna"
        '
        'Comuna_txt
        '
        Me.Comuna_txt.Location = New System.Drawing.Point(10, 126)
        Me.Comuna_txt.Name = "Comuna_txt"
        Me.Comuna_txt.Size = New System.Drawing.Size(115, 20)
        Me.Comuna_txt.TabIndex = 280
        Me.Comuna_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(193, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 21)
        Me.label1.TabIndex = 276
        Me.label1.Text = "Cédula"
        '
        'Ruc_txt
        '
        Me.Ruc_txt.Location = New System.Drawing.Point(151, 35)
        Me.Ruc_txt.Name = "Ruc_txt"
        Me.Ruc_txt.Size = New System.Drawing.Size(128, 20)
        Me.Ruc_txt.TabIndex = 275
        Me.Ruc_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(234, 61)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(49, 21)
        Me.label10.TabIndex = 274
        Me.label10.Text = "Calle"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(11, 59)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(70, 21)
        Me.label11.TabIndex = 273
        Me.label11.Text = "Nombre"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(32, 11)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(61, 21)
        Me.label12.TabIndex = 272
        Me.label12.Text = "Codigo"
        '
        'Calle_txt
        '
        Me.Calle_txt.Location = New System.Drawing.Point(211, 82)
        Me.Calle_txt.Name = "Calle_txt"
        Me.Calle_txt.Size = New System.Drawing.Size(138, 20)
        Me.Calle_txt.TabIndex = 271
        Me.Calle_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nombre_txt
        '
        Me.Nombre_txt.Location = New System.Drawing.Point(10, 81)
        Me.Nombre_txt.Name = "Nombre_txt"
        Me.Nombre_txt.Size = New System.Drawing.Size(195, 20)
        Me.Nombre_txt.TabIndex = 269
        Me.Nombre_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cod_cliente_txt
        '
        Me.Cod_cliente_txt.Location = New System.Drawing.Point(10, 35)
        Me.Cod_cliente_txt.Name = "Cod_cliente_txt"
        Me.Cod_cliente_txt.Size = New System.Drawing.Size(135, 20)
        Me.Cod_cliente_txt.TabIndex = 268
        Me.Cod_cliente_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 279
        Me.Label2.Text = "Cantidad"
        '
        'Cantidad_txb
        '
        Me.Cantidad_txb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Cantidad_txb.Location = New System.Drawing.Point(19, 40)
        Me.Cantidad_txb.Name = "Cantidad_txb"
        Me.Cantidad_txb.Size = New System.Drawing.Size(118, 20)
        Me.Cantidad_txb.TabIndex = 278
        Me.Cantidad_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panel9
        '
        Me.panel9.Controls.Add(Me.Label7)
        Me.panel9.Controls.Add(Me.Buscar_Medidas)
        Me.panel9.Location = New System.Drawing.Point(29, 57)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(367, 37)
        Me.panel9.TabIndex = 334
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Buscar:"
        '
        'Buscar_Medidas
        '
        Me.Buscar_Medidas.Location = New System.Drawing.Point(121, 8)
        Me.Buscar_Medidas.Name = "Buscar_Medidas"
        Me.Buscar_Medidas.Size = New System.Drawing.Size(232, 20)
        Me.Buscar_Medidas.TabIndex = 83
        '
        'Cancelar_btn
        '
        Me.Cancelar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancelar_btn.FlatAppearance.BorderSize = 0
        Me.Cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_btn.Image = CType(resources.GetObject("Cancelar_btn.Image"), System.Drawing.Image)
        Me.Cancelar_btn.Location = New System.Drawing.Point(606, 313)
        Me.Cancelar_btn.Name = "Cancelar_btn"
        Me.Cancelar_btn.Size = New System.Drawing.Size(65, 35)
        Me.Cancelar_btn.TabIndex = 333
        Me.Cancelar_btn.UseVisualStyleBackColor = True
        '
        'Eliminar_btn
        '
        Me.Eliminar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Eliminar_btn.FlatAppearance.BorderSize = 0
        Me.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar_btn.Image = CType(resources.GetObject("Eliminar_btn.Image"), System.Drawing.Image)
        Me.Eliminar_btn.Location = New System.Drawing.Point(606, 349)
        Me.Eliminar_btn.Name = "Eliminar_btn"
        Me.Eliminar_btn.Size = New System.Drawing.Size(65, 35)
        Me.Eliminar_btn.TabIndex = 332
        Me.Eliminar_btn.UseVisualStyleBackColor = True
        '
        'Editar_btn
        '
        Me.Editar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Editar_btn.FlatAppearance.BorderSize = 0
        Me.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_btn.Image = CType(resources.GetObject("Editar_btn.Image"), System.Drawing.Image)
        Me.Editar_btn.Location = New System.Drawing.Point(606, 386)
        Me.Editar_btn.Name = "Editar_btn"
        Me.Editar_btn.Size = New System.Drawing.Size(65, 35)
        Me.Editar_btn.TabIndex = 331
        Me.Editar_btn.UseVisualStyleBackColor = True
        '
        'Insertar_btn
        '
        Me.Insertar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Insertar_btn.FlatAppearance.BorderSize = 0
        Me.Insertar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insertar_btn.Image = CType(resources.GetObject("Insertar_btn.Image"), System.Drawing.Image)
        Me.Insertar_btn.Location = New System.Drawing.Point(606, 275)
        Me.Insertar_btn.Name = "Insertar_btn"
        Me.Insertar_btn.Size = New System.Drawing.Size(65, 35)
        Me.Insertar_btn.TabIndex = 330
        Me.Insertar_btn.UseVisualStyleBackColor = True
        '
        'Nuevo_btn
        '
        Me.Nuevo_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Nuevo_btn.FlatAppearance.BorderSize = 0
        Me.Nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo_btn.Image = CType(resources.GetObject("Nuevo_btn.Image"), System.Drawing.Image)
        Me.Nuevo_btn.Location = New System.Drawing.Point(606, 237)
        Me.Nuevo_btn.Name = "Nuevo_btn"
        Me.Nuevo_btn.Size = New System.Drawing.Size(65, 35)
        Me.Nuevo_btn.TabIndex = 329
        Me.Nuevo_btn.UseVisualStyleBackColor = True
        '
        'Datos_cliente_dgv
        '
        Me.Datos_cliente_dgv.AllowUserToAddRows = False
        Me.Datos_cliente_dgv.AllowUserToDeleteRows = False
        Me.Datos_cliente_dgv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Datos_cliente_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datos_cliente_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Datos_cliente_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos_cliente_dgv.Location = New System.Drawing.Point(21, 100)
        Me.Datos_cliente_dgv.Name = "Datos_cliente_dgv"
        Me.Datos_cliente_dgv.ReadOnly = True
        Me.Datos_cliente_dgv.RowHeadersVisible = False
        Me.Datos_cliente_dgv.ShowCellErrors = False
        Me.Datos_cliente_dgv.Size = New System.Drawing.Size(645, 131)
        Me.Datos_cliente_dgv.TabIndex = 337
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.Location = New System.Drawing.Point(102, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 32)
        Me.Button1.TabIndex = 338
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panelcelular
        '
        Me.panelcelular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.panelcelular.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panelcelular.Controls.Add(Me.Label2)
        Me.panelcelular.Controls.Add(Me.Button1)
        Me.panelcelular.Controls.Add(Me.Cantidad_txb)
        Me.panelcelular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panelcelular.Location = New System.Drawing.Point(429, 327)
        Me.panelcelular.Name = "panelcelular"
        Me.panelcelular.Size = New System.Drawing.Size(167, 80)
        Me.panelcelular.TabIndex = 339
        '
        'rbNotieneCelular
        '
        Me.rbNotieneCelular.AutoSize = True
        Me.rbNotieneCelular.Location = New System.Drawing.Point(454, 281)
        Me.rbNotieneCelular.Name = "rbNotieneCelular"
        Me.rbNotieneCelular.Size = New System.Drawing.Size(99, 17)
        Me.rbNotieneCelular.TabIndex = 340
        Me.rbNotieneCelular.TabStop = True
        Me.rbNotieneCelular.Text = "No tiene celular"
        Me.rbNotieneCelular.UseVisualStyleBackColor = True
        '
        'rbTieneCelular
        '
        Me.rbTieneCelular.AutoSize = True
        Me.rbTieneCelular.Location = New System.Drawing.Point(454, 304)
        Me.rbTieneCelular.Name = "rbTieneCelular"
        Me.rbTieneCelular.Size = New System.Drawing.Size(94, 17)
        Me.rbTieneCelular.TabIndex = 341
        Me.rbTieneCelular.TabStop = True
        Me.rbTieneCelular.Text = "Si tiene celular"
        Me.rbTieneCelular.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(586, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 35)
        Me.Button3.TabIndex = 343
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(536, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 35)
        Me.Button2.TabIndex = 342
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(484, 57)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 35)
        Me.Button4.TabIndex = 344
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BotonCelular
        '
        Me.BotonCelular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BotonCelular.Location = New System.Drawing.Point(552, 256)
        Me.BotonCelular.Name = "BotonCelular"
        Me.BotonCelular.Size = New System.Drawing.Size(44, 25)
        Me.BotonCelular.TabIndex = 345
        Me.BotonCelular.Text = "Ver"
        Me.BotonCelular.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(450, 257)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(94, 17)
        Me.RadioButton1.TabIndex = 346
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si tiene celular"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 432)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.BotonCelular)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.rbTieneCelular)
        Me.Controls.Add(Me.rbNotieneCelular)
        Me.Controls.Add(Me.panelcelular)
        Me.Controls.Add(Me.Datos_cliente_dgv)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.panel8)
        Me.Controls.Add(Me.panel9)
        Me.Controls.Add(Me.Cancelar_btn)
        Me.Controls.Add(Me.Eliminar_btn)
        Me.Controls.Add(Me.Editar_btn)
        Me.Controls.Add(Me.Insertar_btn)
        Me.Controls.Add(Me.Nuevo_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCliente"
        Me.Text = "FrmCliente"
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        CType(Me.Datos_cliente_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcelular.ResumeLayout(False)
        Me.panelcelular.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel7 As Panel
    Private WithEvents label9 As Label
    Private WithEvents panel8 As Panel
    Private WithEvents Label2 As Label
    Private WithEvents Cantidad_txb As TextBox
    Private WithEvents label1 As Label
    Private WithEvents Ruc_txt As TextBox
    Private WithEvents label10 As Label
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Private WithEvents Calle_txt As TextBox
    Private WithEvents Nombre_txt As TextBox
    Private WithEvents Cod_cliente_txt As TextBox
    Private WithEvents panel9 As Panel
    Private WithEvents Buscar_Medidas As TextBox
    Private WithEvents Cancelar_btn As Button
    Private WithEvents Eliminar_btn As Button
    Private WithEvents Editar_btn As Button
    Private WithEvents Insertar_btn As Button
    Private WithEvents Nuevo_btn As Button
    Private WithEvents Label4 As Label
    Private WithEvents Cuidad_txt As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Comuna_txt As TextBox
    Friend WithEvents Datos_cliente_dgv As DataGridView
    Private WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents panelcelular As Panel
    Friend WithEvents rbNotieneCelular As RadioButton
    Friend WithEvents rbTieneCelular As RadioButton
    Private WithEvents Button3 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Button4 As Button
    Friend WithEvents Label7 As Label
    Private WithEvents BotonCelular As Button
    Friend WithEvents RadioButton1 As RadioButton
End Class
