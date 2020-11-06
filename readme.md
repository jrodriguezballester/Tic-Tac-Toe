# Tic-Tac-Toe en Visual Basic

Realización del juego de tres en raya en Visual Basic

## Version 1.0

![Screenshot](/recursos/Capt1.png)

En esta primera versión deberemos implementar:
1) Las nueve casilla creadas en tiempo de ejecución y formando un 3x3
    Ver  Private Sub crearCasillas()
2) Menu que permita salir del juego, iniciar uno nuevo y tener una ayuda.
3) Jugaremos 2 humanos, asi que cada clic pondrá una imagen distinta en una casilla vacía.
    Ver Private Sub casilla_Click(sender As Object, e As EventArgs)
4) El sistema elegirá de forma aleatoria que jugador (1 ó 2) es el primero en jugar
    Ver  Private Sub Quien_empieza()
5) e indicará quien ha ganado o si ha terminado en empate, dando la posibilidad de volver a jugar o salir.
    Ver Private Sub Mostrar_ganador()

![Screenshot](/recursos/Capt2.png)
