<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBoxJug1 = New System.Windows.Forms.PictureBox()
        Me.LabelJugador1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBoxJug2 = New System.Windows.Forms.PictureBox()
        Me.LabelJugador2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelBordeJug2 = New System.Windows.Forms.Panel()
        Me.PanelBordeJug1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxJug1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxJug2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelBordeJug2.SuspendLayout()
        Me.PanelBordeJug1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.PictureBoxJug1)
        Me.Panel1.Controls.Add(Me.LabelJugador1)
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 220)
        Me.Panel1.TabIndex = 0
        '
        'PictureBoxJug1
        '
        Me.PictureBoxJug1.Location = New System.Drawing.Point(20, 60)
        Me.PictureBoxJug1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBoxJug1.Name = "PictureBoxJug1"
        Me.PictureBoxJug1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBoxJug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxJug1.TabIndex = 1
        Me.PictureBoxJug1.TabStop = False
        '
        'LabelJugador1
        '
        Me.LabelJugador1.AutoSize = True
        Me.LabelJugador1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LabelJugador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJugador1.Location = New System.Drawing.Point(15, 15)
        Me.LabelJugador1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJugador1.Name = "LabelJugador1"
        Me.LabelJugador1.Size = New System.Drawing.Size(79, 24)
        Me.LabelJugador1.TabIndex = 0
        Me.LabelJugador1.Text = "Jugador"
        Me.LabelJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.PictureBoxJug2)
        Me.Panel2.Controls.Add(Me.LabelJugador2)
        Me.Panel2.Location = New System.Drawing.Point(20, 11)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 220)
        Me.Panel2.TabIndex = 2
        '
        'PictureBoxJug2
        '
        Me.PictureBoxJug2.Location = New System.Drawing.Point(20, 60)
        Me.PictureBoxJug2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBoxJug2.Name = "PictureBoxJug2"
        Me.PictureBoxJug2.Size = New System.Drawing.Size(150, 150)
        Me.PictureBoxJug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxJug2.TabIndex = 1
        Me.PictureBoxJug2.TabStop = False
        '
        'LabelJugador2
        '
        Me.LabelJugador2.AutoSize = True
        Me.LabelJugador2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LabelJugador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJugador2.Location = New System.Drawing.Point(15, 15)
        Me.LabelJugador2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJugador2.Name = "LabelJugador2"
        Me.LabelJugador2.Size = New System.Drawing.Size(79, 24)
        Me.LabelJugador2.TabIndex = 0
        Me.LabelJugador2.Text = "Jugador"
        Me.LabelJugador2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.SalirToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1099, 29)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 25)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(53, 25)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(66, 25)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'PanelBordeJug2
        '
        Me.PanelBordeJug2.Controls.Add(Me.Panel2)
        Me.PanelBordeJug2.Location = New System.Drawing.Point(30, 406)
        Me.PanelBordeJug2.Name = "PanelBordeJug2"
        Me.PanelBordeJug2.Size = New System.Drawing.Size(224, 253)
        Me.PanelBordeJug2.TabIndex = 23
        '
        'PanelBordeJug1
        '
        Me.PanelBordeJug1.Controls.Add(Me.Panel1)
        Me.PanelBordeJug1.Location = New System.Drawing.Point(30, 138)
        Me.PanelBordeJug1.Name = "PanelBordeJug1"
        Me.PanelBordeJug1.Size = New System.Drawing.Size(224, 253)
        Me.PanelBordeJug1.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 703)
        Me.Controls.Add(Me.PanelBordeJug1)
        Me.Controls.Add(Me.PanelBordeJug2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Tic-Tac-Toe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxJug1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxJug2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelBordeJug2.ResumeLayout(False)
        Me.PanelBordeJug1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxJug1 As PictureBox
    Friend WithEvents LabelJugador1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBoxJug2 As PictureBox
    Friend WithEvents LabelJugador2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelBordeJug2 As Panel
    Friend WithEvents PanelBordeJug1 As Panel
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
End Class
