/*
Crea un array prefijado con los nombres de los días de la semana. 
Pregunta al usuario el nombre de un día y respóndele si ese día existe.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        bool encontrado;
        int cantidadApariciones;
        
        string[] diasSemana = {"lunes", "martes", "miércoles",
            "jueves", "viernes", "sábado", "domingo"};
            
        Console.Write("Qué nombre de día quieres comprobar? ");
        string diaBuscar = Console.ReadLine();
        
        encontrado = false;
        for (int i = 0; i < diasSemana.Length; i++)
        {
            if (diasSemana[i] == diaBuscar)
                encontrado = true;
        }
        
        if (encontrado)
            Console.WriteLine("Encontrado");
        else
            Console.WriteLine("No encontrado");
        
        // ---------------------
        
        cantidadApariciones = 0;
        foreach(string diaActual in diasSemana)
        {
            if (diaActual == diaBuscar)
                cantidadApariciones++;
        }
        
        if (cantidadApariciones > 0)
            Console.WriteLine("Encontrado {0} veces", cantidadApariciones);
        else
            Console.WriteLine("No encontrado");
    }
}

/*
Qué nombre de día quieres comprobar? martes
Encontrado
Encontrado 1 veces

Qué nombre de día quieres comprobar? juernes
No encontrado
No encontrado
*/
