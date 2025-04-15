/*

Crea una aplicación que permita llevar el control de una colección de música en 
formato MP3. De cada canción o similar (que será un objeto de la clase 
"Musica") querremos anotar el titulo (por ejemplo, "The bell"), el intérprete 
("Mike Oldfield"), el nombre del fichero ("thebell.mp3"), la ubicación 
("MikeOldfield/tubularBells"), el tamaño del fichero (en MB, quizá con 
decimales, como en "3,070"). Otros detalles que podrían ser interesantes, como 
la categoría, el álbum al que pertenece o la valoración personal, hemos 
decidido aplazarlos para una versión posterior 2.0.

Tu aplicación debe mostrar un menú que permita:

1. Añadir un nueva canción (al final de los datos existentes).

2. Mostrar las canciones que contengan un cierto texto en el título o en el autor.

3. Modificar los datos de una canción a partir de su posición (la canción número
1 sería la primera de la lista).

4. Eliminar la canción que se encuentra en cierta posición.

5. Ordenar alfabéticamente por título.

6. Ordenar alfabéticamente por autor.

7. Salir

Tu aplicación debe cargar datos al comenzar y guardar datos tras cada cambio, 
empleando serialización con un formateador binario. Si tu versión de la 
plataforma .Net no te permite usar serializador binario, emplea XML.

Por Blanca (...)

*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

class Coleccion
{
    private const string NOMBRE_FICHERO = "canciones.xml";
    List<Musica> canciones;

    public Coleccion()
    {
        Cargar();
    }

    public void Ejecutar()
    {
        string opcion;

        do
        {
            MostrarMenu();
            opcion = Console.ReadLine();

            switch(opcion)
            {
                case "1":
                    AnyadirCancion();
                    break;
                case "2":
                    BuscarYMostrarCanciones();
                    break;
                case "3":
                    ModificarCancion();
                    break;
                case "4":
                    EliminarCancion();
                    break;
                case "5":
                    OrdenarPorTitulo();
                    break;
                case "6":
                    
                    break;
                case "7":
                    Console.WriteLine("Saliendo...");
                    break;
            }

            if(opcion != "7")
            {
                Console.WriteLine("Pulsa ENTER para continuar");
                Console.ReadLine();
            }
        } while (opcion != "7");
    }

    

    public void OrdenarPorTitulo()
    {
        canciones.Sort();
        Guardar();
    }

    public void EliminarCancion()
    {
        MostrarTodasCanciones();

        Console.WriteLine("Qué canción desea eliminar?");
        int posicion = Convert.ToInt32(Console.ReadLine()) - 1;

        if(posicion >= 0 && posicion < canciones.Count)
        {
            canciones.RemoveAt(posicion);
            Guardar();
            Console.WriteLine("Canción eliminada");
        } else
        {
            Console.WriteLine("No existe la canción indicada");
        }
    }

    public void MostrarTodasCanciones()
    {
        for (int i = 0; i < canciones.Count; i++)
        {
            Console.WriteLine("{0} - {1}", i + 1, canciones[i]);
        }
    }

    public void ModificarCancion()
    {
        MostrarTodasCanciones();

        Console.WriteLine("Qué canción quieres modificar?");
        int posicionModificar = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Titulo anterior: {0} (ENTER para saltar)", 
            canciones[posicionModificar].Titulo);
        string nuevoTitulo = Console.ReadLine();

        if(nuevoTitulo != "")
        {
            canciones[posicionModificar].Titulo = nuevoTitulo;
        }

        Console.WriteLine("Intérprete anterior: {0} (ENTER para saltar)", 
            canciones[posicionModificar].Interprete);
        string nuevoInterprete = Console.ReadLine();

        if (nuevoInterprete != "")
        {
            canciones[posicionModificar].Interprete = nuevoInterprete;
        }

        Console.WriteLine("Fichero anterior: {0} (ENTER para saltar)", 
            canciones[posicionModificar].Fichero);
        string nuevoFichero = Console.ReadLine();

        if (nuevoFichero != "")
        {
            canciones[posicionModificar].Fichero = nuevoFichero;
        }

        Console.WriteLine("Ubicación anterior: {0} (ENTER para saltar)", 
            canciones[posicionModificar].Ubicacion);
        string nuevaUbicacion = Console.ReadLine();

        if (nuevaUbicacion != "")
        {
            canciones[posicionModificar].Ubicacion = nuevaUbicacion;
        }

        Console.WriteLine("Tamaño anterior: {0} (ENTER para saltar)", 
            canciones[posicionModificar].Tamanyo);
        string nuevoTamaño = Console.ReadLine();

        if (nuevoTamaño != "")
        {
            canciones[posicionModificar].Tamanyo = Convert.ToSingle(nuevoTamaño);
        }

        Guardar();
    }

    public void BuscarYMostrarCanciones()
    {
        Console.WriteLine("Qué quieres buscar?");
        string textoBuscar = Console.ReadLine();

        foreach(Musica c in canciones)
        {
            if(c.Contains(textoBuscar))
            {
                Console.WriteLine(c);
            }
        }
    }

    public void AnyadirCancion()
    {
        Console.WriteLine("Introduce el titulo: ");
        string titulo = Console.ReadLine();

        Console.WriteLine("Introduce el interprete: ");
        string interprete = Console.ReadLine();

        Console.WriteLine("Introduce el nombre del fichero: ");
        string nombreFichero = Console.ReadLine();

        Console.WriteLine("Introduce la ubicación del fichero: ");
        string ubicacionFichero = Console.ReadLine();

        Console.WriteLine("Introduce el tamaño del fichero:");
        float tamanyo = Convert.ToSingle(Console.ReadLine());

        Musica cancion = new Musica(titulo, interprete, nombreFichero, ubicacionFichero, tamanyo);

        canciones.Add(cancion);
        Guardar();
    }

    public void Guardar()
    {
        XmlSerializer serializador = new XmlSerializer(typeof(List<Musica>));
        FileStream stream = new FileStream(NOMBRE_FICHERO, 
            FileMode.Create, FileAccess.Write, FileShare.None);
        serializador.Serialize(stream, canciones);
        stream.Close();
    }

    public void Cargar()
    {
        if (File.Exists(NOMBRE_FICHERO))
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<Musica>));
            FileStream stream = new FileStream(NOMBRE_FICHERO, 
                FileMode.Open, FileAccess.Read, FileShare.None);
            canciones = (List<Musica>)serializador.Deserialize(stream);
            stream.Close();
        }
        else
        {
            canciones = new List<Musica>();
        }
    }

    public void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("1. Añadir cancion");
        Console.WriteLine("2. Buscar canciones");
        Console.WriteLine("3. Modificar datos de canción");
        Console.WriteLine("4. Eliminar canción");
        Console.WriteLine("5. Ordenar por título");
        Console.WriteLine("6. Ordenar por autor");
        Console.WriteLine("7. Salir");
    }

    static void Main()
    {
        Coleccion coleccion = new Coleccion();
        coleccion.Ejecutar();
    }
}

// ---------------------

class Musica: IComparable<Musica>
{
    public string Titulo {  get; set; }
    public string Interprete { get; set; }
    public string Fichero { get; set; }
    public string Ubicacion { get; set; }
    public float Tamanyo { get; set; }

    public Musica()
    {
    }

    public Musica(string titulo, string interprete, string fichero, 
        string ubicacion, float tamanyo)
    {
        Titulo = titulo;
        Interprete = interprete;
        Fichero = fichero;
        Ubicacion = ubicacion;
        Tamanyo = tamanyo;
    }

    public override string ToString()
    {
        return "Titulo: " + Titulo + ", Interprete: " + Interprete + 
            ", Fichero: " + Fichero + ", Ubicacion: " + Ubicacion + 
            ", Tamaño: " + Tamanyo + "MB";
    }

    public bool Contains(string texto)
    {
        if(Titulo.ToLower().Contains(texto.ToLower()) || 
            Interprete.ToLower().Contains(texto.ToLower()))
        {
            return true;
        }

        return false;
    }

    public int CompareTo(Musica other)
    {
        return Titulo.ToLower().CompareTo(other.Titulo.ToLower());
    }
}



