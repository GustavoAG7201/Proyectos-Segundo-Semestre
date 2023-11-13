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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nudNumber = New System.Windows.Forms.NumericUpDown()
        Me.btnCalcularCarros = New System.Windows.Forms.Button()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.rbBase = New System.Windows.Forms.RadioButton()
        Me.rbContrato = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nudNumber
        '
        Me.nudNumber.Location = New System.Drawing.Point(29, 107)
        Me.nudNumber.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumber.Name = "nudNumber"
        Me.nudNumber.Size = New System.Drawing.Size(120, 20)
        Me.nudNumber.TabIndex = 1
        Me.nudNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCalcularCarros
        '
        Me.btnCalcularCarros.Location = New System.Drawing.Point(39, 133)
        Me.btnCalcularCarros.Name = "btnCalcularCarros"
        Me.btnCalcularCarros.Size = New System.Drawing.Size(96, 41)
        Me.btnCalcularCarros.TabIndex = 2
        Me.btnCalcularCarros.Text = "Calcular Carros"
        Me.btnCalcularCarros.UseVisualStyleBackColor = True
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(287, 27)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreEmpleado.TabIndex = 3
        '
        'rbBase
        '
        Me.rbBase.AutoSize = True
        Me.rbBase.Location = New System.Drawing.Point(287, 65)
        Me.rbBase.Name = "rbBase"
        Me.rbBase.Size = New System.Drawing.Size(49, 17)
        Me.rbBase.TabIndex = 4
        Me.rbBase.TabStop = True
        Me.rbBase.Text = "Base"
        Me.rbBase.UseVisualStyleBackColor = True
        '
        'rbContrato
        '
        Me.rbContrato.AutoSize = True
        Me.rbContrato.Location = New System.Drawing.Point(287, 89)
        Me.rbContrato.Name = "rbContrato"
        Me.rbContrato.Size = New System.Drawing.Size(65, 17)
        Me.rbContrato.TabIndex = 5
        Me.rbContrato.TabStop = True
        Me.rbContrato.Text = "Contrato"
        Me.rbContrato.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CalcularSueldo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(287, 112)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(100, 20)
        Me.txtSalario.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.rbContrato)
        Me.Controls.Add(Me.rbBase)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.btnCalcularCarros)
        Me.Controls.Add(Me.nudNumber)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Repaso Unidad 2"
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents nudNumber As NumericUpDown
    Friend WithEvents btnCalcularCarros As Button
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents rbBase As RadioButton
    Friend WithEvents rbContrato As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents txtSalario As TextBox
End Class
