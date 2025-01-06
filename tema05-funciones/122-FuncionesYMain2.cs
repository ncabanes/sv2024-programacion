/*

122. Crea una versión mejorada del "Main" del ejercicio anterior, con los 
siguientes cambios:

Si no se usan parámetros, o si se especifica un primer parámetro incorrecto, se 
mostrará "Uso: primoc / mm / centrar / mcd" y regresará al sistema operativo 
con el código de error 1. Por otra parte, si se usan menos parámetros de los 
esperados (es decir, : "primoc" y ningún número, "mcd" y menos de dos números, 
y así sucesivamente), mostrará "Faltan parámetros" y regresará al sistema 
operativo con el código de error 2. Si todo es correcto, regresará al sistema 
operativo con código de error 0.

*/

using System;

class Ejercicio122
{
    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Uso: primoc / mm / centrar / mcd");
            return 1;
        }
        else
        {
            switch(args[0].ToLower())
            {
                case "primoc":
                    if(args.Length >= 2)
                    {
                        int num = Convert.ToInt32(args[1]);
                        if (EsPrimoCircular(num))
                        {
                            Console.Write(num + " es primo circular");
                        }
                        else
                        {
                            Console.Write(num + " no es primo circular");
                        }
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Faltan parámetros");
                        return 2;
                    }
                    
                case "mcd":
                    if(args.Length >= 3)
                    {
                        int num1 = Convert.ToInt32(args[1]);
                        int num2 = Convert.ToInt32(args[2]);
                        Console.WriteLine("Mcd: " + Mcd(num1, num2));
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Faltan parámetros");
                        return 2;
                    }
               case "mm":
                    if(args.Length >= 2)
                    {
                        int mays = 0, mins = 0;
                        ContarMm(args[1], ref mays, ref mins);
                        Console.WriteLine
                            ("Mayúsculas: " + mays + ", minúsculas: " + mins);
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Faltan parámetros");
                        return 2;
                    }
               case "centrar":
                    if(args.Length >= 2)
                    {
                        EscribirCentradoYSubrayado(args[1]);
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Faltan parámetros");
                        return 2;
                    }
            }
            Console.WriteLine("Uso: primoc / mm / centrar / mcd");
            return 1;
        }
    }

    static long Mcd(long a, long b)
    {
        if (b == 0)
        {
            return a;
        }

        return Mcd(b, a % b);
    }


    static void ContarMm(string texto, ref int mays, ref int mins)
    {
        mins = 0;
        mays = 0;

        for (int i = 0; i < texto.Length; i++)
        {
            if ((texto[i] >= 'a') && (texto[i] <= 'z'))
            {
                mins++;
            }
            if ((texto[i] >= 'A') && (texto[i] <= 'Z'))
            {
                mays++;
            }
        }
    }


    static void EscribirCentradoYSubrayado(string texto)
    {
        for (int i = 0; i < (80-texto.Length)/2; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(texto);
        
        for (int i = 0; i < (80-texto.Length)/2; i++)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < texto.Length; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }


    static bool EsPrimo(long numero)
    {
        int divisores = 0;
        bool esPrimo = false;
        for (long i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            esPrimo = true;
        }

        return esPrimo;
    }


    static bool EsPrimoCircular(long numero)
    {
        int contadorPrimos = 0;
        
        string numeroComoCadena = Convert.ToString(numero);
        for (int i = 0; i < numeroComoCadena.Length; i++)
        {
            // Colocamos la última cifra al principio
            numeroComoCadena = numeroComoCadena[numeroComoCadena.Length - 1] +
                numeroComoCadena.Substring(0, numeroComoCadena.Length - 1);
            // Y vemos si el resultado es primo
            if (EsPrimo(Convert.ToInt64(numeroComoCadena)))
            {
                contadorPrimos++;
            }
        }
        return contadorPrimos == numeroComoCadena.Length;
    }
}
