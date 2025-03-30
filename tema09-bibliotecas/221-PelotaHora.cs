/* Nombre: Andrés (...)
 * Curso: 1º DAM. Semipresencial 2024-2025 */

/* Ejercicio 221. Pelota rebotando con hora actual.
 * 
 * Crea un programa que muestre la hora actual en la esquina superior derecha
 * de la consola, en color gris claro, con fondo azul oscuro, actualizando
 * cada segundo, mientras una "pelota" (una letra O) de color cian rebota en
 * la pantalla. La pelota comenzará en unas coordenadas al azar de la pantalla.
 * Debe detenerse cuando el usuario pulse Intro. */

using System;
using System.Threading;

class PelotaHora {

    static void Main() {

        char pelota = 'O';
        int moverX = 1;
        int moverY = -1;

        Random random = new Random();

        // Ancho y alto actuales del buffer para ubicar la pelota.
        int x = random.Next(1, Console.BufferWidth - 1);
        int y = random.Next(1, Console.BufferHeight - 1);

        bool terminar = false;

        do {

            Console.Clear();

            // Dibuja la pelota en color cian.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(x, y);
            Console.Write(pelota);
            Console.ResetColor();

            // Obtiene la hora actual.
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            DateTime fecha = DateTime.Now;
            Console.SetCursorPosition(100, 0);
            Console.Write(fecha);

            // Tiempo animación.
            Thread.Sleep(250);

            // Posición de la pelota.
            x += moverX;
            y += moverY;

            // Rebote en la horizontal.
            if (x <= 0 || x >= Console.BufferWidth - 1) {
                moverX *= -1;
            }

            // Rebote en la vertical.
            if (y <= 0 || y >= Console.BufferHeight - 1) {
                moverY *= -1;
            }

            // Intro salir.
            if (Console.KeyAvailable &&
                Console.ReadKey(true).Key == ConsoleKey.Enter) {
                terminar = true;
            }

        } while (!terminar);

    }

}
