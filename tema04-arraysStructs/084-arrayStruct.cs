/*

Crea una versión mejorada del ejercicio anterior, que pida al usuario 
los datos de 3 personas, los guarde en un array de structs y luego los 
muestre.

Crea un "struct" para almacenar algunos datos de personas, de momento 
sólo: nombre (cadena de texto), edad (byte) y estatura en metros (real 
de simple precisión). Pide al usuario datos de 2 personas (sin usar 
todavía ningún array) y luego muéstralos.

Por Blanca (...)*/

using System;

class Ejercicio84
{
    struct persona {
        public string nombre;
        public byte edad;
        public float altura;
    }
    
    static void Main(){
        persona[] gente = new persona[3];
        
        for(int i=0; i<gente.Length;i++)
        {
            Console.WriteLine("Dime el nombre: ");
            gente[i].nombre = Console.ReadLine();
            Console.WriteLine("Dime la edad: ");
            gente[i].edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Dime la altura: ");
            gente[i].altura = Convert.ToSingle(Console.ReadLine());
        }
        
        Console.WriteLine("Estos son los datos que has introducido: ");
        for(int i=0; i<gente.Length;i++)
        {
            Console.WriteLine("Nombre: {0}, edad: {1}, altura: {2}", 
                gente[i].nombre, gente[i].edad, gente[i].altura);
        }
    }
}
