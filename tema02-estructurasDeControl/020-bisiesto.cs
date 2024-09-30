// Noelia P.(...)

/*20. Un año es bisiesto si es múltiplo de 4 pero no múltiplo de 100. 
Pero existe una excepción: los años que son múltiplos de 400, que 
siempre son bisiestos. Crea un programa que pida al usuario el número 
de un año y le diga si es bisiesto. Como datos de prueba: 1992 fue 
bisiesto, 2000 también, pero no lo fueron 1900 ni 1993. */
 
using System;
 
class Ejercicio20
{
    static void Main()
    {
        Console.Write("Introduce un año: ");
        int anyo = Convert.ToInt32(Console.ReadLine());
        
        if ((anyo % 4 == 0 && anyo % 100 !=0) || (anyo % 400 == 0))
        {
            Console.WriteLine("Es bisiesto");
        }
        else
        {
            Console.WriteLine("No es bisiesto");
        }
    }
}
