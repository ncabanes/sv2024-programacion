/* 201. Vamos a hacer una variante del ejercicio anterior, en la que las 
canciones se guarden en un Dictionary o un SortedList, que use como clave el 
título de la canción y como valor el conjunto de los datos, por ejemplo: 
Dictionary<string, Cancion>.

En esta ocasión, tu aplicación debe mostrar un menú que permita:

1. Añadir una nueva canción.

2. Ver todos los datos de una canción a partir de su título.

3. Mostrar los nombres de las canciones que contengan un cierto texto en el 
título o en el autor.

4. Modificar los datos de una canción a partir de su título.

0. Salir

*/

// Francisco (...), retoques menores por Nacho

using System;
using System.Collections;
using System.Collections.Generic;

public class Cancion
{
    // Atributos de clase
    public string Titulo { get; set; }
    public string Interprete { get; set; }
    public string NombreArchivo { get; set; }
    public string Ubicacion { get; set; }

    // Constructor por defecto
    public Cancion()
    {
        this.Titulo = "";
        this.Interprete = "";
        this.NombreArchivo = "";
        this.Ubicacion = "";
    }

    // Constructor con todos los parámetros
    public Cancion(string titulo, string interprete, string archivo, string ruta)
    {
        this.Titulo = titulo;
        this.Interprete = interprete;
        this.NombreArchivo = archivo;
        this.Ubicacion = ruta;
    }

    // Sobrecarga del método ToString() para mostrar contenidos
    public override string ToString()
    {
        string aux = "Canción: " + '\n' + "Título: " + Titulo + '\n' + "Intérprete: "
         + Interprete + '\n' + "Archivo: " + NombreArchivo + '\n' + "Ruta: " + Ubicacion;
        return (aux);
    }

    // Sobrecarga del método Equals() para comparar objetos
    public override bool Equals(object obj)
    {
        bool igual;

        if (obj == null || (this.GetType() != obj.GetType()))
        {
            igual = false;
        }
        else
        {
            Cancion cancion = (Cancion)obj;
            if (this.Interprete == cancion.Interprete
                && this.NombreArchivo == cancion.NombreArchivo &&
            this.Titulo == cancion.Titulo && this.Ubicacion == cancion.Ubicacion)
            {
                igual = true;
            }
            else
            {
                igual = false;
            }
        }

        return (igual);
    }

    // Sobrecarga del método GetHashCode()
    public override int GetHashCode()
    {
        return (this.Ubicacion.GetHashCode() ^ this.Interprete.GetHashCode()
         ^ this.NombreArchivo.GetHashCode() ^ this.Titulo.GetHashCode());
    }
}

// ----------------------------------------------------

class GestorMusica
{
    public static void Main()
    {
        Dictionary<string, Cancion> discoteca = new Dictionary<string, Cancion>();
        bool salir = false;
        byte opcion;

        do
        {
            opcion = Menu();
            switch (opcion)
            {
                case 1:     // Añadir una canción a la lista
                    AnyadirCancion(discoteca);
                    break;
                case 2:     // Ver los datos de una canción
                    VerDatosCancion(discoteca);
                    break;
                case 3:     // Ver la lista de todas las canciones
                    ListarCanciones(discoteca);
                    break;
                case 4:     // Modificar una canción
                    ModificarCancion(discoteca);
                    break;
                case 0:     // Salir del programa
                    salir = true;
                    Console.WriteLine(" > Saliendo...");
                    break;
                default:
                    Console.WriteLine(" # ERROR. Opción incorrecta.");
                    break;
            }
        } while (!salir);
    }

