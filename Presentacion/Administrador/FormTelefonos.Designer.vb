<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTelefonos
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
        Me.Nuevo_Medidas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Nuevo_Medidas
        '
        Me.Nuevo_Medidas.Location = New System.Drawing.Point(269, 151)
        Me.Nuevo_Medidas.Name = "Nuevo_Medidas"
        Me.Nuevo_Medidas.Size = New System.Drawing.Size(65, 35)
        Me.Nuevo_Medidas.TabIndex = 330
        Me.Nuevo_Medidas.Text = "Nuevo"
        Me.Nuevo_Medidas.UseVisualStyleBackColor = True
        '
        'FormTelefonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 213)
        Me.Controls.Add(Me.Nuevo_Medidas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTelefonos"
        Me.Text = "Telefonos"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Nuevo_Medidas As Button
End Class
