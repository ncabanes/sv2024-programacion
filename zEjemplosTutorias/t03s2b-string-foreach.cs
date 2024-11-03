/* Pregunta al usuario su nombre y muestra las letras que forman su 
nombre, separadas por espacios.

Después pregúntale qué estudia. Si responde DAM, dile "tú sí que 
vales".

*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        string nombre;
        string estudios;
        
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
        if ((estudios == "DAM") || (estudios == "dam"))
        {
            Console.WriteLine("tú sí que vales");
        }
        else
        {
            Console.WriteLine("tú te lo pierdes");
        }
    }
}

/*
Cómo te llamas?
Nacho
N a c h o
N a c h o
Qué estudias?
DAM
tú sí que vales
*/
