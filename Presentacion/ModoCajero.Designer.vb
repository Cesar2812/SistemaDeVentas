<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModoCajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModoCajero))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Pn_Contenedor = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 67)
        Me.Panel1.TabIndex = 7
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Teal
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.Control
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(290, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button8.Size = New System.Drawing.Size(114, 61)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Almacen"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Teal
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.Control
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(172, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button9.Size = New System.Drawing.Size(114, 61)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Ventas"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Pn_Contenedor
        '
        Me.Pn_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Contenedor.Location = New System.Drawing.Point(0, 67)
        Me.Pn_Contenedor.Name = "Pn_Contenedor"
        Me.Pn_Contenedor.Size = New System.Drawing.Size(913, 480)
        Me.Pn_Contenedor.TabIndex = 10
        '
        'ModoCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 547)
        Me.Controls.Add(Me.Pn_Contenedor)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModoCajero"
        Me.Text = "ModoCajero"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Pn_Contenedor As Panel
End Class
