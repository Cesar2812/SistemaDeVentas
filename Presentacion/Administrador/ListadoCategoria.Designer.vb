<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoCategoria))
        Me.btn_ListaProductos = New System.Windows.Forms.Button()
        Me.dtg_Categorias = New System.Windows.Forms.DataGridView()
        CType(Me.dtg_Categorias, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_ListaProductos.Location = New System.Drawing.Point(51, 12)
        Me.btn_ListaProductos.Name = "btn_ListaProductos"
        Me.btn_ListaProductos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_ListaProductos.Size = New System.Drawing.Size(261, 40)
        Me.btn_ListaProductos.TabIndex = 9
        Me.btn_ListaProductos.Text = "Listado categorias"
        Me.btn_ListaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ListaProductos.UseVisualStyleBackColor = False
        '
        'dtg_Categorias
        '
        Me.dtg_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Categorias.Location = New System.Drawing.Point(21, 58)
        Me.dtg_Categorias.Name = "dtg_Categorias"
        Me.dtg_Categorias.Size = New System.Drawing.Size(319, 342)
        Me.dtg_Categorias.TabIndex = 8
        '
        'ListadoCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(362, 428)
        Me.Controls.Add(Me.btn_ListaProductos)
        Me.Controls.Add(Me.dtg_Categorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListadoCategoria"
        Me.Text = "FrmCategorias"
        CType(Me.dtg_Categorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_ListaProductos As Button
    Friend WithEvents dtg_Categorias As DataGridView
End Class
