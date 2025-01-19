/*Crea una clase "TituloSubrayado", que herede de "Titulo" (ej.125) y 
que mostrará guiones debajo del título. Tu fuente contendrá las tres 
clases: Titulo (sin modificar), TituloSubrayado y PruebaDeTitulo. 
Pruébalo en "Main", mostrando un título subrayado. Quizá obtengas algún 
error de compilación si intentas acceder a los atributos, y debas 
emplear los "getters".*/ 

// Lucia (...)

using System;

class Titulo
{
    
    private string texto;
    private int x;
    private int y;

    public string GetTexto() {  return texto; }
    public int GetX() { return x; }
    public int GetY() { return y; }

    public void SetTexto(string nuevoTexto) {  texto = nuevoTexto; }
    public void SetX(int nuevaX) { x = nuevaX; }
    public void SetY(int nuevaY) { y = nuevaY; }

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
        Console.SetCursorPosition( GetX(), GetY() );
        Console.WriteLine( GetTexto() );

        Console.SetCursorPosition(GetX(), GetY() + 1);
        Console.WriteLine(new string('-',GetTexto().Length) );
    }
}

// ------------------------

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo t = new Titulo();
        t.SetX(5);
        t.SetY(1);
        t.SetTexto("Hola, qué tal?");
        t.Mostrar();
        
        TituloSubrayado t2 = new TituloSubrayado();
        t2.SetX(50);
        t2.SetY(13);
        t2.SetTexto("Qué tal?");
        t2.Mostrar();
    }
}
