// Tutoría del tema 2, semana 1 (if, switch)
// Ejercicio 3:
//   Pide al usuario que introduzca un número entero. 
//   Respóndele si es positivo, negativo o cero.
// Versión 2:
//   Con "else" (recomendable)

using System;

class PosNeg0bis
{
    static void Main()
    {
        int n;
      
        Console.WriteLine("Dime un número");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if (n > 0)
            Console.WriteLine("Es positivo");
        else if (n < 0)
            Console.WriteLine("Es negativo");
        else 
            Console.WriteLine("Es cero");
    }
}
