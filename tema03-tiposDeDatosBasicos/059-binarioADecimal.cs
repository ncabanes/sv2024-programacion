/*
59. Pide al usuario un número binario (por ejemplo 1101) y muestra su 
equivalente en base 10. Debes hacerlo de la siguiente forma:  leerás un 
número entero largo n, e irás extrayendo cada vez su última cifra (con 
"cifra = n % 10") y eliminando esa cifra (con "n = n / 10"); si esa 
cifra es 1, deberás sumar la correspondiente potencia de 2 (que será 1 
para la primera cifra que elimines, luego 2 para la siguiente, después 
4, a continuación 8, luego 16 y así sucesivamente). Finalmente, muestra 
el equivalente en binario de ese número que has obtenido, pero esta vez 
usando "Convert.ToString(n, 2)" (si todo ha ido bien, debería coincidir 
con el dato original).
*/

// Francisco (...), retoques menores por Nacho

using System;

class Ejercicio59
{
    static void Main()
    {
        long binario;                  // Variables recogidas de la consola
        
        long cifra = 0, resultado = 0;  // Variables calculadas
        long potenciaDeDos = 1;

        Console.Write("Introduce un número binario: ");
        binario = Convert.ToInt64(Console.ReadLine());

        while (binario > 0)
        {
            cifra = binario % 10;
            resultado += potenciaDeDos * cifra;

            binario /= 10;
            potenciaDeDos *= 2;
        }

        Console.WriteLine("La cifra en base 10 es: {0}", resultado);
        Console.WriteLine("En binario es: {0}", 
            Convert.ToString(resultado, 2));
    }
}
