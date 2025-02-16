/* Luis (...), retoques menores por Nacho
    Ejercicio 175

A partir del ejercicio anterior (Vehículo y derivadas), crea un 
programa en el que se muestre un menú al usuario y se le permita 
introducir datos (en un array de 1000 vehículos) de coches o motos, 
mostrar todos los datos almacenados hasta el momento, buscar en ellos 
(a partir de su ToString), o modificar uno concreto.
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

class PruebaDeVehiculo
{
    
    static void Main()
    {
        const int CAPACIDAD = 1000;

        Vehiculo[] vehiculos = new Vehiculo[CAPACIDAD];
        string opcion;
        bool salir = false;
        int cantidad = 0;

        do
        {
            MostraMenu();
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine().ToLower();

            switch (opcion)
            {
                case "1":
                    cantidad = AgregarVehiculos(CAPACIDAD, vehiculos, cantidad);
                    break;
                case "2":
                    MostrarVehiculos(vehiculos, cantidad);
                    break;
                case "3":
                    BuscarVehiculos(vehiculos, cantidad);
                    break;
                case "4":
                    ModificarVehiculo(vehiculos, cantidad);
                    break;
                case "s":
                    Console.WriteLine("Saliendo del programa");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
        while (!salir);
        
    }
    
    private static void MostraMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu");
        Console.WriteLine("---------");
        Console.WriteLine("1- Introducir datos");
        Console.WriteLine("2- Mostrar datos");
        Console.WriteLine("3- Buscar datos");
        Console.WriteLine("4- Modificar datos");
        Console.WriteLine("S- Salir");
    }

    private static int AgregarVehiculos(int CAPACIDAD, Vehiculo[] vehiculos, int cantidad)
    {
        if (cantidad < CAPACIDAD)
        {
            Console.WriteLine("Quieres ingresar coche(c) o moto(m)");
            string tipo = Console.ReadLine().ToLower();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            if (tipo == "c")
            {
                vehiculos[cantidad] = new Coche(marca, modelo);
                cantidad++;
            }
            else if (tipo == "m")
            {
                Console.Write("Tipo de licencia ('A' por defecto):");
                string licencia = Console.ReadLine();

                if (licencia == "")
                {
                    licencia = "A";
                }
                vehiculos[cantidad] = new Moto(marca, modelo, licencia);
                cantidad++;
            }
            else
            {
                Console.WriteLine("Tipo de vehículo no válido.");
            }
        }
        else
        {
            Console.WriteLine("Espacio lleno");
        }

        return cantidad;
    }

    private static void MostrarVehiculos(Vehiculo[] vehiculos, int cantidad)
    {
        if (cantidad != 0)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine((i + 1) + " - " + vehiculos[i]);
            }
        }
        else
        {
            Console.WriteLine("No hay vehículos almacenados.");
        }
    }

    private static void BuscarVehiculos(Vehiculo[] vehiculos, int cantidad)
    {
        Console.WriteLine("Introduce texto a buscar:");
        string busqueda = Console.ReadLine();

        bool encontrado = false;

        for (int i = 0; i < cantidad; i++)
        {
            if (vehiculos[i].ToString().ToLower().Contains(busqueda))
            {
                Console.WriteLine((i + 1) + " - " + vehiculos[i]);
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("No se encontraron vehículos con ese criterio");
        }
    }

    private static void ModificarVehiculo(Vehiculo[] vehiculos, int cantidad)
    {
        Console.WriteLine("Introduce el número de registro a modificar:");
        int numRegistro = Convert.ToInt32(Console.ReadLine());

        Vehiculo vehiculo = vehiculos[numRegistro - 1];
        if (numRegistro >= 1 || numRegistro <= cantidad)
        {
            Console.WriteLine(vehiculo);

            Console.WriteLine("¿Modificar Marca?");
            string nuevaMarca = Console.ReadLine();

            if (nuevaMarca != "")
            {
                vehiculo.Marca = nuevaMarca;
            }

            Console.WriteLine("¿Modificar Modelo?");
            string nuevaModelo = Console.ReadLine();

            if (nuevaModelo != "")
            {
                vehiculo.Modelo = nuevaModelo;
            }

            if (vehiculo is Moto)
            {
                Console.WriteLine("¿Modificar Licencia?");
                string nuevaLicencia = Console.ReadLine();

                if (nuevaLicencia != "")
                {
                    ((Moto) vehiculo).Licencia = nuevaLicencia;
                }
            }

            Console.WriteLine("Vehículo actualizado con éxito.");

        }
        else
        {
            Console.WriteLine("No se encuentra el registro.");
        }
    }
}

