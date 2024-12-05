/* Crea una variante del ejercicio anterior (función "MaysYMins"), 
empleando parámetros "out").
*/

using System;

class Ejemplo 
{
    static void MaysYMins(string texto, out string mayusculas, 
        out string minusculas)
    {
        mayusculas = "";
        minusculas = "";
        foreach(char c in texto)
        {
            if (c >= 'A' && c <= 'Z') mayusculas += c;
            if (c >= 'a' && c <= 'z') minusculas += c;
        }
    }
    
    static void Main() 
    {
        string mays, mins;
        
        MaysYMins("Hola Que Tal", out mays, out mins);
        Console.WriteLine(mays);
        Console.WriteLine(mins);
    }
}

/*
HQT
olaueal
*/
