/* 177. Crea una clase "EncriptadorCesar", que herede de "Encriptador" 
(ejercicio 176) y que use el "cifrado de César para encriptar y 
desencriptar textos, con un desplazamiento de 3 posiciones. 
https://es.wikipedia.org/wiki/Cifrado_C%C3%A9sar  */

using System;

class PruebaEncriptador
{
    static void Main()
    {
        Encriptador encriptador = new EncriptadorCesar();

        string texto = "PRUEBA DE ENCRIPTACIÓN 2 ABC XYZ";
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

class EncriptadorCesar: Encriptador
{
    public override string Encriptar(string cadena)
    {
        string cadenaCifrada = "";

        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] >= 'a' && cadena[i] <= 'w'
                || cadena[i] >= 'A' && cadena[i] <= 'W')
                cadenaCifrada += Convert.ToChar(cadena[i] + 3);
            else if (cadena[i] >= 'x' && cadena[i] <= 'z'
                || cadena[i] >= 'X' && cadena[i] <= 'Z')
                cadenaCifrada += Convert.ToChar(cadena[i] - 23);

            else
                cadenaCifrada += cadena[i];
        }
        return cadenaCifrada;
    }

    public override string Desencriptar(string cadena)
    {
        string cadenaDescifrada = "";

        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] >= 'd' && cadena[i] <= 'z'
              || cadena[i] >= 'D' && cadena[i] <= 'Z')
                cadenaDescifrada += Convert.ToChar(cadena[i] - 3);
            else if (cadena[i] >= 'a' && cadena[i] <= 'c'
                || cadena[i] >= 'A' && cadena[i] <= 'C')
                cadenaDescifrada += Convert.ToChar(cadena[i] + 23);

            else
                cadenaDescifrada += cadena[i];
        }
        return cadenaDescifrada;
    }
}
