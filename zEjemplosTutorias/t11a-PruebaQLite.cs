
using System.Data.SQLite;

class Program
{
    static void Main(string[] args)
    {
        SQLiteConnection conexion =
            new SQLiteConnection("Data Source=amigos.dat; Version=3;");
        conexion.Open();

        string creacion = "create table if not exists amigos ("+
            "id numeric(3) primary key, "
+           "nombre varchar(40)," +
            "direccion varchar(50));";
        SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
        cmd.ExecuteNonQuery();


        bool terminado = false;
        do
        {
            Console.WriteLine("1- Añadir");
            Console.WriteLine("2- Mostrar todos los datos");
            Console.WriteLine("0- Salir");
            string respuesta = Console.ReadLine();
            switch (respuesta)
            {
                case "1":
                    Console.Write("Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Dirección: ");
                    string direccion = Console.ReadLine();
                    string insercion = "INSERT INTO amigos VALUES" +
                        "(" + id + ",'"+nombre+
                        "','" + direccion +"');";
                    cmd = new SQLiteCommand(insercion, conexion);
                    int cantidad = cmd.ExecuteNonQuery();
                    if (cantidad < 1)
                        Console.WriteLine("Inserción fallida");
                    break;

                case "2":
                    string consulta = "select * from amigos order by nombre";
                    cmd = new SQLiteCommand(consulta, conexion);
                    SQLiteDataReader cursor = cmd.ExecuteReader();
                    while (cursor.Read())
                    {
                        int idMostrar = Convert.ToInt32(cursor["id"]);
                        string nombreMostrar = Convert.ToString(cursor["nombre"]);
                        string direccionMostrar = Convert.ToString(cursor["direccion"]);
                        
                        Console.WriteLine(idMostrar + " - " + nombreMostrar +
                            " - " + direccionMostrar);
                    }
                    break;
                
                case "0":
                    terminado = true; 
                    break;
            }
        }
        while (!terminado);
        conexion.Close();
    }
}

