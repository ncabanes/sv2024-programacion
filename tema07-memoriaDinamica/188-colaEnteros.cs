/*
 Crea una clase "ColaDeEnteros", que internamente utilice una "List<int>".
 Debe permitir encolar (usando un método "Enqueue") números enteros, desencolarlos 
(con un método "Dequeue") y saber cuántos datos hay (con una propiedad "Count"). 
Incluye un Main que permita probarla, añadiendo 3 datos, comprobando su cantidad y extrayéndolos. 
Si cambias la llamada al constructor (por ejemplo "ColaDeEnteros cola = new ColaDeEnteros()") 
por "Queue<int> pila = new Queue<int>();", el programa deberá funcionar correctamente.

Por Blanca (...)
*/
 
using System;
using System.Collections.Generic;

class ColaDeEnteros
{
    private List<int> numeros;
    public int Count { get { return numeros.Count; } }
    //public int Count { get; set; }

    public ColaDeEnteros()
    {
        numeros = new List<int>();
    }

    public void Enqueue(int num)
    {
        numeros.Add(num);
    }

    public int Dequeue()
    {
        int ultimaPosicion = numeros.Count - 1;
        int dato = numeros[ultimaPosicion];
        numeros.RemoveAt(ultimaPosicion);
        return dato;
    }
}


class Program
{
    static void Main()
    {
        //Queue<int> numeros = new Queue<int>();
        ColaDeEnteros numeros = new ColaDeEnteros();

        numeros.Enqueue(1);
        numeros.Enqueue(2);
        numeros.Enqueue(3);
        numeros.Enqueue(4);

        Console.WriteLine("Count: " + numeros.Count);

        int cantidad = numeros.Count;
        for(int i=0; i<cantidad; i++)
        {
            Console.WriteLine(numeros.Dequeue());
        }
    }
}

