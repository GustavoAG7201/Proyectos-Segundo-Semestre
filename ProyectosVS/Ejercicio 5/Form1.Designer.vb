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
        Me.nudNumber = New System.Windows.Forms.NumericUpDown()
        Me.lsbTable = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btn1N = New System.Windows.Forms.Button()
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudNumber
        '
        Me.nudNumber.Location = New System.Drawing.Point(115, 12)
        Me.nudNumber.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNumber.Name = "nudNumber"
        Me.nudNumber.Size = New System.Drawing.Size(120, 20)
        Me.nudNumber.TabIndex = 0
        '
        'lsbTable
        '
        Me.lsbTable.FormattingEnabled = True
        Me.lsbTable.Location = New System.Drawing.Point(104, 38)
        Me.lsbTable.Name = "lsbTable"
        Me.lsbTable.Size = New System.Drawing.Size(143, 95)
        Me.lsbTable.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 237)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 26)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(252, 237)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 26)
        Me.btnClean.TabIndex = 3
        Me.btnClean.Text = "Limpiar"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(57, 153)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 26)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calcular"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(208, 153)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(75, 26)
        Me.btnRandom.TabIndex = 5
        Me.btnRandom.Text = "Random"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'btn1N
        '
        Me.btn1N.Location = New System.Drawing.Point(135, 185)
        Me.btn1N.Name = "btn1N"
        Me.btn1N.Size = New System.Drawing.Size(75, 26)
        Me.btn1N.TabIndex = 6
        Me.btn1N.Text = "1 a n"
        Me.btn1N.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(339, 275)
        Me.Controls.Add(Me.btn1N)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lsbTable)
        Me.Controls.Add(Me.nudNumber)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 5 Tablas"
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nudNumber As NumericUpDown
    Friend WithEvents lsbTable As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClean As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnRandom As Button
    Friend WithEvents btn1N As Button
End Class
