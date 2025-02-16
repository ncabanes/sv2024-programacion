/*
180. Sistema domótico (examen del tema 6, grupo presencial, 2015-2016)

Se desea crear un esqueleto para un sistema domótico (de control 
informatizado de un hogar), usando un diseño orientado a objetos.

Para ello, se creará una clase "SistemaDomótico" (como ya sabes, en tu 
implementación no deberás usar acentos en los nombres de clases, 
variables o métodos), que englobará a todas las demás. El sistema 
estará previsto para controlar:

- Ventanas. Existirá una clase Ventana. A su vez, cada ventana 
contendrá una Persiana, con métodos Subir (que subirá la persiana por 
completo, para dejar pasar toda la luz) y Bajar (que la bajará por 
completo, para no dejar pasar nada de luz), junto con sus variantes 
sobrecargadas Subir(porcentaje) y Bajar(porcentaje), que se comportarán 
de la siguiente forma: si la persiana está subida en un 40% y se indica 
Subir(20), pasará a estar abierta en un 60%. También existirá un método 
Abrir(porcentaje), que dejará la persiana abierta exactamente en el 
porcentaje que se indica (por ejemplo, Abrir(50) dejaría la persiana 
justo en su posición central, independientemente de donde se encontrase 
anteriormente). El (único) constructor de una Persiana recibirá como 
parámetros la posición inicial de la persiana (0 para cerrada 
totalmente, 100 para abierta totalmente). El constructor de una ventana 
recibirá la persiana que contiene esa ventana (o null, si se trata de 
una ventana sin persiana). En Persiana existirá un método "get" que 
permitirá saber la posición y en Ventana un "get" para acceder a los 
detalles de su persiana.

- Toldos. Por simplicidad, a efectos de programación se considerará que 
un Toldo es un tipo de persiana y se emplearán los mismos métodos para 
configurarlos. El constructor de un Toldo recibirá como parámetro la 
posición inicial (0 para totalmente bajado). Existirá un método "get" 
que permitirá saber la posición.

- Puertas. Para una Puerta normal, sólo existirán los métodos Bloquear 
y Desbloquear, así como un "get" que permita saber si está bloqueada o 
no. El constructor indicará si inicialmente está bloqueada o no. 
Existirá un caso especial, las puertas de garaje, que tendrán métodos 
Subir, Subir(porcentaje), Bajar y Bajar(porcentaje), con comportamiento 
similar al de las ventanas.

- Calefacciones. Para cada Calefacción se podrá indicar la temperatura 
(en grados centígrados), así como Encender y Apagar ese subsistema de 
calefacción. Existirá un "GetTemperatura" y un "GetEncendido", para 
saber el estado. El constructor recibirá ambos datos como parámetros 
(el primer parámetro será si está encendida o no, el segundo será la 
temperatura). Existirá un segundo constructor que sólo reciba la 
temperatura y que prefijará esa temperatura pero dejará la calefacción 
apagada.

- El Horno tendrá un comportamiento similar al de la calefacción: 
temperatura y encender/apagar, con sus dos constructores y sus Get.

- Cada Luz se podrá encender o apagar y consultar su estado.

- Finalmente, también existirá un Aspirador robótico, que sólo se podrá 
encender o apagar, y para el que se podrá consultar si está encendido, 
así como el porcentaje de batería.

Todos los dispositivos tendrán un nombre (por ejemplo, "Ventana del 
salón" o "Calefacción del dormitorio 1"), un método SetNombre para 
fijarlo y un método ToString que devolverá la información relevante 
(por ejemplo, el nombre, la temperatura y el estado para una 
calefacción, o el nombre y la posición de un toldo).

La clase SistemaDomótico será la que interaccione con el usuario, para 
poder indicar qué comportamiento se desea de cada componente. En 
implementaciones reales será un panel táctil, pero en nuestra primera 
simulación será una aplicación de Consola que permitirá personalizar 
cada elemento del sistema (encender o apagar luces, subir o bajar 
persianas, etc).

El programa de prueba será un Main dentro de la clase SistemaDomótico, 
que añadirá 3 ventanas, una puerta de acceso, una puerta de garaje, un 
toldo, un punto de luz y dos calefacciones (todo ello dentro de un 
único array de dispositivos), y permitirá controlarlas mediante un menú 
que permita: bloquear o desbloquear la puerta de acceso, encender o 
apagar el punto de luz, subir por completo o bajar por completo la 
puerta del garaje, subir o bajar un 25% cada una de las tres persianas, 
recoger (subir) o extender (bajar) por completo el toldo, subir o bajar 
un grado cada calefacción, ver el estado de todos los dispositivos.  

Recuerda evitar código repetitivo tanto como sea posible, reutilizando 
constructores o métodos cuando corresponda y, si fuera necesario, 
creando clases adicionales. */

