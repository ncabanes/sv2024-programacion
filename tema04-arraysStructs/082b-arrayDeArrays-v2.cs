// 82. Crea una variante del programa anterior, que pregunte al usuario cuántos datos guardará
// en un primer bloque de números reales de doble precisión, luego cuántos datos guardará
// en un segundo bloque, y finalmente pida todos esos datos. Los debe guardar en un array de arrays.
// Después mostrará el promedio de los valores que hay guardados en el primer subarray,
// luego el promedio de los valores en el segundo subarray y finalmente el promedio global.

// Pablo (...), retoques menores por Nacho

// Versión 2: variante más avanzada


using System;

class MainClass{
    static void Main(){
        const int FILAS = 2;
        
        Console.WriteLine("¿Cuántos datos quieres guardar en el primer bloque?");
        int elementosPrimerBloque = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("¿Cuántos datos quieres guardar en el segundo bloque?");
        int elementosSegundoBloque = Convert.ToInt32(Console.ReadLine());
        
        double[][] arrayDeArrays = new double[FILAS][];
        arrayDeArrays[0] = new double[elementosPrimerBloque];
        arrayDeArrays[1] = new double[elementosSegundoBloque];

        // Pedimos datos
        Console.WriteLine("Introduce los datos de la matriz");
        for(int i = 0; i < FILAS; i++)
        {
            for(int j = 0; j < arrayDeArrays[i].Length; j++)
            {
                Console.Write( "Dime el dato de la fila {0}, columna {1}: ",
                    i+1, j+1);
                arrayDeArrays[i][j] = Convert.ToDouble(Console.ReadLine());
            }
        }
        
        // Promedio de cada bloque
        for(int f = 0; f < FILAS; f++)
        {
            double suma = 0;
            foreach (double element in arrayDeArrays[f])
            {
                suma += element;
            }
            Console.WriteLine("El promedio de los valores del bloque {0} es: {1}", 
                f+1, (suma / elementosPrimerBloque).ToString("0.0"));
        }
        
        // Calculamos promedio global
        double sumaGlobal = 0;
        foreach (double[] element in arrayDeArrays)
        {
            foreach (double el in element)
            {
                sumaGlobal += el;
            }
        }
        Console.WriteLine("El promedio global es: {0}", 
            (sumaGlobal / (elementosPrimerBloque + elementosSegundoBloque)).ToString("0.0"));
    }
}
