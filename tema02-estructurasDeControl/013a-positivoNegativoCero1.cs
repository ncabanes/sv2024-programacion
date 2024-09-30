/* Jorge (...)
 * 
 * Ejercicio 13 - Crea un programa en C# que pida al usuario un número 
 * entero y responda si es un número positivo, negativo o cero, usando 
 * "if" y "else" consecutivos.*/

using System;

class Ejercicio13
{
    static void Main()
    {
        int num;
        
        Console.Write("Introduce un número entero: ");
        num=Convert.ToInt32(Console.ReadLine());
        
        if(num > 0)
            Console.WriteLine("Es un número positivo");
        else if (num < 0)
            Console.WriteLine("Es un número negativo");
        else
            Console.WriteLine("Es cero");
    }
}
