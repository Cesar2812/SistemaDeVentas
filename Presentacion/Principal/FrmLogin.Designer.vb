<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Ingresar_btn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.password_txb = New System.Windows.Forms.TextBox()
        Me.username_txb = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ingresar_btn
        '
        Me.Ingresar_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Ingresar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ingresar_btn.Location = New System.Drawing.Point(111, 198)
        Me.Ingresar_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Ingresar_btn.Name = "Ingresar_btn"
        Me.Ingresar_btn.Size = New System.Drawing.Size(106, 33)
        Me.Ingresar_btn.TabIndex = 2
        Me.Ingresar_btn.Text = "Ingresar"
        Me.Ingresar_btn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(263, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 148)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(32, 63)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(255, 247)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.CausesValidation = False
        Me.Panel2.Controls.Add(Me.Ingresar_btn)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.checkBox2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.checkBox1)
        Me.Panel2.Controls.Add(Me.password_txb)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.username_txb)
        Me.Panel2.Location = New System.Drawing.Point(293, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 250)
        Me.Panel2.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(44, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 42)
        Me.Label2.TabIndex = 260
        Me.Label2.Text = "Inicie Sesion"
        '
        'checkBox2
        '
        Me.checkBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkBox2.AutoSize = True
        Me.checkBox2.FlatAppearance.BorderSize = 0
        Me.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox2.Image = Global.Presentacion.My.Resources.Resources.ojo
        Me.checkBox2.Location = New System.Drawing.Point(266, 148)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(38, 38)
        Me.checkBox2.TabIndex = 259
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkBox1.AutoSize = True
        Me.checkBox1.FlatAppearance.BorderSize = 0
        Me.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Location = New System.Drawing.Point(261, 139)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(6, 6)
        Me.checkBox1.TabIndex = 18
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'password_txb
        '
        Me.password_txb.BackColor = System.Drawing.Color.DarkSlateGray
        Me.password_txb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password_txb.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txb.ForeColor = System.Drawing.Color.White
        Me.password_txb.Location = New System.Drawing.Point(39, 151)
        Me.password_txb.Name = "password_txb"
        Me.password_txb.Size = New System.Drawing.Size(228, 23)
        Me.password_txb.TabIndex = 17
        Me.password_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password_txb.UseSystemPasswordChar = True
        '
        'username_txb
        '
        Me.username_txb.BackColor = System.Drawing.Color.DarkSlateGray
        Me.username_txb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username_txb.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txb.ForeColor = System.Drawing.Color.White
        Me.username_txb.Location = New System.Drawing.Point(39, 100)
        Me.username_txb.Name = "username_txb"
        Me.username_txb.Size = New System.Drawing.Size(228, 23)
        Me.username_txb.TabIndex = 16
        Me.username_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-16, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(648, 370)
        Me.PictureBox5.TabIndex = 260
        Me.PictureBox5.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 385)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ingresar_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Private WithEvents Panel2 As Panel
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents password_txb As TextBox
    Private WithEvents username_txb As TextBox
    Private WithEvents checkBox2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
