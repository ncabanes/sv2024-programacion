/*
Pide al usuario dos números enteros. Calcula (y muestra) el menor de 
ellos. Hazlo primero con "if" y luego con el "operador ternario" u 
"operador condicional".
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        int a, b;
        int menor;
        
        Console.WriteLine("Dime el primer número");
        a = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("Dime el segundo número");
        b = Convert.ToInt32( Console.ReadLine() );
        
        if (a <= b)
            menor = a;
        else
            menor = b;
        
        Console.WriteLine(menor);
        
        menor = a <= b ? a : b ;
        Console.WriteLine(menor);
    }
}

