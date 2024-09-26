// Tutoría del tema 2, semana 1 (if, switch)
// Ejercicio 1:
// Pide al usuario que introduzca un número entero. 
//   Respóndele si es negativo o si no lo es.
// Versión 2:
//   if+else, uso de llaves

using System;

class NumeroNegativo2
{
    static void Main()
    {
        int numero;
        
        Console.WriteLine ("Dime un número");
        numero = Convert.ToInt32( Console.ReadLine());
        
        if (numero < 0)
        {
            Console.WriteLine ("Es negativo");
            Console.WriteLine("Puedes usar positivos");
        }
        else
        {
            Console.WriteLine ("No es negativo");
        }
    }
}
