/* 81. Crea un programa que pida al usuario 10 números reales de doble 
precisión, los guarde en una matriz bidimensional de 2x5 datos, y luego muestre 
el promedio de los valores que hay guardados en la primera mitad de la matriz, 
luego el promedio de los valores en la segunda mitad de la matriz y finalmente 
el promedio global.

Luis (...)  */

// Versión 1: ejemplo básico

using System;

class MatrizBidimensional
{
    static void Main()
    {
        double[,] datos = new double[2,5];
        double suma1 = 0;
        double suma2 = 0;
        
        for (int fila = 0; fila < 2; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                Console.Write( "Dime el dato de la fila {0}, columna {1}: ",
                    fila+1, columna+1);
                datos[fila, columna] = Convert.ToDouble( Console.ReadLine() );
            }
        }
        
        int fila1 = 0;
        for (int columna = 0; columna < 5; columna++)
        {
            suma1 += datos [ fila1, columna ];
            
        }
        double media1 = suma1 / 5;
        
        int fila2 = 1;
        for (int columna = 0; columna < 5; columna++)
        {
            suma2 += datos [ fila2, columna ];
        }
        double media2 = suma2 / 5;
        
        double media = ( media1 + media2 ) / 2;
        Console.Write( "La media de la fila 1 es: " + media1 + ", la media de" +
        " la fila 2 es: "+media2 + " y la media total: "+ media );
    }
}
