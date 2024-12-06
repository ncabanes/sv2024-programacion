/*
MARTA (...), retoques por Nacho

92 - Juegos de ordenador (examen de 2014-2015)

Crea un programa de C# que pueda almacenar hasta 10000 juegos de ordenador. 
Para cada juego, debe permitir al usuario almacenar la siguiente información:

 • Título (por ejemplo, GranTurismo 6)
 • Categoría (por ejemplo, carreras)
 • Plataforma (por ejemplo, PS3)
 • Año (por ejemplo, 2013)
 • Calificación (por ejemplo, 8.7)
 • Comentarios

*/

using System;

class Ejercicio92
{
    struct tipoJuego
    {
        public string titulo;
        public string categoria;
        public string plataforma;
        public short anyo;
        public float calificacion;
        public string comentarios;
    }
    
    static void Main()
    {
        const int CAPACIDAD = 10000;
        tipoJuego [] juegos = new tipoJuego [CAPACIDAD];
        string opcion, textoBuscar;
        string tituloAux, descripcionAux, categoriaAux, plataformaAux;
        short anyoAux;
        int registroAux;
        float calificacionAux;
        int contador = 0;
        int i, j;
        bool encontrado;
        bool terminado = false;
        
        do
        {
            Console.WriteLine();
            Console.WriteLine("MENÚ");
            Console.WriteLine("Elija una opción.");
            Console.WriteLine("1. Añadir un juego nuevo");
            Console.WriteLine("2. Mostrar datos de un juego");
            Console.WriteLine("3. Juegos de una determinada plataforma y categoría");
            Console.WriteLine("4. Buscar juegos que contengan un determinado texto");
            Console.WriteLine("5. Modificar un registro");
            Console.WriteLine("6. Eliminar un registro");
            Console.WriteLine("7. Ordenar los datos alfabéticamente");
            Console.WriteLine("8. Eliminar espacios redundantes");
            Console.WriteLine("S. Salir");
            Console.WriteLine();
            opcion = Console.ReadLine().ToUpper();
                        
            switch(opcion)
            {
                
                /*1 - Añadir un nuevo juego (al final de los datos 
                existentes). El título y la descripción no deben 
                estar vacíos. El año, si se introduce, debe ser de 
                1940 a 2100. La calificación, si se introduce, debe 
                ser de 0 a 10. No se debe realizar ninguna otra 
                validación.*/                   
                case "1": 
                    if (contador < CAPACIDAD)
                    {
                        Console.WriteLine("INTRODUZCA DATOS DEL NUEVO JUEGO");
                        Console.WriteLine();
                        
                        do
                        {
                            Console.Write("Título: ");
                            tituloAux = Console.ReadLine();
                            if(tituloAux != "")
                            {
                                juegos[contador].titulo = tituloAux;
                            }
                            else
                            {
                                Console.WriteLine("El título no puede estar vacío");
                            }
                        }
                        while(tituloAux == "");
                        
                        do
                        {
                            Console.Write("Comentarios: ");
                            descripcionAux = Console.ReadLine();
                            if(descripcionAux != "")
                            {
                                juegos[contador].comentarios = descripcionAux;
                            }
                            else
                            {
                                Console.WriteLine("La descripción no puede estar vacía");
                            }
                        }
                        while(descripcionAux == "");
                        
                        do
                        { 
                            Console.WriteLine("Categoría: ");
                            anyoAux = Convert.ToInt16(Console.ReadLine());
                            if((anyoAux >= 1940) && (anyoAux <= 2100))
                            {
                                juegos[contador].anyo = anyoAux;
                            }
                            else
                            {
                                Console.WriteLine("El año debe estar entre 1940 y 2100");
                            }
                        }
                        while((anyoAux < 1940) || (anyoAux > 2100));
                        
                        do
                        {
                            Console.WriteLine("Calificación: ");
                            calificacionAux = Convert.ToSingle(Console.ReadLine());
                            if((calificacionAux >= 0) && (calificacionAux <= 10))
                            {
                                juegos[contador].calificacion = calificacionAux;
                            }
                            else
                            {
                                Console.WriteLine("La calificación debe estar entre 0 y 10");
                            }
                        }
                        while((calificacionAux < 0) || (calificacionAux > 10));
                        
                        Console.WriteLine("Categoría: ");
                        juegos[contador].categoria = Console.ReadLine();
                        Console.WriteLine("Plataforma: ");
                        juegos[contador].plataforma = Console.ReadLine();

                        contador++;
                    }
                    break;
                        
                /*2 - Mostrar todos los datos de un juego 
                determinado (a partir de su número de registro o 
                bien de su título exacto -sin distinción de 
                mayúsculas y minúsculas-, según elija el 
                usuario).*/                         
                case "2": 
                    encontrado = false;
                    Console.Write("Para buscar por título pulsa \"T\""
                        +" para buscar por registro pulsa \"R\": ");
                    opcion = Console.ReadLine();
                    do
                    {
                        if(opcion.ToUpper() == "R")
                        {
                            Console.Write("Introduzca el número de registro: ");
                            registroAux = Convert.ToInt32( Console.ReadLine() ) - 1;
                            if (registroAux >= 0 && registroAux < contador)
                            {
                                Console.WriteLine("Título: "+juegos[registroAux].titulo);
                                Console.WriteLine("Categoría: "+juegos[registroAux].categoria);
                                Console.WriteLine("Plataforma: "+juegos[registroAux].plataforma);
                                Console.WriteLine("Año: "+juegos[registroAux].anyo);
                                Console.WriteLine("Calificación: "+juegos[registroAux].calificacion);
                                Console.WriteLine("Comentarios: "+juegos[registroAux].comentarios);
                                
                            }
                            else
                            {
                                Console.WriteLine("Número no válido");
                            }
                        }
                        else if(opcion.ToUpper() == "T")
                        {
                            Console.Write("Introduzca el título a buscar: ");
                            tituloAux = Console.ReadLine();
                            {
                                for(i = 0; i < contador; i++)
                                {
                                    if(tituloAux.ToUpper() == juegos[i].titulo.ToUpper())
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Número de registro: "+(i+1));
                                        Console.WriteLine("Título: "+juegos[i].titulo);
                                        Console.WriteLine("Categoría: "+juegos[i].categoria);
                                        Console.WriteLine("Plataforma: "+juegos[i].plataforma);
                                        Console.WriteLine("Año: "+juegos[i].anyo);
                                        Console.WriteLine("Calificación: "+juegos[i].calificacion);
                                        Console.WriteLine("Comentarios: "+juegos[i].comentarios);
                                        encontrado = true;
                                    }
                                }
                                if (! encontrado)
                                {
                                    Console.WriteLine("No se ha encontrado");
                                }
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Debe pulsar \"T\" o \"R\"");
                        }
                    }
                    while((opcion.ToUpper() != "T") && (opcion.ToUpper() != "R"));
                    break;
                        
                /*3 - Mostrar todos los juegos de una determinada 
                plataforma y categoría. Debe mostrar el número de 
                registro, el título, el año y la clasificación, 
                haciendo una pausa después de cada 22 
                filas.*/                            
                case "3": 
                    Console.Write("Instroduzca la plataforma a filtrar: ");
                    plataformaAux = Console.ReadLine();
                    Console.Write("Introduzca la categoría a filtrar");
                    categoriaAux = Console.ReadLine();
                    
                    encontrado = false;
                    for(i = 0; i < contador; i++)
                    {                                       
                        if((categoriaAux == juegos[i].categoria) 
                            &&(plataformaAux == juegos[i].plataforma))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Número de registro: "+(i+1));
                            Console.WriteLine("Año: "+juegos[i].anyo);
                            Console.WriteLine("Calificación: "+juegos[i].calificacion);                                 
                        }
                        
                        if(i % 22 == 21)
                        {
                            Console.WriteLine();
                        }
                    }
                    if (! encontrado)
                    {
                        Console.WriteLine("No se encontró ningún juego con las"
                            +" especificaciones solicitadas");
                    }
            
                    break;
                        
                /*4 - Buscar juegos que contengan un determinado 
                texto (búsqueda parcial, en cualquier campo de 
                texto, sin distinción de mayúsculas y minúsculas). 
                Debe mostrar el número de registro, el título, el 
                año y la clasificación, haciendo una pausa después 
                de cada 22 filas.*/                         
                case "4": 
                    Console.Write("Introduce el texto a buscar: ");
                    textoBuscar = Console.ReadLine();
                    
                    encontrado = false;
                    for(i = 0; i < contador; i++)
                    {
                        if((juegos[i].titulo.ToUpper().Contains(textoBuscar.ToUpper())) ||
                            (juegos[i].categoria.ToUpper().Contains(textoBuscar.ToUpper())) ||
                            (juegos[i].plataforma.ToUpper().Contains(textoBuscar.ToUpper())) ||
                            (juegos[i].comentarios.ToUpper().Contains(textoBuscar.ToUpper())))
                        {
                            Console.Write((i+1) + " - " + juegos[i].titulo);
                            Console.WriteLine("- Calif.: "+juegos[i].calificacion);                                 
                        }
                        
                        if( i% 22 == 21)
                        {
                            Console.WriteLine();
                        }
                    }
                    if (! encontrado)
                    {
                        Console.WriteLine("No se encontró ese texto");
                    }
                    break;
                        
                /*5 - Modificar un registro: pedirá al usuario su 
                número, mostrará el valor anterior de cada campo y 
                permitirá pulsar Intro para no modificar alguno de 
                los datos. Se debe avisar al usuario (pero no 
                volver a pedir) si introduce un número de registro 
                incorrecto. El año y la calificación, si se 
                modifican, deben ser válidos.*/                         
                case "5": 
                    Console.WriteLine("Introduzca el número de "
                        +"resgistro del juego a modificar:");
                    registroAux = Convert.ToInt32( Console.ReadLine() );
                    
                    if((registroAux <= contador) && (registroAux > 0))
                    {
                        Console.WriteLine();
                        Console.WriteLine("MODIFICANDO DATOS DEL JUEGO: "
                            +juegos[registroAux-1].titulo);
                        Console.WriteLine();
                        
                        //Modificamos los datos de [registro-1] porque
                        //el usuario comienza a contar desde 1.
                        
                        Console.WriteLine("Título actual: "+juegos[registroAux-1].titulo);
                        Console.Write("Título nuevo: ");
                        tituloAux = Console.ReadLine();
                        if( tituloAux != "")
                        {
                            juegos[registroAux-1].titulo = tituloAux;
                        }
                        
                        Console.WriteLine("Categoría actual: "+juegos[registroAux-1].categoria);
                        Console.Write("Categoría nueva: ");
                        categoriaAux = Console.ReadLine();
                        if( categoriaAux != "")
                        {
                            juegos[registroAux-1].categoria = categoriaAux;
                        }
                        
                        Console.WriteLine("Plataforma actual: "+juegos[registroAux-1].plataforma);
                        Console.Write("Plataforma nueva: ");
                        plataformaAux = Console.ReadLine();
                        if( plataformaAux != "")
                        {
                            juegos[registroAux-1].plataforma = plataformaAux;
                        }
                        
                        Console.WriteLine("Comentario actual: "+juegos[registroAux-1].comentarios);
                        Console.Write("Nuevo comentario: ");
                        descripcionAux = Console.ReadLine();
                        if( descripcionAux != "")
                        {
                            juegos[registroAux-1].comentarios = descripcionAux;
                        }
                        
                        Console.WriteLine("Año actual: "+juegos[registroAux-1].anyo);                               
                        do{
                            Console.Write("Año nuevo: ");
                            anyoAux = Convert.ToInt16(Console.ReadLine());
                            if((anyoAux >= 1940) && (anyoAux <= 2100))
                            {
                                juegos[registroAux-1].anyo = anyoAux;
                            }
                            else
                            {
                                Console.WriteLine("El año debe estar entre 1940 y 2100");
                            }
                        }while((anyoAux < 1940) || (anyoAux > 2100));   
                        
                        Console.WriteLine("Calificación actual: "+juegos[registroAux-1].calificacion);                      
                        do{
                            Console.WriteLine("Calificación nueva : ");
                            calificacionAux = Convert.ToSingle(Console.ReadLine());
                            if((calificacionAux >= 0) && (calificacionAux <= 10))
                            {
                                juegos[registroAux-1].calificacion = calificacionAux;
                            }
                            else
                            {
                                Console.WriteLine("La calificación debe estar entre 0 y 10");
                            }
                        }while((calificacionAux < 0) || (calificacionAux > 10));                            
                        
                        Console.WriteLine("DATOS MODIFICADOS CORRECTAMENTE");
                    }
                    else
                    {
                        Console.WriteLine("Número de registro no válido");
                    }
                    break;
                        
                /*6 - Eliminar un registro, en la posición indicada 
                por el usuario. Se le debe avisar (pero no volver a 
                preguntar) si introduce un número de registro 
                incorrecto. Debe mostrar el registro que se va a 
                eliminar y solicitar confirmación antes de la 
                eliminación.*/                          
                case "6": 
                    Console.WriteLine("Introduzca el número de "
                        +"resgistro del juego a borrar:");
                    registroAux = Convert.ToInt32( Console.ReadLine() );
                    
                    if((registroAux <= contador) && (registroAux != 0))
                    {
                        //Mostramos los datos del registro actuales
                        Console.WriteLine();
                        Console.WriteLine("Número de registro: "+registroAux);
                        Console.WriteLine("Título: "+juegos[registroAux-1].titulo);
                        Console.WriteLine("Categoría: "+juegos[registroAux-1].categoria);
                        Console.WriteLine("Plataforma: "+juegos[registroAux-1].plataforma);
                        Console.WriteLine("Año: "+juegos[registroAux-1].anyo);
                        Console.WriteLine("Calificación: "+juegos[registroAux-1].calificacion);
                        Console.WriteLine("Comentarios: "+juegos[registroAux-1].comentarios);
                        
                        //Pedimos confirmación
                        Console.WriteLine("Para confirmar el borrado pulse \"B\"");
                        opcion = Console.ReadLine();                                
                        if(opcion.ToUpper() == "B")
                        {
                            for(i = (registroAux-1); i<contador; i++)
                            {
                                juegos[i] = juegos[i+1];
                            }
                            contador--;
                            Console.WriteLine("JUEGO BORRADO CORRECTAMENTE");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número de registro no válido");
                    }
                    break;
                                                    
                /*7 - Ordenar los datos alfabéticamente, por título y 
                (si es necesario) por plataforma.*/                         
                case "7": 
                    for(i = 0; i < contador-1; i++)
                    {
                        for(j = i+1; i < contador; j++)
                        {
                            if((juegos[i].titulo.ToLower().
                                    CompareTo(juegos[j].titulo.ToLower()) > 0)
                                ||
                                (juegos[i].titulo.ToLower().
                                    CompareTo(juegos[j].titulo.ToLower()) == 0
                                && juegos[i].plataforma.ToLower().
                                    CompareTo(juegos[j].titulo.ToLower()) > 0))
                            {
                                tipoJuego juegoAux = juegos[i];
                                juegos[i] = juegos[j];
                                juegos[j] = juegoAux;
                            }
                        }
                    }
                    Console.WriteLine("Datos ordenados");
                    break;
                        
                /*8 - Eliminar espacios redundantes: eliminar 
                espacios finales, espacios iniciales y espacios 
                duplicados en la descripción, categoría y 
                plataforma.*/
                        
                case "8": 
                    for(i=0; i<contador; i++)
                    {
                        juegos[i].comentarios = juegos[i].comentarios.Trim();
                        while(juegos[i].comentarios.Contains("  "))
                        {
                            juegos[i].comentarios = juegos[i].comentarios.Replace("  "," ");
                        }
                        
                        juegos[i].categoria = juegos[i].categoria.Trim();
                        while(juegos[i].categoria.Contains("  "))
                        {
                            juegos[i].categoria = juegos[i].categoria.Replace("  "," ");
                        }
                        
                        juegos[i].plataforma = juegos[i].plataforma.Trim();
                        while(juegos[i].plataforma.Contains("  "))
                        {
                            juegos[i].plataforma = juegos[i].plataforma.Replace("  "," ");
                        }
                    }
                    Console.WriteLine("Espacios redundantes revisados");
                    break;
                        
                /*S - Salir de la aplicación*/      
                case "S": 
                    terminado = true;
                    break;

                default: Console.WriteLine("Opción no válida");
                        break;
                    
            }
        }
        while(! terminado);
        
        Console.WriteLine("HASTA PRONTO");
    }
}
