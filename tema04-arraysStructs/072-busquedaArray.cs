/*
72. Pide al usuario 8 enteros largos sin signo y guárdalos en un array. Luego 
pide uno más y dile si estaba entre esos 8 datos iniciales, de 2 formas 
distintas: primero usando un booleano y luego usando un contador, para, en la 
segunda ocasión, responderle cuántas veces aparecía (ambas respuestas serán 
parte del mismo programa, no dos programas independientes).
*/

// Francisco (...), retoques por Nacho

using System;

class Ejercicio72
{
    static void Main()
    {
        const int TAMANYO = 8;
        ulong[] numeros = new ulong [TAMANYO];
        bool encontrado;
        int cantidad;
        
        // ----------------
        
        for (ulong i = 0; i < TAMANYO; i++)
        {
            Console.Write("Introduce el número {0}: ",i+1);
            numeros[i] = Convert.ToUInt64(Console.ReadLine());
        }
        
        Console.Write("Introduce un número para buscar: ");
        ulong busqueda = Convert.ToUInt64(Console.ReadLine());
        
        // ----------------
        
        encontrado = false;
        foreach (double i in numeros)
        {
            if ( i == busqueda )
                encontrado = true;
        }
        
        if (encontrado)
            Console.WriteLine(">Bool: Número encontrado.");
        else
            Console.WriteLine(">Bool: Número no encontrado.");
        
        Console.WriteLine();
        
        // ----------------
        
        cantidad = 0;
        foreach (ulong n in numeros)
        {
            if (n == busqueda)
                cantidad++;
        }
        
        if (cantidad > 0)
        {
            Console.WriteLine(">Contador: Número encontrado.");
            Console.WriteLine(">Contador: Se ha encontrado {0} veces.", cantidad);
        }
        else
            Console.WriteLine(">Contador: No se ha encontrado.");
    }
}
