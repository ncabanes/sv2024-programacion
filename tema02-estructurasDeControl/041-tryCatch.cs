// Isabel Maria (...)

/* 
41. 
Pide al usuario dos números enteros y muestra el cuadrado del primero, 
el cuadrado del segundo y el resultado de dividir el primero entre el segundo. 
Usa excepciones para comprobar los posibles errores.
*/

using System;

class Ejercicio41
{
    static void Main()
    {
        int num1, num2,cuadradoNum1, cuadradoNum2, resultado;
        
        try
        { 
            Console.WriteLine("Introduce un número");
            num1 = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("Introduce otro número");
            num2 = Convert.ToInt32(Console.ReadLine());
                
            cuadradoNum1 = num1 * num1;
            Console.WriteLine($"El cuadrado de {num1} es {cuadradoNum1}");
            
            cuadradoNum2 = num2 * num2;
            Console.WriteLine($"El cuadrado de {num2} es {cuadradoNum2}");
            
            resultado = num1 / num2;
            Console.WriteLine($"El resultado de dividir {num1} y {num2} es {resultado}");
        }
        
        catch (FormatException)
        {
            Console.WriteLine("No es un número válido");
        }
        
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir entre cero");
        }
    }
}
