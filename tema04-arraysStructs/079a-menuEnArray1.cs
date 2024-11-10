/* 
  Crea una nueva versión del programa del menú (ejercicio 65), en el que los 
  textos de los menús estarán almacenados en un array.
*/

// Versión 1: 
//    Salir como opción 0, se muestra de forma distinta
//    Sin comprobación de errores

using System;

class Ejercicio79
{
    static void Main()
    {
        byte opcion;
        string [] menu = {"Salir", "Jugar nueva partida", 
            "Cargar partida", "Ver mejores puntuaciones"};
        
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine(i + " " + menu[i]);
        }
        Console.WriteLine(0 + " " + menu[0]);
        
        Console.Write("Opción? ");
        opcion = Convert.ToByte(Console.ReadLine());
        
        Console.WriteLine("Ha escogido la opción "+ opcion
            + ": " + menu[opcion]);
    }
}
