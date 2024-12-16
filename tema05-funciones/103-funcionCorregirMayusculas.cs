/* 103. Crea una función llamada "CorregirMayusculas", que recibirá una cadena 
como parámetro y la devolverá en minúsculas, excepto la primera letra y las que 
están después de un punto. Por ejemplo, a partir del texto "hola.esto No es. 
tan Fácil" se obtendrá "Hola.Esto no es. Tan fácil". Pruébala desde Main. */

using System;

class Ejercicio103
{
    static string CorregirMayusculas(string cadena)
    {
        cadena = cadena.ToLower();
        for(int i = 0; i < cadena.Length-1; i++)
        {
            if(cadena[i] == '.')
            {
                if(cadena[i+1] == ' ')
                {
                    cadena = 
                        cadena.Substring(0,i+2) + 
                        cadena[i+2].ToString().ToUpper() + cadena.Substring(i+3);
                }
                else
                {
                    cadena = 
                        cadena.Substring(0,i+1) + 
                        cadena[i+1].ToString().ToUpper() + cadena.Substring(i+2);
                }
            }
            
        }
        cadena = cadena.Substring(0,1).ToUpper() + cadena.Substring(1);
        return cadena;  
    }

    static void Main()
    {
        /* Para probar con el ejemplo propuesto:
        string ejemplo = "hola.esto No es. tan fácil";
        Console.WriteLine( CorregirMayusculas(ejemplo));
        */
        
        Console.WriteLine("Introduce una frase para corregir:");
        string frase = Console.ReadLine();
        
        Console.WriteLine( CorregirMayusculas(frase) ); 
    }
}

