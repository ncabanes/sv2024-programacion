// Crea una clase Cadena, que internamente contenga un "string".
// Sobrecarga el operador "*", para poder "multiplicar una cadena por
// un número". Por ejemplo, el texto "Hola", si se multiplica por 3,
// generaría "HolaHolaHola".

using System;

class Cadena
{
    private string texto;

    public Cadena(string texto)
    {
        this.texto = texto;
    }

    public static Cadena operator *(Cadena c, int veces)
    {
        string respuesta = "";
        for (int i = 0; i < veces; i++)
        {
            respuesta += c.texto;
        }
        return new Cadena(respuesta);
    }

    public override string ToString()
    {
        return texto;
    }
}

// -----------------------

class PruebaDeCadena
{
    static void Main()
    {
        Cadena c = new Cadena("Hola");
        Console.WriteLine(c * 3);
    }
}
