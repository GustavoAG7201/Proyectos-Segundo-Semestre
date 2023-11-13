<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nudNumero = New System.Windows.Forms.NumericUpDown()
        Me.btnPositivoNegativo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudNumero2 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMayorIgual = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudNum1 = New System.Windows.Forms.NumericUpDown()
        Me.nudNum2 = New System.Windows.Forms.NumericUpDown()
        Me.btnMultiDivRaiz = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTablaCinco = New System.Windows.Forms.Button()
        Me.lsbTablaMultiplicar = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lsbTablaSeis = New System.Windows.Forms.ListBox()
        Me.btnTablaSeis = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numMenorDiez = New System.Windows.Forms.NumericUpDown()
        Me.btnMenorDiez = New System.Windows.Forms.Button()
        CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNum1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMenorDiez, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudNumero
        '
        Me.nudNumero.Location = New System.Drawing.Point(15, 25)
        Me.nudNumero.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudNumero.Name = "nudNumero"
        Me.nudNumero.Size = New System.Drawing.Size(120, 20)
        Me.nudNumero.TabIndex = 0
        '
        'btnPositivoNegativo
        '
        Me.btnPositivoNegativo.Location = New System.Drawing.Point(15, 51)
        Me.btnPositivoNegativo.Name = "btnPositivoNegativo"
        Me.btnPositivoNegativo.Size = New System.Drawing.Size(75, 23)
        Me.btnPositivoNegativo.TabIndex = 1
        Me.btnPositivoNegativo.Text = "Calcular"
        Me.btnPositivoNegativo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1. Ingresa un numero para determinar si es positivo o negativo"
        '
        'nudNumero2
        '
        Me.nudNumero2.Location = New System.Drawing.Point(20, 106)
        Me.nudNumero2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudNumero2.Name = "nudNumero2"
        Me.nudNumero2.Size = New System.Drawing.Size(120, 20)
        Me.nudNumero2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "6. Ingresa un numero que sea igual o mayor a 10"
        '
        'btnMayorIgual
        '
        Me.btnMayorIgual.Location = New System.Drawing.Point(20, 132)
        Me.btnMayorIgual.Name = "btnMayorIgual"
        Me.btnMayorIgual.Size = New System.Drawing.Size(75, 23)
        Me.btnMayorIgual.TabIndex = 5
        Me.btnMayorIgual.Text = "Calcular"
        Me.btnMayorIgual.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "2. Ingresa dos numeros, se multiplicaran, dividiran y se calculara la raiz cuadra" &
    "da de cada uno"
        '
        'nudNum1
        '
        Me.nudNum1.Location = New System.Drawing.Point(20, 205)
        Me.nudNum1.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudNum1.Name = "nudNum1"
        Me.nudNum1.Size = New System.Drawing.Size(59, 20)
        Me.nudNum1.TabIndex = 7
        '
        'nudNum2
        '
        Me.nudNum2.Location = New System.Drawing.Point(97, 205)
        Me.nudNum2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudNum2.Name = "nudNum2"
        Me.nudNum2.Size = New System.Drawing.Size(52, 20)
        Me.nudNum2.TabIndex = 8
        '
        'btnMultiDivRaiz
        '
        Me.btnMultiDivRaiz.Location = New System.Drawing.Point(20, 231)
        Me.btnMultiDivRaiz.Name = "btnMultiDivRaiz"
        Me.btnMultiDivRaiz.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiDivRaiz.TabIndex = 9
        Me.btnMultiDivRaiz.Text = "Calcular"
        Me.btnMultiDivRaiz.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 33)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "3. Al dar clic en el boton se mostrara la tabla del 5"
        '
        'btnTablaCinco
        '
        Me.btnTablaCinco.Location = New System.Drawing.Point(20, 330)
        Me.btnTablaCinco.Name = "btnTablaCinco"
        Me.btnTablaCinco.Size = New System.Drawing.Size(75, 23)
        Me.btnTablaCinco.TabIndex = 11
        Me.btnTablaCinco.Text = "Calcular"
        Me.btnTablaCinco.UseVisualStyleBackColor = True
        '
        'lsbTablaMultiplicar
        '
        Me.lsbTablaMultiplicar.FormattingEnabled = True
        Me.lsbTablaMultiplicar.Location = New System.Drawing.Point(20, 294)
        Me.lsbTablaMultiplicar.Name = "lsbTablaMultiplicar"
        Me.lsbTablaMultiplicar.Size = New System.Drawing.Size(120, 30)
        Me.lsbTablaMultiplicar.TabIndex = 12
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(20, 393)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(350, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 33)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "3. Al dar clic en el boton se mostrara la tabla del 6"
        '
        'lsbTablaSeis
        '
        Me.lsbTablaSeis.FormattingEnabled = True
        Me.lsbTablaSeis.Location = New System.Drawing.Point(353, 45)
        Me.lsbTablaSeis.Name = "lsbTablaSeis"
        Me.lsbTablaSeis.Size = New System.Drawing.Size(120, 30)
        Me.lsbTablaSeis.TabIndex = 15
        '
        'btnTablaSeis
        '
        Me.btnTablaSeis.Location = New System.Drawing.Point(353, 81)
        Me.btnTablaSeis.Name = "btnTablaSeis"
        Me.btnTablaSeis.Size = New System.Drawing.Size(75, 23)
        Me.btnTablaSeis.TabIndex = 16
        Me.btnTablaSeis.Text = "Calcular"
        Me.btnTablaSeis.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "6. Ingresa un numero que sea igual o menor a 10"
        '
        'numMenorDiez
        '
        Me.numMenorDiez.Location = New System.Drawing.Point(353, 135)
        Me.numMenorDiez.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numMenorDiez.Name = "numMenorDiez"
        Me.numMenorDiez.Size = New System.Drawing.Size(120, 20)
        Me.numMenorDiez.TabIndex = 18
        '
        'btnMenorDiez
        '
        Me.btnMenorDiez.Location = New System.Drawing.Point(353, 164)
        Me.btnMenorDiez.Name = "btnMenorDiez"
        Me.btnMenorDiez.Size = New System.Drawing.Size(75, 23)
        Me.btnMenorDiez.TabIndex = 19
        Me.btnMenorDiez.Text = "Calcular"
        Me.btnMenorDiez.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMenorDiez)
        Me.Controls.Add(Me.numMenorDiez)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnTablaSeis)
        Me.Controls.Add(Me.lsbTablaSeis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lsbTablaMultiplicar)
        Me.Controls.Add(Me.btnTablaCinco)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnMultiDivRaiz)
        Me.Controls.Add(Me.nudNum2)
        Me.Controls.Add(Me.nudNum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMayorIgual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudNumero2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPositivoNegativo)
        Me.Controls.Add(Me.nudNumero)
        Me.Name = "Form1"
        Me.Text = "Repaso"
        CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNum1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNum2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMenorDiez, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudNumero As NumericUpDown
    Friend WithEvents btnPositivoNegativo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nudNumero2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMayorIgual As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents nudNum1 As NumericUpDown
    Friend WithEvents nudNum2 As NumericUpDown
    Friend WithEvents btnMultiDivRaiz As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTablaCinco As Button
    Friend WithEvents lsbTablaMultiplicar As ListBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lsbTablaSeis As ListBox
    Friend WithEvents btnTablaSeis As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents numMenorDiez As NumericUpDown
    Friend WithEvents btnMenorDiez As Button
End Class
