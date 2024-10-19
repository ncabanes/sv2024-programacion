/* 43. Crea un programa en C# que pida al usuario el número de un mes 
 * (por ejemplo, 3 para marzo) y el número de un día (por ejemplo, 10) y 
 * muestre de qué número de día dentro del año se trata, en un año no bisiesto.
 *  Por ejemplo: como enero tiene 31 días y febrero tiene 28, el 10 de marzo 
 * sería el día número 69 del año (31+28+10).
 * 
 *  Luis (...) */

using System;

class CalcularDiaDelAño
{
    static void Main()
    {
        int mes, dia, diaAnyo = 0;
        
        Console.Write( "Introduce un mes del año: " );
        mes = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write( "Introduce un día del mes: " );
        dia = Convert.ToInt32( Console.ReadLine() );
        
        switch ( mes )
        {
            case 1: diaAnyo = dia;
                break;
            case 2: diaAnyo = 31 + dia;
                break;
            case 3: diaAnyo = 31 + 28 + dia;
                break;
            case 4: diaAnyo = (2 * 31) + 28 + dia;
                break;
            case 5: diaAnyo = (2 * 31) + 28 +  30 + dia;
                break;
            case 6: diaAnyo = (3 * 31) + 28 +  30 + dia;
                break;
            case 7: diaAnyo = (3 * 31) + 28 +  ( 2 * 30 ) + dia;
                break;
            case 8: diaAnyo = (4 * 31) + 28 +  ( 2 * 30 ) + dia;
                break;
            case 9: diaAnyo = (5 * 31) + 28 +  ( 2 * 30 ) + dia;
                break;
            case 10: diaAnyo = (5 * 31) + 28 +  ( 3 * 30 ) + dia;
                break;
            case 11: diaAnyo = (6 * 31) + 28 +  ( 3 * 30 ) + dia;
                break;
            case 12: diaAnyo = (6 * 31) + 28 + + ( 4 * 30 ) + dia;
                break;
            default:
                Console.WriteLine( "Tiene que ser un numero del 1 al 12." );
                break;
        }
        Console.WriteLine( "El {0} del mes {1} es el dia {2} del año.", 
            dia, mes, diaAnyo );
    }
}

