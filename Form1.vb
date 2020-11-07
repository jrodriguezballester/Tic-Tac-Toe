Public Class Form1
    Public filas As Integer = 3 'inicializamos a numero minimo numero de filas
    Dim PanelJuego As Panel
    Dim gamer1 As Boolean
    Dim finJuego As Boolean = False
    Dim gamer1_imagen, gamer2_imagen As Image
    Dim gamer1_name, gamer2_name, winner As String
    Dim matriz(0, 0) As Integer
    Dim PanelBordeJug1, PanelBorde_jug2 As Panel
    Dim xsizePanel As Integer = 700

    ''' <summary>
    ''' Crea casillas cuadradas, como pictureBox, esta a medio parametrizar (falta valores de y) para poder cambiar facilmente de dimensiones
    ''' </summary>
    Private Sub Crear_casillas()
        Dim xPos, yPos, xInc, yInc, xPanel, aLbl As Integer
        Dim lblAux As Label
        Dim xsize As Integer
        Dim PictureBoxAux As PictureBox
        xPanel = 600
        aLbl = 60 / filas
        yPos = 0
        xsize = (xsizePanel - (aLbl * (filas - 1))) / filas
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
            lblAux.Size = New Size(aLbl, xsizePanel)
            lblAux.Location = New Point(xPos, 0)
            PanelJuego.Controls.Add(lblAux)
            xPos += xInc
        Next

        For i = 1 To filas - 1
            lblAux = New Label
            lblAux.BackColor = Color.Black
            lblAux.Size = New Size(xsizePanel, aLbl)
            lblAux.Location = New Point(0, yPos)
            PanelJuego.Controls.Add(lblAux)
            yPos += yInc
        Next
    End Sub


    ''' <summary>
    ''' Pone banderas y matriz de casillas a su valor inicial
    ''' </summary>
    Private Sub Inicializar_datos()
        'matriz datos
        For i = 0 To filas - 1
            For j = 0 To filas - 1
                matriz(i, j) = 0
            Next
        Next
        'finJuego
        finJuego = False

        'Panel de las casillas
        If IsNothing(PanelJuego) Then
        Else
            PanelJuego.Dispose()
        End If
    End Sub


    ''' <summary>
    ''' Pone imagen jugador y da valor a matriz en funcion de su nombre (saca posicion)
    ''' Controla que no este pulsada esa casilla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Casilla_Click(sender As Object, e As EventArgs)
        ' limita el numero de filas la forma de obtener la posicion 
        Dim posx As String = sender.name.substring(10, 1)
        Dim posy As String = sender.name.substring(11)

        'No esta marcada sender.tag=0
        If IsNothing(sender.tag) Then
            'Saber que jugador es y poner imagen jugador
            If gamer1 Then
                sender.Image = gamer1_imagen
                sender.tag = "1"
            Else
                sender.Image = gamer2_imagen
                sender.tag = "-1"
            End If
            ' rellenar matriz
            matriz(posx, posy) = sender.tag

            ' control de la accion en el juego
            Check_ganador()
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
        Else
            MessageBox.Show("Casilla marcada")
        End If
    End Sub


    ''' <summary>
    ''' Muestra el ganador 
    ''' </summary>
    Private Sub Mostrar_ganador()
        Dim mensaje As String
        If winner = "0" Then
            Ganador.LabelNombreWinner.Text = "Empate"
        Else
            Ganador.LabelNombreWinner.Text = winner
            mensaje = "Ganador: " & winner
        End If
        Ganador.ShowDialog()
    End Sub


    ''' <summary>
    ''' Cambia el valor de la bandera y llama a pintar el borde de la card jugador
    ''' </summary>
    Private Sub Cambiar_jugador()
        gamer1 = Not gamer1
        Mostrar_borde_jugador()
    End Sub


    ''' <summary>
    ''' Pinta el borde de la card del jugador para indicar quien tiene que mover
    ''' </summary>
    Private Sub Mostrar_borde_jugador()
        If gamer1 Then
            PanelBordeJug1.BackColor = Color.Green
            PanelBorde_jug2.BackColor = Color.Red
        Else
            PanelBordeJug1.BackColor = Color.Red
            PanelBorde_jug2.BackColor = Color.Green
        End If
    End Sub


    ''' <summary>
    ''' Controla que quedan casillas sin marcar (Valor en la matriz=0). Si no quedan se declara partida empatada 
    ''' </summary>
    Private Sub Quedan_movimientos()
        Dim valor As Integer
        Dim mover As Boolean = False
        For i = 0 To filas - 1
            For j = 0 To filas - 1
                valor = matriz(i, j)
                If valor = 0 Then
                    mover = True
                    Exit For
                End If
            Next
            If mover Then
                Exit For
            End If
        Next
        If Not mover Then
            finJuego = True
            winner = 0  ' quedan empate 
        End If
    End Sub


    ''' <summary>
    ''' Recorre toda la matriz por filas. La suma (en positivo o negativo) de la fila debe ser igual al numero de filas.
    ''' El ganador se obtiene por el signo (pos o neg)
    ''' </summary>
    Private Sub Check_ganador()
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

        'diagonal \
        valor = 0
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
            winner = gamer1_name
            finJuego = True
        End If
        If gana2 Then
            winner = gamer2_name
            finJuego = True
        End If
    End Sub


    ''' <summary>
    ''' diseño panel dinamicamente
    ''' </summary>
    Private Sub Crear_panel_juego()
        PanelJuego = New Panel With {
            .BorderStyle = BorderStyle.FixedSingle,
            .Location = New Point(337, 15),
            .Name = "PanelJuego",
            .Size = New Size(xsizePanel, xsizePanel)
        }
        PanelFondo.Controls.Add(PanelJuego)
    End Sub


    ''' <summary>
    ''' Salir del juego
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub


    ''' <summary>
    ''' Explicacion juego
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ContenioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContenioToolStripMenuItem.Click
        Ayuda.Label_ayuda.Text = "Seleccione Opciones para poner introducir los jugadores y nivel de juego
        Seleccione Jugar para lanzar una partida rapida al nivel 3 x 3 
        El nivel maximo (en codigo) es 9 filas "
        Ayuda.Size = New Size(640, 150)
        Ayuda.Show()
    End Sub


    ''' <summary>
    ''' Muestra la ventana de Opciones
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpcionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem1.Click
        Opciones.ShowDialog()
    End Sub


    ''' <summary>
    ''' Salir desde opcion del menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Close()
    End Sub


    ''' <summary>
    '''  Inicia el juego si no hay jugadores, nivel los toma por defecto
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub JugarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles JugarToolStripMenuItem1.Click
        Iniciarjuego()
    End Sub


    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        Ayuda.Label_ayuda.Text = "Tic-Tac-Toe version 2.2
            https://github.com/jrodriguezballester/Tic-Tac-Toe.git
            Lenguaje: Visual Basic
            Autor: Jose Rodriguez"
        Ayuda.Size = New Size(540, 250)
        Ayuda.Show()
    End Sub



    ''' <summary>
    ''' Inicio del juego, elimina panel anterior del juego 
    ''' </summary>
    Public Sub Iniciarjuego()

        Nivel_juego()
        Inicializar_datos()
        Crear_panel_juego()
        Crear_card_jugadores()
        Quien_empieza()
        Crear_casillas()

        PanelJuego.BringToFront()
        PanelBordeJug1.BringToFront()
        PanelBorde_jug2.BringToFront()

    End Sub


    ''' <summary>
    ''' Crea las tarjetas de los jugadores
    ''' </summary>
    Private Sub Crear_card_jugadores()
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
            .Text = "Jugador 1",
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
            .Text = "Jugador 2",
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
            gamer1_name = "jugador 1"
        End If
        If gamer2_name = "" Then
            gamer2_name = "jugador 2"
        End If

        LabelJugador1.Text = gamer1_name
        LabelJugador2.Text = gamer2_name

        PictureBoxJug1.Image = gamer1_imagen
        PictureBoxJug2.Image = gamer2_imagen

    End Sub


    ''' <summary>
    ''' Redimensiona matriz 
    ''' </summary>
    Public Sub Nivel_juego()
        ReDim matriz(filas - 1, filas - 1)
    End Sub


    ''' <summary>
    ''' Eleccion aleatoria del jugador que empieza, se controla unicamente al jugador 1 (gamer1=true cuando puede mover)
    ''' </summary>
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

