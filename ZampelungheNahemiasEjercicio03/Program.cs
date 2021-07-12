using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZampelungheNahemiasEjercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
			int MaxContador;
			double TemprCel, TempFah, mayorTemp, menorTemp;
			double promedioTemp=0, TempMax;

			Console.Write("Ingrese la cantidad de temperaturas a ingresar:");
			MaxContador = Convert.ToInt32(Console.ReadLine());
			menorTemp = -70;
			mayorTemp = 60;
			TempMax = -71;

            for (int contadorTemp = 0; contadorTemp < MaxContador; contadorTemp++)
            {
				Console.Write($"Ingrese la temperatura Nº{contadorTemp + 1}:");
                do
                {
					TemprCel = Convert.ToDouble(Console.ReadLine());
                    if (TemprCel>menorTemp && TemprCel<mayorTemp)
                    {
						TempFah = 1.8 * TemprCel + 32;
						Console.WriteLine($"La temperatura equivalente en grados fahrenheit es {TempFah}");
						break;
                    }
                    else
                    {
						Console.WriteLine("Ingrese valores comprendidos entre -70 y 60");

					}
                    
                } while (true);
				if (TemprCel > TempMax)
				{
					TempMax = TemprCel;
				}
				promedioTemp += TemprCel;
			}
			Console.WriteLine($"El promedio de las temperaturas ingresadas es de {promedioTemp / MaxContador}");
			Console.WriteLine($"La temperatura maxima registrada es de {TempMax}");
			Console.ReadKey();
		
		}
    }
}
