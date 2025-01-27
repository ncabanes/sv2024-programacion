/* RUBÉN (...)
 
 143. Crea una nueva versión del ejercicio 138 (última versión de la clase 
 Titulo), partiendo de la "solución oficial", pero en la que, en vez de 
 "getters" y "setters" convencionales, emplees "propiedades" en FORMATO LARGO. 
 Puedes eliminar los destructores. Prueba su funcionamiento, cambiando la X y 
 el texto después de crear el título y antes de mostrarlo. */

using System;

class Titulo
{
    protected string texto;
    protected byte x;
    protected byte y;
    public string Texto
    {
        get
        {
            return texto;
        }

        set
        {
            texto = value;
        }

    }

    public byte X
    {
        get
        {
            return x;
        }

        set
        {
            x = value;
        }
    }

    public byte Y
    {
        get
        {
            return y;
        }

        set
        {
            y = value;
        }
    }

    public Titulo()
    {
    }

    public Titulo(byte nuevaX, byte nuevaY, string nuevoTexto)
    {
        x = nuevaX;
        y = nuevaY;
        texto = nuevoTexto;
    }

    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
}

class TituloSubrayado : Titulo
{
    public TituloSubrayado(byte nuevaX, byte nuevaY, string nuevoTexto)
    {
        x = nuevaX;
        y = nuevaY;
        texto = nuevoTexto;
    }

    public new void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);

        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine(new string('-', texto.Length));
    }
}

class TituloCentrado : Titulo
{
    public TituloCentrado(byte nuevaY, string nuevoTexto)
    {
        x = Convert.ToByte(40 - nuevoTexto.Length / 2);
        y = nuevaY;
        texto = nuevoTexto;
    }
}

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo titulo1 = new Titulo(5, 1, "Hola, qué tal?");
        titulo1.Texto = "Cambio desde metodo oculto en propiedad!";
        titulo1.X = 12;
        titulo1.Mostrar();
        TituloSubrayado titulo2 = new TituloSubrayado(50, 13, "Qué tal?");
        titulo2.Mostrar();
        TituloCentrado titulo3 = new TituloCentrado(10, "Hola, otra vez");
        titulo3.Mostrar();
    }
}
