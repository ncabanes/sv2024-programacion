/*
Datos de hasta 100 personas. 
Nombre y email para cada una.
Menú que permita:
 - Añadir un nuevo dato
 - Ver todos
 - Salir
*/

using System;

class Ejemplo 
{
    struct tipoPersona
    {
        public string nombre;
        public string email;
    }
        
    static void Main() 
    {
        const int CAPACIDAD = 100;
        tipoPersona[] personas = new tipoPersona[CAPACIDAD];
        string opcion;
        int cantidad = 0;
        
        do
        {
            Console.WriteLine("1 - Añadir un nuevo dato");
            Console.WriteLine("2 - Ver todos");
            Console.WriteLine("S - Salir");
            
            opcion = Console.ReadLine();
            
            switch(opcion)
            {
                case "1":  // Añadir
                    if (cantidad < CAPACIDAD)
                    {
                        Console.Write("Dime el nombre: ");
                        personas[cantidad].nombre = Console.ReadLine();
                        Console.Write("Dime el email: ");
                        personas[cantidad].email = Console.ReadLine();
                        cantidad ++;
                    }
                    else
                    {
                        Console.WriteLine("No caben más datos");
                    }
                    break;

                case "2":  // Ver todos
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine(personas[i].nombre + " - " +
                            personas[i].email);
                        if (i % 20 == 19)
                        {
                            Console.ReadLine();
                        }
                    }
                    break;

                case "S":
                case "s":
                    Console.WriteLine("Hasta otra!");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
                
            }
        }
        while (opcion != "S" && opcion != "s");
    }
}

/*
¿Intentos del deportista 1? 3
¿Intentos del deportista 2? 4
Dame el dato del deportista 1, intento 1: 3
Dame el dato del deportista 1, intento 2: 4
Dame el dato del deportista 1, intento 3: 5
Dame el dato del deportista 2, intento 1: 1
Dame el dato del deportista 2, intento 2: 6
Dame el dato del deportista 2, intento 3: 7
Dame el dato del deportista 2, intento 4: 2
El máximo de la segunda fila es 7
*/
