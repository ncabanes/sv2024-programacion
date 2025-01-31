// En la clase Persona (y en PersonaConEdad), haz que el constructor reciba
// parámetros que se llamen igual que los atributos. Utiliza "this" para
// dar valor a los atributos.


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
