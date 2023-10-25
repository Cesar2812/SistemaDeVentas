Public Class ModoCajero


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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AbrirFormularioContenedor(New FrmVentas())
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AbrirFormularioContenedor(New FrmAlmacen())
    End Sub

    Private Sub Pn_Contenedor_Paint(sender As Object, e As PaintEventArgs) Handles Pn_Contenedor.Paint

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class