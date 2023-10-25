Public Class Menu_Configuracion
    Private Sub Proveedor_btn_Click(sender As Object, e As EventArgs) Handles Proveedor_btn.Click
        AbrirFormularioContenedor(New FrmProveedor())
    End Sub
    Private activarforma As Form = Nothing
    Private Sub AbrirFormularioContenedor(FormularioPrimario As Form)
        If activarforma IsNot Nothing Then
            activarforma.Close()
        End If
        activarforma = FormularioPrimario
        FormularioPrimario.TopLevel = False
        FormularioPrimario.FormBorderStyle = FormBorderStyle.None
        FormularioPrimario.Dock = DockStyle.Fill
        Pn_Contenedor.Controls.Add(FormularioPrimario)
        Pn_Contenedor.Tag = FormularioPrimario
        FormularioPrimario.BringToFront()
        FormularioPrimario.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormularioContenedor(New FrmCliente())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormularioContenedor(New FrmProductos())
    End Sub

    Private Sub Usuarios_btn_Click(sender As Object, e As EventArgs) Handles Usuarios_btn.Click
        AbrirFormularioContenedor(New FrmUsuario())
    End Sub
End Class