// Juan Carlos (...), retoques por Nacho

/* 190. Crea una nueva versión del ejercicio 113 (biblioteca + funciones), en la que no se utilice un array
 * para los datos, sino una lista con tipo. Debes partir de la "solución oficial" y respetar su estructura
 * básica, si bien las funciones ya no necesitarán recibir la cantidad de datos como parámetro (porque se
 * puede deducir, al tratarse de una lista) y cambiará la forma de añadir y borrar. */

using System;
using System.Collections.Generic;

class Ejercicio190
{
    struct Libro : IComparable<Libro>
    {
        public string titulo;
        public string autor;
        public short anyoPubli;
        
        public int CompareTo(Libro otro)
        {
            return titulo.CompareTo(otro.titulo);
        }
    }

    static void Main()
    {
        const byte BLOQUE = 18;
        const string SALIR = "S",
            ANADIR = "1", VERTODO = "2", BUSCARTITULO = "3",
            BUSCARFECHA = "4", MODIFICAR = "5", BORRAR = "6",
            ORTOGRAFIA = "7";

        List<Libro> libros = new List<Libro>();
        string opcion;

        do
        {
            opcion = MostrarMenuYEscoger();

            switch (opcion)
            {
                case ANADIR:
                    AnyadirLibro(libros);
                    break;

                case VERTODO:
                    MostrarLibros(libros, BLOQUE);
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

                case ORTOGRAFIA:
                    ComprobarOrtografia(libros);
                    break;

                case SALIR:
                    Console.WriteLine("¡Adios!");
                    break;

                default:
                    Console.WriteLine("Opcion no válida!");
                    break;
            }

        }
        while (opcion != SALIR);
    }

    static string MostrarMenuYEscoger()
    {
        Console.WriteLine("===============MENU===============");
        Console.WriteLine("1" + "-Añadir un libro");
        Console.WriteLine("2" + "-Mostrar todos los libros");
        Console.WriteLine("3" + "-Buscar por título");
        Console.WriteLine("4" + "-Buscar entre fechas");
        Console.WriteLine("5" + "-Modificar libro");
        Console.WriteLine("6" + "-Borrar libro");
        Console.WriteLine("7" + "-Revisar ortografía");
        Console.WriteLine("S" + "-Salir");
        Console.WriteLine();
        Console.Write("Opción?: ");
        return Console.ReadLine().ToUpper();
    }

    static void AnyadirLibro(List<Libro> libros)
    {
        Libro nuevoLibro = new Libro();
        nuevoLibro.titulo = PedirNoVacio("Titulo?: ");
        nuevoLibro.autor = PedirNoVacio("Autor?: ");

        // Año -1 si no se escribe nada
        string anyo = Pedir("Año de publicacion?: ");
        if (anyo == "")
        {
            nuevoLibro.anyoPubli = -1;
        }
        else
        {
            nuevoLibro.anyoPubli = Convert.ToInt16(anyo);
        }

        libros.Add(nuevoLibro);

        Ordenar(libros);
    }

    static void Ordenar(List<Libro> libros)
    {
        libros.Sort();
    }

    static void MostrarLibros(List<Libro> libros, byte bloque)
    {
        if (libros.Count == 0)
            Console.WriteLine("Sin datos");
        else
            for (int i = 0; i < libros.Count; i++)
            {
                string anyoMostrar = Convert.ToString(
                    libros[i].anyoPubli);

                if (anyoMostrar == "-1")
                    anyoMostrar = "Año desconocido";

                Console.WriteLine(
                    "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    i + 1, libros[i].titulo, libros[i].autor,
                    anyoMostrar);

                if ((i + 1) % bloque == 0)
                {
                    Console.ReadLine();
                }
            }
        Console.WriteLine();
    }

