      /* 
        =======================================
                  Javier (...)
                  Clase: Programación        
               Curso: 1 Semi presencial DAM  
                Instituto: IES San Vicente   
                    Ejercicio 65          
        =======================================
        */

/*Crea un menú como el siguiente. El usuario deberá escoger la opción 0, 1, 2 o 3,
 *y después se le mostrará la opción que ha escogido,
 *usando "switch" y datos de tipo "byte" (por ejemplo, con "case 1:"):
1. Jugar nueva partida
2. Cargar partida
3. Ver mejores puntuaciones
0. Salir
2
Ha escogido la opción "2": "Cargar partida"
*/
using System;

class Ejercicio65
{
    static void Main()
    {
        byte opcion;
        
        Console.WriteLine("1. Jugar nueva partida");
        Console.WriteLine("2. Cargar partida");
        Console.WriteLine("3. Ver mejores puntuaciones");
        Console.WriteLine("0. Salir");
        
        Console.WriteLine("Selecciona una opción: ");
        opcion = Convert.ToByte( Console.ReadLine());
        
        switch (opcion)
        {
            case 1: // Jugar
                Console.WriteLine("Ha escogido la opción \"1\": \"Jugar nueva partida\"");
                break;
            case 2: // Cargar
                Console.WriteLine("Ha escogido la opción \"2\": \"Cargar partida\"");           
                break;
            case 3: // Puntuaciones
                Console.WriteLine("Ha escogido la opción \"3\": \"Ver mejores puntuaciones\"");
                break;      
            case 0: // Salir
                Console.WriteLine("Ha escogido la opción \"0\": \"Salir\"");
                break;  
            default:
                Console.WriteLine("Opción no valida");
                break;
        }
    }
}
