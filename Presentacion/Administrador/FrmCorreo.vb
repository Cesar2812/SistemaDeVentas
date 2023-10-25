Public Class FrmCorreo
    Private Sub Adjuntar_btn_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Emisortxt.Text = "credifastnic2022@gmail.com"
        Passwordtxt.Text = "twsevjojgzvfyocb"
    End Sub

    Private Sub btn_Verfactura_Click(sender As Object, e As EventArgs) Handles btn_Verfactura.Click ' Crear una instancia de la clase Correo
        Dim correoInstancia As New Correo()
        ' Llamar al método EnviarCorreo en la instancia
        correoInstancia.EnviarCorreo(Emisortxt.Text, Passwordtxt.Text, Mensajetxt.Text, Asuntotxt.Text, Receptortxt.Text, RutaArctxt.Text)

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "Emisortxt" AndAlso ctrl.Name <> "Passwordtxt" Then
                DirectCast(ctrl, TextBox).Clear()
            End If
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Muestra el cuadro de diálogo para abrir un archivo
            Me.OpenFileDialog1.ShowDialog()

            ' Verifica si se seleccionó un archivo (el nombre del archivo no está vacío)
            If Not Me.OpenFileDialog1.FileName.Equals("") Then
                ' Asigna la ruta del archivo seleccionado al cuadro de texto RutaArc_txt
                RutaArctxt.Text = Me.OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            ' Muestra un mensaje de error en caso de excepción y muestra detalles de la excepción
            MessageBox.Show("Error al cargar la ruta del archivo: " & ex.ToString())
        End Try
    End Sub
End Class