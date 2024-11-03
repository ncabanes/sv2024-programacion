/*
Muestra las letras de la A a la Z, en una línea.

En la línea siguiente muestra los caracteres del 32 al 127. Si alguno 
de ellos es la comilla simple, escribe su código ASCII.
*/

using System;

class Ejemplo 
{
    static void Main() 
    {
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            Console.Write(letra);
        }
        Console.WriteLine();
        
        for (byte i = 32; i <= 127; i++)
        {
            Console.Write( Convert.ToChar(i) );
            if (i == '\'')
                Console.Write(" = {0} ", i);
        }
    }
}

/*
ABCDEFGHIJKLMNOPQRSTUVWXYZ
 !"#$%&' = 39 ()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{|}~
*/
