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
        
        for (int deportista = 0; deportista < datos.GetLength(0); deportista++)
        {
            for (int intento = 0; intento < datos.GetLength(1); intento++)
            {
                Console.WriteLine("Dame el dato del deportista {0}, intento {1}",
                    deportista+1, intento+1);
                datos[deportista, intento] = Convert.ToInt32( Console.ReadLine() );
            }
        }
        
        int participante = 1;
        int maximo = datos[participante,0];
        for (int intento = 0; intento < 5; intento++)
        {
            if (datos[participante,intento] > maximo)
                maximo = datos[participante,intento];
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
