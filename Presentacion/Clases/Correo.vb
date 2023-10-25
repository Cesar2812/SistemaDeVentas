Imports System.Net
Imports System.Net.Mail


Public Class Correo

    Private correos As New MailMessage()
    Private envios As New SmtpClient()

    Public Sub EnviarCorreo(emisor As String, password As String, mensaje As String, asunto As String, destinatario As String, ruta As String)
        Try
            correos.[To].Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.[To].Add(destinatario.Trim())

            If Not ruta.Equals("") Then
                Dim arc As New System.Net.Mail.Attachment(ruta)
                correos.Attachments.Add(arc)
            End If
            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            ' DATOS IMPORTANTES NO MODIFICABLES PARA ACCEDER A LAS CUENTAS
            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)

            MessageBox.Show("El mensaje fue enviado correctamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajería", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class