/*
Reto 03: Mediana

Problema a resolver

En estadística, se llama "mediana" de un conjunto de datos al valor 
central de los datos ordenados. Por ejemplo, para los datos 2, 4 y 3, 
la mediana sería 3, que es la dato central cuando se ordenan. Si la 
cantidad de datos es par, será la media de los datos centrales, por lo 
que la mediana de 20, 40, 10, 30 sería 25 (la media de 20 y 30). Tu 
programa deberá calcular las medianas de los datos que se le indiquen.

Datos de entrada

Cada línea de entrada contendrá una serie de números enteros largos, 
separados por un único espacio en blanco. No existirá un contador de 
casos, sino que la ejecución deberá repetirse hasta que una línea de 
entrada contenga exclusivamente el dato -1 (que no se procesará).

Ejemplo de entrada

2 4 3
20 40 10 30
12
1 2 3 4 5 6 7 8 9
9 8 7 6 5 4 3 2
12345679 12345678 1234567891011
-1 -2 2 1
-1

Salida que se debería obtener con esa entrada:

3
25
12
5
5,5
12345679
0

*/

// Versión 2: con Array.ConvertAll y Array.Sort

using System;

class Mediana
{
    static void Main()
    {
        string entrada;
        
        do
        {
            entrada = Console.ReadLine();
            if (entrada != "-1")
            {
                string[] detalles = entrada.Split();
                
                // Volcamos datos a un array de números
                long[] numeros = Array.ConvertAll(detalles, 
                    d => Convert.ToInt64(d));
                    
                // Ordenamos
                Array.Sort(numeros);
                
                // Y finalmente, obtenemos y mostramos la mediana
                int centro = numeros.Length / 2;
                double mediana;

                if (numeros.Length % 2 == 0)
                {
                    mediana = (numeros[centro - 1] + numeros[centro]) / 2.0;
                }
                else
                {
                    mediana = numeros[centro];
                }

                Console.WriteLine(mediana);
            }
        }
        while (entrada != "-1");
    }
}
