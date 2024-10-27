// Adrián (...), retoques menores por Nacho
// Aproximación PI

/*
58. Haz un programa que calcule una aproximación para PI, usando la 
expresión pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ...  El 
usuario indicará cuántos términos se deben usar (por ejemplo, si 
responde que 2, tu programa calcularía 1/1 - 1/3, que tendrá como 
resultado algo cercano a 0.666666, luego el valor de PI sería 4 * 
0.666666 = 2.666666). Nota 1: debes usar el tipo de datos "double".  
Nota 2: Este método se llama "fórmula de Leibniz": 
https://es.wikipedia.org/wiki/Serie_de_Leibniz
*/

using System;

class AproxPi
{
    static void Main(string[] args)
    {
        Console.Write("Indica cuántos términos de PI quieres para la aproximación: ");
        int terminos = Convert.ToInt32(Console.ReadLine());
        double pi = 0;
        double fraccion;
        double signo = 1;
        double divisor = 1;
        for (double i = 1; i <= terminos; i ++)
        {
            fraccion = 1 / divisor;
            fraccion *= signo;
            pi += fraccion;
            
            signo *= -1;
            divisor += 2;
        }
        Console.WriteLine("La aproximación de PI con {0} términos es de {1}", 
            terminos, pi * 4);
    }
}
