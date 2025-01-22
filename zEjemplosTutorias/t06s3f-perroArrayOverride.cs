// Crea una nueva versión del array formado por varios perros. 
// Emplea "virtual" y "override".


using System;

// -----------------------

class Perro
{
    protected string nombre;

    public virtual void Ladrar()
    {
        Console.WriteLine("Guau");
    }
}

class Dalmata : Perro
{
    public override void Ladrar()
    {
        Console.WriteLine("Auuuuuuu");
    }
}

class PruebaDePerros
{
    static void Main()
    {
        Perro p1 = new Perro();
        p1.Ladrar();

        Dalmata d1 = new Dalmata();
        d1.Ladrar();

        Perro[] perros = new Perro[2];
        perros[0] = p1;
        perros[1] = d1;
        for (int i = 0; i < perros.Length; i++)
        {
            perros[i].Ladrar();
        }
    }
}


//Guau
//Auuuuuuu
//Guau
//Auuuuuuu
