      /* 
        =======================================
                  Javier (...)
                  Clase: Programación        
               Curso: 1 Semi presencial DAM  
                Instituto: IES San Vicente   
                    Ejercicio 67         
        =======================================
        */

/*Crea una tercera versión del programa 66, que no emplee constantes
 *convencionales sino una enumeración  (por ejemplo, con "case (int) opciones.JUGAR:").
*/
using System;
class Ejercicio67
{
    enum opciones { SALIR, JUGAR, CARGAR, PUNTUACIONES };
    static void Main()
    {
        byte opcion;    
                        
        Console.WriteLine(
            (int) opciones.JUGAR + ". Jugar nueva partida");
        Console.WriteLine(
            (int) opciones.CARGAR + ". Cargar partida");
        Console.WriteLine(
            (int) opciones.PUNTUACIONES + ". Ver mejores puntuaciones");
        Console.WriteLine(
            (int) opciones.SALIR + ". Salir");
        
        Console.WriteLine("Selecciona una opción: ");
        opcion = Convert.ToByte( Console.ReadLine());
        
        switch (opcion)
        {
            case (int) opciones.JUGAR:
                Console.WriteLine("Ha escogido la opción \"1\": \"Jugar nueva partida\"");
                break;
            case (int) opciones.CARGAR:
                Console.WriteLine("Ha escogido la opción \"2\": \"Cargar partida\"");           
                break;
            case (int) opciones.PUNTUACIONES:
                Console.WriteLine("Ha escogido la opción \"3\": \"Ver mejores puntuaciones\"");
                break;      
            case (int) opciones.SALIR:
                Console.WriteLine("Ha escogido la opción \"0\": \"Salir\"");
                break;  
            default:
                Console.WriteLine("Opción no valida");
                break;
        }
    }
}

        
        
