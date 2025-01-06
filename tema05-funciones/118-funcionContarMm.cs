/*
 Crea una función ContarMm que obtenga la cantidad de letras mayúsculas (en el rango A-Z)
 y letras minúsculas (en el rango a-z) que hay en la cadena que se pasa como parámetro
 (sin tener en cuenta ñ ni vocales acentuadas, sólo el alfabeto inglés).

 Blanca (...)
 */

using System;
public class Ejercicio118
{
    static void ContarMm(string texto, out int mays, out int mins)
    {
        mays = 0;
        mins = 0;

        for (int i=0; i<texto.Length; i++)
        {
            if (texto[i] >= 'a' && texto[i] <= 'z')
            {
                mins++;
            }

            if (texto[i] >= 'A' && texto[i] <= 'Z')
            {
                mays++;
            }
        }

        //foreach(char letter in texto)
        //{
        //    if(letter >= 'a' && letter <= 'z')
        //    {
        //        mins++;
        //    }

        //    if(letter >= 'A' && letter <= 'Z')
        //    {
        //        mays++;
        //    }
        //}
    }

    public static void Main()
    {
        int mays, mins;

        ContarMm("texto SuPeR loco", out mays, out mins);

        Console.WriteLine("Mayúsculas: {0}, Minúsculas: {1}", mays, mins);
    }
}
