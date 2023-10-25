Imports LogicaNegocio

Public Class FrmCategorias
    Private datos As New ServiciosCategorias()
    Public Sub Mostrartodatabla()
        Datos_categorias_dgv.DataSource = datos.TablaCategoria("SELECT * FROM Categorias")
        Datos_categorias_dgv.EnableHeadersVisualStyles = False
        Datos_categorias_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo
        Datos_categorias_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Datos_categorias_dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 9, FontStyle.Bold)
        Datos_categorias_dgv.AllowUserToResizeColumns = False

    End Sub
    Private Sub FrmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrarcodi()
        Mostrartodatabla()
        Cod_categoria_txt.ReadOnly = True
        Cancelar_btn.Enabled = False
        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Agregar_btn.Enabled = False
    End Sub
    Public Sub Mostrarcodi()
        Dim codigo As String = datos.GenerarCodigoCategoria()
        Cod_categoria_txt.Clear()
        Cod_categoria_txt.Text = codigo
    End Sub
    Private Sub Datos_categorias_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos_categorias_dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = Datos_categorias_dgv.Rows(e.RowIndex)
            Cod_categoria_txt.Text = fila.Cells(0).Value.ToString()
            Nombre_txt.Text = fila.Cells(1).Value.ToString()

            Nombre_txt.ReadOnly = False
            Agregar_btn.Enabled = False
            Nuevo_btn.Enabled = False

            Editar_btn.Enabled = True
            Eliminar_btn.Enabled = True
            Cancelar_btn.Enabled = True
            Nuevo_btn.Enabled = False

        End If
    End Sub
    Private Sub Agregar_btn_Click(sender As Object, e As EventArgs) Handles Agregar_btn.Click
        Try
            If Validar_Campos() = True Then
                Dim codigo As String = Cod_categoria_txt.Text
                Dim nombre As String = Nombre_txt.Text
                datos.InsertarCategoria(codigo, nombre)
                Mostrartodatabla()
                'Me.ProveedorTableAdapter.Fill(Me.VentasBDDataSet.Proveedor)
                Nombre_txt.ReadOnly = True
                Limpiar()
                Mostrarcodi()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
    Dim validador As Boolean
    Private Function Validar_Campos() As Boolean
        If String.IsNullOrWhiteSpace(Nombre_txt.Text) Then
            validador = False
            MessageBox.Show("Rellene los campos!.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            validador = True
        End If
        Return validador
    End Function

    Private Sub Cancelar_btn_Click(sender As Object, e As EventArgs) Handles Cancelar_btn.Click
        Limpiar()
        Nombre_txt.ReadOnly = True

        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Agregar_btn.Enabled = False
        Cancelar_btn.Enabled = False
        Nuevo_btn.Enabled = True
        Mostrarcodi()
    End Sub
    Private Sub Limpiar()
        Cod_categoria_txt.Clear()
        Nombre_txt.Clear()
        Mostrartodatabla()
        'Me.ProveedorTableAdapter.Fill(Me.VentasBDDataSet.Proveedor)
    End Sub

    Private Sub Editar_btn_Click(sender As Object, e As EventArgs) Handles Editar_btn.Click
        Try
            If Validar_Campos() = True Then
                datos.EditarCategoria(Cod_categoria_txt.Text, Nombre_txt.Text)
                MessageBox.Show("Se ha actualizado con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Mostrartodatabla()
                Cancelar_btn.PerformClick()
                Mostrarcodi()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Nuevo_btn_Click(sender As Object, e As EventArgs) Handles Nuevo_btn.Click


        Nuevo_btn.Enabled = False
        Editar_btn.Enabled = False
        Agregar_btn.Enabled = True
        Eliminar_btn.Enabled = False
        Cancelar_btn.Enabled = True

        Nombre_txt.ReadOnly = False
    End Sub

    Private Sub Buscar_txt_TextChanged(sender As Object, e As EventArgs) Handles Buscar_txt.TextChanged
        Dim NombreBuscado As String = Buscar_txt.Text
        If NombreBuscado <> "" Then
            Datos_categorias_dgv.DataSource = datos.TablaCategoria("SELECT * FROM Categorias WHERE Nombre LIKE '%" + NombreBuscado + "%'")
        Else
            Datos_categorias_dgv.DataSource = datos.TablaCategoria("SELECT * FROM Categorias")
        End If
    End Sub

    Private Sub Eliminar_btn_Click(sender As Object, e As EventArgs) Handles Eliminar_btn.Click
        Try
            If String.IsNullOrWhiteSpace(Cod_categoria_txt.Text) Then
                MessageBox.Show("Elije un dato existente!!!!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                datos.EliminarCategoria(Cod_categoria_txt.Text)
                MessageBox.Show("Se ha borrado la categoria!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Mostrartodatabla()
                'Me.ProveedorTableAdapter.Fill(Me.VentasBDDataSet.Proveedor)
                'Editar_btn.Enabled = False
                'Eliminar_btn.Enabled = False
                'Agregar_btn.Enabled = False
                Cancelar_btn.PerformClick()
                Mostrarcodi()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Exportar_pdf_btn.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a pdf?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If Datos_categorias_dgv.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a PDF.")
            Else
                Dim exportadorPDF As New ExportarpdfCategorias(Datos_categorias_dgv, Me)
                exportadorPDF.ExportarPDF()
            End If
        End If
    End Sub

    Private Sub btn_Exporta_Click(sender As Object, e As EventArgs) Handles btn_Exporta.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a Excel?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If Datos_categorias_dgv.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a Excel.")
            Else
                Dim exportadorExce As New ExportarExcel
                exportadorExce.ExportarDataExcel(Datos_categorias_dgv)
            End If
        End If
    End Sub
End Class