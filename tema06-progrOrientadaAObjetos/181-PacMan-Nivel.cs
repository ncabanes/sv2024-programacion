/* 181. (Este ejercicio es INDUDABLEMENTE NO OBLIGATORIO; si lo 
intentas, no le dediques demasiado tiempo, porque es muy distinto de lo 
que sería un ejercicio de examen). Si quieres un reto mayor en cuanto a 
juegos en consola, crea una nueva versión de PacMan (ejercicio 166), 
partiendo de la solución oficial, con los siguientes cambios:

- Debe existir una clase "Nivel", que represente un nivel del juego 
(con su laberinto y sus píldoras de 2 tamaños: "." y "o" ). Tendrá un 
método Mostrar(), que dibuje el nivel en pantalla, así como un método 
bool EsPosibleMoverA(x, y), que permitirá saber si tanto Pac como los 
fantasmas pueden moverse a una cierta casilla o no, y un método int 
ObtenerPuntosDe(x, y), que permitirá saber qué puntos se obtendrán en 
cierta posición del laberinto cuando Pac se desplace a ella (y 
eliminará la píldora correspondiente).

- No es necesario que el movimiento de los fantasmas recuerde al 
original, ni que gestiones los cambios de estado de los fantasmas, ni 
ningún otro detalle más avanzado.

- Pac sólo podrá moverse a posiciones factibles.

- Habrá un marcador que muestre los puntos obtenidos.

- La partida terminará si se recogen todas las píldoras o si algún 
fantasma alcanza a Pac.

*/

using System;

abstract class SpriteModoTexto
{
    protected int x, y;
    protected char caracter;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public char GetCaracter() { return caracter; }

    public void SetX(int setx) { x = setx; }
    public void SetY(int sety) { y = sety; }
    public void SetCaracter(char c) { caracter = c; }

    public SpriteModoTexto(int x, int y, char caracter)
    {
        this.x = x;
        this.y = y;
        this.caracter = caracter;
    }

    public virtual void Dibujar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(caracter);
        Console.ResetColor();
    }

    public void MoverDerecha() { if (x < Console.WindowWidth - 1) x++; }
    public void MoverIzquierda() { if (x > 0) x--; }
    public void MoverArriba() { if (y > 0) y--; }
    public void MoverAbajo() { if (y < Console.WindowHeight - 1) y++; }

    public bool ColisionaCon(SpriteModoTexto otro)
    {
        return this.x == otro.x && this.y == otro.y;
    }
}
// ------------------------------------

class Fantasma : SpriteModoTexto
{
    public Fantasma(int x, int y) : base(x, y, 'A') { }
    public Fantasma() : this(10, 10) { }
    public virtual void Mover() { }
}

// ------------------------------------

class FantasmaAzul : Fantasma
{
    public FantasmaAzul(int x, int y) : base(x, y) { }
    public FantasmaAzul() : this(1, 1) { }
    public override void Mover() { MoverDerecha(); }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Dibujar();
    }
}

// ------------------------------------

class FantasmaNaranja : Fantasma
{
    public FantasmaNaranja(int x, int y) : base(x, y) { }
    public FantasmaNaranja() : this(16, 1) { }
    public override void Mover() { MoverIzquierda(); }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        base.Dibujar();
    }
}

// ------------------------------------

class FantasmaRojo : Fantasma
{
    public FantasmaRojo(int x, int y) : base(x, y) { }
    public FantasmaRojo() : this(1, 8) { }
    public override void Mover() { MoverArriba(); }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Dibujar();
    }
}

// ------------------------------------

class FantasmaRosa : Fantasma
{
    public FantasmaRosa(int x, int y) : base(x, y) { }
    public FantasmaRosa() : this(16, 8) { }
    public override void Mover() { MoverAbajo(); }
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        base.Dibujar();
    }
}

// ------------------------------------

class Pac : SpriteModoTexto
{
    public Pac(int x, int y)
        : base(x, y, 'C')
    {
    }
    
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        base.Dibujar();
    }
}


// ----------

class Nivel
{
    private char[,] laberinto;
    private int pildorasPequenas { get; set; }
    private int pildorasGrandes { get; set; }

    const int FILAS = 10;
    const int COLUMNAS = 18;

