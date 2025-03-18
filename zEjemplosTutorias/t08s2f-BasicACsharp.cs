// Crea un conversor simple de lenguaje BASIC a C#,
// que sea capaz de convertir los ficheros de ejemplo
// que tienes compartidos.

using System;
using System.IO;

class Ejemplo
{

    static void Main()
    {
        StreamReader ficheroBasic = new StreamReader("ejemplo1.bas");
        StreamWriter ficheroCsharp = new StreamWriter("ejemplo1.cs");
        string linea;

        ficheroCsharp.WriteLine("class fuenteBasic");
        ficheroCsharp.WriteLine("{");
        ficheroCsharp.WriteLine("    static void Main()");
        ficheroCsharp.WriteLine("    {");

        do
        {
            linea = ficheroBasic.ReadLine();
            if (linea != null)
            {
                //linea = linea.Replace("PRINT", "Console.ReadLine(");

                // Quito el número de línea
                int posEspacio = linea.IndexOf(' ');
                if ( posEspacio > 1)
                {
                    linea = linea.Substring(posEspacio+1);
                }
                
                // Analizo PRINT
                if (linea.StartsWith("PRINT "))
                {
                    linea = "        Console.WriteLine("+
                        linea.Substring(6)+
                        ");";
                }

                // Analizo INPUT
                if (linea.StartsWith("INPUT "))
                {
                    string nombreVariable = linea.Substring(6);
                    linea = "        int " + nombreVariable
                        + " = Convert.ToInt32( Console.ReadLine) );";
                }
                // Finalmente, vuelco
                ficheroCsharp.WriteLine(linea);
            }
        }
        while (linea != null);

        ficheroCsharp.WriteLine("    }");
        ficheroCsharp.WriteLine("}");

        ficheroCsharp.Close();
        ficheroBasic.Close();
    }
}
