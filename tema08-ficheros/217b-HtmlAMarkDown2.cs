/*----------------------------------------------

Damián (...)
Desarrollo de Aplicaciones Multiplataforma (DAM)
Tema 8
Ejercicio 217
Interprete HTML

217. [Tiempo máximo recomendado: 1 hora] Examen de 2015-2016, grupo presencial: Convertidor de HTML a Markdown

Debes crear un programa capaz de extraer el texto plano contenido en un fichero HTML. Partirá de un fichero que se leerá de parámetros (o se pedirá al usuario en caso de no existir parámetros) y creará un fichero con el mismo nombre y en el que la extensión ".html" (o ".htm", quizá en mayúsculas) será reemplazada por ".txt".

A partir de un fichero con un contenido como

<!DOCTYPE html>
<html>
<body>
  <h1>Título</h1>
  <p>Párrafo
  con <b>varias</b> palabras.</p>
  <ul>
    <li>Dato uno</li>
    <li>Dato dos</li>
  </ul>
</body>
</html>

Se debería generar otro con el contenido:

# Título

Párrafo 
con varias palabras.

* Dato uno
* Dato dos

Es decir: no se mostrarán cabeceras, se eliminarán los sangrados del texto, si los hay; los títulos y los párrafos tendrán a continuación una línea en blanco; los elementos de lista se precederán por asterisco y espacio; los títulos se precederán por una almohadilla; se eliminarán todas las etiquetas.

Como mejora deseable (pero que puntuará por encima del 10, sólo en caso de que el resto del ejercicio esté perfecto), los párrafos que estén formados por varias líneas deberán agruparse en una única línea y luego partirse en palabras exactas en la columna 72 o la columna anterior más cercana. Por ejemplo

<p>Este es un párrafo formado
inicialmente por tres líneas
que deberían agruparse en una
única línea para luego partirla.</p>

se convertiría en

Este es un párrafo formado inicialmente por tres líneas que deberían 
agruparse en una única línea para luego partirla.



------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class HTML
{
    static List<string> etAbiertas = new List<string>();
    static List<string> etValidas = new List<string>(["<!doctype html>", "<html>", "</html>", "<body>", "</body>", "<h1>", "</h1>", "<p>", "</p>", "<ul>", "</ul>", "<li>", "</li>"]);
    
    static void Main(string[] args)
    {
        string ficheroHTML;
        if (args.Length == 0)
        {
            Console.Write("Nombre del fichero HTML: ");
            ficheroHTML = Console.ReadLine();
        } 
        else
        {
            ficheroHTML = args[0];
        }

        if (File.Exists(ficheroHTML) && ficheroHTML.Substring(ficheroHTML.IndexOf('.')) == ".html")
        {
            string ficheroTXT = ficheroHTML.Substring(0, ficheroHTML.IndexOf('.')) + ".txt";
            try
            { 
                FileStream fLeer = File.Open(ficheroHTML, FileMode.Open);
                StreamWriter fGuardar = File.CreateText(ficheroTXT);
                
                if (ProcesarEtiqueta(fLeer)== "<!doctype html>")
                {
                    string etiqueta = "";
                    string texto = ""; 
                    bool apertura = true;
                    do
                    {   
                        etiqueta = ProcesarEtiqueta(fLeer);

                        if (etValidas.IndexOf(etiqueta) != -1)
                        {    
                            apertura = etiqueta.Substring(0, 2) != "</";

                            if (apertura)
                            {
                                texto = ProcesarTexto(fLeer);
                                ImprimmirEtiqueta(etiqueta, texto, fGuardar);
                                etAbiertas.Add(etiqueta);
                                    
                            } 
                            else
                            {
                                string ultimaAbierta = etAbiertas.Last();
                                if (ultimaAbierta.Substring(1) == etiqueta.Substring(2))
                                    etAbiertas.RemoveAt(etAbiertas.Count() - 1);
                            }
                        } 
                        else
                        {
                            Console.WriteLine("La etiqueta " + etiqueta + " no válida...");
                            fLeer.Close();
                            fGuardar.Close();
                            return;
                        }
                    } while (fLeer.Position < fLeer.Length);

                    if (etAbiertas.Count() > 0)
                    {
                        fGuardar.WriteLine("Falta etiqueta de cierre " + etAbiertas.Last() + "...");
                    }
                } 
                else
                {
                    Console.WriteLine("No es un fichero HTML interpretable...");
                }
                fLeer.Close();
                fGuardar.Close();
                Console.WriteLine("Fichero convertido a texto...");
            } catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("No tiene permisos para leer/escribir el fichero...");
            }
        } 
        else
        {
            Console.WriteLine("Fichero HTML inexistente...");
        }
    }

    static string ProcesarEtiqueta(FileStream fLeer)
    {
        StringBuilder etiqueta = new StringBuilder();
        char caracter = new char();
        do
        {
            caracter = (char)fLeer.ReadByte();
        } while (caracter != '<');

        etiqueta.Append(caracter);

        do
        {   
            caracter = (char)fLeer.ReadByte();
            etiqueta.Append(caracter);
        } while (caracter != '>');

        return etiqueta.ToString().ToLower();
    }

    static string ProcesarTexto(FileStream fLeer)
    {
        StringBuilder texto = new StringBuilder();
        char caracter =  new char();
        string etiqueta = "";
        do
        {
            do
            {
                caracter = (char)fLeer.ReadByte();
                if ((caracter != '<') && (caracter != '\n'))
                    texto.Append(caracter);
            } while (caracter != '<');
            
            fLeer.Seek(-1, SeekOrigin.Current);

            etiqueta = ProcesarEtiqueta(fLeer);
            
            if (etValidas.IndexOf(etiqueta) != -1)
                fLeer.Seek(-etiqueta.Length, SeekOrigin.Current);
            
        } while (etValidas.IndexOf(etiqueta) == -1);

        return texto.ToString();
    }

    static void ImprimmirEtiqueta(string etiqueta, string texto, StreamWriter fGuardar)
    {
        switch (etiqueta)
        {
            case "<html>":
                break;
            case "<body>":
                break;
            case "<h1>":
                etiquetaH1(texto, fGuardar);
                break;
            case "<p>":
                etiquetaP(texto, fGuardar);
                break;
            case "<li>":
                etiquetaLI(texto, fGuardar);
                break;
        }
    }

    static void etiquetaH1(string texto, StreamWriter fGuardar)
    {
        fGuardar.WriteLine("# " + texto);
        fGuardar.WriteLine();
    }

    static void etiquetaP(string texto, StreamWriter fGuardar)
    {
        int cantLetras = 0;
        string[] palabras = texto.Split();
        foreach(string palabra in palabras)
        {
            if (cantLetras + palabra.Length > 71)
            {
                fGuardar.WriteLine();
                cantLetras = 0;
            }

            fGuardar.Write(palabra + " ");
            cantLetras += palabra.Length;
        }
        fGuardar.Write("\n\n");
    }

    static void etiquetaLI(string texto, StreamWriter fGuardar)
    {
        if (etAbiertas[etAbiertas.Count() - 1] == "<ul>")
        {   
            fGuardar.WriteLine("* " + texto);
            fGuardar.WriteLine();
        }
    }
}
