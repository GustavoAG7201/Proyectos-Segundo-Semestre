Public Class Form1
    Private Sub pbSalida_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        'Gustavo Alonso Gutierrez'
        Dim response As Byte

        response = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.YesNo, "Aviso")

        If response = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Gustavo Alonso Gutierrez'

        Dim laps As Integer = 0
        Dim random As Random = New Random
        Dim futureTime As Date
        Do
            laps += 1
            txtN1.Text = random.Next(0, 10)
            txtN2.Text = random.Next(0, 10)
            txtN3.Text = random.Next(0, 10)

            laps += 1
            txtN1.Refresh()
            txtN2.Refresh()
            txtN3.Refresh()



            futureTime = Date.Now.AddMilliseconds(5)
            Do While Date.Now < futureTime


            Loop
        Loop While txtN1.Text <> 7 Or txtN2.Text <> 7 Or txtN3.Text <> 7

        MsgBox("Usted ha ganado en la vuelta " & laps, MsgBoxStyle.OkOnly, "Aviso")



    End Sub
End Class
