Public Class Form1
    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        'Alonso Gutierrez Gustavo'

        Dim name As String = txtName.Text
        Dim age As Integer = nudAge.Value
        Dim lenguaje As String = txtLenguaje.Text
        Dim califiacion As Integer = 0

        If name = "" Then
            MsgBox("Por favor ingrese su nombre", MsgBoxStyle.Critical, "Aviso")
            Return
        End If


        'Validar que se responda la pregunta 1 y que sea correcta'
        If rbAnswer1.Checked Or rbAnswer2.Checked Or rbAnswer3.Checked Then
            If rbAnswer1.Checked Then
                califiacion += 50
            Else
            End If
        Else
            If rbAnswer1.Checked Or rbAnswer2.Checked Or rbAnswer3.Checked = False Then
                MsgBox("Debe de seleccionar alguna opcion en la pregunta 1", MsgBoxStyle.Critical)
            End If
        End If



        'Validar que se responda la pregunta 2 y que sea correcta'
        If txtLenguaje.Text = "" Then
            MsgBox("Por favor, conteste la pregunta 2", MsgBoxStyle.Critical, "Aviso")
            Return
        End If


        If txtLenguaje.Text = "Visual basic" Or txtLenguaje.Text = "visual basic" Then
            califiacion += 50
        End If

        MsgBox(name & vbCr &
               "Su calficacion es: " & califiacion & vbCr & "Edad: " & age)
    End Sub



End Class
