/*
Crea una función "MostrarMenu", que muestre 3 opciones de una supuesta 
agenda (añadir, buscar, salir). Úsala desde "Main".
*/

using System;

class Ejemplo 
{
    static void MostrarMenu() 
    {
        Console.WriteLine("1 - Añadir");
        Console.WriteLine("2 - Buscar");
        Console.WriteLine("0 - Salir");
    }

    static void Main() 
    {
        MostrarMenu();
        
        Console.WriteLine("Hasta luego!");
    }
}

/*
1 - Añadir
2 - Buscar
0 - Salir
Hasta luego!
*/
