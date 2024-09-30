/*Crea una variante del ejercicio anterior, que emplee "switch" en vez de "if".
 *  Al igual que en aquella ocasión, debes agrupar los casos en la medida de lo
 *  posible.
*/

// Luis (...)

using System;

class DiasMes
{
    static void Main ()
    {
        int numeroMes;
        
        Console.WriteLine ("Dime un número de mes");
        numeroMes = Convert.ToInt32 (Console.ReadLine());
        
        switch (numeroMes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12: Console.WriteLine ("El mes tiene 31 días"); break;
            
            case 2: Console.WriteLine ("El mes tiene 28 días"); break;
            
            case 4:
            case 6:
            case 9:
            case 11: Console.WriteLine ("El mes tiene 30 días"); break;
            
            default: Console.WriteLine ("Número de mes no válido"); break;
        }            
    }  
}