    public Nivel()
    {
        laberinto = new char[,]
        {
            {'|','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','|' },
            {'|',' ','|','.','|',' ','o',' ',' ','|',' ','|','o',' ','|',' ',' ','|' },
            {'|','.','|',' ','o',' ',' ','|',' ','|',' ',' ',' ',' ','|',' ','.','|' },
            {'|',' ','|',' ',' ',' ',' ','|',' ','|',' ','.','|',' ','|',' ',' ','|' },
            {'|',' ',' ',' ',' ','|','.','|','o',' ',' ',' ','|',' ','|',' ',' ','|' },
            {'|',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','|',' ','o',' ',' ',' ','|' },
            {'|',' ','o',' ','|','.',' ',' ',' ',' ','.','|',' ',' ','.',' ',' ','|' },
            {'|',' ','|',' ','|',' ',' ',' ','|',' ',' ','|',' ','|',' ',' ',' ','|' },
            {'|',' ','|','.','|',' ',' ','o','|',' ',' ',' ','.','|',' ','|','o','|' },
            {'|','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','-','|' }
        };
        pildorasGrandes = 8;
        pildorasPequenas = 10;
    }

    public void Mostrar()
    {
        Console.SetCursorPosition(0,0);
        for (int y = 0; y < FILAS; y++)
        {
            for (int x = 0; x < COLUMNAS; x++)
            {
                Console.Write(laberinto[y, x]);
            }
            Console.WriteLine();
        }
    }

    public bool EsPosibleMoverA(int x, int y)
    {
        if (x <= 0 || y <= 0 || x >= COLUMNAS-1 || y >= FILAS-1)
        {
            return false;
        }
        if (laberinto[y, x] == '|')
        {
            return false;
        }
        return true;
    }

    public int ObtenerPuntosDe(int x, int y)
    {
        int puntos = 0;
        if (laberinto[y,x] == '.')
        {
            laberinto[y,x] = ' ';
            puntos += 10;
            pildorasPequenas--;
        }
        if (laberinto[y,x] == 'o')
        {
            laberinto[y,x] = ' ';
            puntos += 25;
            pildorasGrandes--;
        }
        return puntos;
    }

    public bool TodasLasPildorasRecogidas()
    {
        return (pildorasGrandes == 0 && pildorasPequenas == 0);
    }
}

// ----------

class PacMan
{
    static void Main()
    {
        bool terminado = false;
        ConsoleKeyInfo tecla;
        int puntos = 0;
        Pac pac = new Pac(4, 5);
        Fantasma[] fantasmas = new Fantasma[4];
        fantasmas[0] = new FantasmaAzul();
        fantasmas[1] = new FantasmaRojo();
        fantasmas[2] = new FantasmaRosa();
        fantasmas[3] = new FantasmaNaranja();

        Nivel nivel = new Nivel();

        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            nivel.Mostrar();
            pac.Dibujar();

            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Puntos: " + puntos);

            for (int i = 0; i < 4; i++)
            {
                fantasmas[i].Dibujar();

                if (pac.ColisionaCon(fantasmas[i]))
                {
                    terminado = true;
                }
            }

            tecla = Console.ReadKey();

            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                if (nivel.EsPosibleMoverA(pac.GetX()-1, pac.GetY()))
                {
                    pac.MoverIzquierda();
                    puntos += nivel.ObtenerPuntosDe(pac.GetX(), pac.GetY());
                }
            }
            else if (tecla.Key == ConsoleKey.RightArrow)
            {
                if (nivel.EsPosibleMoverA(pac.GetX()+1, pac.GetY()))
                {
                    pac.MoverDerecha();
                    puntos += nivel.ObtenerPuntosDe(pac.GetX(), pac.GetY());
                }
            }
            else if (tecla.Key == ConsoleKey.UpArrow)
            {
                if (nivel.EsPosibleMoverA(pac.GetX(), pac.GetY()-1))
                {
                    pac.MoverArriba();
                    puntos += nivel.ObtenerPuntosDe(pac.GetX(), pac.GetY());
                }
            }
            else if (tecla.Key == ConsoleKey.DownArrow)
            {
                if (nivel.EsPosibleMoverA(pac.GetX(), pac.GetY()+1))
                {
                    pac.MoverAbajo();
                    puntos += nivel.ObtenerPuntosDe(pac.GetX(), pac.GetY());
                }
            }

            // Movimiento: fantasmas

            if ((nivel.EsPosibleMoverA(fantasmas[0].GetX()+1, fantasmas[0].GetY())))
            {
                fantasmas[0].Mover();
            }
            if ((nivel.EsPosibleMoverA(fantasmas[1].GetX(), fantasmas[1].GetY()-1)))
            {
                fantasmas[1].Mover();
            }
            if ((nivel.EsPosibleMoverA(fantasmas[2].GetX(), fantasmas[2].GetY() + 1)))
            {
                fantasmas[2].Mover();
            }
            if ((nivel.EsPosibleMoverA(fantasmas[3].GetX()-1, fantasmas[3].GetY())))
            {
                fantasmas[3].Mover();
            }
            Console.Clear();
        }
        while (tecla.Key != ConsoleKey.Escape
            && !terminado && !nivel.TodasLasPildorasRecogidas());

        if (terminado)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡Has perdido!");
        }
        else if (nivel.TodasLasPildorasRecogidas())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Enhorabuena por la victoria!");
        }

        Console.ResetColor();
    }
}

