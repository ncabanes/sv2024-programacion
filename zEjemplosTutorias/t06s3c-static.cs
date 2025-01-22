// Crea una clase "Encriptador" que utilizaremos para
// cifrar y descifrar textos. Tendrá un método "Encriptar",
// que recibirá una cadena y devolverá otra cadena (el
// resultado de sumar 1 a cada carácter), y un método
// "Desencriptar", que devolverá también devolverá una
// cadena (el resultado de restar 1 a cada carácter).
// Ambos métodos serán "static". Crea una clase
// "PruebaDeEncriptador", que compruebe su funcionamiento
// desde "Main".

using System;
using System.IO;

// -----------------------

class Encriptador
{
    public static string Encriptar(string texto)
    {
        string respuesta = "";
        for (int i = 0; i<texto.Length; i++)
        {
            respuesta += (char) (texto[i] + 1);
        }
        return respuesta;
    }

    public static string Desencriptar(string texto)
    {
        string respuesta = "";
        for (int i = 0; i < texto.Length; i++)
        {
            respuesta += (char)(texto[i] - 1);
        }
        return respuesta;
    }
}
class PruebaDeEncriptador
{ 
    static void Main()
    {
        string texto = "Hola";
        string textoEncriptado = Encriptador.Encriptar(texto);

        Console.WriteLine( textoEncriptado );
        Console.WriteLine( Encriptador.Desencriptar(textoEncriptado));
    }
}

// Ipmb
// Hola
