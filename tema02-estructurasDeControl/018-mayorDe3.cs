/*Pide tres números y di cuál es el mayor de ellos. Por ejemplo, si el 
usuario introduce 5, 7 y 7, la respuesta será 7. Como ocurre con esos 
datos de ejemplo, es posible que existan números repetidos, y tu 
programa deberá comportarse correctamente también en ese caso. Existen 
varios planteamientos posibles. Uno de los más sencillos es ver si el 
primer número es mayor que los otros dos; en caso de que no sea así, se 
mirará si el segundo es mayor que los otros dos, y así sucesivamente. 
Hay pequeños detalles adicionales que se deben considerar, que pueden 
hacer que tu solución sea correcta o que falle en ciertos casos, o 
incluso que sean innecesariamente larga, y es interesante que trates de 
descubrirlos.*/

// Por Blanca (...)

using System;
class Ejercicio18
{
    static void Main()
    {
        int n1, n2, n3;
        
        Console.WriteLine( "Dime el primer número: ");
        n1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( "Dime el segundo número: ");
        n2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine( "Dime el tercer número: ");
        n3=Convert.ToInt32(Console.ReadLine());
        
        if( n1 >= n2 && n1 >= n3)
        {
            Console.WriteLine("El mayor es {0}", n1);
        } 
        else if (n2 >= n1 && n2 >= n3)
        {
            Console.WriteLine("El mayor es {0}", n2);
        } 
        else
        {
            Console.WriteLine("El mayor es {0}", n3);
        }
    }
}
