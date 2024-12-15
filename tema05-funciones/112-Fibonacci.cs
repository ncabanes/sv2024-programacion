/*
112. Crea una función recursiva que calcule un cierto elemento de la serie de 
Fibonacci, en la que los dos primeros elementos son 0, y cada elemento 
posterior es la suma de los dos que le preceden (n[0] = 0, n[1] = 1,  n[i] = 
n[i-1] + n[i-2]).
*/

// Jorge (...)

using System;

class Ejercicio112
{
    static int Fibonacci(int n)
    {
        if(n<=1)
            return n;
            
        return Fibonacci(n-1)+Fibonacci(n-2);
    }
    
    static void Main()
    {
        Console.Write("Introduce un número para calcular fibonacci: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(Fibonacci(n));
    }
}
