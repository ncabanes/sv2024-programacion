/******************************************************************************
 *
 * César (...)
 * 1º DAW
 * Ejercicio 183

 183. Pide al usuario números reales de simple precisión, tantos como desee,
 hasta que pulse Intro en vez de un número. Cada nuevo número lo deberás
 guardar en una pila. Finalmente, mostrarás todos los datos que ha introducido
 (en orden inverso), así como su suma y su media (que deberás calcular en el
 momento de extraer datos, no en el de guardarlos). Puedes emplear una pila con
 tipo -Generics- o sin tipo, como prefieras (se compartirán ambas soluciones,
 para que puedas comparar).

 *****************************************************************************/

using System;
using System.Collections.Generic;

class PruebaPilaGenerics
{
    static void Main(string[] args)
    {
        Stack<float> pila = new Stack<float>();
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
                pila.Push(numero);
            }
        } while (!terminado);

        Console.WriteLine();
        cantidad = pila.Count;

        for (int i = 0; i < cantidad; i++)
        {
            numero = pila.Pop();
            Console.WriteLine(numero);
            suma += numero;
        }
        media = suma / cantidad;

        Console.WriteLine();
        Console.WriteLine("La suma es "+suma);
        Console.WriteLine("La media es "+media);
    }
}

