// Crea una nueva variante usando datos en formato XML
// (con using System.Xml.Serialization).

using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections.Generic;

[Serializable]
public class EjemploPersistencia
{
    public int DatoEntero { get; set; }
    public double DatoReal { get; set; }
    public List<int> DatoList { get; set; }

    public EjemploPersistencia()
    {
        DatoEntero = 5;
        DatoReal = 5.1;
        DatoList = new List<int>();
        DatoList.Add(1);
        DatoList.Add(2);
        DatoList.Add(3);
        DatoList.Add(4);
        DatoList.Add(5);
    }


    public static void Guardar(string nombre,
        EjemploPersistencia dato)
    {
        XmlSerializer formatter = new XmlSerializer(dato.GetType());
        Stream fichero = new FileStream(nombre,
            FileMode.Create, FileAccess.Write, FileShare.None);
        formatter.Serialize(fichero, dato);
        fichero.Close();
    }


    public static EjemploPersistencia Cargar(string nombre)
    {
        // Cuidado: como nuestro constructor es "terrible" 
        // y añade datos de  prueba al array,
        // éste tendrá datos duplicados
        EjemploPersistencia dato = new EjemploPersistencia();
        XmlSerializer formatter = new XmlSerializer(dato.GetType());
        Stream fichero = new FileStream(nombre,
            FileMode.Open, FileAccess.Read, FileShare.Read);
        dato = (EjemploPersistencia)formatter.Deserialize(fichero);
        fichero.Close();
        return dato;
    }



    public override string ToString()
    {
        string respuesta = DatoEntero.ToString() + " - "
            + DatoReal + " [";
        foreach (int i in DatoList)
        {
            respuesta += i + " ";
        }
        respuesta += "]";
        return respuesta;
    }



    static void Main()
    {
        EjemploPersistencia e = new EjemploPersistencia();
        Console.WriteLine(e);
        e.DatoEntero = 3;
        e.DatoReal = 2.5;
        e.DatoList.Add(6);
        Console.WriteLine(e);
        Guardar("datos5.dat", e);
        e = new EjemploPersistencia();
        e.DatoEntero = 1;
        Console.WriteLine(e);
        e = Cargar("datos5.dat");
        Console.WriteLine(e);
    }
}

// 5 - 5,1 [1 2 3 4 5 ]
// 3 - 2,5[1 2 3 4 5 6]
// 1 - 5,1[1 2 3 4 5]
// 3 - 2,5[1 2 3 4 5 1 2 3 4 5 6]
