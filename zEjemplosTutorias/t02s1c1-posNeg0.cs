// Tutoría del tema 2, semana 1 (if, switch)
// Ejercicio 3:
//   Pide al usuario que introduzca un número entero. 
//   Respóndele si es positivo, negativo o cero.
// Versión 1:
//   Sin "else" (más lento, no lo haremos)

using System;

class PosNeg0
{
    static void Main()
    {
        int n;
      
        Console.WriteLine("Dime un número");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if (n > 0)
            Console.WriteLine("Es positivo");
        if (n < 0)
            Console.WriteLine("Es negativo");
        if (n == 0)
            Console.WriteLine("Es cero");
    }
}

