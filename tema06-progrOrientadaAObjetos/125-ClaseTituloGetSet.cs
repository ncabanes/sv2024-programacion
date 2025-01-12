/*Sara (...)

Crea una nueva versión de la clase "Titulo". Sus atributos serán 
privados y existirán getters y setters para poder darle valor y leer su 
valor. Cambia el programa y "Main" según sea necesario. Deberás 
entregar sólo el (único) fichero .cs.
*/

using System;

class Titulo
{
    //Atributos privados
    private string texto;
    private int x;
    private int y;

    //Getters
    public string GetTexto() {  return texto; }
    public int GetX() { return x; }
    public int GetY() { return y; }

    //Setters
    public void SetTexto(string nuevoTexto) {  texto = nuevoTexto; }
    public void SetX(int nuevaX) { x = nuevaX; }
    public void SetY(int nuevaY) { y = nuevaY; }

    //Método
    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
}

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo t = new Titulo();
        t.SetX(5);
        t.SetY(1);
        t.SetTexto("Hola, qué tal?");
        t.Mostrar();
    }
}
