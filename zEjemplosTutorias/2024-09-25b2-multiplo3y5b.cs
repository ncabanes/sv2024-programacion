// Tutoría del tema 2, semana 1 (if, switch)
// Ejercicio 2:
//   Pide al usuario que introduzca un número entero. 
//   Respóndele si es múltiplo a la vez de 3 y de 5.
// Versión 2:
//   Añadimos el caso de que sea múltipo de uno o del otro
//   (pero no de los dos)

using System;
                    
class MultiploDe3y5bis
{
    static void Main()
    {
        Console.WriteLine("Dime un número");
        int x = Convert.ToInt32( Console.ReadLine() );
        
        if ( (x % 3 == 0)  &&  (x % 5 == 0) )
        {
            Console.WriteLine("Es múltiplo de 3 y de 5");
        }
        else if ( (x % 3 == 0)  ||  (x % 5 == 0) )
        {
            Console.WriteLine("Es múltiplo de 3 o de 5, pero no de los 2");
        }
        else
        {
            Console.WriteLine("No es múltiplo de 3 ni de 5");
        }
    }
}
