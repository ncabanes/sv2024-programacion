// 47. Prepara un programa que le pida al usuario un número entero y muestre sus factores primos,
// usando la estructura repetitiva que consideres más adecuada.
// Por ejemplo, para 15 deberá responder "3 5", para 24 responderá "2 2 2 3" y para 60 deberá escribir "2 2 3 5".

// Pablo (...)

using System;

class FactoresPrimos
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Dame un número:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n = n / i;
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("No es un número válido");
        }
    }
}

