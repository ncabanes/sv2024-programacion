/* Jorge (...)
 * * Ejercicio 42 - Pide al usuario un número y respóndele cuántas 
 cifras tiene. Lo puedes conseguir dividiendo entre 10 tantas veces 
 como sea necesario, hasta que el número se convierta en 0. Por 
 ejemplo, el número 34, si lo divides entre 10 una vez, se convierte en 
 3; si divides una segunda vez, se convierte en 0. Por tanto, 34 tiene 
 2 cifras.*/
 
 using System;
 
 class Ejercicio42
 {
     static void Main()
     {
         int n, aux, cifras=1;
         
         Console.Write("introduce un número para ver cuantas cifras tiene: ");
         n = Convert.ToInt32(Console.ReadLine());
         aux=n;
         
         while(aux/10!=0)
         {
            aux=aux/10;
            cifras++;
         }
         Console.WriteLine("El número tiene {0} cifras.",cifras);
     }
 }
