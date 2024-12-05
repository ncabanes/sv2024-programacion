/* Crea una función "MaysYMins", que reciba una cadena y devuelva (como 
parámetros "ref") una cadena formada por las letras en mayúsculas que 
contenía y otra formada por las letras en minúsculas que contenía. 
Pruébala desde Main, con un texto prefijado.
 */

using System;

class Ejemplo 
{
    static void MaysYMins(string texto, ref string mayusculas, 
        ref string minusculas)
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
        string mays="", mins="";
        
        MaysYMins("Hola Que Tal", ref mays, ref mins);
        Console.WriteLine(mays);
        Console.WriteLine(mins);
    }
}

/*
HQT
olaueal
*/
