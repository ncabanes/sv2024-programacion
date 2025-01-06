/* Nombre: Andrés (...), retoques menores por Nacho
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 115. Calcular mejorado.
 * 
 * Crea una versión mejorada del programa "calcular", que también permita
 * calcular potencias (con el símbolo E), que devuelva al sistema operativo el
 * código de error 0 si todo ha sido correcto, el código 1 si se ha indicado un
 * operador no válido o el código 2 si alguno de los números no era válido,
 * además de mostrar en consola un mensaje de aviso adecuado:
 * 
 * calcular 2 E 3
 * 8
 * 
 * calcular 2 ** 3
 * Operador desconocido
 * 
 * calcular 3 + Hola
 * Número no válido */

using System;

class CalcularMejorado {
    
    static int Main(string[] args) {
        
        float numero1, numero2;
        
        try {
            numero1 = Convert.ToSingle( args[0] );
            numero2 = Convert.ToSingle( args[2] );
            
        } catch (Exception mensaje) {
            Console.WriteLine("Error: " + mensaje.Message);
            return 2;
        }
        
        string operador = Convert.ToString( args[1] );
        
        switch (operador) {
            case "+":
                Console.WriteLine(numero1 + numero2);
                break;
                
            case "-":
                Console.WriteLine(numero1 - numero2);
                break;
                
            case "*":
                Console.WriteLine(numero1 * numero2);
                break;
            
            case "/":
                if (numero2 == 0) {
                    Console.Write("No se puede dividir entre 0.");
                } else {
                    Console.WriteLine(numero1 / numero2);
                }
                break;
                
            case "E":
                float potencia = 1;
                for (int i = 0; i < numero2; i++) {
                    potencia *= numero1;
                }
                Console.Write(potencia);
                break;
            
            default:
                Console.WriteLine("Operador desconocido.");
                return 1;
        }
        return 0;
    }
}
