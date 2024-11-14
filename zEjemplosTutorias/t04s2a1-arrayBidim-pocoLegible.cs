/*
Pide al usuario 2 bloques de 5 enteros. Luego muestra el máximo del 
segundo bloque.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        int[,] datos = new int[2,5];
        
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Dame el dato de la fila {0}, col {1}",
                    i+1, j+1);
                datos[i, j] = Convert.ToInt32( Console.ReadLine() );
            }
        }
        
        int maximo = datos[1, 0];
        for (int i = 0; i < 5; i++)
        {
            if (datos[1,i] > maximo)
                maximo = datos[1,i];
        }
        Console.WriteLine("El máximo de la segunda fila es "+maximo);
    }
}

/*
Dame el dato de la fila 1, col 1
10
Dame el dato de la fila 1, col 2
20
Dame el dato de la fila 1, col 3
30
Dame el dato de la fila 1, col 4
40
Dame el dato de la fila 1, col 5
50
Dame el dato de la fila 2, col 1
1
Dame el dato de la fila 2, col 2
5
Dame el dato de la fila 2, col 3
4
Dame el dato de la fila 2, col 4
3
Dame el dato de la fila 2, col 5
2
El máximo de la segunda fila es 5
*/
