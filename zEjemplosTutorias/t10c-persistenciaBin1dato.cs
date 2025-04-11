// Crea una variante del primer ejercicio
// serializando datos.

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

[Serializable]
class EjemploPersistencia
{
    public int Dato { get; set; }

    public static void Guardar(string nombre,
        EjemploPersistencia dato)
    {
        IFormatter formatter = new BinaryFormatter();
        Stream fichero = new FileStream(nombre,
            FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(fichero, dato);
        fichero.Close();
    }


    public static EjemploPersistencia Cargar(string nombre)
    {
        EjemploPersistencia dato;
        IFormatter formatter = new BinaryFormatter();
        Stream fichero = new FileStream(nombre,
            FileMode.Open, FileAccess.Read, FileShare.Read);
        dato = (EjemploPersistencia)formatter.Deserialize(fichero);
        fichero.Close();
        return dato;
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
        Guardar("datos3.dat", e);
        e.Dato = 0;
        Console.WriteLine(e);
        e = Cargar("datos3.dat");
        Console.WriteLine(e);
    }
}

// 0
// 3
// 0
// 3
