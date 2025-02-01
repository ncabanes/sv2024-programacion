/* 154. A partir del ejercicio anterior (o del ejercicio 147, si no lo has 
conseguido), crea una nueva versión, que incluya una variante sobrecargada del 
método "Mostrar" de la clase "TituloSubrayado", que recibirá como parámetro el 
carácter con el que se desea que el texto aparezca subrayado. Pruébalo en Main, 
mostrando dos títulos subrayados, uno de los cuales usará guiones y otro usará 
"=". Debes intentar minimizar la cantidad de código repetitivo, usando "base" o 
"this" donde sea necesario.*/

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

    public Titulo(byte x, byte y, string texto)
    {
        this.x = x;
        this.y = y;
        Texto =texto;
    }

    public virtual void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(Texto);
    }
}

class TituloSubrayado : Titulo
{
    public TituloSubrayado(byte x, byte y, string texto)
        : base(x, y, texto)
    {
    }
    
    public void Mostrar(char simbolo)
    {
        base.Mostrar();

        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine(new string(simbolo, Texto.Length));
    }
    
    public override void Mostrar()
    {
        this.Mostrar('-');
    }
}

class TituloCentrado : Titulo
{
    public TituloCentrado(byte y, string texto):
        base(Convert.ToByte(40 - texto.Length / 2), y, texto)
    {
    }
}

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo[] titulos = new Titulo[3];

        Titulo titulo1 = new Titulo(5, 1, "Hola, qué tal?");
        titulo1.Texto = "Cambiando el texto desde el metodo compacto";
        titulo1.X = 23;
        TituloSubrayado titulo2 = new TituloSubrayado(50, 13, "Qué tal?");
        TituloCentrado titulo3 = new TituloCentrado(10, "Hola, otra vez");
        TituloSubrayado titulo4 = new TituloSubrayado(25, 15, "Hola mundo");

        titulos[0] = titulo1;
        titulos[1] = titulo2;   
        titulos[2] = titulo3;

        for (int i = 0; i < 3; i++)
        {
            titulos[i].Mostrar();
        }
        
        titulo4.Mostrar('=');

    }
}
