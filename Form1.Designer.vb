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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelFondo = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelJugador2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelJugador1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JugarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContenioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxJug1 = New System.Windows.Forms.PictureBox()
        Me.PanelFondo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxJug1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.JugarToolStripMenuItem})
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(73, 32)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(180, 32)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'JugarToolStripMenuItem
        '
        Me.JugarToolStripMenuItem.Name = "JugarToolStripMenuItem"
        Me.JugarToolStripMenuItem.Size = New System.Drawing.Size(180, 32)
        Me.JugarToolStripMenuItem.Text = "Jugar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(64, 32)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExplicacionToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(82, 32)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ExplicacionToolStripMenuItem
        '
        Me.ExplicacionToolStripMenuItem.Name = "ExplicacionToolStripMenuItem"
        Me.ExplicacionToolStripMenuItem.Size = New System.Drawing.Size(200, 32)
        Me.ExplicacionToolStripMenuItem.Text = "Explicacion"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(200, 32)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de ..."
        '
        'PanelFondo
        '
        Me.PanelFondo.Controls.Add(Me.PictureBox1)
        Me.PanelFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFondo.Location = New System.Drawing.Point(0, 36)
        Me.PanelFondo.Name = "PanelFondo"
        Me.PanelFondo.Size = New System.Drawing.Size(1099, 767)
        Me.PanelFondo.TabIndex = 25
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
        Me.LabelJugador2.Size = New System.Drawing.Size(101, 29)
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
        'LabelJugador1
        '
        Me.LabelJugador1.AutoSize = True
        Me.LabelJugador1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.LabelJugador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJugador1.Location = New System.Drawing.Point(15, 15)
        Me.LabelJugador1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJugador1.Name = "LabelJugador1"
        Me.LabelJugador1.Size = New System.Drawing.Size(101, 29)
        Me.LabelJugador1.TabIndex = 0
        Me.LabelJugador1.Text = "Jugador"
        Me.LabelJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem1, Me.SalirToolStripMenuItem1, Me.AyudaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1099, 36)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem1
        '
        Me.InicioToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem1, Me.JugarToolStripMenuItem1})
        Me.InicioToolStripMenuItem1.Name = "InicioToolStripMenuItem1"
        Me.InicioToolStripMenuItem1.Size = New System.Drawing.Size(73, 32)
        Me.InicioToolStripMenuItem1.Text = "Inicio"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(64, 32)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem1, Me.ContenioToolStripMenuItem})
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(82, 32)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        Me.AyudaToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AyudaToolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'OpcionesToolStripMenuItem1
        '
        Me.OpcionesToolStripMenuItem1.Name = "OpcionesToolStripMenuItem1"
        Me.OpcionesToolStripMenuItem1.Size = New System.Drawing.Size(192, 32)
        Me.OpcionesToolStripMenuItem1.Text = "Opciones..."
        '
        'JugarToolStripMenuItem1
        '
        Me.JugarToolStripMenuItem1.Name = "JugarToolStripMenuItem1"
        Me.JugarToolStripMenuItem1.Size = New System.Drawing.Size(192, 32)
        Me.JugarToolStripMenuItem1.Text = "Jugar"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(224, 32)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de"
        '
        'ContenioToolStripMenuItem
        '
        Me.ContenioToolStripMenuItem.Name = "ContenioToolStripMenuItem"
        Me.ContenioToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.ContenioToolStripMenuItem.Text = "Contenio"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Tic_Tac_Toe.My.Resources.Resources.aplicacion1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1099, 767)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 803)
        Me.Controls.Add(Me.PanelFondo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1100, 850)
        Me.Name = "Form1"
        Me.Text = "Tic-Tac-Toe"
        Me.PanelFondo.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxJug1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ExplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents JugarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContenioToolStripMenuItem As ToolStripMenuItem
End Class
