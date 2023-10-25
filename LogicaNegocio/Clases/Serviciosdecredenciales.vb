Imports AccesoDatos

Public Class Serviciosdecredenciales
    Private credencialesDAO As New Credenciales()

    Public Function VerificarCredenciales(username As String, password As String) As Boolean
        Return credencialesDAO.VerificarCredenciales(username, password)
    End Function

    Public Function ObtenerRol(username As String) As String
        Return credencialesDAO.ObtenerRol(username)
    End Function

    Public Function ObtenerNombre(username As String) As String
        Return credencialesDAO.ObtenerNombrePersona(username)
    End Function

    Public Function ExisteUsuario(username As String) As String
        Return credencialesDAO.ExisteUsuario(username)
    End Function
End Class
