<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoVentas))
        Me.dt_detalleventa = New System.Windows.Forms.DataGridView()
        Me.btn_ListaCompra = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Exportarpdf_btn = New System.Windows.Forms.Button()
        Me.ExportarExcel_btn = New System.Windows.Forms.Button()
        Me.dg_compras = New System.Windows.Forms.DataGridView()
        CType(Me.dt_detalleventa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt_detalleventa
        '
        Me.dt_detalleventa.AllowUserToAddRows = False
        Me.dt_detalleventa.AllowUserToDeleteRows = False
        Me.dt_detalleventa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dt_detalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_detalleventa.Location = New System.Drawing.Point(22, 286)
        Me.dt_detalleventa.Name = "dt_detalleventa"
        Me.dt_detalleventa.ReadOnly = True
        Me.dt_detalleventa.RowHeadersVisible = False
        Me.dt_detalleventa.Size = New System.Drawing.Size(456, 200)
        Me.dt_detalleventa.TabIndex = 62
        '
        'btn_ListaCompra
        '
        Me.btn_ListaCompra.BackColor = System.Drawing.Color.Transparent
        Me.btn_ListaCompra.FlatAppearance.BorderSize = 0
        Me.btn_ListaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ListaCompra.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ListaCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_ListaCompra.Image = CType(resources.GetObject("btn_ListaCompra.Image"), System.Drawing.Image)
        Me.btn_ListaCompra.Location = New System.Drawing.Point(146, 57)
        Me.btn_ListaCompra.Name = "btn_ListaCompra"
        Me.btn_ListaCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_ListaCompra.Size = New System.Drawing.Size(222, 40)
        Me.btn_ListaCompra.TabIndex = 61
        Me.btn_ListaCompra.Text = "Listado de ventas"
        Me.btn_ListaCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_ListaCompra.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Eras Demi ITC", 14.25!)
        Me.Label15.Location = New System.Drawing.Point(54, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 23)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Buscar:"
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Buscar_txt.Location = New System.Drawing.Point(131, 31)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(210, 20)
        Me.Buscar_txt.TabIndex = 59
        Me.Buscar_txt.Text = "dg_compras"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(503, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 377)
        Me.Panel1.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Demi ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(397, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 23)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Vista"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(458, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 55
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(616, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 35)
        Me.Button4.TabIndex = 350
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Exportarpdf_btn
        '
        Me.Exportarpdf_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Exportarpdf_btn.FlatAppearance.BorderSize = 0
        Me.Exportarpdf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exportarpdf_btn.Image = CType(resources.GetObject("Exportarpdf_btn.Image"), System.Drawing.Image)
        Me.Exportarpdf_btn.Location = New System.Drawing.Point(718, 40)
        Me.Exportarpdf_btn.Name = "Exportarpdf_btn"
        Me.Exportarpdf_btn.Size = New System.Drawing.Size(52, 35)
        Me.Exportarpdf_btn.TabIndex = 349
        Me.Exportarpdf_btn.UseVisualStyleBackColor = True
        '
        'ExportarExcel_btn
        '
        Me.ExportarExcel_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ExportarExcel_btn.FlatAppearance.BorderSize = 0
        Me.ExportarExcel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportarExcel_btn.Image = CType(resources.GetObject("ExportarExcel_btn.Image"), System.Drawing.Image)
        Me.ExportarExcel_btn.Location = New System.Drawing.Point(668, 41)
        Me.ExportarExcel_btn.Name = "ExportarExcel_btn"
        Me.ExportarExcel_btn.Size = New System.Drawing.Size(44, 35)
        Me.ExportarExcel_btn.TabIndex = 348
        Me.ExportarExcel_btn.UseVisualStyleBackColor = True
        '
        'dg_compras
        '
        Me.dg_compras.AllowUserToAddRows = False
        Me.dg_compras.AllowUserToDeleteRows = False
        Me.dg_compras.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dg_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_compras.Location = New System.Drawing.Point(22, 102)
        Me.dg_compras.Name = "dg_compras"
        Me.dg_compras.ReadOnly = True
        Me.dg_compras.RowHeadersVisible = False
        Me.dg_compras.Size = New System.Drawing.Size(456, 178)
        Me.dg_compras.TabIndex = 351
        '
        'ListadoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 518)
        Me.Controls.Add(Me.dg_compras)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Exportarpdf_btn)
        Me.Controls.Add(Me.ExportarExcel_btn)
        Me.Controls.Add(Me.dt_detalleventa)
        Me.Controls.Add(Me.btn_ListaCompra)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Buscar_txt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListadoVentas"
        Me.Text = "ListadoVentas"
        CType(Me.dt_detalleventa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dt_detalleventa As DataGridView
    Friend WithEvents btn_ListaCompra As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Buscar_txt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Private WithEvents Button4 As Button
    Private WithEvents Exportarpdf_btn As Button
    Private WithEvents ExportarExcel_btn As Button
    Friend WithEvents dg_compras As DataGridView
End Class
