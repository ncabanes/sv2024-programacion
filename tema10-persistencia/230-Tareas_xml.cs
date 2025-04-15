/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 230. Serialización XML.
 * 
 * Crea una nueva versión del ejercicio 191 (tareas + lista), partiendo de la
 * versión oficial, en la que uses serialización XML para cargar datos cuando
 * arranca el programa y para guardar los datos antes de terminar la
 * ejecución. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Tarea : IComparable<Tarea> {
    public string Descripcion { get; set; }
    public int Prioridad { get; set; }
    public bool Completada { get; set; }

    public int CompareTo(Tarea otra) {
        return Descripcion.ToLower().CompareTo(otra.Descripcion.ToLower());
    }

    public override string ToString() {
        return Descripcion + " - " + Prioridad + " - " +
            (Completada ? "Completada" : "Pendiente");
    }
}

class Program {

    private const string archivo = "tareas.xml";

    static void Main() {

        List<Tarea> tareas = Cargar();

        string opcion;

        do {
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

            switch (opcion) {
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

            if (opcion != "s") {
                Console.WriteLine("Pulsa ENTER para continuar");
                Console.ReadLine();
            }
        } while (opcion != "s");

        Guardar(tareas);
    }

    private static List<Tarea> Cargar() {
        List <Tarea> tareas = new List<Tarea>();

        if (File.Exists(archivo)) {
            try {
                XmlSerializer formatter = new XmlSerializer(tareas.GetType());
                FileStream stream = new FileStream(archivo, FileMode.Open, 
                    FileAccess.Read);
                tareas = (List<Tarea>)formatter.Deserialize(stream);
                stream.Close();
                return tareas;
            } catch (FileNotFoundException) {
                Console.WriteLine("Archivo no encontrado.");
            } catch (PathTooLongException) {
                Console.WriteLine("Archivo demasiado largo.");
            } catch (IOException) {
                Console.WriteLine("Error de lectura y/o escritura");
            } catch (Exception error) {
                Console.WriteLine("Error: " + error.Message);
            }
        }

        return tareas;
    }

    private static void Guardar(List<Tarea> tareas) {
        try {
            XmlSerializer formatter = new XmlSerializer(tareas.GetType());
            FileStream stream = new FileStream(archivo, FileMode.Create,
                FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, tareas);
            stream.Close();
        } catch (FileNotFoundException) {
            Console.WriteLine("Archivo no encontrado.");
        } catch (PathTooLongException) {
            Console.WriteLine("Archivo demasiado largo.");
        } catch (IOException) {
            Console.WriteLine("Error de lectura y/o escritura");
        } catch (Exception error) {
            Console.WriteLine("Error: " + error.Message);
        }
    }

    public static void AnyadirTarea(List<Tarea> tareas) {
        Tarea nuevaTarea = new Tarea();

        Console.WriteLine("Dime la descripción de la tarea");
        nuevaTarea.Descripcion = Console.ReadLine();

        Console.WriteLine("Dime la prioridad (1-5):");
        nuevaTarea.Prioridad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Está terminada la tarea? (s/n)");
        string terminada = Console.ReadLine().ToLower();

        if (terminada == "s") {
            nuevaTarea.Completada = true;
        } else {
            nuevaTarea.Completada = false;
        }

        tareas.Add(nuevaTarea);
    }

    public static void VerTareasPendientes(List<Tarea> tareas) {
        Console.WriteLine("Tareas pendientes:");

        for (int i = 0; i < tareas.Count; i++) {
            if (!tareas[i].Completada) {
                Console.WriteLine((i + 1) + " - " + tareas[i]);
            }
        }
    }

    public static void MarcarCompletada(List<Tarea> tareas) {
        VerTareasPendientes(tareas);
        Console.WriteLine();
        Console.WriteLine("Cual quieres marcar como completada?");
        int opcion = Convert.ToInt32(Console.ReadLine()) - 1;

        tareas[opcion].Completada = true;
        Console.WriteLine("Tarea completada!!!");
    }

    public static void ModificarTarea(List<Tarea> tareas) {
        Console.WriteLine("Lista de tareas: ");
        for (int i = 0; i < tareas.Count; i++) {
            Console.WriteLine((i + 1) + " - " + tareas[i]);
        }

        Console.WriteLine("Qué tarea quieres modificar?");
        int posicionModificar = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Modificar descripción? (ENTER para omitir)");
        string nuevaDescripcion = Console.ReadLine();

        if (nuevaDescripcion != "") {
            tareas[posicionModificar].Descripcion = nuevaDescripcion;
        }

        Console.WriteLine("Modificar prioridad? (ENTER para omitir)");
        string nuevaPrioridad = Console.ReadLine();

        if (nuevaPrioridad != "") {
            tareas[posicionModificar].Prioridad = 
                Convert.ToInt32(nuevaPrioridad);
        }

        Console.WriteLine("Completada (s/n): (ENTER para omitir)");
        string completada = Console.ReadLine().ToLower();

        if (completada != "") {
            tareas[posicionModificar].Completada = 
                completada == "s" ? true : false;
        }
    }

    public static void BuscarTareas(List<Tarea> tareas) {
        Console.WriteLine("Qué quieres buscar?");
        string buscar = Console.ReadLine().ToLower();
        bool encontrado = false;

        for (int i = 0; i < tareas.Count; i++) {
            if (tareas[i].Descripcion.ToLower().Contains(buscar)) {
                Console.WriteLine((i + 1) + ": " + tareas[i]);
                encontrado = true;
            }
        }

        if (!encontrado) {
            Console.WriteLine("No se ha encontrado ninguna coincidencia");
        }
    }
}
