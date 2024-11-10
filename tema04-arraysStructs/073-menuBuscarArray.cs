// Juan Carlos (...) 04/XI/2024

/* 73. Crea un array de números reales de doble precisión, con espacio para 20 datos.
 * Pide al usuario esos 20 datos y luego muestra un menú que le permita: Ver todos los
 * datos en su orden original, ver todos los datos en orden inverso, mostrar el máximo de los datos,
 * mostrar el mínimo de los datos, buscar un cierto dato, salir. La opción de Buscar preguntará
 * el dato que se quiere localizar y responderá si ese aparece o no.*/

using System;

class Ejercicio73
{
    static void Main()
    {
        // Declaración de variables que usaremos a lo largo del programa
        double[] numeros = new double[20];
        double maximo;
        double minimo;
        double numeroBuscado = 0;
        bool encontrado;

        // Guardar números mediante for
        for (byte i = 0; i < numeros.Length; i++)
        {
            Console.Write("Introduce un número ({0} de 20): ", i+1);
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Declaración de variable de menú
        byte opcion = 0;

        // Bucle para preguntar qué interacción tenemos con el menú y sus diferentes opciones
        do
        {
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine("1. Ver los datos introducidos.");
            Console.WriteLine("2. Ver los datos introducidos en orden inverso.");
            Console.WriteLine("3. Mostrar el dato máximo.");
            Console.WriteLine("4. Mostrar el dato mínimo.");
            Console.WriteLine("5. Buscar un dato.");
            Console.WriteLine("6. Salir.");
            Console.WriteLine();
            Console.Write("Opción: ");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                // Ver los datos introducidos
                case 1:
                    foreach (byte i in numeros)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                // Ver los datos introducidos en orden inverso
                case 2:
                    for (int i = numeros.Length - 1; i >= 0; i--)
                    {
                        Console.Write(numeros[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                // Mostrar el dato máximo
                case 3:
                    maximo = numeros[0];
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        if (numeros[i] > maximo)
                        {
                            maximo = numeros[i];
                        }
                    }
                    Console.WriteLine("El máximo es {0}.", maximo);
                    Console.WriteLine();
                    break;

                // Mostrar el dato mínimo
                case 4:
                    minimo = numeros[0];
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        if (numeros[i] < minimo)
                        {
                            minimo = numeros[i];
                        }
                    }
                    Console.WriteLine("El mínimo es {0}.", minimo);
                    Console.WriteLine();
                    break;

                // Buscar el dato
                case 5:
                    Console.Write("Introduce un número para buscar: ");
                    numeroBuscado = Convert.ToDouble(Console.ReadLine());

                    encontrado = false;
                    foreach (double i in numeros)
                    {
                        if (i == numeroBuscado)
                            encontrado = true;
                    }
                    if (encontrado)
                        Console.WriteLine("El número {0} aparece en la lista.",
                            numeroBuscado);
                    else
                        Console.WriteLine("El número {0} no aparece.",
                            numeroBuscado);
                    Console.WriteLine();
                    encontrado = false;
                    break;

                // Salir
                case 6:
                    Console.WriteLine("¡Hasta la próxima!");
                    break;

                default: Console.WriteLine("No conozco esa opción de menú.");
                    Console.WriteLine();
                    break;
            }
        }
        while (opcion != 6);
    }
}
