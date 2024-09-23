// Darío (...)
// Ejercicio 8: Conversor de millas a metros

using System;

class Ej8 
{
    static void Main()
    {
        int metrosPorMilla = 1609;
        int millas;
        int metros;
        
        Console.Write("Introduce el número de millas a calcular: ");
        millas = Convert.ToInt32(Console.ReadLine());
        
        metros = millas * metrosPorMilla;
        
        Console.Write(millas);
        Console.Write(" millas son ");
        Console.Write(metros);
        Console.Write(" metros");
    }
}

/*
Requisitos que se pedían
- Usar varias órdenes "Write", en vez de emplear "{0}"
- Utilizar "using System;"
- Dos comentarios de una línea al principio: 
  uno con tu nombre y otro con el cometido del programa
*/
