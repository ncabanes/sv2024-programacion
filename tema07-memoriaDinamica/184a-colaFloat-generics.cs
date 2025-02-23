
/******************************************************************************
 *
 * César (...)
 * 1º DAW
 * Ejercicio 184

184. Haz una variante del ejercicio anterior, en la que los datos no se
introduzcan en una pila, sino en una cola, de modo que se obtendrán en el mismo
orden en que se introdujeron. Nuevamente, puedes usar una cola con tipo o sin
tipo (se compartirán las dos soluciones).

 *****************************************************************************/

using System;
using System.Collections.Generic;

class PruebaColaGeneric
{
    static void Main(string[] args)
    {
        Queue<float> cola = new Queue<float>();
        bool terminado = false;
        String respuesta = "";
        float numero = 0;
        int cantidad = 0;
        float suma = 0;
        float media = 0;

        do
        {
            Console.Write("Escribe un número: ");
            respuesta = Console.ReadLine();

            if (respuesta == "")
            {
                terminado = true;
                Console.WriteLine("Hasta pronto!");
            }
            else
            {
                numero = Convert.ToSingle(respuesta);
                cola.Enqueue(numero);
            }
        } while (!terminado);

        Console.WriteLine();
        cantidad = cola.Count;

        for (int i = 0; i < cantidad; i++)
        {
            numero = cola.Dequeue();
            Console.WriteLine(numero);
            suma += numero;
        }
        media = suma / cantidad;

        Console.WriteLine();
        Console.WriteLine("La suma es "+suma);
        Console.WriteLine("La media es "+media);
    }
}

