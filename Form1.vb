Public Class Form1
    Dim filas As Integer = 3
    Dim PanelJuego As Panel
    Dim gamer1 As Boolean
    Dim finJuego As Boolean = False
    Dim gamer1_imagen As Image
    Dim gamer2_imagen As Image
    Dim gamer1_name, gamer2_name, Winner As String
    Dim PictureBoxAux As PictureBox
    Dim matriz(2, 2) As Integer


    Private Sub crearCasillas()
        Dim xPos, yPos, xInc, yInc As Integer
        Dim lblAux As Label
        yPos = 20
        xInc = 200
        yInc = 200
        For i = 0 To filas - 1
            xPos = 20
            For j = 0 To filas - 1
                PictureBoxAux = New PictureBox
                ' PictureBoxAux.Image = Global.Tic_Tac_Toe.My.Resources.Resources._69jYqiBt
                PictureBoxAux.Location = New System.Drawing.Point(xPos, yPos)
                PictureBoxAux.Name = "PictureBox" & i & j
                PictureBoxAux.Size = New System.Drawing.Size(150, 150)
                PictureBoxAux.BackColor = Color.Red
                PictureBoxAux.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxAux.Tag = Nothing
                AddHandler PictureBoxAux.Click, AddressOf casilla_Click
                PanelJuego.Controls.Add(PictureBoxAux)
                xPos += xInc

            Next
            yPos += yInc
        Next
        ' Separacion Casillas
        xPos = 185
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
        yPos = 185
        For i = 1 To filas - 1
            lblAux = New Label
            lblAux.BackColor = Color.Black
            lblAux.Size = New Size(570, 20)
            lblAux.Location = New Point(10, yPos)
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
    Private Sub casilla_Click(sender As Object, e As EventArgs)
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
            Inicializar_datos()
            PanelJuego.Dispose()
            crearPanelJuego()
            crearCasillas()
            cargarJugadores()
            Quien_empieza()
        End If
    End Sub

    Private Sub Cambiar_jugador()
        gamer1 = Not gamer1
        Mostrar_borde_jugador()
    End Sub
    Private Sub Mostrar_borde_jugador()
        If gamer1 Then
            PanelBordeJug1.BackColor = Color.Green
            PanelBordeJug2.BackColor = Color.Transparent
            '   DrawRectangle(p, Panel1.Left - 1, Panel1.Top - 1, Panel1.Width + 1, Panel1.Height + 1);
        Else
            PanelBordeJug1.BackColor = Color.Transparent
            PanelBordeJug2.BackColor = Color.Green
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
        PanelJuego = New Panel
        PanelJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        PanelJuego.Location = New System.Drawing.Point(337, 58)
        PanelJuego.Name = "PanelJuego"
        PanelJuego.Size = New System.Drawing.Size(590, 590)
        Me.Controls.Add(PanelJuego)
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

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        'poner variables a 0
        Inicializar_datos()
        If IsNothing(PanelJuego) Then
        Else
            PanelJuego.Dispose()
        End If
        crearPanelJuego()
        crearCasillas()
        cargarJugadores()
        Quien_empieza()
    End Sub

    Private Sub cargarJugadores()
        gamer1_name = "Juan"
        gamer2_name = "Jose"
        gamer1_imagen = Global.Tic_Tac_Toe.My.Resources.Resources._69jYqiBt
        gamer2_imagen = Global.Tic_Tac_Toe.My.Resources.Resources.lets_do_this_lee_sin_best_emotes_league_of_legends
        LabelJugador1.Text = gamer1_name
        LabelJugador2.Text = gamer2_name
        PictureBoxJug1.Image = gamer1_imagen
        PictureBoxJug2.Image = gamer2_imagen
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



End Class

