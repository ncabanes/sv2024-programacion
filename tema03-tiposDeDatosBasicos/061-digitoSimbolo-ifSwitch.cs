// Juan Carlos (...) 28/X/2024

/* 61. Crea un programa que pida al usuario que introduzca un símbolo y 
responda si se trata de un dígito (0 al 9), un operador (+ - * / %) o algún 
otro símbolo. Debes emplear el tipo de datos "char" y hacerlo de dos formas 
distintas (en un mismo programa, que pedirá datos sólo una vez y mostrará dos 
resultados): primero usando "if" y después empleando "switch". */

using System;

class Ejercicio61
{
    static void Main()
    {
        // Introducción de datos por parte usuario
        Console.Write("Introduce un símbolo: ");
        char simbolo = Convert.ToChar(Console.ReadLine());

        // Comprobaciones y resultados impresos
        if (simbolo >= '0' && simbolo <= '9')
        {
            Console.WriteLine("Se trata de un dígito.");
        }
        else if (simbolo == '+' || simbolo == '-' || simbolo == '*' 
            || simbolo == '/' || simbolo == '%')
        {
            Console.WriteLine("Es un operador.");
        }
        else
        {
            Console.WriteLine("Es otro símbolo.");
        }

        // Con switch
        switch (simbolo)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': 
                Console.WriteLine("Se trata de un dígito."); 
                break;
            case '-':
            case '+':
            case '*':
            case '/':
            case '%':
                Console.WriteLine("Es un operador."); 
                break;
            default: 
                Console.WriteLine("Es otro símbolo."); 
                break;
        }
    }
}
