/*Eric (...)
Calculadora de área de círculos */

class Ejercicio9
{
    static void Main()
    {
        int r;
        
        System.Console.Write("Medida del radio: ");
        r = System.Convert.ToInt32( System.Console.ReadLine() );

        System.Console.WriteLine(
            "El área del círculo de radio {0} es de {1}", 
            r, 3.141592 * r * r);
    }
}

/*
Requisitos que se pedían
- debes usar un único WriteLine con {0}, en vez de varios "Write"
- No puedes utilizar "using System;
- El programa debe contener un único comentario de múltiples líneas, 
    al principio, que detalle tu nombre y el cometido del programa
*/
