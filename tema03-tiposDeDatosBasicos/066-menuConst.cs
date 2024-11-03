      /* 
        =======================================
                  Javier (...)
                  Clase: Programación        
               Curso: 1 Semi presencial DAM  
                Instituto: IES San Vicente   
                    Ejercicio 66          
        =======================================
        */

/* Crea una nueva versión del programa anterior, que no utilice "números mágicos"
 * en la orden "switch", sino constantes  (por ejemplo, con "case JUGAR:").
*/
using System;
class Ejercicio66
{
    static void Main()
    {
        byte opcion;
        const byte JUGAR = 1;
        const byte CARGAR = 2;
        const byte PUNTUACIONES = 3;
        const byte SALIR = 0;
        
        Console.WriteLine(JUGAR+". Jugar nueva partida");
        Console.WriteLine(CARGAR+". Cargar partida");
        Console.WriteLine(PUNTUACIONES+". Ver mejores puntuaciones");
        Console.WriteLine(SALIR+". Salir");
        
        Console.WriteLine("Selecciona una opción: ");
        opcion = Convert.ToByte( Console.ReadLine());
        
        switch (opcion)
        {
            case JUGAR:
                Console.WriteLine("Ha escogido la opción \"1\": \"Jugar nueva partida\"");
                break;
            case CARGAR:
                Console.WriteLine("Ha escogido la opción \"2\": \"Cargar partida\"");           
                break;
            case PUNTUACIONES:
                Console.WriteLine("Ha escogido la opción \"3\": \"Ver mejores puntuaciones\"");
                break;      
            case SALIR:
                Console.WriteLine("Ha escogido la opción \"0\": \"Salir\"");
                break;  
            default:
                Console.WriteLine("Opción no valida");
                break;
        }
    }
}
