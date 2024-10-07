/*
21. Pide al usuario un número, que guardarás en una variable "n". Dale a una 
variable llamada "esPar" el valor 1 si "n" es par, o un valor 0 si "n" es 
impar. Hazlo de dos formas: primero con "if" y luego con el operador ternario. 
Ambas comprobaciones serán parte del mismo programa, que pedirá el dato "n" una 
única vez y mostrará dos veces el valor de la variable "esPar" (una vez con 
"if" y otra vez con el "operador ternario").

Autor: Francisco (...)
*/

using System;

class Ejercicio21 
{
    static void Main()
    {
        int n;
        int esPar;

        n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            esPar = 1;
        }
        else
        {
            esPar = 0;
        }
        Console.WriteLine("Resultado del if-else: esPar = {0}", esPar);

        esPar = n % 2 == 0 ? 1 : 0;
        Console.WriteLine("Resultado del ternario: esPar = {0}", esPar);
    }
}
