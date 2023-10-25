<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadProveedor))
        Me.btn_ListaProductos = New System.Windows.Forms.Button()
        Me.dg_Proveedor = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        CType(Me.dg_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ListaProductos
        '
        Me.btn_ListaProductos.BackColor = System.Drawing.Color.Transparent
        Me.btn_ListaProductos.FlatAppearance.BorderSize = 0
        Me.btn_ListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ListaProductos.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ListaProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_ListaProductos.Image = CType(resources.GetObject("btn_ListaProductos.Image"), System.Drawing.Image)
        Me.btn_ListaProductos.Location = New System.Drawing.Point(65, 7)
        Me.btn_ListaProductos.Name = "btn_ListaProductos"
        Me.btn_ListaProductos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_ListaProductos.Size = New System.Drawing.Size(222, 40)
        Me.btn_ListaProductos.TabIndex = 9
        Me.btn_ListaProductos.Text = "Listado proveedor"
        Me.btn_ListaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ListaProductos.UseVisualStyleBackColor = False
        '
        'dg_Proveedor
        '
        Me.dg_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Proveedor.Location = New System.Drawing.Point(12, 85)
        Me.dg_Proveedor.Name = "dg_Proveedor"
        Me.dg_Proveedor.Size = New System.Drawing.Size(335, 315)
        Me.dg_Proveedor.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 15)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Buscar:"
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Location = New System.Drawing.Point(84, 49)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(235, 20)
        Me.Buscar_txt.TabIndex = 54
        '
        'ListadProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 423)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Buscar_txt)
        Me.Controls.Add(Me.btn_ListaProductos)
        Me.Controls.Add(Me.dg_Proveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListadProveedor"
        Me.Text = "ListadProveedor"
        CType(Me.dg_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ListaProductos As Button
    Friend WithEvents dg_Proveedor As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Buscar_txt As TextBox
End Class
