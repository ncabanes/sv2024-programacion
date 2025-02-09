/*
170. Emuladores (examen del tema 6, grupo presencial, 2016-2017)

Se desea crear un emulador de múltiples ordenadores clásicos usando un 
diseño orientado a objetos.

Para ello, en primer lugar se considerará, de forma simplificada, que 
un Ordenador está formado únicamente por un Procesador y una Memoria. 
También nos interesará almacenar un nombre para cada ordenador. Los 
tres valores, en ese orden, se deberán indicar en el (único) 
constructor de la clase Ordenador. Sólo se creará un método Get para 
poder acceder a su nombre, pero también se incluirá un método ToString, 
que devolverá algo como "ZxSpectrum, procesador Z80, 8 bits, 3.5 MHz, 
16384 bytes de memoria".

Un Procesador contendrá una serie de posiciones internas de memoria, 
llamadas registros (por ejemplo A o AX). Por ello, queremos que esta 
clase contenga un único constructor, que recibirá tres parámetros: el 
primero será el número de bits del procesador (por ejemplo, 8); el 
segundo será la velocidad de proceso, medida en Megahertzios (por 
ejemplo, 3.58) y el tercero será una cadena de texto que indicará los 
nombres de los registros separados por espacios (por ejemplo "A B C 
D"). Además, existirá un método AnadirOrden, que servirá para anotar 
órdenes que acepta este procesador. Estas órdenes se indicarán como dos 
parámetros de AnadirOrden. El primer parámetro indicará el código de 
esa orden (por ejemplo 121 en base decimal o 0x79 en base hexadecimal) 
y el segundo parámetro será el equivalente en ensamblador de esa orden 
(por ejemplo, "LD A, C"). Más adelante, todas las órdenes se 
almacenarán en una estructura de datos, como un array, pero esta 
primera versión no debe preocuparse aún de eso, sino que en ella, el 
método AnadirOrden estará vacío. También existirá un método 
MostrarOrdenes, que, en una versión posterior, mostraría toda la lista 
de órdenes que soporta el procesador, pero que por ahora sólo mostrará 
"Lista de órdenes aún no disponible". Igualmente, la clase Procesador 
tendrá métodos Get para su número de bits y para su velocidad de 
proceso. También tendrá un método "ToString", que devolverá algo como 
"8 bits, 3.5 MHz".

La clase Memoria contendrá un dos atributos: el tamaño y un array de 
bytes que contendrá la información real. Existirá un constructor que 
recibirá como parámetro el tamaño de la memoria, en bytes (por ejemplo, 
65536) y creará un array de bytes de ese tamaño. También se creará un 
segundo constructor, que recibirá el tamaño de la memoria (por ejemplo, 
65536) y el tamaño del bus de datos, medido en bits (por ejemplo, 8). 
Aun así, este constructor todavía no se va a implementar, así que 
delegará en el primer constructor e ignorará el dato del tamaño del bus 
de datos (pero contendrá un comentario TO DO en su interior, para 
recordar que se pretende implementar más adelante). La clase también 
tendrá métodos Get(dirección) para obtener el valor almacenado en una 
cierta posición de memoria y Set(dirección, valor) para guardar un 
cierto valor en una posición de memoria. También tendrá un método 
GetTamano, que devuelva su tamaño, medido en bytes.

Crea una clase ProcesadorZ80, que permita crear un procesador Zilog Z80 
o derivado. Esta clase contendrá un único constructor para indicar la 
velocidad en MHz (porque el número de bits quedará prefijado a 8 y los 
registros estarán prefijados a "A B C D E F H L"). Su MostrarOrdenes 
escribirá en pantalla el texto "Z80: " seguido del aviso que se ha 
indicado en la clase procesador. Su método ToString devolverá "Z80, " 
seguido del ToString de un procesador genérico.

Crea una clase Procesador6502, que permita crear un procesador MOS 6502 
o derivado. Esta clase contendrá un único constructor para indicar la 
velocidad en MHz (porque el número de bits quedará prefijado a 8 y los 
registros a "A X Y"). Su MostrarOrdenes escribirá en pantalla el texto 
"6502: " seguido del aviso previsto en la clase procesador. Su método 
ToString devolverá "6502, " seguido del ToString de un procesador 
genérico.

Crea un programa de prueba (clase Emuladores) que tenga un array de 
ordenadores. Los dos primeros ordenadores estarán prefijados: un 
ZxSpectrum, con procesador Z80 a 3.5 MHz y 16384 bytes de memoria, y un 
Commodore VIC-20, con procesador 6502 a 1.1 MHz y 5120 bytes de 
memoria. A continuación, el usuario podrá elegir qué ordenadores 
adicionales desea introducir en el array, mediante un menú que le 
pregunte si quiere añadir un equipo basado en el Z80 (opción 1) o en el 
6502 (opción 2), o bien si quiere ver todos los datos que se han 
introducido hasta el momento (opción 3) o terminar (opción 0). Cada vez 
que elija añadir un equipo, se le preguntará el nombre de éste, la 
velocidad en MHz y el tamaño de su memoria.
*/

using System;

class Emuladores
{
    const string TERMINAR = "0", ANYADIR_Z80 = "1", ANYADIR_6502 = "2", 
        VER_DATOS = "3";
    
