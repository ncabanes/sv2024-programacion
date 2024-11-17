// 81. Crea un programa que pida al usuario 10 números reales de doble precisión,
// los guarde en una matriz bidimensional de 2x5 datos,
// y luego muestre el promedio de los valores que hay guardados en la primera mitad de la matriz,
// luego el promedio de los valores en la segunda mitad de la matriz y finalmente el promedio global.

// Pablo (...), retoques menores por Nacho

// Versión 2: variante más avanzada

using System;

class MainClass{
    static void Main(){
        
        const int FILAS = 2, COLUMNAS = 5;
        double[,] arrayBidim = new double[FILAS,COLUMNAS];
        
        // Pedir datos
        Console.WriteLine("Introduce los 10 números de la matriz");
        for(int i = 0; i < FILAS; i++)
        {
            for(int j = 0; j< COLUMNAS; j++)
            {
                Console.Write( "Dime el dato de la fila {0}, columna {1}: ",
                    i+1, j+1);
                arrayBidim[i,j] = Convert.ToDouble(Console.ReadLine());
            }
        }
        
        // Promedio por cada fila
        for(int f = 0; f < FILAS; f++)
        {
            double suma = 0;
            for(int c = 0; c < COLUMNAS; c++)
            {
                suma += arrayBidim[f,c];
            }
            Console.WriteLine("El promedio de la fila {0} de la matriz es: {1}", 
                f+1, suma / COLUMNAS);
        }
        
        // Promedio valores totales
        double sumaGlobal = 0;
        foreach(double num in arrayBidim)
        {
            sumaGlobal += num;
        }
        Console.WriteLine("El promedio de la matriz completa es: {0}", 
            sumaGlobal / arrayBidim.Length);
    }
}
