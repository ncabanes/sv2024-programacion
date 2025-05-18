/* Ejercicio 236. Tareas pendientes.
 * 
 * Crea una aplicación similar al ejercicio 230, para gestionar tareas
 * pendientes, pero en esta ocasión apoyándote en una base de datos de SQLite.
 * No es necesario que partas de las versiones previas. No debes mantener
 * ninguna lista de datos en memoria, sino obtener en tiempo real la
 * información que el usuario te solicite. Tu aplicación debe permitir:
 * 
 * 1. Añadir una nueva tarea pendiente (id numérico, descripción y prioridad).
 * 2. Mostrar todas las tareas pendientes, ordenadas por prioridad descendente.
 * 3. Modificar una tarea, a partir de su id.
 * 4. Marcar una tarea como completada, a partir de su id (no se borrará
 * realmente, sino que se marcará como completada y no se mostrará en la
 * opción 2).
 * 5. Buscar tareas que contengan un cierto texto (en este caso, sí se
 * mostrarán tanto las completadas como las no completadas, pero indicando
 * cuáles de ellas ya se han completado).
 * 0. Salir */

// Por Marta (...)

using System;
using System.IO; // Para comprobar si el fichero existe
using System.Data.SQLite; // Para acceder a SQLite

public class Ejercicio236
{
    static SQLiteConnection conexion;

    private static void CrearBBDDSiNoExiste()
    {
        if (!File.Exists("tareas.sqlite"))
        {
            // Creamos la conexion a la BD. 
            // El Data Source contiene la ruta del archivo de la BD 
            conexion =
                  new SQLiteConnection
                  ("Data Source=personal.sqlite;Version=3;New=True;Compress=True;");
            conexion.Open();

            // Creamos la tabla
            string creacion = "CREATE TABLE tarea "
              + "(id VARCHAR(4) PRIMARY KEY, descripcion VARCHAR(40), " +
              "prioridad NUMBER(1), completada CHAR(1));";
            SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
            cmd.ExecuteNonQuery();
        }
        else
        {
            // Creamos la conexion a la BD. 
            // El Data Source contiene la ruta del archivo de la BD 
            conexion =
                  new SQLiteConnection
                  ("Data Source=personal.sqlite;Version=3;New=False;Compress=True;");
            conexion.Open();
        }
    }


