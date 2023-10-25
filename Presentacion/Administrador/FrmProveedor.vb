
Imports LogicaNegocio

Public Class FrmProveedor
    Private datos As New ServiciosProveedor()
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VentasBDDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        'Me.ProveedorTableAdapter.Fill(Me.VentasBDDataSet.Proveedor)
        mostrarcodi()
        Mostrartodatabla()

        Cancelar_btn.Enabled = False
        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Agregar_btn.Enabled = False
    End Sub
    Public Sub mostrarcodi()
        Dim codigo As String = datos.GenerarCodigoProveedor()
        Codigo_txt.Clear()
        Codigo_txt.Text = codigo
    End Sub
    Public Sub Mostrartodatabla()
        Datos_proveedor_dgv.DataSource = datos.TablaProveedor("SELECT * FROM Proveedor")
    End Sub


    Private Sub Agregar_btn_Click(sender As Object, e As EventArgs) Handles Agregar_btn.Click
        Try
            If Validar_Campos() = True Then
                Dim codigo As String = Codigo_txt.Text
                Dim nombre As String = Nombre_txt.Text
                Dim ruc As String = Ruc_txt.Text
                Dim direccion As String = Direccion_txt.Text
                Dim telefono As String = Telefono_txt.Text
                Dim pagina As String = Pagina_txt.Text
                Dim estado As String = "Activo"

                datos.InsertarNuevoPropietario(nombre, ruc, direccion, telefono, pagina, estado)
                Mostrartodatabla()

                Limpiar()
                mostrarcodi()

                Nombre_txt.ReadOnly = True
                Ruc_txt.ReadOnly = True
                Direccion_txt.ReadOnly = True
                Telefono_txt.ReadOnly = True
                Pagina_txt.ReadOnly = True
                Cancelar_btn.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Dim validador As Boolean
    Private Function Validar_Campos() As Boolean
        If String.IsNullOrWhiteSpace(Nombre_txt.Text) Or String.IsNullOrWhiteSpace(Ruc_txt.Text) Or String.IsNullOrWhiteSpace(Direccion_txt.Text) Or String.IsNullOrWhiteSpace(Telefono_txt.Text) Or String.IsNullOrWhiteSpace(Pagina_txt.Text) Then
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
        Ruc_txt.ReadOnly = True
        Direccion_txt.ReadOnly = True
        Telefono_txt.ReadOnly = True
        Pagina_txt.ReadOnly = True

        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Agregar_btn.Enabled = False
        Nuevo_btn.Enabled = True
        Cancelar_btn.Enabled = False
        mostrarcodi()
    End Sub
    Private Sub Limpiar()
        'Codigo_txt.Clear()
        Nombre_txt.Clear()
        Ruc_txt.Clear()
        Direccion_txt.Clear()
        Telefono_txt.Clear()
        Pagina_txt.Clear()
        Mostrartodatabla()
    End Sub

    Private Sub Editar_btn_Click(sender As Object, e As EventArgs) Handles Editar_btn.Click
        Try
            If Validar_Campos() = True Then
                datos.EditarProveedor(Codigo_txt.Text, Nombre_txt.Text, Ruc_txt.Text, Direccion_txt.Text, Telefono_txt.Text, Pagina_txt.Text)
                MessageBox.Show("Proveedor actualizado con exito", "Proceso culminado existosamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Mostrartodatabla()
                'Editar_btn.Enabled = False
                'Eliminar_btn.Enabled = False
                'Agregar_btn.Enabled = False
                Cancelar_btn.PerformClick()
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
        Ruc_txt.ReadOnly = False
        Direccion_txt.ReadOnly = False
        Telefono_txt.ReadOnly = False
        Pagina_txt.ReadOnly = False
    End Sub

    Private Sub Buscar_txt_TextChanged(sender As Object, e As EventArgs) Handles Buscar_txt.TextChanged

        Dim NombreBuscado As String = Buscar_txt.Text
        If Datos_proveedor_dgv.Rows.Count > 0 Then
            ' Verificar si el TextBox no está vacío después de eliminar espacios en blanco
            Dim textoBuscado As String = NombreBuscado.Trim()
            If textoBuscado <> "" Then
                ' Realizar la búsqueda y mostrar los resultados
                Dim resultados = datos.TablaProveedor("SELECT * FROM Proveedor WHERE TRIM(Nombre) LIKE '%" + textoBuscado + "%'")
                If resultados.Rows.Count > 0 Then
                    Datos_proveedor_dgv.DataSource = resultados
                Else
                    ' Mostrar un mensaje de error si no se encontraron resultados
                    MessageBox.Show("No se encontraron resultados.", "Error")
                    Buscar_txt.Clear()

                End If
            Else
                ' Mostrar toda la tabla
                Mostrartodatabla()
            End If
        Else
            ' Mostrar un mensaje de error si no hay datos en la tabla
            MessageBox.Show("No hay datos en la tabla.", "Error")
        End If



    End Sub

    Private Sub Eliminar_btn_Click(sender As Object, e As EventArgs) Handles Eliminar_btn.Click
        Try


            If Validar_Campos() = True Then
                datos.EliminarProveedor(Codigo_txt.Text)

                Mostrartodatabla()
                'Editar_btn.Enabled = False
                'Eliminar_btn.Enabled = False
                'Agregar_btn.Enabled = False
                Limpiar()
                mostrarcodi()
                Cancelar_btn.PerformClick()

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Datos_proveedor_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos_proveedor_dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = Datos_proveedor_dgv.Rows(e.RowIndex)

            Codigo_txt.Text = fila.Cells(0).Value.ToString()
            Nombre_txt.Text = fila.Cells(1).Value.ToString()
            Ruc_txt.Text = fila.Cells(2).Value.ToString()
            Direccion_txt.Text = fila.Cells(3).Value.ToString()
            Telefono_txt.Text = fila.Cells(4).Value.ToString()
            Pagina_txt.Text = fila.Cells(5).Value.ToString()

            Agregar_btn.Enabled = False
            Nuevo_btn.Enabled = False

            Editar_btn.Enabled = True
            Eliminar_btn.Enabled = True
            Cancelar_btn.Enabled = True

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Datos_proveedor_dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Datos_proveedor_dgv.CellFormatting
        If e.ColumnIndex = Datos_proveedor_dgv.Columns("Estado").Index Then
            ' Obtén el valor de la celda actual
            Dim cellValue As String = e.Value.ToString()

            If cellValue = "Activo" Then
                e.CellStyle.BackColor = Color.Green
                e.CellStyle.ForeColor = Color.White
            ElseIf cellValue = "No Activo" Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
            End If
        End If
    End Sub

    Private Sub btn_Exporta_Click(sender As Object, e As EventArgs) Handles btn_Exporta.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a Excel?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If Datos_proveedor_dgv.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a Excel.")
            Else
                Dim exportadorExce As New ExportarExcel
                exportadorExce.ExportarDataExcel(Datos_proveedor_dgv)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a pdf?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas  
            If Datos_proveedor_dgv.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a PDF.")
            Else
                Dim exportadorPDF As New ExportarpdfProveedor(Datos_proveedor_dgv, Me)
                exportadorPDF.ExportarPDF()
            End If
        End If
    End Sub
End Class