/* --------------------
 * MARTA (...)
 * --------------------
 * 
 * Muestra las tablas de multiplicar de los números del 0 al 10, 
 * utilizando "for". Debe haber una línea en blanco separando cada tabla
 *  de multiplicar de la siguiente.
 *
 */ 

using System;

class Ejercicio33
{
    static void Main()
    {
        //Primero iteramos por el número de tabla (incluyendo 0)
        for (int tabla=0; tabla<=10; tabla++)
        {
            //Luego iteramos por el mutiplicando de la tabla
            for (int i=0; i<=10 ; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", tabla, i, tabla*i);
            }
            //Separamos cada tabla con una línea en blanco
            Console.WriteLine();
        }
    }
}
