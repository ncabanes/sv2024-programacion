/* 
Crea un programa que le pida al usuario un número y responda si es 
primo. Debes hacerlo contando cuántos divisores tiene. Será primo si y 
solo si tiene exactamente dos divisores. Debes emplear "do-while".

SERGIO (...)
*/

using System;

class Ejercicio_28
{
    static void Main()
    {
        int n;
        int divisorActual = 1;
        int divisoresEncontrados = 0;
        
        Console.Write("Por favor, introduzca un numero ");
        n = Convert.ToInt32( Console.ReadLine() );
        
        do
        {
            if (n % divisorActual == 0)
            {
                divisoresEncontrados ++;
            }
            divisorActual ++;
        }
        while (divisorActual <= n);
        
        if (divisoresEncontrados == 2)
        {
            Console.WriteLine("El numero introducido es Primo");
        }
        else
        {
        Console.WriteLine("El numero introducido no es Primo");
        }
    }
}
