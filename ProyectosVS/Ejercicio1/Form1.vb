Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Gustavo Alonso Gutierrez'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim message As String = "Soy una variable string"
        MsgBox(message)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim number As Integer = 10.5
        MsgBox(number)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim numberDouble As Double = 10.5
        MsgBox(numberDouble)

    End Sub
End Class