    // Función para añadir canciones a la lista
    public static void AnyadirCancion(Dictionary<string, Cancion> canciones)
    {
        Cancion nueva = new Cancion();
        bool existeCancion = false;

        do
        {
            Console.Write(" > Introduce el titulo: ");
            string titulo = Console.ReadLine();

            existeCancion = false;
            if (canciones.ContainsKey(titulo))
            {
                existeCancion = true;
                Console.WriteLine(" # ERROR. Canción ya existente. No se puede añadir duplicados.");
            }
            else
            {
                nueva.Titulo = titulo;
            }
        } while (existeCancion);

        Console.Write(" > Introduce el intérprete: ");
        nueva.Interprete = Console.ReadLine();

        Console.Write(" > Introduce el nombre del archivo: ");
        nueva.NombreArchivo = Console.ReadLine();

        Console.Write(" > Introduce la ruta del archivo: ");
        nueva.Ubicacion = Console.ReadLine();

        canciones.Add(nueva.Titulo, nueva);   // Añadimos la nueva canción a la lista
    }

    // Mostrar los datos completos de una canción en particular
    public static void VerDatosCancion(Dictionary<string, Cancion> canciones)
    {
        Console.Write(" > Introduce el título a buscar: ");
        string tituloBuscar = Console.ReadLine();

        bool encontrado = false;

        if (canciones.ContainsKey(tituloBuscar))
        {
            encontrado = true;
            Console.WriteLine(canciones[tituloBuscar].ToString());
        }
        else
        {
            foreach (string tituloParcial in canciones.Keys)
            {
                if (tituloParcial.ToLower().Contains(tituloBuscar.ToLower()))
                {
                    Console.WriteLine(" > [ Coincidencia parcial ] : ");
                    Console.WriteLine(canciones[tituloParcial].ToString());
                }
                Console.WriteLine(" > Título: " + tituloBuscar);
            }
        }

        if (!encontrado)
        {
            Console.WriteLine(" # ERROR. Canción no encontrada.");
        }
    }

    // Mostrar el titulo de todas las canciones
    public static void ListarCanciones(Dictionary<string, Cancion> canciones)
    {
        if (canciones.Count == 0)
        {
            Console.WriteLine(" # ERROR. Lista vacía.");
        }
        else
        {
            foreach (string titulo in canciones.Keys)
            {
                Console.WriteLine(" > Título: " + titulo);
            }
        }
    }

    // Función para modificar una canción
    public static void ModificarCancion(Dictionary<string, Cancion> canciones)
    {
        Console.Write(" > Introduce el título de la canción a modificar: ");
        string titulo = Console.ReadLine();

        if (canciones.ContainsKey(titulo))
        {
            Console.WriteLine(" > Introduce los nuevos valores para los campos: ");
            Console.Write(" >> Titulo: ");
            canciones[titulo].Titulo = Console.ReadLine();
            Console.Write(" >> Intérprete: ");
            string nuevoInterprete = 
            canciones[titulo].Interprete = Console.ReadLine();
            Console.Write(" >> Nombre del archivo: ");
            canciones[titulo].NombreArchivo = Console.ReadLine();
            Console.Write(" >> Ubicación del archivo: ");
            canciones[titulo].Ubicacion = Console.ReadLine();
        }
        else
        {
            Console.WriteLine(" # ERROR. Canción no encontrada.");
        }
    }

    // Función para mostrar el menú principal y recoger la opción elegida.
    public static byte Menu()
    {
        Console.WriteLine("\n* --------------------------- *");
        Console.WriteLine("*        MENU DISCOTECA       *");
        Console.WriteLine("* --------------------------- *");
        Console.WriteLine("* 1. Añadir nueva cancion     *");
        Console.WriteLine("* 2. Ver datos de una canción *");
        Console.WriteLine("* 3. Ver lista completa       *");
        Console.WriteLine("* 4. Modificar una canción    *");
        Console.WriteLine("* --------------------------- *");
        Console.WriteLine("* 0. Salir                    *");
        Console.WriteLine("* --------------------------- *");
        Console.Write(" > Opción: ");
        byte opcion = Convert.ToByte(Console.ReadLine());

        return (opcion);
    }
}
