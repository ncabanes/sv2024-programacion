/*
Pide al usuario una palabra y muéstrala con 
mayúsculas "en formato de nombre" (la primera 
letra en mayúsculas y el resto en minúsculas)
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        Console.Write("Dime una palabra: ");
        string palabra = Console.ReadLine();
        
        string nombreCorrecto = 
            palabra.Substring(0,1).ToUpper() +
            palabra.Substring(1).ToLower();
        
        Console.WriteLine(nombreCorrecto);
    }
}

/*
Dime una palabra: hoLA
Hola
*/
