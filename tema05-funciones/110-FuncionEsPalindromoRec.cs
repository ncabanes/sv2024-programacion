/* 110. Crea una función recursiva EsPalindromo, como alternativa a la que 
hiciste en el ejercicio 97, que devolverá "true" si la cadena de caracteres 
indicada como parámetro es simétrica (un palíndromo). Pista: como caso base, 
una cadena de 1 letra o menos será palíndroma siempre; para una cadena de mayor 
longitud, se puede mirar si coinciden los dos caracteres de los extremos y 
descartarlos en caso de que sea así. */

using System;

class Ejercicio110
{
    static bool EsPalindromo(string palabra)
    {
        if (palabra.Length <= 1)
            return true;

        else if (palabra[0] == palabra[palabra.Length - 1])
            return EsPalindromo(palabra.Substring(1, palabra.Length - 2));

        else
            return false;
    }
    
    static void Main()
    {
        Console.Write("Dime una palabra: ");
        string palabra = Console.ReadLine();

        Console.WriteLine("Palindromo: {0}", EsPalindromo(palabra));
    }
}
