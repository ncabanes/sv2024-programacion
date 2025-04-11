// Crea una variante del ejemplo, en la que el
// número no sea un atributo con getters y setters,
// sino una propiedad.

using System;
using System.IO;

class EjemploPersistencia
{
    public int Dato { get; set; }

    public void Guardar(string nombreFich)
    {
        BinaryWriter fichSalida = new BinaryWriter(
            File.Open(nombreFich, FileMode.Create));
        fichSalida.Write(Dato);
        fichSalida.Close();
    }

    public void Cargar(string nombreFich)
    {
        BinaryReader fichEntrada = new BinaryReader(
            File.Open(nombreFich, FileMode.Open));
        Dato = fichEntrada.ReadInt32();
        fichEntrada.Close();
    }

    public override string ToString()
    {  
        return Dato.ToString(); 
    }



    static void Main()
    {
        EjemploPersistencia e = new EjemploPersistencia();
        Console.WriteLine(e);
        e.Dato = 3;
        Console.WriteLine(e);
        e.Guardar("datos1.dat");
        e.Dato = 0;
        Console.WriteLine(e);
        e.Cargar("datos1.dat");
        Console.WriteLine(e);
    }
}

// 0
// 3
// 0
// 3
