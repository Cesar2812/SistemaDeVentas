Imports LogicaNegocio

Public Class FormTelefonos
    Private cliente As New ServiciosClientes()
    'Private _codCliente As String
    'Private _cantidadNumeros As Integer
    Dim frmCliente As New FrmCliente()

    Private _cantidadNumeros As Integer
    Private _codigo As List(Of String)
    Private _telefonos As List(Of String)
    Private _companias As List(Of String)


    'Dim numeros As New List(Of String)
    'Dim operadores As New List(Of String)
    Public Sub New(cantidadNumeros As Integer, codigo As List(Of String), telefonos As List(Of String), companias As List(Of String))
        InitializeComponent()
        '_codCliente = codCliente

        _cantidadNumeros = cantidadNumeros
        _telefonos = telefonos
        _companias = companias
        _codigo = codigo

        For Each control As Control In Me.Controls
            If control.Name.StartsWith("TxtNumero") OrElse control.Name.StartsWith("CmbOperador") Then
                Me.Controls.Remove(control)
            End If
        Next
        Dim centerX As Integer = Me.ClientSize.Width / 2

        ' Crear dinámicamente los TextBoxes y ComboBoxes para ingresar números
        For i As Integer = 1 To cantidadNumeros
            Dim nuevoTextBox As New TextBox()
            nuevoTextBox.Name = "TxtNumero" & i
            nuevoTextBox.Location = New Point(50, 30 + (i - 1) * 30)
            nuevoTextBox.Size = New Size(200, 20)
            Me.Controls.Add(nuevoTextBox)

            Dim nuevoComboBox As New ComboBox()
            nuevoComboBox.Name = "CmbCompania" & i
            nuevoComboBox.Location = New Point(300, 30 + (i - 1) * 30)
            nuevoComboBox.Size = New Size(150, 20)

            ' Agregar la opción "Seleccione una opción" al ComboBox
            nuevoComboBox.Items.Add("Seleccione una opción")

            ' Agregar las compañías al ComboBox
            nuevoComboBox.Items.Add("Tigo")
            nuevoComboBox.Items.Add("Claro")

            ' Establecer "Seleccione una opción" como el elemento seleccionado por defecto
            nuevoComboBox.SelectedIndex = 0

            Me.Controls.Add(nuevoComboBox)



            ' Crear un Label para mostrar el código generado
            Dim nuevoLabel As New Label()
            nuevoLabel.Name = "LblCodigo" & i
            nuevoLabel.Location = New Point(470, 30 + (i - 1) * 30) ' Ajusta la posición según tus necesidades
            nuevoLabel.Size = New Size(100, 20)

            Dim codigote As String = cliente.CodigoTelefono(i) ' Llamar a la función con el valor de i
            nuevoLabel.Text = codigote
            nuevoLabel.Visible = False
            Me.Controls.Add(nuevoLabel)
        Next
    End Sub

    Private Sub FormTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Nuevo_Medidas_Click(sender As Object, e As EventArgs) Handles Nuevo_Medidas.Click

        Dim camposVacios As Boolean = False

        ' Verificar si hay campos vacíos o ComboBox con "Seleccione una opción" seleccionada antes del bucle
        For i As Integer = 1 To _cantidadNumeros
            Dim nombreTextBox As String = "TxtNumero" & i
            Dim nombreComboBox As String = "CmbCompania" & i

            Dim textBox As TextBox = DirectCast(Me.Controls(nombreTextBox), TextBox)
            Dim comboBox As ComboBox = DirectCast(Me.Controls(nombreComboBox), ComboBox)

            If textBox IsNot Nothing AndAlso comboBox IsNot Nothing Then
                Dim numero As String = textBox.Text
                Dim compania As String = If(comboBox.SelectedItem IsNot Nothing, comboBox.SelectedItem.ToString(), "")

                If String.IsNullOrEmpty(numero) OrElse (String.IsNullOrEmpty(compania) OrElse compania = "Seleccione una opción") Then
                    camposVacios = True ' Hay campos vacíos o "Seleccione una opción" seleccionada
                    Exit For ' Salir del bucle tan pronto como se encuentre un campo vacío o ComboBox con "Seleccione una opción"
                End If
            End If
        Next

        ' Mostrar mensaje de error si hay campos vacíos o ComboBox con "Seleccione una opción" seleccionada
        If camposVacios Then
            MessageBox.Show("Rellene los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim seGuardoExitosamente As Boolean = False

            ' Continuar con el bucle para procesar los datos
            For i As Integer = 1 To _cantidadNumeros
                Dim nombreTextBox As String = "TxtNumero" & i
                Dim nombreComboBox As String = "CmbCompania" & i
                Dim labelbox As String = "LblCodigo" & i


                Dim textBox As TextBox = DirectCast(Me.Controls(nombreTextBox), TextBox)
                Dim comboBox As ComboBox = DirectCast(Me.Controls(nombreComboBox), ComboBox)
                Dim label As Label = DirectCast(Me.Controls(labelbox), Label)


                If textBox IsNot Nothing AndAlso comboBox IsNot Nothing Then
                    Dim numero As String = textBox.Text
                    Dim compania As String = If(comboBox.SelectedItem IsNot Nothing, comboBox.SelectedItem.ToString(), "")
                    Dim codigo As String = label.Text



                    If Not String.IsNullOrEmpty(numero) AndAlso Not String.IsNullOrEmpty(compania) AndAlso compania <> "Seleccione una opción" Then
                        ' Agregar el número y la compañía a las listas
                        _codigo.Add(codigo)
                        _telefonos.Add(numero)
                        _companias.Add(compania)

                        ' Limpiar los campos después de agregarlos
                        textBox.Clear()
                        comboBox.SelectedIndex = -1


                        ' Indicar que se ha guardado al menos un dato
                        seGuardoExitosamente = True
                    End If
                End If
            Next
            frmCliente.SetTelefonosYCompanias(_codigo, _telefonos, _companias)
            ' Cerrar el formulario FrmTelefono si se ha guardado al menos un dato
            If seGuardoExitosamente Then

                Me.Close()
            End If
        End If



    End Sub

End Class