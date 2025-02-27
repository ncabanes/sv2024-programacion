// Para probar el uso de Equals y GetHashCode, crea una
// clase Capital como la propuesta, añade varias
// capitales en un HashSet, pregunta al usuario cuál
// quiere buscar y dile si está o no. Finalmente,
// muestra todas las capitales.


using System;
using System.Collections.Generic;

class Capital
{
    public string Nombre { get; set; }
    public string Pais { get; set; }

    public Capital(string nombre, string pais)
    { 
        Nombre = nombre; 
        Pais = pais; 
    }

    public override string ToString()
    {
        return Nombre + " - " + Pais;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Capital otra = (Capital)obj;
        return Nombre == otra.Nombre && Pais == otra.Pais;
    }

    public override int GetHashCode()
    {
        return Nombre.GetHashCode() + Pais.GetHashCode();
    }
}

class Ejemplo
{
    static void Main()
    {
        HashSet<Capital> conjunto = new HashSet<Capital>();
        conjunto.Add( new Capital("Lima", "Perú"));
        conjunto.Add( new Capital("Madrid", "España"));
        conjunto.Add( new Capital("París", "Francia"));
        conjunto.Add( new Capital("Roma", "Italia"));
        conjunto.Add( new Capital("Roma", "Italia"));

        if (conjunto.Contains(new Capital("Madrid", "España")))
            Console.WriteLine("Madrid está");
        else
            Console.WriteLine("Madrid no está");

        foreach (Capital c in conjunto)
        {
            Console.WriteLine(c);
        }
    }
}
