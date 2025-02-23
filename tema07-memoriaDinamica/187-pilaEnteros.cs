/*
 Crea una clase "PilaDeEnteros", que internamente debe emplear un array de enteros,
en vez de la clase "Stack". Debe permitir apilar (usando un método "Push") números 
enteros, obtenerlos (con un método "Pop") y saber cuántos datos hay (con una propiedad 
"Count"). . Incluye un Main que permita probarla, añadiendo 3 datos, comprobando
su cantidad y extrayéndolos. Debe imitar el comportamiente de un "Stack", de modo 
que, si cambias la llamada al constructor (por ejemplo 
"PilaDeEnteros pila = new PilaDeEnteros()") por "Stack<int> pila = new Stack<int>();",
el programa deberá funcionar correctamente.

Por Blanca (...)
*/
 
using System;
using System.Collections.Generic;

class PilaDeEnteros
{
    private int[] numeros;
    private const int CAPACIDAD = 100;
    public int Count { get; set; }

    public PilaDeEnteros()
    {
        numeros = new int[CAPACIDAD];
        Count = 0;
    }

    public void Push(int num)
    {
        numeros[Count] = num;
        Count++;
    }

    public int Pop()
    {        
        int num = numeros[Count - 1];
        Count--;
        return num;
    }
}

class Program
{
    static void Main()
    {
        PilaDeEnteros numeros = new PilaDeEnteros();
        //Stack<int> numeros = new Stack<int>();

        numeros.Push(1);
        numeros.Push(3);
        numeros.Push(5);

        Console.WriteLine("Cantidad: {0}", numeros.Count);

        int cantidad = numeros.Count;

        for(int i=0; i<cantidad; i++)
        {
            Console.WriteLine(numeros.Pop());
        }
    }
}

