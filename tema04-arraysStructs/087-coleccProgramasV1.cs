/*
Crea un programa en C# que pueda almacenar fichas de hasta 1000 programas de
ordenador. Para cada programa, debe guardar los siguientes datos:

Nombre

Descripción

Versión (es un conjunto de 2 datos: el mes de lanzamiento -byte- y el año de
lanzamiento -entero corto sin signo-)

El programa debe permitir al usuario las siguientes operaciones:

1- Añadir datos de un nuevo programa.

2- Mostrar los nombres de todos los programas almacenados. Cada nombre debe
aparecer en una línea distinta, precedido por el número de programa (empezando
a contar desde 1). Si hay más de 20 programas, se deberá hacer una pausa tras
mostrar cada bloque de 20 programas, y esperar a que el usuario pulse Intro
antes de seguir. Se deberá avisar si no hay datos. (*)

3- Ver todos los datos de un cierto programa (a partir de su número de
registro, contando desde 1, que se preguntará al usuario). Se deberá avisar
(pero no volver a pedir) si el número no es válido.

4- Modificar una ficha (se pedirá el número y se volverá a introducir el valor
de todos los campos. Se debe avisar (pero no volver a pedir) si introduce un
número de ficha incorrecto.

5- Borrar un cierto dato, a partir del número de posición, que introducirá el
usuario. Se debe avisar (pero no volver a pedir) si introduce un número
incorrecto.

T- Terminar(como no sabemos almacenar la información, los datos se perderán).

(*) Pista: Para esperar a que el usuario pulse Intro, puedes usar
"Console.ReadLine()", sin necesidad de guardarlo en ninguna variable. Para
hacer una pausa tras mostrar cada 20 datos, puedes usar un contador o la
operación "módulo".


César (...), retoques menores por Nacho
*/

using System;

class Ejercicio87
{
    struct tipoVersion
    {
        public byte mesLanzamiento;
        public ushort anyoLanzamiento;
    }

    struct tipoPrograma
    {
        public string nombre;
        public string descripcion;
        public tipoVersion version;
    }

    static void Main ()
    {
        const int MAX_PROGRAMAS = 1000;
        tipoPrograma[] programas = new tipoPrograma[MAX_PROGRAMAS];
        bool seguir = true;
        int contador = 0;
        while (seguir)
        {
            Console.WriteLine ("Pulsa: ");
            Console.WriteLine ("1 Para añadir un nuevo programa.");
            Console.WriteLine ("2 Para ver los programas almacenados.");
            Console.WriteLine ("3 Para ver la ficha de un programa concreto.");
            Console.WriteLine ("4 Para modificar la ficha de un programa.");
            Console.WriteLine ("5 Para borrar una ficha de un programa.");
            Console.WriteLine ("T Para terminar.");
            string dato = Console.ReadLine ();
            switch (dato)
            {
                case "1": // Añadir
                    if (contador < MAX_PROGRAMAS)
                    {
                        Console.Write("Nombre del programa: ");
                        programas[contador].nombre = Console.ReadLine ();
                        Console.Write("Descripción del programa: ");
                        programas[contador].descripcion = Console.ReadLine ();
                        Console.Write("Version (Mes de lanzamiento): ");
                        programas[contador].version.mesLanzamiento =
                            Convert.ToByte (Console.ReadLine ());
                        Console.Write("Version (Año de lanzamiento): ");
                        programas[contador].version.anyoLanzamiento =
                            Convert.ToUInt16 (Console.ReadLine ());
                        Console.WriteLine ("Programa añadido.");
                        contador ++;
                    }
                    else
                    {
                        Console.Write ("No caben más programas");
                    }
                    break;

                case "2": // Ver todos
                    if (contador != 0)
                    {
                        for (int i=0; i<contador; i++)
                        {
                            Console.WriteLine("{0}. {1}", i+1, programas[i].nombre);
                            if (i % 20 == 19)
                            {
                                Console.WriteLine("Pulsa INTRO para continuar: ");
                                Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine ("No hay programas grabados.");
                    }
                    break;

                case "3": // Ver detalles de uno

                    Console.Write ("¿La ficha de qué programa quieres ver?: ");
                    short mostrarFicha = Convert.ToInt16 (Console.ReadLine());
                    if (mostrarFicha < contador+1)
                    {
                        Console.WriteLine("{0}. {1}", mostrarFicha, programas[mostrarFicha-1].nombre);
                        Console.WriteLine("Descripción: " +
                        programas[mostrarFicha-1].descripcion);
                        Console.WriteLine("Versión: " +
                        programas[mostrarFicha-1].version.mesLanzamiento +
                            "/" + programas[mostrarFicha-1].version.anyoLanzamiento);
                    }
                    else
                    {
                        Console.WriteLine ("Numero incorrecto");
                    }
                    break;

                case "4":  // Modificar
                    Console.Write ("¿Que ficha quieres modificar?: ");
                    int modificarFicha = Convert.ToInt16 (Console.ReadLine()) - 1;
                    if (modificarFicha < contador)
                    {
                        Console.Write("Nombre del programa: ");
                        programas[modificarFicha].nombre = Console.ReadLine ();
                        Console.Write("Descripción del programa: ");
                        programas[modificarFicha].descripcion = Console.ReadLine ();
                        Console.Write("Version (Mes de lanzamiento): ");
                        programas[modificarFicha].version.mesLanzamiento =
                            Convert.ToByte (Console.ReadLine ());
                        Console.Write("Version (Año de lanzamiento): ");
                        programas[modificarFicha].version.anyoLanzamiento =
                            Convert.ToUInt16 (Console.ReadLine ());
                        Console.WriteLine ("Programa modificado.");
                    }
                    else
                    {
                        Console.WriteLine ("Numero incorrecto");
                    }
                    break;

                case "5":
                    Console.Write ("¿Que ficha quieres borrar?: ");
                    int borrarFicha = Convert.ToInt16 (Console.ReadLine())-1;
                    if (borrarFicha <= contador)
                    {
                        for (int i = borrarFicha; i<contador-1; i++)
                        {
                           programas[i].nombre = programas[i+1].nombre;
                           programas[i].descripcion = programas[i+1].descripcion;
                           programas[i].version = programas[i+1].version;
                           contador--;
                        }
                    }
                    else
                    {
                        Console.WriteLine ("Numero incorrecto");
                    }
                    break;

                case "T":
                case "t":
                    Console.WriteLine ("Hasta la próxima");
                    seguir = false;
                    break;

                default:
                    Console.WriteLine("Dato incorrecto");
                    Console.WriteLine ("Intentalo de nuevo"); break;
                }
        }
    }
}



























