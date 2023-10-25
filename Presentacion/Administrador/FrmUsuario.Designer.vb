<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.Datos_usuarios_dgv = New System.Windows.Forms.DataGridView()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Nombre_txt = New System.Windows.Forms.TextBox()
        Me.IdUsuario_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NombreUsuario_txt = New System.Windows.Forms.TextBox()
        Me.Cancelar_btn = New System.Windows.Forms.Button()
        Me.Eliminar_btn = New System.Windows.Forms.Button()
        Me.Editar_btn = New System.Windows.Forms.Button()
        Me.Agregar_btn = New System.Windows.Forms.Button()
        Me.Nuevo_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Roles_cmbx = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Clave_txt = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_Exporta = New System.Windows.Forms.Button()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Datos_usuarios_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Datos_usuarios_dgv
        '
        Me.Datos_usuarios_dgv.AllowUserToAddRows = False
        Me.Datos_usuarios_dgv.AllowUserToDeleteRows = False
        Me.Datos_usuarios_dgv.AllowUserToResizeColumns = False
        Me.Datos_usuarios_dgv.AllowUserToResizeRows = False
        Me.Datos_usuarios_dgv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Datos_usuarios_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datos_usuarios_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Datos_usuarios_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos_usuarios_dgv.Location = New System.Drawing.Point(14, 113)
        Me.Datos_usuarios_dgv.Name = "Datos_usuarios_dgv"
        Me.Datos_usuarios_dgv.ReadOnly = True
        Me.Datos_usuarios_dgv.RowHeadersVisible = False
        Me.Datos_usuarios_dgv.ShowCellErrors = False
        Me.Datos_usuarios_dgv.Size = New System.Drawing.Size(638, 123)
        Me.Datos_usuarios_dgv.TabIndex = 348
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel7.Controls.Add(Me.PictureBox1)
        Me.panel7.Controls.Add(Me.label9)
        Me.panel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel7.Location = New System.Drawing.Point(18, 11)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(642, 37)
        Me.panel7.TabIndex = 347
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(603, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 352
        Me.PictureBox1.TabStop = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Snow
        Me.label9.Location = New System.Drawing.Point(30, 2)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(130, 32)
        Me.label9.TabIndex = 269
        Me.label9.Text = "Usuarios"
        '
        'panel8
        '
        Me.panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel8.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel8.Controls.Add(Me.label11)
        Me.panel8.Controls.Add(Me.label12)
        Me.panel8.Controls.Add(Me.Nombre_txt)
        Me.panel8.Controls.Add(Me.IdUsuario_txt)
        Me.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel8.Location = New System.Drawing.Point(33, 260)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(212, 116)
        Me.panel8.TabIndex = 346
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(8, 55)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(70, 21)
        Me.label11.TabIndex = 273
        Me.label11.Text = "Nombre"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(8, 9)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(61, 21)
        Me.label12.TabIndex = 272
        Me.label12.Text = "Codigo"
        '
        'Nombre_txt
        '
        Me.Nombre_txt.Location = New System.Drawing.Point(7, 79)
        Me.Nombre_txt.Name = "Nombre_txt"
        Me.Nombre_txt.ReadOnly = True
        Me.Nombre_txt.Size = New System.Drawing.Size(194, 20)
        Me.Nombre_txt.TabIndex = 269
        Me.Nombre_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IdUsuario_txt
        '
        Me.IdUsuario_txt.Location = New System.Drawing.Point(7, 33)
        Me.IdUsuario_txt.Name = "IdUsuario_txt"
        Me.IdUsuario_txt.ReadOnly = True
        Me.IdUsuario_txt.Size = New System.Drawing.Size(135, 20)
        Me.IdUsuario_txt.TabIndex = 268
        Me.IdUsuario_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 283
        Me.Label4.Text = "Clave"
        '
        'NombreUsuario_txt
        '
        Me.NombreUsuario_txt.Location = New System.Drawing.Point(7, 24)
        Me.NombreUsuario_txt.Name = "NombreUsuario_txt"
        Me.NombreUsuario_txt.ReadOnly = True
        Me.NombreUsuario_txt.Size = New System.Drawing.Size(159, 20)
        Me.NombreUsuario_txt.TabIndex = 280
        Me.NombreUsuario_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cancelar_btn
        '
        Me.Cancelar_btn.FlatAppearance.BorderSize = 0
        Me.Cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_btn.Image = CType(resources.GetObject("Cancelar_btn.Image"), System.Drawing.Image)
        Me.Cancelar_btn.Location = New System.Drawing.Point(487, 356)
        Me.Cancelar_btn.Name = "Cancelar_btn"
        Me.Cancelar_btn.Size = New System.Drawing.Size(52, 35)
        Me.Cancelar_btn.TabIndex = 344
        Me.Cancelar_btn.UseVisualStyleBackColor = True
        '
        'Eliminar_btn
        '
        Me.Eliminar_btn.FlatAppearance.BorderSize = 0
        Me.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar_btn.Image = CType(resources.GetObject("Eliminar_btn.Image"), System.Drawing.Image)
        Me.Eliminar_btn.Location = New System.Drawing.Point(547, 298)
        Me.Eliminar_btn.Name = "Eliminar_btn"
        Me.Eliminar_btn.Size = New System.Drawing.Size(52, 35)
        Me.Eliminar_btn.TabIndex = 343
        Me.Eliminar_btn.UseVisualStyleBackColor = True
        '
        'Editar_btn
        '
        Me.Editar_btn.FlatAppearance.BorderSize = 0
        Me.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_btn.Image = CType(resources.GetObject("Editar_btn.Image"), System.Drawing.Image)
        Me.Editar_btn.Location = New System.Drawing.Point(556, 338)
        Me.Editar_btn.Name = "Editar_btn"
        Me.Editar_btn.Size = New System.Drawing.Size(39, 35)
        Me.Editar_btn.TabIndex = 342
        Me.Editar_btn.UseVisualStyleBackColor = True
        '
        'Agregar_btn
        '
        Me.Agregar_btn.FlatAppearance.BorderSize = 0
        Me.Agregar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar_btn.Image = CType(resources.GetObject("Agregar_btn.Image"), System.Drawing.Image)
        Me.Agregar_btn.Location = New System.Drawing.Point(487, 315)
        Me.Agregar_btn.Name = "Agregar_btn"
        Me.Agregar_btn.Size = New System.Drawing.Size(52, 35)
        Me.Agregar_btn.TabIndex = 341
        Me.Agregar_btn.UseVisualStyleBackColor = True
        '
        'Nuevo_btn
        '
        Me.Nuevo_btn.FlatAppearance.BorderSize = 0
        Me.Nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo_btn.Image = CType(resources.GetObject("Nuevo_btn.Image"), System.Drawing.Image)
        Me.Nuevo_btn.Location = New System.Drawing.Point(487, 269)
        Me.Nuevo_btn.Name = "Nuevo_btn"
        Me.Nuevo_btn.Size = New System.Drawing.Size(41, 35)
        Me.Nuevo_btn.TabIndex = 340
        Me.Nuevo_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel1.Controls.Add(Me.Roles_cmbx)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.NombreUsuario_txt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Clave_txt)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(263, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 154)
        Me.Panel1.TabIndex = 349
        '
        'Roles_cmbx
        '
        Me.Roles_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Roles_cmbx.FormattingEnabled = True
        Me.Roles_cmbx.Location = New System.Drawing.Point(7, 118)
        Me.Roles_cmbx.Name = "Roles_cmbx"
        Me.Roles_cmbx.Size = New System.Drawing.Size(159, 21)
        Me.Roles_cmbx.TabIndex = 285
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 21)
        Me.Label2.TabIndex = 284
        Me.Label2.Text = "Rol"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 21)
        Me.Label5.TabIndex = 274
        Me.Label5.Text = "Nombre de usuario"
        '
        'Clave_txt
        '
        Me.Clave_txt.Location = New System.Drawing.Point(7, 70)
        Me.Clave_txt.Name = "Clave_txt"
        Me.Clave_txt.ReadOnly = True
        Me.Clave_txt.Size = New System.Drawing.Size(159, 20)
        Me.Clave_txt.TabIndex = 271
        Me.Clave_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Clave_txt.UseSystemPasswordChar = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(560, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 35)
        Me.Button3.TabIndex = 352
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_Exporta
        '
        Me.btn_Exporta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Exporta.FlatAppearance.BorderSize = 0
        Me.btn_Exporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exporta.Image = CType(resources.GetObject("btn_Exporta.Image"), System.Drawing.Image)
        Me.btn_Exporta.Location = New System.Drawing.Point(510, 64)
        Me.btn_Exporta.Name = "btn_Exporta"
        Me.btn_Exporta.Size = New System.Drawing.Size(44, 35)
        Me.btn_Exporta.TabIndex = 351
        Me.btn_Exporta.UseVisualStyleBackColor = True
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar_txt.Location = New System.Drawing.Point(121, 3)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(169, 26)
        Me.Buscar_txt.TabIndex = 83
        '
        'panel9
        '
        Me.panel9.Controls.Add(Me.Label7)
        Me.panel9.Controls.Add(Me.Buscar_txt)
        Me.panel9.Location = New System.Drawing.Point(33, 63)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(367, 37)
        Me.panel9.TabIndex = 345
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Buscar:"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 434)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_Exporta)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Datos_usuarios_dgv)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.panel8)
        Me.Controls.Add(Me.panel9)
        Me.Controls.Add(Me.Cancelar_btn)
        Me.Controls.Add(Me.Eliminar_btn)
        Me.Controls.Add(Me.Editar_btn)
        Me.Controls.Add(Me.Agregar_btn)
        Me.Controls.Add(Me.Nuevo_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsuario"
        Me.Text = "FrmCrear_Usuario"
        CType(Me.Datos_usuarios_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Datos_usuarios_dgv As DataGridView
    Private WithEvents panel7 As Panel
    Private WithEvents label9 As Label
    Private WithEvents panel8 As Panel
    Private WithEvents Label4 As Label
    Private WithEvents NombreUsuario_txt As TextBox
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Private WithEvents Nombre_txt As TextBox
    Private WithEvents IdUsuario_txt As TextBox
    Private WithEvents Cancelar_btn As Button
    Private WithEvents Eliminar_btn As Button
    Private WithEvents Editar_btn As Button
    Private WithEvents Agregar_btn As Button
    Private WithEvents Nuevo_btn As Button
    Private WithEvents Panel1 As Panel
    Private WithEvents Label5 As Label
    Private WithEvents Clave_txt As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents Roles_cmbx As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Button3 As Button
    Private WithEvents btn_Exporta As Button
    Private WithEvents Buscar_txt As TextBox
    Private WithEvents panel9 As Panel
    Friend WithEvents Label7 As Label
End Class
