/* MARTA (...)
 * 
 136. Prepara una nueva versión del ejercicio anterior, en la que la 
 clase "Titulo" tenga un constructor con los parámetros (x, y, texto) 
 en vez del método Inicializar, y también haya otro constructor similar 
 en "TituloSubrayado". Pruébalo desde "Main", con los mismos valores 
 que antes. Quizá necesites crear un constructor vacío en "Título" para 
 evitar errores de compilación; lo mejoraremos más adelante. */

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

class PruebaDeTitulo
{
    static void Main()
    {
       Titulo titulo1 = new Titulo(5,1,"Hola, qué tal?");
       titulo1.Mostrar();
       TituloSubrayado titulo2 = new TituloSubrayado(50, 13, "Qué tal?");
       titulo2.Mostrar();
    }
}
