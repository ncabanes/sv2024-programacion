/* Crea una función "PedirNoVacio", que mostrará en pantalla el mensaje 
de aviso que se indique como parámetro y leerá (y devolverá) el texto 
que el usuario introduzca en consola, sin permitir que sea una cadena 
vacía.
*/

using System;

class Ejemplo 
{
    static string PedirNoVacio(string mensaje)
    {
        string respuesta;
        
        do
        {
            Console.Write(mensaje);
            respuesta = Console.ReadLine();
        }
        while (respuesta == "");
        
        return respuesta;
    }
    
    static void Main() 
    {
        string nombre = PedirNoVacio("Dime el nombre");
        //string direccion = PedirNoVacio("Dime la direccion");
        Console.WriteLine("Hola, " + nombre);
    }
}

/*
Dime el nombre

Dime el nombre

Dime el nombre

Dime el nombre
Marta
Hola, Marta
*/
