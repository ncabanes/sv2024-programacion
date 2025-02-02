/* 160. Crea una clase "Medio", que permita guardar información sobre un
archivo multimedia genérico. Tendrá como atributos: autor, tamaño (en KB),
formato (por ejemplo, MPEG4). También debes crear los "setters" y los "getters"
(convencionales) para leer o cambiar estos atributos. Crea también un
constructor, que permita asignar un valor a los tres atributos cuando se crea
un objeto, así como un segundo constructor que sólo detalle el tamaño y el
formato, dejando el autor con el valor "(Desconocido)". Un constructor deberá
apoyarse en otro empleando "this". Su método ToString deberá devolver el autor,
el tamaño y el formato, en una única línea de texto.

Crea una clase "Imagen", que herede de "Medio" y añada los atributos "ancho"
(por ejemplo, 1600) y "alto", con su correspondiente Set y Get, así como un
(único) constructor específico, que se apoyará en el de la clase superior. Su
método ToString añadirá el ancho y el alto al ToString de la clase base.

Crea una clase "Sonido", también basada en "Medio", con los atributos "estereo"
(booleano), "kbps" (por ejemplo, 192) y "duración" (en segundos), sus setters y
getters y un constructor. Su método ToString se basará en el de la superclase.

Crea una clase "Video", también heredando de "Medio", que ampliará con los
atributos "códec" (por ejemplo, H.264), "ancho" (por ejemplo, 1600), "alto" y
"duracion" (en segundos), sus setters y getters y un constructor adecuado. Su
método ToString se apoyará en el de la clase base.

Finalmente, crea una clase "PruebaDeMedios". con un programa de prueba que cree
al menos un elemento de cada uno de los tipos anteriores, así como un array con
al menos dos elementos de diferentes tipos y luego muestre los datos de todos
ellos en pantalla. */

using System;

class PruebaDeMedios
{
    static void Main()
    {
        Medio[] medios = new Medio[6];

        medios[0] = new Sonido("L. van Beethoven", 186, "Mp3", true, 1440, 3956);
        medios[1] = new Imagen("Robert Capa", 2589, "jpg", 8000, 6000);
        medios[2] = new Video("George Lucas", 6589, "mkv", "H.264", 3840, 2160, 7380);
        medios[3] = new Sonido("W. A. Mozart", 3567, "Wav", true, 1256, 3812);
        medios[4] = new Imagen("Ansel Adams", 3589, "png", 4000, 3000);
        medios[5] = new Video("Billy Wilder", 5832, "Mp4", "H.264", 3840, 2160, 8922);

        foreach (var m in medios)
        {
            Console.WriteLine(m);
        }
    }
}

// ---------------------

class Medio
{
    protected string autor;
    protected ulong tamanyo;
    protected string formato;

    public string GetAutor() { return autor; }
    public ulong GetTamanyo() { return tamanyo; }
    public string GetFormato() { return formato; }

    public void SetAutor(string autor) { this.autor = autor; }
    public void SetTamanyo(ulong tamanyo) { this.tamanyo = tamanyo; }
    public void SetFormato(string formato) { this.formato = formato; }

    public Medio(string autor, ulong tamanyo, string formato)
    {
        this.autor = autor;
        this.tamanyo = tamanyo;
        this.formato = formato;
    }

    public Medio(ulong tamanyo, string formato)
        : this("(Desconocido)", tamanyo, formato)
    {
    }

    public override string ToString()
    {
        return "Autor: " + autor + " - Tamaño: " + tamanyo +
            " KB - Formato: " + formato;
    }
}

// ---------------------

class Imagen : Medio
{
    protected ushort ancho;
    protected ushort alto;

    public ushort GetAncho() { return ancho; }
    public ushort GetAlto() { return alto; }

    public void SetAncho(ushort ancho) { this.ancho = ancho; }
    public void SetAlto(ushort alto) { this.alto = alto; }

    public Imagen(string autor, ulong tamanyo, string formato, ushort ancho,
        ushort alto) : base(autor, tamanyo, formato)
    {
        this.ancho = ancho;
        this.alto = alto;

    }

    public override string ToString()
    {
        return "Imagen - " + base.ToString() + " - Ancho: " + ancho + " - Alto: " + alto;
    }

}

// ---------------------

class Sonido : Medio
{

    protected bool estereo;
    protected uint kbps;
    protected uint duracion;

    public bool GetEstereo() { return estereo; }
    public uint Getkbps() { return kbps; }
    public uint Getduracion() { return duracion; }

    public void SetEstereo(bool estereo) { this.estereo = estereo; }
    public void Setkbps(uint kbps) { this.kbps = kbps; }
    public void SetDuracion(uint duracion) { this.duracion = duracion; }

    public Sonido(string autor, ulong tamanyo, string formato, bool estereo,
        uint kbps, uint duracion) : base(autor, tamanyo, formato)
    {
        this.estereo = estereo;
        this.kbps = kbps;
        this.duracion = duracion;
    }

    public override string ToString()
    {
        return "Sonido - " + base.ToString() + " - Estereo: " + estereo + " - Velocidad de bits :" +
            kbps + " - Duración: " + duracion;
    }
}

// ---------------------

class Video : Medio
{
    protected string codec;
    protected ushort ancho;
    protected ushort alto;
    protected ulong duracion;

    public string GetCodec() { return codec; }
    public ushort GetAncho() { return ancho; }
    public ushort GetAlto() { return alto; }
    public ulong GetDuracion() { return duracion; }

    public void SetCodec(string codec) { this.codec = codec; }
    public void SetAncho(ushort ancho) { this.ancho = ancho; }
    public void SetAlto(ushort alto) { this.alto = alto; }
    public void SetDuracion(ulong duracion) { this.duracion = duracion; }

    public Video(string autor, ulong tamanyo, string formato, string codec,
        ushort ancho, ushort alto, ulong duracion)
        : base(autor, tamanyo, formato)
    {
        this.codec = codec;
        this.ancho = ancho;
        this.alto = alto;
        this.duracion = duracion;
    }

    public override string ToString()
    {
        return "Video  - " + base.ToString() + " - Codec: " + codec + " - Ancho: " + ancho +
            " - Alto: " + alto + " - Duración: " + duracion;
    }
}
