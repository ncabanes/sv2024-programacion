/*
25. Crea un programa que muestre los números del 100 al 125, cada uno en una 
línea, usando "while".

Liberto (...)
*/

using System;

class Ejercicio25 {
    static void Main() {

        int n = 100;

        while( n <= 125 )
        {
            Console.WriteLine(n);
            n = n+1;
        }
    }
}
