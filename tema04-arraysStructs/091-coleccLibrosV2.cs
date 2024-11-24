/*Crea un programa en C# que pueda almacenar hasta 25000 libros. Para cada 
libro, debe permitir al usuario almacenar la siguiente información:

• Título (por ejemplo, El resplandor)

• Autor(por ejemplo, Stephen King)

• Año de publicación (p. Ej., 1977)

El programa debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir un libro nuevo. El título y el autor no pueden estar vacíos. Si el 
usuario introduce un año vacío, se guardará un -1 en su lugar. Los datos deben 
ordenarse automáticamente por título.

2 - Mostrar todos los libros (número de registro, título, autor y año, en una 
misma línea), haciendo una pausa tras cada 21 filas. Si para un libro no se 
introdujo año, debe mostrar "Año desconocido" en lugar de -1.

3 - Buscar libros que contengan un texto determinado (búsqueda parcial, en 
cualquier campo de texto, sin distinguir entre mayúsculas y minúsculas). Debe 
mostrar el número de registro, el título, el autor y el año, en una misma 
línea, haciendo una pausa después de cada 21 filas.

4 - Buscar libros publicados entre dos fechas (por ejemplo, 1970 y 1985), ambas 
incluidas.Nuevamente, debe mostrar el número de registro, el título, el autor y 
el año, pero no es necesario hacer una pausa.Debe comportarse correctamente si 
el usuario introduce las fechas en orden inverso (primero el mayor año y luego 
el menor).

5 - Modificar un registro: solicitará al usuario su número, mostrará el valor 
anterior de cada campo y permitirá al usuario pulsar Intro sin escribir nada, 
si opta por no modificar alguno de los campos. Se avisará al usuario (pero no 
se le volverá a preguntar) si introduce un número de registro incorrecto. Antes 
de almacenar los datos, deben eliminarse los espacios iniciales y finales de 
cada campo de texto. Se advertirá al usuario si el título o el autor están 
completamente en mayúsculas, completamente en minúsculas o si contienen 
espacios redundantes.

6 - Eliminar un registro, en la posición ingresada por el usuario. Se debe 
avisar (pero no volver a preguntar) si introduce un número de registro 
incorrecto. Deberá mostrar el registro que se eliminará y solicitar 
confirmación antes de la eliminación.

7 - Corregir la ortografía en los títulos: mostrará los registros que contengan 
en el título: dos espacios consecutivos, espacios iniciales o finales, o una 
letra mayúscula justo después de una letra minúscula. Después de mostrar cada 
registro, le preguntará al usuario "¿Desea arreglar este registro (s/n)?" Si el 
usuario responde "s", el programa corregirá su título: eliminará los espacios 
finales, los espacios iniciales y los espacios duplicados, y cambiará el texto 
a minúsculas, excepto la primera letra y las que siguen a un punto.

S - Salir de la aplicación (como no almacenamos la información en fichero, los 
datos se perderán).*/

using System;

class Biblioteca
{
    struct Libro
    {
        public string titulo;
        public string autor;
        public short anyoPubli;
    }

