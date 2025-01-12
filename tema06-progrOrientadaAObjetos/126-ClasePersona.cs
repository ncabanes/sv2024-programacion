/* 126. Crea un clase "Persona", que permita almacenar ciertos datos de 
 * personas, de momento sólo: nombre (cadena de texto), edad (byte) y eMail 
 * (cadena de texto). Estos atributos deben ser accesibles a través de getters 
 * y setters. Tendrá también un método "MostrarDatos", que escribirá en 
 * pantalla el nombre, la edad y el eMail, en la misma línea, separando cada 
 * dato del siguiente con un espacio en blanco. Crea, en el mismo fichero 
 * fuente, una clase "PruebaDePersona", que contendrá Main, y que pedirá al 
 * usuario los datos de 2 personas (sin usar todavía un array) y luego los 
 * mostrará. Deberás entregar sólo el (único) fichero .cs.
 * 
 * Luis (...)  */

using System;

class Persona
{
    private string nombre;
    private byte edad;
    private string eMail;

    public string GetNombre() { return nombre; }
    public byte GetEdad() { return edad; }
    public string GetEMail() { return eMail; }

    public void SetNombre(string nuevoNombre) { nombre = nuevoNombre; }
    public void SetEdad(byte nuevaEdad) { edad = nuevaEdad; }
    public void SetEMail(string nuevoEMail) { eMail = nuevoEMail; }

    public void MostrarDatos()
    {
        Console.WriteLine("{0} {1} {2}.",nombre, edad, eMail);
    }
}

class PruebaDePersona
{
    static void Main()
    {
        Persona persona1 = new Persona();
        Persona persona2 = new Persona();

        Console.Write("Dime el nombre de la primera persona: ");
        string nombre1 = Console.ReadLine();
        persona1.SetNombre(nombre1);

        Console.Write("Dime la edad de la primera persona: ");
        byte edad1 = Convert.ToByte(Console.ReadLine());
        persona1.SetEdad(edad1);

        Console.Write("Dime el email de la primera persona: ");
        string email1 = Console.ReadLine();
        persona1.SetEMail(email1);

        Console.Write("Dime el nombre de la segunda persona: ");
        string nombre2 = Console.ReadLine();
        persona2.SetNombre(nombre2);

        Console.Write("Dime la edad de la segunda persona: ");
        byte edad2 = Convert.ToByte(Console.ReadLine());
        persona2.SetEdad(edad2);

        Console.Write("Dime el email de la segunda persona: ");
        string email2 = Console.ReadLine();
        persona2.SetEMail(email2);

        Console.Write("Los datos de la primera persona son: ");
        persona1.MostrarDatos();

        Console.Write("Los datos de la segunda persona son: ");
        persona2.MostrarDatos();
    }
}

