Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub btnResultados_Click(sender As Object, e As EventArgs) Handles btnResultados.Click
        'Gustavo Alonso Gutierrez'


    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        'Gustavo Alonso Gutierrez'


        Dim edad As Integer = nudEdad.Value
        Dim nombre As String = txtNombre.Text
        Dim salarioSemanal As Double = CDbl(txtSueldo.Text)
        Dim salarioFinal As Double = salarioSemanal


        Dim categoria1 As Object = cmbCategoria.SelectedItem.ToString() = "Categoria1"
        Dim categoria2 As Object = cmbCategoria.SelectedItem.ToString() = "Categoria2"
        Dim categoria3 As Object = cmbCategoria.SelectedItem.ToString() = "Categoria3"
        Dim categoria4 As Object = cmbCategoria.SelectedItem.ToString() = "Categoria4"

        If categoria1 IsNot Nothing Then
            salarioSemanal = categoria1
            salarioFinal += 120
        ElseIf categoria2 IsNot Nothing Then
            salarioSemanal = categoria2
            salarioFinal += 90
        ElseIf categoria3 IsNot Nothing Then
            salarioSemanal = categoria3
            salarioFinal += 50
        ElseIf categoria2 IsNot Nothing Then
            salarioSemanal = categoria4
            salarioFinal += 20
        End If


        lstDatos.Items.Add("Nombre: " & nombre & "Edad: " & edad & "Categoria: " & salarioFinal)

    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Gustavo Alonso Gutierrez'
        Dim respuesta As Byte

        respuesta = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.YesNo, "Advertencia")

        If respuesta = 6 Then
            Me.Close()

        End If

    End Sub
End Class