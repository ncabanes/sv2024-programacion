/*
Crea un programa llamado "sumar", que reciba dos números enteros en 
línea de comandos y muestre su suma, como en este ejemplo:

sumar 123 456
579
*/

using System;

class Ejemplo
{
    static void Main(string[] args)
    {
        // int n1 = Convert.ToInt32( Console.ReadLine() );
        // int n2 = Convert.ToInt32( Console.ReadLine() );
        if (args.Length != 2)
        {
            Console.WriteLine("Indica dos números a sumar");
        }
        else
        {
            int n1 = Convert.ToInt32(args[0]);
            int n2 = Convert.ToInt32(args[1]);
            Console.WriteLine(n1 + n2);
        }
    }
}

