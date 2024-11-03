/*
Pide un número al usuario un número del 0 al 9. Dale 5 oportunidades 
para acertar como máximo (sin avisarle de si se pasa o se queda corto).

Mejora el ejercicio anterior, para que avise al usuario de si se 
pasa o se queda corto. A cambio, tendrá sólo 3 intentos.
 
Mejora el ejercicio de adivinar números, para que no falle si se 
introduce un texto en vez de un número.


*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        int numeroAAdivinar = 4;
        int n = 0;
        
        
        int i = 1;
        int numeroValido;

        
        do
        {
            do
            {
                numeroValido = 1;
                try
                {
                    Console.Write("Dime tu intento... ");
                    n = Convert.ToInt32( Console.ReadLine() );
                }
                catch(FormatException)
                {
                    Console.WriteLine("No es un número válido");
                    numeroValido = 0;
                }
            }
            while (numeroValido == 0);
            
            if (n == numeroAAdivinar)
            {
                Console.WriteLine("Has acertado");
            }
            else if (n < numeroAAdivinar)
            {
                Console.WriteLine("Te has quedado corto");
            }
            else
            {
                Console.WriteLine("Te has pasado");
            }
            i++;
        }
        while ( i <= 3 && n != numeroAAdivinar );
        
        //if (n == numeroAAdivinar)
        //{
        //    // ...
        //}

        
    }
}
