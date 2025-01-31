// Crea una clase Persona, con atributos (o propiedades) Nombre y
// Apellidos, incluye un constructor que permita dar valores a ambos
// y un ToString que devuelva primero los apellidos, luego una coma
// y después el nombre. Prueba tanto el constructor como el "ToString".

using System;

class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    public Persona(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }

    
    public override string ToString()
    {
        return Apellidos + ", " + Nombre;
    }
    

}

// -----------------------

class PruebaDePersona
{
    static void Main()
    {
        Persona p = new Persona("Nacho", "Yo");
        Console.WriteLine(p);
    }
}
