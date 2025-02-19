// Haz una versión alternativa del ejercicio 088
// (colección de libros V1, con struct, sin funciones),
// usando una lista en vez de un array.


/*

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

class Ejercicio88listas
{
    struct Libro
    {
        public string titulo;
        public string autor;
        public ushort publicacion;
    }

    static void Main()
    {
        const char ANADIR = '1', VERTODOS = '2', BUSCARTITULO = '3',
            BUSCARFECHA = '4', MODIFICAR = '5', BORRAR = '6',
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
            Console.WriteLine("------------------------");
            Console.WriteLine(" " + SALIR1 + ". Salir");
            Console.WriteLine("========================");
            Console.Write(" > Opción: ");
            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case ANADIR:
                    Libro libro;
                    do
                    {
                        Console.Write("Titulo : ");
                        libro.titulo = Console.ReadLine();
                        if (libro.titulo == "")
                        {
                            Console.WriteLine("Se necesita un titulo.");
                        }
                    }
                    while (libro.titulo == "");

                    do
                    {
                        Console.Write("Autor: ");
                        libro.autor = Console.ReadLine();
                        if (libro.autor == "")
                        {
                            Console.WriteLine("Se necesita un autor.");
                        }
                    }
                    while (libro.autor == "");

                    Console.Write("Año de publicacion: ");
                    libro.publicacion =
                        Convert.ToUInt16(Console.ReadLine());
                    
                    libros.Add(libro);

                    break;

                case VERTODOS:
                    for (int i = 0; i < libros.Count; i++)
                    {
                        Console.WriteLine(
                            "{0}: Titulo: {1} - Autor: {2} - Año: {3}",
                            i + 1, libros[i].titulo, libros[i].autor,
                            libros[i].publicacion);
                        if ((i + 1) % PAGINA == 0)
                        {
                            Console.Write("Pulsa Intro para seguir... ");
                            Console.ReadLine();
                        }
                    }
                    break;

                case BUSCARTITULO:
                    bool tituloEncontrado = false;
                    Console.Write("Título a buscar: ");
                    string titulo = Console.ReadLine();
                    if (titulo != "")
                    {
                        for (int i = 0; i < libros.Count; i++)
                        {
                            if (titulo == libros[i].titulo)
                            {
                                Console.WriteLine(
                                    "{0}: Titulo: {1} - Autor: {2} - Año: {3}",
                                    i + 1, libros[i].titulo, libros[i].autor,
                                    libros[i].publicacion);
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
                    break;

                case BUSCARFECHA:
                    bool fechaEncontrada = false;
                    Console.Write("Año de inicio: ");
                    ushort fechaInicio = Convert.ToUInt16(Console.ReadLine());
                    Console.Write("Año de fin: ");
                    ushort fechaFin = Convert.ToUInt16(Console.ReadLine());

                    for (int i = 0; i < libros.Count; i++)
                    {
                        if (libros[i].publicacion >= fechaInicio
                            && libros[i].publicacion <= fechaFin)
                        {
                            Console.WriteLine(
                                "{0}: Titulo: {1} - Autor: {2} - Año: {3}",
                                i + 1, libros[i].titulo, libros[i].autor,
                                libros[i].publicacion);
                            fechaEncontrada = true;
                        }
                    }

                    if (!fechaEncontrada)
                    {
                        Console.WriteLine("No encontrado");
                    }
                    break;

                case MODIFICAR:
                    Console.Write("Introduce el registro a modificar: ");
                    ushort registro = Convert.ToUInt16(Console.ReadLine());

                    if (registro > libros.Count || registro < 0)
                    {
                        Console.WriteLine("ERROR. Registro incorrecto.");
                    }
                    else
                    {
                        Libro libroModificar = libros[registro - 1];
                        Console.WriteLine(
                            "Pulsa Intro si no quieres modificar algún dato: ");

                        Console.WriteLine("Titulo (era {0})",
                            libroModificar.titulo);
                        string nuevoTitulo = Console.ReadLine();
                        if (nuevoTitulo != "")
                        {
                            libroModificar.titulo = nuevoTitulo;
                        }

                        Console.WriteLine("Autor (era {0})",
                            libroModificar.autor);
                        string nuevoAutor = Console.ReadLine();
                        if (nuevoAutor != "")
                        {
                            libroModificar.autor = nuevoAutor;
                        }

                        Console.WriteLine("Publicación (era {0})",
                            libroModificar.publicacion);
                        string nuevaPublicacion = Console.ReadLine();
                        if (nuevaPublicacion != "")
                        {
                            ushort nuevaFechaPublicacion =
                                Convert.ToUInt16(nuevaPublicacion);
                            libroModificar.publicacion = nuevaFechaPublicacion;
                        }

                        libros[registro-1] = libroModificar;
                    }
                    break;

                case BORRAR:
                    Console.Write("Introduce el registro a borrar: ");
                    ushort borrar = Convert.ToUInt16(Console.ReadLine());

                    if (borrar > libros.Count || borrar < 0)
                    {
                        Console.WriteLine("ERROR. Registro incorrecto.");
                    }
                    else
                    {
                        Console.WriteLine("{0}: Titulo: {1} - Autor: {2} - Año: {3}",
                            borrar, libros[borrar - 1].titulo, libros[borrar - 1].autor,
                            libros[borrar - 1].publicacion);
                        Console.Write("¿Está seguro de borrar este registro? S/n: ");
                        char respuesta = Convert.ToChar(Console.ReadLine());
                        if (respuesta == 's' || respuesta == 'S')
                        {
                            libros.RemoveAt(borrar - 1);
                        }
                    }
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
}
