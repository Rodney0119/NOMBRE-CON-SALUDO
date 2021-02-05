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
        Me.SALUDO = New System.Windows.Forms.Label()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.ENTRAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(582, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESE SU NOMBRE"
        '
        'SALUDO
        '
        Me.SALUDO.AutoSize = True
        Me.SALUDO.BackColor = System.Drawing.Color.LightGray
        Me.SALUDO.Font = New System.Drawing.Font("Yu Gothic", 13.8!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALUDO.Location = New System.Drawing.Point(695, 396)
        Me.SALUDO.Name = "SALUDO"
        Me.SALUDO.Size = New System.Drawing.Size(113, 31)
        Me.SALUDO.TabIndex = 1
        Me.SALUDO.Text = "SALUDO"
        '
        'textNombre
        '
        Me.textNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.textNombre.Font = New System.Drawing.Font("Yu Gothic", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textNombre.Location = New System.Drawing.Point(585, 75)
        Me.textNombre.Name = "textNombre"
        Me.textNombre.Size = New System.Drawing.Size(485, 51)
        Me.textNombre.TabIndex = 2
        Me.textNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ENTRAR
        '
        Me.ENTRAR.BackColor = System.Drawing.Color.IndianRed
        Me.ENTRAR.Location = New System.Drawing.Point(715, 154)
        Me.ENTRAR.Name = "ENTRAR"
        Me.ENTRAR.Size = New System.Drawing.Size(120, 56)
        Me.ENTRAR.TabIndex = 3
        Me.ENTRAR.Text = "ENTRAR"
        Me.ENTRAR.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1082, 624)
        Me.Controls.Add(Me.ENTRAR)
        Me.Controls.Add(Me.textNombre)
        Me.Controls.Add(Me.SALUDO)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SALUDO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SALUDO As Label
    Friend WithEvents textNombre As TextBox
    Friend WithEvents ENTRAR As Button
End Class
