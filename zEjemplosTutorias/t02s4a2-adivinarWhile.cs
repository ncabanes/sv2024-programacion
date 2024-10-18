/*
Pide un número al usuario un número del 0 al 9. Dale 5 oportunidades 
para acertar como máximo (sin avisarle de si se pasa o se queda corto).
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        int numeroAAdivinar = 4;
        int n;
        
        
        int i = 1;
        
        do
        {
            Console.Write("Dime tu intento... ");
            n = Convert.ToInt32( Console.ReadLine() );
            
            if (n == numeroAAdivinar)
            {
                Console.WriteLine("Has acertado");
            }
            else
            {
                Console.WriteLine("No has acertado");
            }
            i++;
        }
        while ( i <= 5 && n != numeroAAdivinar );
        
        //if (n == numeroAAdivinar)
        //{
        //    // ...
        //}
        
    }
}
