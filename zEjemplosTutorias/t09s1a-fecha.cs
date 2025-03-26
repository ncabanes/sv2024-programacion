// Muestra la fecha actual, en formato "25-Marzo-25 Lunes".
// Ayúdate de un array con los nombres de los meses y otro
// con los nombres de los días de la semana.

using System;

class Program
{
    static void Main()
    {
        string[] nombresMeses = { "Enero", "Febrero", "Marzo" };
        string[] nombresDias = { "Domingo", "Lunes", "Martes", "Miércoles" };
        DateTime ahora = DateTime.Now;
        //Console.WriteLine(ahora);
        Console.WriteLine(ahora.Day.ToString("00") +"-"+
            nombresMeses[ahora.Month-1] + "-"+
            ahora.Year % 100 + " "+
            nombresDias[(int) ahora.DayOfWeek]);
    }
}
