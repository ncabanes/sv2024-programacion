/*
 * MARTA (...)
 * 
   Crea un programa en C# que pida al usuario una cadena y la muestre 
   encriptada de dos maneras diferentes: primero restando 1 a cada 
   carácter, luego con la operación XOR 1.
*/

using System;

class Ejercicio70
{
    static void Main()
    {
           string cadena;
           string encriptacion1 = "", encriptacion2 = "";
           string desencriptacion1 = "", desencriptacion2 = "";
           char respuesta;
           
           Console.WriteLine("Introduzca la frase a encriptar: ");
           cadena = Console.ReadLine();
           
           //Encriptación restando
           foreach ( char c in cadena)
           {
               encriptacion1 += (char)(c - 1);
           }
           Console.WriteLine("Primera encriptación:");
           Console.WriteLine(encriptacion1);
           Console.WriteLine();
           
           //Encriptación con XOR
           foreach ( char c in cadena)
           {
               encriptacion2 += (char)(c ^ 1);
           }
           
           Console.WriteLine("Segunda encriptación:");
           Console.WriteLine(encriptacion2);
           Console.WriteLine();
           
           //DESENCRIPTAMOS LOS MENSAJES
           Console.WriteLine("¿QUIERES DESENCRIPTAR LOS MENSAJES? S/N");
           respuesta = Convert.ToChar( Console.ReadLine() );
           
           if (respuesta == 'N')
           {
               Console.WriteLine("Hasta pronto");
           }
           else if (respuesta == 'S')
           {
               //Desencriptación mensaje 1
               foreach ( char c in encriptacion1)
               {
                   desencriptacion1 += (char)(c + 1);
               }
               Console.WriteLine("Primera encriptación:");
               Console.WriteLine(desencriptacion1);
               Console.WriteLine();
               
               //Desencriptación mensaje 2
               foreach ( char c in encriptacion2)
               {
                   desencriptacion2 += (char)(c ^ 1);
               }
               
               Console.WriteLine("Segunda encriptación:");
               Console.WriteLine(desencriptacion2);
           }
           else
           {
               Console.WriteLine("Opción elegida no válida");
           }
           
    }
}
