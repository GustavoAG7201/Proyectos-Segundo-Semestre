Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim num1, num2, result As Integer
        'GUSTAVO ALONSO GUTIERREZ'
        num1 = CInt(txtNum1.Text)
        num2 = CInt(txtNum2.Text)


        If txtNum1.Text = "" Then
            MsgBox("Por favor, ingresa un numero", MsgBoxStyle.Critical, "ERROR")

            Return

        End If

        If txtNum2.Text = "" Then
            MsgBox("Por favor, ingresa un numero", MsgBoxStyle.Critical, "ERROR")
            Return
        End If

        result = num1 * num2
        If result = 10 Then
            MsgBox("El resultado es 10")
        ElseIf result = 20 Then
            MsgBox("El resultado es 20")
        ElseIf result = 30 Then
            MsgBox("El resultado es 30")
        Else
            MsgBox("La respuesta no entra dentro del rango")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNum1.Clear()
        txtNum2.Clear()

    End Sub
End Class

