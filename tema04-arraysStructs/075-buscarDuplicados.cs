/*
 * MARTA (...), retoques por nacho
 * 
Crea un programa que pregunte al usuario cuántos datos (enteros cortos 
sin signo) va a introducir, reserve espacio para todos ellos, se los 
pida al usuario y finamente muestre los números que estén duplicados 
(pista: deberás comparar cada dato con todos los posteriores). Por 
ejemplo, si los números son 12 23 36 23 45, la respuesta sería 
"Duplicados: 23". Si no hubiera ningún duplicado, la respuesta deberá 
ser "Duplicados: Ninguno". Si algún dato aparece más de dos veces (por 
ejemplo, 12 23 36 23 45 23) puede que la respuesta sea "fea": 
"Duplicados: 23 23", pero no nos preocupa que no se comporte 
correctamente en ese caso.
 */

using System;

class Ejercicio75
{
    static void Main()
    {
        ushort[] datos;
        int cantidad;
        bool hayDuplicados;
        
        Console.Write("¿Cuántos datos vas a introducir?: ");
        cantidad = Convert.ToInt32( Console.ReadLine() );
        datos = new ushort[cantidad];
        
        //Pedimos los datos
        for( int i=0; i < datos.Length; i++)
        {
            Console.Write("Introduce el dato "+(i+1)+": ");
            datos[i] = Convert.ToUInt16(Console.ReadLine());
        }
        
        //Comprobamos si están duplicados
        Console.Write("Duplicados: ");
        hayDuplicados = false;
        for( int i=0; i < datos.Length-1; i++)
        {  
            for( int j = i+1; j < datos.Length; j++)
            {                              
                if (datos[i] == datos [j])
                {
                    Console.Write(datos[i] + " ");
                    hayDuplicados = true;
                }
            }
        }
        if (! hayDuplicados)
        {
            Console.Write("Ninguno");
        }
    }
}
