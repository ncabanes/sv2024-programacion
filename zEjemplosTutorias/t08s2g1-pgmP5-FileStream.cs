// Muestra en consola la imagen almacenada en un
// fichero PGM binario en tonos de gris.

using System;
using System.IO;

class Ejemplo
{

    static void Main()
    {
        FileStream f = File.OpenRead("imagen_gris_binaria.pgm");
        int tamanyo = (int) f.Length;
        byte[] datos = new byte[tamanyo];

        int cantidadLeida = f.Read(datos, 0, tamanyo);
        f.Close();

        if (cantidadLeida != tamanyo)
        {
            Console.WriteLine("Error de lectura");
            return;
        }

        if ((datos[0] != 'P') || (datos[1] != '5'))
        {
            Console.WriteLine("No es PGM");
            return;
        }

        int posicion = 3;
        string anchoAlto = "";
        do
        {
            if ((datos[posicion] != 10))
            {
                anchoAlto += (char) datos[posicion];
                posicion++;
            }
        }
        while (datos[posicion] != 10);
        Console.WriteLine(anchoAlto); // 72 20

        int ancho = Convert.ToInt32(anchoAlto.Split()[0]);
        int alto = Convert.ToInt32(anchoAlto.Split()[1]);

        // Mejorable: saltamos la cantidad de grises
        posicion += 5;

        int caracteresEscritos = 0;
        for (int i = posicion; i < tamanyo; i++)
        {
            if (datos[i] == 255)
                Console.Write(".");
            else
                Console.Write("M");

            caracteresEscritos++;
            if (caracteresEscritos >= ancho)
            {
                Console.WriteLine();
                caracteresEscritos = 0;
            }
        }

    }
}
