
Imports System.Data
Imports System.Data.SqlClient
Public Class ConexionSql

    Private conexion As SqlConnection
    Private connectionString As String
    Public Sub New()
        'connectionString = "Data Source=PC-001\MSSQLSERVER01;Initial Catalog=VentasBD; Integrated Security=true"
        connectionString = "Data Source=DESKTOP-VRFB2RU; Initial Catalog=VentasBD; Integrated Security=true"
        'connectionString = "Data Source=DESKTOP-77REPL1;Initial Catalog=VentasBD; Integrated Security=true"
        conexion = New SqlConnection(connectionString)
    End Sub

    Public Function ObtenerConexion() As SqlConnection
        Return conexion
    End Function

    Public Sub AbrirConexion()
        Try
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CerrarConexion()
        Try
            If conexion.State <> ConnectionState.Closed Then
                conexion.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
