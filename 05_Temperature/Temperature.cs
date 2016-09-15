using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Temperature
{
	public enum Unit
	{
		Celcius,
		Fahrenheit
	};
	public class Temperature
	{
		public double Celcius;
		public double Fahrenheit;


		public Temperature()
		{

		}
		public Temperature(Unit E, double T)
		{
			if (Unit.Celcius == E)
			{
				Celcius = T;
			} else if (Unit.Fahrenheit == E)
			{
				Fahrenheit = T;
			}
		}
		
		public static double FahrenheitToCelcius(double t)
		{
			return (5*t - 160) / 9;
		}

		public static double CelciusToFahrenheit(double t)
		{
			return t * 9 / 5 + 32;
		}

	}
}