/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 019. Sistema de notas americano.
 * 
 * En el sistema de notas norteamericano se usan letras como A, B, C o F para
 * expresar si el resultado de un examen es bueno o no.
 * 
 * Suponiendo la equivalencia 10=A+, 9=A, 8=A-, 7=B+, 6=B, 5=C, suspenso=F,
 * crea un programa que te pida la nota numérica y responda escribiendo la
 * calificación americana correspondiente.
 * 
 * Por ejemplo, para una nota 8, tu programa escribirá A-.
 * 
 * Hazlo dos veces como parte de un único programa, primero con "if" y luego
 * con "switch".
 * 
 * Pedirás al usuario la nota sólo una vez y le darás dos repuestas (la que
 * obtengas con "if" y la que obtengas con "switch", que deberían coincidir). */

using System;

class SistemaNotasAmericano {
    
    static void Main() {
        
        int nota;
        
        Console.Write("Introduce nota: ");
        nota = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine();
        
        // Usando condición "if".
        
        Console.WriteLine("Usando condición if ... ");
        
        if (nota == 10) {
            Console.WriteLine("La nota numérica {0} equivale a: A+.", nota);
        } else if (nota == 9) {
            Console.WriteLine("La nota numérica {0} equivale a: A.", nota);
        } else if (nota == 8) {
            Console.WriteLine("La nota numérica {0} equivale a: A-.", nota);
        } else if (nota == 7) {
            Console.WriteLine("La nota numérica {0} equivale a: B+.", nota);
        } else if (nota == 6) {
            Console.WriteLine("La nota numérica {0} equivale a: B.", nota);
        } else if (nota == 5) {
            Console.WriteLine("La nota numérica {0} equivale a: C.", nota);
        } else if ( (nota <= 4) && (nota >= 0) ) {
            Console.WriteLine("La nota numérica {0} equivale a: F.", nota);
        } else {
            Console.WriteLine("Error al introducir nota.");
        }
        
        Console.WriteLine();
        
        // Usando condición "switch".
        
        Console.WriteLine("Usando condición switch ... ");
        
        switch (nota) {
            case 10:
                Console.WriteLine("La nota numérica {0} equivale a: A+.", nota);
                break;
            case 9:
                Console.WriteLine("La nota numérica {0} equivale a: A.", nota);
                break;
            case 8:
                Console.WriteLine("La nota numérica {0} equivale a: A-.", nota);
                break;
            case 7:
                Console.WriteLine("La nota numérica {0} equivale a: B+.", nota);
                break;
            case 6:
                Console.WriteLine("La nota numérica {0} equivale a: B.", nota);
                break;
            case 5:
                Console.WriteLine("La nota numérica {0} equivale a: C.", nota);
                break;
            case 4:
            case 3:
            case 2:
            case 1:
            case 0:
                Console.WriteLine("La nota numérica {0} equivale a: F", nota);
                break;
            default:
                Console.WriteLine("Error al introducir nota.");
                break;
        }
    }
}
