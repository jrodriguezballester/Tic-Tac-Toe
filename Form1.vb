Public Class Form1
    Dim filas As Integer
    Dim PanelJuego As Panel
    Dim gamer1 As Boolean
    Dim finJuego As Boolean = False
    Dim gamer1_imagen, gamer2_imagen As Image
    Dim gamer1_name, gamer2_name, Winner As String
    Dim matriz(0, 0) As Integer
    Dim PanelBordeJug1, PanelBorde_jug2 As Panel

    Private Sub crearCasillas()
        Dim xPos, yPos, xInc, yInc, xPanel, aLbl As Integer
        Dim lblAux As Label
        Dim xsize As Integer
        Dim PictureBoxAux As PictureBox
        xPanel = 600
        aLbl = 20
        yPos = 0
        xsize = (600 - (aLbl * (filas - 1))) / filas
        xInc = xsize + aLbl
        yInc = xInc
        For i = 0 To filas - 1
            xPos = 0
            For j = 0 To filas - 1
                PictureBoxAux = New PictureBox
                PictureBoxAux.Location = New System.Drawing.Point(xPos, yPos)
                PictureBoxAux.Name = "PictureBox" & i & j
                PictureBoxAux.Size = New System.Drawing.Size(xsize, xsize)
                PictureBoxAux.BackColor = Color.Transparent
                PictureBoxAux.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxAux.Tag = Nothing
                AddHandler PictureBoxAux.Click, AddressOf Casilla_Click
                PanelJuego.Controls.Add(PictureBoxAux)
                xPos += xInc
            Next
            yPos += yInc
        Next

        ' Barras Separacion Casillas
        xPos = 0 + xsize
        yPos = 0 + xsize
        For i = 1 To filas - 1
            lblAux = New Label
            lblAux.BackColor = Color.Black
            lblAux.Size = New Size(20, 600)
            lblAux.Location = New Point(xPos, 0)
            PanelJuego.Controls.Add(lblAux)
            xPos += xInc
        Next

        For i = 1 To filas - 1
            lblAux = New Label
            lblAux.BackColor = Color.Black
            lblAux.Size = New Size(600, 20)
            lblAux.Location = New Point(0, yPos)
            PanelJuego.Controls.Add(lblAux)
            yPos += yInc
        Next
    End Sub
    Private Sub Inicializar_datos()
        'matriz datos
        For i = 0 To filas - 1
            For j = 0 To filas - 1
                matriz(i, j) = 0
            Next
        Next
        'finJuego
        finJuego = False

    End Sub
    Private Sub Casilla_Click(sender As Object, e As EventArgs)
        'No esta marcada sender.tag=0
        Dim posx As String = sender.name.substring(10, 1)
        Dim posy As String = sender.name.substring(11)
        'Label1.Text = sender.tag
        If IsNothing(sender.tag) Then
            'Saber que jugador es y Poner imagen jugador,rellenar matriz
            If gamer1 Then
                sender.Image = gamer1_imagen
                sender.tag = "1"
                matriz(posx, posy) = 1
            Else
                sender.Image = gamer2_imagen
                sender.tag = "-1"
                matriz(posx, posy) = -1
            End If
            '     Label1.Text = posx
            '     Label2.Text = posy
            Check_ganador(sender)
            If finJuego Then
                Mostrar_ganador()
            Else
                Quedan_movimientos()
                If finJuego Then
                    Mostrar_ganador()
                Else
                    Cambiar_jugador()
                End If
            End If
        End If
    End Sub

    Private Sub Mostrar_ganador()
        Dim mensaje As String
        If Winner = "0" Then
            mensaje = "Habeis empatado"
        Else
            mensaje = "Ganador: " & Winner
        End If
        Dim result As DialogResult = MessageBox.Show(mensaje & "
Quieres seguir jugando", "Fin del Juego", MessageBoxButtons.YesNo)
        ' If the no button was pressed ...
        If (result = DialogResult.No) Then
            ' cancel the closure of the form.
            Close()
        End If
        If (result = DialogResult.Yes) Then
            iniciarjuego()
        End If
    End Sub

    Private Sub Cambiar_jugador()
        gamer1 = Not gamer1
        Mostrar_borde_jugador()
    End Sub
    Private Sub Mostrar_borde_jugador()
        If gamer1 Then
            PanelBordeJug1.BackColor = Color.Green
            PanelBorde_jug2.BackColor = Color.Red
        Else
            PanelBordeJug1.BackColor = Color.Red
            PanelBorde_jug2.BackColor = Color.Green
        End If
    End Sub

    Private Sub Quedan_movimientos()
        Dim valor As Integer
        Dim mover As Boolean = False
        For i = 0 To filas - 1
            For j = 0 To filas - 1
                valor = matriz(i, j)
                If valor = 0 Then
                    '  MessageBox.Show("quedan movimientos")
                    'mejorar for
                    mover = True
                    Exit For
                End If
            Next
            If mover Then Exit For
        Next
        If Not mover Then
            ' quedan empate 
            finJuego = True
            Winner = 0
        End If
    End Sub

    Private Sub Check_ganador(sender As Object)
        Dim valor As Integer = 0
        Dim gana1 = False
        Dim gana2 = False
        ' horizontales
        For i = 0 To filas - 1
            For j = 0 To filas - 1
                valor += matriz(i, j)
                If valor = filas Then gana1 = True
                If valor = -(filas) Then gana2 = True
            Next
            valor = 0
        Next
        ' verticales
        For i = 0 To filas - 1
            For j = 0 To filas - 1
                valor += matriz(j, i)
                If valor = filas Then gana1 = True
                If valor = -(filas) Then gana2 = True
            Next
            valor = 0
        Next
        valor = 0
        'diagonal \
        For i = 0 To filas - 1
            valor += matriz(i, i)
            If valor = filas Then gana1 = True
            If valor = -(filas) Then gana2 = True
        Next

        'diagonal /
        valor = 0
        For i = 0 To filas - 1
            Dim n = filas - 1
            valor += matriz(i, n - i)
            If valor = filas Then gana1 = True
            If valor = -(filas) Then gana2 = True
        Next
        If gana1 Then
            Winner = gamer1_name
            finJuego = True
        End If
        If gana2 Then
            Winner = gamer2_name
            finJuego = True
        End If
    End Sub

    Private Sub crearPanelJuego()
        PanelJuego = New Panel With {
            .BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
            .Location = New System.Drawing.Point(337, 58),
            .Name = "PanelJuego",
        .Size = New System.Drawing.Size(600, 600)
        }
        PanelFondo.Controls.Add(PanelJuego)
    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click

        Ayuda.Label_ayuda.Text = "Tic-Tac-Toe version 1.0
        https://github.com/jrodriguezballester/Tic-Tac-Toe.git
        Lenguaje: Visual Basic
        Autor: Jose Rodriguez"
        Ayuda.Size = New Size(540, 250)
        Ayuda.Show()
    End Sub

    Private Sub JugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugarToolStripMenuItem.Click
        'poner variables a 0
        iniciarjuego()
    End Sub

    Public Sub iniciarjuego()
        Inicializar_datos()
        If IsNothing(PanelJuego) Then
        Else
            PanelJuego.Dispose()
        End If

        Nivel_juego(filas)
        crearPanelJuego()
        Crear_jugadores()
        PanelJuego.BringToFront()
        PanelBordeJug1.BringToFront()
        PanelBorde_jug2.BringToFront()

        crearCasillas()
        ' cargarJugadores()
        Quien_empieza()
    End Sub

    Private Sub Crear_jugadores()
        'jugador 1
        Dim PictureBoxJug1 As New PictureBox With {
            .Location = New Point(20, 60),
            .Margin = New Padding(4, 5, 4, 5),
            .Name = "PictureBoxJug1",
            .Size = New Size(150, 150),
            .SizeMode = PictureBoxSizeMode.StretchImage
        }
        Dim LabelJugador1 As New Label With {
            .AutoSize = True,
            .BackColor = System.Drawing.SystemColors.ControlDark,
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .Location = New System.Drawing.Point(15, 15),
            .Margin = New System.Windows.Forms.Padding(4, 0, 4, 0),
            .Name = "LabelJugador1",
            .Size = New System.Drawing.Size(79, 24),
            .Text = "Jugador",
            .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        }
        Dim Panel1 As New Panel With {
            .BackColor = System.Drawing.SystemColors.ControlDark,
            .Location = New System.Drawing.Point(20, 20),
            .Margin = New System.Windows.Forms.Padding(4, 5, 4, 5),
            .Name = "Panel1",
            .Size = New System.Drawing.Size(220, 220)
        }

        PanelBordeJug1 = New Panel With {
            .Location = New System.Drawing.Point(20, 45),
            .Name = "PanelBordeJug1",
            .Size = New System.Drawing.Size(260, 260)
        }
        PanelBordeJug1.Controls.Add(Panel1)
        Panel1.Controls.Add(PictureBoxJug1)
        Panel1.Controls.Add(LabelJugador1)
        Me.Controls.Add(PanelBordeJug1)
        'jugador 2
        Dim PictureBoxJug2 As New PictureBox With {
            .Location = New Point(20, 60),
            .Margin = New Padding(4, 5, 4, 5),
            .Name = "PictureBoxJug1",
            .Size = New Size(150, 150),
            .SizeMode = PictureBoxSizeMode.StretchImage
        }
        Dim LabelJugador2 As New Label With {
            .AutoSize = True,
            .BackColor = System.Drawing.SystemColors.ControlDark,
            .Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
            .Location = New System.Drawing.Point(15, 15),
            .Margin = New System.Windows.Forms.Padding(4, 0, 4, 0),
            .Name = "LabelJugador2",
            .Size = New System.Drawing.Size(79, 24),
            .Text = "Jugador",
            .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        }
        Dim Panel2 As New Panel With {
            .BackColor = System.Drawing.SystemColors.ControlDark,
            .Location = New System.Drawing.Point(20, 20),
            .Margin = New System.Windows.Forms.Padding(4, 5, 4, 5),
            .Name = "Panel2",
            .Size = New System.Drawing.Size(220, 220)
        }

        PanelBorde_jug2 = New Panel With {
            .Location = New System.Drawing.Point(20, 310),
            .Name = "PanelBorde_jug2",
            .Size = New System.Drawing.Size(260, 260)
        }
        PanelBorde_jug2.Controls.Add(Panel2)
        Panel2.Controls.Add(PictureBoxJug2)
        Panel2.Controls.Add(LabelJugador2)
        Me.Controls.Add(PanelBorde_jug2)

        ' Cargajugadores
        'recoger datos de opciones
        gamer1_name = Opciones.TextBoxGamer1_name.Text
        gamer2_name = Opciones.TextBoxGamer2_name.Text
        gamer1_imagen = Opciones.PictureBoxGamer1.Image
        gamer2_imagen = Opciones.PictureBoxGamer2.Image

        If gamer1_name = "" Then
            gamer1_name = "jug 1"
        End If
        If gamer2_name = "" Then
            gamer2_name = "jug 2"
        End If


        LabelJugador1.Text = gamer1_name
        LabelJugador2.Text = gamer2_name
        PictureBoxJug1.Image = gamer1_imagen
        PictureBoxJug2.Image = gamer2_imagen

    End Sub

    Public Sub Nivel_juego(nuevafila As Integer)
        filas = nuevafila
        ReDim matriz(filas - 1, filas - 1)
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click
        Opciones.ShowDialog()
    End Sub



    Private Sub Quien_empieza()
        Dim rdn As New Random
        Dim jugSelect As Integer
        jugSelect = rdn.Next(2)
        If jugSelect = 0 Then
            gamer1 = True
        Else
            gamer1 = False
        End If
        Mostrar_borde_jugador()
    End Sub

    Private Sub crearCasillas2()
        Dim xPos, yPos, xInc, yInc As Integer
        Dim lblAux As Label
        Dim xsize As Integer
        Dim PictureBoxAux As PictureBox
        yPos = 20
        xInc = 200
        yInc = 200
        xsize = 150
        For i = 0 To filas - 1
            xPos = 20
            For j = 0 To filas - 1
                PictureBoxAux = New PictureBox
                PictureBoxAux.Location = New System.Drawing.Point(xPos, yPos)
                PictureBoxAux.Name = "PictureBox" & i & j
                PictureBoxAux.Size = New System.Drawing.Size(xsize, xsize)
                PictureBoxAux.BackColor = Color.Red
                PictureBoxAux.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxAux.Tag = Nothing
                AddHandler PictureBoxAux.Click, AddressOf Casilla_Click
                PanelJuego.Controls.Add(PictureBoxAux)
                xPos += xInc
            Next
            yPos += yInc
        Next
        ' Separacion Casillas
        ' xPos = 185
        yPos = 10
        xInc = 200
        yInc = 200
        For i = 1 To filas - 1
            lblAux = New Label
            lblAux.BackColor = Color.Black
            lblAux.Size = New Size(20, 570)
            lblAux.Location = New Point(xPos, 10)
            PanelJuego.Controls.Add(lblAux)
            xPos += xInc
        Next
        yPos = 175
        For i = 1 To filas - 1
            lblAux = New Label
            lblAux.BackColor = Color.Black
            lblAux.Size = New Size(570, 20)
            lblAux.Location = New Point(10, yPos)
            PanelJuego.Controls.Add(lblAux)
            yPos += yInc
        Next
    End Sub

End Class

