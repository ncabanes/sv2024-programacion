/*
Crea un array con las raíces cuadradas de los números 
contenidos en otro array de números reales, 
empleado Array.ConvertAll y una "función lambda".
*/

using System;

class Ejemplo
{
    static void Main()
    {
        double[] datos = { 10, 20.5, 30.6, 600 };

        double[] raices = new double[datos.Length];
        for (int i = 0; i < datos.Length; i++)
        {
            raices[i] = Math.Sqrt(datos[i]);
        }

        var raices2 = Array.ConvertAll(datos, d => Math.Sqrt(d));
        Array.ForEach(raices2, d => Console.Write(d + " "));
    }
}

