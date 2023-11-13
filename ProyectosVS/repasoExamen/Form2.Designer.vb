<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.btnMostrarIf = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAyuda = New System.Windows.Forms.TextBox()
        Me.txtSeleccion = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNum1.Location = New System.Drawing.Point(12, 12)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNum2.Location = New System.Drawing.Point(148, 12)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 1
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSuma.Location = New System.Drawing.Point(23, 38)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 23)
        Me.btnSuma.TabIndex = 2
        Me.btnSuma.Text = "Sumar"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMultiplicacion.Location = New System.Drawing.Point(157, 38)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicacion.TabIndex = 3
        Me.btnMultiplicacion.Text = "Multiplicar"
        Me.btnMultiplicacion.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMostrar.Location = New System.Drawing.Point(23, 108)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEdad.Location = New System.Drawing.Point(12, 82)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 20)
        Me.txtEdad.TabIndex = 5
        '
        'btnMostrarIf
        '
        Me.btnMostrarIf.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMostrarIf.Location = New System.Drawing.Point(23, 153)
        Me.btnMostrarIf.Name = "btnMostrarIf"
        Me.btnMostrarIf.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrarIf.TabIndex = 6
        Me.btnMostrarIf.Text = "Mostrar IF"
        Me.btnMostrarIf.UseVisualStyleBackColor = False
        '
        'btnAyuda
        '
        Me.btnAyuda.Location = New System.Drawing.Point(353, 38)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(120, 23)
        Me.btnAyuda.TabIndex = 7
        Me.btnAyuda.Text = "Ayuda a Peach"
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Seleccion 1 Al 6"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAyuda
        '
        Me.txtAyuda.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtAyuda.Location = New System.Drawing.Point(363, 12)
        Me.txtAyuda.Name = "txtAyuda"
        Me.txtAyuda.Size = New System.Drawing.Size(100, 20)
        Me.txtAyuda.TabIndex = 9
        '
        'txtSeleccion
        '
        Me.txtSeleccion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSeleccion.Location = New System.Drawing.Point(363, 108)
        Me.txtSeleccion.Name = "txtSeleccion"
        Me.txtSeleccion.Size = New System.Drawing.Size(100, 20)
        Me.txtSeleccion.TabIndex = 10
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(248, 215)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "SelectCase"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(513, 286)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtSeleccion)
        Me.Controls.Add(Me.txtAyuda)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.btnMostrarIf)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents btnMostrarIf As Button
    Friend WithEvents btnAyuda As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtAyuda As TextBox
    Friend WithEvents txtSeleccion As TextBox
    Friend WithEvents btnSelect As Button
End Class
