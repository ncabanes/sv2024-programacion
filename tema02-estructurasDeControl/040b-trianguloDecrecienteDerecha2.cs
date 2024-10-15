/* Ejercicio 040. Triángulo decreciente alineado a la derecha.
 * 
 * Muestra un triángulo decreciente, formado por letras X, alineado a la
 * derecha, con el tamaño indicado por el usuario, usando "for":
 * 
 * Tamaño? 5
 * 
 * XXXXX
 *  XXXX
 *   XXX
 *    XX
 *     X */

using System;

class TrianguloDecrecienteDerecha2
{
    static void Main() 
    {
        int tamanyo, espacios, simbolos;
        
        Console.Write("Tamaño? ");
        tamanyo = Convert.ToInt32( Console.ReadLine() );
        
        espacios = 0;
        simbolos = tamanyo;
        
        for (int fila = 1; fila <= tamanyo; fila++) 
        {
            for (int i = 1; i <= espacios; i++) 
            {
                Console.Write(" ");
            }
            
            for (int i = 1; i <= simbolos; i++) 
            {
                Console.Write("X");
            }
            
            Console.WriteLine();
            
            espacios++;
            simbolos--;
        }
    }
}
