/* Pide al usuario una frase y muestra el resultado de hacer una suma 
lógica, bit a bit, del número 32 sobre cada una de sus letras.

*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        string texto;
        
        Console.Write("Dime un texto: ");
        texto = Console.ReadLine();
        
        // Minúsculas
        foreach(char c in texto)
        {
            Console.Write( (char) (c | 32 ));  // c | 0b0001_0000
        }
        Console.WriteLine();
        
        // Mayúsculas
        /*
        foreach(char c in texto)
        {
            Console.Write( (char) (c & 0b1110_1111));
        }
        Console.WriteLine();
        */
    }
}

/*
Dime un texto: HOLA soy yo
hola soy yo
*/

