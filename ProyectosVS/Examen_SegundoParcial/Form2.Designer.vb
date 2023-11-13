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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNombre = New TextBox()
        nudEdad = New NumericUpDown()
        cmbCategoria = New ComboBox()
        Label4 = New Label()
        lstDatos = New ListBox()
        btnResultados = New Button()
        btnDatos = New Button()
        btnSalir = New Button()
        txtSueldo = New TextBox()
        CType(nudEdad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 15)
        Label1.TabIndex = 0
        Label1.Text = "Por favor, ingresa tu nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 15)
        Label2.TabIndex = 1
        Label2.Text = "Por favor, ingresa tu  edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 15)
        Label3.TabIndex = 2
        Label3.Text = "Por favor, ingresa tu  salario semanal"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(12, 27)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(200, 23)
        txtNombre.TabIndex = 3
        ' 
        ' nudEdad
        ' 
        nudEdad.Location = New Point(12, 79)
        nudEdad.Name = "nudEdad"
        nudEdad.Size = New Size(120, 23)
        nudEdad.TabIndex = 4
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Items.AddRange(New Object() {"Categoria 1", "Categoria 2", "Categoria 3", "Categoria 4"})
        cmbCategoria.Location = New Point(12, 192)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(121, 23)
        cmbCategoria.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 15)
        Label4.TabIndex = 7
        Label4.Text = "Por favor, ingresa tu  categoria"
        ' 
        ' lstDatos
        ' 
        lstDatos.FormattingEnabled = True
        lstDatos.ItemHeight = 15
        lstDatos.Location = New Point(243, 12)
        lstDatos.Name = "lstDatos"
        lstDatos.Size = New Size(294, 94)
        lstDatos.TabIndex = 8
        ' 
        ' btnResultados
        ' 
        btnResultados.Location = New Point(12, 234)
        btnResultados.Name = "btnResultados"
        btnResultados.Size = New Size(75, 23)
        btnResultados.TabIndex = 9
        btnResultados.Text = "Resultados"
        btnResultados.UseVisualStyleBackColor = True
        ' 
        ' btnDatos
        ' 
        btnDatos.Location = New Point(125, 234)
        btnDatos.Name = "btnDatos"
        btnDatos.Size = New Size(75, 23)
        btnDatos.TabIndex = 10
        btnDatos.Text = "Datos"
        btnDatos.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(261, 234)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 11
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' txtSueldo
        ' 
        txtSueldo.Location = New Point(12, 134)
        txtSueldo.Name = "txtSueldo"
        txtSueldo.Size = New Size(100, 23)
        txtSueldo.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(549, 269)
        Controls.Add(txtSueldo)
        Controls.Add(btnSalir)
        Controls.Add(btnDatos)
        Controls.Add(btnResultados)
        Controls.Add(lstDatos)
        Controls.Add(Label4)
        Controls.Add(cmbCategoria)
        Controls.Add(nudEdad)
        Controls.Add(txtNombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Form2"
        CType(nudEdad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents nudEdad As NumericUpDown
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstDatos As ListBox
    Friend WithEvents btnResultados As Button
    Friend WithEvents btnDatos As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtSueldo As TextBox
End Class
