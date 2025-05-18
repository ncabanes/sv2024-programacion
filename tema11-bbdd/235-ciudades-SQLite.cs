/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 235. Ciudades SQLite.
 * 
 * Crea una aplicación (relativamente) parecida al ejercicio 189, para
 * gestionar una lista de ciudades (nombre, país, población), pero en esta
 * ocasión apoyándote en una base de datos de SQLite. No es necesario que
 * partas de las versiones previas. No debes mantener ninguna lista de datos
 * en memoria, sino obtener en tiempo real la información que el usuario te
 * solicite. Tu aplicación debe permitir las siguientes opciones:
 * 
 * 1 - Añadir una nueva ciudad.
 * 2 - Mostrar todas las ciudades (ordenadas)
 * 3 - Buscar ciudades que contengan un determinado texto en su nombre o el
 * nombre del país (ordenadas).
 * 4 - Modificar una ciudad, a partir de su nombre.
 * 5 - Eliminar una ciudad, a partir de su nombre.
 * S - Salir */

using System;
using System.Data.SQLite;
using System.IO;
using System.Threading;

class Ciudad {
    public string Nombre { get; set; }
    public string Pais { get; set; }
    public int Poblacion { get; set; }

    public Ciudad() { }

    public Ciudad(string nombre, string pais, int poblacion) {
        Nombre = nombre;
        Pais = pais;
        Poblacion = poblacion;
    }
    public override string ToString() {
        return Nombre + " - " + Pais + " (población: " + Poblacion + ")";
    }
}

// ---------------------------------------------------------------------------

class GestorDeCiudades {
    private const string RUTABD = "ciudades.sqlite";
    private readonly SQLiteConnection conexion;

    public GestorDeCiudades() {
        if (!File.Exists(RUTABD)) {
            SQLiteConnection.CreateFile(RUTABD);
            Console.WriteLine("Base de datos creada: " + RUTABD);
            Thread.Sleep(2000);
        } else {
            Console.Write("Base de datos ya existente: " + RUTABD);
            Thread.Sleep(2000);
        }

        conexion = new SQLiteConnection(
            "Data Source=" + RUTABD + ";Version=3;New=True;Compress=True;");
        conexion.Open();

        CrearTabla();
    }

    private void CrearTabla() {
        string creacion = @" 
            CREATE TABLE IF NOT EXISTS ciudades (
                nombre     VARCHAR(30),
                pais       VARCHAR(30),
                poblacion  INTEGER
            );";

        SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
        cmd.ExecuteNonQuery();
        // Libera recursos.
        cmd.Dispose();
    }

    public bool InsertarDatos(string nombre, string pais, int poblacion) {
        try {
            // Escapamos posibles comillas simples para no romper la consulta,
            // si se introduce un nombre con apóstrofo (ejemplo: O'Connor).
            nombre = nombre.Replace("'", "''");
            pais = pais.Replace("'", "''");

            string insercion =
                "INSERT INTO ciudades (nombre, pais, poblacion) " +
                "VALUES ('" + nombre + "','" + pais + "'," + poblacion + ");";

            SQLiteCommand cmd = new SQLiteCommand(insercion, conexion);
            int filasAfectadas = cmd.ExecuteNonQuery();
            // Libera recursos.
            cmd.Dispose();

            return filasAfectadas > 0;
        } catch (Exception error) {
            Console.WriteLine("Error al insertar ciudad: " + error.Message);
            return false;
        }
    }

    public void Mostrar() {
        string sql = "SELECT * FROM ciudades ORDER BY pais;";

        SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
        SQLiteDataReader reader = cmd.ExecuteReader();

        int idx = 1;
        while (reader.Read()) {
            string nombre = reader[0].ToString();
            string pais = reader[1].ToString();
            int poblacion = Convert.ToInt32(reader[2]);
            Console.WriteLine
                (idx + ". " + nombre + " - " + pais + " - " + poblacion);
            idx++;
        }

        if (idx == 1) {
            Console.WriteLine("No hay ciudades en el registro.");
        }

        reader.Close();
        cmd.Dispose();
    }

