/* MARTA (...), retoques menores por Nacho
 Ejercicio 173  */

// Crea una clase abstracta Vehiculo, con atributos: marca, modelo, 
// cantidadDeRuedas. Crea un único constructor que dé valores a los 3 atributos, 
// y crea también propiedades en formato largo. También habrá un método ToString, 
// devuelva la marca, el modelo y la cantidad de ruedas, separados por " - ".

using System;

abstract class Vehiculo
{
    private string marca;
    private string modelo;
    private byte cantidadDeRuedas;
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }
    public byte CantidadDeRuedas
    {
        get { return cantidadDeRuedas; }
        set { cantidadDeRuedas = value; }
    }

    public Vehiculo(string Marca, string Modelo, byte CantidadDeRuedas)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.CantidadDeRuedas = CantidadDeRuedas;
    }

    public override string ToString()
    {
        return Marca + " - "  + Modelo+ " - "+
            CantidadDeRuedas + " ruedas";
    }

    // Crea una clase Coche, que herede de Vehiculo. Su único constructor dará valor 
    // a marca y modelo, y prefijará las ruedas a 4. El método ToString devolverá la 
    // marca, el modelo y la cantidad de ruedas, seguido de " (Coche)".
    class Coche : Vehiculo
    {
        public Coche(string Marca, string Modelo)
            : base(Marca, Modelo, 4)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " (Coche)";
        }
    }

    // Crea una clase Moto, que herede de Vehiculo. Su único constructor dará valor a 
    // marca y modelo, y prefijará las ruedas a 2. El método ToString devolverá la 
    // marca, el modelo y la cantidad de ruedas, seguido de " (Moto)".
    class Moto : Vehiculo
    {
        public Moto(string Marca, string Modelo)
            : base(Marca, Modelo, 2)
        {
        }

        public override string ToString()
        {
            return base.ToString() + " (Moto)";
        }
    }

    // Crea un array de 3 vehículos, que contenga dos coches, una moto y luego muéstralos.
    class Ejercicio173
	{
		static void Main()
		{
				Coche coche1 = new Coche("Renault", "Captur");
				Coche coche2 = new Coche("Honda", "Civic");
				Moto moto1 = new Moto("Yamaha", "XMAX 125");

				Vehiculo [] vehiculos = {coche1, coche2, moto1};
				
				foreach(Vehiculo vehiculo in vehiculos)
				{
					Console.WriteLine(vehiculo);
				}
		}
	}
}
