// Genera 6 números al azar del 1 al 49, que nos ayuden a
// rellenar un número de la "Lotería Primitiva".

using System;

class Program
{
    static void Main()
    {
        Random generador = new Random();
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(generador.Next(1,50));
        }
    }
}
