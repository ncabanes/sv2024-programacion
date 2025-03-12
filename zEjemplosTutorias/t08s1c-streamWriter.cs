// Crea tres ficheros, cada uno de ellos formado por tres
// líneas: "Uno", "Dos" y "Tres", desde un mismo programa,
// usando los tres formatos vistos.

using System;
using System.IO;

class Ejemplo
{
    static void Main()
    {
        StreamWriter fichero = File.CreateText("1.txt");
        fichero.WriteLine("Uno");
        fichero.WriteLine("Dos");
        fichero.WriteLine("Tres");
        fichero.Close();

        StreamWriter fichero2 = new StreamWriter("2.txt");
        fichero2.WriteLine("Uno");
        fichero2.WriteLine("Dos");
        fichero2.WriteLine("Tres");
        fichero2.Close();

        using (StreamWriter fichero3 = File.CreateText("3.txt"))
        {
            fichero3.WriteLine("Uno");
            fichero3.WriteLine("Dos");
            fichero3.WriteLine("Tres");
        }

        using (StreamWriter fichero4 = new StreamWriter("4.txt"))
        {
            fichero4.WriteLine("Uno");
            fichero4.WriteLine("Dos");
            fichero4.WriteLine("Tres");
        }
    }
}
