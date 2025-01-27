/* RUBÉN (...)
 
 145. Crea una nueva versión del ejercicio 138 (última versión de la clase 
 Titulo), partiendo de la "solución oficial", pero en la que, en vez de 
 "getters" y "setters" convencionales, emplees "propiedades", usando el formato 
 compacto cuando sea posible, pero teniendo en cuenta que las propiedades X e Y 
 deben ser de tipo "int", pero ocultar datos que internamente serán de tipo 
 "byte". Prueba su funcionamiento, cambiando la X y el texto antes de mostrar 
 el título. Puedes eliminar los destructores. */

using System;

class Titulo
{
    public string Texto { get; set; }
    protected byte x, y;
    
    public int X
    {
        get
        {
            return x;   
        }

        set
        {
            x = (byte) value;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }

        set
        {
            y = (byte) value;
        }
    }

    public Titulo()
    {
    }

    public Titulo(byte nuevaX, byte nuevaY, string nuevoTexto)
    {
        x = nuevaX;
        y = nuevaY;
        Texto = nuevoTexto;
    }

    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(Texto);
    }
}

class TituloSubrayado : Titulo
{
    public TituloSubrayado(byte nuevaX, byte nuevaY, string nuevoTexto)
    {
        x = nuevaX;
        y = nuevaY;
        Texto = nuevoTexto;
    }

    public new void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(Texto);

        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine(new string('-', Texto.Length));
    }
}

class TituloCentrado : Titulo
{
    public TituloCentrado(byte nuevaY, string nuevoTexto)
    {
        x = Convert.ToByte(40 - nuevoTexto.Length / 2);
        y = nuevaY;
        Texto = nuevoTexto;
    }
}

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo titulo1 = new Titulo(5, 1, "Hola, qué tal?");
        titulo1.Texto = "Cambiando el texto desde el metodo compacto";
        titulo1.X = 23;
        titulo1.Mostrar();
        TituloSubrayado titulo2 = new TituloSubrayado(50, 13, "Qué tal?");
        titulo2.Mostrar();
        TituloCentrado titulo3 = new TituloCentrado(10, "Hola, otra vez");
        titulo3.Mostrar();
    }
}
