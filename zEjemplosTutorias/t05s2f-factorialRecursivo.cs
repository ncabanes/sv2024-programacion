/* Prueba esa función "Factorial", que calcula el factorial de un 
número. Comprueba si el factorial de 4 vale 24.
*/

using System;

class Ejemplo 
{
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
            
        return n * Factorial(n-1);
    }
    
    static void Main() 
    {
        Console.WriteLine( Factorial(4) );
    }
}

/*
24

Process is terminated due to StackOverflowException.
*/
