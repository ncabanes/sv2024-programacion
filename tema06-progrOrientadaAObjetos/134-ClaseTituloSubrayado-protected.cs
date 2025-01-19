/*Crea una nueva versión de clase "Titulo" y "TituloSubrayado" 
(ej.133), en la que los atributos sean "protected", y emplees los 
atributos en vez de "getters". Pruébalo en "Main".*/ 

// Lucia (...)

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
