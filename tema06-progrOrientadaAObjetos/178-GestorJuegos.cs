/* 178. Crea una nueva versión del gestor de juegos de ordenador 
 * (ejercicio 092), con los siguientes cambios:

- El dato base no debe ser un "struct", sino un "class".

- Debes descomponer el programa en funciones, tanto de cara a simplificar Main
como de cara a eliminar código repetitivo.

- La opción 7 (ordenar) debe emplear "Array.Sort", para lo que deberás
implementar la interfaz "IComparable". Recuerda usar el formato
Array.Sort(array, inicio, cantidad), al tratarse de un array sobredimensionado.

Luis (...), retoques menores por Nacho */

using System;

public class Juego : IComparable<Juego>
{

    // Propiedades correctas
    public string Titulo { get; set; }
    public string Categoria { get; set; }
    public string Plataforma { get; set; }
    public short Anyo { get; set; }
    public float Calificacion { get; set; }
    public string Comentarios { get; set; }

    // Constructor con parámetros
    public Juego(string titulo, string categoria, string plataforma, short anyo, float calificacion, string comentarios)
    {
        this.Titulo = titulo;
        this.Categoria = categoria;
        this.Plataforma = plataforma;
        this.Anyo = anyo;
        this.Calificacion = calificacion;
        this.Comentarios = comentarios;
    }
    public Juego()
    {
    }

    public int CompareTo(Juego otro)
    {

        if (Titulo != otro.Titulo)
        {
            return Titulo.CompareTo(otro.Titulo);
        }
        else
        {
            return Plataforma.CompareTo(otro.Plataforma);
        }
    }
}

// --------------

