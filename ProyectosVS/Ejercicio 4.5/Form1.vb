Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Gustavo Alonso Gutierrez'
        Me.Close()
    End Sub

    Private Sub btnNumMayor_Click(sender As Object, e As EventArgs) Handles btnNumMayor.Click
        'Gustavo Alonso Gutierrez'

        Dim valor1 As Integer = nudNumber1.Value
        Dim valor2 As Integer = nudNumber2.Value

        Dim numeroMayor As Integer = Math.Max(valor1, valor2)

        MsgBox("El numero mayor es: " & numeroMayor, MsgBoxStyle.Information, "Aviso")

    End Sub

    Private Sub btnNumMenor_Click(sender As Object, e As EventArgs) Handles btnNumMenor.Click
        'Gustavo Alonso Gutierrez'

        Dim valor1 As Integer = nudNumber1.Value
        Dim valor2 As Integer = nudNumber2.Value

        Dim numeroMenor As Integer = Math.Min(valor1, valor2)

        MsgBox("El numero menor es: " & numeroMenor, MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        'Gustavo Alonso Gutierrez'

        Dim edad As Integer = 19

        Select Case edad

            Case edad = 10 To 20
                MsgBox("Tu edad esta entre 10 y 20", MsgBoxStyle.Information, "Aviso")
            Case edad = 21 To 30
                MsgBox("Tu edad esta entre 21 y 30", MsgBoxStyle.Information, "Aviso")
        End Select
    End Sub
End Class
