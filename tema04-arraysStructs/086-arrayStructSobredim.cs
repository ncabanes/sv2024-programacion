/* Crea una versión mejorada del ejercicio anterior (85), que no 
reservará espacio sólo para 3 datos, sino para 100 (un "array 
sobredimensionado"), y mostrará un menú que permita al usuario añadir 
un nuevo dato, ver todos los existentes o salir (por supuesto, se 
repetirá hasta que se escoja la opción de "Salir"). Pista: recuerda que 
deberás llevar un contador de cuántos registros se han añadido 
realmente, como puedes ver en el apartado 4.1.4 de los apuntes.

Por Blanca (...)*/

using System;

class Ejercicio86
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
        const int CAPACIDAD= 100;
        int cantidad = 0;
        persona[] gente = new persona[CAPACIDAD];
        int opcion;
        
        do
        {
            Console.Clear();
            Console.WriteLine("Elije la opción que quieras:");
            Console.WriteLine("1. Añadir nuevo dato.");
            Console.WriteLine("2. Ver todos los existentes.");
            Console.WriteLine("0. Salir.");
            
            opcion=Convert.ToInt32(Console.ReadLine());
            
            switch(opcion)
            {
                case 1: // Añadir
                    Console.WriteLine("Añadir nueva persona:");
                    
                    Console.WriteLine("Dime el nombre: ");
                    gente[cantidad].nombre = Console.ReadLine();
                    Console.WriteLine("Dime la fecha de nacimiento: ");
                    Console.WriteLine("Día: ");
                    gente[cantidad].fechaNacimiento.dia = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Mes: ");
                    gente[cantidad].fechaNacimiento.mes = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Año: ");
                    gente[cantidad].fechaNacimiento.anyo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dime la altura: ");
                    gente[cantidad].altura = Convert.ToSingle(Console.ReadLine());
                    cantidad++;
                    break;
                    
                case 2: // Ver todos
                    Console.WriteLine("Ver todos:");
                    Console.WriteLine("Estos son los datos que has introducido: ");
                    for(int i=0; i<cantidad;i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Persona {0}:", i+1);
                        Console.WriteLine("Nombre: {0}, altura: {1}, fecha de nacimiento: {2}-{3}-{4}.", 
                        gente[i].nombre, gente[i].altura, gente[i].fechaNacimiento.dia, 
                        gente[i].fechaNacimiento.mes, gente[i].fechaNacimiento.anyo);
                        Console.WriteLine();
                    }
                    break;
                    
                case 0: // Salir
                    Console.WriteLine("¡ Hasta pronto !");
                    break;
                    
                default: 
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }
        
            Console.WriteLine("Pulsa INTRO para continuar: ");
            Console.ReadLine();
        } while(opcion !=0);
    }
}