    static void Main()
    {
        const int MAXIMO = 25000;
        const byte BLOQUE = 18;
        const string SALIR = "S",
            ANADIR = "1", VERTODO = "2", BUSCARTITULO= "3", 
            BUSCARFECHA= "4", MODIFICAR = "5", BORRAR = "6",
            ORTOGRAFIA = "7";
        
        Libro[] libros = new Libro[MAXIMO];
        ushort cantidad = 0;
        string opcion;

        do
        {
            Console.WriteLine("===============MENU===============");
            Console.WriteLine(ANADIR + "-Añadir un libro");
            Console.WriteLine(VERTODO + "-Mostrar todos los libros");
            Console.WriteLine(BUSCARTITULO + "-Buscar por título");
            Console.WriteLine(BUSCARFECHA + "-Buscar entre fechas");
            Console.WriteLine(MODIFICAR + "-Modificar libro");
            Console.WriteLine(BORRAR + "-Borrar libro");
            Console.WriteLine(ORTOGRAFIA + "-Revisar ortografía");
            Console.WriteLine(SALIR + "-Salir");
            Console.WriteLine();
            Console.Write("Opción?: ");
            opcion = Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            switch(opcion)
            {
                case ANADIR:
                    if (cantidad >= MAXIMO)
                    {
                        Console.WriteLine("Biblioteca llena");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Titulo?: ");
                            libros[cantidad].titulo = Console.ReadLine();
                        }
                        while (libros[cantidad].titulo == "");
                        
                        do
                        {
                            Console.Write("Autor?: ");
                            libros[cantidad].autor = Console.ReadLine();
                        }
                        while (libros[cantidad].autor == "");
                        
                        // Año -1 si no se escribe nada
                        Console.Write("Año de publicacion?: ");
                        string anyo = Console.ReadLine();
                        if (anyo == "")
                        {
                            libros[cantidad].anyoPubli = -1;
                        }
                        else
                        {
                            libros[cantidad].anyoPubli = Convert.ToInt16(anyo);
                        }
                        
                        cantidad++;
                        
                        //Ordeno titulos alfabeticamente
                        for(int i = 0; i < cantidad - 1; i++)
                        {
                            for(int j = i+1; j < cantidad; j++)
                            {
                                if (string.Compare(libros[i].titulo, 
                                    libros[j].titulo, true) > 0)
                                {
                                    Libro aux = libros[i];
                                    libros[i] = libros[j];
                                    libros[j] = aux;
                                }
                            }
                        }
                    }
                    break;

                case VERTODO:
                    if(cantidad == 0)
                        Console.WriteLine("Sin datos");
                    else
                        for(int i = 0; i < cantidad; i++)
                        {
                            string anyoMostrar = Convert.ToString(
                                libros[i].anyoPubli);
                                
                            if (anyoMostrar == "-1")
                                anyoMostrar = "Año desconocido";
                                
                            Console.WriteLine(
                                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                i+1, libros[i].titulo, libros[i].autor,
                                anyoMostrar);
                                
                            if ( (i+1) % BLOQUE == 0 )
                            {
                                Console.ReadLine();
                            }
                        }
                    Console.WriteLine();
                    break;

                case BUSCARTITULO:
                    Console.Write("BUSCAR. Titulo?: ");
                    string buscar = Console.ReadLine();
                    if(buscar !="")
                    {
                        for(int i = 0; i < cantidad; i++)
                        {  
                            if(libros[i].titulo.ToUpper().Contains(buscar.ToUpper())
                                || libros[i].autor.ToUpper().Contains(buscar.ToUpper()))
                            {
                                Console.WriteLine(
                                    "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                    i+1, libros[i].titulo, libros[i].autor,
                                    libros[i].anyoPubli);
                            }
                        }
                    }
                    break;

                case BUSCARFECHA:
                    Console.WriteLine("BUSCAR. RANGO AÑO DE PUBLICACION");
                    Console.Write("Entre año: ");
                    ushort fecha1 = Convert.ToUInt16( Console.ReadLine() );
                    Console.Write("Y año: ");
                    ushort fecha2 = Convert.ToUInt16( Console.ReadLine() );
                    
                    // Invertir fechas si están al revés
                    ushort fechaInicial = fecha1 > fecha2 ? fecha1 : fecha2;
                    ushort fechaFinal = fecha1 < fecha2 ? fecha1 : fecha2;
                    
                    for(int i = 0; i < cantidad; i++)
                    {  
                        if(libros[i].anyoPubli >= fechaInicial && 
                                libros[i].anyoPubli <= fechaFinal)
                        {
                            Console.WriteLine(
                                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                i+1, libros[i].titulo, libros[i].autor,
                                libros[i].anyoPubli);
                        }
                    }
                    break;

                case MODIFICAR:
                    Console.Write("Número de registro?: ");
                    int numRegistro = Convert.ToInt32( Console.ReadLine() );
                    if(numRegistro >= 1 && numRegistro <=cantidad)
                    { 
                        Console.WriteLine(
                            "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                numRegistro, libros[numRegistro-1].titulo, 
                                libros[numRegistro-1].autor,
                                libros[numRegistro-1].anyoPubli);
                        
                        Console.Write("Titulo?: ");
                        string cadenaAux = Console.ReadLine().Trim();
                        if(cadenaAux !="")
                            libros[numRegistro-1].titulo = cadenaAux;

                        Console.Write("Autor?:");
                        cadenaAux = Console.ReadLine().Trim();
                        if(cadenaAux !="")
                            libros[numRegistro-1].autor = cadenaAux;

                        Console.Write("Año de publicacion?: ");
                        cadenaAux = Console.ReadLine().Trim();
                        if(cadenaAux !="")
                            libros[cantidad].anyoPubli =
                                Convert.ToInt16( cadenaAux );
                        
                        // Avisos de mayúsculas, minúsculas, espacios
                        if (libros[numRegistro-1].autor == 
                            libros[numRegistro-1].autor.ToUpper())
                        {
                            Console.WriteLine("Cuidado: Autor en mayúsculas");
                        }
                        
                        if (libros[numRegistro-1].titulo == 
                            libros[numRegistro-1].titulo.ToUpper())
                        {
                            Console.WriteLine("Cuidado: Título en mayúsculas");
                        }
                        
                        if (libros[numRegistro-1].autor == 
                            libros[numRegistro-1].autor.ToLower())
                        {
                            Console.WriteLine("Cuidado: Autor en minúsculas");
                        }
                        
                        if (libros[numRegistro-1].titulo == 
                            libros[numRegistro-1].titulo.ToLower())
                        {
                            Console.WriteLine("Cuidado: Título en inúsculas");
                        }
                        
                        if (libros[numRegistro-1].autor.Contains("  "))
                        {
                            Console.WriteLine("Cuidado: Autor con espacios de sobra");
                        }
                        
                        if (libros[numRegistro-1].titulo.Contains("  "))
                        {
                            Console.WriteLine("Cuidado: Título con espacios de sobra");
                        }
                        
                    }
                    else
                        Console.WriteLine("No se encuentra el registro.");
                    break;

                case BORRAR:
                    Console.Write("Numero de registro?: ");
                    numRegistro = Convert.ToInt32( Console.ReadLine() );
                    if(numRegistro>=1 && numRegistro <= cantidad)
                    {
                        Console.WriteLine(
                            "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                numRegistro, libros[numRegistro-1].titulo, 
                                    libros[numRegistro-1].autor,
                                        libros[numRegistro-1].anyoPubli);
                        Console.Write(
                            "Seguro que quieres borrar este libro? Si/No:" );
                        string siNo = Console.ReadLine().ToUpper();
                        if(siNo == "SI" || siNo == "S")
                        {
                            for(int i=numRegistro-1; i < cantidad; i++)
                            {
                                libros[i] = libros[i+1];
                            }
                            cantidad--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sin datos");
                        Console.WriteLine();
                    }
                    break;
                
                case ORTOGRAFIA:
                    for(int i = 0; i < cantidad; i++)
                    {
                        bool fichaCorrecta = true;
                        string titulo = libros[i].titulo;
                        int longitud = titulo.Length;
                        
                        // Contiene espacios duplicados?
                        if (titulo.Contains("  "))
                        {
                            fichaCorrecta = false;
                        }
                        
                        // Empieza o termina en espacio?
                        if (titulo[0] == ' ' ||
                            titulo[longitud-1] == ' ')
                        {
                            fichaCorrecta = false;
                        }
                        
                        
                        // Minúscula justo antes de mayúscula
                        for (int l = 0; l < longitud-1; l++)
                        {
                            
                            if ((titulo[l] >= 'a') && (titulo[l] <= 'z')
                                && (titulo[l+1] >= 'A') && (titulo[l+1] <= 'Z'))
                            {
                                fichaCorrecta = false;
                            }
                        }
                        
                        if (! fichaCorrecta)
                        {
                            Console.WriteLine(
                            "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                i+1, libros[i].titulo, 
                                    libros[i].autor, libros[i].anyoPubli);
                            Console.Write("¿Desea arreglar este registro (s/n)? ");
                            string corregir = Console.ReadLine().ToUpper();
                            if (corregir == "S")
                            {
                                // Sin espacios iniciales ni finales
                                libros[i].titulo = libros[i].titulo.Trim();
                                
                                // Sin espacios redundantes
                                while (libros[i].titulo.Contains("  "))
                                    libros[i].titulo = 
                                        libros[i].titulo.Replace("  ", " ");
                                
                                // Mayúsculas correctas
                                // Fase 1: 1ª mayúscula, resto minúscula
                                libros[i].titulo =
                                    libros[i].titulo.ToUpper()[0] +
                                    libros[i].titulo.ToLower().Substring(1);
                                // Fase 2: Mays tras cada punto
                                string t = libros[i].titulo;
                                bool proxMayuscula = false;
                                for (int l = 1; l < t.Length-1; l++)
                                {
                                    if (t[l-1] == '.')
                                        proxMayuscula = true;

                                    if ((t[l] >= 'a') && (t[l] <= 'z')
                                        && proxMayuscula)
                                    {
                                        t = t.Insert(l, t.ToUpper().Substring(l,1));
                                        t = t.Remove(l+1,1);
                                        proxMayuscula = false;
                                    }
                                }
                                libros[i].titulo = t;
                            }
                        }
                        
                    }
                    break;

                case SALIR:
                    Console.WriteLine("¡Adios!");
                    break;

                default:
                    Console.WriteLine("Opcion no válida!");
                    break;
            }
                 
        }
        while(opcion != SALIR);
    }
}
