﻿/* RUBÉN (...)
 
 146. A partir del ejercicio anterior (145), crea un programa cuyo Main prepare 
 un array de títulos. Este array contendrá un título convencional, un título 
 centrado y dos títulos subrayados, en distintas coordenadas de pantalla, y el 
 programa de prueba primero creará todos ellos y luego mostrará todos ellos. 
 Comprueba si los subrayados se ven correctamente (es probable que no sea así). 
 */

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
        Titulo[] titulos = new Titulo[4];

        Titulo titulo1 = new Titulo(5, 1, "Hola, qué tal?");
        titulo1.Texto = "Cambiando el texto desde el metodo compacto";
        titulo1.X = 23;
        TituloSubrayado titulo2 = new TituloSubrayado(50, 13, "Qué tal?");
        TituloSubrayado titulo3 = new TituloSubrayado(25, 3, "Hola mundo");
        TituloCentrado titulo4 = new TituloCentrado(10, "Hola, otra vez");

        titulos[0] = titulo1;
        titulos[1] = titulo2;   
        titulos[2] = titulo3;
        titulos[3] = titulo4;

        for (int i = 0; i < 4; i++)
        {
            titulos[i].Mostrar();
        }

    }
}
