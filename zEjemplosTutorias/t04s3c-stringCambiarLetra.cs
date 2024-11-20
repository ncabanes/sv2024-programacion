/*
Pide al usuario una palabra. Cambia su segunda letra 
por una "o", de (al menos) tres formas distintas.
*/

using System;
using System.Text;

class Ejemplo 
{
    static void Main() 
    {
        Console.Write("Dime una palabra: ");
        string palabra = Console.ReadLine();
        
        // Lo que no funciona:
        //string palabraModificada1 = palabra;
        //palabraModificada1[1] = 'o';
        
        string palabraModificada1 = 
            palabra.Substring(0,1) +
            "o"+
            palabra.Substring(2);
        
        Console.WriteLine(palabraModificada1);
        
        string palabraModificada2 = 
            palabra.Remove(1,1).Insert(1,"o");
        
        Console.WriteLine(palabraModificada2);
        
        StringBuilder palabraModificable = new StringBuilder(palabra);
        palabraModificable[1] = 'o';
        //string palabraModificada3 = palabraModificable.ToString(); // Opcional
        Console.WriteLine(palabraModificable);
        
    }
}

/*
Dime una palabra: cala
cola
cola
cola
*/
