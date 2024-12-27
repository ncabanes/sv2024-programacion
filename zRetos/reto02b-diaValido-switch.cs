/*
Reto 02: Día válido

Problema a resolver

No queda muy serio hablar del "40 de mayo". Por eso, nos han pedido un 
programa que valide si un cierto número de día existe (o al menos puede 
existir, en el caso del 29 de febrero) o bien si no puede existir.

Datos de entrada

La primera línea de entrada contendrá un número, que indica cuantos 
casos deberás procesar. Cada caso estará formado por dos números en una 
misma, ambos entre el 1 el 100, separados por un único espacio en 
blanco. El primer número será el número de día a revisar, y el segundo 
será el número de mes. Tu programa debe responder escribiendo el texto 
"Puede existir" o "No puede existir", según corresponda.

Ejemplo de entrada

8
1 1
32 1
13 13
31 12
29 2
31 6
50 8
19 3

Salida que se debería obtener con esa entrada:

Puede existir
No puede existir
No puede existir
Puede existir
Puede existir
No puede existir
No puede existir
Puede existir
*/

// Ejemplo de solución 2, con "switch"

using System;

class DiaValido
{
    static void Main()
    {
        int casos = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < casos; i++)
        {
            bool fechaValida = false;
            string[] datos = Console.ReadLine().Split();
            int dia = Convert.ToInt32(datos[0]);
            int mes = Convert.ToInt32(datos[1]);
            
            switch(mes)
            {
                case 2: 
                    fechaValida = dia >=1 && dia <= 29;
                    break;
                case 1: 
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10: 
                case 12: 
                    fechaValida = dia >=1 && dia <= 31;
                    break;
                case 4: 
                case 6: 
                case 9: 
                case 11: 
                    fechaValida = dia >=1 && dia <= 30;
                    break;
            }

            if (fechaValida)
            {
                Console.WriteLine("Puede existir");
            }
            else
            {
                Console.WriteLine("No puede existir");
            }
        }
    }
}
