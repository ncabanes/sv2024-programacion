/*
Reto 08: La huida del ca*aner

Problema a resolver

Al final, la abuela nos ha dado permiso para colocar las figuritas del belén 
como nos apetezca, pero teniendo en cuenta que el ca*aner siempre se siente 
observado, por lo que nos ha pedido que coloquemos las figuritas de forma que 
éste pueda encontrar una salida en caso de que se agobie.

El ca*aner se puede mover de una posición de la cuadrícula a la siguiente, en 
horizontal o en vertical pero no en diagonal. La colocación del belén será 
aceptable si el ca*aner puede encontrar un camino entre su posición inicial, 
que estará indicada con una letra C y la salida, que estará indicada con una 
letra S. El resto de figuras, cuya posición no podrá atravesar, estarán 
indicadas con una X. Las posiciones pisables estarán detalladas con un punto 
(.)

Tu programa deberá responder escribiendo "ACEPTABLE" o "NO ACEPTABLE", según si 
podrá encontrar la salida o no.

Puedes ayudarte de una función recursiva "bool EsResoluble(char[,] tablero, int 
xInicial, int yInicial)" que mire, para cada estado de la cuadrícula que 
representa el belén, si, cuando se mueva el ca*aner, se acerca a una posición 
que le permita abandonar el Belén. 

Datos de entrada

Para cada posible colocación del belén, habrá una primera línea con dos números 
positivos (menores que 100) separados por un espacio. El primer número será la 
cantidad de filas (f) y el segundo será la cantidad de columnas (c). A 
continuación, seguirán "f" filas, cada una formada por "c" caracteres, todos 
los cuales serán un punto (.) para indicar un espacio en blanco o una equis 
mayúscula (X) para indicar la posición de una figurita y también existirá una C 
para indicar la posición inicial del ca*aner y una S para la salida. Tras cada 
boceto, habrá una línea en blanco. Para terminar, existirá una línea en la que 
tanto el alto como ancho sean 0.

Ejemplo de entrada

3 3
C..
.X.
..S

5 5
SX..X
....C
..X.X
..XXX
.XX..

3 4
..CX
..XS
X..X

3 4
S..X
..XC
X..X

3 4
...X
.SX.
X..C

6 10
.XC..X....
...X...X..
X....X....
..X......X
X...X..X..
..X....S.X

0 0

Salida que se debería obtener con esa entrada:

ACEPTABLE
ACEPTABLE
NO ACEPTABLE
NO ACEPTABLE
ACEPTABLE
ACEPTABLE
*/

using System;

class LaHuida
{
    static void Main()
    {
        string tamanyo = Console.ReadLine();
        while (tamanyo != "0 0")
        {
            int filas = Convert.ToInt32(tamanyo.Split()[0]);
            int columnas = Convert.ToInt32(tamanyo.Split()[1]);
            int xInicial = 0, yInicial = 0;

            char[,] belen = new char[filas, columnas];

            for (int fila = 0; fila < filas; fila++)
            {
                string linea = Console.ReadLine();
                for (int col = 0; col < columnas; col++)
                {
                    belen[fila, col] = linea[col];
                    if (linea[col] == 'C')
                    {
                        xInicial = col;
                        yInicial = fila;
                    }
                }
            }

            if (EsResoluble(belen, xInicial, yInicial))
                Console.WriteLine("ACEPTABLE");
            else
                Console.WriteLine("NO ACEPTABLE");

            Console.ReadLine(); // Separador

            tamanyo = Console.ReadLine(); // Siguiente dato real
        }
    }

    static bool EsResoluble(char[,] belen, int xInicial, int yInicial)
    {
        int filas = belen.GetLength(0);
        int columnas = belen.GetLength(1);

        if (yInicial < 0 || yInicial >= filas        // Fila no válida
            || xInicial < 0 || xInicial >= columnas  // Columna no válida
            || belen[yInicial, xInicial] == 'X'      // Ocupada
            || belen[yInicial, xInicial] == 'V')     // Visitada
        {
            return false;
        }

        if (belen[yInicial, xInicial] == 'S')  // Si llegamos a la salida, se puede resolver
        {
            return true;
        }

        belen[yInicial, xInicial] = 'V'; // Si no, marcamos esta casilla como visitada

        // Y miramos en las 4 casillas que reodean a la actual
        if (EsResoluble(belen, xInicial - 1, yInicial)
            || EsResoluble(belen, xInicial + 1, yInicial)
            || EsResoluble(belen, xInicial, yInicial - 1)
            || EsResoluble(belen, xInicial, yInicial + 1))
        {
            return true;
        }

        return false;
    }
}
