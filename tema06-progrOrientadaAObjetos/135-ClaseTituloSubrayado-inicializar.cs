/*Crea una versión mejorada del ejercicio anterior, con un método 
"Inicializar(x, y, texto)" para la clase "Título", que permita fijar a 
la vez los valores iniciales para x, y, texto. Pruébalo desde "Main" 
con los valores, escribiendo un título subrayado con los valores: texto 
= "Hola", x = 35, y = 11*/ 

// Damian (...)

using System;

class Titulo
{
    protected string texto;
    protected int x;
    protected int y;

    public string GetTexto() {  return texto; }
    public int GetX() { return x; }
    public int GetY() { return y; }

    public void SetTexto(string nuevoTexto) {  texto = nuevoTexto; }
    public void SetX(int nuevaX) { x = nuevaX; }
    public void SetY(int nuevaY) { y = nuevaY; }

    public void Inicializar(int x1, int y1, string texto1)
    {
        x = x1;
        y = y1;
        texto = texto1;
    }

    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
}

// ------------------------

class TituloSubrayado : Titulo
{
    public new void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);

        Console.SetCursorPosition(x, y + 1);
        Console.WriteLine(new string('-',texto.Length) );
    }
}

// ------------------------

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo t = new Titulo();
        t.Inicializar(5,1,"Hola, qué tal?");
        t.Mostrar();
        
        TituloSubrayado t2 = new TituloSubrayado();
        t2.Inicializar(50, 13, "Qué tal?");
        t2.Mostrar();
    }
}
