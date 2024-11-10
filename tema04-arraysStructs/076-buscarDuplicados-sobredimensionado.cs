/*
 * MARTA (...), retoques por nacho
 * 
Crea una variante del programa anterior, que no pregunte al usuario 
cuántos datos va a introducir, sino que reserve espacio para 1000 
datos, y permita al usuario almacenar varios datos, hasta introducir un 
0, que no se guardará sino que servirá para indicar al programa que no 
se desea introducir más datos (pista: recuerda que deberás llevar un 
contador de cuántos datos hay realmente en el fichero). Cuando estén 
todos los datos introducidos, procederá como la versión anterior, 
buscando y mostrando los duplicados.
 */

using System;

class Ejercicio76
{
    static void Main()
    {
        ushort [] datos = new ushort [1000];
        int cantidad = 0;
        bool hayDuplicados;
        ushort dato;
        
        //Pedimos los datos
        do
        {
            Console.Write("Introduce el dato "+(cantidad+1)
                +" (0 para terminar): ");
            dato = Convert.ToUInt16( Console.ReadLine() );

            if (dato != 0) 
            {
                datos[cantidad] = dato;
                cantidad++;
            }
        }
        while(dato != 0);
        
        //Comprobamos si están duplicados
        Console.WriteLine("BUSCANDO DATOS DUPLICADOS");
        Console.Write("Duplicados: ");
        hayDuplicados = false;
        for( int i=0; i < cantidad-1; i++)
        {  
            for( int j = i+1; j < cantidad; j++)
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
