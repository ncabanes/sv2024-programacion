// Tutoría del tema 2, semana 1 (if, switch)
// Ejercicio 4

/*
Pide al usuario que introduzca un número entero del 1 al 5. Respóndele 
si es par o impar, usando "switch" y luego usando "if" (todo ello, como 
parte de un único programa).
*/

using System;

class ParImpar
{
    static void Main()
    {
        int n;
        
        Console.WriteLine("Dame un número (del 1 al 5)");
        n = Convert.ToInt32( Console.ReadLine() );
        
        // Forma 1: switch, exhaustivo
        
        switch(n)
        {
            case 1: Console.WriteLine("Impar"); break;
            case 2: Console.WriteLine("Par"); break;
            case 3: Console.WriteLine("Impar"); break;
            case 4: Console.WriteLine("Par"); break;
            case 5: Console.WriteLine("Impar"); break;
            default: Console.WriteLine("Del 1 al 5, por favor"); break;
        }
        
        // Forma 2: switch, agrupando con "goto case" (sólo C#)
        
        switch(n)
        {
            case 1: Console.WriteLine("Impar"); break;
            case 2: Console.WriteLine("Par"); break;
            case 3: goto case 1;
            case 4: goto case 2;
            case 5: goto case 1;
            default: Console.WriteLine("Del 1 al 5, por favor"); break;
        }
        
        // Forma 3: switch, agrupando con casos vacíos (puede suponer
        // cambiar el orden de los casos)
        
        switch(n)
        {
            case 2:
            case 4: 
                Console.WriteLine("Par"); 
                break;
            
            case 1:
            case 3:
            case 5: 
                Console.WriteLine("Impar"); 
                break;
                
            default: Console.WriteLine("Del 1 al 5, por favor"); break;
        }
        
        
        // Forma 4: if, exhaustivo
        
        if (n == 1) Console.WriteLine("Impar"); 
        else if (n == 2) Console.WriteLine("Par");
        else if (n == 3) Console.WriteLine("Impar"); 
        else if (n == 4) Console.WriteLine("Par"); 
        else if (n == 5) Console.WriteLine("Impar"); 
        else Console.WriteLine("Del 1 al 5, por favor"); 
        
        
        // Forma 5: if, agrupando con "o" ||
        
        if ((n == 1) || (n == 3) || (n == 5))
            Console.WriteLine("Impar"); 
        else if ((n == 2)|| (n == 4)) 
            Console.WriteLine("Par"); 
        else Console.WriteLine("Del 1 al 5, por favor"); 
        
    }   
}
