<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedor))
        Me.Datos_proveedor_dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Codigo_txt = New System.Windows.Forms.TextBox()
        Me.Nombre_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ruc_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Direccion_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Telefono_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pagina_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Editar_btn = New System.Windows.Forms.Button()
        Me.Agregar_btn = New System.Windows.Forms.Button()
        Me.Eliminar_btn = New System.Windows.Forms.Button()
        Me.Cancelar_btn = New System.Windows.Forms.Button()
        Me.Nuevo_btn = New System.Windows.Forms.Button()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.btn_Exporta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Datos_proveedor_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Datos_proveedor_dgv
        '
        Me.Datos_proveedor_dgv.AllowUserToAddRows = False
        Me.Datos_proveedor_dgv.AllowUserToDeleteRows = False
        Me.Datos_proveedor_dgv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Datos_proveedor_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datos_proveedor_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Datos_proveedor_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos_proveedor_dgv.Location = New System.Drawing.Point(30, 96)
        Me.Datos_proveedor_dgv.Name = "Datos_proveedor_dgv"
        Me.Datos_proveedor_dgv.ReadOnly = True
        Me.Datos_proveedor_dgv.RowHeadersVisible = False
        Me.Datos_proveedor_dgv.ShowCellErrors = False
        Me.Datos_proveedor_dgv.Size = New System.Drawing.Size(595, 119)
        Me.Datos_proveedor_dgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        '
        'Codigo_txt
        '
        Me.Codigo_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Codigo_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Codigo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_txt.Location = New System.Drawing.Point(16, 23)
        Me.Codigo_txt.Name = "Codigo_txt"
        Me.Codigo_txt.ReadOnly = True
        Me.Codigo_txt.Size = New System.Drawing.Size(154, 22)
        Me.Codigo_txt.TabIndex = 2
        '
        'Nombre_txt
        '
        Me.Nombre_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Nombre_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Nombre_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_txt.Location = New System.Drawing.Point(179, 23)
        Me.Nombre_txt.Name = "Nombre_txt"
        Me.Nombre_txt.ReadOnly = True
        Me.Nombre_txt.Size = New System.Drawing.Size(196, 22)
        Me.Nombre_txt.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Ruc_txt
        '
        Me.Ruc_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Ruc_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Ruc_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ruc_txt.Location = New System.Drawing.Point(381, 23)
        Me.Ruc_txt.Name = "Ruc_txt"
        Me.Ruc_txt.ReadOnly = True
        Me.Ruc_txt.Size = New System.Drawing.Size(189, 22)
        Me.Ruc_txt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RUC"
        '
        'Direccion_txt
        '
        Me.Direccion_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Direccion_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Direccion_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Direccion_txt.Location = New System.Drawing.Point(159, 78)
        Me.Direccion_txt.Name = "Direccion_txt"
        Me.Direccion_txt.ReadOnly = True
        Me.Direccion_txt.Size = New System.Drawing.Size(216, 22)
        Me.Direccion_txt.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Direccion"
        '
        'Telefono_txt
        '
        Me.Telefono_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Telefono_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Telefono_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefono_txt.Location = New System.Drawing.Point(16, 78)
        Me.Telefono_txt.Name = "Telefono_txt"
        Me.Telefono_txt.ReadOnly = True
        Me.Telefono_txt.Size = New System.Drawing.Size(137, 22)
        Me.Telefono_txt.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Celular"
        '
        'Pagina_txt
        '
        Me.Pagina_txt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Pagina_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Pagina_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pagina_txt.Location = New System.Drawing.Point(378, 78)
        Me.Pagina_txt.Name = "Pagina_txt"
        Me.Pagina_txt.ReadOnly = True
        Me.Pagina_txt.Size = New System.Drawing.Size(224, 22)
        Me.Pagina_txt.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pagina"
        '
        'Editar_btn
        '
        Me.Editar_btn.BackColor = System.Drawing.Color.Gray
        Me.Editar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editar_btn.ForeColor = System.Drawing.Color.White
        Me.Editar_btn.Image = CType(resources.GetObject("Editar_btn.Image"), System.Drawing.Image)
        Me.Editar_btn.Location = New System.Drawing.Point(336, 221)
        Me.Editar_btn.Name = "Editar_btn"
        Me.Editar_btn.Size = New System.Drawing.Size(50, 39)
        Me.Editar_btn.TabIndex = 13
        Me.Editar_btn.UseVisualStyleBackColor = False
        '
        'Agregar_btn
        '
        Me.Agregar_btn.BackColor = System.Drawing.Color.Gray
        Me.Agregar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Agregar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar_btn.ForeColor = System.Drawing.Color.White
        Me.Agregar_btn.Image = CType(resources.GetObject("Agregar_btn.Image"), System.Drawing.Image)
        Me.Agregar_btn.Location = New System.Drawing.Point(234, 223)
        Me.Agregar_btn.Name = "Agregar_btn"
        Me.Agregar_btn.Size = New System.Drawing.Size(44, 36)
        Me.Agregar_btn.TabIndex = 14
        Me.Agregar_btn.UseVisualStyleBackColor = False
        '
        'Eliminar_btn
        '
        Me.Eliminar_btn.BackColor = System.Drawing.Color.Gray
        Me.Eliminar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_btn.ForeColor = System.Drawing.Color.White
        Me.Eliminar_btn.Image = CType(resources.GetObject("Eliminar_btn.Image"), System.Drawing.Image)
        Me.Eliminar_btn.Location = New System.Drawing.Point(392, 223)
        Me.Eliminar_btn.Name = "Eliminar_btn"
        Me.Eliminar_btn.Size = New System.Drawing.Size(50, 39)
        Me.Eliminar_btn.TabIndex = 15
        Me.Eliminar_btn.UseVisualStyleBackColor = False
        '
        'Cancelar_btn
        '
        Me.Cancelar_btn.BackColor = System.Drawing.Color.Gray
        Me.Cancelar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar_btn.ForeColor = System.Drawing.Color.White
        Me.Cancelar_btn.Image = CType(resources.GetObject("Cancelar_btn.Image"), System.Drawing.Image)
        Me.Cancelar_btn.Location = New System.Drawing.Point(285, 222)
        Me.Cancelar_btn.Name = "Cancelar_btn"
        Me.Cancelar_btn.Size = New System.Drawing.Size(41, 37)
        Me.Cancelar_btn.TabIndex = 16
        Me.Cancelar_btn.UseVisualStyleBackColor = False
        '
        'Nuevo_btn
        '
        Me.Nuevo_btn.BackColor = System.Drawing.Color.Gray
        Me.Nuevo_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevo_btn.ForeColor = System.Drawing.Color.White
        Me.Nuevo_btn.Image = CType(resources.GetObject("Nuevo_btn.Image"), System.Drawing.Image)
        Me.Nuevo_btn.Location = New System.Drawing.Point(178, 223)
        Me.Nuevo_btn.Name = "Nuevo_btn"
        Me.Nuevo_btn.Size = New System.Drawing.Size(49, 36)
        Me.Nuevo_btn.TabIndex = 17
        Me.Nuevo_btn.UseVisualStyleBackColor = False
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Location = New System.Drawing.Point(118, 59)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(195, 20)
        Me.Buscar_txt.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Buscar:"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.panel3.Controls.Add(Me.PictureBox2)
        Me.panel3.Controls.Add(Me.Label8)
        Me.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel3.Location = New System.Drawing.Point(12, 10)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(641, 37)
        Me.panel3.TabIndex = 326
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(605, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.TabIndex = 355
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(3, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 32)
        Me.Label8.TabIndex = 269
        Me.Label8.Text = "Proveedor"
        '
        'panel8
        '
        Me.panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel8.BackColor = System.Drawing.Color.CadetBlue
        Me.panel8.Controls.Add(Me.Pagina_txt)
        Me.panel8.Controls.Add(Me.Label4)
        Me.panel8.Controls.Add(Me.Direccion_txt)
        Me.panel8.Controls.Add(Me.Label6)
        Me.panel8.Controls.Add(Me.Nombre_txt)
        Me.panel8.Controls.Add(Me.Label1)
        Me.panel8.Controls.Add(Me.Codigo_txt)
        Me.panel8.Controls.Add(Me.Label2)
        Me.panel8.Controls.Add(Me.Label3)
        Me.panel8.Controls.Add(Me.Telefono_txt)
        Me.panel8.Controls.Add(Me.Ruc_txt)
        Me.panel8.Controls.Add(Me.Label5)
        Me.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel8.Location = New System.Drawing.Point(30, 276)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(609, 116)
        Me.panel8.TabIndex = 327
        '
        'btn_Exporta
        '
        Me.btn_Exporta.FlatAppearance.BorderSize = 0
        Me.btn_Exporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exporta.Image = CType(resources.GetObject("btn_Exporta.Image"), System.Drawing.Image)
        Me.btn_Exporta.Location = New System.Drawing.Point(492, 52)
        Me.btn_Exporta.Name = "btn_Exporta"
        Me.btn_Exporta.Size = New System.Drawing.Size(42, 35)
        Me.btn_Exporta.TabIndex = 330
        Me.btn_Exporta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(540, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 35)
        Me.Button1.TabIndex = 331
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(678, 434)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Exporta)
        Me.Controls.Add(Me.panel8)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Buscar_txt)
        Me.Controls.Add(Me.Nuevo_btn)
        Me.Controls.Add(Me.Cancelar_btn)
        Me.Controls.Add(Me.Eliminar_btn)
        Me.Controls.Add(Me.Agregar_btn)
        Me.Controls.Add(Me.Editar_btn)
        Me.Controls.Add(Me.Datos_proveedor_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProveedor"
        Me.Text = "FrmProveedor"
        CType(Me.Datos_proveedor_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Datos_proveedor_dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Codigo_txt As TextBox
    'Friend WithEvents ProveedorTableAdapter As VentasBDDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents Nombre_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Ruc_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Direccion_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Telefono_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Pagina_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Editar_btn As Button
    Friend WithEvents Agregar_btn As Button
    Friend WithEvents Eliminar_btn As Button
    Friend WithEvents Cancelar_btn As Button
    Friend WithEvents Nuevo_btn As Button
    Friend WithEvents Buscar_txt As TextBox
    Friend WithEvents Label7 As Label
    Private WithEvents panel3 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents panel8 As Panel
    Private WithEvents btn_Exporta As Button
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents Button1 As Button
End Class
