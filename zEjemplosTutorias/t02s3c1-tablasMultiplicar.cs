// Tutoría del tema 2, semana 3 (for, bucles anidados)
// Ejercicio 3

/* Prueba el ejemplo anterior: escribe las tablas 
 * de multiplicar del 1 al 10.
 */

using System;

class TablasMult
{
    static void Main() 
    {
        for (int tabla = 1; tabla <= 10; tabla ++)
        {
            for (int n = 0; n <= 10; n++)
            {
                Console.WriteLine("{0} x {1} = {2}", 
                    tabla, n, tabla*n);
            }
        }
    }
}
