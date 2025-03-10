/* 200. Debes crear una aplicación que permita llevar el control de una 
colección de música en formato MP3. De cada canción o similar (que será un 
objeto de la clase "Cancion") querremos anotar el título (por ejemplo, "The 
bell"), el intérprete ("Mike Oldfield"), el nombre del fichero ("thebell.mp3") 
y la ubicación ("MikeOldfield/tubularBells"). Otros detalles que podrían ser 
interesantes, como el tamaño del fichero, la categoría, el álbum al que 
pertenece o la valoración personal, hemos decidido aplazarlos para una versión 
posterior 2.0. A pesar de que esta versión no va hacer búsquedas exactas ni 
borrados por contenido, implementa los métodos ".Equals" y ".GetHashCode" 
(puedes ayudarte del apartado 7.8 de los apuntes, versión 2025).

En esta primera versión, las canciones se guardarán en una List<Cancion>.

Tu aplicación debe mostrar un menú que permita:

1. Añadir una nueva canción.

2. Ver todos los datos de una canción a partir de su número.

3. Mostrar los nombres de las canciones que contengan un cierto texto en el 
título o en el autor.

4. Modificar los datos de una canción a partir de su número.

0. Salir
*/

// Francisco (...), retoques menores por Nacho

using System;
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
        List<Cancion> discoteca = new List<Cancion>();
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
    public static void AnyadirCancion(List<Cancion> canciones)
    {
        Cancion nueva = new Cancion();
        bool existeCancion = false;

        do
        {
            Console.Write(" > Introduce el titulo: ");
            string titulo = Console.ReadLine();

            existeCancion = false;

            foreach (Cancion c in canciones)
            {
                if (c.Titulo == titulo)
                {
                    Console.WriteLine(" # ERROR. Canción ya existente. "
                        + "No se puede añadir duplicados.");
                    existeCancion = true;
                }
            }
            if (!existeCancion)
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

        canciones.Add(nueva);   // Añadimos la nueva canción a la lista
    }

    // Mostrar los datos completos de una canción en particular
    public static void VerDatosCancion(List<Cancion> canciones)
    {
        Console.Write(" > Introduce el título a buscar: ");
        string titulo = Console.ReadLine();

        bool encontrado = false;

        foreach (Cancion c in canciones)
        {
            if (c.Titulo == titulo)
            {
                encontrado = true;
                Console.WriteLine(c.ToString());
            }
            if (!encontrado && c.Titulo.ToLower().Contains(titulo.ToLower()))
            {
                Console.WriteLine(" > [ Coincidencia parcial ] : ");
                Console.WriteLine(c.ToString());
            }
        }
        if (!encontrado)
        {
            Console.WriteLine(" # ERROR. Canción no encontrada.");
        }
    }

    // Mostrar el titulo de todas las canciones
    public static void ListarCanciones(List<Cancion> canciones)
    {
        if (canciones.Count == 0)
        {
            Console.WriteLine(" # ERROR. Lista vacía.");
        }
        else
        {
            foreach (Cancion c in canciones)
            {
                Console.WriteLine(" > Título: " + c.Titulo);
            }
        }
    }

    // Función para modificar una canción
    public static void ModificarCancion(List<Cancion> canciones)
    {
        Console.Write(" > Introduce el título de la canción a modificar: ");
        string titulo = Console.ReadLine();
        bool encontrado = false;

        foreach (Cancion c in canciones)
        {
            if (c.Titulo == titulo)
            {
                encontrado = true;
                Console.WriteLine(" > Introduce los nuevos valores para los campos: ");
                Console.Write(" >> Titulo: ");
                c.Titulo = Console.ReadLine();
                Console.Write(" >> Intérprete: ");
                c.Interprete = Console.ReadLine();
                Console.Write(" >> Nombre del archivo: ");
                c.NombreArchivo = Console.ReadLine();
                Console.Write(" >> Ubicación del archivo: ");
                c.Ubicacion = Console.ReadLine();
                string nuevaRuta = Console.ReadLine();
            }
        }
        if (!encontrado)
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
