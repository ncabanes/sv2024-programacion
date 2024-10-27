/*
54. Calcula el volumen de un cilindro, a partir de su radio y su 
altura, que introducirá el usuario. El volumen será "pi por el radio al 
cuadrado, multiplicado por la altura". Debes utilizar variables de tipo 
"float" y mostrar los resultados con tres decimales.
*/

// Pablo (...)

using System;

class VolumenCilindro
{
    static void Main()
    {
        Console.WriteLine("Dime el radio del cilindro: ");
        float radio = Convert.ToSingle(Console.ReadLine());    
        
        Console.WriteLine("Dame la altura del cilindro: ");
        float altura = Convert.ToSingle(Console.ReadLine());    
        
        float pi = 3.1415927f;
        
        float volume = pi * radio*radio * altura;
        
        Console.WriteLine("El volumen para un cilindro con radio {0} y altura {1} es: {2}", 
            radio, altura, volume.ToString("0.000"));  
    }
}
