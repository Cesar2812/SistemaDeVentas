
Imports LogicaNegocio

Public Class FrmCliente

    ' Declarar variables globales para almacenar los números de teléfono y compañías
    Dim validador As Boolean
    Private cliente As New ServiciosClientes()
    Private telefono As New ServiciosTelefono()

    Private codigo As New List(Of String)
    Private telefonos As New List(Of String)
    Private companias As New List(Of String)

    Public Sub SetTelefonosYCompanias(codigo As List(Of String), telefonos As List(Of String), companias As List(Of String))
        Me.codigo = codigo
        Me.telefonos = telefonos
        Me.companias = companias
    End Sub



    Public Sub Mostrarcodi()
        Dim codigo As String = cliente.GenerarCodigoCliente()
        Cod_cliente_txt.Clear()
        Cod_cliente_txt.Text = codigo
    End Sub
    Public Sub Mostrartodatabla()
        Datos_cliente_dgv.DataSource = cliente.TablaCliente("SELECT * FROM Cliente")
        Datos_cliente_dgv.EnableHeadersVisualStyles = False
        Datos_cliente_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo
        Datos_cliente_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Datos_cliente_dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Verdana", 9, FontStyle.Bold)
        Datos_cliente_dgv.AllowUserToResizeColumns = False
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Visible = False
        BotonCelular.Visible = False
        panelcelular.Visible = False
        Cod_cliente_txt.ReadOnly = True
        Mostrarcodi()
        Mostrartodatabla()

        Cancelar_btn.Enabled = False
        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Insertar_btn.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cantidadNumeros As Integer
        If Integer.TryParse(Cantidad_txb.Text, cantidadNumeros) Then

            If cantidadNumeros >= 1 AndAlso cantidadNumeros <= 4 Then
                ' Abrir el formulario de teléfonos

                'Dim codCliente As String = Cod_cliente_txt.Text
                Dim formularioTelefonos As New FormTelefonos(cantidadNumeros, codigo, telefonos, companias)
                formularioTelefonos.ShowDialog()

            Else
                MessageBox.Show("Ingrese un valor válido para la cantidad de números (entre 1 y 4).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cantidad_txb.Clear()
            End If
        Else
            MessageBox.Show("Ingrese una cantidad válida de números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Insertar_btn_Click(sender As Object, e As EventArgs) Handles Insertar_btn.Click
        Try
            If String.IsNullOrEmpty(Cod_cliente_txt.Text) OrElse
             String.IsNullOrEmpty(Ruc_txt.Text) OrElse
             String.IsNullOrEmpty(Nombre_txt.Text) OrElse
              String.IsNullOrEmpty(Calle_txt.Text) OrElse
             String.IsNullOrEmpty(Comuna_txt.Text) OrElse
              String.IsNullOrEmpty(Cuidad_txt.Text) Then
                MsgBox("Por favor, complete todos los campos.")
                Return
            End If
            Dim codCliente As String = Cod_cliente_txt.Text
            Dim rucCliente As String = Ruc_txt.Text
            Dim nombreCliente As String = Nombre_txt.Text
            Dim calleCliente As String = Calle_txt.Text
            Dim comunaCliente As String = Comuna_txt.Text
            Dim ciudadCliente As String = Cuidad_txt.Text
            Dim tieneCelular As Boolean

            If rbTieneCelular.Checked Then
                tieneCelular = True
                If codigo.Count = 0 OrElse telefonos.Count = 0 OrElse companias.Count = 0 Then
                    MsgBox("Por favor, complete la información de los numeros de celular y compañía del cliente.")
                    Return
                End If
            ElseIf rbNotieneCelular.Checked Then
                tieneCelular = False

            Else
                MsgBox("Por favor, seleccione si el cliente tiene o no tiene celular.")
                Return
            End If
            cliente.InsertarCliente(codCliente, rucCliente, nombreCliente, calleCliente, comunaCliente, ciudadCliente, codigo, telefonos, companias, tieneCelular)
            panelcelular.Visible = False
            Limpiar()
            telefonos.Clear()
            companias.Clear()
            Cod_cliente_txt.ReadOnly = True
            Mostrarcodi()
            Mostrartodatabla()
            'Cod_cliente_txt.Clear()
            'Ruc_txt.Clear()
            'Nombre_txt.Clear()
            'Calle_txt.Clear()
            'Comuna_txt.Clear()
            'Cuidad_txt.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbTieneCelular_CheckedChanged(sender As Object, e As EventArgs) Handles rbTieneCelular.CheckedChanged
        panelcelular.Visible = True

    End Sub

    Private Sub rbNotieneCelular_CheckedChanged(sender As Object, e As EventArgs) Handles rbNotieneCelular.CheckedChanged
        panelcelular.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a pdf?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If Datos_cliente_dgv.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a PDF.")
            Else
                Dim exportadorPDF As New ExportarpdfCliente(Datos_cliente_dgv, Me)
                exportadorPDF.ExportarPDF()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de exportar los datos a Excel?", "Confirmar Exportación", MessageBoxButtons.YesNo)
        If confirmacion = DialogResult.Yes Then
            ' Verificar si el DataGridView tiene filas
            If Datos_cliente_dgv.Rows.Count = 0 Then
                MessageBox.Show("El DataGridView está vacío. No se puede exportar a Excel.")
            Else
                Dim exportadorExce As New ExportarExcel
                exportadorExce.ExportarDataExcel(Datos_cliente_dgv)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tienecelularStr As String = Datos_cliente_dgv.CurrentRow.Cells("Celular").Value.ToString()

        If tienecelularStr = "Sí" Then
            Dim codclienteStr As String = Datos_cliente_dgv.CurrentRow.Cells(0).Value.ToString()
            Dim formTelefono As New FrmTelefono()
            formTelefono.CargarTelefonosPorCliente(codclienteStr)
            formTelefono.ShowDialog()
        Else
            MessageBox.Show("El cliente no tiene celular.")
        End If
    End Sub

    Private Sub Buscar_Medidas_TextChanged(sender As Object, e As EventArgs) Handles Buscar_Medidas.TextChanged
        Dim NombreBuscado As String = Buscar_Medidas.Text
        If NombreBuscado <> "" Then
            Datos_cliente_dgv.DataSource = cliente.TablaCliente("SELECT* FROM Proveedor WHERE Nombre LIKE '%" + NombreBuscado + "%'")
        Else
            Mostrartodatabla()
        End If
    End Sub

    Private Sub Nuevo_btn_Click(sender As Object, e As EventArgs) Handles Nuevo_btn.Click

        Editar_btn.Enabled = False
        Insertar_btn.Enabled = True
        Eliminar_btn.Enabled = False
        Cancelar_btn.Enabled = True
        Nuevo_btn.Enabled = False

        panelcelular.Visible = False

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "Cod_cliente_txt" Then
                Dim textBox As TextBox = DirectCast(ctrl, TextBox)
                textBox.ReadOnly = False
            End If
        Next
        For Each control As Control In Me.Controls
            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                radioButton.Checked = False
            End If
        Next
    End Sub

    Private Sub Datos_cliente_dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos_cliente_dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = Datos_cliente_dgv.Rows(e.RowIndex)

            Cod_cliente_txt.Text = fila.Cells(0).Value.ToString()
            Ruc_txt.Text = fila.Cells(1).Value.ToString()
            Nombre_txt.Text = fila.Cells(2).Value.ToString()
            Calle_txt.Text = fila.Cells(3).Value.ToString()
            Comuna_txt.Text = fila.Cells(4).Value.ToString()
            Cuidad_txt.Text = fila.Cells(5).Value.ToString()


            Insertar_btn.Enabled = False
            Nuevo_btn.Enabled = False
            Editar_btn.Enabled = True
            Eliminar_btn.Enabled = True
            Cancelar_btn.Enabled = True

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "Cod_cliente_txt" Then
                    Dim textBox As TextBox = DirectCast(ctrl, TextBox)
                    textBox.ReadOnly = False
                End If
            Next
            Dim valorCelular As String = fila.Cells("Celular").Value.ToString() ' Reemplaza "nombreDeTuColumnaDeCelular" por el nombre real de tu columna

            If valorCelular = "Sí" Then
                RadioButton1.Visible = True
                RadioButton1.Checked = True
                ' Marcar el CheckBox si contiene "si"
                BotonCelular.Visible = True ' Habilitar el botón
                rbTieneCelular.Visible = False
            Else
                RadioButton1.Checked = False
                rbTieneCelular.Visible = True
                rbNotieneCelular.Checked = True
                BotonCelular.Visible = False
            End If
        End If
    End Sub
    Public Sub Limpiar()
        'For Each ctrl As Control In Me.Controls
        '    If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "Cod_cliente_txt" Then
        '        DirectCast(ctrl, TextBox).Text = ""
        '    End If
        'Next
        For Each ctrl As Control In panel8.Controls
            If TypeOf ctrl Is TextBox AndAlso ctrl.Name <> "Cod_cliente_txt" Then
                DirectCast(ctrl, TextBox).Text = ""
            End If
        Next

        For Each control As Control In Me.Controls
            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                radioButton.Checked = False
            End If
        Next


    End Sub
    Private Sub Cancelar_btn_Click(sender As Object, e As EventArgs) Handles Cancelar_btn.Click

        Limpiar()
        Editar_btn.Enabled = False
        Eliminar_btn.Enabled = False
        Insertar_btn.Enabled = False
        Cancelar_btn.Enabled = False
        Nuevo_btn.Enabled = True
        Mostrarcodi()

        panelcelular.Visible = False
        RadioButton1.Visible = False
        rbTieneCelular.Visible = True
        rbNotieneCelular.Checked = False
        BotonCelular.Visible = False
    End Sub

    Private Sub panel8_Paint(sender As Object, e As PaintEventArgs) Handles panel8.Paint

    End Sub
    Private Function Validar_Campos() As Boolean
        If String.IsNullOrWhiteSpace(Cod_cliente_txt.Text) Then
            validador = False
            MessageBox.Show("Rellene los campos antes de realizar una operacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            validador = True
        End If
        Return validador
    End Function
    Private Sub Eliminar_btn_Click(sender As Object, e As EventArgs) Handles Eliminar_btn.Click
        Try

            If Validar_Campos() = True Then
                cliente.EliminarCliente(Cod_cliente_txt.Text)
                Mostrartodatabla()
                Cancelar_btn.PerformClick()
                Limpiar()
                Mostrarcodi()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Editar_btn_Click(sender As Object, e As EventArgs) Handles Editar_btn.Click

        Dim codCliente As String = Cod_cliente_txt.Text
        Dim ruc As String = Ruc_txt.Text
        Dim nombre As String = Nombre_txt.Text
        Dim calle As String = Calle_txt.Text
        Dim comuna As String = Comuna_txt.Text
        Dim ciudad As String = Cuidad_txt.Text
        Dim tieneCelular As Boolean

        If rbTieneCelular.Checked Then
            tieneCelular = True
        ElseIf rbNotieneCelular.Checked Then
            tieneCelular = False
        End If
        ' Llama a la función Editar_Cliente
        cliente.EditarCliente(codCliente, ruc, nombre, calle, comuna, ciudad, tieneCelular, telefonos, codigo, companias)

        ' Aquí puedes agregar código adicional, como mostrar un mensaje de éxito.
        MessageBox.Show("Cliente editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        panelcelular.Visible = False
        'Limpiar()
        telefonos.Clear()
        companias.Clear()
        Cod_cliente_txt.ReadOnly = True
        'Mostrarcodi()
        Mostrartodatabla()
        Insertar_btn.PerformClick()
    End Sub

    Private Sub BotonCelular_Click(sender As Object, e As EventArgs) Handles BotonCelular.Click

        Dim codclienteStr As String = Datos_cliente_dgv.CurrentRow.Cells(0).Value.ToString()
        Dim formTelefono As New FrmTelefono()
        formTelefono.CargarTelefonosPorCliente(codclienteStr)
        formTelefono.ShowDialog()
    End Sub
End Class