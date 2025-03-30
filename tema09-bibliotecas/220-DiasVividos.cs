/* 220. Crea un programa que pregunte al usuario su fecha de nacimiento (día, 
mes y año) y le diga cuántos días ha vivido hasta ahora. */

using System;

class diasVividos
{
    static void Main()
    {
        Console.WriteLine("Fecha de nacimiento");
        Console.WriteLine();

        Console.Write("Día: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mes (número): ");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Año (cuatro cifras): ");
        int anyo = Convert.ToInt32(Console.ReadLine());

        DateTime fechaActual = DateTime.Now;
        DateTime nacimiento = new DateTime(anyo, mes, dia);
        TimeSpan diasVividos = fechaActual.Subtract(nacimiento);

        Console.WriteLine();
        Console.WriteLine("Has vivido {0} días", diasVividos.Days);
    }
}
