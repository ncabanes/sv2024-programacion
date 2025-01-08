/* Mejora la clase "Libro": los atributos no serán públicos, sino que 
habrá métodos Get y Set adecuados para leer su valor y cambiarlo.
*/

using System;

class Libro 
{
    private string autor;
    private string titulo;
    private string ubicacion;
    
    public string GetAutor()
    {
        if (autor == "")
            return "Anónimo";
        else
            return autor;
    }
    
    public void SetAutor(string nuevoAutor)
    {
        autor = nuevoAutor;
    }
    
    public string GetTitulo()
    {
        return titulo;
    }
    
    public void SetTitulo(string nuevoTitulo)
    {
        titulo = nuevoTitulo;
    }
    
    public string GetUbicacion()
    {
        return ubicacion;
    }
    
    public void SetUbicacion(string nuevaUbicacion)
    {
        ubicacion = nuevaUbicacion;
    } 

    public void MostrarDetalles()
    {
        Console.WriteLine(autor);
        Console.WriteLine(titulo);
        Console.WriteLine(ubicacion);
    }
}

public class PruebaDeLibro
{
    static void Main() 
    {
        Libro l = new Libro();
        l.SetTitulo("It");
        l.SetAutor("Stephen King");
        l.SetUbicacion("e1b2");
        
        l.MostrarDetalles();
    }
}

/*
Stephen King
It
e1b2
*/
