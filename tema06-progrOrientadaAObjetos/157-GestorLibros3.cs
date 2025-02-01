/* 157. Crea una versión mejorada del ejercicio anterior, en la que tengamos 
dos subtipos de Libro: LibroPapel (que añadirá un atributo "cantidadPaginas") y 
LibroElectronico (que añadirá un atributo "URL"). El método "Mostrar" y el 
"ToString" deberán incluir esos nuevos datos. A la hora de añadir datos, se 
debe preguntar de qué tipo de libro se trata, pedir los campos adecuados y 
guardar en el array un objeto del tipo adecuado. */

using System;
using System.Configuration;

public class Libro
{

    protected string titulo;
    protected string autor;
    protected short anyoPubli;

    public Libro(string titulo, string autor, int anyoPubli)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anyoPubli = (short) anyoPubli;
    }

    public Libro(string titulo, int anyoPubli)
        : this(titulo, "Desconocido", anyoPubli)
    {
    }

    public string GetTitulo() { return titulo; }
    public string GetAutor() { return autor; }
    public int GetAnyoPubli() { return anyoPubli; }

    public void SetTitulo(string nuevoTitulo)
    {
        titulo = nuevoTitulo;
    }

    public void SetAutor(string nuevoAutor)
    {
        autor = nuevoAutor;
    }

    public void SetAnyoPubli(int nuevoAnyoPubli)
    {
        anyoPubli = (short)nuevoAnyoPubli;
    }

    public virtual void Mostrar()
    {
        Console.WriteLine("Título : " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicación: " + anyoPubli);
    }

    public bool Contiene(string texto)
    {
        return titulo.ToUpper().Contains(texto.ToUpper()) ||
            autor.ToUpper().Contains(texto.ToUpper());
    }

    public override string ToString()
    {
        return titulo + " - " + autor + " - " + anyoPubli;
    }
}

// ---------------------

public class LibroPapel : Libro
{
    private int cantidadPaginas;

    public LibroPapel(string titulo, string autor, int anyoPubli, int cantidadPaginas)
        : base(titulo, autor, anyoPubli)
    {
        this.cantidadPaginas = cantidadPaginas;
    }

    public int GetCantidadPaginas() { return cantidadPaginas; }
    public void SetCantidadPaginas(int cantidadPaginas) { this.cantidadPaginas = cantidadPaginas; }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Cantidad de páginas: " + cantidadPaginas);
    }

    public override string ToString()
    {
        return base.ToString() + " - " + cantidadPaginas +" páginas";
    }
}

// ---------------------

public class LibroElectronico : Libro
{
    private string url;

    public LibroElectronico(string titulo, string autor, int anyoPubli, string url)
        : base(titulo, autor, anyoPubli)
    {
        this.url = url;
    }

    public string GetUrl() { return url; }
    public void SetUrl(string url) { this.url = url; }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("URL: " + url);
    }

    public override string ToString()
    {
        return base.ToString() + " - URL: " + url;
    }
}

// ---------------------

class GestorLibros
{
    public static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("------ MENÚ -------");
        Console.WriteLine("1. Añadir un libro nuevo");
        Console.WriteLine("2. Mostrar todos los libros");
        Console.WriteLine("3. Buscar libros que contengan un texto determinado");
        Console.WriteLine("S. Salir");
        Console.WriteLine("-------------------");
        Console.WriteLine();
    }

    static void Main()
    {
        const int CAPACIDADMAXIMA = 50000;
        Libro[] libros = new Libro[CAPACIDADMAXIMA];
        string opcion = "";
        string tituloAux, autorAux, textoBuscar;
        short anyoAux;
        int contadorLibros = 0;

        while (opcion != "S")
        {
            MostrarMenu();
            opcion = Console.ReadLine().ToUpper();

            switch (opcion)
            {
                //Añadir un libro nuevo
                case "1":
                    Console.Write("Introduzca el título: ");
                    tituloAux = Console.ReadLine();
                    Console.Write("Introduzca el autor: ");
                    autorAux = Console.ReadLine();
                    Console.Write("Introduzca el año de publicación: ");
                    anyoAux = Convert.ToInt16(Console.ReadLine());
                    
                    string tipoLibro;
                    do
                    {

                        Console.Write("¿Es un libro en papel (P) o electrónico (E)? ");
                        tipoLibro = Console.ReadLine().ToUpper();

                        if (tipoLibro == "P")
                        {
                            Console.Write("Introduzca la cantidad de páginas: ");
                            int paginasAux = Convert.ToInt32(Console.ReadLine());
                            libros[contadorLibros] = new LibroPapel(tituloAux, autorAux, anyoAux, paginasAux);
                        }
                        else if (tipoLibro == "E")
                        {
                            Console.Write("Introduzca la URL: ");
                            string urlAux = Console.ReadLine();
                            libros[contadorLibros] = new LibroElectronico(tituloAux, autorAux, anyoAux, urlAux);
                        }
                    }
                    while (tipoLibro != "P" && tipoLibro != "E");
                    
                    contadorLibros++;
                    break;

                //Mostrar todos los libros
                case "2":
                    for (int i = 0; i < contadorLibros; i++)
                    {
                        Console.WriteLine("LIBRO " + (i + 1) + ":");
                        libros[i].Mostrar();
                    }
                    break;

                //Buscar libros que contengan un texto determinado
                case "3":
                    Console.Write("Introduce el texto a buscar: ");
                    textoBuscar = Console.ReadLine();
                    bool encontrado = false;
                    for (int i = 0; i < contadorLibros; i++)
                    {
                        if (libros[i].Contiene(textoBuscar))
                        {
                            Console.WriteLine(libros[i]);
                            encontrado = true;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("No encontrado");
                    }
                    break;

                // Salir
                case "S":
                    Console.WriteLine("Hasta pronto!");
                    break;

                default:
                    Console.WriteLine("Opción NO válida.");
                    break;
            }
        }
    }
}
