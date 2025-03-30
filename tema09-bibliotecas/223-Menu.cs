/* MARTA (...)
 * 
 * Crea un menú en consola, que permita al usuario lanzar 
 * 8 aplicaciones prefijadas, pulsando las teclas del 1 al 
 * 8, o salir pulsando ESC. Por ejemplo, 1 podría lanzar 
 * Geany y 2 podría lanzar el navegador de Internet.
 * */

using System;
using System.Diagnostics;

class Ejercicio223
{
    public static void MostrarMenu()
    {
        Console.WriteLine("ELIGE EL PROGRAMA A EJECUTAR: ");
        Console.WriteLine("1. Geany");
        Console.WriteLine("2. Google Chrome");
        Console.WriteLine("3. Spotify");
        Console.WriteLine("4. Visual Studio");
        Console.WriteLine("5. Wireshark");
        Console.WriteLine("6. Paint");
        Console.WriteLine("7. Notepad");
        Console.WriteLine("8. Git for Windows");
        Console.WriteLine("ESC. Salir ");
    }

    static void Main()
    {
        bool salir = false;
        while (!salir)
        {
            MostrarMenu();

            ConsoleKeyInfo tecla = Console.ReadKey(true);

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("Lanzando Geany...");
                    Console.WriteLine();
                    Process.Start("geany.exe");
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("Lanzando Google Chrome...");
                    Process.Start("chrome.exe");
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("Lanzando Spotify...");
                    Console.WriteLine();
                    Process.Start("spotify.exe");
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.WriteLine("Lanzando Visual Studio...");
                    Console.WriteLine();
                    Process.Start("VSWebLauncher.exe");
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.WriteLine("Lanzando Wireshark...");
                    Console.WriteLine();
                    Process.Start("Wireshark.exe");
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Console.WriteLine("Lanzando Paint...");
                    Console.WriteLine();
                    Process.Start("paint.exe");
                    break;

                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Console.WriteLine("Lanzando Notepad...");
                    Console.WriteLine();
                    Process.Start("notepad.exe");
                    break;

                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    Console.WriteLine("Lanzando Git for Windows...");
                    Console.WriteLine();
                    Process.Start("git.exe");
                    break;

                case ConsoleKey.Escape:
                    salir = true;
                    Console.WriteLine("Saliendo...");
                    Console.WriteLine();
                    break; ; // Salir del programa
            }
        }
    }
}