    static void BuscarTitulo(List<Libro> libros)
    {
        Console.Write("BUSCAR. Titulo?: ");
        string buscar = Console.ReadLine();
        if (buscar != "")
        {
            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].titulo.ToUpper().Contains(buscar.ToUpper())
                    || libros[i].autor.ToUpper().Contains(buscar.ToUpper()))
                {
                    Console.WriteLine(
                        "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                        i + 1, libros[i].titulo, libros[i].autor,
                        libros[i].anyoPubli);
                }
            }
        }
    }

    static void BuscarFecha(List<Libro> libros)
    {
        Console.WriteLine("BUSCAR. RANGO AÑO DE PUBLICACION");
        Console.Write("Entre año: ");
        ushort fecha1 = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Y año: ");
        ushort fecha2 = Convert.ToUInt16(Console.ReadLine());

        // Invertir fechas si están al revés
        ushort fechaInicial = fecha1 > fecha2 ? fecha1 : fecha2;
        ushort fechaFinal = fecha1 < fecha2 ? fecha1 : fecha2;

        for (int i = 0; i < libros.Count; i++)
        {
            if (libros[i].anyoPubli >= fechaInicial &&
                    libros[i].anyoPubli <= fechaFinal)
            {
                Console.WriteLine(
                    "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    i + 1, libros[i].titulo, libros[i].autor,
                    libros[i].anyoPubli);
            }
        }
    }

    static void Modificar(List<Libro> libros)
    {
        Console.Write("Número de registro?: ");
        int numRegistro = Convert.ToInt32(Console.ReadLine());
        if (numRegistro >= 1 && numRegistro <= libros.Count)
        {
            Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    numRegistro, libros[numRegistro - 1].titulo,
                    libros[numRegistro - 1].autor,
                    libros[numRegistro - 1].anyoPubli);

            Libro libroMod = libros[numRegistro-1];

            Console.Write("Titulo?: ");
            string cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libroMod.titulo = cadenaAux;

            Console.Write("Autor?:");
            cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libroMod.autor = cadenaAux;

            Console.Write("Año de publicacion?: ");
            cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libroMod.anyoPubli =
                    Convert.ToInt16(cadenaAux);

            libros[numRegistro-1] = libroMod;
            ComprobarMayusculas(libros[numRegistro - 1]);
        }
    }

    static void Borrar(List<Libro> libros)
    {
        int numRegistro;
        Console.Write("Numero de registro?: ");
        numRegistro = Convert.ToInt32(Console.ReadLine());
        if (numRegistro >= 1 && numRegistro <= libros.Count)
        {
            Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    numRegistro, libros[numRegistro - 1].titulo,
                        libros[numRegistro - 1].autor,
                            libros[numRegistro - 1].anyoPubli);
            Console.Write(
                "Seguro que quieres borrar este libro? Si/No:");
            string siNo = Console.ReadLine().ToUpper();
            if (siNo == "SI" || siNo == "S")
            {
                libros.RemoveAt(numRegistro-1);
            }
        }
    }

    static void ComprobarOrtografia(List<Libro> libros)
    {
        for (int i = 0; i < libros.Count; i++)
        {
            bool fichaCorrecta = true;
            string titulo = libros[i].titulo;
            int longitud = titulo.Length;

            // Contiene espacios duplicados?
            if (titulo.Contains("  "))
            {
                fichaCorrecta = false;
            }

            // Empieza o termina en espacio?
            if (titulo[0] == ' ' || titulo[longitud - 1] == ' ')
            {
                fichaCorrecta = false;
            }

            // Minúscula justo antes de mayúscula
            for (int l = 0; l < longitud - 1; l++)
            {

                if ((titulo[l] >= 'a') && (titulo[l] <= 'z')
                    && (titulo[l + 1] >= 'A') && (titulo[l + 1] <= 'Z'))
                {
                    fichaCorrecta = false;
                }
            }

            if (!fichaCorrecta)
            {
                Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    i + 1, libros[i].titulo,
                        libros[i].autor, libros[i].anyoPubli);
                Console.Write("¿Desea arreglar este registro (s/n)? ");
                string corregir = Console.ReadLine().ToUpper();
                if (corregir == "S")
                {
                    Libro libroCorregido = libros[i];
                    libroCorregido.titulo = libros[i].titulo.Trim();
                    libroCorregido.titulo = QuitarEspaciosRedundantes(libros[i].titulo);
                    libroCorregido.titulo = CorregirMayusculas(libros[i].titulo);
                }
            }
        }
    }


    static void ComprobarMayusculas(Libro l)
    {
        // Avisos de mayúsculas, minúsculas, espacios
        if (l.autor == l.autor.ToUpper()) Console.WriteLine("Cuidado: Autor en mayúsculas");
        if (l.titulo == l.titulo.ToUpper()) Console.WriteLine("Cuidado: Título en mayúsculas");
        if (l.autor == l.autor.ToLower()) Console.WriteLine("Cuidado: Autor en minúsculas");
        if (l.titulo == l.titulo.ToLower()) Console.WriteLine("Cuidado: Título en inúsculas");
        if (l.autor.Contains("  ")) Console.WriteLine("Cuidado: Autor con espacios de sobra");
        if (l.titulo.Contains("  ")) Console.WriteLine("Cuidado: Título con espacios de sobra");
    }


    static string Pedir(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }


    static string PedirNoVacio(string mensaje)
    {
        string respuesta;

        do
        {
            Console.Write(mensaje);
            respuesta = Console.ReadLine();
        }
        while (respuesta == "");

        return respuesta;
    }

    static string QuitarEspaciosRedundantes(string texto)
    {
        while (texto.Contains("  "))
            texto = texto.Replace("  ", " ");
        return texto;
    }

    static string CorregirMayusculas(string texto)
    {
        // Fase 1: 1ª mayúscula, resto minúscula
        texto = texto.ToUpper()[0] + texto.ToLower().Substring(1);
        // Fase 2: Mays tras cada punto
        bool proxMayuscula = false;
        for (int l = 1; l < texto.Length - 1; l++)
        {
            if (texto[l - 1] == '.')
                proxMayuscula = true;

            if ((texto[l] >= 'a') && (texto[l] <= 'z')
                && proxMayuscula)
            {
                texto = texto.Insert(l, texto.ToUpper().Substring(l, 1));
                texto = texto.Remove(l + 1, 1);
                proxMayuscula = false;
            }
        }
        return texto;
    }
}
