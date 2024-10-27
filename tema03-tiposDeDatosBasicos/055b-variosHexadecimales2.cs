/*
55. Pide al usuario dos números enteros cortos y muestra todos los 
números que hay entre ellos, ambos incluidos, en hexadecimal, en la 
misma línea, separados por un espacio. Por ejemplo, si introduce 8 y 
11, deberás mostrar "8 9 a b". El programa se debe comportar 
correctamente si introduce los números en orden contrario, es decir, si 
primero indica 11 y 8 en vez de 8 y 11.
*/

// Pablo (...)

using System;
class MainClass
{
    static void Main()
    {
        Console.WriteLine("Dime el primer número entero: ");
        short n1 = Convert.ToInt16(Console.ReadLine()); 
        
        Console.WriteLine("Dime el segundo número entero: ");
        short n2 = Convert.ToInt16(Console.ReadLine());
        
        short min = (n1 < n2) ? n1 : n2;
        short max = (n1 > n2) ? n1 : n2;
        
        for(short i = min; i <= max; i++)
        {
            Console.Write("{0} ", Convert.ToString(i, 16));
        }       
    }
}
