/*  MARTA (...), retoques menores por Nacho
    Ejercicio 174

 *Crea una nueva versión de la clase Vehículo y derivadas (ej. 173), 
 * en la que uses propiedades en formato compacto. Además, en la clase 
 * moto habrá un atributo adicional, el "tipo de licencia" necesario para 
 * conducirla. Habrá un nuevo constructor que permita dar valor a la marca, 
 * el modelo y la licencia. El constructor inicial pasará a apoyarse en 
 * este nuevo constructor, prefijando la licencia a "A". La clase Moto 
 * será "sellada".
 */

using System;

abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public byte CantidadDeRuedas { get; set; }

    public Vehiculo(string marca, string modelo, byte cantidadDeRuedas)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.CantidadDeRuedas = cantidadDeRuedas;
    }

    public override string ToString()
    {
        return "Marca: " + Marca + " - " + "Modelo: " + Modelo + " - " +
            "Cantidad de ruedas: " + CantidadDeRuedas;
    }
}

class Coche : Vehiculo
{
    public Coche(string marca, string modelo)
        : base(marca, modelo, 4)
    {
    }

    public override string ToString()
    {
        return base.ToString() + " (Coche)";
    }
}

sealed class Moto : Vehiculo
{
    public string Licencia { get; set; }

    public Moto(string marca, string modelo, string licencia)
        : base(marca, modelo, 2)
    {
        this.Licencia = licencia;
    }
    
    public Moto(string marca, string modelo)
        : this(marca, modelo, "A")
    {;
    }

    public override string ToString()
    {
        return base.ToString() +" - "+"Licencia: "+Licencia+" (Moto)";
    }
}

class Ejercicio174
{
    static void Main()
    {
        Coche coche1 = new Coche("Renault", "Captur");
        Coche coche2 = new Coche("Honda", "Civic");
        Moto moto1 = new Moto("Yamaha", "XMAX 125");

        Vehiculo[] vehiculos = { coche1, coche2, moto1 };

        foreach (Vehiculo vehiculo in vehiculos)
        {
            Console.WriteLine(vehiculo);
        }
    }
}
