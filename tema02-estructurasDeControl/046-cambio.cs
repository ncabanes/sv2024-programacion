/******************************************************************************
 ÓSCAR (...) 1ºDAM
 Programación
 
46. Crea un programa devuelva el cambio de una compra, 
utilizando siempre en primer lugar monedas (o billetes) 
del valor más grande posible. 
Supondremos que tenemos una cantidad ilimitada de monedas (o billetes)
 de 50, 10, 5, 2 y 1, y que no hay decimales. L
 a ejecución podría ser algo como:

Precio? 212
Pagado? 300
Tu cambio es 88: 50 10 10 10 5 2 1 

*******************************************************************************/
using System;

class Ej2_4_46
{
    static void Main()
    {
        try
        {
            int precio,pagado,cambio;
            Console.WriteLine("Introduzca el precio del producto");
            precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad pagada");
            pagado = Convert.ToInt32(Console.ReadLine());
            cambio = pagado-precio;
            Console.Write("Tu cambio es {0}: ",cambio);
            
            while(cambio >= 50)
            {
                Console.Write(" 50");
                cambio -= 50;
            }

            while(cambio >= 10)
            {
                Console.Write(" 10");
                cambio -= 10;
            }
            
            while(cambio >= 5)
            {
                Console.Write(" 5");
                cambio -= 5;
            }
            
            while(cambio >= 2)
            {
                Console.Write(" 2");
                cambio -= 2;
            }
            
            while(cambio >= 1)
            {
                Console.Write(" 1");
                cambio -= 1;
            }   
        }
        catch (FormatException)
        {
            Console.WriteLine("La cantidad introducida no es un número");
        }
        catch (Exception error)
        {
            Console.WriteLine("Error del tipo: {0}",error);
        }
    }
}
