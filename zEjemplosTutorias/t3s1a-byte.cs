/*
Pide al usuario que introduzca tres números enteros entre el 100 y el 
200. Calcula su suma, guárdala en una variable y muéstrala. Optimiza el 
tipo de datos, para que el espacio ocupado sea el menor posible.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        byte n1, n2, n3;
    
        Console.WriteLine("Dime el primer número");
        n1 = Convert.ToByte( Console.ReadLine() );
        
        Console.WriteLine("Dime el segundo número");
        n2 = Convert.ToByte( Console.ReadLine() );
        
        Console.WriteLine("Dime el tercero número");
        n3 = Convert.ToByte( Console.ReadLine() );
        
        int suma = n1+n2+n3;
        Console.WriteLine("La suma es {0}", suma);
    }
}

/*
Dime el primer número
200
Dime el segundo número
190
Dime el tercero número
180
La suma es 570
*/
