// Crea un programa que, cada vez que se lance, pida
// una frase al usuario, la añada al fichero "registro.txt" y termine.

using System;
using System.IO;

class Ejemplo
{
    static void Main()
    {
        Console.Write("Nueva entrada para el registro? ");
        string texto = Console.ReadLine();

        //StreamWriter fichero = new StreamWriter("registro.txt", true);
        StreamWriter fichero = File.AppendText("registro.txt");
        fichero.WriteLine(texto);
        fichero.Close();
    }
}
