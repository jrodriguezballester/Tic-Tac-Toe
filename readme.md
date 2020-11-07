# Tic-Tac-Toe

<https://github.com/jrodriguezballester/Tic-Tac-Toe.git>
Realización del juego de tres en raya en Visual Basic cumpliendo con los siguientes requisitos

## Version 1.0

En esta primera versión deberemos implementar:
1) Las nueve casilla creadas en tiempo de ejecución y formando un 3x3
 Las casillas se crean en tiempo de ejecucion, son PictureBox cuadrados, se han creado para que sean escalables facilmente, aunque solo esta completa (controlada) la dimension horizontal.
    ![Screenshot](/recursos/c2.png)
2) Menu que permita salir del juego, iniciar uno nuevo y tener una ayuda.
3) Jugaremos 2 humanos, asi que cada clic pondrá una imagen distinta en  una casilla vacía.
4) El sistema elegirá de forma aleatoria que jugador (1 ó 2) es el primero en jugar
 El jugador que tiene que mover viene indicado por la casilla verde, este pondrá su imagen sobre una casilla vacia, si estubiera llena recibe un aviso
 ![Screenshot](/recursos/c3.png)

5) e indicará quien ha ganado o si ha terminado en empate, dando la posibilidad de volver a jugar o salir.
Cuando se consigue completar una linea se muestra el ganador, si se completan las casillas sin un ganador se muestra el resultado de empate
![Screenshot](/recursos/c4.png)

## Version 2.0

En la segunda versión deberemos implementar:
Antes de empezar a jugar, y utilizando una opción del menú a tal efecto, abriremos un formulario donde:
1) Podremos indicar al nombre de los 2 jugadores
2) Podremos indicar la imagen que se mostrará para cada jugador.
Es decir, cada jugador puede elegir que imagen quiere que aparezca al pinchar. Podeis utilizar un OpenFileDialog y vigilar su propiedad FileName y poner el resultado en un PictureBox. Podemos utilizar un Checkbox que permita poner la imagen por defecto (la X o el O)
3) Podremos indicar si el jugador 2 será humano o el ordenador (aunque no implementemos la funcionalidad del ordenador, en esta segunda versión)
![Screenshot](/recursos/c5.png)

4) Podremos seleccionar, mediante RadioButtons, 2 tipos de juego: 3 en raya (versión que hemos implementado hasta ahora) y 4 en raya (nueva versión con 4x4 cuadrículas). Alguien se atreve con 5 en raya ...
![Screenshot](/recursos/c6.png)
El nombre de las casillas PictureBox +fila +columna que da lugar a su posicion en la matriz,  y su forma de extraerlo Dim posx As String = sender.name.substring(10, 1) delimita el nivel del juego a un digito; una modificacion en el nombre  PictureBox +fila +separador +columna haria mas fácil la ampliacion de niveles
