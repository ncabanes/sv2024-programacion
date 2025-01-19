/* MARTA (...)
 * 
 * 138. A partir del ejercicio 137, añade un destructor a la clase 
 "Titulo", que escriba en pantalla "Destruyendo el título". Comprueba 
 el funcionamiento de esta versión del programa. */

using System;

class Titulo
{
    protected string texto;
    protected byte x, y;
    
    public Titulo()
    {
    }
    
    public Titulo(byte nuevaX, byte nuevaY, string nuevoTexto)
    {
        x = nuevaX;
        y = nuevaY;
        texto = nuevoTexto;
    }

    ~Titulo()
    {
        Console.WriteLine("Destruyendo el título");
    }    

    public string GetTexto() {  return texto; }
    public int GetX() { return x; }
    public int GetY() { return y; }

    public void SetTexto(string nuevoTexto) {  texto = nuevoTexto; }
    public void SetX(int nuevaX) { x = (byte) nuevaX; }
    public void SetY(int nuevaY) { y = (byte) nuevaY; }
    
    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
}

class TituloSubrayado: Titulo
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
        Console.WriteLine(new string('-',texto.Length) );
    }
}

class TituloCentrado: Titulo
{
    public TituloCentrado( byte nuevaY, string nuevoTexto)
    {
        x = Convert.ToByte(40 - nuevoTexto.Length/2);
        y = nuevaY;
        texto = nuevoTexto;
    }
}

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo titulo1 = new Titulo(5,1,"Hola, qué tal?");
        titulo1.Mostrar();
        TituloSubrayado titulo2 = new TituloSubrayado(50, 13, "Qué tal?");
        titulo2.Mostrar();
        TituloCentrado titulo3 = new TituloCentrado(10, "Hola, otra vez");
        titulo3.Mostrar();
    }
}
