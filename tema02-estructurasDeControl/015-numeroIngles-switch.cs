/* Sara Casas Agra
 * 
 * Crea una variante del ejercicio anterior, que emplee "switch" en vez 
 * de "if": pedirá un número del 1 al 10 al usuario y mostrará su nombre 
 * en inglés, usando "switch". Por ejemplo, si el usuario introduce el 
 * número 5, tu programa deberá responder "Five". Si introduce un número
 * no válido (el 14 o el -5, por ejemplo), responderá "No conozco ese 
 * número. */

using System;

class NumeroIngles
{
    static void Main()
    {
        int n;
        
        Console.WriteLine("Dime un número del 1 al 10: ");
        n = Convert.ToInt32(Console.ReadLine());

        switch(n)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            case 10: Console.WriteLine("Ten"); break;
            default: Console.WriteLine("No conozco ese número"); break;
        }
    }
}
            
