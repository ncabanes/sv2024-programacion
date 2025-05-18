/*
 Crea una versión alternativa del ejercicio 231 (biblioteca), partiendo de la "versión oficial"
empleando bases de datos de SQLite. En la medida de lo posible,
intenta que sólo cambie la clase "ListaDeLibros": los datos se mantendrán en memoria,
en una lista, pero se cargarán desde la base de datos al comenzar el programa,
y los cambios se reflejarán también tanto en la copia local (la lista que se almacena en memoria)
como en la base de datos:

- Al añadir un dato, se guardará en la lista y se hará una orden "INSERT" en la base de datos.

- Al borrar un dato, se eliminará de la lista y se hará una orden "DELETE" en la base de datos.

- Al modificar un dato, se eliminará de la lista y se hará una orden "UPDATE" (o REPLACE, como prefieras) en la base de datos.
 
 Por Blanca (...)
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;
using System.Xml.Serialization;

class Biblioteca
{
    static void Main()
    {
        const byte BLOQUE = 18;
        const string SALIR = "S",
            ANADIR = "1", VERTODO = "2", BUSCARTITULO = "3",
            BUSCARFECHA = "4", MODIFICAR = "5", BORRAR = "6",
            ORTOGRAFIA = "7";

        ListaDeLibros lista = new ListaDeLibros();

        string opcion;

        do
        {
            opcion = MostrarMenu();

            switch (opcion)
            {
                case ANADIR:
                    ListaDeLibros.AnyadirLibro(lista);
                    break;

                case VERTODO:
                    ListaDeLibros.MostrarLibros(lista, BLOQUE);
                    break;

                case BUSCARTITULO:
                    ListaDeLibros.BuscarTitulo(lista);
                    break;

                case BUSCARFECHA:
                    ListaDeLibros.BuscarFecha(lista);
                    break;

                case MODIFICAR:
                    ListaDeLibros.Modificar(lista);
                    break;

                case BORRAR:
                    ListaDeLibros.Borrar(lista);
                    break;

                case ORTOGRAFIA:
                    ListaDeLibros.ComprobarOrtografia(lista);
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

    static string MostrarMenu()
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
}

// -----------------------------------------------


public class Libro : IComparable<Libro>
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public short AnyoPubli { get; set; }

    public int CompareTo(Libro otro)
    {
        return Titulo.CompareTo(otro.Titulo);
    }

    public override string ToString()
    {
        return "Título: " + Titulo +
            "\nAutor: " + Autor +
            "\nAño de publicación: " + AnyoPubli;
    }

    public void ComprobarMayusculas()
    {
        // Avisos de mayúsculas, minúsculas, espacios
        if (Autor == Autor.ToUpper()) Console.WriteLine("Cuidado: Autor en mayúsculas");
        if (Titulo == Titulo.ToUpper()) Console.WriteLine("Cuidado: Título en mayúsculas");
        if (Autor == Autor.ToLower()) Console.WriteLine("Cuidado: Autor en minúsculas");
        if (Titulo == Titulo.ToLower()) Console.WriteLine("Cuidado: Título en inúsculas");
        if (Autor.Contains("  ")) Console.WriteLine("Cuidado: Autor con espacios de sobra");
        if (Titulo.Contains("  ")) Console.WriteLine("Cuidado: Título con espacios de sobra");
    }


}


// -----------------------------------------------


[Serializable]
public class ListaDeLibros
{
    private const string NOMBRE_FICHERO = "libros.dat";
    private List<Libro> Libros = new List<Libro>();
    private string NombreFich = "libros.xml";
    public int Cantidad
    {
        get { return Libros.Count; }
    }

    public ListaDeLibros(List<Libro> libros)
    {
        this.Libros = libros;
    }

    public ListaDeLibros()
    {
        Cargar();
    }
    public Libro Obtener(int posicion)
    {
        Libro libro = new Libro();

        if (posicion >= 0 && posicion < Libros.Count)
        {
            libro = Libros[posicion];
        }
        libro = null;
        return libro;
    }

    private void Cargar()
    {
        SQLiteConnection conexion = new SQLiteConnection("Data Source="+ NOMBRE_FICHERO +"; Version=3");
        conexion.Open();
        string crearTabla = "create table if not exists libro (" +
            "id integer primary key autoincrement, " +
            "titulo varchar(50), " +
            "autor varchar(30), " +
            "anyoPubli numeric(4)" +
            ");";
        SQLiteCommand cmd = new SQLiteCommand(crearTabla, conexion);
        cmd.ExecuteNonQuery();

        string leerDatos = "SELECT * FROM libro;";
        SQLiteCommand cmd2 = new SQLiteCommand(leerDatos, conexion);
        SQLiteDataReader datos = cmd2.ExecuteReader();

        while(datos.Read())
        {
            Libro nuevoLibro = new Libro();
            nuevoLibro.Autor = Convert.ToString(datos["autor"]);
            nuevoLibro.Titulo = Convert.ToString(datos["titulo"]);
            nuevoLibro.AnyoPubli = Convert.ToInt16(datos["anyoPubli"]);
            Libros.Add(nuevoLibro);
        }

        conexion.Close();
    }

    private static void Guardar(Libro libro)
    {
        SQLiteConnection conexion = new SQLiteConnection("Data Source=" + NOMBRE_FICHERO + "; Version=3");
        conexion.Open();
        string guardarLibro = "INSERT INTO libro (titulo, autor, anyoPubli) VALUES ('" +
            libro.Titulo + "','" + libro.Autor + "'," + libro.AnyoPubli + ");";
        SQLiteCommand cmd = new SQLiteCommand(guardarLibro, conexion);
        cmd.ExecuteNonQuery();
        conexion.Close();
    }

    private static void Borrar(Libro libroBorrar)
    {
        SQLiteConnection conexion = new SQLiteConnection("Data Source=" + NOMBRE_FICHERO + "; Version=3");
        conexion.Open();
        string borrarLibro = "DELETE FROM libro WHERE autor='" + libroBorrar.Autor +
            "' and titulo='" + libroBorrar.Titulo +
            "' and anyoPubli=" + libroBorrar.AnyoPubli;
        SQLiteCommand cmd = new SQLiteCommand(borrarLibro, conexion);
        cmd.ExecuteNonQuery();
        conexion.Close();
    }

    private static void Actualizar(Libro libroAnterior, Libro libroActualizado)
    {
        SQLiteConnection conexion = new SQLiteConnection("Data Source=" + NOMBRE_FICHERO + "; Version=3");
        conexion.Open();
        string actualizarLibro = "UPDATE libro SET autor='" + libroActualizado.Autor + 
            "', titulo='" + libroActualizado.Titulo + 
            "', anyoPubli=" + libroActualizado.AnyoPubli + 
            " WHERE titulo='" + libroAnterior.Titulo + 
            "' AND autor='" + libroAnterior.Autor + 
            "' AND anyoPubli=" + libroAnterior.AnyoPubli;
        SQLiteCommand cmd = new SQLiteCommand(actualizarLibro, conexion);
        cmd.ExecuteNonQuery();
        conexion.Close();
    }

    public static void AnyadirLibro(ListaDeLibros lista)
    {
        List<Libro> libros = lista.Libros;
        Libro nuevoLibro = new Libro();
        nuevoLibro.Titulo = PedirNoVacio("¿Título?: ");
        nuevoLibro.Autor = PedirNoVacio("¿Autor?: ");

        // Año -1 si no se escribe nada
        string anyo = Pedir("¿Año de publicación?: ");
        if (anyo == "")
        {
            nuevoLibro.AnyoPubli = -1;
        }
        else
        {
            nuevoLibro.AnyoPubli = Convert.ToInt16(anyo);
        }

        libros.Add(nuevoLibro);

        Ordenar(libros);
        Guardar(nuevoLibro);
    }

    public static void Ordenar(List<Libro> libros)
    {
        libros.Sort();
    }

    public static void MostrarLibros(ListaDeLibros lista, byte bloque)
    {
        List<Libro> libros = lista.Libros;
        if (libros.Count == 0)
            Console.WriteLine("Sin datos");
        else
            for (int i = 0; i < libros.Count; i++)
            {
                string anyoMostrar = Convert.ToString(
                    libros[i].AnyoPubli);

                if (anyoMostrar == "-1")
                    anyoMostrar = "Año desconocido";

                Console.WriteLine(
                    "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    i + 1, libros[i].Titulo, libros[i].Autor,
                    anyoMostrar);

                if ((i + 1) % bloque == 0)
                {
                    Console.ReadLine();
                }
            }
        Console.WriteLine();
    }

    public static void BuscarTitulo(ListaDeLibros lista)
    {
        List<Libro> libros = lista.Libros;
        Console.Write("BUSCAR. Titulo?: ");
        string buscar = Console.ReadLine();
        if (buscar != "")
        {
            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].Titulo.ToUpper().Contains(buscar.ToUpper())
                    || libros[i].Autor.ToUpper().Contains(buscar.ToUpper()))
                {
                    Console.WriteLine(
                        "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                        i + 1, libros[i].Titulo, libros[i].Autor,
                        libros[i].AnyoPubli);
                }
            }
        }
    }

    public static void BuscarFecha(ListaDeLibros lista)
    {
        List<Libro> libros = lista.Libros;
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
            if (libros[i].AnyoPubli >= fechaInicial &&
                    libros[i].AnyoPubli <= fechaFinal)
            {
                Console.WriteLine(
                    "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    i + 1, libros[i].Titulo, libros[i].Autor,
                    libros[i].AnyoPubli);
            }
        }
    }

    public static void Modificar(ListaDeLibros lista)
    {
        List<Libro> libros = lista.Libros;
        Console.Write("Número de registro?: ");
        int numRegistro = Convert.ToInt32(Console.ReadLine());
        if (numRegistro >= 1 && numRegistro <= libros.Count)
        {
            Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    numRegistro, libros[numRegistro - 1].Titulo,
                    libros[numRegistro - 1].Autor,
                    libros[numRegistro - 1].AnyoPubli);

            Libro libroMod = libros[numRegistro - 1];

            Console.Write("Titulo?: ");
            string cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libroMod.Titulo = cadenaAux;

            Console.Write("Autor?:");
            cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libroMod.Autor = cadenaAux;

            Console.Write("Año de publicacion?: ");
            cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libroMod.AnyoPubli =
                    Convert.ToInt16(cadenaAux);

            Actualizar(libros[numRegistro - 1], libroMod);
            libros[numRegistro - 1] = libroMod;
            libros[numRegistro - 1].ComprobarMayusculas();
        }
    }

    public static void Borrar(ListaDeLibros lista)
    {
        List<Libro> libros = lista.Libros;
        int numRegistro;
        Console.Write("¿Número de registro?: ");
        numRegistro = Convert.ToInt32(Console.ReadLine());
        if (numRegistro >= 1 && numRegistro <= libros.Count)
        {
            Console.WriteLine(
                "{0}-Título: {1}, Autor: {2}, Año publicación: {3}",
                    numRegistro, libros[numRegistro - 1].Titulo,
                        libros[numRegistro - 1].Autor,
                            libros[numRegistro - 1].AnyoPubli);
            Console.Write(
                "Seguro que quieres borrar este libro? Si/No:");
            string siNo = Console.ReadLine().ToUpper();
            if (siNo == "SI" || siNo == "S")
            {
                Borrar(libros[numRegistro - 1]);
                libros.RemoveAt(numRegistro - 1);
            }
        }
    }

    public static void ComprobarOrtografia(ListaDeLibros lista)
    {
        List<Libro> libros = lista.Libros;
        for (int i = 0; i < libros.Count; i++)
        {
            bool fichaCorrecta = true;
            string titulo = libros[i].Titulo;
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
                    i + 1, libros[i].Titulo,
                        libros[i].Autor, libros[i].AnyoPubli);
                Console.Write("¿Desea arreglar este registro (s/n)? ");
                string corregir = Console.ReadLine().ToUpper();
                if (corregir == "S")
                {
                    Libro libroCorregido = libros[i];
                    libroCorregido.Titulo = libros[i].Titulo.Trim();
                    libroCorregido.Titulo = QuitarEspaciosRedundantes(libros[i].Titulo);
                    libroCorregido.Titulo = CorregirMayusculas(libros[i].Titulo);
                    Actualizar(libros[i], libroCorregido);
                }
            }
        }
    }

    public static string Pedir(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }


    public static string PedirNoVacio(string mensaje)
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

    public static string QuitarEspaciosRedundantes(string texto)
    {
        while (texto.Contains("  "))
            texto = texto.Replace("  ", " ");
        return texto;
    }

    public static string CorregirMayusculas(string texto)
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
