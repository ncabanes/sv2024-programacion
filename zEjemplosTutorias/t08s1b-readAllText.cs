// Crea una variante del ejercicio anterior, tratando todo
// el fichero como una gran cadena de texto.

using System;
using System.IO;

class Ejemplo
{
    static void Main()
    {
        string texto = File.ReadAllText("dracula.txt");
        texto = texto.Replace(" ", "");
        File.WriteAllText("dracula3.txt", texto);
    }
}
