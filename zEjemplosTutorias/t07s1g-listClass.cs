// Versión alternativa del ejercicio de la última tutoría
// (colección de libros con class y funciones), usando una
// lista en vez de un array.

/*

Versión mejorada, con clases, funciones y posibilidad de ordenar,
de este ejercicio:

---

88. Biblioteca. Examen del tema 4, 2016, grupo presencial, versión 
simplificada. 

Crea un programa en C# que pueda almacenar hasta 25000 libros. Para 
cada libro, debe permitir al usuario almacenar la siguiente 
información:

    • Título (por ejemplo, El resplandor)

    • Autor (por ejemplo, Stephen King)

    • Año de publicación (p. Ej., 1977)

El programa debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir un libro nuevo. El título y el autor no pueden estar vacíos.

2 - Mostrar todos los libros (número de registro, título, autor y año, 
en una misma línea), haciendo una pausa tras cada 18 filas.

3 - Buscar libros que tengan un cierto título. Se debe mostrar el 
número de registro, el título, el autor y el año, todo ello en una 
misma línea.

4 - Buscar libros publicados entre dos fechas (por ejemplo, 1970 y 
1985), ambas incluidas. Nuevamente, debe mostrar el número de registro, 
el título, el autor y el año.

5 - Modificar un registro: solicitará al usuario el número de registro, 
mostrará el valor anterior de cada campo y permitirá al usuario pulsar 
Intro sin escribir nada, en caso de que prefiera no modificar alguno de 
los campos. Se avisará al usuario (pero no se le volverá a preguntar) 
si introduce un número de registro incorrecto.

6 - Eliminar un registro, en la posición indicada por el usuario. Se 
debe avisar (pero no volver a preguntar) si introduce un número de 
registro incorrecto. Deberá mostrar el registro que se eliminará y 
solicitar confirmación antes de borrarlo.

S - Salir (como no almacenamos la información en fichero, los datos se 
perderán).

*/


using System;
using System.Collections.Generic;

class Ejercicio88
{
    class Libro : IComparable<Libro>
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public ushort Publicacion { get; set; }

