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
        Me.lbProductList = New System.Windows.Forms.ListBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbProductList
        '
        Me.lbProductList.FormattingEnabled = True
        Me.lbProductList.Location = New System.Drawing.Point(4, 75)
        Me.lbProductList.Name = "lbProductList"
        Me.lbProductList.Size = New System.Drawing.Size(356, 238)
        Me.lbProductList.TabIndex = 2
        '
        'btnPay
        '
        Me.btnPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPay.Location = New System.Drawing.Point(122, 329)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(123, 32)
        Me.btnPay.TabIndex = 3
        Me.btnPay.Text = "Pagar"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Alonso Gutierrez Gustavo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(372, 383)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lbProductList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repaso 2. Unidad 2. Autocobro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbProductList As ListBox
    Friend WithEvents btnPay As Button
    Friend WithEvents Label2 As Label
End Class
