Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gustavo Alonso Gutierrez'
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        'Gustavo Alonso Gutierrez'
        Dim nombre_producto As String
        Dim precio_producto As Integer
        Dim subTotal As Integer
        Dim total As Integer
        Dim IVA As Integer
        Dim cantidad_productos As Integer = 0

        Do

            If Integer.TryParse(InputBox("Escriba la cantidad de productos que desea comprar"), cantidad_productos) Then

                For x = 1 To cantidad_productos

                    nombre_producto = InputBox("Escriba el nombre del producto")

                    precio_producto = InputBox("Ingrese el precio del producto", 0)

                    subTotal += precio_producto

                    lbProductList.Items.Add(nombre_producto & " - $" & precio_producto)
                Next

                IVA = subTotal * 0.16
                total = subTotal + IVA

                MsgBox("Subtotal " & subTotal & vbCr &
                       "Iva " & IVA & vbCr &
                       "Total " & total)

            Else
                MsgBox("Por favor, ingrese valores numericos", MsgBoxStyle.Critical, "Aviso")
            End If

        Loop While cantidad_productos = 0

    End Sub
End Class
