/* 
  Crea una nueva versión del programa del menú (ejercicio 65), en el que los 
  textos de los menús estarán almacenados en un array.
*/

// Versión 2: 
//    Salir como opción 0, mostrado con "operador módulo"
//    Con comprobación de errores

using System;

class Ejercicio79
{
    static void Main()
    {
        byte opcion;
        string [] menu = {"Salir", "Jugar nueva partida", 
            "Cargar partida", "Ver mejores puntuaciones"};
        
        for (int i = 1; i <= 4; i++)
            Console.WriteLine(i%4 + " " + menu[i%4]);
        Console.Write("Opción? ");
        opcion = Convert.ToByte(Console.ReadLine());
        
        if (opcion <= 0 || opcion >= 4)
            Console.WriteLine("Opción no válida");
        else
            Console.WriteLine("Ha escogido la opción "+ opcion
                + ": " + menu[opcion]);
    }
}
