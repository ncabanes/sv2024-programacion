// Crea una función que compruebe si una cadena
// que introduce el usuario parece un número
// real válido, usando expresiones regulares.

using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool EsReal(string s)
    {
        Regex r = new Regex(@"\A[0-9]*\.[0-9]+\z");
        return r.IsMatch(s);
    }

    // \A[a-z][a-z0-9]*@[a-z0-9]+\.[a-z]+\z

    static void Main()
    {
        Console.WriteLine(EsReal("12.34"));
        Console.WriteLine(EsReal("1.56789"));
        Console.WriteLine(EsReal(".5"));

        Console.WriteLine(EsReal("12"));
        Console.WriteLine(EsReal("12.5a"));
        Console.WriteLine(EsReal("a"));
        Console.WriteLine(EsReal("12a"));
    }
}
