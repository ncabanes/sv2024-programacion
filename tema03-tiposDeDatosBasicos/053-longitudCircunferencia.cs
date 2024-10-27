/*  Calcula la longitud de un circunferencia, a partir de su radio,
 *  que introducirá el usuario en una variable real de doble precisión
 *  (longitud = 2 * pi * radio). Tanto el valor de "pi" como el
 *  resultado (la longitud) deben estar almacenados en variables,
 *  que también serán números reales de doble precisión.*/
 
// Sara (...)

using System;

class Circunferencia
{
    static void Main()
    {
        double radio;
        double pi = 3.141592654;
        double longitud;
        
        Console.WriteLine("Dime un radio para calcular la longitud de una circunferencia");
        radio = Convert.ToDouble(Console.ReadLine());
        
        longitud = 2 * pi * radio;
        
        Console.WriteLine("La longitud de una circunferencia con radio {0} es {1}", 
            radio, longitud);
    }
}
