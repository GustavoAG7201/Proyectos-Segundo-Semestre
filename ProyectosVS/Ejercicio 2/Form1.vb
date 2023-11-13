Public Class Form1

    Dim moduleVariable As String = "10.55"
    Public globalVariable As String = "Gustavo Alonso Gutierrez"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'GUSTAVO ALONSO GUTIERREZ'
        Dim variableString As String = "1"
        MsgBox(CBool(variableString))

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'GUSTAVO ALONSO GUTIERREZ'
        MsgBox(moduleVariable)


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'GUSTAVO ALONSO GUTIERREZ'
        Dim variableDouble As Double = 9.59
        MsgBox(CInt(variableDouble))


    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'GUSTAVO ALONSO GUTIERREZ'
        Dim variableInteger As Integer = 9.59
        MsgBox(CStr(variableInteger))

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
