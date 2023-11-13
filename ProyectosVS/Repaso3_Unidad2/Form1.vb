Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        'Gustavo Alonso Gutierrez'

        lstNominas.Items.Clear()
        txtNombreEmpleado.Clear()
        txtSalarioSemanal.Clear()
        rbAdmin.Checked = True
        nudAñosLaborados.Value = 1

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'Gustavo Alonso Gutierrez'

        Dim response As Byte

        response = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.YesNo, "Advertencia")

        If response = 6 Then
            Me.Close()

        End If


    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Gustavo Alonso Gutierrez'

        Dim nombreEmpleado As String = txtNombreEmpleado.Text
        Dim tipoEmpleado As String

        Dim sueldoSemanal As Double = Double.Parse(txtSalarioSemanal.Text)
        Dim tieneVacaciones As Boolean = (cmbVacaciones.SelectedItem.ToString() = "Si")
        Dim añosTrabajados As Integer = CInt(nudAñosLaborados.Value)


        If rbOperador.Checked Then
            tipoEmpleado = "Operador"
        ElseIf rbAdmin.Checked Then
            tipoEmpleado = "Administrativo"
        Else
            tipoEmpleado = "No se especifico"
        End If



        Dim sueldoSinVacaciones As Double = sueldoSemanal * 7


        Dim sueldoConVacaciones As Double = sueldoSinVacaciones
        If tieneVacaciones Then
            Dim diasVacacionados As Integer = 12 + (añosTrabajados / 5) * 2
            Dim primaVacacional As Double = sueldoSinVacaciones * 0.25
            sueldoConVacaciones = sueldoSinVacaciones + primaVacacional + (diasVacacionados * sueldoSinVacaciones / 365)
        End If

        Dim item As String = $"Nombre: {nombreEmpleado}" & Environment.NewLine & $"Tipo: {tipoEmpleado}" & Environment.NewLine & $"Vacaciones {tieneVacaciones}" & Environment.NewLine & $"Sueldo sin vacaciones: ${sueldoSinVacaciones}" & Environment.NewLine & $"Sueldo con vacaciones: ${sueldoConVacaciones}"
        lstNominas.Items.Add(item & vbCrLf)
    End Sub

End Class
