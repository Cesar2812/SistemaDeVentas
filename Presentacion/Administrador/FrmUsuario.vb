Imports LogicaNegocio
Public Class FrmUsuario
    Private datos As New ServiciosDUsuarios()
    Private Sub FrmCrear_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox AndAlso ctrl.Name Then
                Dim textBox As TextBox = DirectCast(ctrl, TextBox)
                textBox.ReadOnly = True
            End If
        Next

        'Mostrartodatabla()
        Roles_cmbx.DataSource = datos.TablaUsuario("SELECT * FROM Rol")
        Roles_cmbx.DisplayMember = "Descripcion"
        Roles_cmbx.ValueMember = "IdRol"


        mostrarcodi()
        Mostrartodatabla()

        Cancelar_btn.Enabled = False
        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Agregar_btn.Enabled = False



    End Sub
    Public Sub Mostrartodatabla()
        Datos_usuarios_dgv.DataSource = datos.TablaUsuario("SELECT * FROM Usuario")
    End Sub

    Private Sub Roles_cmbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Roles_cmbx.SelectedIndexChanged
        If Roles_cmbx.SelectedItem IsNot Nothing Then
            'Dim fila As DataRowView = DirectCast(Roles_cmbx.SelectedItem, DataRowView)
            Dim Idrol As String = Roles_cmbx.SelectedValue.ToString()
            'MessageBox.Show(Idrol)
        End If
    End Sub
    Public Sub mostrarcodi()
        Dim codigo As String = datos.GenerarCodigoUsuario()
        IdUsuario_txt.Clear()
        IdUsuario_txt.Text = codigo
    End Sub

    Private Sub Agregar_btn_Click(sender As Object, e As EventArgs) Handles Agregar_btn.Click
        Try
            If Validar_Campos() = True Then
                Dim codigo As String = IdUsuario_txt.Text
                Dim nombre As String = Nombre_txt.Text
                Dim nombreusuario As String = NombreUsuario_txt.Text
                Dim clave As String = Clave_txt.Text

                Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd")
                datos.InsertarUsuario(codigo, Roles_cmbx.SelectedValue.ToString(), Fecha, nombre, nombreusuario, clave)
                Mostrartodatabla()

                Limpiar()
                mostrarcodi()

                Nombre_txt.ReadOnly = True
                NombreUsuario_txt.ReadOnly = True
                Clave_txt.ReadOnly = True
                Cancelar_btn.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Dim validador As Boolean
    Private Function Validar_Campos() As Boolean
        If String.IsNullOrWhiteSpace(Nombre_txt.Text) Or String.IsNullOrWhiteSpace(IdUsuario_txt.Text) Or String.IsNullOrWhiteSpace(NombreUsuario_txt.Text) Or String.IsNullOrWhiteSpace(Clave_txt.Text) Then
            validador = False
            MessageBox.Show("Rellene los campos antes de realizar una operacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            validador = True
        End If
        Return validador
    End Function

    Private Sub Cancelar_btn_Click(sender As Object, e As EventArgs) Handles Cancelar_btn.Click
        Limpiar()
        Nombre_txt.ReadOnly = True
        NombreUsuario_txt.ReadOnly = True
        Clave_txt.ReadOnly = True

        Cancelar_btn.Enabled = False
        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Agregar_btn.Enabled = False
        Nuevo_btn.Enabled = True
        mostrarcodi()
    End Sub
    Private Sub Limpiar()
        'Codigo_txt.Clear()
        Nombre_txt.Clear()
        NombreUsuario_txt.Clear()
        Clave_txt.Clear()
        Mostrartodatabla()
    End Sub

    Private Sub Editar_btn_Click(sender As Object, e As EventArgs) Handles Editar_btn.Click
        Try
            Dim codigo As String = IdUsuario_txt.Text
            Dim nombre As String = Nombre_txt.Text
            Dim nombreusuario As String = NombreUsuario_txt.Text
            Dim clave As String = Clave_txt.Text
            Dim tiempo As DateTime = DateTime.Now
            Dim fechaformat As String = tiempo.ToString("dd/MM/yyyy")
            If Validar_Campos() = True Then
                datos.EditarUsuario(codigo, Roles_cmbx.SelectedValue.ToString(), fechaformat, nombre, nombreusuario, clave)
                MessageBox.Show("Usuario actualizado con exito", "Proceso culminado existosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Mostrartodatabla()
                Editar_btn.Enabled = False
                Eliminar_btn.Enabled = False
                Agregar_btn.Enabled = False
                mostrarcodi()
            End If
        Catch

        End Try

    End Sub

    Private Sub Nuevo_btn_Click(sender As Object, e As EventArgs) Handles Nuevo_btn.Click
        Editar_btn.Enabled = False
        Agregar_btn.Enabled = True
        Eliminar_btn.Enabled = False
        Cancelar_btn.Enabled = True
        Nuevo_btn.Enabled = False

        Nombre_txt.ReadOnly = False
        NombreUsuario_txt.ReadOnly = False
        Clave_txt.ReadOnly = False
    End Sub

    Private Sub Buscar_txt_TextChanged(sender As Object, e As EventArgs) Handles Buscar_txt.TextChanged

        Dim NombreBuscado As String = Buscar_txt.Text

        If NombreBuscado <> "" Then
            Datos_usuarios_dgv.DataSource = datos.TablaUsuario("SELECT* FROM Usuario WHERE NombreCompleto LIKE '%" + NombreBuscado + "%'")
        Else
            Mostrartodatabla()
        End If
    End Sub

    Private Sub Eliminar_btn_Click(sender As Object, e As EventArgs) Handles Eliminar_btn.Click
        Try


            If Validar_Campos() = True Then
                datos.EliminarUsuario(IdUsuario_txt.Text)
                'MessageBox.Show("Se ha borrado el proveedor", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Mostrartodatabla()
                Editar_btn.Enabled = False
                Eliminar_btn.Enabled = False
                Agregar_btn.Enabled = False
                Limpiar()
                mostrarcodi()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Datos_Usuario_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos_usuarios_dgv.CellContentClick

    End Sub

    Private Sub Datos_usuarios_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos_usuarios_dgv.CellClick
        If e.RowIndex >= 0 Then

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "IdUsuario_txt" Then
                    Dim textBox As TextBox = DirectCast(ctrl, TextBox)
                    textBox.ReadOnly = False
                End If
            Next


            Dim fila As DataGridViewRow = Datos_usuarios_dgv.Rows(e.RowIndex)

            IdUsuario_txt.Text = fila.Cells(0).Value.ToString()
            Roles_cmbx.Text = fila.Cells(1).Value.ToString()

            Nombre_txt.Text = fila.Cells(3).Value.ToString()
            NombreUsuario_txt.Text = fila.Cells(4).Value.ToString()
            Clave_txt.Text = fila.Cells(5).Value.ToString()

            Agregar_btn.Enabled = False
            Nuevo_btn.Enabled = False

            Editar_btn.Enabled = True
            Eliminar_btn.Enabled = True

        End If
    End Sub

    Private Sub Datos_usuarios_dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Datos_usuarios_dgv.CellFormatting
        If e.ColumnIndex = Datos_usuarios_dgv.Columns("Clave").Index AndAlso e.Value IsNot Nothing Then
            e.Value = "***"
        End If
    End Sub

    Private Sub btn_Importar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btn_Exporta_Click(sender As Object, e As EventArgs)
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a Excel?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If Datos_usuarios_dgv.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a Excel.")
            Else
                Dim exportadorExce As New ExportarExcel
                exportadorExce.ExportarDataExcel(Datos_usuarios_dgv)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a pdf?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If Datos_usuarios_dgv.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a PDF.")
            Else
                Dim exportadorPDF As New ExportarpdfUsuario(Datos_usuarios_dgv, Me)
                exportadorPDF.ExportarPDF()
            End If
        End If
    End Sub

    Private Sub btnBuscar_Medidas_Click(sender As Object, e As EventArgs)

    End Sub
End Class