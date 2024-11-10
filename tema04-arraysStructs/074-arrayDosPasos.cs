/* 74. Crea un programa que pregunte al usuario cuántos datos (cadenas de 
texto) va a introducir, reserve espacio para todos ellos, se los pida uno a uno 
y finamente los muestre en orden contrario.

Luis (...)  */

using System;

class MostrarCadenas
{
    static void Main()
    {
        string[] textos;
        int cantidad;

        Console.Write( "¿Cuántos datos va a introducir? " );
        cantidad = Convert.ToInt32( Console.ReadLine() );
        textos = new string[cantidad];
        
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write( "Introduce una cadena: " );
            textos[i] = Console.ReadLine();
        }

        Console.WriteLine( "Las cadenas en orden inverso son:" );
        for (int i = cantidad -1; i >= 0; i--)
        {
            Console.WriteLine( textos[i] );
        }
        
    }
}
