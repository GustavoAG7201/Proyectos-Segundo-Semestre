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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCleanSide = New System.Windows.Forms.Button()
        Me.txtSideSquare = New System.Windows.Forms.TextBox()
        Me.btnSquareArea = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCleanRadio = New System.Windows.Forms.Button()
        Me.btnCircleArea = New System.Windows.Forms.Button()
        Me.txtRadio = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClearTriangle = New System.Windows.Forms.Button()
        Me.txtAreaTriangle = New System.Windows.Forms.Button()
        Me.txtBaseTriangle = New System.Windows.Forms.TextBox()
        Me.txtHeightTriangle = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClearRectangle = New System.Windows.Forms.Button()
        Me.btnRectangleArea = New System.Windows.Forms.Button()
        Me.txtHeightRectangle = New System.Windows.Forms.TextBox()
        Me.txtBaseRectangle = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(387, 409)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnCleanSide)
        Me.TabPage1.Controls.Add(Me.txtSideSquare)
        Me.TabPage1.Controls.Add(Me.btnSquareArea)
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(379, 412)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cuadrado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Lado:"
        '
        'btnCleanSide
        '
        Me.btnCleanSide.Location = New System.Drawing.Point(135, 252)
        Me.btnCleanSide.Name = "btnCleanSide"
        Me.btnCleanSide.Size = New System.Drawing.Size(106, 34)
        Me.btnCleanSide.TabIndex = 4
        Me.btnCleanSide.Text = "Limpiar"
        Me.btnCleanSide.UseVisualStyleBackColor = True
        '
        'txtSideSquare
        '
        Me.txtSideSquare.Location = New System.Drawing.Point(125, 155)
        Me.txtSideSquare.Multiline = True
        Me.txtSideSquare.Name = "txtSideSquare"
        Me.txtSideSquare.Size = New System.Drawing.Size(136, 51)
        Me.txtSideSquare.TabIndex = 3
        '
        'btnSquareArea
        '
        Me.btnSquareArea.Location = New System.Drawing.Point(135, 212)
        Me.btnSquareArea.Name = "btnSquareArea"
        Me.btnSquareArea.Size = New System.Drawing.Size(106, 34)
        Me.btnSquareArea.TabIndex = 2
        Me.btnSquareArea.Text = "Area"
        Me.btnSquareArea.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(125, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(126, 104)
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btnCleanRadio)
        Me.TabPage2.Controls.Add(Me.btnCircleArea)
        Me.TabPage2.Controls.Add(Me.txtRadio)
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(379, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Circulo "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Radio"
        '
        'btnCleanRadio
        '
        Me.btnCleanRadio.Location = New System.Drawing.Point(135, 278)
        Me.btnCleanRadio.Name = "btnCleanRadio"
        Me.btnCleanRadio.Size = New System.Drawing.Size(106, 34)
        Me.btnCleanRadio.TabIndex = 6
        Me.btnCleanRadio.Text = "Limpiar"
        Me.btnCleanRadio.UseVisualStyleBackColor = True
        '
        'btnCircleArea
        '
        Me.btnCircleArea.Location = New System.Drawing.Point(135, 238)
        Me.btnCircleArea.Name = "btnCircleArea"
        Me.btnCircleArea.Size = New System.Drawing.Size(106, 34)
        Me.btnCircleArea.TabIndex = 5
        Me.btnCircleArea.Text = "Area"
        Me.btnCircleArea.UseVisualStyleBackColor = True
        '
        'txtRadio
        '
        Me.txtRadio.Location = New System.Drawing.Point(121, 181)
        Me.txtRadio.Multiline = True
        Me.txtRadio.Name = "txtRadio"
        Me.txtRadio.Size = New System.Drawing.Size(136, 51)
        Me.txtRadio.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(126, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(126, 114)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.btnClearTriangle)
        Me.TabPage3.Controls.Add(Me.txtAreaTriangle)
        Me.TabPage3.Controls.Add(Me.txtBaseTriangle)
        Me.TabPage3.Controls.Add(Me.txtHeightTriangle)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(379, 412)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Triangulo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Altura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Base"
        '
        'btnClearTriangle
        '
        Me.btnClearTriangle.Location = New System.Drawing.Point(134, 314)
        Me.btnClearTriangle.Name = "btnClearTriangle"
        Me.btnClearTriangle.Size = New System.Drawing.Size(106, 34)
        Me.btnClearTriangle.TabIndex = 7
        Me.btnClearTriangle.Text = "Limpiar"
        Me.btnClearTriangle.UseVisualStyleBackColor = True
        '
        'txtAreaTriangle
        '
        Me.txtAreaTriangle.Location = New System.Drawing.Point(134, 274)
        Me.txtAreaTriangle.Name = "txtAreaTriangle"
        Me.txtAreaTriangle.Size = New System.Drawing.Size(106, 34)
        Me.txtAreaTriangle.TabIndex = 6
        Me.txtAreaTriangle.Text = "Area"
        Me.txtAreaTriangle.UseVisualStyleBackColor = True
        '
        'txtBaseTriangle
        '
        Me.txtBaseTriangle.Location = New System.Drawing.Point(31, 196)
        Me.txtBaseTriangle.Multiline = True
        Me.txtBaseTriangle.Name = "txtBaseTriangle"
        Me.txtBaseTriangle.Size = New System.Drawing.Size(136, 51)
        Me.txtBaseTriangle.TabIndex = 5
        '
        'txtHeightTriangle
        '
        Me.txtHeightTriangle.Location = New System.Drawing.Point(207, 196)
        Me.txtHeightTriangle.Multiline = True
        Me.txtHeightTriangle.Name = "txtHeightTriangle"
        Me.txtHeightTriangle.Size = New System.Drawing.Size(136, 51)
        Me.txtHeightTriangle.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(124, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(126, 112)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.btnClearRectangle)
        Me.TabPage4.Controls.Add(Me.btnRectangleArea)
        Me.TabPage4.Controls.Add(Me.txtHeightRectangle)
        Me.TabPage4.Controls.Add(Me.txtBaseRectangle)
        Me.TabPage4.Controls.Add(Me.PictureBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(379, 412)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Rectangulo "
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Base"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(205, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Altura"
        '
        'btnClearRectangle
        '
        Me.btnClearRectangle.Location = New System.Drawing.Point(130, 312)
        Me.btnClearRectangle.Name = "btnClearRectangle"
        Me.btnClearRectangle.Size = New System.Drawing.Size(106, 34)
        Me.btnClearRectangle.TabIndex = 9
        Me.btnClearRectangle.Text = "Limpiar"
        Me.btnClearRectangle.UseVisualStyleBackColor = True
        '
        'btnRectangleArea
        '
        Me.btnRectangleArea.Location = New System.Drawing.Point(130, 272)
        Me.btnRectangleArea.Name = "btnRectangleArea"
        Me.btnRectangleArea.Size = New System.Drawing.Size(106, 34)
        Me.btnRectangleArea.TabIndex = 8
        Me.btnRectangleArea.Text = "Area"
        Me.btnRectangleArea.UseVisualStyleBackColor = True
        '
        'txtHeightRectangle
        '
        Me.txtHeightRectangle.Location = New System.Drawing.Point(209, 198)
        Me.txtHeightRectangle.Multiline = True
        Me.txtHeightRectangle.Name = "txtHeightRectangle"
        Me.txtHeightRectangle.Size = New System.Drawing.Size(136, 51)
        Me.txtHeightRectangle.TabIndex = 7
        '
        'txtBaseRectangle
        '
        Me.txtBaseRectangle.Location = New System.Drawing.Point(34, 198)
        Me.txtBaseRectangle.Multiline = True
        Me.txtBaseRectangle.Name = "txtBaseRectangle"
        Me.txtBaseRectangle.Size = New System.Drawing.Size(136, 51)
        Me.txtBaseRectangle.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(130, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 104)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(147, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejercicio 4 Figuras"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCleanSide As Button
    Friend WithEvents txtSideSquare As TextBox
    Friend WithEvents btnSquareArea As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCleanRadio As Button
    Friend WithEvents btnCircleArea As Button
    Friend WithEvents txtRadio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearTriangle As Button
    Friend WithEvents txtAreaTriangle As Button
    Friend WithEvents txtBaseTriangle As TextBox
    Friend WithEvents txtHeightTriangle As TextBox
    Friend WithEvents btnRectangleArea As Button
    Friend WithEvents txtHeightRectangle As TextBox
    Friend WithEvents txtBaseRectangle As TextBox
    Friend WithEvents btnClearRectangle As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
End Class
