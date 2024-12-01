/* 98. Crea una función booleana llamada "EsPalindromoPrimo", que devolverá 
"true" si el parámetro, un número entero largo, es un número primo que también 
es palíndromo, o "false" en caso contrario. En vez de que esta función tenga 
toda la carga lógica, apóyate en las funciones "EsPrimo" y "EsPalindromo" que 
has creado anteriormente. El "Main" de prueba deberá mostrar los números 
palíndromos primos que hay entre 500 y 1000. */

using System;

class Ejercicio98
{
    // Función EsPrimo, tomada del ejercicio 96
    static bool EsPrimo(long numero)
    {
        int divisores = 0;
        bool esPrimo = false;

        for (long i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }

        if (divisores == 2)
        {
            esPrimo = true;
        }

        return esPrimo;
    }
    
    // Función EsPalindromo, tomada del ejercicio 97
    static bool EsPalindromo(string texto)
    {
        string textoAlReves = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            char letra = texto[i];
            textoAlReves += letra;
        }
        
        if (texto == textoAlReves)
            return true;
        else
            return false;
    }
    
    // Y la nueva función, que se apoya en ambas
    static bool EsPalindromoPrimo(long numero)
    {
        if (EsPalindromo(Convert.ToString(numero)) && EsPrimo(numero))
            return true;
        
        // Siendo estructos, aquí no hace falta "else",
        // porque si llegamos hasta esta linea, 
        // es porque no se cumplía la condición anterior
        return false;
    }

    // Y el programa de prueba, claro
    static void Main()
    {
        const long MINIMO = 500, MAXIMO = 1000;
        

        Console.Write("Primos palíndromos entre "+MINIMO+" y "
            + MAXIMO +": ");
        for (long numero = MINIMO; numero <= MAXIMO; numero++)
        {
            if (EsPalindromoPrimo(numero))
            {
                Console.Write(numero + " ");
            }
        }
    }
}

