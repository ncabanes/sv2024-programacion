// Crea una variable float, otra int y otra ulong.
// Guarda todas ellas en un mismo fichero usando
// un BinaryWriter. Luego lee todas ellas con un
// BinaryReader y comprueba que sus valores son
// los que esperabas.


using System;
using System.IO;

class Ejemplo
{

    static void Main()
    {
        float dato1 = 4.5f;
        int dato2 = 123456;
        ulong dato3 = 12345678901234;

        BinaryWriter f1 = new BinaryWriter(
            File.Open("datos.dat", FileMode.Create));
        f1.Write(dato1);
        f1.Write(dato2);
        f1.Write(dato3);
        f1.Close();

        BinaryReader f2 = new BinaryReader(
            File.Open("datos.dat", FileMode.Open));
        dato2 = f2.ReadInt32();
        dato1 = f2.ReadSingle();
        dato3 = f2.ReadUInt64();
        f2.Close();

        Console.WriteLine(dato1);
        Console.WriteLine(dato2);
        Console.WriteLine(dato3);
    }
}
