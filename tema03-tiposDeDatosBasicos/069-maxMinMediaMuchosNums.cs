/*
 * MARTA (...)
 * 
  Escribe un programa que pida al usuario números reales de doble 
  precisión, tras cada introducir cada número, muestre cuál es hasta 
  ese momento el máximo, mínimo, suma y media. Terminará cuando 
  introduzca la palabra "fin".
*/

using System;

class Ejercicio69
{
    static void Main()
    {
        string dato;
        double n;
        double maximo = 0, minimo = 0;
        double suma = 0;
        byte contador = 1;
      
        do
        {
            Console.Write("Dato: ");
            dato = Console.ReadLine(); 
            
            //Verificamos que dato sea diferente de fin antes de convertir
            //en double            
            if (dato != "fin")
            {
                //Convertimos el dato introducido en Double
                n = Convert.ToDouble(dato);
                    
                //Ponemos una condición especial para el primera caso
                if (contador == 1)
                {
                    maximo = n;                     
                    minimo = n;
                }
                //Aislamos el resto de casos
                else
                {
                    //Comprobamos el máximo
                    if(n > maximo)
                    {
                        maximo = n;
                    }
                    
                    //Comprobamos el mínimo                     
                    if (n < minimo)
                    {
                        minimo = n;
                    }
                }
                //Acumulamos la suma
                suma += n;
                
                //Mostramos por pantalla resultados
                Console.Write("Max = "+maximo+", ");
                Console.Write("Min = "+minimo+", ");
                Console.Write("Suma = "+suma+", ");
                Console.WriteLine("Media = "+suma/contador);
                
                contador++;
            }
        }
        while(dato != "fin");
         
        Console.WriteLine("¡Hasta pronto!");
    }
}
