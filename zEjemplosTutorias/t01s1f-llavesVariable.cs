using System;

class Ejemplo05
{
    static void Main()
    {
        int numero1 = 5, numero2 = 7;
        int suma = numero1+numero2;
        
        Console.Write("12 * 11 =");
        Console.WriteLine(12*11);
        
        Console.Write("La suma de ");
        Console.Write(numero1);
        Console.Write(" y ");
        Console.Write(numero2);
        Console.Write(" es ");
        Console.WriteLine(suma);
        
        System.Console.WriteLine(
           "La suma de {0} y {1} es {2}", 
           numero1, numero2, suma);
        
        // Alternativa, sólo en versiones recientes de C#
        System.Console.WriteLine(
           $"La suma de {numero1} y {numero2} es {suma}");
    }
}
