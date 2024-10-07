/* Jorge (...)
 
 Ejercicio 24 - Escribe un programa en C# que pida al usuario una 
 contraseña numérica. Se le dirá "Acceso concedido" cuando acierte la 
 contraseña correcta, que será "1234". Si no la acierta, se le volverá 
 a pedir tantas veces como sea necesario. Hazlo empleando "while".*/
 
using System;
 
class Ejercicio_24
{
    static void Main()
    {
        int pass, passCorrecta = 1234;
        
        Console.Write("Escribe la contraseña (numérica): ");
        pass=Convert.ToInt32(Console.ReadLine());
        
        while(pass!=passCorrecta)
        {
            Console.Write("Contraseña incorrecta, vuelva a introducir contraseña: ");
            pass=Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Acceso concedido");
    }
}
