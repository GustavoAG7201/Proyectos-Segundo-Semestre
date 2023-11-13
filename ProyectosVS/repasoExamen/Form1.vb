Public Class Form1
    Private Sub btnNombre_Click(sender As Object, e As EventArgs) Handles btnNombre.Click
        If txtNombre.Text = "" Then
            MsgBox("Por favor, escribe un nombre", MsgBoxStyle.Exclamation, "ERROR")

            Return

        End If

        MsgBox("Hola," & txtNombre.Text, MsgBoxStyle.Information, "Bienvenido")

        lblNombre.Text = txtNombre.Text


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNombre.Clear()

    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click

        Form2.Show()


    End Sub
End Class
