/* Pide al usuario dos enteros y muestra su producto, filtrando errores 
con "TryParse".
*/

using System;

class Ejemplo 
{
    
    static void Main() 
    {
        int n1, n2;
        
        Console.WriteLine("Dime un número");      
        if (Int32.TryParse(Console.ReadLine(), out n1))
        {
            Console.WriteLine("Dime otro número");
            if (Int32.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Su producto es " + (n1 * n2));
            }
        }
        else
            Console.WriteLine("El primer número no es válido");
    }
}

/*
Dime un número
10
Dime otro número
20
Su producto es 200
*/
