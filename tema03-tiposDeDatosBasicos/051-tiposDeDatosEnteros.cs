/* 51. Crea un programa en C# que pida al usuario su edad, su año de 
nacimiento, su estatura en centímetros, la población de su ciudad, la población 
estimada del mundo y el dinero que tiene ahorrado (en euros, sin decimales). 
Debes optimizar los tipos de datos usados (todos ellos serán números enteros, 
pero quizá de distinto tipo). 

Luis (...)  */

using System;

class MostrarDatos
{
    static void Main()
    {
        byte edad, estatura;
        ushort nacimiento;
        uint poblacion;
        ulong poblacionMundial;
        int cantidadDinero;
        
        Console.Write( "Dime tu edad: " );
        edad = Convert.ToByte( Console.ReadLine() );
        
        Console.Write( "Dime tu año de nacimiento: " );
        nacimiento = Convert.ToUInt16( Console.ReadLine() );
        
        Console.Write( "Dime tu estatura en centimetros: " );
        estatura = Convert.ToByte( Console.ReadLine() );
        
        Console.Write( "Dime la poblacion de tu ciudad: " );
        poblacion = Convert.ToUInt32( Console.ReadLine() );
        
        Console.Write( "Dime la poblacion mundial: " );
        poblacionMundial = Convert.ToUInt64( Console.ReadLine() );
        
        Console.Write( "Dime el dinero que tienes ahorrado: " );
        cantidadDinero = Convert.ToInt32( Console.ReadLine() );
        
        Console.WriteLine("Edad: {0}, Año de nacimiento: {1}, " +
                          "Estatura: {2} cm, Población de la ciudad: {3}, " +
                          " Población mundial: {4}, Dinero ahorrado: {5}", edad,
                           nacimiento, estatura, poblacion, 
                           poblacionMundial, cantidadDinero);
    }
}
