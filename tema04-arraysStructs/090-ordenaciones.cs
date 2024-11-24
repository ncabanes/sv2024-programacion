/* Crea un programa que pida al usuario 10 números reales de doble precisión, 
los guarde en un array llamados "datosOriginales", y luego:

- Los copie a un array "datos1", ordene este array mediante intercambio directo 
  (ya sea ascendente, descendente o burbuja) y muestre el contenido de "datos1".

- Los copie a un array "datos2", ordene este array mediante selección directa y 
  muestre el contenido de "datos2".

- Los copie a un array "datos3", ordene este array mediante inserción directa y 
  muestre el contenido de "datos3".

- Busque si el dato 100 aparece en "datosOriginales", mediante búsqueda lineal.

- Busque si el dato 100 aparece en "datos3", mediante búsqueda binaria.*/

using System;

class Orenaciones
{
    static void Main()
    {
        const int CANTIDAD = 10;
        double[] datosOriginales = new double[CANTIDAD];

        Console.WriteLine("Introduce 10 numeros reales de doble precision.");

        for (int i = 0; i < datosOriginales.Length; i++)
        {
            Console.Write("Introduce el dato numero {0}: ", i+1);
            datosOriginales[i] = Convert.ToDouble(Console.ReadLine());
        }

        //copie a un array "datos1", ordene este array mediante intercambio directo

        double[] datos1 = new double[CANTIDAD];
        for (int i = 0; i <datosOriginales.Length; i++)
        {
            datos1[i] = datosOriginales[i];
        }
        
        for (int i = 0; i < CANTIDAD - 1; i++)
        {
            for(int j = i+1; j < CANTIDAD; j++)
            {
                if (datos1[i] > datos1[j])
                {
                    double datoTemporal1 = datos1[i];
                    datos1[i] = datos1[j];
                    datos1[j] = datoTemporal1;
                }
            }
        }
        Console.Write("Ordenado mediante intercambio directo:");
        foreach(double dato in datos1)
        {
            Console.Write(" {0}",dato);
        }
        Console.WriteLine();
        
        //Los copie a un array "datos2", ordene este array mediante selección directa

        double[] datos2 = new double[CANTIDAD];
        for (int i = 0; i < datosOriginales.Length; i++)
        {
            datos2[i] = datosOriginales[i];
        }

        for(int i = 0; i < CANTIDAD - 1; i++)
        {
            int posicNumeroMenor = i;
            for(int j = i+1; j < CANTIDAD; j++)
            {
                if (datos2[j] < datos2[posicNumeroMenor])
                {
                    posicNumeroMenor = j;
                }
            }
            if( i != posicNumeroMenor)
            {
                double datoTemporal2 = datos2[i];
                datos2[i] = datos2[posicNumeroMenor];
                datos2[posicNumeroMenor] = datoTemporal2;

            }
        }

        Console.Write("Ordenado mediante selección directa:");
        foreach(double dato in datos2)
        {
            Console.Write(" {0}", dato);
        }
        Console.WriteLine();

        //Los copie a un array "datos3", ordene este array mediante inserción directa

        double[] datos3 = new double[CANTIDAD];
        for(int i = 0; i < datosOriginales.Length; i++)
        {
            datos3[i] = datosOriginales[i];
        }

        for(int i = 1; i < CANTIDAD; i++)
        {
            int j = i - 1;
            while((j>= 0) && (datos3[j] > datos3[j + 1]))
            {
                double datoTemporal3 = datos3[j];
                datos3[j] = datos3[j+ 1];
                datos3[j + 1] = datoTemporal3;
                j--;
            }
        }
        Console.Write("Ordenado mediante insercion directa:");
        foreach(double dato in datos3)
        {
            Console.Write(" {0}", dato);
        }
        Console.WriteLine();

        //Busque si el dato 100 aparece en "datosOriginales", mediante búsqueda lineal.

        int buscado = 100;
        bool encontradoBL = false;
        for(int i = 0; i < CANTIDAD; i++)
        {
            if (datosOriginales[i] == buscado)
            {
                encontradoBL = true;
            }
        }
        if (encontradoBL)
        {
            Console.WriteLine("El dato " + buscado + 
                " ha sido encontrado mediante búsqueda lineal.");
        }
        else
        {
            Console.WriteLine("El dato " + buscado + 
                " NO ha sido encontrado mediante búsqueda lineal.");
        }
        
        //Busque si el dato 100 aparece en "datos3", mediante búsqueda binaria.

        bool encontradoBB = false;
        int limiteInferior = 0;
        int limiteSuperior = CANTIDAD-1;

        while (limiteInferior <= limiteSuperior && ! encontradoBB)
        {
            int puntoMedio = limiteInferior + (limiteSuperior - limiteInferior) / 2;
            if (datos3[puntoMedio] == buscado)
            {
                encontradoBB = true;
            }
            else if (datos3[puntoMedio] < buscado)
            {
                limiteInferior = puntoMedio + 1;
            }
            else
            {
                limiteSuperior = puntoMedio - 1;
            }
        }

        if (encontradoBB)
        {
            Console.WriteLine("El dato "+ buscado + 
                " ha sido encontrado mediante busqueda binaria.");
        }
        else
        {
            Console.WriteLine("El dato "+ buscado + 
                " NO ha sido encontrado mediante busqueda binaria.");
        }
    }
}
