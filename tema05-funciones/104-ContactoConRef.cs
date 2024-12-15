/*
104. Crea tres versiones de una función para triplicar números (hallar su 
triple, el resultado de multiplicarlo por tres) y prueba todas ellas desde un 
único Main:

- La primera será una función entera llamada "Triplicar1", que devolverá 
triplicado el valor del número entero pasado como parámetro, usando "return" 
(por ejemplo, si el parámetro es 6, se devolverá 18).

- La segunda será un procedimiento (función "void") llamado "Triplicar2", que 
triplicará el valor del número entero pasado como parámetro (por ejemplo, si el 
parámetro es 5, se convertirá en 15), sin usar "ref"/"out" ni "return". Tras 
llamar a la función, comprueba si ha cambiado el valor de la variable que has 
pasado como parámetro.

- La tercera será un procedimiento llamado "Triplicar3", que triplicará el 
valor de un número entero que se le pasará como parámetro ref (por ejemplo, si 
el parámetro es 4, se convertirá en 12). Tras llamar a la función, comprueba si 
ha cambiado el valor de la variable que has pasado como parámetro.
*/

using System;

class Ejercicio104
{
    static int Triplicar1 (int n)
    {
        int resultado = n * 3;
        return resultado;
    }

    static void Triplicar2 (int n)
    {
         n = n * 3;
    }

    static void Triplicar3 (ref int n)
    {
         n = n * 3;
    }

    static void Main()
    {
        Console.Write("Escribe un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El número triplicado es {0}" , Triplicar1(numero));

        Triplicar2(numero);
        Console.WriteLine("Tras el segundo intento se convierte en {0}" , numero);

        Triplicar3(ref numero);
        Console.WriteLine("Y tras el tercero se convierte en:{0}" , numero);
    }
}

