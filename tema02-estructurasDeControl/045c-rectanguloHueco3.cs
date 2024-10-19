/* --------------------
 * MARTA ORTIZ GONZÁLEZ
 * --------------------
 * 
 * Muestra un rectángulo hueco, con el ancho y el alto que elija el 
 * usuario, y usando como símbolo el número que escoja el usuario.
 * 
 */ 

using System;

class Ejercicio45
{
    static void Main()
    {
        int ancho;
        int alto;
        int n;
        
        Console.WriteLine("Dime el ancho del rectángulo:");
        ancho = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("Dime el alto del rectángulo:");
        alto = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("Dime un número:");
        n = Convert.ToInt32( Console.ReadLine() );
        
        //Primera fila
        for(int columna = 1; columna <= ancho; columna++)
        {
            Console.Write(n);
        }
        Console.WriteLine();
        
        //Filas intermedias
        for(int fila = 2; fila < alto; fila++)
        {
            Console.Write(n);
            for(int columna = 2; columna <= ancho-1; columna++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(n);
        }
        
        //Última fila si el alto es mayor que 1
        if(alto > 1)
        {
            for(int columna = 1; columna <= ancho; columna++)
            {
                Console.Write(n);
            }
        }
    }
}

