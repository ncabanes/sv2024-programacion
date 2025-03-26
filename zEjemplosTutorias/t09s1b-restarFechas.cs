// Calcula cuántos días quedan hasta que empiecen los
// exámenes (19 de mayo).

using System;

class Program
{
    static void Main()
    {
        DateTime ahora = DateTime.Now;
        DateTime examenes = new DateTime(2025, 5, 19);

        TimeSpan diferencia = examenes - ahora;

        Console.WriteLine(diferencia.Days);
    }
}
