<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.pb_Admin = New System.Windows.Forms.PictureBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.pb_Cajero = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Pn_Contenedor = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pb_Admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Cajero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 55)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbUsuario)
        Me.Panel2.Controls.Add(Me.pb_Admin)
        Me.Panel2.Controls.Add(Me.lblRol)
        Me.Panel2.Controls.Add(Me.pb_Cajero)
        Me.Panel2.Location = New System.Drawing.Point(765, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 55)
        Me.Panel2.TabIndex = 0
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbUsuario.Location = New System.Drawing.Point(34, 9)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(179, 24)
        Me.lbUsuario.TabIndex = 2
        Me.lbUsuario.Text = "Sistema de ventas"
        Me.lbUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pb_Admin
        '
        Me.pb_Admin.Image = CType(resources.GetObject("pb_Admin.Image"), System.Drawing.Image)
        Me.pb_Admin.Location = New System.Drawing.Point(-1, 9)
        Me.pb_Admin.Name = "pb_Admin"
        Me.pb_Admin.Size = New System.Drawing.Size(36, 36)
        Me.pb_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Admin.TabIndex = 5
        Me.pb_Admin.TabStop = False
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.BackColor = System.Drawing.Color.Transparent
        Me.lblRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblRol.Location = New System.Drawing.Point(44, 33)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(157, 20)
        Me.lblRol.TabIndex = 3
        Me.lblRol.Text = "Sistema de ventas"
        Me.lblRol.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pb_Cajero
        '
        Me.pb_Cajero.Image = CType(resources.GetObject("pb_Cajero.Image"), System.Drawing.Image)
        Me.pb_Cajero.Location = New System.Drawing.Point(2, 11)
        Me.pb_Cajero.Name = "pb_Cajero"
        Me.pb_Cajero.Size = New System.Drawing.Size(36, 36)
        Me.pb_Cajero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Cajero.TabIndex = 7
        Me.pb_Cajero.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(995, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(118, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de ventas"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 646)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1044, 27)
        Me.Panel3.TabIndex = 3
        '
        'Pn_Contenedor
        '
        Me.Pn_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Contenedor.Location = New System.Drawing.Point(0, 55)
        Me.Pn_Contenedor.Name = "Pn_Contenedor"
        Me.Pn_Contenedor.Size = New System.Drawing.Size(1044, 591)
        Me.Pn_Contenedor.TabIndex = 8
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1044, 673)
        Me.Controls.Add(Me.Pn_Contenedor)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pb_Admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Cajero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lblRol As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pn_Contenedor As Panel
    Friend WithEvents pb_Admin As PictureBox
    Friend WithEvents pb_Cajero As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
