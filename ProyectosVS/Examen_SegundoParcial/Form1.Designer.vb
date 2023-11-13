<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        txtCorreo = New TextBox()
        txtContraseña = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(120, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 15)
        Label1.TabIndex = 1
        Label1.Text = "Por favor, ingresa tu correo electronico"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(180, 163)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Inicio"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(120, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 15)
        Label2.TabIndex = 3
        Label2.Text = "Por favor, ingresa tu contraseña"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(120, 41)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(212, 23)
        txtCorreo.TabIndex = 4
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(120, 96)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(212, 23)
        txtContraseña.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(451, 246)
        Controls.Add(txtContraseña)
        Controls.Add(txtCorreo)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Examen Unidad 2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContraseña As TextBox
End Class
