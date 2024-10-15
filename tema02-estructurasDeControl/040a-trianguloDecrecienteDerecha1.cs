/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

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

class TrianguloDecrecienteDerecha 
{
    static void Main() 
    {
        int tamanyo;
        
        Console.Write("Tamaño?: ");
        tamanyo = Convert.ToInt32( Console.ReadLine() );
        
        for (int alto = 1; alto <= tamanyo; alto++) 
        {
            for (int espacio = 1; espacio < alto; espacio++) 
            {
                Console.Write(" ");
            }
            
            for (int ancho = tamanyo; ancho >= alto; ancho--) 
            {
                Console.Write("X");
            }
            
            Console.WriteLine();
        }
    }
}
