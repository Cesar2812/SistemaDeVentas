<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelefono
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelefono))
        Me.Datos_telefono_dgv = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panel8 = New System.Windows.Forms.Panel()
        Me.cmbcompania_cmbx = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numero_txt = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.NombreCliente_txt = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Cod_telefono_txt = New System.Windows.Forms.TextBox()
        Me.Eliminar_btn = New System.Windows.Forms.Button()
        Me.Editar_btn = New System.Windows.Forms.Button()
        CType(Me.Datos_telefono_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Datos_telefono_dgv
        '
        Me.Datos_telefono_dgv.AllowUserToAddRows = False
        Me.Datos_telefono_dgv.AllowUserToDeleteRows = False
        Me.Datos_telefono_dgv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Datos_telefono_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datos_telefono_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.Datos_telefono_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos_telefono_dgv.Location = New System.Drawing.Point(14, 27)
        Me.Datos_telefono_dgv.Name = "Datos_telefono_dgv"
        Me.Datos_telefono_dgv.ReadOnly = True
        Me.Datos_telefono_dgv.RowHeadersVisible = False
        Me.Datos_telefono_dgv.ShowCellErrors = False
        Me.Datos_telefono_dgv.Size = New System.Drawing.Size(335, 210)
        Me.Datos_telefono_dgv.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(562, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox2.TabIndex = 356
        Me.PictureBox2.TabStop = False
        '
        'panel8
        '
        Me.panel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel8.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.panel8.Controls.Add(Me.cmbcompania_cmbx)
        Me.panel8.Controls.Add(Me.Label3)
        Me.panel8.Controls.Add(Me.Label2)
        Me.panel8.Controls.Add(Me.numero_txt)
        Me.panel8.Controls.Add(Me.label1)
        Me.panel8.Controls.Add(Me.NombreCliente_txt)
        Me.panel8.Controls.Add(Me.label12)
        Me.panel8.Controls.Add(Me.Cod_telefono_txt)
        Me.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel8.Location = New System.Drawing.Point(355, 40)
        Me.panel8.Name = "panel8"
        Me.panel8.Size = New System.Drawing.Size(229, 197)
        Me.panel8.TabIndex = 357
        '
        'cmbcompania_cmbx
        '
        Me.cmbcompania_cmbx.FormattingEnabled = True
        Me.cmbcompania_cmbx.Items.AddRange(New Object() {"Selecciona una opcion", "Tigo", "Claro"})
        Me.cmbcompania_cmbx.Location = New System.Drawing.Point(13, 168)
        Me.cmbcompania_cmbx.Name = "cmbcompania_cmbx"
        Me.cmbcompania_cmbx.Size = New System.Drawing.Size(169, 21)
        Me.cmbcompania_cmbx.TabIndex = 281
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 280
        Me.Label3.Text = "Compañia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 278
        Me.Label2.Text = "Número"
        '
        'numero_txt
        '
        Me.numero_txt.Location = New System.Drawing.Point(13, 122)
        Me.numero_txt.Name = "numero_txt"
        Me.numero_txt.Size = New System.Drawing.Size(169, 20)
        Me.numero_txt.TabIndex = 277
        Me.numero_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(52, 52)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 21)
        Me.label1.TabIndex = 276
        Me.label1.Text = "Cliente"
        '
        'NombreCliente_txt
        '
        Me.NombreCliente_txt.Location = New System.Drawing.Point(10, 73)
        Me.NombreCliente_txt.Name = "NombreCliente_txt"
        Me.NombreCliente_txt.Size = New System.Drawing.Size(212, 20)
        Me.NombreCliente_txt.TabIndex = 275
        Me.NombreCliente_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(35, 5)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(61, 21)
        Me.label12.TabIndex = 272
        Me.label12.Text = "Codigo"
        '
        'Cod_telefono_txt
        '
        Me.Cod_telefono_txt.Location = New System.Drawing.Point(13, 29)
        Me.Cod_telefono_txt.Name = "Cod_telefono_txt"
        Me.Cod_telefono_txt.Size = New System.Drawing.Size(135, 20)
        Me.Cod_telefono_txt.TabIndex = 268
        Me.Cod_telefono_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Eliminar_btn
        '
        Me.Eliminar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Eliminar_btn.FlatAppearance.BorderSize = 0
        Me.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar_btn.Image = CType(resources.GetObject("Eliminar_btn.Image"), System.Drawing.Image)
        Me.Eliminar_btn.Location = New System.Drawing.Point(415, 243)
        Me.Eliminar_btn.Name = "Eliminar_btn"
        Me.Eliminar_btn.Size = New System.Drawing.Size(36, 39)
        Me.Eliminar_btn.TabIndex = 359
        Me.Eliminar_btn.UseVisualStyleBackColor = True
        '
        'Editar_btn
        '
        Me.Editar_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Editar_btn.FlatAppearance.BorderSize = 0
        Me.Editar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar_btn.Image = CType(resources.GetObject("Editar_btn.Image"), System.Drawing.Image)
        Me.Editar_btn.Location = New System.Drawing.Point(498, 243)
        Me.Editar_btn.Name = "Editar_btn"
        Me.Editar_btn.Size = New System.Drawing.Size(39, 39)
        Me.Editar_btn.TabIndex = 358
        Me.Editar_btn.UseVisualStyleBackColor = True
        '
        'FrmTelefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(596, 284)
        Me.Controls.Add(Me.Eliminar_btn)
        Me.Controls.Add(Me.Editar_btn)
        Me.Controls.Add(Me.panel8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Datos_telefono_dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTelefono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTelefono"
        CType(Me.Datos_telefono_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel8.ResumeLayout(False)
        Me.panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Datos_telefono_dgv As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents panel8 As Panel
    Private WithEvents label1 As Label
    Private WithEvents NombreCliente_txt As TextBox
    Private WithEvents label12 As Label
    Private WithEvents Cod_telefono_txt As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Label2 As Label
    Private WithEvents numero_txt As TextBox
    Friend WithEvents cmbcompania_cmbx As ComboBox
    Private WithEvents Eliminar_btn As Button
    Private WithEvents Editar_btn As Button
End Class
