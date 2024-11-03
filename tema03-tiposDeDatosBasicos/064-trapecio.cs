// 64. Escribe un programa que pida un ancho y un alto (ambos serán "byte"),
// así como un carácter, y muestre un trapecio de tamaño descendente como éste:
//*********
// *******
//  *****

// Pablo (...)

using System;
class MainClass
{
	static void Main()
	{
		Console.WriteLine("Introduce ancho de la base menor: ");
		byte anchura = Convert.ToByte(Console.ReadLine());
		
		Console.WriteLine("Introduce alto: ");
		byte altura = Convert.ToByte(Console.ReadLine());
		
		byte anchuraActual = (byte)(anchura + (altura - 1) * 2);
		
		Console.WriteLine("Introduce un símbolo ");
		char pressedSymbol = Convert.ToChar(Console.ReadLine());
		
		byte espacios = 0;
		
		for (int i = 0; i < altura; i++)
		{
			for (int k = 0; k < espacios; k++)
			{
				Console.Write(" ");
			}
		
			for (int j = 0; j < anchuraActual ; j++)
			{	
				Console.Write(pressedSymbol);
			}
			anchuraActual -=2;
			espacios ++;
			Console.WriteLine();
		}
	}
}
