/* Ejercicio 080. Número entero positivo en forma binaria.
 * 
 * Crea un programa que pida al usuario un número entero positivo y muestre su
 * equivalente en forma binaria, usando un array como paso intermedio para
 * guardar los resultados temporales.
 * 
 * Supondremos que el número cabe en 8 bits (un byte).
 * 
 * El algoritmo es el siguiente: divide el número entre 2 tantas veces como sea
 * posible hasta que el número se convierta en uno, y toma todos los restos en
 * orden inverso:
 * 
 * 35: 2 = 17, resto 1
 * 17: 2 = 8, resto 1
 * 8: 2 = 4, resto 0
 * 4: 2 = 2, resto 0
 * 2: 2 = 1, resto 0
 * 1, terminado
 * 
 * por lo que el número sería 00100011 (o 100011, sin los 0 iniciales).
 * 
 * Puedes usar ".ToString" para verificar que tu algoritmo funciona bien, pero
 * no como único método de resolución. */

// Versión 2: permite números de hasta 32 bits, mide la cantidad
// de dígitos binarios

/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

using System;

class EnteroABinario {
    
    static void Main() {
        
        int numero, numeroInicial, numeroDividido, contador = 0;
        
        Console.Write("Introduce un número: ");
        numero = Convert.ToInt32( Console.ReadLine() );
        
        numeroInicial = numero;
        numeroDividido = numero;
        
        while (numeroDividido > 0) {
            numeroDividido /= 2;
            contador++;
        }
        
        int[] datos = new int [contador];
        
        for (int i = 0; i < contador; i++) {
            datos[i] = numero % 2;
            numero /= 2;
        }
        
        Console.Write("Conversión a Binario: ");
        for (int i = contador - 1; i >= 0; i--) {
            Console.Write(datos[i]);
        }
        
        Console.WriteLine();
        Console.WriteLine("Verificación " + "\"To.String\": " 
                        + Convert.ToString(numeroInicial, 2) );
        
    }
    
}
