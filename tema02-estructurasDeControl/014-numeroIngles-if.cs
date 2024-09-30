/* Sara (...)
 * 
 * Crea un programa en C# que pida un número del 1 al 10 al usuario y 
 * muestre su nombre en inglés, usando "if". Por ejemplo, si el usuario
 * introduce el número 5, tu programa deberá responder "Five". Si 
 * introduce un número no válido (el 14 o el -5, por ejemplo), le 
 * responderá "No conozco ese número". */

using System;

class NumeroIngles
{
    static void Main()
    {
        int n;
        
        Console.WriteLine("Dime un número del 1 al 10");
        n = Convert.ToInt32(Console.ReadLine());
        
        if (n == 1)
        {
            Console.WriteLine("One");
        }
        else if (n == 2)
        {
            Console.WriteLine("Two");
        }
        else if (n == 3)
        {
            Console.WriteLine("Three");
        }
        else if (n == 4)
        {
            Console.WriteLine("Four");
        }
        else if (n == 5)
        {
            Console.WriteLine("Five");
        }
        else if (n == 6)
        {
            Console.WriteLine("Six");
        }
        else if (n == 7)
        {
            Console.WriteLine("Seven");
        }
        else if (n == 8)
        {
            Console.WriteLine("Eight");
        }
        else if (n == 9)
        {
            Console.WriteLine("Nine");
        }
        else if (n == 10)
        {
            Console.WriteLine("Ten");
        }
        else
        {
            Console.WriteLine("No conozco ese número");
        }
    }
}
        
        
        
