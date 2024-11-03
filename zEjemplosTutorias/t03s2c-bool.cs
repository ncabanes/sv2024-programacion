/* Crea una variante del ejercicio anterior, que cree una variable 
"booleana" llamada "vaAAprobar", que será "verdad" cuando el usuario 
responda que estudia DAM.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        string nombre;
        string estudios;
        bool vaAAprobar;
        
        Console.WriteLine("Cómo te llamas?");
        nombre = Console.ReadLine();
        
        // Con {0}
        foreach(char letra in nombre)
        {
            Console.Write("{0} ", letra);
        }
        Console.WriteLine();
        
        // Concatenando
        foreach(char letra in nombre)
        {
            Console.Write(letra + " ");
        }
        Console.WriteLine();
        
        
        Console.WriteLine("Qué estudias?");
        estudios = Console.ReadLine();
        
        // Forma masoquista
        if ((estudios == "DAM") || (estudios == "dam"))
        {
            vaAAprobar = true;
        }
        else
        {
            vaAAprobar = false;
        }
        
        if (vaAAprobar == true)
        {
            Console.WriteLine("tú sí que vales");
        }
        else
        {
            Console.WriteLine("tú te lo pierdes");
        }
        
        
        // Forma compacta
        vaAAprobar = 
            ((estudios == "DAM") || (estudios == "dam"));
        
        if (vaAAprobar)
        {
            Console.WriteLine("tú sí que vales");
        }
        else
        {
            Console.WriteLine("tú te lo pierdes");
        }
        
        if (! vaAAprobar)
        {
            Console.WriteLine("tú te lo pierdes");
        }
        else
        {
            Console.WriteLine("tú sí que vales");
        }
    }
}

/*
Cómo te llamas?
Nacho
N a c h o
N a c h o
Qué estudias?
dam
tú sí que vales
tú sí que vales
tú sí que vales
*/

