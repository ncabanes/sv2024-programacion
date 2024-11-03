/* FRANCISCO (...)

70. Crea un programa en C# que pida al usuario una cadena y la muestre
encriptada de dos maneras diferentes: primero restando 1 a cada carácter, luego
con la operación XOR 1.
 */

using System;
class Ejercicio_70
{
    static void Main()
    {
        Console.WriteLine ("Escribe un texto.");
        string texto = Console.ReadLine();
        Console.WriteLine();

        Console.Write("El resultado de restar 1 a cada carácter es: ");
        foreach (char letra in texto)
        {
            char resta1 =(char) (letra-1);
            Console.Write(resta1);
        }
        Console.WriteLine();

        Console.Write("El resultado de la operación \"XOR\" 1 es: ");
        foreach(char letra in texto)
        {
            char xor =(char)(letra^1);
            Console.Write(xor);
        }
        Console.WriteLine();
    }
}






