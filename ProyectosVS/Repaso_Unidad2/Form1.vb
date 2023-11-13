Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Gustavo Alonso Gutierrez'
        Dim a As Integer = 5
        Dim b As Integer = 10

        a = b
        b = a - 5

        MsgBox("El valor es: " & a)
        MsgBox("El valor es: " & b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCalcularCarros.Click
        'Gustavo Alonso Gutierrez'

        Dim numCar = nudNumber.Value
        Dim contador As Integer = 0

        While contador < numCar
            contador += 1
            MsgBox("El total de carros es: " & contador, MsgBoxStyle.Information)
        End While


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Gustavo Alonso Gutierrez'

        Dim nombre As String = txtNombreEmpleado.Text
        Dim salario As String = txtSalario.Text

        If Double.TryParse(txtSalario.Text, salario) Then
        Else
            MsgBox("Ingrese unicamente valores numericos")
        End If

    End Sub
End Class
