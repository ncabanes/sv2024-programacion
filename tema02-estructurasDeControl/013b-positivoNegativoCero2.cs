/*******************************************************************************
* 1º DAW
* Módulo: Programación
* Tema 2 - Ejercicio 13
* Autor: César (...)
* Descripción: ¿Positivo, negativo o cero?
*******************************************************************************/

using System;

class ParImparCero
{
    static void Main()
    {
        int n;
        
        Console.Write("Escribe un número: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        if (n < 0) 
        {
            Console.WriteLine("El número {0} es negativo",n);
        } 
        else if ( n > 0) 
        {
            Console.WriteLine("El número {0} es positivo",n);
        } 
        else 
        {
            Console.WriteLine("El número es cero",n);
        }
    }
}
