/*
Pide al usuario un texto formado por varios números
separados por espacios y muestra la suma de esos números.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        Console.Write("Dime varios números separados por espacios: ");
        string respuesta = Console.ReadLine();
        
        string[] numerosComoTexto = respuesta.Split();
        
        int suma = 0;
        foreach(string numero in numerosComoTexto)
        {
            suma += Convert.ToInt32(numero);
        }
        Console.WriteLine("La suma es " + suma);
    }
}

/*
Dime varios números separados por espacios: 2 3 4 5 6
La suma es 20
*/
