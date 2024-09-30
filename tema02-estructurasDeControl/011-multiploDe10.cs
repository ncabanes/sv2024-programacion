/*
11. Crea un programa en C# que pida al usuario un número entero y 
responda si es múltiplo de 10 o no lo es, empleando dos órdenes "if" 
consecutivas (en este primera versión NO debes emplear "else"). Pista: 
deberás usar el "operador módulo" (%).
*/

// Néstor (...)

using System;

class MultiploDe10 
{
    static void Main()
    {
        int numero;
        Console.WriteLine("Introduce un número");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 10 == 0) 
        {
            Console.WriteLine("El número es múltiplo de 10");
        } 

        if (numero % 10 !=0)
        {
            Console.WriteLine("El número no es múltiplo de 10");
        }
    }
}
