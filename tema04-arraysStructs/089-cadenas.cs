/* 
87. Crea un programa que solicite al usuario una cadena y:

- La convierta a mayúsculas (almacenando el resultado en una nueva cadena, que mostrará)

- La convierta a minúsculas (almacenando el resultado en una nueva cadena, que mostrará)

- Si tiene más de 4 letras, elimine la segunda letra y la tercera letra 
(almacenando el resultado en una nueva cadena, que mostrará)

- Si tiene más de 3 letras, Inserte "yo" después de la segunda letra 
(almacenando el resultado en una nueva cadena, que mostrará)

- Reemplace todos los espacios (' ') por guiones ('-') 
(almacenando el resultado en una nueva cadena, que mostrará)

- Elimine los espacios finales (almacenando el resultado en otra cadena, que mostrará)

- Elimine los espacios iniciales y finales (almacenando el resultado en otra cadena, que mostrará)

- Divida el texto en un array de strings, usando los espacios como separadores, 
y muestre las subcadenas resultantes, cada una en una línea.

- Divida el texto en un array de strings, usando como separadores las comas 
y los puntos, y muestre las subcadenas resultantes, cada una en una línea.

- Reemplace todos los espacios por guiones bajos, con la ayuda de un StringBuilder 
(almacenando el resultado en una nueva cadena, que mostrará)
*/

using System;
using System.Text;

class ManipulacionesCadenas
{

    static void Main()
    {
        string cadena;

        Console.Write("Dime una cadena: ");
        cadena = Console.ReadLine();

        // Convertir a mayus y guardar en una cadena nueva
        string cadenaMayus = cadena.ToUpper();
        Console.WriteLine(cadenaMayus);

        // Convertir a minúsculas y guardar en una cadena nueva
        string cadenaMinus = cadena.ToLower();
        Console.WriteLine(cadenaMinus);

        // Si tiene más de 4 letras, elimine la segunda letra
        // y la tercera letra y guardar en una cadena nueva
        string cadenaBorrar = cadena;
        if (cadena.Length > 4)
        {
            cadenaBorrar = cadena.Remove(1, 2);
        }
        Console.WriteLine(cadenaBorrar);

        // Si tiene más de 3 letras, Inserte "yo" después de la
        // segunda letra y guardar en una cadena nueva
        string cadenaInsertar = cadena;
        if (cadena.Length > 3)
        {
            cadenaInsertar = cadena.Insert(2, "yo");
        }
        Console.WriteLine(cadenaInsertar);

        // Reemplace todos los espacios (' ') por guiones ('-')
        string cadenaReplace = cadena.Replace(' ', '-');
        Console.WriteLine(cadenaReplace);
        
        // (Forma alternativa)
        string cadenaSplitJoin = cadena;
        string[] partes = cadena.Split();
        cadenaSplitJoin = string.Join("-", partes);
        Console.WriteLine(cadenaSplitJoin);


        // Elimina espacios finales y guardar en una nueva cadena
        string cadenaEliminarEspaciosFinal;
        cadenaEliminarEspaciosFinal = cadena.TrimEnd();
        Console.WriteLine(cadenaEliminarEspaciosFinal);

        // Elimina espacios iniciales y finales y guardar en una nueva cadena
        string cadenaEliminarEspaciosInicioFinal;
        cadenaEliminarEspaciosInicioFinal = cadena.Trim();
        Console.WriteLine(cadenaEliminarEspaciosInicioFinal);

        // Divida el texto en un array de strings, usando los espacios como separadores, 
        // y muestre las subcadenas resultantes, cada una en una línea
        string[] partes2 = cadena.Split();
        foreach (string palabra in partes2)
        {
            Console.WriteLine(palabra);
        }

        // Divida el texto en un array de strings, usando como separadores las comas
        // y los puntos, y muestre las subcadenas resultantes, cada una en una línea.
        string[] partes3 = cadena.Split(',', '.');
        foreach (string palabra in partes3)
        {
            Console.WriteLine(palabra);
        }

        // Reemplace todos los espacios por guiones bajos, con la ayuda de un StringBuilder 
        // (almacenando el resultado en una nueva cadena, que mostrará)
        StringBuilder cadenaBuilder = new StringBuilder(cadena);
        for (int i = 0; i < cadenaBuilder.Length; i++)
        {
            if (cadenaBuilder[i] == ' ')
            {
                cadenaBuilder[i] = '_';
            }
        }
        Console.WriteLine(cadenaBuilder);
    }
}
