// Crea una versión que guarde "de forma artesanal"
// tres atributos (o propiedades): un número entero,
// un real de doble precisión y una lista con 5 enteros.

using System;
using System.Collections.Generic;
using System.IO;

class EjemploPersistencia
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

    public void Guardar(string nombreFich)
    {
        BinaryWriter fichSalida = new BinaryWriter(
            File.Open(nombreFich, FileMode.Create));
        fichSalida.Write(DatoEntero);
        fichSalida.Write(DatoReal);
        fichSalida.Write(DatoList.Count);
        foreach (int i in DatoList)
        {
            fichSalida.Write(i);
        }
        fichSalida.Close();
    }

    public void Cargar(string nombreFich)
    {
        BinaryReader fichEntrada = new BinaryReader(
            File.Open(nombreFich, FileMode.Open));
        DatoEntero = fichEntrada.ReadInt32();
        DatoReal = fichEntrada.ReadDouble();
        DatoList = new List<int>();
        int cantidad = fichEntrada.ReadInt32();
        for (int i = 0; i < cantidad; i++)
        {
            DatoList.Add(fichEntrada.ReadInt32());
        }
        fichEntrada.Close();
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
        e.Guardar("datos2.dat");
        e = new EjemploPersistencia();
        e.DatoEntero = 1;
        Console.WriteLine(e);
        e.Cargar("datos2.dat");
        Console.WriteLine(e);
    }
}

//5 - 5,1 [1 2 3 4 5 ]
//3 - 2,5 [1 2 3 4 5 6]
//1 - 5,1 [1 2 3 4 5]
//3 - 2,5 [1 2 3 4 5 6]
