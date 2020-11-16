Public Class Form1
    Public filas As Integer = 3 'inicializamos a numero minimo numero de filas
    Dim PanelJuego As Panel
    Dim gamer1 As Boolean
    Dim finJuego As Boolean = False
    Dim gamer1_imagen, gamer2_imagen As Image
    Dim gamer1_name, gamer2_name, winner As String
    Dim matrizTablero(0, 0) As Integer
    Dim matrizMaximos(0, 0) As Integer
    Dim matrizCasos(2, 2) As Integer
    Dim matrizCasosHum(2, 2) As Integer
    Dim matrizAux(0, 0) As Integer
    Dim matrizPic(3, 3) As PictureBox
    Dim PanelBordeJug1, PanelBorde_jug2 As Panel
    Dim xsizePanel As Integer = 700
    Dim numCasos As Integer = 0
    Dim casos, posxMax, posyMax, Pmax As Integer

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
                matrizPic(i, j) = PictureBoxAux
                ''' Controls("PictureBox1.1").Text = 3
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
                matrizTablero(i, j) = 0
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
                ' rellenar matriz
                matrizTablero(posx, posy) = sender.tag
            Else
                MessageBox.Show("mueve el ordenador")
                matrizCasos = BorrarMatriz(matrizCasos)
                matrizMaximos = BorrarMatriz(matrizMaximos)
                PonerFichaIA()
            End If
            ' control de la accion en el juego
            ControlPartida()
        Else
            MessageBox.Show("Casilla marcada")
        End If

    End Sub

    Private Sub ControlPartida()
        Check_ganador()
        If finJuego Then
            Mostrar_ganador()
        Else
            Quedan_movimientos()
            If finJuego Then
                Mostrar_ganador()
            Else
                Cambiar_jugador()
                If Not gamer1 Then
                    movimientoIA()
                    Cambiar_jugador()
                End If

            End If
        End If

    End Sub

    Private Sub movimientoIA()
        MovimientosPosibles()
        ' Cambiar_jugador()
    End Sub

    Private Sub MovimientosPosibles()
        Dim moveWinner = False
        Dim moveLoser = False
        Dim evitarPerder = False
        Dim fila, columna As Integer
        Dim valorGamer2 As Integer = -1
        Dim valorGamer1 As Integer = 1
        matrizAux = CopiarMatrizAux()
        For filaP As Integer = 0 To UBound(matrizAux)
            For columnaP As Integer = 0 To UBound(matrizAux, 2)
                If matrizAux(filaP, columnaP) = 0 Then
                    ' filaP    columnaP
                    moveWinner = MovimientoGanador(filaP, columnaP, valorGamer2)
                    ' moviwinner salir bucle con filaP,columnaP
                    Dim a = 0
                    If moveWinner Then
                        fila = filaP
                        columna = columnaP
                        Exit For
                    End If
                    moveLoser = MovimientoGanador(filaP, columnaP, valorGamer1)
                    a = 0
                    If moveLoser Then
                        evitarPerder = True
                        fila = filaP
                        columna = columnaP
                    End If
                End If
            Next
            If moveWinner Then
                Exit For
            End If
        Next

        If moveWinner Then
            DibujarFicha(fila, columna)
        ElseIf evitarPerder Then
            DibujarFicha(fila, columna)
        Else
            matrizCasos = BorrarMatriz(matrizCasos)
            Pmax = 0
            For filaP As Integer = 0 To UBound(matrizTablero)
                For columnaP As Integer = 0 To UBound(matrizTablero, 2)
                    If matrizTablero(filaP, columnaP) = 0 Then
                        CalcularCasos(filaP, columnaP)
                    End If
                Next
            Next
            PonerenMaximo() ' Dibuja la ficha
            Pmax = 0
        End If

    End Sub

    Private Sub DibujarFicha(fila As Integer, columna As Integer)
        ' pintar esta posicion y finalizar
        matrizPic(fila, columna).Image = gamer2_imagen
        matrizPic(fila, columna).Tag = "-1"
        ' rellenar matriz
        matrizTablero(fila, columna) = -1
    End Sub

    Private Function MovimientoGanador(fila As Integer, columna As Integer, valorGamer As Integer) As Boolean
        matrizAux(fila, columna) = valorGamer
        Dim ganador As Integer
        ganador = checkWinner()
        ' devolver matriz a su estado anterior
        matrizAux(fila, columna) = 0
        If (ganador = valorGamer) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function checkWinner() As Integer
        Dim valor As Integer = 0
        Dim gana As Integer = 0

        ' horizontales
        For fila = 0 To UBound(matrizAux)
            For columna = 0 To UBound(matrizAux, 2)
                valor += matrizAux(fila, columna)
                If valor = filas Then gana = 1
                If valor = -(filas) Then gana = -1
            Next
            valor = 0
        Next

        ' verticales
        For i = 0 To UBound(matrizAux)
            For j = 0 To UBound(matrizAux, 2)
                valor += matrizAux(j, i)
                If valor = filas Then gana = 1
                If valor = -(filas) Then gana = -1
            Next
            valor = 0
        Next

        'diagonal \
        valor = 0
        For i = 0 To UBound(matrizAux)
            valor += matrizAux(i, i)
            If valor = filas Then gana = 1
            If valor = -(filas) Then gana = -1
        Next

        'diagonal /
        valor = 0
        For i = 0 To UBound(matrizAux)
            Dim n = filas - 1
            valor += matrizAux(i, n - i)
            If valor = filas Then gana = 1
            If valor = -(filas) Then gana = -1
        Next
        Return gana
    End Function


    Private Sub CalcularCasos(posxInicial As Integer, posyInicial As Integer)
        ' matrizCasos = BorrarMatriz(matrizCasos)
        ' matrizPosibles = BorrarMatriz(matrizPosibles)
        ' Rellenar filas,columnas, /,\ posibles para esa posicion 
        ' para hacer una parte de funcion minimax 


        'filas horizontales
        matrizAux = CopiarMatrizAux()
        matrizAux(posxInicial, posyInicial) = -1
        matrizAux = ComprobarFila(posxInicial, posyInicial)
        Dim numFilasPosibles As Integer = Calcularnumerodefilas(matrizAux)

        ' Columnas
        matrizAux = CopiarMatrizAux()
        matrizAux(posxInicial, posyInicial) = -1
        matrizAux = ComprobarColumna(posxInicial, posyInicial)
        Dim numcolunmasPosibles As Integer = calcularnumerodecolumnas(matrizAux)

        ' diagonal \
        matrizAux = CopiarMatrizAux()
        matrizAux(posxInicial, posyInicial) = -1
        matrizAux = ComprobarDiagonal1(posxInicial, posyInicial)
        Dim numDiagonal1Posibles As Integer = calcularnumerodediagonal1(matrizAux)

        ' diagonal /
        matrizAux = CopiarMatrizAux()
        matrizAux(posxInicial, posyInicial) = -1
        matrizAux = ComprobarDiagonal2(posxInicial, posyInicial)
        Dim numDiagonal2Posibles As Integer = calcularnumerodediagonal2(matrizAux)

        matrizAux = CopiarMatrizAux()

        ' Sumar numero de casos
        casos = 0
        casos = numFilasPosibles + numcolunmasPosibles + numDiagonal1Posibles + numDiagonal2Posibles
        'guardo el valor maximo de las lineas que se pueden rellenar
        If casos > Pmax Then Pmax = casos
        'guardo los valores de las lineas en cada posicion
        matrizCasos(posxInicial, posyInicial) = casos
    End Sub

    Private Sub PonerenMaximo() ' una parte de funcion minimax 
        Dim filaUlt, ColumnaUlt As Integer

        matrizMaximos = BorrarMatriz(matrizMaximos)
        'guardo en una matriz los casos en que son maximos
        For fila = 0 To UBound(matrizCasos)
            For columna = 0 To UBound(matrizCasos, 2)
                If matrizCasos(fila, columna) = Pmax Then
                    'guarda posicion caso
                    matrizMaximos(fila, columna) = 5
                    filaUlt = fila
                    ColumnaUlt = columna
                End If
            Next
        Next
        DibujarFicha(filaUlt, ColumnaUlt)
    End Sub








    Private Sub calcularMinHum()
        For filaP As Integer = 0 To UBound(matrizAux)
            For columnaP As Integer = 0 To UBound(matrizAux, 2)
                If matrizAux(filaP, columnaP) = 0 Then
                    CalcularCasosMin(filaP, columnaP)
                End If
            Next
        Next
    End Sub

    Private Sub CalcularCasosMin(fila As Integer, columna As Integer)
        Dim posxInicial = fila
        Dim posyInicial = columna
        matrizAux = CopiarReversoMatrizAux(matrizAux)
        'filas horizontales
        matrizAux = ComprobarFila(posxInicial, posyInicial)
        Dim numFilasPosibles As Integer = Calcularnumerodefilas(matrizAux)

        matrizAux = CopiarReversoMatrizAux(matrizAux)
        ' matrizAux(posxInicial, posyInicial) = -1

        ' Columnas
        matrizAux = ComprobarColumna(posxInicial, posyInicial)
        Dim numcolunmasPosibles As Integer = calcularnumerodecolumnas(matrizAux)

        matrizAux = CopiarReversoMatrizAux(matrizAux)
        '  matrizAux(posxInicial, posyInicial) = -1

        ' diagonal \
        matrizAux = ComprobarDiagonal1(posxInicial, posyInicial)
        Dim numDiagonal1Posibles As Integer = calcularnumerodediagonal1(matrizAux)

        matrizAux = CopiarReversoMatrizAux(matrizAux)
        ' matrizAux(posxInicial, posyInicial) = -1

        ' diagonal /
        matrizAux = ComprobarDiagonal2(posxInicial, posyInicial)
        Dim numDiagonal2Posibles As Integer = calcularnumerodediagonal2(matrizAux)

        ' Sumar numero de casos
        casos = 0
        casos = numFilasPosibles + numcolunmasPosibles + numDiagonal1Posibles + numDiagonal2Posibles
        matrizCasosHum(posxInicial, posyInicial) = casos
        ' guardar posicion maxima
        If casos > Pmax Then
            Pmax = casos
            '    posxMax = posxInicial
            '    posyMax = posyInicial
        End If
        For fila = 0 To UBound(matrizCasosHum)
            For columna = 0 To UBound(matrizCasosHum, 2)
                If matrizCasos(fila, columna) = Pmax Then
                    'guarda posicion caso
                    '    matrizPosiblesHum(fila, columna) = 5
                End If
            Next
        Next

    End Sub

    Private Function ChequeaGanador(matrizAux(,) As Integer)
        Dim valor As Integer = 0
        Dim gana = 0

        ' horizontales
        For fila = 0 To UBound(matrizAux)
            For columna = 0 To UBound(matrizAux, 2)
                valor += matrizAux(fila, columna)
                If valor = filas Then gana = 100
                If valor = -(filas) Then gana = -100
            Next
            valor = 0
        Next

        ' verticales
        For i = 0 To UBound(matrizAux)
            For j = 0 To UBound(matrizAux, 2)
                valor += matrizAux(j, i)
                If valor = filas Then gana = 100
                If valor = -(filas) Then gana = -100
            Next
            valor = 0
        Next

        'diagonal \
        valor = 0
        For i = 0 To UBound(matrizAux)
            valor += matrizAux(i, i)
            If valor = filas Then gana = 100
            If valor = -(filas) Then gana = -100
        Next

        'diagonal /
        valor = 0
        For i = 0 To UBound(matrizAux)
            Dim n = filas - 1
            valor += matrizAux(i, n - i)
            If valor = filas Then gana = 100
            If valor = -(filas) Then gana = -100
        Next
        Return gana
    End Function





    Private Function ComprobarDiagonal2(posxInicial As Integer, posyInicial As Integer) As Integer(,)
        ' diagonal /
        Dim n = filas - 1
        Dim RellenarDiagonal2 = True
        If posxInicial = (n - posyInicial) Then
            For fila As Integer = 0 To UBound(matrizAux)
                For columna As Integer = 0 To UBound(matrizAux, 2)
                    Dim aux As Integer = n - columna
                    If fila = (aux) Then ' lo meto delante y ahorro en el bucle
                        If matrizAux(fila, columna) = 1 Then
                            RellenarDiagonal2 = False
                        End If
                    End If
                Next
            Next
        End If
        If RellenarDiagonal2 Then
            If posxInicial = n - posyInicial Then
                For fila As Integer = 0 To UBound(matrizAux)
                    For columna As Integer = 0 To UBound(matrizAux, 2)
                        If fila = (n - columna) Then ' lo meto delante y ahorro en el bucle
                            If matrizAux(fila, columna) = 0 Then
                                matrizAux(fila, columna) = -1
                            End If
                        End If
                    Next
                Next
            End If
        End If
        Return matrizAux
    End Function
    Private Function ComprobarDiagonal2Hu(posxInicial As Integer, posyInicial As Integer) As Integer(,)
        ' diagonal /
        Dim n = filas - 1
        Dim RellenarDiagonal2 = True
        If posxInicial = (n - posyInicial) Then
            For fila As Integer = 0 To UBound(matrizAux)
                For columna As Integer = 0 To UBound(matrizAux, 2)
                    Dim aux As Integer = n - columna
                    If fila = (aux) Then ' lo meto delante y ahorro en el bucle
                        If matrizAux(fila, columna) = -1 Then
                            RellenarDiagonal2 = False
                        End If
                    End If
                Next
            Next
        End If
        If RellenarDiagonal2 Then
            If posxInicial = n - posyInicial Then
                For fila As Integer = 0 To UBound(matrizAux)
                    For columna As Integer = 0 To UBound(matrizAux, 2)
                        If fila = (n - columna) Then ' lo meto delante y ahorro en el bucle
                            If matrizAux(fila, columna) = 0 Then
                                matrizAux(fila, columna) = 1
                            End If
                        End If
                    Next
                Next
            End If
        End If
        Return matrizAux
    End Function
    Private Function ComprobarDiagonal1(posxInicial As Integer, posyInicial As Integer) As Integer(,)
        ' diagonal \
        Dim RellenarDiagonal1 = True
        If posxInicial = posyInicial Then
            For fila As Integer = 0 To UBound(matrizAux)
                For columna As Integer = 0 To UBound(matrizAux, 2)
                    If fila = columna Then ' lo meto delante y ahorro en el bucle
                        If matrizAux(fila, columna) = 1 Then
                            '       MessageBox.Show("hay x en la diagonal \")
                            RellenarDiagonal1 = False
                        End If
                    End If
                Next
            Next
        End If
        ' Rellenar diagonal \
        If RellenarDiagonal1 Then
            If posxInicial = posyInicial Then
                For fila As Integer = 0 To UBound(matrizAux)
                    For columna As Integer = 0 To UBound(matrizAux, 2)
                        If fila = columna Then ' lo meto delante y ahorro en el bucle
                            If matrizAux(fila, columna) = 0 Then
                                matrizAux(fila, columna) = -1
                            End If
                        End If
                    Next
                Next
            End If
        End If
        Return matrizAux
    End Function
    Private Function ComprobarDiagonal1Hu(posxInicial As Integer, posyInicial As Integer) As Integer(,)
        ' diagonal \
        Dim RellenarDiagonal1 = True
        If posxInicial = posyInicial Then
            For fila As Integer = 0 To UBound(matrizAux)
                For columna As Integer = 0 To UBound(matrizAux, 2)
                    If fila = columna Then ' lo meto delante y ahorro en el bucle
                        If matrizAux(fila, columna) = -1 Then
                            '       MessageBox.Show("hay x en la diagonal \")
                            RellenarDiagonal1 = False
                        End If
                    End If
                Next
            Next
        End If
        ' Rellenar diagonal \
        If RellenarDiagonal1 Then
            If posxInicial = posyInicial Then
                For fila As Integer = 0 To UBound(matrizAux)
                    For columna As Integer = 0 To UBound(matrizAux, 2)
                        If fila = columna Then ' lo meto delante y ahorro en el bucle
                            If matrizAux(fila, columna) = 0 Then
                                matrizAux(fila, columna) = 1
                            End If
                        End If
                    Next
                Next
            End If
        End If
        Return matrizAux
    End Function
    Private Function ComprobarColumna(posxInicial As Integer, posyInicial As Integer) As Integer(,)
        Dim RellenarColumna = True
        For fila As Integer = 0 To UBound(matrizAux)
            For columna As Integer = 0 To UBound(matrizAux, 2)
                If columna = posyInicial Then
                    If matrizAux(fila, columna) = 1 Then
                        '    MessageBox.Show("hay x en la columna")
                        RellenarColumna = False
                    End If
                End If
            Next
        Next
        ' Se puede rellenar columna
        If RellenarColumna Then
            For fila As Integer = 0 To UBound(matrizAux)
                For columna As Integer = 0 To UBound(matrizAux, 2)
                    If matrizAux(fila, columna) = 0 Then
                        If columna = posyInicial Then
                            matrizAux(fila, columna) = -1
                        End If
                    End If
                Next
            Next
        End If
        Return matrizAux
    End Function
    Private Function ComprobarColumnaHu(posxInicial As Integer, posyInicial As Integer) As Integer(,)
        Dim RellenarColumna = True
        For fila As Integer = 0 To UBound(matrizAux)
            For columna As Integer = 0 To UBound(matrizAux, 2)
                If columna = posyInicial Then
                    If matrizAux(fila, columna) = -1 Then
                        '    MessageBox.Show("hay x en la columna")
                        RellenarColumna = False
                    End If
                End If
            Next
        Next
        ' Se puede rellenar columna
        If RellenarColumna Then
            For fila As Integer = 0 To UBound(matrizAux)
                For columna As Integer = 0 To UBound(matrizAux, 2)
                    If matrizAux(fila, columna) = 0 Then
                        If columna = posyInicial Then
                            matrizAux(fila, columna) = 1
                        End If
                    End If
                Next
            Next
        End If
        Return matrizAux
    End Function
    Private Function ComprobarFila(posxInicial As Integer, posyInicial As Integer) As Integer(,)
        Dim RellenarFila = True
        For fila As Integer = 0 To UBound(matrizAux)
            For columna As Integer = 0 To UBound(matrizAux, 2)
                If fila = posxInicial Then
                    If matrizAux(fila, columna) = 1 Then
                        '    MessageBox.Show("hay x en la fila")
                        RellenarFila = False
                        Exit For
                    End If
                End If
            Next
            If Not RellenarFila Then Exit For
        Next
        ' se puede rellenar fila
        If RellenarFila Then
            For fila As Integer = 0 To UBound(matrizAux)
                For columna As Integer = 0 To UBound(matrizAux, 2)
                    If matrizAux(fila, columna) = 0 Then
                        If fila = posxInicial Then
                            matrizAux(fila, columna) = -1
                        End If
                    End If
                Next
            Next
        End If
        Return matrizAux
    End Function
    Private Function ComprobarFilaHu(posxInicial As Integer, posyInicial As Integer) As Integer(,)
        Dim RellenarFila = True
        For fila As Integer = 0 To UBound(matrizAux)
            For columna As Integer = 0 To UBound(matrizAux, 2)
                If fila = posxInicial Then
                    If matrizAux(fila, columna) = -1 Then
                        '    MessageBox.Show("hay x en la fila")
                        RellenarFila = False
                    End If
                End If
            Next
        Next
        ' se puede rellenar fila
        If RellenarFila Then
            For fila As Integer = 0 To UBound(matrizAux)
                For columna As Integer = 0 To UBound(matrizAux, 2)
                    If matrizAux(fila, columna) = 0 Then
                        If fila = posxInicial Then
                            matrizAux(fila, columna) = 1
                        End If
                    End If
                Next
            Next
        End If
        Return matrizAux
    End Function
    Private Function CopiarMatrizAux() As Integer(,)
        For fila As Integer = 0 To UBound(matrizTablero)
            For columna As Integer = 0 To UBound(matrizTablero, 2)
                matrizAux(fila, columna) = matrizTablero(fila, columna)
            Next
        Next
        Return matrizAux
    End Function
    Private Function BorrarMatriz(matriz1(,) As Integer) As Integer(,)
        For fila As Integer = 0 To UBound(matriz1)
            For columna As Integer = 0 To UBound(matriz1, 2)
                matriz1(fila, columna) = 0
            Next
        Next
        Return matriz1
    End Function
    Private Function CopiarReversoMatrizAux(matriz2(,) As Integer) As Integer(,)
        For fila As Integer = 0 To UBound(matriz2)
            For columna As Integer = 0 To UBound(matriz2, 2)
                matrizAux(fila, columna) = -matriz2(fila, columna)
            Next
        Next
        Return matrizAux
    End Function

    Private Function Calcularnumerodefilas(matrizAux(,) As Integer) As Integer
        Dim valor As Integer = 0
        Dim contador = 0
        For fila As Integer = 0 To UBound(matrizAux)
            For columna As Integer = 0 To UBound(matrizAux, 2)
                valor += matrizAux(fila, columna)
                If valor = -(filas) Then
                    contador += 1
                End If
            Next
            valor = 0
        Next
        Return contador
    End Function
    Private Function CalcularnumerodefilasHu(matrizAux(,) As Integer) As Integer
        Dim valor As Integer = 0
        Dim contador = 0
        For fila As Integer = 0 To UBound(matrizAux)
            For columna As Integer = 0 To UBound(matrizAux, 2)
                valor += matrizAux(fila, columna)
                If valor = (filas) Then
                    contador += 1
                End If
            Next
            valor = 0
        Next
        Return contador
    End Function
    Private Function calcularnumerodecolumnas(matrizAux(,) As Integer) As Integer
        Dim valor As Integer = 0
        Dim contador = 0
        ' verticales
        For fila As Integer = 0 To UBound(matrizAux)
            For columna As Integer = 0 To UBound(matrizAux, 2)
                valor += matrizAux(columna, fila)
                If valor = -(filas) Then
                    contador += 1
                End If
            Next
            valor = 0
        Next
        '     MessageBox.Show("columnas" & contador)
        Return contador
    End Function
    Private Function calcularnumerodediagonal1(matrizAux(,) As Integer) As Integer
        Dim valor As Integer = 0
        Dim contador = 0

        'diagonal \
        valor = 0
        For fila As Integer = 0 To UBound(matrizAux)
            valor += matrizAux(fila, fila)
            If valor = -(filas) Then
                contador += 1
            End If
        Next

        '     MessageBox.Show("diagonal1 " & contador)
        Return contador
    End Function
    Private Function calcularnumerodediagonal2(matrizAux(,) As Integer) As Integer
        Dim valor As Integer = 0
        Dim contador = 0

        'diagonal /
        valor = 0
        For fila As Integer = 0 To UBound(matrizAux)
            Dim n = filas - 1
            valor += matrizAux(fila, n - fila)
            If valor = -(filas) Then contador += 1
        Next
        '    MessageBox.Show("diagonal2" & contador)
        Return contador
    End Function



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
                valor = matrizTablero(i, j)
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
                valor += matrizTablero(i, j)
                If valor = filas Then gana1 = True
                If valor = -(filas) Then gana2 = True
            Next
            valor = 0
        Next

        ' verticales
        For i = 0 To filas - 1
            For j = 0 To filas - 1
                valor += matrizTablero(j, i)
                If valor = filas Then gana1 = True
                If valor = -(filas) Then gana2 = True
            Next
            valor = 0
        Next

        'diagonal \
        valor = 0
        For i = 0 To filas - 1
            valor += matrizTablero(i, i)
            If valor = filas Then gana1 = True
            If valor = -(filas) Then gana2 = True
        Next

        'diagonal /
        valor = 0
        For i = 0 To filas - 1
            Dim n = filas - 1
            valor += matrizTablero(i, n - i)
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
        Dim primeravez = True

        Nivel_juego()
        Inicializar_datos()
        Crear_panel_juego()
        Crear_card_jugadores()
        Quien_empieza()
        Crear_casillas()
        'controlar que juega ordenador
        If primeravez Then
            If gamer1 Then
                MessageBox.Show("mueves tu")
                primeravez = False
            Else
                MessageBox.Show("mueves ordenador")
                PonerFichaIA()
                Cambiar_jugador()
                primeravez = False
            End If
        End If

        PanelJuego.BringToFront()
        PanelBordeJug1.BringToFront()
        PanelBorde_jug2.BringToFront()

    End Sub

    Private Sub PonerFichaIA()
        If gamer1 Then
        Else
            movimientoIA()
        End If
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
        Dim n As Integer = filas - 1
        ReDim matrizTablero(n, n)
        ReDim matrizMaximos(n, n)
        ReDim matrizAux(n, n)
        ReDim matrizPic(n, n)
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

