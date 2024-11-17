/* Crea un "struct" para almacenar algunos datos de personas, de 
momento sólo: nombre (cadena de texto), edad (byte) y estatura en 
metros (real de simple precisión). Pide al usuario datos de 2 personas 
(sin usar todavía ningún array) y luego muéstralos.

Por Blanca (...)*/

using System;

class Ejercicio83
{
    struct persona {
        public string nombre;
        public byte edad;
        public float altura;
    }
    
    static void Main(){
        persona p1,p2;
        
        Console.WriteLine("Dime el nombre: ");
        p1.nombre = Console.ReadLine();
        Console.WriteLine("Dime la edad: ");
        p1.edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Dime la altura: ");
        p1.altura = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Dime el nombre: ");
        p2.nombre = Console.ReadLine();
        Console.WriteLine("Dime la edad: ");
        p2.edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Dime la altura: ");
        p2.altura = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Primera persona:");
        Console.WriteLine("Nombre: {0}, edad: {1}, altura: {2}", 
            p1.nombre, p1.edad, p1.altura);
        
        Console.WriteLine("Segunda persona:");
        Console.WriteLine("Nombre: {0}, edad: {1}, altura: {2}", 
            p2.nombre, p2.edad, p2.altura);
    }
}
