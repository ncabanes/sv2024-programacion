// A partir de la clase Persona, crea una clase PersonaConEdad.
// En esta clase existirá un nuevo atributo, la edad. El constructor
// deberá recibir nombre, apellidos y edad, y deberá apoyarse en el
// constructor de persona que recibe nombre y apellidos. El método
// ToString deberá añadir " - " y la edad al de la clase Persona.
// Prueba ambas clases desde Main.


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

class PersonaConEdad : Persona
{
    public int Edad { get; set; }

    public PersonaConEdad(string nombre, string apellidos, int edad) 
        : base(nombre, apellidos)
    {
        Edad = edad;
    }


    public override string ToString()
    {
        return base.ToString() + " - " + Edad;
    }


}

// -----------------------

class PruebaDePersona
{
    static void Main()
    {
        Persona p = new Persona("Nacho", "Yo");
        Console.WriteLine(p);

        PersonaConEdad pe = new PersonaConEdad("A", "B", 30);
        Console.WriteLine(pe);
    }
}
