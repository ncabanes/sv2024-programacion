/* 161. Crea una nueva versión de la clase "Medio" y derivadas (ejercicio 160),
 * que no emplee "getters" y "setters" convencionales, sino propiedades 
 * en formato corto. */

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
    protected string Autor {  get; set; }
    protected ulong Tamanyo { get; set; }
    protected string Formato { get; set; }

    public Medio(string autor, ulong tamanyo, string formato)
    {
        Autor = autor;
        Tamanyo = tamanyo;
        Formato = formato;
    }

    public Medio(ulong tamanyo, string formato)
        : this("(Desconocido)", tamanyo, formato)
    {
    }

    public override string ToString()
    {
        return "Autor: " + Autor + " - Tamaño: " + Tamanyo +
            " KB - Formato: " + Formato;
    }
}

// ---------------------

class Imagen : Medio
{
    protected ushort Ancho { get; set; }
    protected ushort Alto { get; set; }

    public Imagen(string autor, ulong tamanyo, string formato, ushort ancho,
        ushort alto) : base(autor, tamanyo, formato)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public override string ToString()
    {
        return "Imagen - " + base.ToString() + " - Ancho: " + Ancho + " - Alto: " + Alto;
    }

}

// ---------------------

class Sonido : Medio
{

    protected bool Estereo { get; set; }
    protected uint Kbps { get; set; }
    protected uint Duracion { get; set; }

    public Sonido(string autor, ulong tamanyo, string formato, bool estereo,
        uint kbps, uint duracion) : base(autor, tamanyo, formato)
    {
        Estereo = estereo;
        Kbps = kbps;
        Duracion = duracion;
    }

    public override string ToString()
    {
        return "Sonido - " + base.ToString() + " - Estereo: " + Estereo + " - Velocidad de bits :" +
            Kbps + " - Duración: " + Duracion;
    }
}

// ---------------------

class Video : Medio
{
    protected string Codec { get; set; }
    protected ushort Ancho { get; set; }
    protected ushort Alto { get; set; }
    protected ulong Duracion { get; set; }

    public Video(string autor, ulong tamanyo, string formato, string codec,
        ushort ancho, ushort alto, ulong duracion)
        : base(autor, tamanyo, formato)
    {
        Codec = codec;
        Ancho = ancho;
        Alto = alto;
        Duracion = duracion;
    }

    public override string ToString()
    {
        return "Video  - " + base.ToString() + " - Codec: " + Codec + " - Ancho: " + Ancho +
            " - Alto: " + Alto + " - Duración: " + Duracion;
    }
}
