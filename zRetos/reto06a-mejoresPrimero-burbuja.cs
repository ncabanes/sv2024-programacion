/*
Reto 06: Los mejores primero

Problema a resolver

Este año, los Reyes Magos van un poco estresados y no saben si podrán llevar 
regalos a todos los alumnos de DAM y DAW del IES San Vicente, así que han 
decidido comenzar por los mejores estudiantes, por si acaso...

A pesar de que todos sabemos que esa no tiene por qué ser la medida más fiable, 
han decidido tomar las notas obtenidas en la primera evaluación como criterio 
para valorar quién debe recibir los regalos antes que quien. En un sorteo 
realizado totalmente al azar, ha salido que los criterios deben ser: en primer 
lugar la nota de Programación, y, en segundo lugar, en los casos en que esta 
coincida para dos estudiantes, se mirará la nota de Bases de Datos.

Datos de entrada

La primera línea contendrá un número, la cantidad de estudiantes a ordenar 
según sus notas. Cada una de las líneas posteriores contendrá la nota de 
Programación (sin decimales, expresada como un entero de 0 a 100) y la nota de 
Bases de Datos (también de 0 a 100). Deberás mostrar los datos ordenados según 
esos criterios.

Ejemplo de entrada

6
100 70
100 80
90 100
70 50
95 85
95 100

Salida que se debería obtener con esa entrada:

100 80
100 70
95 100
95 85
90 100
70 50
*/

// Versión 1: ordenando por intercambio directo

using System;

class MejoresPrimero
{
    struct Estudiante
    {
        public byte notaProgr;
        public byte notaBBDD;
    }

    static void Main()
    {
        int cantidadEstudiantes = Convert.ToInt32( Console.ReadLine() );
        Estudiante[] estudiantes = new Estudiante[cantidadEstudiantes];

        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            string[] notas = Console.ReadLine().Split();
            estudiantes[i].notaProgr = Convert.ToByte(notas[0]);
            estudiantes[i].notaBBDD = Convert.ToByte(notas[1]);
        }
        
        for (int i = 0; i < estudiantes.Length - 1; i++)
        {
            for(int j = i+1; j < estudiantes.Length; j++)
            {
                if ((estudiantes[i].notaProgr < estudiantes[j].notaProgr)
                    || (estudiantes[i].notaProgr == estudiantes[j].notaProgr)
                    && (estudiantes[i].notaBBDD < estudiantes[j].notaBBDD))
                {
                    Estudiante temporal = estudiantes[i];
                    estudiantes[i] = estudiantes[j];
                    estudiantes[j] = temporal;
                }
            }
        }

        foreach (Estudiante e in estudiantes)
        {
            Console.WriteLine(e.notaProgr + " " + e.notaBBDD);
        }
    }
}


