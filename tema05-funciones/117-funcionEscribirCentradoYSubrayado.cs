// PABLO (...) 1ºDAW - SEMIPRESENCIAL
// 117.Crea una función EscribirCentradoYSubrayado, que escriba centrado horizontalmente en pantalla
// (suponiendo una anchura de 80 columnas) y subrayado (con guiones) el texto que se indique como parámetro:
using System;

class Ejercicio117
{
    const int MAX_COLUMNS = 80;
    static void EscribirCentradoYSubrayado(string texto)
    {
        int espaciosTotales = MAX_COLUMNS - texto.Length;
        // First row
        for (int i = 0; i < espaciosTotales / 2; i++)
        {
            Console.Write(" ");
        }
        Console.Write(texto);

        // Second row
        Console.WriteLine();
        for (int i = 0; i < espaciosTotales / 2; i++)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < texto.Length; i++)
        {
            Console.Write("-");
        }
    }

    static void Main()
    {
        
        string texto = "Hola Mundo";
        EscribirCentradoYSubrayado(texto);
    }
}
