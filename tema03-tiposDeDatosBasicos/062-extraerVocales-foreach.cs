// José (...)

/*
Escribe un programa que pregunte al usuario una palabra y muestre las 
vocales en minúsculas (sin acentuar) que contenga. Por ejemplo, si el 
usuario introduce "Programación", el programa escribirá "oaai".
*/

using System;

class Ejercicio62
{
    static void Main()
    {
        string p;
        
        Console.Write("Introduce una palabra: ");
        p = Console.ReadLine();
        
        foreach(char c in p)
        {
            if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u'))
                Console.Write(c);
            
        }
    }
}
