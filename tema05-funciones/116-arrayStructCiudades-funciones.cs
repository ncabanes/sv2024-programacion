/*116. Crea una versión actualizada de la base de datos de ciudades (ejercicio 
093), descomponiéndola en funciones. Puedes tomar ideas mirando la solución 
compartida al ejercicio 113 (biblioteca, con funciones) o del video 052 de 
YouTube.
*/

using System;

class Ciudades
{
    struct tipoCiudad
    {
        public string nombre;
        public string pais;
        public int poblacion;
    }

    enum opcionesMenu
    {
        SALIR, ANYADIR, MOSTRAR, BUSCAR,
        EDITAR, INSERTAR, ELIMINAR, ORDENAR, ERRORES
    };

    static void Main()
    {
        const int CANTIDAD_MAX = 20000;
        tipoCiudad[] ciudades = new tipoCiudad[CANTIDAD_MAX];
        bool terminado = false;
        int cantidad = 0;
        string opcion;

        do
        {
            MostrarMenu();

            opcion = Console.ReadLine().ToLower();
            if (opcion == "t")
                terminado = true;
            else switch (Convert.ToByte(opcion))
                {
                    case (int)opcionesMenu.ANYADIR:
                        cantidad = AnadirCiudad(ciudades, cantidad, CANTIDAD_MAX);
                        break;

                    case (int)opcionesMenu.MOSTRAR:
                        MostrarCiudades(ciudades, cantidad);
                        break;

                    case (int)opcionesMenu.BUSCAR:
                        BuscarCiudades(ciudades, cantidad);
                        break;

                    case (int)opcionesMenu.EDITAR:
                        EditarCiudad(ciudades, cantidad);
                        break;

                    case (int)opcionesMenu.INSERTAR:
                        InsertarCiudad(ciudades, ref cantidad, CANTIDAD_MAX);
                        break;

                    case (int)opcionesMenu.ELIMINAR:
                        EliminarCiudad(ciudades, ref cantidad);
                        break;

                    case (int)opcionesMenu.ORDENAR:
                        OrdenarCiudades(ciudades, cantidad);
                        break;

                    case (int)opcionesMenu.ERRORES:
                        BuscarErrores(ciudades, cantidad);
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
        }
        while (!terminado);
        Console.WriteLine("Fin del programa");
    }

    private static void BuscarErrores(tipoCiudad[] ciudades, int cantidad)
    {
        bool problemaEncontrado = false;
        for (int i = 0; i < cantidad; i++)
        {
            if (ciudades[i].nombre.Contains(".."))
                problemaEncontrado = true;

            if (ciudades[i].nombre.Contains(",,"))
                problemaEncontrado = true;

            for (int j = 0; j < ciudades[i].nombre.Length - 2; j++)
            {
                if ((ciudades[i].nombre[j] == ciudades[i].nombre[j + 1])
                   && (ciudades[i].nombre[j] == ciudades[i].nombre[j + 2]))
                {
                    problemaEncontrado = true;
                }
            }

            if (problemaEncontrado)
            {
                Console.WriteLine("Posibles errores encontrados: "
                    + ciudades[i].nombre);
                problemaEncontrado = false;
            }
        }
    }

    private static void OrdenarCiudades(tipoCiudad[] ciudades, int cantidad)
    {
        Console.WriteLine("¿Ordenar por nombre o país (n/p)?");
        string respuesta1 = Console.ReadLine();
        if (respuesta1.ToLower() == "n")
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (String.Compare(ciudades[i].nombre,
                        ciudades[j].nombre, true) > 0)
                    {
                        tipoCiudad datotemporal = ciudades[i];
                        ciudades[i] = ciudades[j];
                        ciudades[j] = datotemporal;
                    }
                }
            }
        }
        else if (respuesta1.ToLower() == "p")
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (String.Compare(ciudades[i].pais, ciudades[j].pais, true) > 0)
                    {
                        tipoCiudad datotemporal = ciudades[i];
                        ciudades[i] = ciudades[j];
                        ciudades[j] = datotemporal;
                    }
                }
            }
        }
    }

    private static void EliminarCiudad(tipoCiudad[] ciudades, ref int cantidad)
    {
        Console.WriteLine("Eliminar registro.Número de registro: ");
        int posicionEliminar = Convert.ToInt32(Console.ReadLine());
        posicionEliminar = posicionEliminar - 1;
        if ((posicionEliminar < 0) || (posicionEliminar > cantidad - 1))
        {
            Console.WriteLine("Número de registro no válido");
        }
        else
        {
            Console.WriteLine("{0}-{1},{2}",
                posicionEliminar,
                ciudades[posicionEliminar].nombre,
                ciudades[posicionEliminar].pais);
            Console.WriteLine("¿Seguro que quieres eliminar este registro de forma permanente (s/n)?");
            string contestacion = Console.ReadLine();
            if (contestacion.ToLower() == "s")
            {
                for (int i = posicionEliminar; i < cantidad; i++)
                {
                    ciudades[i] = ciudades[i + 1];
                }
                cantidad--;
                if (cantidad == 0)
                {
                    Console.WriteLine("Se ha borrado el último dato que quedaba");
                }
            }
        }
    }

    private static void InsertarCiudad(tipoCiudad[] ciudades, ref int cantidad, int CANTIDAD_MAX)
    {
        Console.WriteLine("Insertar un registro. Posición: ");
        int posicionInsertar = Convert.ToInt32(Console.ReadLine());
        if (posicionInsertar > cantidad)
        {
            Console.WriteLine("Número de registro no válido");
        }
        if (posicionInsertar > CANTIDAD_MAX)
        {
            Console.WriteLine("No puede almacenar más datos.Array lleno");
        }
        else
        {
            for (int i = cantidad; i > posicionInsertar; i--)
            {
                ciudades[i] = ciudades[i - 1];
            }
            cantidad++;

            do
            {
                Console.WriteLine("Nombre: ");
                ciudades[posicionInsertar].nombre = Console.ReadLine();
            }
            while (ciudades[posicionInsertar].nombre == "");

            do
            {
                Console.WriteLine("País: ");
                ciudades[posicionInsertar].pais = Console.ReadLine();
            }
            while (ciudades[posicionInsertar].pais == "");

            Console.WriteLine("Población: ");
            string leer1 = Console.ReadLine();
            if (leer1 == "")
            {
                ciudades[posicionInsertar].poblacion = 0;
            }
            else
            {
                ciudades[posicionInsertar].poblacion = Convert.ToInt32(
                    Console.ReadLine());
            }
        }
    }

    private static void EditarCiudad(tipoCiudad[] ciudades, int cantidad)
    {
        int posicionEditar;
        do
        {
            Console.WriteLine("Editar. Número de registro (0 para cancelar): ");
            posicionEditar = Convert.ToInt32(Console.ReadLine());
        }
        while (posicionEditar < 0 || posicionEditar > cantidad);

        posicionEditar = posicionEditar - 1;
        if (posicionEditar == 0)
        {
            Console.WriteLine("Cancelado");
        }
        else
        {
            Console.WriteLine("Nombre: " + ciudades[posicionEditar].nombre);
            string cambio = Console.ReadLine();
            if (cambio != "")
            {
                cambio = cambio.Trim();
                while (cambio.Contains("  "))
                {
                    cambio = cambio.Replace("  ", " ");
                }
                ciudades[posicionEditar].nombre = cambio;
            }

            Console.WriteLine("País: " + ciudades[posicionEditar].pais);
            cambio = Console.ReadLine();
            if (cambio != "")
            {
                cambio = cambio.Trim();
                while (cambio.Contains("  "))
                {
                    cambio = cambio.Replace("  ", " ");
                }
                ciudades[posicionEditar].pais = cambio;
            }

            Console.WriteLine("Población: " + ciudades[posicionEditar].poblacion);
            cambio = Console.ReadLine();
            if (cambio != "")
            {
                ciudades[posicionEditar].poblacion = Convert.ToInt32(cambio);
            }
        }
    }

    private static void BuscarCiudades(tipoCiudad[] ciudades, int cantidad)
    {
        Console.WriteLine("Buscar ciudades. Introduce el texto: ");
        string textoBuscar = Console.ReadLine();
        for (int i = 0; i < cantidad; i++)
        {
            if ((ciudades[i].nombre.ToLower().Contains(textoBuscar.ToLower()))
                || (ciudades[i].pais.ToLower().Contains(textoBuscar.ToLower())))
            {
                Console.Write("{0}- {1}, {2},",
                    i + 1, ciudades[i].nombre, ciudades[i].pais);
                if (ciudades[i].poblacion == 0)
                {
                    Console.WriteLine("población: desconocida");
                }
                else
                {
                    Console.WriteLine("población: {0}", ciudades[i].poblacion);
                }

            }
            if (i % 24 == 23)
            {
                Console.ReadLine();
            }
        }
    }

    private static void MostrarCiudades(tipoCiudad[] ciudades, int cantidad)
    {
        int tope = 24;
        bool seguir = true;
        int pos = 0;
        while (pos < cantidad && seguir)
        {
            string nombre = ciudades[pos].nombre;
            if (nombre.Length > 20)
                nombre = nombre.Substring(0, 20) + "...";

            string pais = ciudades[pos].pais;
            if (pais.Length > 40)
                pais = pais.Substring(0, 40).Replace(" ", "");

            Console.WriteLine("{0}- {1}, {2}", pos + 1, nombre, pais);

            if (pos % tope == tope - 1)
            {
                string respuesta = Console.ReadLine();
                if (respuesta != "fin")
                {
                    seguir = false;
                }
            }
            pos++;
        }
    }

    private static int AnadirCiudad(tipoCiudad[] ciudades, int cantidad, int CANTIDAD_MAX)
    {
        if (cantidad >= CANTIDAD_MAX)
        {
            Console.WriteLine("Biblioteca llena");
        }
        else
        {
            do
            {
                Console.WriteLine("Nombre: ");
                ciudades[cantidad].nombre = Console.ReadLine();
            }
            while (ciudades[cantidad].nombre == "");

            do
            {
                Console.WriteLine("País: ");
                ciudades[cantidad].pais = Console.ReadLine();
            }
            while (ciudades[cantidad].pais == "");

            Console.WriteLine("Población: ");
            string respuesta = (Console.ReadLine());
            if (respuesta == "")
            {
                ciudades[cantidad].poblacion = 0;
            }
            else
            {
                ciudades[cantidad].poblacion = Convert.ToInt32(respuesta);
            }
            cantidad++;
        }

        return cantidad;
    }

    private static void MostrarMenu()
    {
        Console.WriteLine((int)opcionesMenu.ANYADIR
                        + " - Añadir una nueva ciudad");
        Console.WriteLine((int)opcionesMenu.MOSTRAR
            + " - Mostrar todas las ciudades");
        Console.WriteLine((int)opcionesMenu.BUSCAR
            + " - Buscar ciudades por texto");
        Console.WriteLine((int)opcionesMenu.EDITAR
            + " - Editar un registro");
        Console.WriteLine((int)opcionesMenu.INSERTAR
            + " - Insertar un registro, en cierta posición");
        Console.WriteLine((int)opcionesMenu.ELIMINAR
            + " - Eliminar un registro");
        Console.WriteLine((int)opcionesMenu.ORDENAR
            + " - Ordenar los datos");
        Console.WriteLine((int)opcionesMenu.ERRORES
            + " - Encontrar posibles errores ortográficos");
        Console.WriteLine("T - Terminar");
    }
}

