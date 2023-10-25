
Imports LogicaNegocio
Public Class FrmLogin
    Dim username As String
    Dim password As String
    Private intentosFallidos As Integer = 0
    Dim servicioCredenciales As New Serviciosdecredenciales()

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Ingresar_btn_Click(sender As Object, e As EventArgs) Handles Ingresar_btn.Click

        username = username_txb.Text
        password = password_txb.Text
        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Por favor, ingresa el nombre de usuario y la contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If servicioCredenciales.ExisteUsuario(username) Then

                If servicioCredenciales.VerificarCredenciales(username, password) Then
                    Dim nombrePersona As String = servicioCredenciales.ObtenerNombre(username)
                    Dim rol As String = servicioCredenciales.ObtenerRol(username)

                    MessageBox.Show($"Usuario: {username}{vbCrLf}Rol: {rol}", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    intentosFallidos = 0
                    Dim menuForm As New Menu(nombrePersona, rol)
                    Me.Hide()
                    menuForm.ShowDialog()
                    Me.Close()
                Else

                    intentosFallidos += 1
                    If intentosFallidos < 3 Then
                        MessageBox.Show($"Credenciales incorrectas. Intento {intentosFallidos} de 3. Intenta de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Has excedido el número máximo de intentos fallidos. Acceso bloqueado.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else

                MessageBox.Show("El nombre de usuario no existe.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If



    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Hora.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub checkBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox2.CheckedChanged
        Dim chk As CheckBox = TryCast(sender, CheckBox)

        If checkBox2.CheckState = CheckState.Checked Then
            chk.Image = My.Resources.ojo
            password_txb.UseSystemPasswordChar = True
        Else
            chk.Image = My.Resources.ojo_1_
            password_txb.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class