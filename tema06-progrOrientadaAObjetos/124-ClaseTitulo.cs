/*Sara (...)
  
 Crea una clase llamada "Titulo". Sus atributos (públicos) serán el 
 texto y las coordenadas x e y. Tendrá un método público void llamado 
 "Mostrar", que mostrará su texto en la pantalla, en las coordenadas 
 indicadas por sus atributos x e y. Crea una clase "PruebaDeTitulo" (en 
 el mismo fichero fuente), que contendrá un "Main" para probar la clase 
 "Titulo". Puedes ayudarte de Console.SetCursorPosition(columna,fila) 
 para conseguir que el texto aparezca realmente en esas coordenadas. 
 Deberás entregar sólo el (único) fichero .cs.
*/

using System;

class Titulo
{
    public string texto;
    public int x;
    public int y;

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
        t.x = 5;
        t.y = 1;
        t.texto = "Hola, qué tal?";
        t.Mostrar();
    }
}
