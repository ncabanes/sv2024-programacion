/* Ejercicio 06: Crea un programa que pida al usuario 2 números y 
muestre su diferencia (el primer número menos el segundo número).

Claudia (...)
*/

using System;

class Calcular
{
    static void Main()
    {
        int numero01, numero02;
        int diferencia;
        
        Console.WriteLine("Introduce el primer número");
        numero01 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Introduce el segundo número");
        numero02 = Convert.ToInt32(Console.ReadLine());
        
        diferencia = numero01 - numero02;
        
        Console.WriteLine("La diferencia de {0} y {1} es {2}", 
            numero01, numero02, diferencia);
    }
}
