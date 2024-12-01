/* 102. Crea una función llamada "SumaDeNumeros", que reciba una cadena formada 
por números enteros largos y espacios intermedios, quizá redundantes, como "23 
45  67 89 " y devuelva la suma de esos números (en este caso, 224). Recuerda: 
debe comportarse bien si hay espacios redundantes. Pruébala desde Main, con una 
cadena prefijada. */

using System;

class Ejercicio102
{
    static void Main()
    {
        string textoNumeros = " 23 45      67 89";

        Console.WriteLine(SumaDeNumeros(textoNumeros));
    }

    static long SumaDeNumeros(string textoContenedor)
    {
        long suma = 0;
        textoContenedor = textoContenedor.Trim();

        while (textoContenedor.Contains("  "))
        {
            textoContenedor = textoContenedor.Replace("  ", " ");
        }

        string[] trozos = textoContenedor.Split();
        for (int i = 0; i < trozos.Length; i++)
        {
            suma += Convert.ToInt32(trozos[i]);
        }

        return suma;
    }
}