    public Ciudad Obtener(int indiceBasadoEnCero) {
        string sql = "SELECT * FROM ciudades ORDER BY pais";
        SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
        SQLiteDataReader reader = cmd.ExecuteReader();

        int contador = 0;
        Ciudad resultado = null;

        while (reader.Read()) {
            if (contador == indiceBasadoEnCero) {
                string nombre = reader[0].ToString();
                string pais = reader[1].ToString();
                int poblacion = Convert.ToInt32(reader[2]);
                resultado = new Ciudad(nombre, pais, poblacion);
            }
            contador++;
        }

        reader.Close();
        cmd.Dispose();
        return resultado;
    }

    public void Buscar(string texto) {
        texto = texto.Replace("'", "''");
        string consulta = "SELECT * FROM ciudades " +
            "WHERE nombre LIKE '%" + texto +
            "%' OR pais LIKE '%" + texto + "%' " +
            "ORDER BY pais;";

        SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
        SQLiteDataReader reader = cmd.ExecuteReader();

        bool encontrado = false;
        while (reader.Read()) {
            string nombre = reader[0].ToString();
            string pais = reader[1].ToString();
            int poblacion = Convert.ToInt32(reader[2]);
            Console.WriteLine("Ciudad: " + nombre + " - " +
                "País: " + pais + " - " +
                "Población: " + poblacion);
            encontrado = true;
        }

        if (!encontrado) {
            Console.WriteLine("No se ha encontrado coincidencias.");
        }
        reader.Close();
        cmd.Dispose();
    }

    public bool Modificar(string original, Ciudad datos) {
        string modificado = original.Replace("'", "''");
        string nombreModificado = datos.Nombre.Replace("'", "''");
        string paisModificado = datos.Pais.Replace("'", "''");
        int poblacionModificado = datos.Poblacion;

        string sql =
            "UPDATE ciudades SET " +
            "nombre='" + nombreModificado + "', " +
            "pais='" + paisModificado + "', " +
            "poblacion=" + poblacionModificado + " " +
            "WHERE nombre='" + modificado + "';";

        SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
        int filasAfectadas = cmd.ExecuteNonQuery();
        cmd.Dispose();

        return filasAfectadas > 0;
    }

    public bool Eliminar(string nombre) {
        string ciudadEliminar = nombre.Replace("'", "''");
        string sql = "DELETE FROM ciudades WHERE nombre='" +
            ciudadEliminar + "';";
        SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
        int filas = cmd.ExecuteNonQuery();
        cmd.Dispose();
        return filas > 0;
    }

    public void Cerrar() {
        conexion.Close();
    }
}

// ---------------------------------------------------------------------------

