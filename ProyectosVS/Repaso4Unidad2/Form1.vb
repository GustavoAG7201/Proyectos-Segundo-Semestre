Public Class Form1
    Private Sub btnPositivoNegativo_Click(sender As Object, e As EventArgs) Handles btnPositivoNegativo.Click
        'Gustavo Alonso Gutierrez'
        'Punto 1'
        Dim numero As Integer = nudNumero.Value

        If numero >= 0 Then
            MsgBox("El numero que ingresaste es positivo", MsgBoxStyle.Information)
        ElseIf numero < 0 Then
            MsgBox("El numero que ingresaste es negativo", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnMayorIgual_Click(sender As Object, e As EventArgs) Handles btnMayorIgual.Click
        'Gustavo Alonso Gutierrez'
        'Punto 6'

        Dim numero As Integer = nudNumero2.Value

        Do
            If numero >= 10 Then
                MsgBox("El numero que ingresaste es mayor o es igual a 10", MsgBoxStyle.Information, "Aviso")

            ElseIf numero < 10 Then
                MsgBox("El numero que ingresaste no cumple con la condicion", MsgBoxStyle.Information, "Aviso")

            End If

        Loop Until True


    End Sub

    Private Sub btnMultiDivRaiz_Click(sender As Object, e As EventArgs) Handles btnMultiDivRaiz.Click
        'Alonso Gutierrez Gustavo'
        'Punto 2'

        Dim num1 As Integer = nudNum1.Value
        Dim num2 As Integer = nudNum2.Value
        Dim multiplicacion As Integer
        Dim division As Integer
        Dim resultadoRaiz1 = Math.Sqrt(num1)
        Dim resultadoRaiz2 = Math.Sqrt(num2)



        multiplicacion = num1 * num2
        MsgBox("El resultado de la multiplicacion fue: " & multiplicacion, MsgBoxStyle.Information, "Aviso")

        division = num1 / num2
        MsgBox("El resultado de la division fue: " & division, MsgBoxStyle.Information, "Aviso")

        MsgBox("El resultado de la primer raiz fue fue: " & resultadoRaiz1, MsgBoxStyle.Information, "Aviso")

        MsgBox("El resultado de la segunda raiz fue: " & resultadoRaiz2, MsgBoxStyle.Information, "Aviso")



    End Sub

    Private Sub btnTablaCinco_Click(sender As Object, e As EventArgs) Handles btnTablaCinco.Click
        'Gustavo Alonso Gutierrez'
        'Punto 3'

        lsbTablaMultiplicar.Items.Clear()

        For x As Integer = 1 To 10
            Dim resultado As Integer = 5 * x
            lsbTablaMultiplicar.Items.Add("5 x " & x & " = " & resultado)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Gustavo Alonso Gutierrez'
        'Punto 4'

        Dim respuesta As Byte

        respuesta = MsgBox("¿Estas seguro que quieres salir?", MsgBoxStyle.YesNo, "Advertencia")

        If respuesta = 6 Then
            Me.Close()
        End If


    End Sub

    Private Sub btnTablaSeis_Click(sender As Object, e As EventArgs) Handles btnTablaSeis.Click
        'Alonso Gutierrez Gustavo'
        'Punto 6'

        Dim x As Integer = 1
        lsbTablaSeis.Items.Clear()

        While x <= 10
            Dim resultado As Integer = 6 * x
            lsbTablaSeis.Items.Add("6 x " & x & " = " & resultado)
            x += 1
        End While
    End Sub

    Private Sub btnMenorDiez_Click(sender As Object, e As EventArgs) Handles btnMenorDiez.Click
        'Gustavo Alonso Gutierrez'
        'Punto 7 Do loop until'

        Dim x As Integer = 1

        Do
            MsgBox("El numero que ingresaste es menor a 10! " & x, MsgBoxStyle.Information, "Aviso")
            x += 1

        Loop Until x <= 10

    End Sub
End Class
