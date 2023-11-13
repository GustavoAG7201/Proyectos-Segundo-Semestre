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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.nudNumber1 = New System.Windows.Forms.NumericUpDown()
        Me.nudNumber2 = New System.Windows.Forms.NumericUpDown()
        Me.btnNumMayor = New System.Windows.Forms.Button()
        Me.btnNumMenor = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        CType(Me.nudNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumber2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(127, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'nudNumber1
        '
        Me.nudNumber1.Location = New System.Drawing.Point(12, 47)
        Me.nudNumber1.Name = "nudNumber1"
        Me.nudNumber1.Size = New System.Drawing.Size(120, 20)
        Me.nudNumber1.TabIndex = 1
        '
        'nudNumber2
        '
        Me.nudNumber2.Location = New System.Drawing.Point(183, 47)
        Me.nudNumber2.Name = "nudNumber2"
        Me.nudNumber2.Size = New System.Drawing.Size(120, 20)
        Me.nudNumber2.TabIndex = 2
        '
        'btnNumMayor
        '
        Me.btnNumMayor.Location = New System.Drawing.Point(116, 84)
        Me.btnNumMayor.Name = "btnNumMayor"
        Me.btnNumMayor.Size = New System.Drawing.Size(95, 41)
        Me.btnNumMayor.TabIndex = 3
        Me.btnNumMayor.Text = "Calcular Numero Mayor"
        Me.btnNumMayor.UseVisualStyleBackColor = True
        '
        'btnNumMenor
        '
        Me.btnNumMenor.Location = New System.Drawing.Point(116, 131)
        Me.btnNumMenor.Name = "btnNumMenor"
        Me.btnNumMenor.Size = New System.Drawing.Size(95, 41)
        Me.btnNumMenor.TabIndex = 4
        Me.btnNumMenor.Text = "Calcular Numero Menor"
        Me.btnNumMenor.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(127, 187)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(315, 305)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnNumMenor)
        Me.Controls.Add(Me.btnNumMayor)
        Me.Controls.Add(Me.nudNumber2)
        Me.Controls.Add(Me.nudNumber1)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 4.5 Repaso "
        CType(Me.nudNumber1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumber2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents nudNumber1 As NumericUpDown
    Friend WithEvents nudNumber2 As NumericUpDown
    Friend WithEvents btnNumMayor As Button
    Friend WithEvents btnNumMenor As Button
    Friend WithEvents btnSelect As Button
End Class
