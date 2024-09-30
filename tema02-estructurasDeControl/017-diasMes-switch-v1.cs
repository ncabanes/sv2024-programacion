/*

17. Crea una variante del ejercicio anterior, que emplee "switch" en 
vez de "if". Al igual que en aquella ocasión, debes agrupar los casos 
en la medida de lo posible.

SERGIO (...)

*/

using System;

class Ejercicio17
{
    static void Main()
    {
        int mes;
        
        Console.Write("Introduce el mes en formato numerico (1 a 12): ");
        mes = Convert.ToInt32( Console.ReadLine() );
        
        switch (mes)
        {
            case 1:
                Console.WriteLine("Ese mes tiene 31 dias");
                break;
            case 2:
                Console.WriteLine("Ese mes tiene 28 dias");
                break;
            case 3:
                goto case 1;
            case 4:
                Console.WriteLine("Ese mes tiene 30 dias");
                break;
            case 5: goto case 1;
            case 6: goto case 4;
            case 7: goto case 1;
            case 8: goto case 1;
            case 9: goto case 4;
            case 10: goto case 1;
            case 11: goto case 4;
            case 12: goto case 1;
            default:
                Console.WriteLine("Numero de mes no valido.");
                break;
        }
    }
}
