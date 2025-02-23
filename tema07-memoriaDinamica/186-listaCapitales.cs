/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 186. Capitales - Paises "Struct".
 * 
 * Crea un programa parecido al anterior, pero que no guarde frases
 * individuales, sino capitales de países del mundo (para cada capital se
 * guardarán dos datos: el nombre de la capital y el nombre del país).
 * 
 * Mostrará un menú que permita al usuario introducir una capital, ver todas
 * ellas, buscar las que contengan un cierto texto (en el nombre de la ciudad
 * o en el país), modificar una de ellas (indicando su posición) o borrar una
 * de ellas (a partir de su posición). */

using System;
using System.Collections.Generic;

class CiudadesPaisesStruct {

    struct TipoCapital {
        public string capital;
        public string pais;
    }
    static void Main() {

        const string SALIR = "S", AGREGAR = "1", VER = "2", BUSCAR = "3", 
            MODIFICAR = "4", BORRAR = "5";
        List<TipoCapital> capitales = new List<TipoCapital> ();
        bool terminar = false;

        do {

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

            switch (opcion) {
                case AGREGAR:
                    TipoCapital nuevaCapital;
                    Console.Write("Capital: ");
                    nuevaCapital.capital = Console.ReadLine();
                    Console.Write("País: ");
                    nuevaCapital.pais = Console.ReadLine();

                    if (nuevaCapital.capital != "" || nuevaCapital.pais != "") {
                        capitales.Add(nuevaCapital);
                    }

                    LimpiarPantalla();
                    break;

                case VER:
                    Console.WriteLine("Mostrando datos: ");
                    foreach (TipoCapital c in capitales) {
                        Console.WriteLine(c.capital + " -- " + c.pais);
                    }
                    LimpiarPantalla();
                    break;

                case BUSCAR:
                    bool encontrado = false;
                    Console.Write("Introduce texto a buscar: ");
                    string textoBuscar = Console.ReadLine().ToLower();

                    for (int i = 0; i < capitales.Count; i++) {
                        if (capitales[i].capital.ToLower()
                                .Contains(textoBuscar) 
                                || capitales[i].pais.ToLower()
                                .Contains(textoBuscar)) {
                            Console.WriteLine((i+1) + ". " 
                                + capitales[i].capital + " -- " 
                                + capitales[i].pais);
                            encontrado = true;
                        }
                    }
                    if (! encontrado)
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

                    LimpiarPantalla();
                    break;

                case BORRAR:
                    Console.Write("Indica posicion a borrar: ");
                    int numBorrar = Convert.ToInt32(Console.ReadLine());
                    capitales.RemoveAt(numBorrar - 1);
                    LimpiarPantalla();
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


    }

    private static void LimpiarPantalla() {
        Console.WriteLine();
        Console.WriteLine("Pulsa una tecla para continuar ... ");
        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}
