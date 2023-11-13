Imports System.Security.Policy

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Alonso Gutierrez Gustavo'
    End Sub

    Private Sub btnSquareArea_Click(sender As Object, e As EventArgs) Handles btnSquareArea.Click
        Dim side As Integer = CInt(Val(txtSideSquare.Text))

        If side = 0 Then
            MsgBox("No se puede obtener el area de un lado con valor a 0", MsgBoxStyle.Critical, "Aviso")
            Return
        End If

        Dim result As Integer = side * side

        MsgBox("El area del cuadrado es: " & result)

        'Alonso Gutierrez Gustavo '

    End Sub

    Private Sub btnCleanSide_Click(sender As Object, e As EventArgs) Handles btnCleanSide.Click

        txtSideSquare.Clear()
        txtSideSquare.Focus()

        'Alonso Gutierrez Gustavo'
    End Sub

    Private Sub btnRectangleArea_Click(sender As Object, e As EventArgs) Handles btnRectangleArea.Click
        Dim base As Integer = CInt(Val(txtBaseRectangle.Text))
        Dim height As Integer = CInt(Val(txtHeightRectangle.Text))

        If base And height = 0 Then
            MsgBox("No se puede obtener el area con un valor 0", MsgBoxStyle.Critical, "Aviso")

        End If

        Dim rectangleArea As Integer = base * height
        MsgBox("El area del rectangulo es: " & rectangleArea)

        'Alonso Gutierrez Gustavo'
    End Sub

    Private Sub btnClearRectangle_Click(sender As Object, e As EventArgs) Handles btnClearTriangle.Click

        txtBaseRectangle.Clear()
        txtHeightRectangle.Clear()
        txtBaseRectangle.Focus()

        'Alonso Gutierrez Gustavo'
    End Sub

    Private Sub txtAreaTriangle_Click(sender As Object, e As EventArgs) Handles txtAreaTriangle.Click
        Dim base As Integer = CInt(Val(txtBaseTriangle.Text))
        Dim height As Integer = CInt(Val(txtHeightTriangle.Text))

        If base And height = 0 Then
            MsgBox("No se puede obtener el area con un valor 0", MsgBoxStyle.Critical, "Aviso")

        End If

        Dim triangleArea As Integer = base * height
        MsgBox("El area del triangulo es: " & triangleArea)

        'Gustavo Alonso Gutierrez'
    End Sub
    Private Sub btnClearTriangle_Click(sender As Object, e As EventArgs) Handles btnClearTriangle.Click

        txtBaseTriangle.Clear()
        txtHeightTriangle.Clear()
        txtBaseTriangle.Focus()

        'Alonso Gutierrez Gustavo'
    End Sub

    Private Sub btnCircleArea_Click(sender As Object, e As EventArgs) Handles btnCircleArea.Click
        Dim radio As Double = CDbl(Val(txtRadio.Text))

        If radio = 0 Then
            MsgBox("No se puede obtener el area de un radio con valor a 0", MsgBoxStyle.Critical, "Aviso")
            Return
        End If

        Dim result As Double = System.Math.PI * System.Math.Pow(radio, 2)

        MsgBox("El area del circulo es " & result)

        'Alonso Gutierrez Gustavo'

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

        'Alonso Gutierrez Gustavo'
    End Sub
End Class
