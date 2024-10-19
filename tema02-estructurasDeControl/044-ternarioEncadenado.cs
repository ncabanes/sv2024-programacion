/*44. Pide al usuario dos números, que guardarás en variables "n1" y 
"n2". Dale a una variable llamada "pares" el valor 2 si los dos son 
pares, 1 si sólo uno es par o 0 si ninguno es par. Hazlo de dos formas: 
primeros con dos "if" encadenados y luego con dos operadores ternarios 
encadenados.*/

// Maria Blanca (...)

using System;

class Ejercicio44
{
    static void Main()
    {
        int n1, n2;
        int pares;
      
        Console.WriteLine("Dime un número: ");
        n1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime un número: ");
        n2=Convert.ToInt32(Console.ReadLine());
      
        Console.WriteLine("Primera forma: ");
        if ( n1 %2 == 0 && n2 % 2 == 0) 
        {
            pares = 2;
        } 
        else 
            if ( n1 %2 != 0 && n2 % 2 != 0) 
            {
                pares = 0;
            } 
            else 
            {
                pares = 1;
            }
      
        Console.WriteLine(pares);
      
        Console.WriteLine("Segunda forma, con operadores ternarios: ");
      
        pares = n1 % 2 == 0 && n2 % 2 == 0
            ? 2
            :  n1 %2 != 0 && n2 % 2 != 0
                ? 0
                : 1;
            
        Console.WriteLine(pares);   
    }
}
