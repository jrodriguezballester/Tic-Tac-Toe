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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelGanador = New System.Windows.Forms.Label()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fin del Juego"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ganador: "
        '
        'LabelGanador
        '
        Me.LabelGanador.AutoSize = True
        Me.LabelGanador.Location = New System.Drawing.Point(236, 166)
        Me.LabelGanador.Name = "LabelGanador"
        Me.LabelGanador.Size = New System.Drawing.Size(51, 17)
        Me.LabelGanador.TabIndex = 2
        Me.LabelGanador.Text = "Label3"
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.Location = New System.Drawing.Point(95, 333)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(119, 33)
        Me.ButtonNuevo.TabIndex = 3
        Me.ButtonNuevo.Text = "Seguir Jugando"
        Me.ButtonNuevo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 430)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonNuevo)
        Me.Controls.Add(Me.LabelGanador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelGanador As Label
    Friend WithEvents ButtonNuevo As Button
    Friend WithEvents Button2 As Button
End Class
