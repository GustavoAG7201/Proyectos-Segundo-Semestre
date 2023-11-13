Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Gustavo Alonso Gutierrez'

        Dim correo As String = txtCorreo.Text
        Dim contraseña As String = txtContraseña.Text



        If correo = "gustavo@correo.com" And contraseña = "alonso" Then
            MsgBox("Los datos que ingresaste se han guardado!", MsgBoxStyle.Information, "Aviso!")
            Form2.Show()
        Else
            MsgBox("Error al verificar los datos!", MsgBoxStyle.Critical, "Advertencia!")
        End If


    End Sub
End Class
