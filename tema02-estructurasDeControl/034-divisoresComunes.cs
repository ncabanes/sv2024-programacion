/* 34. Escribe un programa que le pida al usuario dos números y muestre sus 
divisores comunes. La apariencia debe ser como ésta:
Introduce un número: 8
Introduce otro número: 12
Sus divisores comunes son: 1 2 4

Luis (...) */

using System;

class Divisores
{
    static void Main()
    {
        int num1, num2, menor;
        
        Console.Write( "Introduce un número: " );
        num1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write( "Introduce otro número: " );
        num2 = Convert.ToInt32( Console.ReadLine() );
        
        if ( num1 > num2 )
        {
            menor = num2;
        }
        else
        {
            menor = num1;
        }
        
        Console.Write( "Sus divisores comunes son: ");
        for( int i = 1; i <= menor; i++ )
        {
            if ( (num1 % i == 0) && (num2 % i == 0) )
            {
                Console.Write( "{0} ", i );
            }
        }
        
    }
}
