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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelFondo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelJugador2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBoxJug1 = New System.Windows.Forms.PictureBox()
        Me.LabelJugador1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelFondo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxJug1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.JugarToolStripMenuItem})
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 25)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'JugarToolStripMenuItem
        '
        Me.JugarToolStripMenuItem.Name = "JugarToolStripMenuItem"
        Me.JugarToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.JugarToolStripMenuItem.Text = "Jugar"
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
        'PanelFondo
        '
        Me.PanelFondo.Controls.Add(Me.PictureBox1)
        Me.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFondo.Location = New System.Drawing.Point(0, 29)
        Me.PanelFondo.Name = "PanelFondo"
        Me.PanelFondo.Size = New System.Drawing.Size(1099, 674)
        Me.PanelFondo.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Tic_Tac_Toe.My.Resources.Resources.cMVxfiI
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1099, 674)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.LabelJugador2)
        Me.Panel2.Location = New System.Drawing.Point(20, 11)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 220)
        Me.Panel2.TabIndex = 2
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 703)
        Me.Controls.Add(Me.PanelFondo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Tic-Tac-Toe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelFondo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxJug1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelBordeJug2 As Panel
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelFondo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    ' Friend WithEvents PictureBoxJug2 As PictureBox
    Friend WithEvents LabelJugador2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxJug1 As PictureBox
    Friend WithEvents LabelJugador1 As Label
End Class
