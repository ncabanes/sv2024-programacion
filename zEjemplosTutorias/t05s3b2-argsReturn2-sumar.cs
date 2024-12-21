/*
Crea una versión actualizada de "sumar", que reciba dos números 
enteros en línea de comandos y devuelva el código:

0 si todo ha ido bien
1 si faltan parámetros
2 si algún dato no es numérico

*/

using System;

class Ejemplo
{
    static int Main(string[] args)
    {
        int codigoError = 0;

        if (args.Length != 2)
        {
            Console.WriteLine("Indica dos números a sumar");
            codigoError = 1;
        }
        else
        {
            try
            {
                int n1 = Convert.ToInt32(args[0]);
                int n2 = Convert.ToInt32(args[1]);
                Console.WriteLine(n1 + n2);
            }
            catch(FormatException) 
            {
                Console.WriteLine("Los datos deben ser numéricos");
                codigoError = 2;
            }
        }

        return codigoError;
    }
}

