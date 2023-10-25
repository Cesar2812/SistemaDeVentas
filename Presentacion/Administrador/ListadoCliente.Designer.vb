<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoCliente))
        Me.dtg_Clientes = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        Me.panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label9 = New System.Windows.Forms.Label()
        CType(Me.dtg_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtg_Clientes
        '
        Me.dtg_Clientes.AllowUserToAddRows = False
        Me.dtg_Clientes.AllowUserToDeleteRows = False
        Me.dtg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_Clientes.Location = New System.Drawing.Point(15, 97)
        Me.dtg_Clientes.Name = "dtg_Clientes"
        Me.dtg_Clientes.ReadOnly = True
        Me.dtg_Clientes.Size = New System.Drawing.Size(319, 333)
        Me.dtg_Clientes.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Buscar:"
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Location = New System.Drawing.Point(83, 62)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(235, 20)
        Me.Buscar_txt.TabIndex = 21
        '
        'panel7
        '
        Me.panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel7.BackColor = System.Drawing.Color.Maroon
        Me.panel7.Controls.Add(Me.PictureBox1)
        Me.panel7.Controls.Add(Me.label9)
        Me.panel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.panel7.Location = New System.Drawing.Point(10, 12)
        Me.panel7.Name = "panel7"
        Me.panel7.Size = New System.Drawing.Size(333, 40)
        Me.panel7.TabIndex = 325
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(298, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 353
        Me.PictureBox1.TabStop = False
        '
        'label9
        '
        Me.label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Snow
        Me.label9.Location = New System.Drawing.Point(30, 4)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(110, 32)
        Me.label9.TabIndex = 269
        Me.label9.Text = "Cliente"
        '
        'ListadoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 457)
        Me.Controls.Add(Me.panel7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Buscar_txt)
        Me.Controls.Add(Me.dtg_Clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListadoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListadoCliente"
        CType(Me.dtg_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel7.ResumeLayout(False)
        Me.panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtg_Clientes As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Buscar_txt As TextBox
    Private WithEvents panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents label9 As Label
End Class
