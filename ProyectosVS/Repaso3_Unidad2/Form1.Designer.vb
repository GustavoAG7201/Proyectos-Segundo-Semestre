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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalarioSemanal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbOperador = New System.Windows.Forms.RadioButton()
        Me.cmbVacaciones = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstNominas = New System.Windows.Forms.ListBox()
        Me.nudAñosLaborados = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudAñosLaborados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su nombre"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(16, 36)
        Me.txtNombreEmpleado.Multiline = True
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(281, 20)
        Me.txtNombreEmpleado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese su sueldo semanal"
        '
        'txtSalarioSemanal
        '
        Me.txtSalarioSemanal.Location = New System.Drawing.Point(15, 144)
        Me.txtSalarioSemanal.Multiline = True
        Me.txtSalarioSemanal.Name = "txtSalarioSemanal"
        Me.txtSalarioSemanal.Size = New System.Drawing.Size(281, 33)
        Me.txtSalarioSemanal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "¿Cuantos años lleva laborados dentro de la empresa?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(340, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Seleccione su rol dentro de la empresa"
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Checked = True
        Me.rbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdmin.Location = New System.Drawing.Point(16, 86)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(144, 28)
        Me.rbAdmin.TabIndex = 7
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Administrativo"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbOperador
        '
        Me.rbOperador.AutoSize = True
        Me.rbOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOperador.Location = New System.Drawing.Point(188, 86)
        Me.rbOperador.Name = "rbOperador"
        Me.rbOperador.Size = New System.Drawing.Size(109, 28)
        Me.rbOperador.TabIndex = 8
        Me.rbOperador.Text = "Operador"
        Me.rbOperador.UseVisualStyleBackColor = True
        '
        'cmbVacaciones
        '
        Me.cmbVacaciones.FormattingEnabled = True
        Me.cmbVacaciones.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbVacaciones.Location = New System.Drawing.Point(15, 207)
        Me.cmbVacaciones.Name = "cmbVacaciones"
        Me.cmbVacaciones.Size = New System.Drawing.Size(121, 21)
        Me.cmbVacaciones.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "¿Se le pagaran vacaciones?"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(16, 284)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(455, 35)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 410)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(236, 33)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(254, 410)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(217, 33)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lstNominas
        '
        Me.lstNominas.FormattingEnabled = True
        Me.lstNominas.Location = New System.Drawing.Point(15, 325)
        Me.lstNominas.Name = "lstNominas"
        Me.lstNominas.Size = New System.Drawing.Size(455, 69)
        Me.lstNominas.TabIndex = 14
        '
        'nudAñosLaborados
        '
        Me.nudAñosLaborados.Location = New System.Drawing.Point(17, 258)
        Me.nudAñosLaborados.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudAñosLaborados.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAñosLaborados.Name = "nudAñosLaborados"
        Me.nudAñosLaborados.Size = New System.Drawing.Size(120, 20)
        Me.nudAñosLaborados.TabIndex = 15
        Me.nudAñosLaborados.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(483, 450)
        Me.Controls.Add(Me.nudAñosLaborados)
        Me.Controls.Add(Me.lstNominas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbVacaciones)
        Me.Controls.Add(Me.rbOperador)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSalarioSemanal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nominas Transportes FEMA"
        CType(Me.nudAñosLaborados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalarioSemanal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbOperador As RadioButton
    Friend WithEvents cmbVacaciones As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lstNominas As ListBox
    Friend WithEvents nudAñosLaborados As NumericUpDown
End Class