    public static bool InsertarDatos()
    {
        string insercion;  // Orden de insercion, en SQL
        SQLiteCommand cmd; // Comando de SQLite
        int cantidad;      // Resultado: cantidad de datos

        Console.WriteLine("id?");
        string id = Console.ReadLine();
        Console.WriteLine("Descripción?");
        string descripcion = Console.ReadLine();
        Console.WriteLine("Prioridad? (1/5)");
        int prioridad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Completada? (S/N)");
        char completada = Convert.ToChar(Console.ReadLine().ToUpper());

        try
        {
            insercion = "INSERT INTO tarea " +
              "VALUES  ('" + id + "','" + descripcion + "'," + prioridad + ",'" + completada + "');";
            cmd = new SQLiteCommand(insercion, conexion);
            cantidad = cmd.ExecuteNonQuery();
            if (cantidad < 1)
            {
                Console.WriteLine("No se ha podido insertar");
                return false;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("No se ha podido insertar");
            Console.WriteLine("Posiblemente un código está repetido");
            return false;
        }
        return true;
    }

    public static bool AnyadirTareaPendiente(string id, string descripcion, int prioridad)
    {
        char completada = 'N';
        string insercion;  // Orden de insercion, en SQL
        SQLiteCommand cmd; // Comando de SQLite
        int cantidad;      // Resultado: cantidad de datos

        try
        {
            insercion = "INSERT INTO tarea " +
              "VALUES  ('" + id + "','" + descripcion + "'," + prioridad + ",'" + completada + "');";
            cmd = new SQLiteCommand(insercion, conexion);
            cantidad = cmd.ExecuteNonQuery();
            if (cantidad < 1)
            {
                Console.WriteLine("No se ha podido insertar");
                return false;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("No se ha podido insertar");
            Console.WriteLine("Posiblemente el id ya existe");
            return false;
        }
        return true;
    }

    public string LeerDatos()
    {
        // Lanzamos la consulta y preparamos la estructura para leer datos
        string consulta = "select * from tarea";
        string resultado = "";
        SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
        SQLiteDataReader datos = cmd.ExecuteReader();
        // Leemos los datos de forma repetitiva
        while (datos.Read())
        {
            string id = Convert.ToString(datos[0]);
            string descripcion = Convert.ToString(datos[1]);
            string prioridad = Convert.ToString(datos[2]);
            string completada = Convert.ToString(datos[3]);

            resultado += ("id: {0}, Descripción: {1}," +
                " Prioridad: {2}, Completada: {3}",
                id, descripcion, prioridad, completada);
        }
        return resultado;
    }

    public static void MostrarTareasPendientes()
    {
        // Lanzamos la consulta y preparamos la estructura para leer datos
        // y mostrarlos en orden descendente
        try
        {
            string consulta = "SELECT * FROM tarea WHERE completada='N' ORDER BY id DESC";
            string resultado = "";
            SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
            SQLiteDataReader datos = cmd.ExecuteReader();
            // Leemos los datos de forma repetitiva
            while (datos.Read())
            {
                string id = Convert.ToString(datos[0]);
                string descripcion = Convert.ToString(datos[1]);
                string prioridad = Convert.ToString(datos[2]);
                string completada = Convert.ToString(datos[3]);

                Console.WriteLine("id: {0}, Descripción: {1}," +
                    " Prioridad: {2}", id, descripcion, prioridad);
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error al mostrar las tareas pendientes: "
                + ex.Message);
        }
    }

    public static bool ModificarTareaPorId()
    {
        Console.WriteLine("Introduce el ID de la tarea que quieres modificar:");
        string id = Console.ReadLine();

        Console.WriteLine("Nueva descripción:");
        string descripcion = Console.ReadLine();

        Console.WriteLine("Nueva prioridad (1/5):");
        int prioridad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("¿Está completada? (S/N):");
        char completada = Convert.ToChar(Console.ReadLine().ToUpper());

        try
        {
            string actualizacion = "UPDATE tarea SET descripcion = '" + descripcion +
                "', prioridad = " + prioridad + ", completada = '" + completada +
                "' WHERE codigo = '" + id + "';";

            SQLiteCommand cmd = new SQLiteCommand(actualizacion, conexion);
            int cantidad = cmd.ExecuteNonQuery();

            if (cantidad < 1)
            {
                Console.WriteLine("No se ha encontrado ninguna tarea con ese ID.");
                return false;
            }
            else
            {
                Console.WriteLine("Tarea modificada correctamente.");
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al modificar la tarea: " + e.Message);
            return false;
        }
    }

    public static bool MarcarTareaComoCompletada()
    {
        Console.WriteLine("Introduce el ID de la tarea que quieres marcar como completada:");
        string id = Console.ReadLine();

        try
        {
            string actualizacion = "UPDATE tarea SET completada = 'S' WHERE codigo = '" + id + "';";
            SQLiteCommand cmd = new SQLiteCommand(actualizacion, conexion);
            int cantidad = cmd.ExecuteNonQuery();

            if (cantidad < 1)
            {
                Console.WriteLine("No se ha encontrado ninguna tarea con ese ID.");
                return false;
            }
            else
            {
                Console.WriteLine("Tarea marcada como completada.");
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al marcar la tarea: " + e.Message);
            return false;
        }
    }

    public static void BuscarTareasPorTexto()
    {
        Console.WriteLine("Introduce un texto para buscar en las descripciones:");
        string texto = Console.ReadLine();

        try
        {
            string consulta = "SELECT * FROM tarea WHERE descripcion LIKE '%" + texto + "%' ORDER BY codigo ASC;";
            SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
            SQLiteDataReader datos = cmd.ExecuteReader();

            bool hayResultados = false;

            while (datos.Read())
            {
                hayResultados = true;
                string id = Convert.ToString(datos[0]);
                string descripcion = Convert.ToString(datos[1]);
                string prioridad = Convert.ToString(datos[2]);
                string completada = Convert.ToString(datos[3]);

                string estado = completada == "S" ? "Completada" : "Pendiente";

                Console.WriteLine("id: {0}, Descripción: {1}, Prioridad: {2}, Estado: {3}",
                    id, descripcion, prioridad, estado);
            }

            if (!hayResultados)
            {
                Console.WriteLine("No se han encontrado tareas con ese texto.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al buscar tareas: " + ex.Message);
        }
    }



    private static void CerrarBBDD()
    {
        conexion.Close();
    }


    public static void Main()
    {
        Console.WriteLine("Accediendo...");
        CrearBBDDSiNoExiste();
        string opcion = "";

        while (opcion != "0")
        {
            Console.WriteLine("Escoja una opción...");
            Console.WriteLine("1.Añadir una nueva tarea pendiente(id numérico, descripción y prioridad).");
            Console.WriteLine("2.Mostrar todas las tareas pendientes, ordenadas por prioridad descendente.");
            Console.WriteLine("3.Modificar una tarea, a partir de su id.");
            Console.WriteLine("4.Marcar una tarea como completada, a partir de su id");
            Console.WriteLine("5.Buscar tareas que contengan un cierto texto");
            Console.WriteLine("0.- Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    InsertarDatos();
                    break;
                case "2":
                    MostrarTareasPendientes();
                    break;
                case "3":
                    ModificarTareaPorId();
                    break;
                case "4":
                    MarcarTareaComoCompletada();
                    break;
                case "5":
                    BuscarTareasPorTexto();
                    break;
                case "0":
                    Console.WriteLine("Saliendo... ¡Hasta pronto!");
                    CerrarBBDD();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

}
