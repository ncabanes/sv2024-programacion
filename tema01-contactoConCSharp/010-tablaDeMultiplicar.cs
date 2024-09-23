// Tabla de multiplicar (sin bucles)
// Francisco (...)

using System;

class Ejercicio10 
{
    static void Main() 
    {
        Console.Write("Introduce un número: ");
        int num = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine();
        Console.WriteLine("Tabla de Multiplicar de {0}", num);
        Console.WriteLine("---------------------------");
        Console.WriteLine("{0} x 0 = {1}", num, 0*num);
        Console.WriteLine("{0} x 1 = {1}", num, 1*num);
        Console.WriteLine("{0} x 2 = {1}", num, 2*num);
        Console.WriteLine("{0} x 3 = {1}", num, 3*num);
        Console.WriteLine("{0} x 4 = {1}", num, 4*num);
        Console.WriteLine("{0} x 5 = {1}", num, 5*num);
        Console.WriteLine("{0} x 6 = {1}", num, 6*num);
        Console.WriteLine("{0} x 7 = {1}", num, 7*num);
        Console.WriteLine("{0} x 8 = {1}", num, 8*num);
        Console.WriteLine("{0} x 9 = {1}", num, 9*num);
        Console.WriteLine("{0} x 10 = {1}", num, 10*num);
    }
}
