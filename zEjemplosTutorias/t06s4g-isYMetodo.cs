// Amplía la clase  PersonaConEdad, para añadir un método
// CalcularAnyoNacimiento, que deduzca el año en que nació,
// restando su edad del año actual.

// Crea un array que contenga clases Persona y PersonaConEdad,
// añade 3 datos de ejemplo, recorre el array con un foreach,
// mostrando los datos de cada una (usando ToString() y
// muestra el año de nacimiento de las que sean de tipo
// PersonaConEdad.

using System;

class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }

    public Persona(string Nombre, string Apellidos)
    {
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
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

    public PersonaConEdad(string Nombre, string Apellidos, int Edad)
        : base(Nombre, Apellidos)
    {
        this.Edad = Edad;
    }


    public PersonaConEdad(string Nombre, string Apellidos)
        : this(Nombre, Apellidos, 18)
    {
    }

    /*
    public PersonaConEdad(string Nombre, string Apellidos)
        : base(Nombre, Apellidos)
    {
        this.Edad = 18;
    }
    */

    public override string ToString()
    {
        return base.ToString() + " - " + Edad;
    }

    public int CalcularAnyoNacimiento()
    {
        return 2025 - Edad;
    }


}

// -----------------------

class PruebaDePersona
{
    static void Main()
    {
        Persona[] personas = new Persona[3];

        personas[0] = new Persona("Nacho", "Yo");

        PersonaConEdad pe = new PersonaConEdad("A", "B", 30);
        personas[1] = pe;

        personas[2] = new Persona("C", "D");

        foreach (Persona p in personas)
        {
            Console.WriteLine(p);
            if (p is PersonaConEdad)
            {
                Console.WriteLine("Tiene edad");
                Console.WriteLine("Su año de nacimiento es " 
                    + ((PersonaConEdad) p).CalcularAnyoNacimiento());
            }
        }
    }
}
