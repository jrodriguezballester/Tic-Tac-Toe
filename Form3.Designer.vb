<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ayuda
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
        Me.Label_ayuda = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_ayuda
        '
        Me.Label_ayuda.AutoSize = True
        Me.Label_ayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ayuda.Location = New System.Drawing.Point(73, 49)
        Me.Label_ayuda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_ayuda.Name = "Label_ayuda"
        Me.Label_ayuda.Size = New System.Drawing.Size(66, 25)
        Me.Label_ayuda.TabIndex = 0
        Me.Label_ayuda.Text = "ayuda"
        '
        'Ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 228)
        Me.Controls.Add(Me.Label_ayuda)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ayuda"
        Me.Text = "Acerca de ..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_ayuda As Label
End Class
