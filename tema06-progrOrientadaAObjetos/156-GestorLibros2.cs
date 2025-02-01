/* 156. Crea una nueva versión del ejercicio 148 (clase Libro y menú asociado), 
a partir de la "solución oficial", en la que emplees "this" en el constructor 
de "Libro" y añadas un constructor que permita indicar título y año, sin autor 
(que se guardará como "Desconocido"). Este segundo constructor debe apoyarse en 
el primero. Al añadir datos desde el menú, deberás usar el constructor original 
si se indica autor, o el nuevo, en caso de que el autor se deje en blanco (el 
usuario introduzca una cadena vacía). Emplea un "ToString" adecuado para 
mostrar los resultados de las búsquedas, que devuelva todos los datos como 
parte de una misma cadena, separados por " - ".*/

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

    public void Mostrar()
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
        Libro libroAux;
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

                    if (autorAux == "")
                        libroAux = new Libro(tituloAux, anyoAux);
                    else
                        libroAux = new Libro(tituloAux, autorAux, anyoAux);
                    
                    libros[contadorLibros] = libroAux;
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