        public int CompareTo(Libro otro)
        {
            if (Titulo != otro.Titulo)
                return Titulo.CompareTo(otro.Titulo);
            else
                return Autor.CompareTo(otro.Autor);
        }
    }

    static void Main()
    {
        const char ANADIR = '1', VERTODOS = '2', BUSCARTITULO = '3',
            BUSCARFECHA = '4', MODIFICAR = '5', BORRAR = '6', ORDENAR = '7',
            SALIR1 = 'S', SALIR2 = 's';
        const byte PAGINA = 18;
        List<Libro> libros = new List<Libro>();
        char opcion;
        bool terminado = false;

        do
        {

            Console.WriteLine("========================");
            Console.WriteLine("**        MENU        **");
            Console.WriteLine("========================");
            Console.WriteLine(" " + ANADIR + ". Añadir libro");
            Console.WriteLine(" " + VERTODOS + ". Ver todos los libros");
            Console.WriteLine(" " + BUSCARTITULO + ". Buscar por titulo");
            Console.WriteLine(" " + BUSCARFECHA + ". Buscar por publicacion");
            Console.WriteLine(" " + MODIFICAR + ". Modificar un libro");
            Console.WriteLine(" " + BORRAR + ". Borrar un libro");
            Console.WriteLine(" " + ORDENAR + ". Ordenar libros");
            Console.WriteLine("------------------------");
            Console.WriteLine(" " + SALIR1 + ". Salir");
            Console.WriteLine("========================");
            Console.Write(" > Opción: ");
            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case ANADIR:
                    Anyadir(libros);
                    break;

                case VERTODOS:
                    VerTodos(libros, PAGINA);
                    break;

                case BUSCARTITULO:
                    BuscarTitulo(libros);
                    break;

                case BUSCARFECHA:
                    BuscarFecha(libros);
                    break;

                case MODIFICAR:
                    Modificar(libros);
                    break;

                case BORRAR:
                    Borrar(libros);
                    break;

                case ORDENAR:
                    Ordenar(libros);
                    break;

                case SALIR1:
                case SALIR2:
                    Console.WriteLine("Saliendo...");
                    terminado = true;
                    break;

                default:                // Error de entrada
                    Console.WriteLine("ERROR. Opción incorrecta.");
                    break;
            }
        }
        while (!terminado);
    }

    private static void Anyadir(List<Libro> libros)
    {
        Libro l = new Libro();
        do
        {
            Console.Write("Titulo : ");
            l.Titulo = Console.ReadLine();
            if (l.Titulo == "")
            {
                Console.WriteLine("Se necesita un titulo.");
            }
        }
        while (l.Titulo == "");

        do
        {
            Console.Write("Autor: ");
            l.Autor = Console.ReadLine();
            if (l.Autor == "")
            {
                Console.WriteLine("Se necesita un autor.");
            }
        }
        while (l.Autor == "");

        Console.Write("Año de publicacion: ");
        l.Publicacion =
            Convert.ToUInt16(Console.ReadLine());

        libros.Add(l);
    }

    private static void VerTodos(List<Libro> libros, byte PAGINA)
    {
        for (int i = 0; i < libros.Count; i++)
        {
            Console.WriteLine(
                "{0}: Titulo: {1} - Autor: {2} - Año: {3}",
                i + 1, libros[i].Titulo, libros[i].Autor,
                libros[i].Publicacion);
            if ((i + 1) % PAGINA == 0)
            {
                Console.Write("Pulsa Intro para seguir... ");
                Console.ReadLine();
            }
        }
    }

    private static void BuscarTitulo(List<Libro> libros)
    {
        bool tituloEncontrado = false;
        Console.Write("Título a buscar: ");
        string titulo = Console.ReadLine();
        if (titulo != "")
        {
            for (int i = 0; i < libros.Count; i++)
            {
                if (titulo == libros[i].Titulo)
                {
                    Console.WriteLine(
                        "{0}: Titulo: {1} - Autor: {2} - Año: {3}",
                        i + 1, libros[i].Titulo, libros[i].Autor,
                        libros[i].Publicacion);
                    tituloEncontrado = true;
                }
            }
        }
        else
        {
            Console.WriteLine("Debe indicar un título");
        }

        if (!tituloEncontrado)
        {
            Console.WriteLine("No encontrado");
        }
    }

    private static void BuscarFecha(List<Libro> libros)
    {
        bool fechaEncontrada = false;
        Console.Write("Año de inicio: ");
        ushort fechaInicio = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Año de fin: ");
        ushort fechaFin = Convert.ToUInt16(Console.ReadLine());

        for (int i = 0; i < libros.Count; i++)
        {
            if (libros[i].Publicacion >= fechaInicio
                && libros[i].Publicacion <= fechaFin)
            {
                Console.WriteLine(
                    "{0}: Titulo: {1} - Autor: {2} - Año: {3}",
                    i + 1, libros[i].Titulo, libros[i].Autor,
                    libros[i].Publicacion);
                fechaEncontrada = true;
            }
        }

        if (!fechaEncontrada)
        {
            Console.WriteLine("No encontrado");
        }
    }

    private static void Modificar(List<Libro> libros)
    {
        Console.Write("Introduce el registro a modificar: ");
        ushort registro = Convert.ToUInt16(Console.ReadLine());

        if (registro > libros.Count || registro < 0)
        {
            Console.WriteLine("ERROR. Registro incorrecto.");
        }
        else
        {
            Libro l = libros[registro - 1];
            Console.WriteLine(
                "Pulsa Intro si no quieres modificar algún dato: ");

            Console.WriteLine("Titulo (era {0})",
                l.Titulo);
            string nuevoTitulo = Console.ReadLine();
            if (nuevoTitulo != "")
            {
                l.Titulo = nuevoTitulo;
            }

            Console.WriteLine("Autor (era {0})",
                l.Autor);
            string nuevoAutor = Console.ReadLine();
            if (nuevoAutor != "")
            {
                l.Autor = nuevoAutor;
            }

            Console.WriteLine("Publicación (era {0})",
                l.Publicacion);
            string nuevaPublicacion = Console.ReadLine();
            if (nuevaPublicacion != "")
            {
                ushort nuevaFechaPublicacion =
                    Convert.ToUInt16(nuevaPublicacion);
                l.Publicacion = nuevaFechaPublicacion;
            }

            libros[registro - 1] = l;
        }
    }

    private static void Borrar(List<Libro> libros)
    {
        Console.Write("Introduce el registro a borrar: ");
        ushort borrar = Convert.ToUInt16(Console.ReadLine());

        if (borrar > libros.Count || borrar < 0)
        {
            Console.WriteLine("ERROR. Registro incorrecto.");
        }
        else
        {
            Console.WriteLine("{0}: Titulo: {1} - Autor: {2} - Año: {3}",
                borrar, libros[borrar - 1].Titulo, libros[borrar - 1].Autor,
                libros[borrar - 1].Publicacion);
            Console.Write("¿Está seguro de borrar este registro? S/n: ");
            char respuesta = Convert.ToChar(Console.ReadLine());
            if (respuesta == 's' || respuesta == 'S')
            {
                libros.RemoveAt(borrar - 1);
            }
        }
    }

    private static void Ordenar(List<Libro> libros)
    {
        libros.Sort();
    }
}
