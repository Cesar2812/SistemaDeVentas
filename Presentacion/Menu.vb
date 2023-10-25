Imports System.Net.Http
Public Class Menu

    Private _nombrePersona As String
    Private _rol As String

    Public Sub New(nombre As String, rol As String)
        InitializeComponent()
        _nombrePersona = nombre
        _rol = rol
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim city As String = Await ObtenerCiudad()
        'labelciudad.Text = city
        lblRol.Text = _rol
        lbUsuario.Text = _nombrePersona
        Funcionesxrol()

    End Sub

    Public Sub Funcionesxrol()




        Select Case _rol
            Case "admin"
                BotonesAdministradorVisible()
            Case "cajero"
                BotonesCajeroVisible()
        End Select
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



    Public Sub BotonesAdministradorVisible()
        pb_Admin.Visible = True
        pb_Cajero.Visible = False
        AbrirFormularioContenedor(New ModoAdmin())

    End Sub

    Public Sub BotonesCajeroVisible()
        pb_Admin.Visible = False
        pb_Cajero.Visible = True
        PictureBox1.Visible = False
        AbrirFormularioContenedor(New ModoCajero())

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult = MessageBox.Show("¿Desea cerrar la sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Código para cerrar la sesión (limpiar credenciales, etc.)
            ' Luego, redirige al formulario de inicio de sesión
            Dim loginForm As New FrmLogin()
            loginForm.Show()
            Me.Close() ' Cierra el formulario actual
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Pn_Contenedor.Paint

    End Sub
End Class