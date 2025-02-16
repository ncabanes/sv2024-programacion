/* 176. Crea una clase "Encriptador" que utilizaremos para cifrar y descifrar 
 * textos.

Tendrá un método "Encriptar", abstracto, que recibirá una cadena y devolverá
otra cadena, y un método "Desencriptar", también abstracto, y con mismo
parámetro y valor devuelto.

Crea una clase "EncriptadorXOR", que herede de "Encriptador" y que haga una
operación "XOR 1" a cada carácter, tanto para obtener el texto cifrado como
para descrifrarlo (recuerda que habíamos estudiado las operaciones a nivel de
bits en el apartado 3.1.6, del tema 3).

Luis (...), retoques menores por Nacho  */

using System;

class PruebaEncriptador
{
    static void Main()
    {
        Encriptador encriptador = new EncriptadorXOR();

        string texto = "Prueba de Encriptación";
        string textoEncriptado = encriptador.Encriptar(texto);
        string textoDesencriptado = encriptador.Desencriptar(textoEncriptado);

        Console.WriteLine("Texto Original: {0}",texto);
        Console.WriteLine("Texto Encriptado: {0}", textoEncriptado);
        Console.WriteLine("Texto Desencriptado: {0}", textoDesencriptado);
    }
}

public abstract class Encriptador
{
    public abstract string Encriptar(string texto);
    public abstract string Desencriptar(string texto);
}


public class EncriptadorXOR : Encriptador
{
    public override string Encriptar(string texto)
    {
        return AplicarXOR(texto);
    }

    public override string Desencriptar(string texto)
    {
        return AplicarXOR(texto);
    }

    private string AplicarXOR(string texto)
    {
        string temporal = "";
        for (int i = 0; i < texto.Length; i++)
        {
            temporal += (char)(texto[i] ^ 1); 
        }
        return temporal;
    }
}
