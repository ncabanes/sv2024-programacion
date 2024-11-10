// 80. Crea un programa que pida al usuario un número entero positivo y
// muestre su equivalente en forma binaria, usando un array como paso intermedio
// para guardar los resultados temporales. Supondremos que el número cabe en 8 bits (un byte).

// Versión 1: tal y como se pedía

// Pablo (...)

using System;

class DecimalABinario
{
    static void Main()
    {
        byte[] numeroBinario = new byte[8];
        Console.WriteLine("Dime un número y lo convertiré en binario: ");
        byte num = Convert.ToByte(Console.ReadLine());
        
        for(int i = 0; i < numeroBinario.Length; i++)
        {
            numeroBinario[i] = (byte)(num % 2);
            num = (byte)(num / 2);
;
        }
        
        for(int i = numeroBinario.Length - 1; i >= 0; i--)
        {
            Console.Write(numeroBinario[i]);
        }
    }
}
