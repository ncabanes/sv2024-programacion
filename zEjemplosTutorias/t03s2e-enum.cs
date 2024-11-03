/* Crea una enumeración con los días de la semana. Muestra el valor del 
miércoles.
*/

using System;

class Ejemplo 
{
    enum diasSemana { LUNES, MARTES, MIERCOLES, JUEVES,
            VIERNES, SABADO, DOMINGO };

    static void Main() 
    {
        Console.WriteLine(diasSemana.MIERCOLES);
        Console.WriteLine( (int) diasSemana.MIERCOLES );
    }
}

/*
MIERCOLES
2
*/

