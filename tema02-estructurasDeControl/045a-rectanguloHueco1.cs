/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 045. Rectángulo hueco.
 * 
 * Muestra un rectángulo hueco, con el ancho y el alto que elija el usuario, y
 * usando como símbolo el número que escoja el usuario, como en este ejemplo:
 * 
 * Ancho? 5
 * Alto? 3
 * Número? 1
 * 
 * 11111
 * 1   1
 * 11111 */

using System;

class TrianguloHueco {
    
    static void Main() {
        
        int alto, ancho, numero;
        
        Console.Write("Alto: ");
        alto = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Ancho: ");
        ancho = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Número (del 0 al 9): ");
        numero = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine();
        
        for (int i = 1; i <= alto; i++) {
            for (int j = 1; j <= ancho; j++) {
                if ( (i == 1) || (i == alto) || (j == 1) || (j == ancho) ) {
                    Console.Write(numero);
                } else {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
