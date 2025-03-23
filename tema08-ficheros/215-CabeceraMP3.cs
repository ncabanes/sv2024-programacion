/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 215. Mostrar información de archivo MP3.
 * 
 * Crea un programa que muestre la información almacenada en un archivo MP3
 * (que tenga una cabecera en formato "ID3 TAG V1"): título, artista, álbum,
 * año. Deberás comprobar el contenido de los últimos 128 bytes del fichero.
 * En caso de tratarse de un MP3 que tenga cabecera en dicho formato, deberías
 * encontrar la siguiente secuencia de bytes a partir de esa posición:
 * 
 * - Los caracteres "TAG" (3 bytes)
 * - Título: 30 caracteres (30 bytes).
 * - Artista: 30 caracteres (ídem).
 * - Álbum: 30 caracteres (ídem).
 * - Año: 4 caracteres.
 * - Un comentario: 30 caracteres.
 * - Género (musical): un byte.
 * 
 * Todas las etiquetas usan caracteres ASCII (terminados en caracteres nulos
 * o quizá en espacios, según con qué aplicación se hayan creado), excepto el
 * género, que es un número entero almacenado en un único byte. Tienes un
 * fichero de ejemplo "mp3.mp3" compartido en Aules y GitHub. */

using System;
using System.IO;

class MP3 {

    static void Main(string[] args) {

        string nombreArchivo;

        if (args.Length == 0) {
            Console.Write("Nombre del archivo: ");
            nombreArchivo = Console.ReadLine();
        } else {
            nombreArchivo= args[0];
        }

        if (File.Exists(nombreArchivo)) {

            try {
                FileStream archivo = 
                    new FileStream(nombreArchivo, FileMode.Open);

                if (archivo.Length < 128) {
                    Console.WriteLine
                        ("Archivo con cabecera diferente a ID3V1");
                } else {
                    // Posición a 128 bytes del final.
                    archivo.Seek(-128, SeekOrigin.End);

                    byte[] datos = new byte[128];
                    int leidos = archivo.Read(datos, 0, 128);

                    // TAG.
                    if ((char)datos[0] != 'T' ||
                        (char)datos[1] != 'A' ||
                        (char)datos[2] != 'G') {
                        Console.WriteLine("Archivo sin TAG ID3V1");
                    } else {
                        // Título 30 bytes desde la pos 3 a 32.
                        string titulo = "";
                        int posIniTitulo = 3;
                        int posFinTitulo = 33;
                        for (int i = posIniTitulo; i < posFinTitulo; i++) {
                            titulo += (char)datos[i];
                        }

                        // Artista 30 bytes desde la pos 33 a 62.
                        string artista = "";
                        int posIniArtista = 33;
                        int posFinArtista = 62;
                        for (int i = posIniArtista; i < posFinArtista; i++) {
                            artista += (char)datos[i];
                        }

                        // Album 30 bytes desde la pos 63 a 92.
                        string album = "";
                        int posIniAlbum = 63;
                        int posFinAlbum = 92;
                        for (int i = posIniAlbum; i < posFinAlbum; i++) {
                            album += (char)datos[i];
                        }

                        // Año 4 bytes desde la pos 93 a 96.
                        string anyo = "";
                        int posIniAnyo = 93;
                        int posFinAnyo = 96;
                        for (int i = posIniAnyo; i < posFinAnyo; i++) {
                            anyo += (char)datos[i];
                        }

                        // Comentario 30 bytes desde la pos 97 a 126.
                        string comentario = "";
                        int posIniComentario = 97;
                        int posFinComentario = 126;
                        for (int i = posIniComentario; i < posFinComentario; i++) {
                            comentario += (char)datos[i];
                        }

                        // Género 1 byte  en la pos 127.
                        byte genero = datos[127];

                        // Información a mostrar.
                        Console.WriteLine("Título: " + titulo);
                        Console.WriteLine("Artista: " + artista);
                        Console.WriteLine("Álbum: " + album);
                        Console.WriteLine("Año: " + anyo);
                        Console.WriteLine("Comentario: " + comentario);
                        Console.WriteLine("Género: " + genero);

                    }

                }

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
            Console.WriteLine("Archivo no encontrado.");
        }

    }

}
