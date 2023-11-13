Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'GUSTAVO ALOSNO GUTIERREZ'
        Static staticVariable As String = "Programacion basica"
        MsgBox(staticVariable)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'GUSTAVO ALOSNO GUTIERREZ'
        MsgBox(Form1.globalVariable, MsgBoxStyle.Information, "Nombre")

    End Sub
End Class