/*

16. Pregunta al usuario el número de un mes y muestra cuántos días 
tiene, usando "if". Por ejemplo, si el mes es el 3, la respuesta 
debería ser "31 días". (Supon que febrero siempre tiene 28 días). No 
debes usar 12 casos distintos, sino agrupar las condiciones de la 
manera que consideres más conveniente. Si el mes no es correcto (por 
ejempo, el mes 13 o el mes 0), responderá "Número de mes no válido".

SERGIO (..)

*/

using System;

class Ejercicio16
{
    static void Main()
    {
        int mes;
        
        Console.Write("Introduce el mes en formato numerico (1 a 12): ");
        mes = Convert.ToInt32( Console.ReadLine() );
        
        if (( mes == 1 ) || ( mes == 3 ) || ( mes == 5 ) || 
            ( mes == 7 ) || ( mes == 8 ) || ( mes == 10 ) || 
            ( mes == 12 ))            
        {
            Console.WriteLine("Ese mes tiene 31 dias.");
        }
        else if (( mes == 4 ) || ( mes == 6 ) || ( mes == 9 ) || 
            ( mes == 11))
        {
            Console.WriteLine("Ese mes tiene 30 dias.");
        }
        else if ( mes == 2 )
        {
            Console.WriteLine("Ese mes tiene 28 dias.");
        }
        else 
        {
            Console.WriteLine("Numero de mes no valido.");
        }
    }
}
