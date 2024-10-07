        /* 
        =======================================
                      Javier (...)        
                  Clase: Programación        
               Curso: 1 Semi presencial DAM  
                Instituto: IES San Vicente   
                    Ejercicio 23           
        =======================================
        */
/*Haz un programa que diga al usuario "Introduce un múltiplo de 7"
 * y se lo pida tantas veces como sea necesario hasta que realmente
 * introduzca un número que sea múltiplo de 7, 
 * repitiendo en caso de que introduzca un número incorrecto.
 */

using System;

class Multiplode7
{
    static void Main()
    {
        int n;
        
        Console.WriteLine("Introduce un múltiplo de 7");
        n = Convert.ToInt32(Console.ReadLine());
        
        while (n % 7 != 0)
        {
            Console.WriteLine ("No es múltiplo de 7");
        
            Console.WriteLine("Introduce un múltiplo de 7");
            n = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("¡Perfecto! Has introducido un múltiplo de 7.");
    }
}
