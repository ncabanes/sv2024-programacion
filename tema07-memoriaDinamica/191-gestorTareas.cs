/* Crea un gestor básico de tareas, usando una lista de objetos de clase 
"Tarea" (con los atributos o propiedades: descripción -texto-, prioridad -1 a 
5-, completada -verdadero o falso-). Esa clase "Tarea" implementará la interfaz 
IComparable, lo que te obligará a crear un método "CompareTo", que permita 
comparar dos tareas, para poder utilizar "Array.Sort" en vez de algoritmos 
lentos como la "burbuja".

En esta primera versión, el criterio de comparación será la descripción, de 
modo que las tareas se muestren ordenadas de la A a la Z.

El programa principal mostrará un menú al usuario, mediante el cual pueda:

1 - Añadir una nueva tarea.

2 - Ver todas las tareas pendientes.

3 - Marcar una tarea como completada, a partir de su posición en el array (1 para la primera, 2 para la segunda, etc).

4 - Modificar una tarea (también a partir de su posición).

5 - Buscar entre todas las tareas que contengan un cierto texto (estén completadas o no).

6 - Ordenar las tareas alfabéticamente.

S - Salir.

Por Blanca (...)
*/

using System;
using System.Collections.Generic;

class Tarea: IComparable<Tarea>
{
    public string Descripcion {  get; set; }
    public int Prioridad { get; set; }
    public bool Completada { get; set; }

    public int CompareTo(Tarea otra)
    {
        return Descripcion.ToLower().CompareTo(otra.Descripcion.ToLower());
    }

    public override string ToString()
    {
        return Descripcion + " - " + Prioridad + " - " + (Completada ? "Completada" : "Pendiente");
    }
}

class Program
{
    static void Main()
    {
        List<Tarea> tareas = new List<Tarea>();
        string opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("Menú:");
            Console.WriteLine("1 - Añadir nueva tarea");
            Console.WriteLine("2 - Ver todas las tareas pendientes");
            Console.WriteLine("3 - Marcar una tarea como completada");
            Console.WriteLine("4 - Modificar tarea");
            Console.WriteLine("5 - Buscar tarea");
            Console.WriteLine("6 - Ordenar tareas");
            Console.WriteLine("s - Salir");
            opcion = Console.ReadLine().ToLower();

            switch(opcion)
            {
                case "1":
                    AnyadirTarea(tareas);
                    break;
                case "2":
                    VerTareasPendientes(tareas);
                    break;
                case "3":
                    MarcarCompletada(tareas);
                    break;
                case "4":
                    ModificarTarea(tareas);
                    break;
                case "5":
                    BuscarTareas(tareas);
                    break;
                case "6":
                    tareas.Sort();
                    Console.WriteLine("Tareas ordenadas");
                    break;
                case "s":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            if(opcion != "s")
            {
                Console.WriteLine("Pulsa ENTER para continuar");
                Console.ReadLine();
            }
        } while (opcion != "s");
    }

    public static void AnyadirTarea(List<Tarea> tareas)
    {
        Tarea nuevaTarea = new Tarea();

        Console.WriteLine("Dime la descripción de la tarea");
        nuevaTarea.Descripcion = Console.ReadLine();

        Console.WriteLine("Dime la prioridad (1-5):");
        nuevaTarea.Prioridad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Está terminada la tarea? (s/n)");
        string terminada = Console.ReadLine().ToLower();

        if(terminada == "s")
        {
            nuevaTarea.Completada = true;
        } 
        else
        {
            nuevaTarea.Completada = false;
        }

        tareas.Add(nuevaTarea);
    }

    public static void VerTareasPendientes(List<Tarea> tareas)
    {
        Console.WriteLine("Tareas pendientes:");

        for (int i=0; i<tareas.Count; i++)
        {
            if (!tareas[i].Completada)
            {
                Console.WriteLine((i + 1) + " - " + tareas[i]);
            }
        }
    }

    public static void MarcarCompletada(List<Tarea> tareas)
    {
        VerTareasPendientes(tareas);
        Console.WriteLine();
        Console.WriteLine("Cual quieres marcar como completada?");
        int opcion = Convert.ToInt32(Console.ReadLine()) - 1;

        tareas[opcion].Completada = true;
        Console.WriteLine("Tarea completada!!!");
    }

    public static void ModificarTarea(List<Tarea> tareas)
    {
        Console.WriteLine("Lista de tareas: ");
        for(int i=0; i < tareas.Count; i++)
        {
            Console.WriteLine((i + 1) + " - " + tareas[i]);
        }

        Console.WriteLine("Qué tarea quieres modificar?");
        int posicionModificar = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Modificar descripción? (ENTER para omitir)");
        string nuevaDescripcion = Console.ReadLine();

        if(nuevaDescripcion != "")
        {
            tareas[posicionModificar].Descripcion = nuevaDescripcion;
        }

        Console.WriteLine("Modificar prioridad? (ENTER para omitir)");
        string nuevaPrioridad = Console.ReadLine();

        if(nuevaPrioridad != "")
        {
            tareas[posicionModificar].Prioridad = Convert.ToInt32(nuevaPrioridad);
        }

        Console.WriteLine("Completada (s/n): (ENTER para omitir)");
        string completada = Console.ReadLine().ToLower();

        if(completada != "")
        {
            tareas[posicionModificar].Completada = completada == "s" ? true : false;
        }
    }

    public static void BuscarTareas(List<Tarea> tareas)
    {
        Console.WriteLine("Qué quieres buscar?");
        string buscar = Console.ReadLine().ToLower();
        bool encontrado = false;

        for(int i=0; i<tareas.Count; i++)
        {
            if (tareas[i].Descripcion.ToLower().Contains(buscar))
            {
                Console.WriteLine((i+1) + ": " + tareas[i]);
                encontrado = true;
            }
        }

        if(!encontrado)
        {
            Console.WriteLine("No se ha encontrado ninguna coincidencia");
        }
    }
}

