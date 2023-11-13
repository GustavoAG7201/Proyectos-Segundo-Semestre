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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMilimetrosOnzas = New System.Windows.Forms.RadioButton()
        Me.rbMetrosPies = New System.Windows.Forms.RadioButton()
        Me.rbKilosLibras = New System.Windows.Forms.RadioButton()
        Me.rbCentigradosFarenheit = New System.Windows.Forms.RadioButton()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMilimetrosOnzas)
        Me.GroupBox1.Controls.Add(Me.rbMetrosPies)
        Me.GroupBox1.Controls.Add(Me.rbKilosLibras)
        Me.GroupBox1.Controls.Add(Me.rbCentigradosFarenheit)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversiones"
        '
        'rbMilimetrosOnzas
        '
        Me.rbMilimetrosOnzas.AutoSize = True
        Me.rbMilimetrosOnzas.Location = New System.Drawing.Point(3, 80)
        Me.rbMilimetrosOnzas.Name = "rbMilimetrosOnzas"
        Me.rbMilimetrosOnzas.Size = New System.Drawing.Size(113, 17)
        Me.rbMilimetrosOnzas.TabIndex = 3
        Me.rbMilimetrosOnzas.Text = "Milimetros a Onzas"
        Me.rbMilimetrosOnzas.UseVisualStyleBackColor = True
        '
        'rbMetrosPies
        '
        Me.rbMetrosPies.AutoSize = True
        Me.rbMetrosPies.Location = New System.Drawing.Point(3, 57)
        Me.rbMetrosPies.Name = "rbMetrosPies"
        Me.rbMetrosPies.Size = New System.Drawing.Size(89, 17)
        Me.rbMetrosPies.TabIndex = 2
        Me.rbMetrosPies.Text = "Metros a Pies"
        Me.rbMetrosPies.UseVisualStyleBackColor = True
        '
        'rbKilosLibras
        '
        Me.rbKilosLibras.AutoSize = True
        Me.rbKilosLibras.Location = New System.Drawing.Point(3, 39)
        Me.rbKilosLibras.Name = "rbKilosLibras"
        Me.rbKilosLibras.Size = New System.Drawing.Size(116, 17)
        Me.rbKilosLibras.TabIndex = 1
        Me.rbKilosLibras.Text = "Kilogramos a Libras"
        Me.rbKilosLibras.UseVisualStyleBackColor = True
        '
        'rbCentigradosFarenheit
        '
        Me.rbCentigradosFarenheit.AutoSize = True
        Me.rbCentigradosFarenheit.Checked = True
        Me.rbCentigradosFarenheit.Location = New System.Drawing.Point(3, 19)
        Me.rbCentigradosFarenheit.Name = "rbCentigradosFarenheit"
        Me.rbCentigradosFarenheit.Size = New System.Drawing.Size(137, 17)
        Me.rbCentigradosFarenheit.TabIndex = 0
        Me.rbCentigradosFarenheit.TabStop = True
        Me.rbCentigradosFarenheit.Text = "Centigrados a Farenheit"
        Me.rbCentigradosFarenheit.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(35, 23)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(203, 20)
        Me.txtValue.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(97, 221)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calcular"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(35, 250)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 5
        Me.btnClean.Text = "Limpiar"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(163, 250)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(264, 285)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 6 Conversiones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbMilimetrosOnzas As RadioButton
    Friend WithEvents rbMetrosPies As RadioButton
    Friend WithEvents rbKilosLibras As RadioButton
    Friend WithEvents rbCentigradosFarenheit As RadioButton
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClean As Button
    Friend WithEvents btnExit As Button
End Class
