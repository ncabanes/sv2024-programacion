// Crea un constructor alternativo para PersonaConEdad,
// que no recibirá edad, y la prefijará a 18 años, apoyándose
// en el constructor que sí la recibe.

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
