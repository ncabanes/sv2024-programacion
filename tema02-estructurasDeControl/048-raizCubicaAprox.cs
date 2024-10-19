/*Silvia (...)

Haz un programa que calcule una raíz cúbica (entera, sin decimales) por 
tanteo. Por ejemplo, si se introduce el número 8, probará a calcular 
1*1*1 y verá que no ha llegado, luego probará 2*2*2 y verá que ha 
obtenido la respuesta, que es 2, por lo que escribirá "2 (exacta)". Si 
se introduce un número como el 30, tu programa probará con 1, luego con 
2, luego con 3 (que todavía no llega a 30, porque 3*3*3 = 27), y 
finalmente con 4 (que es demasiado alto, porque 4*4*4 = 64), así que 
responderá "3 (aproximada)". */

using System;

class RaizCubica
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int num = int.Parse(Console.ReadLine());
        int i = 0;

        while (i * i * i < num)
        {
            i++;
        }

        if (i * i * i == num)
            Console.WriteLine("{0} (exacta)", i);
        else
            Console.WriteLine("{0} (aproximada)", i-1);
    }
}
