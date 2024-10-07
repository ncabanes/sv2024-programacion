/******************************************************************************
 ÓSCAR (...) 1ºDAM
 Programación
 
30. Crea una versión mejorada del ejercicio de la contraseña numérica,
 en la que el usuario deba introducir un login además de la contraseña, 
 y sólo tenga 3 intentos. Si, al cabo de 3 intentos, no ha indicado el login y 
 la contraseña correctos (por ejemplo, 1111 y 1234 respectivamente), 
 se le responderá con "Acceso denegado" y terminará el programa.
 Si introduce ambos datos de forma correcta en 3 intentos o menos, 
 se le dirá "Acceso concedido" y terminará el programa. 
 Esta versión hazla sólo una vez, empleando "while" o "do-while", 
 como consideres más razonable. Comprueba que se comporta bien si
 el usuario introduce el login correcto y la contraseña incorrecta o viceversa.
*******************************************************************************/

using System;

class Ej30
{
    static void Main()
    {
        int password,login,intentos;
        intentos=1;
        
        do
        {
            Console.WriteLine("Intento: {0}",intentos);
            
            Console.WriteLine("Escribe tu login");
            login=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe tu contraseña");
            password=Convert.ToInt32(Console.ReadLine());
            
            intentos=intentos+1;
        }
        while ((intentos <= 3)
            && ((password != 1234) || (login != 1111)));  
        
        if ((password==1234)&&(login==1111))
        {
            Console.WriteLine("Acceso concedido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
        
    }
}
