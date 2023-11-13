Public Class Form1
    'Gustavo Alonso Gutierrez'
    Dim operation As String
    Dim valueResult As Nullable(Of Double) = Nothing
    Dim valueNumeric As Nullable(Of Double) = Nothing
    Dim pressOperator As Boolean



    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "1"
        'Gustavo Alonso Gutierrez'
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "2"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "3"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "4"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "5"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "6"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "7"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "8"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "9"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        evualuatesConstrainsToConcatenate()
        txtResult.Text &= "0"
        'Gustavo Alonso Gutierrez'

    End Sub


    Private Sub btnComma_Click(sender As Object, e As EventArgs) Handles btnComma.Click
        evualuatesConstrainsToConcatenate()
        If InStr(txtResult.Text, ",", CompareMethod.Text) = 0 Then
            txtResult.Text &= ","
        End If
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        evaluateDoOperation()
        operation = "+"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        evaluateDoOperation()
        operation = "-"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnMultiplicaction_Click(sender As Object, e As EventArgs) Handles btnMultiplicaction.Click
        evaluateDoOperation()
        operation = "x"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        evaluateDoOperation()
        operation = "÷"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnPercentage_Click(sender As Object, e As EventArgs) Handles btnPercentage.Click
        evaluateDoOperation()
        operation = "%"
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnRoot_Click(sender As Object, e As EventArgs) Handles btnRoot.Click
        evaluateDoOperation()
        operation = "√"
        If txtResult.Text = "0" Then
            MsgBox("No se puede sacar raiz del 0", MsgBoxStyle.Critical, "ERROR")
            Return
        End If
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        evaluateDoOperation()
        operation = ""
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        txtResult.Clear()
        valueNumeric = Nothing
        valueResult = Nothing
        'Gustavo Alonso Gutierrez'

    End Sub

    Public Sub evaluateDoOperation()
        pressOperator = True

        If txtResult.Text = "" Then
            MsgBox("Ingresa un valor numerico", MsgBoxStyle.Critical, "ERROR")
        End If


        valueNumeric = Val(txtResult.Text)
        If valueResult Then
            Select Case operation
                Case "+"
                    valueResult = valueResult + valueNumeric
                Case "-"
                    valueResult -= valueNumeric
                Case "x"
                    valueResult *= valueNumeric
                Case "÷"
                    valueResult /= valueNumeric
                Case "√"
                    valueResult = Math.Sqrt(valueResult)
                Case "%"
                    valueResult = (valueResult * valueNumeric) / 100
            End Select
            txtResult.Text = valueResult
        Else
            valueResult = valueNumeric
        End If
        'Gustavo Alonso Gutierrez'

    End Sub

    Public Sub evualuatesConstrainsToConcatenate()
        If pressOperator = True Then
            txtResult.Text = ""
            pressOperator = False
        ElseIf txtResult.Text = "0" Then
            txtResult.Text = ""
        End If
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Gustavo Alonso Gutierrez'

    End Sub

    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged
        'Gustavo Alonso Gutierrez'

    End Sub
End Class
