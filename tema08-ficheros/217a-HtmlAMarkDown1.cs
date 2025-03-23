/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 217. Convertidor HTML a Markdown.
 * 
 * [Tiempo máximo recomendado: 1 hora] Examen de 2015-2016, grupo presencial:
 * Convertidor de HTML a Markdown
 * Debes crear un programa capaz de extraer el texto plano contenido en un
 * fichero HTML. Partirá de un fichero que se leerá de parámetros (o se pedirá
 * al usuario en caso de no existir parámetros) y creará un fichero con el
 * mismo nombre y en el que la extensión ".html" (o ".htm", quizá en
 * mayúsculas) será reemplazada por ".txt".
 * 
 * A partir de un fichero con un contenido como
 * <!DOCTYPE html>
 * <html>
 * <body>
 *   <h1>Título</h1>
 *   <p>Párrafo
 *   con <b>varias</b> palabras.</p>
 *   <ul>
 *     <li>Dato uno</li>
 *     <li>Dato dos</li>
 *   </ul>
 * </body>
 * </html>
 * 
 * Se debería generar otro con el contenido:
 * # Título
 * 
 * Párrafo 
 * con varias palabras.
 * 
 * * Dato uno
 * 
 * * Dato dos
 * 
 * Es decir: no se mostrarán cabeceras, se eliminarán los sangrados del texto,
 * si los hay; los títulos y los párrafos tendrán a continuación una línea en
 * blanco; los elementos de lista se precederán por asterisco y espacio; los
 * títulos se precederán por una almohadilla; se eliminarán todas las
 * etiquetas.
 * 
 * Como mejora deseable (pero que puntuará por encima del 10, sólo en caso de
 * que el resto del ejercicio esté perfecto), los párrafos que estén formados
 * por varias líneas deberán agruparse en una única línea y luego partirse en
 * palabras exactas en la columna 72 o la columna anterior más cercana. Por
 * ejemplo
 * 
 * <p>Este es un párrafo formado
 * inicialmente por tres líneas
 * que deberían agruparse en una
 * única línea para luego partirla.</p>
 * 
 * se convertiría en
 * 
 * Este es un párrafo formado inicialmente por tres líneas que deberían
 * agruparse en una única línea para luego partirla. */

using System;
using System.IO;

class ConvertidorHTMLMarkdown {

    static void Main(string[] args) {

        string nombreOrigen;
        string nombreDestino;

        // Linea de comandos o entrada por consola.
        if (args.Length == 0) {
            Console.Write("Introduce nombre del archivo: ");
            nombreOrigen = Console.ReadLine();
        } else {
            nombreOrigen = args[0];
        }

        // Nombre del archivo a crear.
        int indicePunto = nombreOrigen.LastIndexOf('.');
        if (indicePunto > 0) {
            nombreDestino = nombreOrigen.Substring(0, indicePunto) + ".txt";
        } else {
            nombreDestino = nombreOrigen + ".txt";
        }

        // Proceso de lineas.
        if (File.Exists(nombreOrigen)) {
            try {
                StreamReader leer = new StreamReader(nombreOrigen);
                StreamWriter escribir = new StreamWriter(nombreDestino);

                string linea;
                do {
                    linea = leer.ReadLine();

                    if (linea != null && linea != "") {
                        if (!(linea.Contains("<!DOCTYPE html>") ||
                              linea.Contains("<html>") ||
                              linea.Contains("<body>") ||
                              linea.Contains("<ul>") ||
                              linea.Contains("</ul>") ||
                              linea.Contains("</body>") ||
                              linea.Contains("</html>"))) {

                            linea = linea.Trim();
                            linea = linea.Replace("<h1>", "# ");
                            linea = linea.Replace("</h1>", "\r\n");
                            linea = linea.Replace("<p>", "");
                            linea = linea.Replace("</p>", "\r\n");
                            linea = linea.Replace("<b>", "");
                            linea = linea.Replace("</b>", "");
                            linea = linea.Replace("<ul>", "");
                            linea = linea.Replace("</ul>", "");
                            linea = linea.Replace("<li>", "* ");
                            linea = linea.Replace("</li>", "\r\n");

                            escribir.WriteLine(linea);
                        }

                    }

                } while (linea != null);

                escribir.Close();
                leer.Close();
                Console.WriteLine("Archivo creado: " + nombreDestino);

            } catch (FileNotFoundException) {
                Console.WriteLine("Archivo no encontrado.");
            } catch (PathTooLongException) {
                Console.WriteLine("Archivo demasiado largo.");
            } catch (IOException) {
                Console.WriteLine("Error de lectura y/o escritura");
            } catch (Exception error) {
                Console.WriteLine("Error: " + error.Message);
            }

        } else {
            Console.WriteLine("No se ha encontrado el archivo.");
        }

    }

}
