// Crea una versión ampliada de las clases Persona y
// PersonaConEdad, en la que cada persona pueda tener una
// madre (omitiremos el padre y los hijos). Crea un método
// IndicarMadre(Persona p) para dar valor a ese nuevo atributo.
// Añade también un método MostrarFamilia, que muestre
// el nombre de la madre (si existe).


using System;

class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    private Persona madre;

    public Persona(string Nombre, string Apellidos)
    {
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
        madre = null;
    }


    public override string ToString()
    {
        return Apellidos + ", " + Nombre;
    }

    public void IndicarMadre(Persona persona)
    {
        madre = persona;
    }

    public void MostrarFamilia()
    {
        if (madre != null)
        {
            Console.WriteLine("Madre: " + madre);
        }
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

        PersonaConEdad pe = new PersonaConEdad("Adelaida", "Benito", 50);
        personas[1] = pe;

        personas[2] = new PersonaConEdad("Carlos", "Durendez", 20);
        personas[2].IndicarMadre(pe);

        foreach (Persona p in personas)
        {
            Console.WriteLine(p);
            p.MostrarFamilia();
            if (p is PersonaConEdad)
            {
                Console.WriteLine("Tiene edad");
                Console.WriteLine("Su año de nacimiento es " 
                    + ((PersonaConEdad) p).CalcularAnyoNacimiento());
            }
        }
    }
}
