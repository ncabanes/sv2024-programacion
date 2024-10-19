/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 049. Calendario.
 * 
 * Muestra un calendario, pidiendo al usuario la cantidad de días del mes (por
 * ejemplo, 31) y el número dentro de la semana que ocupa el primer día (por
 * ejemplo, 2 para el martes). El resultado debería ser algo como:
 * 
 *  L   M   X   J   V   S   D
 *      1   2   3   4   5   6
 *  7   8   9  10  11  12  13
 * 14  15  16  17  18  19  20
 * 21  22  23  24  25  26  27
 * 28  29  30  31 */

using System;

class Calendario {
    
    static void Main() {
        
        int diasMes, numeroDia, contadorDiaSemana = 1;
        
        Console.Write("Introduce días que tiene el mes: ");
        diasMes = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Introduce número de día donde inicia la semana: ");
        numeroDia = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine();
        Console.WriteLine("  L   M   X   J   V   S   D");
        
        for (int i = 1; i < numeroDia; i++) {
            Console.Write("    ");
        }
        
        contadorDiaSemana = numeroDia;
        
        for (int dia = 1; dia <= diasMes; dia++) {
            if (dia < 10) {
                Console.Write("  {0} ", dia);
            } 
            else {
                Console.Write(" {0} ", dia);
            }
            
            contadorDiaSemana++;
            
            if (contadorDiaSemana > 7) {
                Console.WriteLine();
                contadorDiaSemana = 1;
            }
        }
    }
}
