/*
Reto 04: Palabras encadenadas

Problema a resolver

En estas fechas, en las que es frecuente que haya viajes familiares de duración 
más larga de la habitual, se suelen proponer juegos en familia que no necesiten 
dispositivos electrónicos, como el "veo veo" o las palabras encadenadas. Tu 
programa tendrá que ser un verificador básico para el juego de palabras 
encadenadas. A partir de una lista de palabras, deberá responder si cada una de 
ellas parece estar encadenada con la siguiente (SI) o no (NO), considerando 
solo las dos últimas letras de cada palabra y las dos primeras letras de la 
siguiente. También comprobará el caso de que alguna palabra termine en "ción", 
como nación, y en ese caso responderá TRAMPA, a pesar de que realmente nuestro 
programa no trabajará por sílabas sino por pares de letras.

Datos de entrada

Cada línea de entrada contendrá una serie de (al menos dos) palabras escritas 
con el alfabeto inglés, (es decir, sin acentos, ni eñe, ni vocales acentuadas) 
separadas cada una de la siguiente por un espacio en blanco, y quizás en 
mayúsculas, en minúsculas o con ambas mezcladas. Los datos de entrada 
terminarán con una línea vacía.

Ejemplo de entrada

dado donde
debemos OSTRA
MAS Masia
Casi Simbiosis isla Latin ingles
LoCa Casi Situacion


Salida que se debería obtener con esa entrada:

SI
SI
NO
SI
TRAMPA
*/

using System;

class Encadenadas
{
    static void Main()
    {
        string entrada = Console.ReadLine().ToUpper();
        while (entrada != "")
        {
            if (entrada.Contains("CION ") || entrada.EndsWith("CION"))
            {
                Console.WriteLine("TRAMPA");
            }
            else
            {
                string[] palabras = entrada.Split();
                bool encadenadas = true;

                for (int i = 0; i < palabras.Length - 1; i++)
                {
                    string palabraActual = palabras[i];
                    string palabraSiguiente = palabras[i+1];

                    string final = palabraActual.Substring(palabraActual.Length-2);
                    string principio = palabraSiguiente.Substring(0, 2);

                    if (final != principio)
                    {
                        encadenadas = false;
                    }
                }
                
                Console.WriteLine( encadenadas ? "SI" : "NO");
            }
            
            entrada = Console.ReadLine().ToUpper();
        }
    }
}
