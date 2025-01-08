using System;

class Libro
{
    private string autor;
    private string titulo;
    private string ubicacion;

    public string GetAutor() { return autor; }
    public string GetTitulo() { return titulo; }
    public string GetUbicacion() { return ubicacion; }

    public void SetAutor(string nuevoAutor) { autor = nuevoAutor; }
    public void SetTitulo(string nuevoTitulo) { titulo = nuevoTitulo; }
    public void SetUbicacion(string nuevaUbicacion) { ubicacion = nuevaUbicacion; }

    public void MostrarDetalles()
    {
        Console.WriteLine(autor);
        Console.WriteLine(titulo);
        Console.WriteLine(ubicacion);
    }
}

// -----------------------

class PruebaDeLibro
{
    static void Main()
    {
        Libro l = new Libro();
        l.SetAutor("Stephen King");
        l.SetTitulo("It");
        l.SetUbicacion("e3b4");

        l.MostrarDetalles();
    }
}
