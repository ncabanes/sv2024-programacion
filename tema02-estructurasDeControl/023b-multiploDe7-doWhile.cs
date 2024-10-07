/* Haz un programa que diga al usuario "Introduce un múltiplo de 7", y se lo 
pida tantas veces como sea necesario hasta que realmente introduzca un número 
que sea múltiplo de 7, repitiendo en caso de que introduzca un número 
incorrecto. */

// Giorgi (...)

using System;

class Ej23
{
    static void Main()
    {
        int num;
        
        do
        {
            Console.WriteLine("Dime un numero multiplo de 7: ");
            num = Convert.ToInt32(Console.ReadLine());
        
            if (num % 7 != 0)
            {
                Console.WriteLine("El numero debe ser multiplo de 7");
            }
            
        }
        while (num % 7 != 0);
        Console.WriteLine("El numero es divisible por 7.");
    }
}
