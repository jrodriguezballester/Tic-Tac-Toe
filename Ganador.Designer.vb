<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ganador
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
        Me.LabelNombreWinner = New System.Windows.Forms.Label()
        Me.ButtonPlayAgain = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 145)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ganador"
        '
        'LabelNombreWinner
        '
        Me.LabelNombreWinner.AutoSize = True
        Me.LabelNombreWinner.BackColor = System.Drawing.Color.Transparent
        Me.LabelNombreWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreWinner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelNombreWinner.Location = New System.Drawing.Point(176, 182)
        Me.LabelNombreWinner.Name = "LabelNombreWinner"
        Me.LabelNombreWinner.Size = New System.Drawing.Size(425, 135)
        Me.LabelNombreWinner.TabIndex = 1
        Me.LabelNombreWinner.Text = "Label2"
        '
        'ButtonPlayAgain
        '
        Me.ButtonPlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlayAgain.Location = New System.Drawing.Point(540, 415)
        Me.ButtonPlayAgain.Name = "ButtonPlayAgain"
        Me.ButtonPlayAgain.Size = New System.Drawing.Size(75, 32)
        Me.ButtonPlayAgain.TabIndex = 2
        Me.ButtonPlayAgain.Text = "Otra"
        Me.ButtonPlayAgain.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Location = New System.Drawing.Point(668, 415)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 32)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "Cerrar"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Ganador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonPlayAgain)
        Me.Controls.Add(Me.LabelNombreWinner)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Ganador"
        Me.Text = "Ganador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNombreWinner As Label
    Friend WithEvents ButtonPlayAgain As Button
    Friend WithEvents ButtonSalir As Button
End Class
