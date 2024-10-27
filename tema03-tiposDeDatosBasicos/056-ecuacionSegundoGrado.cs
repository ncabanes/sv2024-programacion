/* 
 * Crea un programa que calcule las soluciones ("raíces") de una
 *  ecuación de segundo grado Ax2 + Bx + C = 0 (si no recuerdas la
 *  fórmula, puedes verla en la Wikipedia)
 *  https://es.wikipedia.org/wiki/Ecuaci%C3%B3n_de_segundo_grado#
 * Soluciones_de_la_ecuaci%C3%B3n_de_segundo_grado Nota: para calcular
 *  la raíz cuadrada, puedes usar Math.Sqrt( x ), que veremos con
 *  más detalle la próxima semana.*/

using System;

class SegundoGrado
{
    static void Main()
    {
        int a, b, c;
        double x1, x2;

        Console.Write("Valor de a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Valor de b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Valor de c: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        double discriminante = b * b - 4 * a * c;

        if (discriminante < 0) // si la raíz es negativa, no hay solución
        {
            Console.WriteLine("no tiene solución");
        }
        else
        {
            x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            
            if (discriminante == 0 ) //si es igual a 0, sólo hay una solución
            {
                Console.WriteLine("x1 = x2 = {0}", x1.ToString("N2"));
            }
            else //si es mayor que 0, hay dos soluciones
            {
                Console.WriteLine("x1 = {0}", x1.ToString("N2"));
                Console.WriteLine("x2 = {0}", x2.ToString("N2"));
            }
        }
    }
}



