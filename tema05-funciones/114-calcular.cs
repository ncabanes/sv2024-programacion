/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 114. Calcular.
 * 
 * Crea un programa llamado "calcular", que reciba tres parámetros en la línea
 * de comandos (dos números enteros y un operador de entre éstos: +, -, *, /) y
 * muestre el resultado de la operación, como en este ejemplo:
 * 
 * calcular 5 * 3
 * 
 * 15
 * 
 * A pesar de que los datos sean enteros, la división se calculará con
 * decimales, de modo que otro ejemplo de ejecución podría ser:
 * 
 * calcular 15 / 2
 * 7,5 */

using System;

class Calcular {
    
    static void Main(string[] args) {
        
        if (args.Length != 3) {
            Console.WriteLine("Uso: calcular <número1> <operador> <número2>");
        } else {
            float numero1 = Convert.ToSingle(args[0]);
            float numero2 = Convert.ToSingle(args[2]);
            char operador = Convert.ToChar( args[1] );
        
            switch (operador) {
                case '+':
                    Console.WriteLine(numero1 + numero2);
                    break;
                    
                case '-':
                    Console.WriteLine(numero1 - numero2);
                    break;
                    
                case '*':
                    Console.WriteLine(numero1 * numero2);
                    break;
                
                case '/':
                    if (numero2 == 0) {
                        Console.Write("No se puede dividir entre 0.");
                    } else {
                        Console.WriteLine(numero1 / numero2);
                    }
                    break;
                
                default:
                    Console.WriteLine("Argumento desconocido.");
                    break;
            }
        }
    }
}
