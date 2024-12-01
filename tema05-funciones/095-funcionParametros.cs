/* 95. Crea una función llamada "ComprobarAsignatura", que escriba en pantalla 
"Se me va dando mejor " seguido del texto que se indique como parámetro (de 
tipo "string"). Empléala en un programa que pregunte al usuario una asignatura 
y luego le responda algo como "Se me va dando mejor Bases de datos". En este 
caso, la función debe estar declarada antes de "Main". */


using System;

public class Ejercicio95
{
    static void ComprobarAsignatura(string texto)
    {
        Console.WriteLine("Se me va dando mejor {0}", texto);
    }
    
    static void Main()
    {
        Console.Write("Dime la asignatura: ");
        string a = Console.ReadLine();
        ComprobarAsignatura(a);
    }
}
