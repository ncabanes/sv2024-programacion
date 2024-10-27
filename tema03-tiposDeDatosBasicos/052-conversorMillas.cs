/*Crea un programa que pida al usuario una cantidad de kilómetros y 
calcule (y escriba) su equivalencia en millas terrestres (1 milla 
terrestre = 1,609 Km) y en millas náutica (1 milla náutica = 1,852 Km). 
Por ejemplo, si el usuario introduce 20,5 km, la respuesta debería ser 
cercana a 12,74 millas terrestres y a 11,07 millas náuticas. Debes usar 
datos reales de simple precisión (float).
*/

// César (...)

using System;

class Millas
{
    static void Main ()
    {
        Console.WriteLine("Dime kilómetros: ");
        float km = Convert.ToSingle( Console.ReadLine() );
        float kmPorMillaTerrestre = 1.609f;
        float kmPorMillaNautica = 1.852f;
        
        Console.WriteLine ("Son {0} millas y {1} millas nauticas",
            km / kmPorMillaTerrestre, km / kmPorMillaNautica);
    }
}


