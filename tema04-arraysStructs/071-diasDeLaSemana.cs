/* Ejercicio 071. Array con días de la semana.
 * 
 * Crea un array que contenga los nombres de los días de la semana, indicando
 * los datos iniciales de dicho array entre llaves.
 * 
 * Muestra todos los días en pantalla, desde el primero (lunes) hasta el último
 * (domingo), en una misma línea y separando cada uno del siguiente con un
 * espacio en blanco, empleando "foreach".
 * 
 * En la siguiente línea, muéstralos en orden inverso (de domingo a lunes),
 * empleando "for".
 * 
 * Finalmente, pide al usuario un número de día (por ejemplo, el 3) y muestra su
 * nombre (el 3 sería "miércoles"). */

/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */


using System;

class DiasDeLaSemana {
    
    static void Main() {
        
        string[] datos = {"lunes", "martes", "miércoles", "jueves", "viernes", 
                            "sábado", "domingo"};
        
        // Orden directo, con "foreach"
        foreach (string dia in datos) {
            Console.Write(dia +" ");
        }
        Console.WriteLine();
        
        // Orden inverso, con "for"
        for (int i = 6; i >= 0; i--) {
            Console.Write(datos[i] +" ");
        }
        Console.WriteLine();
        
        // Búsqueda por posición
        Console.Write("Introduce nº de día: ");
        byte numDia = Convert.ToByte( Console.ReadLine() );
        Console.Write("El número de día " + numDia + " es " + datos[numDia - 1]);
    }
}
