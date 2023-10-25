Imports LogicaNegocio

Public Class ListadoCliente
    Private ventas As New FrmVentas()


    Public Sub New(ByRef formPrincipal As FrmVentas)
        InitializeComponent()
        Me.ventas = formPrincipal
    End Sub
    Private cliente As New ServiciosClientes()
    Public Sub Mostrartodatabla()
        dtg_Clientes.DataSource = cliente.TablaCliente("SELECT Cod_cliente, Nombre FROM Cliente")
    End Sub
    Private Sub ListadoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrartodatabla()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Buscar_txt_TextChanged(sender As Object, e As EventArgs) Handles Buscar_txt.TextChanged

        Dim NombreBuscado As String = Buscar_txt.Text

        If NombreBuscado <> "" Then
            dtg_Clientes.DataSource = cliente.TablaCliente("SELECT Cod_cliente, Nombre FROM Cliente WHERE Nombre LIKE '%" + NombreBuscado + "%'")
        Else
            Mostrartodatabla()
        End If
    End Sub

    Private Sub dtg_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_Clientes.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dtg_Clientes.Columns("Cod_cliente").Index Then
            ' Obtén el valor de la celda clickeada
            Dim valorDato1 As String = dtg_Clientes.Rows(e.RowIndex).Cells("Cod_cliente").Value.ToString()

            ' Llama al método en el FormPrincipal para establecer el valor en el label
            ventas.SetLabelValues(valorDato1)
        End If
    End Sub
End Class