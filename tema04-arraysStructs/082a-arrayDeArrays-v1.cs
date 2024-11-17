/* 82. Crea una variante del programa anterior, que pregunte al usuario cuántos 
datos guardará en un primer bloque de números reales de doble precisión, luego 
cuántos datos guardará en un segundo bloque, y finalmente pida todos esos 
datos. Los debe guardar en un array de arrays. Después mostrará el promedio de 
los valores que hay guardados en el primer subarray, luego el promedio de los 
valores en el segundo subarray y finalmente el promedio global.

Luis (...), retoques menores por Nacho  */

// Versión 1: ejemplo básico

using System;

class ArraysDeArrays
{
    static void Main()
    {
        double[][] datos = new double [2][];
        double suma1 = 0;
        double suma2 = 0;
        
        Console.Write( "¿Cuántos datos vas a meter en el primer bloque?: " );
        int bloque1 = Convert.ToInt32( Console.ReadLine() );
        datos[0] = new double [ bloque1 ];
        
        Console.Write( "¿Cuántos datos vas a meter en el segundo bloque?" );
        int bloque2 = Convert.ToInt32( Console.ReadLine() );
        datos[1] = new double [ bloque2 ];
        
        for (int fila = 0; fila < datos.Length; fila++)
        {
            for (int columna = 0; columna < datos[fila].Length; columna++)
            {
                Console.Write( "Introduce los datos de la fila {0} columna {1}: ",
                    fila+1, columna+1 );
                datos[fila][columna] = Convert.ToDouble( Console.ReadLine());
            }
        } 
        
        for (int columna = 0; columna < datos[0].Length; columna++)
        {
            suma1 += datos [ 0][ columna ];
        }
        double media1 = suma1 / datos[0].Length;
        
      
        for (int columna = 0; columna < datos[1].Length; columna++)
        {
            suma2 += datos [ 1 ][columna ];
        }
        double media2 = suma2 / datos[1].Length;
        
        double media3 = ( suma1 + suma2 ) / (datos[0].Length + datos[1].Length);
        Console.Write( "La media de la fila 1 es: " + media1 + ", la media de" +
        " la fila 2 es: "+media2 + " y la media total: "+ media3 );
    }
}
