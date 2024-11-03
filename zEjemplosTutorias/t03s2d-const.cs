/* Crea una variante del ejercicio anterior, que use una constante para 
los estudios deseables, en vez de ser una cadena prefijada.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        string nombre;
        string estudios;
        bool vaAAprobar;
        
        const string ESTUDIOS_RECOMENDABLES = "DAM";
        const string ESTUDIOS_RECOMENDABLES_2 = "dam";
        
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
        if ((estudios == ESTUDIOS_RECOMENDABLES) 
            || (estudios == ESTUDIOS_RECOMENDABLES_2))
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
            ((estudios == ESTUDIOS_RECOMENDABLES) 
                || (estudios == ESTUDIOS_RECOMENDABLES_2));
        
        if (vaAAprobar)
        {
            Console.WriteLine("tú sí que vales");
        }
        else
        {
            Console.WriteLine("tú te lo pierdes");
        }
        
        // Planteamiento con el caso contrario ("si no...")
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

