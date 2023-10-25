<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategorias))
        Me.Datos_categorias_dgv = New System.Windows.Forms.DataGridView()
        Me.panel9 = New System.Windows.Forms.Panel()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        Me.btnBuscar_Medidas = New System.Windows.Forms.Button()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Nombre_txt = New System.Windows.Forms.TextBox()
        Me.Cod_categoria_txt = New System.Windows.Forms.TextBox()
        Me.Cancelar_btn = New System.Windows.Forms.Button()
        Me.Eliminar_btn = New System.Windows.Forms.Button()
        Me.Editar_btn = New System.Windows.Forms.Button()
        Me.Agregar_btn = New System.Windows.Forms.Button()
        Me.Nuevo_btn = New System.Windows.Forms.Button()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.Exportar_pdf_btn = New System.Windows.Forms.Button()
        Me.btn_Exporta = New System.Windows.Forms.Button()
        CType(Me.Datos_categorias_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel9.SuspendLayout()
        Me.panel8.SuspendLayout()
        Me.panel7.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datos_categorias_dgv
        '
        Me.Datos_categorias_dgv.AllowUserToAddRows = False
        Me.Datos_categorias_dgv.AllowUserToDeleteRows = False
        Me.Datos_categorias_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos_categorias_dgv.Location = New System.Drawing.Point(15, 120)
        Me.Datos_categorias_dgv.Name = "Datos_categorias_dgv"
        Me.Datos_categorias_dgv.ReadOnly = True
        Me.Datos_categorias_dgv.Size = New System.Drawing.Size(286, 136)
        Me.Datos_categorias_dgv.TabIndex = 8
        '
        'panel9
        '
        Me.panel9.Controls.Add(Me.Buscar_txt)
        Me.panel9.Controls.Add(Me.btnBuscar_Medidas)
        Me.panel9.Location = New System.Drawing.Point(33, 65)
        Me.panel9.Name = "panel9"
        Me.panel9.Size = New System.Drawing.Size(268, 37)
        Me.panel9.TabIndex = 327
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Location = New System.Drawing.Point(88, 8)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(169, 20)
        Me.Buscar_txt.TabIndex = 83
        '
        'btnBuscar_Medidas
        '
        Me.btnBuscar_Medidas.Location = New System.Drawing.Point(3, 3)
        Me.btnBuscar_Medidas.Name = "btnBuscar_Medidas"
        Me.btnBuscar_Medidas.Size = New System.Drawing.Size(79, 29)
        Me.btnBuscar_Medidas.TabIndex = 301
        Me.btnBuscar_Medidas.Text = "Buscar"
        Me.btnBuscar_Medidas.UseVisualStyleBackColor = True
        '
        'panel8
        '
        Me.panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel8.BackColor = System.Drawing.Color.Blue
        Me.panel8.Controls.Add(Me.label11)
        Me.panel8.Controls.Add(Me.label12)
        Me.panel8.Controls.Add(Me.Nombre_txt)
        Me.panel8.Controls.Add(Me.Cod_categoria_txt)
        Me.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel8.Location = New System.Drawing.Point(338, 125)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(241, 110)
        Me.panel8.TabIndex = 347
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(22, 52)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(70, 21)
        Me.label11.TabIndex = 273
        Me.label11.Text = "Nombre"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(22, 5)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(61, 21)
        Me.label12.TabIndex = 272
        Me.label12.Text = "Codigo"
        '
        'Nombre_txt
        '
        Me.Nombre_txt.Location = New System.Drawing.Point(21, 76)
        Me.Nombre_txt.Name = "Nombre_txt"
        Me.Nombre_txt.Size = New System.Drawing.Size(198, 20)
        Me.Nombre_txt.TabIndex = 269
        Me.Nombre_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cod_categoria_txt
        '
        Me.Cod_categoria_txt.Location = New System.Drawing.Point(21, 29)
        Me.Cod_categoria_txt.Name = "Cod_categoria_txt"
        Me.Cod_categoria_txt.Size = New System.Drawing.Size(135, 20)
        Me.Cod_categoria_txt.TabIndex = 268
        Me.Cod_categoria_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cancelar_btn
        '
        Me.Cancelar_btn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Cancelar_btn.FlatAppearance.BorderSize = 0
        Me.Cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelar_btn.Image = CType(resources.GetObject("Cancelar_btn.Image"), System.Drawing.Image)
        Me.Cancelar_btn.Location = New System.Drawing.Point(438, 243)
        Me.Cancelar_btn.Name = "Cancelar_btn"
        Me.Cancelar_btn.Size = New System.Drawing.Size(34, 35)
        Me.Cancelar_btn.TabIndex = 352
        Me.Cancelar_btn.UseVisualStyleBackColor = True
        '
        'Eliminar_btn
        '
        Me.Eliminar_btn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Eliminar_btn.FlatAppearance.BorderSize = 0
        Me.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar_btn.Image = CType(resources.GetObject("Eliminar_btn.Image"), System.Drawing.Image)
        Me.Eliminar_btn.Location = New System.Drawing.Point(478, 244)
        Me.Eliminar_btn.Name = "Eliminar_btn"
        Me.Eliminar_btn.Size = New System.Drawing.Size(41, 35)
        Me.Eliminar_btn.TabIndex = 351
        Me.Eliminar_btn.UseVisualStyleBackColor = True
        '
        'Editar_btn
        '
        Me.Editar_btn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Editar_btn.FlatAppearance.BorderSize = 0
        Me.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_btn.Image = CType(resources.GetObject("Editar_btn.Image"), System.Drawing.Image)
        Me.Editar_btn.Location = New System.Drawing.Point(525, 244)
        Me.Editar_btn.Name = "Editar_btn"
        Me.Editar_btn.Size = New System.Drawing.Size(39, 35)
        Me.Editar_btn.TabIndex = 350
        Me.Editar_btn.UseVisualStyleBackColor = True
        '
        'Agregar_btn
        '
        Me.Agregar_btn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Agregar_btn.FlatAppearance.BorderSize = 0
        Me.Agregar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregar_btn.Image = CType(resources.GetObject("Agregar_btn.Image"), System.Drawing.Image)
        Me.Agregar_btn.Location = New System.Drawing.Point(385, 244)
        Me.Agregar_btn.Name = "Agregar_btn"
        Me.Agregar_btn.Size = New System.Drawing.Size(47, 35)
        Me.Agregar_btn.TabIndex = 349
        Me.Agregar_btn.UseVisualStyleBackColor = True
        '
        'Nuevo_btn
        '
        Me.Nuevo_btn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Nuevo_btn.FlatAppearance.BorderSize = 0
        Me.Nuevo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo_btn.Image = CType(resources.GetObject("Nuevo_btn.Image"), System.Drawing.Image)
        Me.Nuevo_btn.Location = New System.Drawing.Point(338, 242)
        Me.Nuevo_btn.Name = "Nuevo_btn"
        Me.Nuevo_btn.Size = New System.Drawing.Size(41, 35)
        Me.Nuevo_btn.TabIndex = 348
        Me.Nuevo_btn.UseVisualStyleBackColor = True
        '
        'panel7
        '
        Me.panel7.BackColor = System.Drawing.Color.Blue
        Me.panel7.Controls.Add(Me.PictureBox2)
        Me.panel7.Controls.Add(Me.label9)
        Me.panel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel7.Location = New System.Drawing.Point(15, 12)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(584, 37)
        Me.panel7.TabIndex = 353
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(548, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.TabIndex = 354
        Me.PictureBox2.TabStop = False
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Snow
        Me.label9.Location = New System.Drawing.Point(30, 2)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(157, 32)
        Me.label9.TabIndex = 269
        Me.label9.Text = "Categorias"
        '
        'Exportar_pdf_btn
        '
        Me.Exportar_pdf_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Exportar_pdf_btn.FlatAppearance.BorderSize = 0
        Me.Exportar_pdf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exportar_pdf_btn.Image = CType(resources.GetObject("Exportar_pdf_btn.Image"), System.Drawing.Image)
        Me.Exportar_pdf_btn.Location = New System.Drawing.Point(528, 55)
        Me.Exportar_pdf_btn.Name = "Exportar_pdf_btn"
        Me.Exportar_pdf_btn.Size = New System.Drawing.Size(52, 35)
        Me.Exportar_pdf_btn.TabIndex = 356
        Me.Exportar_pdf_btn.UseVisualStyleBackColor = True
        '
        'btn_Exporta
        '
        Me.btn_Exporta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Exporta.FlatAppearance.BorderSize = 0
        Me.btn_Exporta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exporta.Image = CType(resources.GetObject("btn_Exporta.Image"), System.Drawing.Image)
        Me.btn_Exporta.Location = New System.Drawing.Point(478, 55)
        Me.btn_Exporta.Name = "btn_Exporta"
        Me.btn_Exporta.Size = New System.Drawing.Size(44, 35)
        Me.btn_Exporta.TabIndex = 355
        Me.btn_Exporta.UseVisualStyleBackColor = True
        '
        'FrmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(619, 289)
        Me.Controls.Add(Me.Exportar_pdf_btn)
        Me.Controls.Add(Me.btn_Exporta)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.Cancelar_btn)
        Me.Controls.Add(Me.Eliminar_btn)
        Me.Controls.Add(Me.Editar_btn)
        Me.Controls.Add(Me.Agregar_btn)
        Me.Controls.Add(Me.Nuevo_btn)
        Me.Controls.Add(Me.panel8)
        Me.Controls.Add(Me.panel9)
        Me.Controls.Add(Me.Datos_categorias_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListadoCategorias"
        CType(Me.Datos_categorias_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel9.ResumeLayout(False)
        Me.panel9.PerformLayout()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Datos_categorias_dgv As DataGridView
    Private WithEvents panel9 As Panel
    Private WithEvents Buscar_txt As TextBox
    Private WithEvents btnBuscar_Medidas As Button
    Private WithEvents panel8 As Panel
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Private WithEvents Nombre_txt As TextBox
    Private WithEvents Cod_categoria_txt As TextBox
    Private WithEvents Cancelar_btn As Button
    Private WithEvents Eliminar_btn As Button
    Private WithEvents Editar_btn As Button
    Private WithEvents Agregar_btn As Button
    Private WithEvents Nuevo_btn As Button
    Private WithEvents panel7 As Panel
    Private WithEvents label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents Exportar_pdf_btn As Button
    Private WithEvents btn_Exporta As Button
End Class
