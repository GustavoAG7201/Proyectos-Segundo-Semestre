Public Class Form1
    'Gustavo Alonso Gutierrez'
    Dim selection As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Gustavo Alonso Gutierrez'

        Dim response As Byte

        response = MsgBox("¿Esta seguro de que quiere salir?", MsgBoxStyle.YesNo, "Aviso")

        If response = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        'Gustavo Alonso Gutierrez'
        rbCentigradosFarenheit.Checked = True


        txtValue.Clear()
        txtValue.Focus()
    End Sub

    Private Sub rbCentigradosFarenheit_CheckedChanged(sender As Object, e As EventArgs) Handles rbCentigradosFarenheit.CheckedChanged
        'Gustavo Alonso Gutierrez'
        selection = 1
    End Sub

    Private Sub rbKilosLibras_CheckedChanged(sender As Object, e As EventArgs) Handles rbKilosLibras.CheckedChanged
        'Gustavo Alonso Gutierrez'
        selection = 2
    End Sub

    Private Sub rbMetrosPies_CheckedChanged(sender As Object, e As EventArgs) Handles rbMetrosPies.CheckedChanged
        'Gustavo Alonso Gutierrez'
        selection = 3
    End Sub

    Private Sub rbMilimetrosOnzas_CheckedChanged(sender As Object, e As EventArgs) Handles rbMilimetrosOnzas.CheckedChanged
        'Gustavo Alonso Gutierrez'
        selection = 4
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Gustavo Alonso Gutierrez'

        Dim value, result As Double

        'txtValue.Text'

        If Double.TryParse(txtValue.Text, value) Then

            Select Case selection
                Case 1
                    result = (value * 1.8 + 32)
                Case 2
                    result = value * 2.20462
                Case 3
                    result = value * 3.38084
                Case 4
                    result = value * 0.033814
                Case Else
                    MessageBox.Show("Seleccione un elemento de conversion", "Aviso", MessageBoxButtons.OK)
                    Return

            End Select

            MessageBox.Show("El resultado es: " & result, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("´Por favor ingrese unicamente valores numericos", "Aviso", MessageBoxButtons.OK)
            txtValue.Clear()
            txtValue.Focus()
        End If
    End Sub

End Class
