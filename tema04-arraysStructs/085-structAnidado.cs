/*
 Crea una variante del ejercicio anterior (84), en la que no guardes
 la edad de cada persona, sino la fecha de nacimiento (día, mes, 
 año, en forma de struct anidado). Al igual que antes, pide al usuario 
 datos de 3 personas (que serán parte de un array) y luego muéstralos.

Por Blanca (...)*/

using System;

class Ejercicio85
{
    struct fecha
    {
        public byte dia;
        public byte mes;
        public int anyo;
    }

    struct persona 
    {
        public string nombre;
        public fecha fechaNacimiento;
        public float altura;
    }
   
    static void Main(){
        persona[] gente = new persona[3];
        
        for(int i=0; i<gente.Length;i++)
        {
            Console.WriteLine("Dime el nombre: ");
            gente[i].nombre = Console.ReadLine();
            Console.WriteLine("Dime la fecha de nacimiento: ");
            Console.WriteLine("Día: ");
            gente[i].fechaNacimiento.dia = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Mes: ");
            gente[i].fechaNacimiento.mes = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Año: ");
            gente[i].fechaNacimiento.anyo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime la altura: ");
            gente[i].altura = Convert.ToSingle(Console.ReadLine());
        }
        
        Console.WriteLine("Estos son los datos que has introducido: ");
        for(int i=0; i<gente.Length;i++)
        {
            Console.WriteLine("Nombre: {0}, altura: {1}, fecha de nacimiento: {2}-{3}-{4}.", 
            gente[i].nombre, gente[i].altura, gente[i].fechaNacimiento.dia, 
            gente[i].fechaNacimiento.mes, gente[i].fechaNacimiento.anyo);
        }
    }
}
