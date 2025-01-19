/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 141. Biblioteca con getters y setters.
 * 
 * De cara a irnos acercando a una versión orientada a objetos del proyecto
 * de la Biblioteca (ejercicio 113), crea una clase Libro, con atributos:
 * titulo (string), autor (string), anyoPubli (entero corto). 
 * 
 * Debes preparar setters y getters para todos ellos, pero los getters
 * numéricos devolverán datos "int" (en vez de "short"), y los setters
 * numéricos recibirán datos "int". 
 * 
 * Crea también un constructor adecuado, un método Mostrar (void) que muestre
 * los datos de un Libro en pantalla, y un método Contiene (booleano) que
 * devuelva "true" si el título o el autor contienen el texto que se indique
 * como parámetro. */

using System;

class Libro {

    protected string titulo;
    protected string autor;
    protected short anyoPubli;

    public Libro( string nuevoTitulo, string nuevoAutor, int nuevoAnyoPubli ) {
        titulo = nuevoTitulo;
        autor = nuevoAutor;
        anyoPubli = ( short) nuevoAnyoPubli;
    }

    public string GetTitulo() { return titulo; }
    public string GetAutor() { return autor; }
    public int GetAnyoPubli() { return anyoPubli; }

    public void SetTitulo( string nuevoTitulo ) { 
        titulo = nuevoTitulo; 
    }
    
    public void SetAutor( string nuevoAutor ) {
        autor = nuevoAutor;
    }

    public void SetAnyoPubli( int nuevoAnyoPubli ) { 
        anyoPubli = (short)nuevoAnyoPubli; 
    }

    public void Mostrar() {
        Console.WriteLine( "Título : " + titulo );
        Console.WriteLine( "Autor: " + autor );
        Console.WriteLine( "Año de publicación: " + anyoPubli );
    }

    public bool Contiene( string texto) {
        return titulo.ToUpper().Contains( texto.ToUpper() ) || 
            autor.ToUpper().Contains( texto.ToUpper() );
    }

}

class PruebaLibro {

    static void Main() {

        Libro l = new Libro( "Libro de prueba.", "Autor de prueba.", 2022 );
        l.SetAnyoPubli( 2025 );
        l.Mostrar();

        if ( l.Contiene( "mm" ) ) {
            Console.WriteLine( "El texto \"mm\" ha sido encontrado." );
        } else {
            Console.WriteLine( "El texto \"mm\" no ha sido encontrado." );
        }
    }
}
