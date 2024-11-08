/* Prepara un array con espacio para hasta 1000 números enteros. 
Permite que el usuario introduzca tantos como quiera, hasta terminar 
pulsando "Intro" sin ningún número. Cuando termine, mostrarás todos los 
números introducidos.

*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        const int CAPACIDAD = 1000;
        int[] numeros = new int[CAPACIDAD];
        int cantidad = 0;
        string respuesta;
        
        do
        {
            Console.Write("Dime un número (Intro para terminar): ");
            respuesta = Console.ReadLine();
            if (respuesta != "")
            {
                int n = Convert.ToInt32( respuesta );
                if (cantidad < CAPACIDAD)
                {
                    numeros[cantidad] = n;
                    cantidad++;
                }
                else
                    Console.WriteLine("Base de datos llena");
            }
        }
        while (respuesta != "");
        
        Console.Write("Tus datos son:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write(" " +numeros[i]);
        }
        Console.WriteLine();
    }
}

/*
Dime un número (Intro para terminar): 3
Dime un número (Intro para terminar): 6
Dime un número (Intro para terminar): 9
Dime un número (Intro para terminar): 2
Dime un número (Intro para terminar): 4
Dime un número (Intro para terminar): 8
Dime un número (Intro para terminar):
Tus datos son: 3 6 9 2 4 8
*/
