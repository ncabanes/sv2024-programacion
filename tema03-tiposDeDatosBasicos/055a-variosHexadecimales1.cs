/*Sara (...)
 * 
 * Pide al usuario dos números enteros cortos y muestra todos los
 *  números que hay entre ellos, ambos incluidos, en hexadecimal,
 *  en la misma línea, separados por un espacio. Por ejemplo, si
 *  introduce 8 y 11, deberás mostrar "8 9 a b". El programa se debe
 *  comportar correctamente si introduce los números en orden
 *  contrario, es decir, si primero indica 11 y 8 en vez de 8 y 11.*/

using System;

class NumerosEnHexadecimal
{
    static void Main()
    {
        short n1, n2;
        
        Console.WriteLine("Dime un número entero");
        n1 = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Dime otro número entero");
        n2 = Convert.ToInt16(Console.ReadLine());
        
        if(n1>n2)
        {
            for(short i=n2; i<=n1; i++)
            {
                Console.Write(Convert.ToString(i, 16));
                Console.Write(" ");
            }
        }
        else if(n2>n1)
        {
            for(short u=n1; u<=n2; u++)
            {
                Console.Write(Convert.ToString(u, 16));
                Console.Write(" ");
            }
        }
    }
}
