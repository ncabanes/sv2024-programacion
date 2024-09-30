/* 12. Crea una versión alternativa del programa anteior (que pida al 
usuario un número entero y responda si es múltiplo de 10 o no lo es), 
empleando las órdenes "if" y "else". Al final del programa añade un 
comentario en el que digas qué version te parece más eficiente y por 
qué. */

// Eliseo (...)

using System;

class Ejercicio2 
{
    static void Main() 
    {
      
        Console.WriteLine("Introduce un numero entero: ");
        int numero = Convert.ToInt32( Console.ReadLine() );

        if (numero % 10 == 0)
        {
            Console.WriteLine("El numero es multiplo de 10.");
        }
        else
        {
            Console.WriteLine("El numero no es multiplo de 10.");
        }      
    }
}

// Con else me parece mas rapido, ademas de que si tienes que 
// utilizar varios if, es mucho mas intuitivo usar else.