using System;

class SistemaDomotico
{
    static void Main()
    {
        Dispositivo[] dispositivos = new Dispositivo[9];
        ConfigurarDispositivosIniciales(dispositivos);
        string opcion;

        do
        {
            Console.WriteLine();
            MostrarMenu();
            opcion = Pedir("¿Opción?");

            switch(opcion)
            {
                case "1":
                    BloquearPuerta(dispositivos);
                    break;
                case "2":
                    DesbloquearPuerta(dispositivos);
                    break;
                case "3":
                    EncenderLuz(dispositivos);
                    break;
                case "4":
                    ApagarLuz(dispositivos);
                    break;
                case "5":
                    SubirPuerta(dispositivos);
                    break;
                case "6":
                    BajarPuerta(dispositivos);
                    break;
                case "7":
                    SubirPersianas(dispositivos);
                    break;
                case "8":
                    BajarPersianas(dispositivos);
                    break;
                case "9":
                    SubirToldo(dispositivos);
                    break;
                case "10":
                    BajarToldo(dispositivos);
                    break;
                case "11":
                    SubirCalefaccion(dispositivos);
                    break;
                case "12":
                    BajarCalefaccion(dispositivos);
                    break;
                case "13":
                    VerEstadoDispositivos(dispositivos);
                    break;
                case "0":
                    Console.WriteLine("Apagando terminal");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while (opcion != "0");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("------- MENU --------");
        Console.WriteLine("0. Salir");
        Console.WriteLine("1. Bloquear puerta de acceso");
        Console.WriteLine("2. Desbloquear puerta de acceso");
        Console.WriteLine("3. Encender luz");
        Console.WriteLine("4. Apagar luz");
        Console.WriteLine("5. Subir por completo la puerta del garaje");
        Console.WriteLine("6. Bajar por completo la puerta del garaje");
        Console.WriteLine("7. Subir un 25% cada una de las persianas");
        Console.WriteLine("8. Bajar un 25% cada una de las persianas");
        Console.WriteLine("9. Subir por completo el toldo");
        Console.WriteLine("10. Bajar por completo el toldo");
        Console.WriteLine("11. Subir un grado cada calefacción");
        Console.WriteLine("12. Bajar un grado cada calefacción");
        Console.WriteLine("13. Ver el estado de todos los dispositivos");
    }


    static void BloquearPuerta(Dispositivo[] dispositivos)
    {
        ((Puerta)dispositivos[3]).Bloquear();
        Console.WriteLine("Puerta de acceso bloqueada");
    }

    static void DesbloquearPuerta(Dispositivo[] dispositivos)
    {
        ((Puerta)dispositivos[3]).Desbloquear();
        Console.WriteLine("Puerta de acceso desbloqueada");
    }


    static void EncenderLuz(Dispositivo[] dispositivos)
    {
        ((Luz)dispositivos[6]).Encender();
        Console.WriteLine("Luz encendida");
    }

    static void ApagarLuz(Dispositivo[] dispositivos)
    {
        ((Luz)dispositivos[6]).Apagar();
        Console.WriteLine("Luz apagada");
    }


    static void SubirPuerta(Dispositivo[] dispositivos)
    {
        ((PuertaGaraje)dispositivos[4]).Subir();
    }

    static void BajarPuerta(Dispositivo[] dispositivos)
    {
        ((PuertaGaraje)dispositivos[4]).Bajar();
    }


    static void BajarPersianas(Dispositivo[] dispositivos)
    {
        ((Ventana)dispositivos[1]).GetPersiana().Bajar(25);
        ((Ventana)dispositivos[2]).GetPersiana().Bajar(25);

        Console.WriteLine("Persianas bajadas un 25%");
    }

    static void SubirPersianas(Dispositivo[] dispositivos)
    {
        ((Ventana)dispositivos[1]).GetPersiana().Subir(25);
        ((Ventana)dispositivos[2]).GetPersiana().Subir(25);

        Console.WriteLine("Persianas subidas un 25%");
    }


    static void BajarToldo(Dispositivo[] dispositivos)
    {
        ((Toldo)dispositivos[5]).Bajar();
        Console.WriteLine("Toldo bajado por completo");
    }

    static void SubirToldo(Dispositivo[] dispositivos)
    {
        ((Toldo)dispositivos[5]).Subir();
        Console.WriteLine("Toldo subido por completo");
    }


    static void SubirCalefaccion(Dispositivo[] dispositivos)
    {
        ((Calefaccion)dispositivos[7]).SetTemperatura(
            Convert.ToByte(((Calefaccion)dispositivos[7]).GetTemperatura() + 1));

        ((Calefaccion)dispositivos[8]).SetTemperatura(
            Convert.ToByte(((Calefaccion)dispositivos[8]).GetTemperatura() + 1));
    }

    static void BajarCalefaccion(Dispositivo[] dispositivos)
    {
        ((Calefaccion)dispositivos[7]).SetTemperatura(
            Convert.ToByte(((Calefaccion)dispositivos[7]).GetTemperatura()-1));

        ((Calefaccion)dispositivos[8]).SetTemperatura(
            Convert.ToByte(((Calefaccion)dispositivos[8]).GetTemperatura() - 1));
    }


    static void VerEstadoDispositivos(Dispositivo[] dispositivos)
    {
        for(int i = 0; i < dispositivos.Length; i++)
        {
            Console.WriteLine(dispositivos[i]);
        }
    }

    static void ConfigurarDispositivosIniciales(Dispositivo[] dispositivos)
    {
        Persiana persiana1 = new Persiana(40);
        persiana1.SetNombre("Persiana salón");
        Persiana persiana2 = new Persiana(60);
        persiana1.SetNombre("Persiana cocina");

        dispositivos[0] = new Ventana(null);
        dispositivos[0].SetNombre("Ventana habitación");
        dispositivos[1] = new Ventana(persiana1);
        dispositivos[1].SetNombre("Ventana salón");
        dispositivos[2] = new Ventana(persiana2);
        dispositivos[2].SetNombre("Ventana cocina");
        dispositivos[3] = new Puerta(false);
        dispositivos[3].SetNombre("Puerta de acceso");
        dispositivos[4] = new PuertaGaraje(0);
        dispositivos[4].SetNombre("Puerta Garaje");
        dispositivos[5] = new Toldo(0);
        dispositivos[5].SetNombre("Toldo entrada");
        dispositivos[6] = new Luz(false);
        dispositivos[6].SetNombre("Luz cocina");
        dispositivos[7] = new Calefaccion(15);
        dispositivos[7].SetNombre("Calefacción habitación");
        dispositivos[8] = new Calefaccion(20);
        dispositivos[8].SetNombre("Calefacción salón");
    }

    static string Pedir(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Console.ReadLine();
    }
}

// --------------------------

abstract class Dispositivo
{
    protected string nombre;

    public void SetNombre(string nombre) { this.nombre = nombre; }

    public override string ToString()
    {
        return "Nombre: " + nombre;
    }
}

// --------------------------

abstract class AparatoEncendible : Dispositivo
{
    protected bool encendida;

    public AparatoEncendible(bool encendida)
    {
        this.encendida = encendida;
    }

    public string GetEstado()
    {
        if(encendida)
        {
            return "Encendida";
        }
        else
        {
            return "Apagada";
        }
    }

    public void Encender()
    {
        encendida = true;
    }

    public void Apagar()
    {
        encendida= false;
    }

    public override string ToString()
    {
        return base.ToString() + " Estado: " + GetEstado();
    }
}

// --------------------------

class AspiradorRobotico : AparatoEncendible
{
    protected byte porcentajeBateria;
    public AspiradorRobotico(bool encendida) : base(encendida) { }

    public AspiradorRobotico(byte porcentajeBateria, bool encendida) :
        base(encendida)
    {
        this.porcentajeBateria= porcentajeBateria;
    }

    public byte GetPorcentajeBateria() { return porcentajeBateria; }

    public void IndicarPorcentaje(byte porcentajeBateria)
    {
        if(porcentajeBateria >= 100)
        {
            this.porcentajeBateria= porcentajeBateria;
        }
        else if(porcentajeBateria <= 0)
        {
            this.porcentajeBateria = 0;
        }
        else
        {
            this.porcentajeBateria = porcentajeBateria;
        }
    }

    public override string ToString()
    {
        return base.ToString() + " Porcentaje de la batería: " + porcentajeBateria;
    }
}

// --------------------------

class Calefaccion : ElementoCalefactable
{
    public Calefaccion(bool encendido, byte temperatura) :
        base(encendido, temperatura)
    { }

    public Calefaccion(byte temperatura) : base (temperatura) { }


    public override string ToString()
    {
        return base.ToString();
    }
}


// --------------------------

abstract class ElementoCalefactable : Dispositivo
{
    protected byte temperatura;
    protected bool encendido;

    public ElementoCalefactable(bool encendido,byte temperatura)
    {
        this.encendido = encendido;
        this.temperatura = temperatura;
    }

    public ElementoCalefactable(byte temperatura)
    {
        this.temperatura=temperatura;
        encendido = false;
    }

    public byte GetTemperatura() { return temperatura; }
    public string GetEncendido()
    {
        if (encendido)
        {
            return "Encendida";
        }
        else
        {
            return "Apagada";
        }
    }

    public void SetTemperatura(byte temperatura)
    {
        this.temperatura = temperatura;
    }

    public void Encender()
    {
        encendido = true;
    }

    public void Apagar()
    {
        encendido = false;
    }

    public override string ToString()
    {
        return base.ToString() + " Temperatura: " + temperatura +"ºC" +
            " Estado: " + GetEncendido();
    }
}

// --------------------------

class Horno : ElementoCalefactable
{
    public Horno(bool encendido, byte temperatura) :
        base(encendido,temperatura) { }
    public Horno(byte temperatura) : base(temperatura) { }

    public override string ToString()
    {
        return base.ToString();
    }
}

// --------------------------

class Luz : AparatoEncendible
{
    public Luz(bool encendida) : base(encendida) { }

}

// --------------------------

class Persiana : Dispositivo
{
    protected int posicion;

    public Persiana(int posicion)
    {
        if(posicion >= 100)
        {
            this.posicion = 100;
        }
        else if(posicion <= 0)
        {
            this.posicion = 0;
        }
        else
        {
            this.posicion = posicion;
        }
    }

    public int GetPosicion() { return posicion; }

    public void Subir()
    {
        this.posicion = 100;
    }

    public void Bajar()
    {
        this.posicion = 0;
    }

    public void Subir(int porcentaje)
    {
        int nuevaPosicion = porcentaje + posicion;

        if(nuevaPosicion >= 100)
        {
            posicion = 100;
        }
        else
        {
            posicion = nuevaPosicion;
        }
    }

    public void Bajar(int porcentaje)
    {
        int nuevaPosicion = posicion - porcentaje;
        if(nuevaPosicion <= 0)
        {
            posicion = 0;
        }
        else
        {
            posicion = nuevaPosicion;
        }
    }

    public void Abrir(int porcentaje)
    {
        if(porcentaje >= 100)
        {
            posicion = 100;
        }
        else if(porcentaje <= 0)
        {
            posicion = 0;
        }
        else
        {
            posicion = porcentaje;
        }
    }

    public override string ToString()
    {
        return base.ToString() + " Posición: " + posicion;
    }
}

// --------------------------

class Puerta : Dispositivo
{
    protected bool bloqueada;

    public Puerta(bool bloqueada)
    {
        this.bloqueada = bloqueada;
    }

    public string GetBloqueada()
    {
        if(bloqueada)
        {
            return "Bloqueada";
        }
        else
        {
            return "Desbloqueada";
        }
    }

    public void Desbloquear()
    {
        bloqueada = false;
    }

    public void Bloquear()
    {
        bloqueada = true;
    }

    public override string ToString()
    {
        return base.ToString() + " Estado de la puerta: " + GetBloqueada();
    }
}

// --------------------------

class PuertaGaraje : Persiana
{
    public PuertaGaraje(int posicion): base(posicion) { }
}

// --------------------------

class Toldo : Persiana
{
    public Toldo(int posicion) : base(posicion)
    {
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

// --------------------------

class Ventana : Dispositivo
{
    protected Persiana persiana;

    public Ventana(Persiana persiana)
    {
        this.persiana = persiana;
    }

    public Persiana GetPersiana() { return persiana; }

    public override string ToString()
    {
        if(persiana == null)
        {
            return base.ToString() + " - La ventana no tiene persiana";
        }
        else
        {
            return base.ToString() + " - PERSIANA: " + persiana;
        }

    }
}

