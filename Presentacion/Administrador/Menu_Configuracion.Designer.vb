<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Configuracion))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Proveedor_btn = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Usuarios_btn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Pn_Contenedor = New System.Windows.Forms.Panel()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(16, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cliente"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Proveedor_btn
        '
        Me.Proveedor_btn.FlatAppearance.BorderSize = 0
        Me.Proveedor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Proveedor_btn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proveedor_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Proveedor_btn.Image = CType(resources.GetObject("Proveedor_btn.Image"), System.Drawing.Image)
        Me.Proveedor_btn.Location = New System.Drawing.Point(3, 60)
        Me.Proveedor_btn.Name = "Proveedor_btn"
        Me.Proveedor_btn.Size = New System.Drawing.Size(142, 48)
        Me.Proveedor_btn.TabIndex = 4
        Me.Proveedor_btn.Text = "Proveedor"
        Me.Proveedor_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Proveedor_btn.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel7.Controls.Add(Me.Usuarios_btn)
        Me.Panel7.Controls.Add(Me.Button4)
        Me.Panel7.Controls.Add(Me.Proveedor_btn)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(151, 541)
        Me.Panel7.TabIndex = 7
        '
        'Usuarios_btn
        '
        Me.Usuarios_btn.FlatAppearance.BorderSize = 0
        Me.Usuarios_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Usuarios_btn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuarios_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Usuarios_btn.Image = CType(resources.GetObject("Usuarios_btn.Image"), System.Drawing.Image)
        Me.Usuarios_btn.Location = New System.Drawing.Point(12, 168)
        Me.Usuarios_btn.Name = "Usuarios_btn"
        Me.Usuarios_btn.Size = New System.Drawing.Size(133, 48)
        Me.Usuarios_btn.TabIndex = 7
        Me.Usuarios_btn.Text = "Usuarios"
        Me.Usuarios_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Usuarios_btn.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(12, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 48)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Productos"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Pn_Contenedor
        '
        Me.Pn_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Contenedor.Location = New System.Drawing.Point(151, 0)
        Me.Pn_Contenedor.Name = "Pn_Contenedor"
        Me.Pn_Contenedor.Size = New System.Drawing.Size(768, 541)
        Me.Pn_Contenedor.TabIndex = 9
        '
        'Menu_Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 541)
        Me.Controls.Add(Me.Pn_Contenedor)
        Me.Controls.Add(Me.Panel7)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu_Configuracion"
        Me.Text = "Crear_Usuario"
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Proveedor_btn As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Pn_Contenedor As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Usuarios_btn As Button
End Class
