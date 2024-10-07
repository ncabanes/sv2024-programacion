/*
22. Crea un programa en C# que pida al usuario un número y asigne a una 
variable "multiploDe5yDe7" el valor 1 si es múltiplo de 5 y a la vez de 7, o el 
valor 0 en caso contrario. Hazlo dos veces: primero con "if" y luego con el 
operador ternario. Al igual que en el ejercicio anterior, todo deberá ser parte 
de un único programa, que pida el dato una única vez y muestre dos respuestas.
*/

//Eliseo (...)

using System;

class Ejercicio22
{
    static void Main()
    {
        int numero, multiploDe5yDe7;
        
        Console.WriteLine("Introduce un numero: ");
        numero = Convert.ToInt32(Console.ReadLine() );
        
        if (numero % 5 == 0 && numero % 7 == 0)
        {
            multiploDe5yDe7 = 1;
        }
        else
        {
            multiploDe5yDe7 = 0;
        }
        Console.WriteLine("El numero es: " + multiploDe5yDe7);
        
        multiploDe5yDe7 = (numero % 5 == 0 && numero % 7 == 0) ? 1 : 0;
        Console.WriteLine("El numero es: " + multiploDe5yDe7);
    }
}
