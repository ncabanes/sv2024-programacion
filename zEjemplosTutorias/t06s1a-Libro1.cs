/* Para guardar información sobre libros, vamos a comenzar por crear 
una clase "Libro", que contendrá atributos "autor", "titulo", 
"ubicacion" (todos ellos strings). En esta primera aproximación, los 
tres atributos serán públicos. Crea también un método 
"MostrarDetalles", que escriba los valores de los tres atributos, cada 
uno en una línea. Finalmente, prepara también un Main (en la misma 
clase), que cree un objeto de la clase Libro, dé valores a sus tres 
atributos y luego los muestre. */

using System;

class Libro 
{
    public string autor;
    public string titulo;
    public string ubicacion;
    
    public void MostrarDetalles()
    {
        Console.WriteLine(autor);
        Console.WriteLine(titulo);
        Console.WriteLine(ubicacion);
    }
    
    
    static void Main() 
    {
        Libro l = new Libro();
        l.titulo = "It";
        l.autor = "Stephen King";
        l.ubicacion = "e1b2";
        
        l.MostrarDetalles();
    }
}

/*
Stephen King
It
e1b2
*/
