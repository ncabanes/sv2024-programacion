/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 123. Función "EscribirCentradoYSubrayado" modificado.
 * 
 * Crea una nueva versión de la función EscribirCentradoYSubrayado
 * (ejercicio 117), en la que también se pueda indicar, opcionalmente, un
 * símbolo distinto de los guiones para subrayar.
 * 
 * Crea un Main que te permita probar la función de tres formas distintas:
 * 
 * con dos parámetros en su orden normal,
 * con un solo parámetro,
 * y con dos parámetros en orden invertido. */

using System;

class FuncionEscribirCentradoYSubrayadoModificado {
    
    static void EscribirCentradoYSubrayado(string frase, char simbolo = '-') {
        
        int anchoPantalla = 80;
        
        int inicioEscritura = (anchoPantalla - frase.Length) / 2;
        
        string espacios = new string(' ', inicioEscritura);
        string subrayado = new string(simbolo, frase.Length);
        
        Console.WriteLine(espacios + frase);
        Console.WriteLine(espacios + subrayado);
        
    }
    
    static void Main() {
        
        Console.Write("Introduce cadena: ");
        string cadena1 = Console.ReadLine();
        Console.Write("Introduce símbolo: ");
        char simbolo1 = Convert.ToChar( Console.ReadLine() );
        EscribirCentradoYSubrayado(cadena1, simbolo1);
        
        Console.Write("Introduce otra cadena: ");
        string cadena2 = Console.ReadLine();
        EscribirCentradoYSubrayado(cadena2);
        
        Console.Write("Introduce tercera cadena: ");
        string cadena3 = Console.ReadLine();
        Console.Write("Introduce otro símbolo: ");
        char simbolo3 = Convert.ToChar( Console.ReadLine() );
        EscribirCentradoYSubrayado(simbolo: simbolo3, frase: cadena3);
    }
    
}
