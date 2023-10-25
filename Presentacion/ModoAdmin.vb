Public Class ModoAdmin



    Private activarforma As Form = Nothing
    'Private panelVisble As Boolean = False
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



    Private Sub btn_Home_Click(sender As Object, e As EventArgs)

        Button1.BackColor = Color.Teal
        Button3.BackColor = Color.Teal

        SubMernuC.Visible = False
        SubMernuV.Visible = False
    End Sub

    Private Sub Pn_Contenedor_Paint(sender As Object, e As PaintEventArgs) Handles Pn_Contenedor.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button3.BackColor = Color.Teal

        SubMernuC.Visible = False



        ' Verifica si ya se muestra pnopciones en Pn_Contenedor
        If Not Pn_Contenedor.Controls.Contains(SubMernuV) Then
            ' Si no se muestra, carga pnopciones
            Pn_Contenedor.Controls.Add(SubMernuV)
        End If
        ' Lleva pnopciones al frente
        SubMernuV.BringToFront()
        ' Hazlo visible
        SubMernuV.Visible = True
        ' Cambia el fondo de Button1 (si es necesario)
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Button1.BackColor = Color.Teal
        Button3.BackColor = Color.Teal

        SubMernuC.Visible = False
        SubMernuV.Visible = False
        AbrirFormularioContenedor(New Menu_Configuracion())

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button1.BackColor = Color.Teal

        SubMernuV.Visible = False

        ' Verifica si ya se muestra pnopciones en Pn_Contenedor
        If Not Pn_Contenedor.Controls.Contains(SubMernuC) Then
            ' Si no se muestra, carga pnopciones
            Pn_Contenedor.Controls.Add(SubMernuC)
        End If
        ' Lleva pnopciones al frente
        SubMernuC.BringToFront()
        ' Hazlo visible
        SubMernuC.Visible = True
        ' Cambia el fondo de Button1 (si es necesario)
        Button3.BackColor = Color.Black
    End Sub

    Private Sub btn_Ventas_Click(sender As Object, e As EventArgs) 

        Button1.BackColor = Color.Teal
        Button3.BackColor = Color.Teal

        SubMernuC.Visible = False
        SubMernuV.Visible = False
    End Sub

    Private Sub ModoAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SubMernuV.Visible = False
        SubMernuC.Visible = False
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pn_Submenu_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AbrirFormularioContenedor(New FrmVentas())

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AbrirFormularioContenedor(New FrmCompra())

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        SubMernuC.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SubMernuV.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AbrirFormularioContenedor(New Listadocompra())
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AbrirFormularioContenedor(New ListadoVentas())
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AbrirFormularioContenedor(New FrmCorreo())
    End Sub
End Class