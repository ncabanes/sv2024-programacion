/* 78. Crea una versión mejorada del programa anterior: un array que permita 
almacenar hasta 1.000 nombres de personas y un menú que permita: Añadir un 
nuevo dato (al final de los existentes), insertar un dato (en una cierta 
posición que se preguntará al usuario), borrar un dato (a partir de su número 
de posición), ver todos los datos, buscar un cierto dato, salir. */

using System;

//Rubén (...), retoques por Nacho

class Ejercicio78
{
    static void Main()
    {
        const int CAPACIDAD = 100;
        const int ANADIR = 1, INSERTAR = 2, BORRAR = 3,
            VER = 4, BUSCAR = 5, SALIR = 0;
        string[] nombres = new string[CAPACIDAD];
        int contador = 0;
        bool condicion = true;

        while (condicion)
        { 

            Console.WriteLine(ANADIR + ". Añadir un dato (al final)");
            Console.WriteLine(INSERTAR + ". Insertar un dato (en una posic. intermedia)");
            Console.WriteLine(BORRAR + ". Borrar un dato");
            Console.WriteLine(VER + ". Ver todos los datos");
            Console.WriteLine(BUSCAR + ". Buscar una personas");
            Console.WriteLine(SALIR + ". Salir");
            Console.Write("Introduce una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case ANADIR:
                    if (contador >= CAPACIDAD)
                    {
                        Console.WriteLine("No caben más datos");
                    }
                    else
                    {
                        Console.Write("Introduce el nombre del nuevo contacto de la agenda: ");
                        string nuevo = Console.ReadLine();
                        nombres[contador] = nuevo;
                        contador++;
                    }
                    break;

                case INSERTAR:
                    Console.Write("Introduce el nombre del nuevo contacto de la agenda: ");
                    string datoInsertar = Console.ReadLine();
                    Console.Write("Introduce la posicion en la que quieras añadir el contacto: ");
                    int posicionInsertar = Convert.ToInt32(Console.ReadLine()) - 1;
                    for (int i=contador; i > posicionInsertar; i--) 
                        nombres[i] = nombres[i-1]; 
                    nombres[posicionInsertar] = datoInsertar;
                    contador++;
                    break;
                    
                case BORRAR:
                    Console.Write("Introduce la posicion en la que quieras que se borre el dato: ");
                    int posicionBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
                    for (int i=posicionBorrar; i < contador-1; i++) 
                        nombres[i] = nombres[i+1]; 
                    contador--;
                    break;
                    
                case VER:
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine(nombres[i]);
                    }
                    break;

                case BUSCAR:
                    Console.Write("Introduce el nombre del contacto que quieres buscar: ");
                    string buscar = Console.ReadLine();
                    bool encontrado = false;
                    foreach (string nombre in nombres)
                    {
                        if ( nombre == buscar)
                        {
                            encontrado = true;
                        }
                    }
                    if ( encontrado)
                    {
                        Console.WriteLine("El contacto {0} se encuentra en la agenda", buscar);
                    } 
                    else
                    {
                        Console.WriteLine("El contacto {0} NO se cuentra en la agenda", buscar);
                    }
                    break;

                case SALIR:
                    Console.WriteLine("Cerrando agenda...");
                    condicion = false;
                    break;
            }
            Console.WriteLine();
        }
    }
}