public class GestorDeJuegos
{
    static void Main()
    {
        const int CAPACIDAD = 10000;
        Juego[] juegos = new Juego[CAPACIDAD];
        int contador = 0;
        bool terminado = false;

        do
        {
            MostrarMenu();
            string opcion = Console.ReadLine().ToUpper();

            switch (opcion)
            {
                case "1":
                    AgregarJuego(juegos, ref contador, CAPACIDAD);
                    break;

                case "2":
                    MostrarDatos(juegos, contador);
                    break;

                case "3":
                    MostrarTodosLosJuegos(juegos, contador)
                    break;

                case "4":
                    BuscarJuego(juegos, contador);
                    break;

                case "5":
                    ModificarJuego(juegos, contador);
                    break;

                case "6":
                    EliminarRegistro(juegos, ref contador);
                    break;

                case "7":
                    Ordenar(juegos, contador);
                    break;

                case "8":
                    EliminarEspaciosRedundantes(juegos, contador);
                    break;

                case "S":
                    terminado = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;

            }
        }
        while (!terminado);

        Console.WriteLine("HASTA PRONTO");
    }



static void MostrarMenu()
{
    Console.WriteLine();
    Console.WriteLine("MENÚ");
    Console.WriteLine("Elija una opción.");
    Console.WriteLine("1. Añadir un juego nuevo");
    Console.WriteLine("2. Mostrar datos de un juego");
    Console.WriteLine("3. Juegos de una determinada plataforma y categoría");
    Console.WriteLine("4. Buscar juegos que contengan un determinado texto");
    Console.WriteLine("5. Modificar un registro");
    Console.WriteLine("6. Eliminar un registro");
    Console.WriteLine("7. Ordenar los datos alfabéticamente");
    Console.WriteLine("8. Eliminar espacios redundantes");
    Console.WriteLine("S. Salir");
    Console.WriteLine();
}

static void AgregarJuego(Juego[] juegos, ref int contador, int CAPACIDAD)
{
    float calificacionAux;

    if (contador < CAPACIDAD)
    {
        juegos[contador] = new Juego();
        Console.WriteLine("INTRODUZCA DATOS DEL NUEVO JUEGO");
        Console.WriteLine();
        string tituloAux;
        do
        {
            Console.Write("Título: ");
            tituloAux = Console.ReadLine();
            if (!string.IsNullOrEmpty(tituloAux))
            {
                juegos[contador].Titulo = tituloAux;
            }
            else
            {
                Console.WriteLine("El título no puede estar vacío.");
            }
        }
        while (string.IsNullOrEmpty(tituloAux));

        string descripcionAux;
        do
        {
            Console.Write("Comentarios: ");
            descripcionAux = Console.ReadLine();
            if (descripcionAux != "")
            {
                juegos[contador].Comentarios = descripcionAux;
            }
            else
            {
                Console.WriteLine("La descripción no puede estar vacía");
            }
        }
        while (descripcionAux == "");

        short anyoAux;
        do
        {
            Console.WriteLine("Categoría: ");
            anyoAux = Convert.ToInt16(Console.ReadLine());
            if ((anyoAux >= 1940) && (anyoAux <= 2100))
            {
                juegos[contador].Anyo = anyoAux;
            }
            else
            {
                Console.WriteLine("El año debe estar entre 1940 y 2100");
            }
        }
        while ((anyoAux < 1940) || (anyoAux > 2100));

        do
        {
            Console.WriteLine("Calificación: ");
            calificacionAux = Convert.ToSingle(Console.ReadLine());
            if ((calificacionAux >= 0) && (calificacionAux <= 10))
            {
                juegos[contador].Calificacion = calificacionAux;
            }
            else
            {
                Console.WriteLine("La calificación debe estar entre 0 y 10");
            }
        }
        while ((calificacionAux < 0) || (calificacionAux > 10));

        Console.WriteLine("Categoría: ");
        juegos[contador].Categoria = Console.ReadLine();
        Console.WriteLine("Plataforma: ");
        juegos[contador].Plataforma = Console.ReadLine();

        contador++;
    }
}

static void MostrarDatos(Juego[] juegos, int contador)
{
    bool encontrado = false;
    string tituloAux;
    Console.Write("Para buscar por título pulsa \"T\""
        + " para buscar por registro pulsa \"R\": ");
    string opcion = Console.ReadLine();
    do
    {
        if (opcion.ToUpper() == "R")
        {
            Console.Write("Introduzca el número de registro: ");
            int registroAux = Convert.ToInt32(Console.ReadLine()) - 1;
            if (registroAux >= 0 && registroAux < contador)
            {
                Console.WriteLine("Título: " + juegos[registroAux].Titulo);
                Console.WriteLine("Categoría: " + juegos[registroAux].Categoria);
                Console.WriteLine("Plataforma: " + juegos[registroAux].Plataforma);
                Console.WriteLine("Año: " + juegos[registroAux].Anyo);
                Console.WriteLine("Calificación: " + juegos[registroAux].Calificacion);
                Console.WriteLine("Comentarios: " + juegos[registroAux].Comentarios);
            }
            else
            {
                Console.WriteLine("Número no válido");
            }
        }
        else if (opcion.ToUpper() == "T")
        {
            Console.Write("Introduzca el título a buscar: ");
            tituloAux = Console.ReadLine();
            {
                for (int i = 0; i < contador; i++)
                {
                    if (tituloAux.ToUpper() == juegos[i].Titulo.ToUpper())
                    {
                        Console.WriteLine();
                        Console.WriteLine("Número de registro: " + (i + 1));
                        Console.WriteLine("Título: " + juegos[i].Titulo);
                        Console.WriteLine("Categoría: " + juegos[i].Categoria);
                        Console.WriteLine("Plataforma: " + juegos[i].Plataforma);
                        Console.WriteLine("Año: " + juegos[i].Anyo);
                        Console.WriteLine("Calificación: " + juegos[i].Calificacion);
                        Console.WriteLine("Comentarios: " + juegos[i].Comentarios);
                        encontrado = true;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se ha encontrado");
                }
            }
        }
        else
        {
            Console.WriteLine("Debe pulsar \"T\" o \"R\"");
        }
    }
    while ((opcion.ToUpper() != "T") && (opcion.ToUpper() != "R"));
}

static void MostrarTodosLosJuegos(Juego[] juegos, int contador)
{
    Console.Write("Instroduzca la plataforma a filtrar: ");
    string plataformaAux = Console.ReadLine();
    Console.Write("Introduzca la categoría a filtrar");
    string categoriaAux = Console.ReadLine();

    bool encontrado = false;
    for (int i = 0; i < contador; i++)
    {
        if ((categoriaAux == juegos[i].Categoria)
            && (plataformaAux == juegos[i].Plataforma))
        {
            Console.WriteLine();
            Console.WriteLine("Número de registro: " + (i + 1));
            Console.WriteLine("Año: " + juegos[i].Anyo);
            Console.WriteLine("Calificación: " + juegos[i].Calificacion);
        }

        if (i % 22 == 21)
        {
            Console.WriteLine();
        }
    }
    if (!encontrado)
    {
        Console.WriteLine("No se encontró ningún juego con las"
            + " especificaciones solicitadas");
    }
}

static void BuscarJuego(Juego[] juegos, int contador)
{
    Console.Write("Introduce el texto a buscar: ");
    string textoBuscar = Console.ReadLine();

    bool encontrado = false;
    for (int i = 0; i < contador; i++)
    {
        if ((juegos[i].Titulo.ToUpper().Contains(textoBuscar.ToUpper())) ||
            (juegos[i].Categoria.ToUpper().Contains(textoBuscar.ToUpper())) ||
            (juegos[i].Plataforma.ToUpper().Contains(textoBuscar.ToUpper())) ||
            (juegos[i].Comentarios.ToUpper().Contains(textoBuscar.ToUpper())))
        {
            Console.Write((i + 1) + " - " + juegos[i].Titulo);
            Console.WriteLine("- Calif.: " + juegos[i].Calificacion);
        }

        if (i % 22 == 21)
        {
            Console.WriteLine();
        }
    }
    if (!encontrado)
    {
        Console.WriteLine("No se encontró ese texto");
    }
}

static int ModificarJuego(Juego[] juegos, int contador)
{
    short anyoAux;
    float calificacionAux;
    int registroAux;
    Console.WriteLine("Introduzca el número de "
                    + "resgistro del juego a modificar:");
    registroAux = Convert.ToInt32(Console.ReadLine());

    if ((registroAux <= contador) && (registroAux > 0))
    {
        Console.WriteLine();
        Console.WriteLine("MODIFICANDO DATOS DEL JUEGO: "
            + juegos[registroAux - 1].Titulo);
        Console.WriteLine();

        //Modificamos los datos de [registro-1] porque
        //el usuario comienza a contar desde 1.

        Console.WriteLine("Título actual: " + juegos[registroAux - 1].Titulo);
        Console.Write("Título nuevo: ");
        string tituloAux = Console.ReadLine();
        if (tituloAux != "")
        {
            juegos[registroAux - 1].Titulo = tituloAux;
        }

        Console.WriteLine("Categoría actual: " + juegos[registroAux - 1].Categoria);
        Console.Write("Categoría nueva: ");
        string categoriaAux = Console.ReadLine();
        if (categoriaAux != "")
        {
            juegos[registroAux - 1].Categoria = categoriaAux;
        }

        Console.WriteLine("Plataforma actual: " + juegos[registroAux - 1].Plataforma);
        Console.Write("Plataforma nueva: ");
        string plataformaAux = Console.ReadLine();
        if (plataformaAux != "")
        {
            juegos[registroAux - 1].Plataforma = plataformaAux;
        }

        Console.WriteLine("Comentario actual: " + juegos[registroAux - 1].Comentarios);
        Console.Write("Nuevo comentario: ");
        string descripcionAux = Console.ReadLine();
        if (descripcionAux != "")
        {
            juegos[registroAux - 1].Comentarios = descripcionAux;
        }

        Console.WriteLine("Año actual: " + juegos[registroAux - 1].Anyo);
        do
        {
            Console.Write("Año nuevo: ");
            anyoAux = Convert.ToInt16(Console.ReadLine());
            if ((anyoAux >= 1940) && (anyoAux <= 2100))
            {
                juegos[registroAux - 1].Anyo = anyoAux;
            }
            else
            {
                Console.WriteLine("El año debe estar entre 1940 y 2100");
            }
        } while ((anyoAux < 1940) || (anyoAux > 2100));

        Console.WriteLine("Calificación actual: " + juegos[registroAux - 1].Calificacion);
        do
        {
            Console.WriteLine("Calificación nueva : ");
            calificacionAux = Convert.ToSingle(Console.ReadLine());
            if ((calificacionAux >= 0) && (calificacionAux <= 10))
            {
                juegos[registroAux - 1].Calificacion = calificacionAux;
            }
            else
            {
                Console.WriteLine("La calificación debe estar entre 0 y 10");
            }
        } while ((calificacionAux < 0) || (calificacionAux > 10));

        Console.WriteLine("DATOS MODIFICADOS CORRECTAMENTE");
    }
    else
    {
        Console.WriteLine("Número de registro no válido");
    }

    return registroAux;
}

static int EliminarRegistro(Juego[] juegos, ref int contador)
{
    int registroAux;
    Console.WriteLine("Introduzca el número de "
                            + "resgistro del juego a borrar:");
    registroAux = Convert.ToInt32(Console.ReadLine());

    if ((registroAux <= contador) && (registroAux != 0))
    {
        //Mostramos los datos del registro actuales
        Console.WriteLine();
        Console.WriteLine("Número de registro: " + registroAux);
        Console.WriteLine("Título: " + juegos[registroAux - 1].Titulo);
        Console.WriteLine("Categoría: " + juegos[registroAux - 1].Categoria);
        Console.WriteLine("Plataforma: " + juegos[registroAux - 1].Plataforma);
        Console.WriteLine("Año: " + juegos[registroAux - 1].Anyo);
        Console.WriteLine("Calificación: " + juegos[registroAux - 1].Calificacion);
        Console.WriteLine("Comentarios: " + juegos[registroAux - 1].Comentarios);

        //Pedimos confirmación
        Console.WriteLine("Para confirmar el borrado pulse \"B\"");
        string opcion = Console.ReadLine();
        if (opcion.ToUpper() == "B")
        {
            for (int i = (registroAux - 1); i < contador; i++)
            {
                juegos[i] = juegos[i + 1];
            }
            contador--;
            Console.WriteLine("JUEGO BORRADO CORRECTAMENTE");
        }
    }
    else
    {
        Console.WriteLine("Número de registro no válido");
    }

    return registroAux;
}

    static void Ordenar(Juego[] juegos, int contador)
    {
        if (contador > 1)
        {
            Array.Sort(juegos, 0, contador);
            Console.WriteLine("Juegos ordenados correctamente.");
        }
        else
        {
            Console.WriteLine("No hay suficientes juegos para ordenar.");
        }
    }

    static void EliminarEspaciosRedundantes(Juego[] juegos, int contador)
    {
        for (int i = 0; i < contador; i++)
        {
            juegos[i].Comentarios = juegos[i].Comentarios.Trim();
            while (juegos[i].Comentarios.Contains("  "))
            {
                juegos[i].Comentarios = juegos[i].Comentarios.Replace("  ", " ");
            }

            juegos[i].Categoria = juegos[i].Categoria.Trim();
            while (juegos[i].Categoria.Contains("  "))
            {
                juegos[i].Categoria = juegos[i].Categoria.Replace("  ", " ");
            }

            juegos[i].Plataforma = juegos[i].Plataforma.Trim();
            while (juegos[i].Plataforma.Contains("  "))
            {
                juegos[i].Plataforma = juegos[i].Plataforma.Replace("  ", " ");
            }
        }
        Console.WriteLine("Espacios redundantes revisados");
    }
}
