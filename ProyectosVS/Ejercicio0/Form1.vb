Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox("Hola Mundo")




    End Sub

    'Boton "MOSTRAR"'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("Hola Mundo")
        'Gustavo Alonso Gutierrez'
        MsgBox("Esta es una pregunta", MsgBoxStyle.Question)
        MsgBox("Este es un mensaje de informacion", MsgBoxStyle.Information)
        MsgBox("Este es un mensaje critico", MsgBoxStyle.Critical)
        MsgBox("Este es un mensaje de ayuda", MsgBoxStyle.MsgBoxHelp)
        MsgBox("Este es un mensaje de exclamacion", MsgBoxStyle.Exclamation)



    End Sub
End Class