    const int CAPACIDAD = 1000;
    Ordenador[] ordenadores;
    int numDatos = 0;

    public Emuladores()
    {
        ordenadores = new Ordenador[CAPACIDAD];

        Procesador p1 = new ProcesadorZ80(3.5f);
        Memoria m1 = new Memoria(16384);
        ordenadores[0] = new Ordenador(p1, m1, "ZxSpectrum");

        Procesador p2 = new Procesador6502(1.1f);
        Memoria m2 = new Memoria(5120);
        ordenadores[1] = new Ordenador(p2, m2, "Commodore VIC-20");

        numDatos += 2;
    }

    public void Prueba()
    {   
        Emuladores emulador = new Emuladores();
        bool salir = false;
        string opcion;
        do
        {
            MostrarMenu();
            opcion = Pedir("Elige una opción: ");

            switch (opcion) 
            {
                case ANYADIR_Z80: AnyadirZ80(); break;
                case ANYADIR_6502: Anyadir6502(); break;
                case VER_DATOS: VerDatos(); break;
                case TERMINAR: salir = true; break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
        }
        while (!salir);
    }

    private void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine(ANYADIR_Z80 + ". Añadir equipo basado en Z80;");
        Console.WriteLine(ANYADIR_6502 + ". Añadir equipo basado en 6502;");
        Console.WriteLine(VER_DATOS + ". Ver todos los datos introducidos");
        Console.WriteLine(TERMINAR + ". Terminar");
        Console.WriteLine();
    }

    private void AnyadirZ80()
    {
        string nombre = Pedir("Nombre del equipo: ");
        float velocidad = Convert.ToSingle(Pedir("Velocidad: "));
        int tamanyo = Convert.ToInt32(Pedir("Tamaño: "));
        Procesador p = new ProcesadorZ80(velocidad);
        Memoria m = new Memoria(tamanyo);
        ordenadores[numDatos] = new Ordenador(p, m, nombre);
        numDatos++;
    }

    private void Anyadir6502()
    {
        string nombre = Pedir("Nombre del equipo: ");
        float velocidad = Convert.ToSingle(Pedir("Velocidad: "));
        int tamanyo = Convert.ToInt32(Pedir("Tamaño: "));
        Procesador p = new Procesador6502(velocidad);
        Memoria m = new Memoria(tamanyo);
        ordenadores[numDatos] = new Ordenador(p, m, nombre);
        numDatos++;
    }

    private void VerDatos()
    {
        for (int i = 0; i < numDatos; i++)
        {
            Console.WriteLine(i + 1 + ". " + ordenadores[i]);
        }
    }

    public string Pedir(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }
    
    static void Main()
    {
        Emuladores e = new Emuladores();
        e.Prueba();
    }
}

// -----------------------

abstract class Procesador
{
    protected byte bits;
    protected float velocidad;
    protected string registros;

    public byte GetBits() {  return bits; }
    public float GetVelocidad() {  return velocidad; }

    public override string ToString()
    {
        return bits + " bits, " + velocidad + " MHz";
    }

    public Procesador(byte bits, float velocidad, string registros)
    {
        this.bits = bits;
        this.velocidad = velocidad;
        this.registros = registros;
    }

    public void AnadirOrden(byte codigo, string ensamblador)
    {
        // TO DO
    }

    public virtual void MostrarOrdenes()
    {
        Console.WriteLine("Lista de órdenes aún no disponible");
    }
}



// -----------------------

class ProcesadorZ80 : Procesador
{
    public ProcesadorZ80(float velocidad) : base (8, velocidad, 
        "A B C D E F H L")
    {
    }

    public override void MostrarOrdenes()
    {
        Console.Write("Z80: ");
        base.MostrarOrdenes();
    }

    public override string ToString()
    {
        return "Z80, " + base.ToString();
    }
}

// -----------------------

class Procesador6502 : Procesador
{
    public Procesador6502(float velocidad) : base(8, velocidad,
        "A X Y")
    {
    }

    public override void MostrarOrdenes()
    {
        Console.Write("6502: ");
        base.MostrarOrdenes();
    }

    public override string ToString()
    {
        return "6502, " + base.ToString();
    }
}

// -----------------------

class Memoria
{
    protected int tamanyo;
    protected int[] arrayBytes;

    public int GetValorArray(int direccion) {  return arrayBytes[direccion]; }
    public int GetTamanyo() {  return tamanyo; }
    public void SetValorArray(int direccion, int valor)
    {
        arrayBytes[direccion] = valor;
    }

    public Memoria (int tamanyo)
    {
        this.tamanyo = tamanyo;
        this.arrayBytes = new int[tamanyo];
    }

    public Memoria(int tamanyo, byte tamanyoBusDatos): this(tamanyo)
    {
        // TO DO
    }
}

// -----------------------

class Ordenador
{
    protected Procesador procesador;
    protected Memoria memoria;
    protected string nombre;

    public string GetNombre() { return nombre; }

    public Ordenador (Procesador procesador, Memoria memoria, string nombre)
    {
        this.procesador = procesador;
        this.memoria = memoria;
        this.nombre = nombre;
    }

    public override string ToString()
    {
        return nombre + ", procesador " + procesador + ", " + memoria.GetTamanyo() 
            + " bytes de memoria"; ;
    }
}

// -----------------------