class ListaDeCiudades {
    static void Main() {
        const string SALIR = "S";
        const string ANYADIR = "1";
        const string MOSTRAR = "2";
        const string BUSCAR = "3";
        const string MODIFICAR = "4";
        const string ELIMINAR = "5";

        GestorDeCiudades gestor = new GestorDeCiudades();

        string opcion;
        bool terminar = false;

        do {
            opcion = MostrarMenuPrincipal
                (SALIR, ANYADIR, MOSTRAR, BUSCAR, MODIFICAR, ELIMINAR);

            switch (opcion) {
                case ANYADIR:
                    Anyadir(gestor);

                    LimpiarPantalla();
                    break;

                case MOSTRAR:
                    gestor.Mostrar();
                    LimpiarPantalla();
                    break;

                case BUSCAR:
                    Console.Write("Texto a buscar: ");
                    string textoBuscar = Console.ReadLine();
                    gestor.Buscar(textoBuscar);

                    LimpiarPantalla();
                    break;

                case MODIFICAR:
                    Modifiar(gestor);

                    LimpiarPantalla();
                    break;

                case ELIMINAR:
                    Eliminar(gestor);

                    LimpiarPantalla();
                    break;

                case SALIR:
                    Console.WriteLine("Saliendo del programa.");
                    terminar = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (!terminar);
    }

    private static string MostrarMenuPrincipal
        (string SALIR, string ANYADIR, string MOSTRAR, string BUSCAR,
        string MODIFICAR, string ELIMINAR) {
        string opcion;
        Console.Clear();
        Console.WriteLine(ANYADIR + ". Añadir ciudad.");
        Console.WriteLine(MOSTRAR + ". Mostrar todas las ciudades.");
        Console.WriteLine(BUSCAR + ". Buscar una ciudad.");
        Console.WriteLine(MODIFICAR + ". Modificar una ciudad.");
        Console.WriteLine(ELIMINAR + ". Eliminar una ciudad.");
        Console.WriteLine(SALIR + ". Salir.");
        Console.WriteLine();
        Console.Write("Introduce opción: ");
        opcion = Console.ReadLine().Trim().ToUpper();
        return opcion;
    }

    private static void Eliminar(GestorDeCiudades gestor) {
        if (gestor.Obtener(0) == null) {
            Console.WriteLine("No hay registros en la BBDD.");
        } else {
            Console.WriteLine("Registros en la BBDD:");
            gestor.Mostrar();
            Console.WriteLine();

            Console.Write("Introduce número de registro a eliminar: ");
            int numRegistroEliminar =
            Convert.ToInt32(Console.ReadLine());
            numRegistroEliminar--;

            Ciudad eliminar = gestor.Obtener(numRegistroEliminar);

            if (eliminar != null) {
                Console.Write("Confirmas eliminar (S/N): ");
                string confirmar = Console.ReadLine().Trim().ToUpper();
                if (confirmar == "S") {
                    if (gestor.Eliminar(eliminar.Nombre))
                        Console.WriteLine("Ciudad eliminada correctamente.");
                    else
                        Console.WriteLine("Error al eliminar la ciudad.");
                } else {
                    Console.WriteLine("Operación cancelada.");
                }
            } else {
                Console.WriteLine("Número de registro erróneo.");
            }

        }
    }

    private static void Modifiar(GestorDeCiudades gestor) {
        if (gestor.Obtener(0) == null) {
            Console.WriteLine("No hay registros en la BBDD.");
        } else {
            Console.WriteLine("Registros en la BBDD:");
            gestor.Mostrar();
            Console.WriteLine();

            Console.Write("Introduce número de registro: ");
            int numRegModificar = Convert.ToInt32(Console.ReadLine());
            numRegModificar--;

            Ciudad original = gestor.Obtener(numRegModificar);
            if (original != null) {
                string nombreOriginal = original.Nombre;

                Console.Write("Nuevo nombre [" + original.Nombre + "]: ");
                string nuevoNombre = Console.ReadLine();
                if (nuevoNombre == "") {
                    nuevoNombre = original.Nombre;
                }

                Console.Write("Nuevo país [" + original.Pais + "]: ");
                string nuevoPais = Console.ReadLine();
                if (nuevoPais == "") {
                    nuevoPais = original.Pais;
                }

                Console.Write("Nueva población [" + original.Poblacion + "]: ");
                string entrada = Console.ReadLine();
                int nuevaPoblacion;
                if (entrada == "") {
                    nuevaPoblacion = original.Poblacion;
                } else {
                    nuevaPoblacion = Convert.ToInt32(entrada);
                }

                Ciudad modificada =
                    new Ciudad(nuevoNombre, nuevoPais, nuevaPoblacion);

                if (gestor.Modificar(nombreOriginal, modificada)) {
                    Console.WriteLine("Ciudad modificada correctamente.");
                } else {
                    Console.WriteLine("Error al modificar la ciudad.");
                }
            } else {
                Console.WriteLine("Número de registro erróneo");
            }
        } 
    }

    private static void Anyadir(GestorDeCiudades gestor) {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("País: ");
        string pais = Console.ReadLine();
        Console.Write("Población: ");
        int poblacion = Convert.ToInt32(Console.ReadLine());

        gestor.InsertarDatos(nombre, pais, poblacion);
        Console.WriteLine("Ciudad añadida correctamente.");
    }

    private static void LimpiarPantalla() {
        Console.WriteLine();
        Console.Write("Pulsa \"Enter\" para continuar ... ");
        Console.ReadKey();
        Console.Clear();
    }
}
