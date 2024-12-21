/*

Problema a resolver:

En la Navidad española, es posible recibir regalos el 25 de diciembre o 
el 6 de enero, según las costumbres de cada familia.

Debes crear un programa que reciba varios pares de día y mes, y 
responda "Regalo" si es un día en el que quizá se reciban regalos o "No 
regalo" si es un día en el que es casi seguro que no se va a recibir 
ninguno.

Datos de entrada

En primer lugar recibirás un número, que indica cuantos pares de datos 
se van a analizar. Luego seguirán varias líneas formadas por un número 
de día (que será de 1 a 31, no hace falta validarlo) y un número de mes 
(de 1 a 12, tampoco es necesario validarlo), separados por un único 
espacio en blanco.

Ejemplo de entrada

5
23 12
6 1
25 12
9 1
28 12

Salida que se debería obtener con esa entrada

No regalo
Regalo
Regalo
No regalo
No regalo

Recuerda: tu programa no debe mostrar nada más en pantalla (ni "Dime 
cuantos datos", ni "Dime el día y el mes", ni "El resultado es", ni 
nada que no sea estrictamente los resultados esperados).

*/

// Solución 2, más aplicable a cualquier reto de este tipo

using System;

class Reto01b
{
    static void Main()
    {
        int casos = Convert.ToInt32 (Console.ReadLine());
        for (int i = 0; i < casos; i++)
        {
            string[] detalles = Console.ReadLine().Split();
            byte dia = Convert.ToByte(detalles[0]);
            byte mes = Convert.ToByte(detalles[1]);
            if ((dia == 25 && mes == 12) 
                    || (dia == 6 && mes == 1))
                Console.WriteLine("Regalo");
            else
                Console.WriteLine("No regalo");
        }
    }
}
