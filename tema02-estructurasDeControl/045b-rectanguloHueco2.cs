// Adrián (...)
// Rectangulo formado por unos

using System;
class Ejercicio
{
    static void Main()
    {
        
        try
        {            
            Console.Write("Alto: ");
            int alto = Convert.ToInt32( Console.ReadLine() );
            
            Console.Write("Ancho: ");
            int ancho = Convert.ToInt32( Console.ReadLine() );
            
            Console.Write("Número (del 0 al 9): ");
            int numero = Convert.ToInt32( Console.ReadLine() );          

            for(int i = 1; i <= alto; i++)
            {
                if(i == 1 || i == alto)
                {
                    for (int j = 0; j <= ancho; j++)
                    {
                        Console.Write(numero);
                    }
                    Console.Write("\n");                    
                }
                else
                {
                    for (int j = 0; j <= ancho; j++)
                    {
                        if(j == 0 || j == ancho)
                        {
                            Console.Write(numero);
                        }
                        else
                        {
                            Console.Write(" ");
                        }                        
                    }
                    Console.Write("\n");
                }
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("El valor introducido no ha sido un número");
        }
    }
}
