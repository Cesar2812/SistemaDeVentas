Imports LogicaNegocio

Public Class FrmTelefono
    Private telefono As New ServiciosTelefono()

    Private Sub FrmTelefono_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub CargarTelefonosPorCliente(codCliente As String)

        Dim telefonosDataTable As DataTable = telefono.ObtenercelularPorId(codCliente)
        Datos_telefono_dgv.DataSource = telefonosDataTable
    End Sub
    Public Sub Cargar(codCliente As String)
        codCliente = NombreCliente_txt.Text
        Dim telefonosDataTable As DataTable = telefono.ObtenercelularPorId(codCliente)
        Datos_telefono_dgv.DataSource = telefonosDataTable
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Datos_telefono_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos_telefono_dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = Datos_telefono_dgv.Rows(e.RowIndex)

            Cod_telefono_txt.Text = fila.Cells(0).Value.ToString()
            NombreCliente_txt.Text = fila.Cells(1).Value.ToString()
            numero_txt.Text = fila.Cells(2).Value.ToString()
            cmbcompania_cmbx.Text = fila.Cells(3).Value.ToString()

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "Cod_cliente_txt" AndAlso ctrl.Name <> "cliente" Then
                    Dim textBox As TextBox = DirectCast(ctrl, TextBox)
                    textBox.ReadOnly = False
                End If
            Next



        End If
    End Sub

    Private Sub Eliminar_btn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Eliminar_btn_Click_1(sender As Object, e As EventArgs) Handles Eliminar_btn.Click
        Dim codCliente As String = NombreCliente_txt.Text

        telefono.EliminarProveedor(Cod_telefono_txt.Text)
        Cargar(codCliente)
    End Sub

    Private Sub Editar_btn_Click(sender As Object, e As EventArgs) Handles Editar_btn.Click


        If Datos_telefono_dgv.Rows.Count > 0 Then

            Dim respuesta As DialogResult = MessageBox.Show("¿Desea editar el proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.Yes Then
                telefono.EditarProveedor(Cod_telefono_txt.Text, NombreCliente_txt.Text, numero_txt.Text, cmbcompania_cmbx.Text)

                ' Mostrar el mensaje de edición completada
                MessageBox.Show("Edición completada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar los TextBox
                Cod_telefono_txt.Text = ""
                NombreCliente_txt.Text = ""
                numero_txt.Text = ""

                ' Restablecer el ComboBox seleccionando el índice cero (por ejemplo, "Selecciona una opción")
                cmbcompania_cmbx.SelectedIndex = 0
                Dim codCliente As String = NombreCliente_txt.Text
                Cargar(codCliente)

            End If

        Else
            ' El DataGridView está vacío, no se realizará la edición
            MessageBox.Show("El DataGridView está vacío. No se puede realizar la edición del proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class