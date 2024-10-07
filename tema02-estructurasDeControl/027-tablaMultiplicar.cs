//Nerea (...)

/* 27. Escribe un programa en C# que pida al usuario un número entero y 
 * muestre su tabla de multiplicar, usando "while"*/
 
using System;
 
class Ejercicio27
{
    static void Main()
    {
        Console.Write("Tabla de multiplicar del número: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        
        while (a < 11)
        {
            Console.WriteLine("{0} x {1} = {2}", n, a, n*a );
            a++;
        }
    }
}
