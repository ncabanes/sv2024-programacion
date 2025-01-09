/*
Reto 07: Figuritas del Belén

Problema a resolver

La abuela y sus costumbres navideñas... al menos este año nos ha dejado colocar 
nosotros las figuras en el Belén. Pero, eso sí, quiere que todas estén a la 
vista, que no se tapen unas a otras. Pretende que estén sobre una cuadrícula, 
sin que ninguna esté en contacto con otra, ya sea en horizontal, vertical o 
diagonal. Nos ha pedido que hagamos un boceto en una hoja cuadriculada, 
indicando dónde colocaremos las figuras, para que confirme si el parecen bien.

Para ganar tiempo, hemos decidido crear un programa que nos ayude a comprobar 
que, a partir de un cierto array bidimensional, no hay dos figuras demasiado 
cerca, y responda "ACEPTABLE" (o "NO ACEPTABLE", si fuera el caso).

Datos de entrada

Para cada posible boceto, habrá una primera línea con dos números positivos 
(menores que 100) separados por un espacio. El primer número será la cantidad 
de filas (f) y el segundo será la cantidad de columnas (c). A continuación, 
seguirán "f" filas, cada una formada por "c" caracteres, todos los cuales serán 
un punto (.) para indicar un espacio en blanco o una equis mayúscula (X) para 
indicar la posición de una figurita. Tras cada boceto, habrá una línea en 
blanco. Para terminar, existirá una línea en la que tanto el alto como ancho 
sean 0.

Ejemplo de entrada

3 3
...
.X.
...

5 5
.X..X
.....
.....
..X.X
X....

3 4
..XX
....
X..X

3 4
...X
...X
X..X

3 4
...X
..X.
X...

6 10
.X...X....
...X...X..
X....X....
..X......X
X...X..X..
..X......X

0 0

Salida que se debería obtener con esa entrada:

ACEPTABLE
ACEPTABLE
NO ACEPTABLE
NO ACEPTABLE
NO ACEPTABLE
ACEPTABLE
*/

using System;

class FiguritasBelen
{
    static void Main()
    {
        string tamanyo = Console.ReadLine();
        while (tamanyo != "0 0")
        {
            int filas = Convert.ToInt32(tamanyo.Split()[0]);
            int columnas = Convert.ToInt32(tamanyo.Split()[1]);

            char[,] belen = new char[filas, columnas];

            for (int fila = 0; fila < filas; fila++)
            {
                string linea = Console.ReadLine();
                for (int col = 0; col < columnas; col++)
                {
                    belen[fila, col] = linea[col];
                }
            }

            if (EsAceptable(belen))
                Console.WriteLine("ACEPTABLE");
            else
                Console.WriteLine("NO ACEPTABLE");

            Console.ReadLine(); // Separador

            tamanyo = Console.ReadLine(); // Siguiente dato real
        }
    }

    static bool EsAceptable(char[,] belen)
    {
        int filas = belen.GetLength(0);
        int columnas = belen.GetLength(1);

        for (int fila = 0; fila < filas; fila++)
        {
            for (int col = 0; col < columnas; col++)
            {
                if (belen[fila, col] == 'X')  // Si es figurita, miramos los 3x3 que le rodean
                {
                    for (int incrY = -1; incrY <= 1; incrY++)
                    {
                        for (int incrX = -1; incrX <= 1; incrX++)
                        {
                            int yComprobar = fila + incrY;
                            int xComprobar = col + incrX;

                            if (xComprobar >= 0 && xComprobar < columnas
                                && yComprobar >= 0 && yComprobar < filas
                                && (yComprobar != fila || xComprobar != col)
                                && belen[yComprobar, xComprobar] == 'X')
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }

        return true;
    }
}
