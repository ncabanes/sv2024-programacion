/*
77. Crea un array que permita almacenar hasta 100 nombres de personas, como 
primera aproximación para crear nuestra agenda personal. Deberás mostrar un 
menú que permita: Añadir un nuevo dato (al final de los existentes), ver todos 
los datos, buscar una persona, salir. La opción de Buscar preguntará el nombre 
a buscar y responderá si es parte de nuestra colección.
*/

using System;

//Rubén (...), retoques por Nacho

class Ejercicio77
{
    static void Main()
    {
        const int CAPACIDAD = 100;
        const int ANADIR = 1, VER = 2, BUSCAR = 3, SALIR = 4;
        string[] nombres = new string[CAPACIDAD];
        int contador = 0;
        bool condicion = true;

        while (condicion)
        { 

            Console.WriteLine(ANADIR + ". Añadir un dato");
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


