// Tutoría del tema 2, semana 1 (if, switch)
// Ejercicio 5

/*
Pide al usuario el número de un mes. 
Respóndele el nombre del mes. 
Hazlo primero con "if" y luego con "switch".
*/

using System;

class NombreMes 
{
    static void Main() 
    {
        int mes;
        
        Console.Write("Dime el número de mes y te diré su nombre: ");
        mes = Convert.ToInt32( Console.ReadLine() );
        
        if (mes == 1)
        {
            Console.WriteLine("Enero");
        }
        else if (mes == 2)
        {
            Console.WriteLine("Febrero");
        }
        else if (mes == 3)
        {
            Console.WriteLine("Marzo");
        }
        else if (mes == 4)
        {
            Console.WriteLine("Abril");
        }
        else if (mes == 5)
        {
            Console.WriteLine("Mayo");
        }
        else if (mes == 6)
        {
            Console.WriteLine("Junio");
        }
        else if (mes == 7)
        {
            Console.WriteLine("Julio");
        }
        else if (mes == 8)
        {
            Console.WriteLine("Agosto");
        }
        else if (mes == 9)
        {
            Console.WriteLine("Septiembre");
        }
        else if (mes == 10)
        {
            Console.WriteLine("Octubre");
        }
        else if (mes == 11)
        {
            Console.WriteLine("Noviembre");
        }
        else if (mes == 12)
        {
            Console.WriteLine("Diciembre");
        }
        else 
        {
            Console.WriteLine("Del 1 al 12, por favor");
        }
        
        
        switch(mes)
        {
            case  1: Console.WriteLine("Enero"); break;
            case  2: Console.WriteLine("Febrero"); break;
            case  3: Console.WriteLine("Marzo");break;
            case  4: Console.WriteLine("Abril"); break;
            case  5: Console.WriteLine("Mayo"); break;
            case  6: Console.WriteLine("Junio"); break;
            case  7: Console.WriteLine("Julio"); break;
            case  8: Console.WriteLine("Agosto"); break;
            case  9: Console.WriteLine("Septiembre"); break;
            case 10: Console.WriteLine("Octubre"); break;
            case 11: Console.WriteLine("Noviembre"); break;
            case 12: Console.WriteLine("Diciembre"); break;
            default: Console.WriteLine("Del 1 al 12, por favor"); break;
        }
    }
}

