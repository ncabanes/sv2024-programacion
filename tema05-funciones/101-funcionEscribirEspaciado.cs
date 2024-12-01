/* 101. Crea una función llamada "EscribirEspaciado", que mostrará en pantalla 
el texto que se indique como parámetro, pero con un espacio adicional entre 
cada par de letras. Por ejemplo, el texto "DAM/DAW" se mostraría como "D A M / 
D A W" (cuidado: no debe sobrar un espacio al final ni al principio). Pruébala 
en Main, a partir de un texto introducido por el usuario.*/

using System;

class Ejercicio101
{
    static void Main()
    {
        Console.WriteLine("Escribe el texto: ");
        string texto = Console.ReadLine();
        EscribirEspaciado(texto); 
    }
    
    static void EscribirEspaciado (string frase)
    {
        string textoConEspacios = "";
        for (int i = 0; i < frase.Length; i++)
        {
            textoConEspacios += frase[i] + " ";
        }
        Console.WriteLine(textoConEspacios.Trim());
    }
}

