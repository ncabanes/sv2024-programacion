/* Pide al usuario un número entre el 0 y el 100, con un máximo de 2 
cifras decimales. Calcula su producto por 3,14 (este dato y el 
resultado de la multiplicación deberán estar en variables). Haz una 
variante con datos "float" y otra con datos "double".
 */

using System;

class Ejemplo 
{
    static void Main() 
    {
        float n;
        float pi = 3.1415965359f;
        
        Console.Write("Dime un número: ");
        n = Convert.ToSingle( Console.ReadLine() );
        
        Console.WriteLine(n * pi);
        
        // --------------------
        
        double n2;
        double pi2 = 3.1415965359;
        
        Console.Write("Dime otro número: ");
        n2 = Convert.ToDouble( Console.ReadLine() );
        
        Console.WriteLine(n2 * pi2);
    }
}

/*
Dime un número: 10
31,41597
Dime otro número: 10
31,415965359
*/
