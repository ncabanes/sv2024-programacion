/* MARTA (...)
 * 
 * Crea una nueva versión del ejercicio 186 (lista de struct), 
 * partiendo de la versión oficial, en la que guardes datos 
 * tras cada cambio (añadir, modificar, borrar) usando StreamWriter 
 * y cargues datos al comenzar la ejecución (si existen) con 
 * StreamReader. Como son varios datos distintos para cada registro 
 * (nombre y país), deberás escribirlos en una misma línea usando 
 * un separador poco habitual, como "@" o "#". Tu lectura deberá 
 * adaptarse a la forma en que hayas decidido guardar los datos. 
 * Debes gestionar los posibles errores de forma adecuada.
 */

using System;
using System.Collections.Generic;
using System.IO;

class CiudadesPaisesStruct
{
    struct TipoCapital
    {
        public string capital;
        public string pais;
    }

    static void Main()
    {
        const string SALIR = "S", AGREGAR = "1", VER = "2", BUSCAR = "3",
            MODIFICAR = "4", BORRAR = "5";
        List<TipoCapital> capitales = Cargar();
        bool terminar = false;

        do
        {
            Console.WriteLine(" *** MENÚ DE USUARIO *** ");
            Console.WriteLine();
            Console.WriteLine(AGREGAR + ". Añadir capital y pais.");
            Console.WriteLine(VER + ". Ver capitales y paises.");
            Console.WriteLine(BUSCAR + ". Buscar capitales ó paises.");
            Console.WriteLine(MODIFICAR + ". Modificar capitales ó paises.");
            Console.WriteLine(BORRAR + ". Borrar capitales y paises.");
            Console.WriteLine(SALIR + ". Terminar el programa.");
            Console.WriteLine();
            Console.Write("Introduce una opción: ");
            string opcion = Console.ReadLine().ToUpper();
            Console.WriteLine();

            switch (opcion)
            {
                case AGREGAR:
                    TipoCapital nuevaCapital;
                    Console.Write("Capital: ");
                    nuevaCapital.capital = Console.ReadLine();
                    Console.Write("País: ");
                    nuevaCapital.pais = Console.ReadLine();

                    if (nuevaCapital.capital != "" || nuevaCapital.pais != "")
                    {
                        capitales.Add(nuevaCapital);
                    }
                    Guardar(capitales);
                    LimpiarPantalla();
                    break;

                case VER:
                    Console.WriteLine("Mostrando datos: ");
                    foreach (TipoCapital c in capitales)
                    {
                        Console.WriteLine(c.capital + " -- " + c.pais);
                    }
                    LimpiarPantalla();
                    break;

                case BUSCAR:
                    bool encontrado = false;
                    Console.Write("Introduce texto a buscar: ");
                    string textoBuscar = Console.ReadLine().ToLower();

                    for (int i = 0; i < capitales.Count; i++)
                    {
                        if (capitales[i].capital.ToLower()
                                .Contains(textoBuscar)
                                || capitales[i].pais.ToLower()
                                .Contains(textoBuscar))
                        {
                            Console.WriteLine((i + 1) + ". "
                                + capitales[i].capital + " -- "
                                + capitales[i].pais);
                            encontrado = true;
                        }
                    }
                    if (!encontrado)
                        Console.WriteLine("No encontrado");
                    LimpiarPantalla();
                    break;

                case MODIFICAR:
                    TipoCapital capitalModificar;
                    Console.Write("Introduce posición a modificar: ");
                    int numModificar = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Introduce nueva capital: ");
                    capitalModificar.capital = Console.ReadLine();
                    Console.Write("Introduce nuevo país: ");
                    capitalModificar.pais = Console.ReadLine();

                    capitales[numModificar - 1] = capitalModificar;

                    Guardar(capitales);
                    LimpiarPantalla();
                    break;

                case BORRAR:
                    Console.Write("Indica posicion a borrar: ");
                    int numBorrar = Convert.ToInt32(Console.ReadLine());
                    capitales.RemoveAt(numBorrar - 1);
                    LimpiarPantalla();
                    Guardar(capitales);
                    break;

                case SALIR:
                    Console.WriteLine("Bye bye ... ");
                    terminar = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (!terminar);
        Guardar(capitales);
    }

    private static void Guardar(List<TipoCapital> capitales)
    {
        try
        {
            StreamWriter fichero = File.CreateText("capitales.txt");
            foreach(TipoCapital c in capitales)
            {
                fichero.WriteLine(c.capital + "#" + c.pais);
            }
            fichero.Close();
        }
        catch(PathTooLongException)
        {
            Console.WriteLine("No guardado, ruta demasiado larga");
        }
        catch (IOException)
        {
            Console.WriteLine("No guardado, ¿hay permisos?");
        }
        catch (Exception)
        {
            Console.WriteLine("No guardado, problema indeterminado");
        }
    }

    private static List<TipoCapital> Cargar()
    {
        List<TipoCapital> capitales = new List<TipoCapital>();
        if(File.Exists("capitales.txt"))
        {
            try
            {
                string linea;
                StreamReader fichero = File.OpenText("capitales.txt");

                do
                {
                    linea = fichero.ReadLine();
                    if(linea != null)
                    {
                        string[] fragmentos = linea.Split('#');
                        TipoCapital nuevaCapital;
                        nuevaCapital.capital = fragmentos[0];
                        nuevaCapital.pais = fragmentos[1];
                        capitales.Add(nuevaCapital);
                    }
                }
                while (linea != null);

                fichero.Close();
            }
            catch(PathTooLongException)
            {
                Console.WriteLine("No cargado, ruta demasiado larga");
            }
            catch (IOException)
            {
                Console.WriteLine("No cargado, ¿hay permisos?");
            }
            catch (Exception)
            {
                Console.WriteLine("No cargado, problema indeterminado");
            }
        }
        return capitales;
    }

    private static void LimpiarPantalla()
    {
        Console.WriteLine();
        Console.WriteLine("Pulsa una tecla para continuar ... ");
        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}
