/*
* Pide al usuario 2 bloques de enteros, 
* cada uno con el tamaño que él/ella elija. 
* Luego muestra el máximo del segundo bloque.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        int[][] datos = new int[2][];
        
        Console.Write("¿Intentos del deportista 1? ");
        int intentos1 = Convert.ToInt32( Console.ReadLine() );
        datos[0] = new int[intentos1];
        
        Console.Write("¿Intentos del deportista 2? ");
        int intentos2 = Convert.ToInt32( Console.ReadLine() );
        datos[1] = new int[intentos2];
        
        for (int deportista = 0; deportista < datos.Length; deportista++)
        {
            for (int intento = 0; intento < datos[deportista].Length; intento++)
            {
                Console.Write("Dame el dato del deportista {0}, intento {1}: ",
                    deportista+1, intento+1);
                datos[deportista][intento] = Convert.ToInt32( Console.ReadLine() );
            }
        }
        
        int participante = 1;
        int maximo = datos[participante][0];
        for (int intento = 0; intento < datos[participante].Length; intento++)
        {
            if (datos[participante][intento] > maximo)
                maximo = datos[participante][intento];
        }
        Console.WriteLine("El máximo de la segunda fila es "+maximo);
    }
}

/*
¿Intentos del deportista 1? 3
¿Intentos del deportista 2? 4
Dame el dato del deportista 1, intento 1: 3
Dame el dato del deportista 1, intento 2: 4
Dame el dato del deportista 1, intento 3: 5
Dame el dato del deportista 2, intento 1: 1
Dame el dato del deportista 2, intento 2: 6
Dame el dato del deportista 2, intento 3: 7
Dame el dato del deportista 2, intento 4: 2
El máximo de la segunda fila es 7
*/
