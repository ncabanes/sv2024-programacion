using System;

class SumaDeDos
{
    static void Main()
    {
        int a;
        int b;
        int suma;
        
        Console.WriteLine("Primer número a sumar?");
        a = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("Segundo número a sumar?");
        b = Convert.ToInt32( Console.ReadLine() );
        
        suma = a + b;
        Console.WriteLine("La suma es:");
        Console.WriteLine(suma);
    }
}
