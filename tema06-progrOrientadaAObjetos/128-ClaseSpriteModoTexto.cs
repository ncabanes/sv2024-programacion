/*
Crea una clase llamada "SpriteModoTexto", que representará una supuesta imagen
de un juego en modo de consola. Sus atributos (públicos) serán las coordenadas 
x e y (de tipo byte) y el carácter que represente esa supuesta imagen. Tendrá 
un método (void) llamado "Dibujar", que mostrará ese carácter en la pantalla, 
en las coordenadas indicadas por sus atributos (puedes ayudarte de Console.SetCursorPosition 
para conseguir que el texto aparezca realmente en esas coordenadas). Crea una clase 
"PruebaDeSprite" (en el mismo fichero fuente), que tendrá un "Main" para probar 
la clase "SpriteModoTexto", creando una supuesta nave espacial formada por el
carácter "M", en las coordenadas (40, 20) y que habrá de mostrarse.
*/

// Blanca (...)

using System;

class SpriteModoTexto
{
    public int X, Y;
    public char Caracter;

    public void Dibujar()
    {
        Console.SetCursorPosition(X, Y);
        Console.WriteLine(Caracter);
    }
}

class PruebaDeSprite
{
    static void Main()
    {
        SpriteModoTexto t = new SpriteModoTexto();
        t.X = 40;
        t.Y = 10;
        t.Caracter = 'M';
        t.Dibujar();
    }
}



