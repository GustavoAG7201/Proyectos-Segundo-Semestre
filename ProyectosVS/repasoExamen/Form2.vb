Public Class Form2

    Dim num1, num2 As Double

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

        num1 = CDbl(txtNum1.Text)
        num2 = CDbl(txtNum2.Text)

        Dim suma As Double = num1 + num2

        MsgBox(suma)



    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        num1 = CDbl(txtNum1.Text)
        num2 = CDbl(txtNum2.Text)

        Dim multiplicacion As Double = num1 * num2
        MsgBox(multiplicacion)


    End Sub

    Private Sub btnMostrarIf_Click(sender As Object, e As EventArgs) Handles btnMostrarIf.Click
        Dim edad As Integer = CInt(txtEdad.Text)

        If edad >= 18 Then
            MsgBox("Ya eres mayor de edad")
        Else
            MsgBox("Aun eres menor de edad, mejor ponte a aprender ingles")

        End If
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        Dim camino As Integer = CInt(txtAyuda.Text)

        If camino = 1 Then
            MsgBox("Peach se salvo")
        Else
            MsgBox("Peach no se salvo")

            Return
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim seleccion As Integer = CInt(txtSeleccion.Text)


        Select Case seleccion
            Case "1"
                MsgBox("Seleccionaste a: Snorlax")
            Case "2"
                MsgBox("Seleccionaste a: Jigglypuff")
            Case "3"
                MsgBox("Seleccionaste a: Squirtle")
            Case "4"
                MsgBox("Seleccionaste a: Charmander")
            Case "5"
                MsgBox("Seleccionaste a: Lugia")
            Case "6"
                MsgBox("Seleccionaste a: Gasly")

            Case Else
                MsgBox("No se encuentra dentro del rango de seleccion", MsgBoxStyle.Critical, "ERROR")


        End Select

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim num1, num2, result As Integer
        num1 = 3
        num2 = 6
        result = num1 + num2
        Select Case result
            Case 1 To 9
                MsgBox("El resultado se encuentra dentro del rando de 1-9")
            Case 10 To 19
                MsgBox("El resultado se encuentra dentro del rango de 10-19")
            Case 20 To 29
                MsgBox("El resultado se encuentra dentro del rango de 20-29")
            Case Else
                MsgBox("El resultado no se encuentra dentro de ningun rango")




        End Select

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class