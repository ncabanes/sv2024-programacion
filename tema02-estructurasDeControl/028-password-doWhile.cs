/* Sara (...)
 * 
 * Crea una nueva versión del ejercicio 24: un programa en C# que 
 * pida al usuario una contraseña numérica. Se le dirá "Acceso
 * concedido" cuando acierte la contraseña correcta, 1234. Si no
 * la acierta, se le volverá a pedir tantas veces como sea necesario.
 * En esta ocasión, hazlo utilizando "do-while".*/



using System;

class Contrasena
{
    static void Main()
    {
        int n;
        
        do
        {
            Console.WriteLine("Introduce una contraseña numérica de 4 dígitos");
            n=Convert.ToInt32(Console.ReadLine());
            
            if(n != 1234)
            {
                Console.WriteLine("Contraseña incorrecta.");
            }
        }        
        while(n != 1234);
        
        Console.WriteLine("Acceso concedido");
    }
}
