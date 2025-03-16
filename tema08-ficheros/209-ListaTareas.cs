/*
 Crea una nueva versión del ejercicio 191 (gestor de tareas), partiendo de la versión oficial,
en la que guardes datos tras cada cambio (añadir, completar, modificar, ordenar) usando StreamWriter
y cargues datos (si existen) al comenzar la ejecución con StreamReader. Deberás crear una función "Cargar" y otra función "Guardar" que se encarguen de hacerlo.
En esta ocasión, cada dato (descripción, prioridad, completada) se guardará en una línea distinta.
En la primera línea del fichero se guardará el contador de la cantidad de registros existentes,
de modo que la lectura se pueda hacer simplemente con un "for".
Como siempre, debes gestionar los posibles errores de forma adecuada.

Por Blanca (...)
*/


using System;
using System.Collections.Generic;
using System.IO;

class Tarea : IComparable<Tarea>
{
    public string Descripcion { get; set; }
    public int Prioridad { get; set; }
    public bool Completada { get; set; }

    public int CompareTo(Tarea otra)
    {
        return Descripcion.ToLower().CompareTo(otra.Descripcion.ToLower());
    }

    public override string ToString()
    {
        return Descripcion + "-" + Prioridad + "-" + (Completada ? "Completada" : "Pendiente");
    }
}

class Program
{
    static void Main()
    {
        const string nombreFichero = "datos.txt";
        List<Tarea> tareas = new List<Tarea>();
        string opcion;

        Cargar(tareas, nombreFichero);

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

            switch (opcion)
            {
                case "1":
                    AnyadirTarea(tareas);
                    Guardar(tareas, nombreFichero);
                    break;
                case "2":
                    VerTareasPendientes(tareas);
                    break;
                case "3":
                    MarcarCompletada(tareas);
                    Guardar(tareas, nombreFichero);
                    break;
                case "4":
                    ModificarTarea(tareas);
                    Guardar(tareas, nombreFichero);
                    break;
                case "5":
                    BuscarTareas(tareas);
                    break;
                case "6":
                    tareas.Sort();
                    Guardar(tareas, nombreFichero);
                    Console.WriteLine("Tareas ordenadas");
                    break;
                case "s":
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            if (opcion != "s")
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

        if (terminada == "s")
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

        for (int i = 0; i < tareas.Count; i++)
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
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine((i + 1) + " - " + tareas[i]);
        }

        Console.WriteLine("Qué tarea quieres modificar?");
        int posicionModificar = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Modificar descripción? (ENTER para omitir)");
        string nuevaDescripcion = Console.ReadLine();

        if (nuevaDescripcion != "")
        {
            tareas[posicionModificar].Descripcion = nuevaDescripcion;
        }

        Console.WriteLine("Modificar prioridad? (ENTER para omitir)");
        string nuevaPrioridad = Console.ReadLine();

        if (nuevaPrioridad != "")
        {
            tareas[posicionModificar].Prioridad = Convert.ToInt32(nuevaPrioridad);
        }

        Console.WriteLine("Completada (s/n): (ENTER para omitir)");
        string completada = Console.ReadLine().ToLower();

        if (completada != "")
        {
            tareas[posicionModificar].Completada = completada == "s" ? true : false;
        }
    }

    public static void BuscarTareas(List<Tarea> tareas)
    {
        Console.WriteLine("Qué quieres buscar?");
        string buscar = Console.ReadLine().ToLower();
        bool encontrado = false;

        for (int i = 0; i < tareas.Count; i++)
        {
            if (tareas[i].Descripcion.ToLower().Contains(buscar))
            {
                Console.WriteLine((i + 1) + ": " + tareas[i]);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se ha encontrado ninguna coincidencia");
        }
    }

    public static void Guardar(List<Tarea> tareas, string nombreFichero)
    {
        try
        {
            StreamWriter escribir = new StreamWriter(nombreFichero);
            escribir.WriteLine(tareas.Count);
            foreach(Tarea t in tareas)
            {
                escribir.WriteLine(t);
            }
            escribir.Close();
        } 
        catch(IOException)
        {
            Console.WriteLine("Error al guardar el fichero");
        }
    }

    public static void Cargar(List<Tarea> tareas, string nombreFichero)
    {
        if(File.Exists(nombreFichero))
        {
            try
            {
                StreamReader lectura = new StreamReader(nombreFichero);
                string linea;
                int cantidad = Convert.ToInt32(lectura.ReadLine());

                for(int i=0; i<cantidad; i++)
                {
                    linea = lectura.ReadLine();

                    if (linea != null && linea != "")
                    {
                        string[] datos = linea.Split('-');
                        Tarea t = new Tarea();
                        t.Descripcion = datos[0];
                        t.Prioridad = Convert.ToInt32(datos[1]);
                        t.Completada = datos[2] == "Completada" ? true : false;

                        tareas.Add(t);
                    }
                }

                lectura.Close();
            }
            catch(IOException)
            {
                Console.WriteLine("Error al intentar guardar los cambios");
            }
            catch(FormatException)
            {
                Console.WriteLine("Datos guardados corruptos");
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
