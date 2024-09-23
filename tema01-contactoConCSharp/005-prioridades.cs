/*******************************************************************************
* 1º DAW
* Módulo: Programación
* Tema 1 - Ejercicio 5
* Autor: César (...)
* Descripción: Resultado de operación aritmética
*******************************************************************************/

using System;

class Operacion
{
    static void Main()
    {
        int a;
        a = (50-11/5+2*4)%7;

        Console.Write("El resultado de la operación (50-11/5+2*4)%7 es ");
        Console.WriteLine(a);
    }
}

/* La operación, al no tener paréntesis, se resuelve con la prioridad 
matemática de siempre: paréntesis, potencias, multiplicaciones, sumas:

(50-(11/5)+(2*4))%7

En la calculadora la división 11/5 da 2.2 pero como estamos trabajando 
con enteros toma el cociente que es 2 y lo aplica en la operación 
conjunta, como si fuera (50-2+8)%7

De ahí que el resto de 0
*/
