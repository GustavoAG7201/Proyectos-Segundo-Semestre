Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Gustavo Alonso Gutierrez'
        Dim respuesta As Byte
        respuesta = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.YesNo, "AVISO")

        If respuesta = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        'Gustavo Alonso Gutierrez Gustavo'
        nudNumber.Value = 0
        nudNumber.Focus()
        lsbTable.Items.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Gustavo Alonso Gutierrez'
        lsbTable.Items.Clear()

        Dim number As Integer = nudNumber.Value

        For x = 1 To 10
            lsbTable.Items.Add(number & "*" & x & "=" & (number * x))
        Next
    End Sub

    Private Sub btnRamdom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        'Gustavo Alonso Gutierrez'

        lsbTable.Items.Clear()
        Dim numRandom As Random = New Random

        Dim number As Integer = numRandom.Next(0, 11)
        For x = 1 To 10
            lsbTable.Items.Add(number & "*" & x & "=" & (number * x))
        Next
    End Sub

    Private Sub btn1N_Click(sender As Object, e As EventArgs) Handles btn1N.Click
        'Gustavo Alonso Gutierrez'

        Dim number As Integer = nudNumber.Value

        If number <= 1 Then
            MsgBox("Por favor ingresa un numero mayor a 1", MsgBoxStyle.Information, "AVISO")
        End If

        For x = 1 To number
            For y = 1 To 10
                lsbTable.Items.Add(x & "*" & y & "=" & (x * y))
            Next

            lsbTable.Items.Add("******")
        Next
    End Sub
End Class


