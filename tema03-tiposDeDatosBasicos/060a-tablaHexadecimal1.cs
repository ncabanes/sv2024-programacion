/*
60. Crea una tabla de conversión de base 10 (decimal) a base 16 
(hexadecimal) para los números del 0 al 255, en 16 filas, cada una de 
las cuales tendrá 16 columnas, así:

000: 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F
016: 10 11 12 13 14 15 16 17 18 19 1A 1B 1C 1D 1E 1F
(...)
224: E0 E1 E2 E3 E4 E5 E6 E7 E8 E9 EA EB EC ED EE EF
240: F0 F1 F2 F3 F4 F5 F6 F7 F8 F9 FA FB FC FD FE FF
*/

// Pablo (...)

using System;
class MainClass
{
    static void Main()
    {
        for(int i = 0, j = 1; i <= 255; i++, j++)
        {
            if(i < 16)
            {
                Console.Write("0");
            }
            Console.Write("{0} ", Convert.ToString(i,16));

            if(j == 16)
            {
                Console.WriteLine("");
                j = 0 ;
            }
        }
        
    }
}
