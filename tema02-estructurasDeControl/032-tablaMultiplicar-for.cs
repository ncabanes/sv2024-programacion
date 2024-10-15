// 32. Pide al usuario un número del 0 al 10 y muestra su tabla de multiplicar,
// usando "for". Si introduce un número no válido, deberás mostrar un mensaje de aviso.

// Pablo (...)

using System;

class TablaMultiplicar
{
    static void Main()
    {
        Console.WriteLine("Dame un número del 0 al 10 y te diré su tabla de multiplicar:");
        int num = Convert.ToInt32(Console.ReadLine());
        
        if(num < 0 || num > 10)
        {
            Console.WriteLine("Número introducido no válido, debe ser entre el 0 y el 10");
        }
        else
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
        }
    }
}
