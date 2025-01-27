/* RUBÉN (...)
 
 144. Crea una nueva versión del ejercicio 138 (última versión de la clase 
 Titulo), partiendo de la "solución oficial", pero en la que, en vez de 
 "getters" y "setters" convencionales, emplees "propiedades" en FORMATO 
 COMPACTO. Puedes eliminar los destructores. Prueba su funcionamiento, 
 cambiando la X y el texto después de crear el título y antes de mostrarlo. */

using System;

class Titulo
{
    public string Texto { get; set; }
    public byte X { get; set; }
    public byte Y { get; set; }

    public Titulo()
    {
    }

    public Titulo(byte nuevaX, byte nuevaY, string nuevoTexto)
    {
        X = nuevaX;
        Y = nuevaY;
        Texto = nuevoTexto;
    }

    public void Mostrar()
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine(Texto);
    }
}

class TituloSubrayado : Titulo
{
    public TituloSubrayado(byte nuevaX, byte nuevaY, string nuevoTexto)
    {
        X = nuevaX;
        Y = nuevaY;
        Texto = nuevoTexto;
    }

    public new void Mostrar()
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine(Texto);

        Console.SetCursorPosition(X, Y + 1);
        Console.WriteLine(new string('-', Texto.Length));
    }
}

class TituloCentrado : Titulo
{
    public TituloCentrado(byte nuevaY, string nuevoTexto)
    {
        X = Convert.ToByte(40 - nuevoTexto.Length / 2);
        Y = nuevaY;
        Texto = nuevoTexto;
    }
}

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo titulo1 = new Titulo(5, 1, "Hola, qué tal?");
        titulo1.Texto = "Cambiando la propiedad de la forma compacta!";
        titulo1.X = 5;
        titulo1.Mostrar();
        TituloSubrayado titulo2 = new TituloSubrayado(50, 13, "Qué tal?");
        titulo2.Mostrar();
        TituloCentrado titulo3 = new TituloCentrado(10, "Hola, otra vez");
        titulo3.Mostrar();
    }
}
