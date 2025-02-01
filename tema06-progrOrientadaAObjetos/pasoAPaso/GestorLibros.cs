/* MARTA (...), retoques menores por Nacho
 * 
148. A partir de la clase "Libro" (ejercicio 142, en su "solución 
oficial"), crea un programa que permita tener hasta 25000 libros, y un 
menú con el que se pueda: Añadir un libro nuevo (opción "1"), Mostrar 
todos los libros (opción "2"), Buscar libros que contengan un texto 
determinado (opción "3"), Salir (opción "S"). */

using System;

public class Libro 
{

    protected string titulo;
    protected string autor;
    protected short anyoPubli;

    public Libro( string nuevoTitulo, string nuevoAutor, int nuevoAnyoPubli ) 
    {
        titulo = nuevoTitulo;
        autor = nuevoAutor;
        anyoPubli = ( short) nuevoAnyoPubli;
    }

    public string GetTitulo() { return titulo; }
    public string GetAutor() { return autor; }
    public int GetAnyoPubli() { return anyoPubli; }

    public void SetTitulo( string nuevoTitulo ) 
    { 
        titulo = nuevoTitulo; 
    }
    
    public void SetAutor( string nuevoAutor ) 
    {
        autor = nuevoAutor;
    }

    public void SetAnyoPubli( int nuevoAnyoPubli ) 
    { 
        anyoPubli = (short)nuevoAnyoPubli; 
    }

    public void Mostrar() 
    {
        Console.WriteLine( "Título : " + titulo );
        Console.WriteLine( "Autor: " + autor );
        Console.WriteLine( "Año de publicación: " + anyoPubli );
    }

    public bool Contiene( string texto) 
    {
        return titulo.ToUpper().Contains( texto.ToUpper() ) || 
            autor.ToUpper().Contains( texto.ToUpper() );
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
        Libro [] libros = new Libro [CAPACIDADMAXIMA];
        string opcion="";
        string tituloAux, autorAux, textoBuscar;
        short anyoAux;
        Libro libroAux;
        int contadorLibros = 0;
        
        while(opcion != "S")
        {
            MostrarMenu();
            opcion = Console.ReadLine().ToUpper();
            
            switch(opcion)
            {
                //Añadir un libro nuevo
                case "1": 
                    Console.Write("Introduzca el título: ");
                    tituloAux = Console.ReadLine();
                    Console.Write("Introduzca el autor: ");
                    autorAux = Console.ReadLine();
                    Console.Write("Introduzca el año de publicación: ");
                    anyoAux = Convert.ToInt16(Console.ReadLine());
                    
                    libroAux = new Libro(tituloAux, autorAux, anyoAux);
                    libros[contadorLibros] = libroAux;
                    
                    contadorLibros++;
                    break;
                    
                //Mostrar todos los libros
                case "2": 
                    for( int i = 0; i < contadorLibros; i++)
                    {
                        Console.WriteLine("LIBRO "+(i+1)+":");
                        libros[i].Mostrar();
                    }
                    break;
                    
                //Buscar libros que contengan un texto determinado
                case "3": 
                    Console.Write("Introduce el texto a buscar: ");
                    textoBuscar = Console.ReadLine();
                    bool encontrado = false;
                    for(int i = 0; i < contadorLibros; i++)
                    {
                        if(libros[i].Contiene(textoBuscar))
                        {
                            libros[i].Mostrar();
                            encontrado = true;
                        }
                    }
                    if (! encontrado)
                    {
                        Console.WriteLine("No encontrado");
                    }
                    break;
                    
                // Salir
                case "S":
                    Console.WriteLine("Hasta pronto!");
                    break;

                default: Console.WriteLine("Opción NO válida.");
                    break;
            }
        }
    }
}
