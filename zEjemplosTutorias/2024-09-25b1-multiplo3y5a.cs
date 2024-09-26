// Tutoría del tema 2, semana 1 (if, switch)
// Ejercicio 2:
//   Pide al usuario que introduzca un número entero. 
//   Respóndele si es múltiplo a la vez de 3 y de 5.
// Versión 1:
//   Sólo lo que se pide, ¿es mútiplo o no?
//   Novedad: declaramos la variable en el uso, no antes (menos recomendable)

using System;
                    
class MultiploDe3y5
{
    static void Main()
    {
        Console.WriteLine("Dime un número");
        int x = Convert.ToInt32( Console.ReadLine() );
        
        if ( (x % 3 == 0)  &&  (x % 5 == 0) )
        {
            Console.WriteLine("Es múltiplo de 3 y de 5");
        }
        else
        {
            Console.WriteLine("No es múltiplo de 3 y de 5 a la vez");
        }
    }
}

