/*
Crea un programa que le pida al usuario dos números (reales de doble precisión) 
y una operación para realizar en ellos (+, -, *, /) y muestre el resultado de esa operación, como en este ejemplo:

Introduzca el primer número: 8
Introduzca la operación: +
Introduzca el segundo número: 7
8 + 7 = 15
*/

// Kevin (...)

using System;

class Ejercicio63
{
    static void Main()
    {
        Console.WriteLine("Escribe el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe la operación (+, -, *, /):");
        char operacion = Convert.ToChar( Console.ReadLine() );

        Console.WriteLine("Escribe el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;
        bool operacionValida = true;

        switch (operacion)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Esta división no es válida.");
                    operacionValida = false;
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                operacionValida = false;
                break;
        }

        if (operacionValida)
        {
            Console.WriteLine($"{num1} {operacion} {num2} = {resultado}");
        }
    }
}
