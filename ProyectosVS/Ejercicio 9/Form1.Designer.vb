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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudAge = New System.Windows.Forms.NumericUpDown()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.txtLenguaje = New System.Windows.Forms.TextBox()
        Me.rbAnswer1 = New System.Windows.Forms.RadioButton()
        Me.rbAnswer2 = New System.Windows.Forms.RadioButton()
        Me.rbAnswer3 = New System.Windows.Forms.RadioButton()
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Nombre:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(298, 20)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿Que es la programacion?(50pts)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(505, 52)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "¿Como se llama el lenguaje de programacion que estas viendo con la maestra Athala" &
    "?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ingresa tu edad:"
        '
        'nudAge
        '
        Me.nudAge.Location = New System.Drawing.Point(179, 281)
        Me.nudAge.Name = "nudAge"
        Me.nudAge.Size = New System.Drawing.Size(120, 20)
        Me.nudAge.TabIndex = 7
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(204, 313)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(128, 45)
        Me.btnFinish.TabIndex = 8
        Me.btnFinish.Text = "Finalizar"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'txtLenguaje
        '
        Me.txtLenguaje.Location = New System.Drawing.Point(16, 234)
        Me.txtLenguaje.Name = "txtLenguaje"
        Me.txtLenguaje.Size = New System.Drawing.Size(298, 20)
        Me.txtLenguaje.TabIndex = 9
        '
        'rbAnswer1
        '
        Me.rbAnswer1.AutoSize = True
        Me.rbAnswer1.Location = New System.Drawing.Point(16, 73)
        Me.rbAnswer1.Name = "rbAnswer1"
        Me.rbAnswer1.Size = New System.Drawing.Size(369, 17)
        Me.rbAnswer1.TabIndex = 10
        Me.rbAnswer1.TabStop = True
        Me.rbAnswer1.Text = "Crear instrucciones que nos permiten decirle que hacer a la computadora"
        Me.rbAnswer1.UseVisualStyleBackColor = True
        '
        'rbAnswer2
        '
        Me.rbAnswer2.AutoSize = True
        Me.rbAnswer2.Location = New System.Drawing.Point(16, 108)
        Me.rbAnswer2.Name = "rbAnswer2"
        Me.rbAnswer2.Size = New System.Drawing.Size(257, 17)
        Me.rbAnswer2.TabIndex = 11
        Me.rbAnswer2.TabStop = True
        Me.rbAnswer2.Text = "Una metodologia para la resolucion de problemas"
        Me.rbAnswer2.UseVisualStyleBackColor = True
        '
        'rbAnswer3
        '
        Me.rbAnswer3.AutoSize = True
        Me.rbAnswer3.Location = New System.Drawing.Point(16, 147)
        Me.rbAnswer3.Name = "rbAnswer3"
        Me.rbAnswer3.Size = New System.Drawing.Size(209, 17)
        Me.rbAnswer3.TabIndex = 12
        Me.rbAnswer3.TabStop = True
        Me.rbAnswer3.Text = "Un metodo para arreglar computadoras"
        Me.rbAnswer3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(540, 370)
        Me.Controls.Add(Me.rbAnswer3)
        Me.Controls.Add(Me.rbAnswer2)
        Me.Controls.Add(Me.rbAnswer1)
        Me.Controls.Add(Me.txtLenguaje)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.nudAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 9 Examen"
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudAge As NumericUpDown
    Friend WithEvents btnFinish As Button
    Friend WithEvents txtLenguaje As TextBox
    Friend WithEvents rbAnswer1 As RadioButton
    Friend WithEvents rbAnswer2 As RadioButton
    Friend WithEvents rbAnswer3 As RadioButton
End Class
