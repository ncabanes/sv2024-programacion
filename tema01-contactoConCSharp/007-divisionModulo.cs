/*----------------------------------------------
Damián (...)
Desarrollo de Aplicaciones Multiplataforma (DAM)
Tema 1
Ejercicio 7 
División y módulos
------------------------------------------------*/

using System;

class Division
{
    static void Main()
    {
        int a, b, division, modulo;
        
        Console.Write("Primer número: "); 
        a = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Segundo número: "); 
        b = Convert.ToInt32( Console.ReadLine() );

        division = a / b;
        modulo = a % b;
        Console.WriteLine("Resultado de la división: {0}", division);
        Console.Write("Resultado del resto: {0}", modulo);
    }
}
