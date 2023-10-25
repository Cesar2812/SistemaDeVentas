<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCorreo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCorreo))
        Me.panel_Titulo_verClientes = New System.Windows.Forms.Panel()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Mensajetxt = New System.Windows.Forms.TextBox()
        Me.RutaArctxt = New System.Windows.Forms.TextBox()
        Me.Asuntotxt = New System.Windows.Forms.TextBox()
        Me.Receptortxt = New System.Windows.Forms.TextBox()
        Me.Emisortxt = New System.Windows.Forms.TextBox()
        Me.Passwordtxt = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_Verfactura = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.panel_Titulo_verClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_Titulo_verClientes
        '
        Me.panel_Titulo_verClientes.BackColor = System.Drawing.Color.MediumVioletRed
        Me.panel_Titulo_verClientes.Controls.Add(Me.labelTitulo)
        Me.panel_Titulo_verClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_Titulo_verClientes.Location = New System.Drawing.Point(0, 0)
        Me.panel_Titulo_verClientes.Name = "panel_Titulo_verClientes"
        Me.panel_Titulo_verClientes.Size = New System.Drawing.Size(845, 45)
        Me.panel_Titulo_verClientes.TabIndex = 229
        '
        'labelTitulo
        '
        Me.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelTitulo.AutoSize = True
        Me.labelTitulo.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelTitulo.Location = New System.Drawing.Point(261, 2)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(339, 43)
        Me.labelTitulo.TabIndex = 0
        Me.labelTitulo.Text = "ENVIOS DE CORREO"
        Me.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(32, 219)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(84, 20)
        Me.label6.TabIndex = 235
        Me.label6.Text = "Adjunto:"
        '
        'label5
        '
        Me.label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(32, 258)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(88, 20)
        Me.label5.TabIndex = 234
        Me.label5.Text = "Mensaje:"
        '
        'label3
        '
        Me.label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(32, 171)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 20)
        Me.label3.TabIndex = 233
        Me.label3.Text = "Asunto:"
        '
        'label2
        '
        Me.label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(52, 128)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(53, 20)
        Me.label2.TabIndex = 232
        Me.label2.Text = "Para:"
        '
        'label1
        '
        Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(405, 86)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(109, 20)
        Me.label1.TabIndex = 231
        Me.label1.Text = "Contraseña"
        Me.label1.Visible = False
        '
        'label4
        '
        Me.label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(63, 86)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(39, 20)
        Me.label4.TabIndex = 230
        Me.label4.Text = "De:"
        '
        'Mensajetxt
        '
        Me.Mensajetxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Mensajetxt.Location = New System.Drawing.Point(123, 258)
        Me.Mensajetxt.Multiline = True
        Me.Mensajetxt.Name = "Mensajetxt"
        Me.Mensajetxt.Size = New System.Drawing.Size(648, 182)
        Me.Mensajetxt.TabIndex = 238
        '
        'RutaArctxt
        '
        Me.RutaArctxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RutaArctxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RutaArctxt.Location = New System.Drawing.Point(123, 217)
        Me.RutaArctxt.Name = "RutaArctxt"
        Me.RutaArctxt.Size = New System.Drawing.Size(244, 22)
        Me.RutaArctxt.TabIndex = 239
        '
        'Asuntotxt
        '
        Me.Asuntotxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Asuntotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Asuntotxt.Location = New System.Drawing.Point(114, 171)
        Me.Asuntotxt.Name = "Asuntotxt"
        Me.Asuntotxt.Size = New System.Drawing.Size(210, 22)
        Me.Asuntotxt.TabIndex = 240
        '
        'Receptortxt
        '
        Me.Receptortxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Receptortxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receptortxt.Location = New System.Drawing.Point(114, 126)
        Me.Receptortxt.Name = "Receptortxt"
        Me.Receptortxt.Size = New System.Drawing.Size(210, 22)
        Me.Receptortxt.TabIndex = 241
        '
        'Emisortxt
        '
        Me.Emisortxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Emisortxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emisortxt.Location = New System.Drawing.Point(114, 86)
        Me.Emisortxt.Name = "Emisortxt"
        Me.Emisortxt.Size = New System.Drawing.Size(251, 22)
        Me.Emisortxt.TabIndex = 242
        '
        'Passwordtxt
        '
        Me.Passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Passwordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordtxt.Location = New System.Drawing.Point(523, 87)
        Me.Passwordtxt.Name = "Passwordtxt"
        Me.Passwordtxt.Size = New System.Drawing.Size(210, 22)
        Me.Passwordtxt.TabIndex = 243
        Me.Passwordtxt.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(373, 213)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 37)
        Me.Button4.TabIndex = 348
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_Verfactura
        '
        Me.btn_Verfactura.BackColor = System.Drawing.Color.Teal
        Me.btn_Verfactura.FlatAppearance.BorderSize = 0
        Me.btn_Verfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Verfactura.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Verfactura.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Verfactura.Image = CType(resources.GetObject("btn_Verfactura.Image"), System.Drawing.Image)
        Me.btn_Verfactura.Location = New System.Drawing.Point(655, 459)
        Me.btn_Verfactura.Name = "btn_Verfactura"
        Me.btn_Verfactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_Verfactura.Size = New System.Drawing.Size(128, 42)
        Me.btn_Verfactura.TabIndex = 349
        Me.btn_Verfactura.Text = "Enviar"
        Me.btn_Verfactura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_Verfactura.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(845, 549)
        Me.Controls.Add(Me.btn_Verfactura)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Passwordtxt)
        Me.Controls.Add(Me.Emisortxt)
        Me.Controls.Add(Me.Receptortxt)
        Me.Controls.Add(Me.Asuntotxt)
        Me.Controls.Add(Me.RutaArctxt)
        Me.Controls.Add(Me.Mensajetxt)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.panel_Titulo_verClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCorreo"
        Me.Text = "FrmCorreo"
        Me.panel_Titulo_verClientes.ResumeLayout(False)
        Me.panel_Titulo_verClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel_Titulo_verClientes As Panel
    Private WithEvents labelTitulo As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Friend WithEvents Mensajetxt As TextBox
    Friend WithEvents RutaArctxt As TextBox
    Friend WithEvents Asuntotxt As TextBox
    Friend WithEvents Receptortxt As TextBox
    Friend WithEvents Emisortxt As TextBox
    Friend WithEvents Passwordtxt As TextBox
    Private WithEvents Button4 As Button
    Friend WithEvents btn_Verfactura As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
