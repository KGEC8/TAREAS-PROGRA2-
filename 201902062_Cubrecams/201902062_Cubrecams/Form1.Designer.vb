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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.King = New System.Windows.Forms.RadioButton()
        Me.Imperial = New System.Windows.Forms.RadioButton()
        Me.Queen = New System.Windows.Forms.RadioButton()
        Me.Matrimonial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLino = New System.Windows.Forms.TextBox()
        Me.txtAlgodon = New System.Windows.Forms.TextBox()
        Me.txtSeda = New System.Windows.Forms.TextBox()
        Me.txtHilo = New System.Windows.Forms.TextBox()
        Me.Hilo = New System.Windows.Forms.CheckBox()
        Me.Lino = New System.Windows.Forms.CheckBox()
        Me.Seda = New System.Windows.Forms.CheckBox()
        Me.Algodón = New System.Windows.Forms.CheckBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LBL1 = New System.Windows.Forms.Label()
        Me.LBL2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(153, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fabrica la chapinita"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.King)
        Me.GroupBox1.Controls.Add(Me.Imperial)
        Me.GroupBox1.Controls.Add(Me.Queen)
        Me.GroupBox1.Controls.Add(Me.Matrimonial)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 120)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño de cubrecama"
        '
        'King
        '
        Me.King.AutoSize = True
        Me.King.Location = New System.Drawing.Point(6, 88)
        Me.King.Name = "King"
        Me.King.Size = New System.Drawing.Size(46, 17)
        Me.King.TabIndex = 6
        Me.King.TabStop = True
        Me.King.Text = "King"
        Me.King.UseVisualStyleBackColor = True
        '
        'Imperial
        '
        Me.Imperial.AutoSize = True
        Me.Imperial.Location = New System.Drawing.Point(6, 19)
        Me.Imperial.Name = "Imperial"
        Me.Imperial.Size = New System.Drawing.Size(61, 17)
        Me.Imperial.TabIndex = 3
        Me.Imperial.TabStop = True
        Me.Imperial.Text = "Imperial"
        Me.Imperial.UseVisualStyleBackColor = True
        '
        'Queen
        '
        Me.Queen.AutoSize = True
        Me.Queen.Location = New System.Drawing.Point(6, 65)
        Me.Queen.Name = "Queen"
        Me.Queen.Size = New System.Drawing.Size(57, 17)
        Me.Queen.TabIndex = 5
        Me.Queen.TabStop = True
        Me.Queen.Text = "Queen"
        Me.Queen.UseVisualStyleBackColor = True
        '
        'Matrimonial
        '
        Me.Matrimonial.AutoSize = True
        Me.Matrimonial.Location = New System.Drawing.Point(6, 42)
        Me.Matrimonial.Name = "Matrimonial"
        Me.Matrimonial.Size = New System.Drawing.Size(78, 17)
        Me.Matrimonial.TabIndex = 4
        Me.Matrimonial.TabStop = True
        Me.Matrimonial.Text = "Matrimonial"
        Me.Matrimonial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox2.Controls.Add(Me.txtLino)
        Me.GroupBox2.Controls.Add(Me.txtAlgodon)
        Me.GroupBox2.Controls.Add(Me.txtSeda)
        Me.GroupBox2.Controls.Add(Me.txtHilo)
        Me.GroupBox2.Controls.Add(Me.Hilo)
        Me.GroupBox2.Controls.Add(Me.Lino)
        Me.GroupBox2.Controls.Add(Me.Seda)
        Me.GroupBox2.Controls.Add(Me.Algodón)
        Me.GroupBox2.Location = New System.Drawing.Point(236, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 171)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Materiales de cubrecama"
        '
        'txtLino
        '
        Me.txtLino.Location = New System.Drawing.Point(109, 21)
        Me.txtLino.Name = "txtLino"
        Me.txtLino.Size = New System.Drawing.Size(100, 20)
        Me.txtLino.TabIndex = 3
        Me.txtLino.Text = "0"
        '
        'txtAlgodon
        '
        Me.txtAlgodon.Location = New System.Drawing.Point(109, 57)
        Me.txtAlgodon.Name = "txtAlgodon"
        Me.txtAlgodon.Size = New System.Drawing.Size(100, 20)
        Me.txtAlgodon.TabIndex = 4
        Me.txtAlgodon.Text = "0"
        '
        'txtSeda
        '
        Me.txtSeda.Location = New System.Drawing.Point(109, 90)
        Me.txtSeda.Name = "txtSeda"
        Me.txtSeda.Size = New System.Drawing.Size(100, 20)
        Me.txtSeda.TabIndex = 5
        Me.txtSeda.Text = "0"
        '
        'txtHilo
        '
        Me.txtHilo.Location = New System.Drawing.Point(109, 125)
        Me.txtHilo.Name = "txtHilo"
        Me.txtHilo.Size = New System.Drawing.Size(100, 20)
        Me.txtHilo.TabIndex = 6
        Me.txtHilo.Text = "0"
        '
        'Hilo
        '
        Me.Hilo.AutoSize = True
        Me.Hilo.Location = New System.Drawing.Point(6, 128)
        Me.Hilo.Name = "Hilo"
        Me.Hilo.Size = New System.Drawing.Size(74, 17)
        Me.Hilo.TabIndex = 6
        Me.Hilo.Text = "Hilo crudo"
        Me.Hilo.UseVisualStyleBackColor = True
        '
        'Lino
        '
        Me.Lino.AutoSize = True
        Me.Lino.Location = New System.Drawing.Point(6, 23)
        Me.Lino.Name = "Lino"
        Me.Lino.Size = New System.Drawing.Size(46, 17)
        Me.Lino.TabIndex = 3
        Me.Lino.Text = "Lino"
        Me.Lino.UseVisualStyleBackColor = True
        '
        'Seda
        '
        Me.Seda.AutoSize = True
        Me.Seda.Location = New System.Drawing.Point(6, 93)
        Me.Seda.Name = "Seda"
        Me.Seda.Size = New System.Drawing.Size(51, 17)
        Me.Seda.TabIndex = 5
        Me.Seda.Text = "Seda"
        Me.Seda.UseVisualStyleBackColor = True
        '
        'Algodón
        '
        Me.Algodón.AutoSize = True
        Me.Algodón.Location = New System.Drawing.Point(6, 57)
        Me.Algodón.Name = "Algodón"
        Me.Algodón.Size = New System.Drawing.Size(65, 17)
        Me.Algodón.TabIndex = 4
        Me.Algodón.Text = "Algodón"
        Me.Algodón.UseVisualStyleBackColor = True
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(251, 214)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 3
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(413, 214)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 4
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(325, 272)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 315)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 269)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Location = New System.Drawing.Point(22, 272)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(61, 13)
        Me.LBL1.TabIndex = 8
        Me.LBL1.Text = "Costo Total"
        '
        'LBL2
        '
        Me.LBL2.AutoSize = True
        Me.LBL2.Location = New System.Drawing.Point(21, 315)
        Me.LBL2.Name = "LBL2"
        Me.LBL2.Size = New System.Drawing.Size(35, 13)
        Me.LBL2.TabIndex = 9
        Me.LBL2.Text = "Venta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateBlue
        Me.ClientSize = New System.Drawing.Size(538, 404)
        Me.Controls.Add(Me.LBL2)
        Me.Controls.Add(Me.LBL1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents King As System.Windows.Forms.RadioButton
    Friend WithEvents Imperial As System.Windows.Forms.RadioButton
    Friend WithEvents Queen As System.Windows.Forms.RadioButton
    Friend WithEvents Matrimonial As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLino As System.Windows.Forms.TextBox
    Friend WithEvents txtAlgodon As System.Windows.Forms.TextBox
    Friend WithEvents txtSeda As System.Windows.Forms.TextBox
    Friend WithEvents txtHilo As System.Windows.Forms.TextBox
    Friend WithEvents Hilo As System.Windows.Forms.CheckBox
    Friend WithEvents Lino As System.Windows.Forms.CheckBox
    Friend WithEvents Seda As System.Windows.Forms.CheckBox
    Friend WithEvents Algodón As System.Windows.Forms.CheckBox
    Friend WithEvents Calcular As System.Windows.Forms.Button
    Friend WithEvents Limpiar As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LBL1 As System.Windows.Forms.Label
    Friend WithEvents LBL2 As System.Windows.Forms.Label

End Class
