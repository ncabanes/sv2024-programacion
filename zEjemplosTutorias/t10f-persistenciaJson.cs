// Crea una nueva variante usando datos en formato XML
// (con using System.Xml.Serialization).

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;


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
        string jsonString = JsonSerializer.Serialize(dato);
        File.WriteAllText(nombre, jsonString);
    }


    public static EjemploPersistencia Cargar(string nombre)
    {
        string jsonString = File.ReadAllText(nombre);
        EjemploPersistencia objeto =
             JsonSerializer.Deserialize<EjemploPersistencia>(jsonString);
        return objeto;
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
        Guardar("datos6.dat", e);
        e = new EjemploPersistencia();
        e.DatoEntero = 1;
        Console.WriteLine(e);
        e = Cargar("datos6.dat");
        Console.WriteLine(e);
    }
}

// 5 - 5,1 [1 2 3 4 5 ]
// 3 - 2,5[1 2 3 4 5 6]
// 1 - 5,1[1 2 3 4 5]
// 3 - 2,5[1 2 3 4 5 6]
// 
