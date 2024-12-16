/* 113. Crea una nueva versión del ejercicio 91 (Biblioteca), partiendo de la 
versión oficial que tienes compartida. En esta versión, cada opción del menú 
principal se debe extraer a una función. Por lo general, cada una de estas 
funciones deberá recibir como parámetros el array con los datos y el contador 
de cuántos datos hay almacenados, de modo que no existan variables "globales", 
sino variables locales y datos pasados como parámetros. También puedes crearte 
las funciones auxiliares que consideres útiles (por ejemplo, una para pedir un 
texto no vacío, que simplifique la opción de Añadir, y/o una que compruebe si 
un texto está en minúsculas, para simplificar la opción de Modificar). */

// Ruben (...), retoques por Nacho

using System;

class Ejercicio113
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
            ANADIR = "1", VERTODO = "2", BUSCARTITULO = "3",
            BUSCARFECHA = "4", MODIFICAR = "5", BORRAR = "6",
            ORTOGRAFIA = "7";

        Libro[] libros = new Libro[MAXIMO];
        ushort cantidad = 0;
        string opcion;

        do
        {
            opcion = MostrarMenuYEscoger();
            
            switch (opcion)
            {
                case ANADIR:
                    AnyadirLibro(ref libros, ref cantidad, MAXIMO);
                    break;

                case VERTODO:
                    MostrarLibros(ref libros, cantidad, BLOQUE);
                    break;

                case BUSCARTITULO:
                    BuscarTitulo(ref libros, cantidad);
                    break;

                case BUSCARFECHA:
                    BuscarFecha(ref libros, cantidad);
                    break;

                case MODIFICAR:
                    Modificar(ref libros, cantidad);   
                    break;

                case BORRAR:
                    Borrar(ref libros, ref cantidad);
                    break;

                case ORTOGRAFIA:
                    ComprobarOrtografia(ref libros, cantidad);
                    break;

                case SALIR:
                    Console.WriteLine("¡Adios!");
                    break;

                default:
                    Console.WriteLine("Opcion no válida!");
                    break;
            }

        }
        while (opcion != SALIR);
    }

    static string MostrarMenuYEscoger() 
    {
        Console.WriteLine("===============MENU===============");
        Console.WriteLine("1" + "-Añadir un libro");
        Console.WriteLine("2"+ "-Mostrar todos los libros");
        Console.WriteLine("3" + "-Buscar por título");
        Console.WriteLine("4" + "-Buscar entre fechas");
        Console.WriteLine("5" + "-Modificar libro");
        Console.WriteLine("6" + "-Borrar libro");
        Console.WriteLine("7" + "-Revisar ortografía");
        Console.WriteLine("S" + "-Salir");
        Console.WriteLine();
        Console.Write("Opción?: ");
        return Console.ReadLine().ToUpper();
    }

    static void AnyadirLibro(ref Libro[] libros, ref ushort cantidad, ushort maximo)
    {
        if (cantidad >= maximo)
        {
            Console.WriteLine("Biblioteca llena");
        }
        else
        {
            libros[cantidad].titulo = PedirNoVacio("Titulo?: ");
            libros[cantidad].autor = PedirNoVacio("Autor?: ");

            // Año -1 si no se escribe nada
            string anyo = Pedir("Año de publicacion?: ");
            if (anyo == "")
            {
                libros[cantidad].anyoPubli = -1;
            }
            else
            {
                libros[cantidad].anyoPubli = Convert.ToInt16(anyo);
            }

            cantidad++;

            Ordenar(ref libros, cantidad);
        }
    }
    
    static void Ordenar(ref Libro[] libros, ushort cantidad)
    {
        for (int i = 0; i < cantidad - 1; i++)
        {
            for (int j = i + 1; j < cantidad; j++)
            {
                if (string.Compare(libros[i].titulo, libros[j].titulo, true) > 0)
                {
                    Libro aux = libros[i];
                    libros[i] = libros[j];
                    libros[j] = aux;
                }
            }
        }
    }

    static void MostrarLibros(ref Libro[] libros, ushort cantidad, byte bloque)
    {
        if (cantidad == 0)
            Console.WriteLine("Sin datos");
        else
            for (int i = 0; i < cantidad; i++)
            {
                string anyoMostrar = Convert.ToString(
                    libros[i].anyoPubli);

                if (anyoMostrar == "-1")
                    anyoMostrar = "Año desconocido";

                Console.WriteLine(
                    "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    i + 1, libros[i].titulo, libros[i].autor,
                    anyoMostrar);

                if ((i + 1) % bloque == 0)
                {
                    Console.ReadLine();
                }
            }
        Console.WriteLine();
    }

    static void BuscarTitulo(ref Libro[] libros, ushort cantidad) 
    {
        Console.Write("BUSCAR. Titulo?: ");
        string buscar = Console.ReadLine();
        if (buscar != "")
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (libros[i].titulo.ToUpper().Contains(buscar.ToUpper())
                    || libros[i].autor.ToUpper().Contains(buscar.ToUpper()))
                {
                    Console.WriteLine(
                        "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                        i + 1, libros[i].titulo, libros[i].autor,
                        libros[i].anyoPubli);
                }
            }
        }
    }

    static void BuscarFecha(ref Libro[] libros, ushort cantidad)
    {
        Console.WriteLine("BUSCAR. RANGO AÑO DE PUBLICACION");
        Console.Write("Entre año: ");
        ushort fecha1 = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Y año: ");
        ushort fecha2 = Convert.ToUInt16(Console.ReadLine());

        // Invertir fechas si están al revés
        ushort fechaInicial = fecha1 > fecha2 ? fecha1 : fecha2;
        ushort fechaFinal = fecha1 < fecha2 ? fecha1 : fecha2;

        for (int i = 0; i < cantidad; i++)
        {
            if (libros[i].anyoPubli >= fechaInicial &&
                    libros[i].anyoPubli <= fechaFinal)
            {
                Console.WriteLine(
                    "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    i + 1, libros[i].titulo, libros[i].autor,
                    libros[i].anyoPubli);
            }
        }
    }

    static void Modificar(ref Libro[] libros, ushort cantidad)
    {
        Console.Write("Número de registro?: ");
        int numRegistro = Convert.ToInt32(Console.ReadLine());
        if (numRegistro >= 1 && numRegistro <= cantidad)
        {
            Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    numRegistro, libros[numRegistro - 1].titulo,
                    libros[numRegistro - 1].autor,
                    libros[numRegistro - 1].anyoPubli);

            Console.Write("Titulo?: ");
            string cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libros[numRegistro - 1].titulo = cadenaAux;

            Console.Write("Autor?:");
            cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libros[numRegistro - 1].autor = cadenaAux;

            Console.Write("Año de publicacion?: ");
            cadenaAux = Console.ReadLine().Trim();
            if (cadenaAux != "")
                libros[cantidad].anyoPubli =
                    Convert.ToInt16(cadenaAux);
                    
            ComprobarMayusculas(libros[numRegistro - 1]);
        }
    }

    static void Borrar(ref Libro[] libros, ref ushort cantidad)
    {
        int numRegistro;
        Console.Write("Numero de registro?: ");
        numRegistro = Convert.ToInt32(Console.ReadLine());
        if (numRegistro >= 1 && numRegistro <= cantidad)
        {
            Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    numRegistro, libros[numRegistro - 1].titulo,
                        libros[numRegistro - 1].autor,
                            libros[numRegistro - 1].anyoPubli);
            Console.Write(
                "Seguro que quieres borrar este libro? Si/No:");
            string siNo = Console.ReadLine().ToUpper();
            if (siNo == "SI" || siNo == "S")
            {
                for (int i = numRegistro - 1; i < cantidad; i++)
                {
                    libros[i] = libros[i + 1];
                }
                cantidad--;
            }
        }
    }

    static void ComprobarOrtografia(ref Libro[] libros, ushort cantidad)
    {
        for (int i = 0; i < cantidad; i++)
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
            if (titulo[0] == ' ' || titulo[longitud - 1] == ' ')
            {
                fichaCorrecta = false;
            }

            // Minúscula justo antes de mayúscula
            for (int l = 0; l < longitud - 1; l++)
            {

                if ((titulo[l] >= 'a') && (titulo[l] <= 'z')
                    && (titulo[l + 1] >= 'A') && (titulo[l + 1] <= 'Z'))
                {
                    fichaCorrecta = false;
                }
            }

            if (!fichaCorrecta)
            {
                Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    i + 1, libros[i].titulo,
                        libros[i].autor, libros[i].anyoPubli);
                Console.Write("¿Desea arreglar este registro (s/n)? ");
                string corregir = Console.ReadLine().ToUpper();
                if (corregir == "S")
                {
                    libros[i].titulo = libros[i].titulo.Trim();
                    libros[i].titulo = QuitarEspaciosRedundantes(libros[i].titulo);
                    libros[i].titulo = CorregirMayusculas(libros[i].titulo);
                }
            }
        }
    }

    
    static void ComprobarMayusculas(Libro l)
    {
        // Avisos de mayúsculas, minúsculas, espacios
        if (l.autor == l.autor.ToUpper()) Console.WriteLine("Cuidado: Autor en mayúsculas");
        if (l.titulo == l.titulo.ToUpper()) Console.WriteLine("Cuidado: Título en mayúsculas");
        if (l.autor == l.autor.ToLower()) Console.WriteLine("Cuidado: Autor en minúsculas");
        if (l.titulo ==l.titulo.ToLower()) Console.WriteLine("Cuidado: Título en inúsculas");
        if (l.autor.Contains("  ")) Console.WriteLine("Cuidado: Autor con espacios de sobra");
        if (l.titulo.Contains("  ")) Console.WriteLine("Cuidado: Título con espacios de sobra");
    }


    static string Pedir(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }

    
    static string PedirNoVacio(string mensaje)
    {
        string respuesta;
        
        do
        {
            Console.Write(mensaje);
            respuesta = Console.ReadLine();
        }
        while (respuesta == "");
        
        return respuesta;
    }
    
    static string QuitarEspaciosRedundantes(string texto)
    {
        while (texto.Contains("  "))
            texto = texto.Replace("  ", " ");
        return texto;
    }
    
    static string CorregirMayusculas(string texto)
    {
        // Fase 1: 1ª mayúscula, resto minúscula
        texto = texto.ToUpper()[0] + texto.ToLower().Substring(1);
        // Fase 2: Mays tras cada punto
        bool proxMayuscula = false;
        for (int l = 1; l < texto.Length - 1; l++)
        {
            if (texto[l - 1] == '.')
                proxMayuscula = true;

            if ((texto[l] >= 'a') && (texto[l] <= 'z')
                && proxMayuscula)
            {
                texto = texto.Insert(l, texto.ToUpper().Substring(l, 1));
                texto = texto.Remove(l + 1, 1);
                proxMayuscula = false;
            }
        }
        return texto;
    }
}
