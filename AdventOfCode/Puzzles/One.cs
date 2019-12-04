using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Schema;

namespace AdventOfCode.Puzzles
{
	public class One
	{
		private static double fuelRequirement;

		public static string Solve()
		{
			fuelRequirement = 0;

			foreach (double moduleMass in LoadData())
			{
				fuelRequirement += CalculateFuelForModule(moduleMass);
			}

			return fuelRequirement.ToString(CultureInfo.InvariantCulture);
		}

		private static double CalculateFuelForModule(double moduleMass)
		{
			return CalculateFuel(moduleMass);
		}

		public static double CalculateFuel(double mass)
		{
			var fuel = Math.Floor(mass / 3) - 2;

			if (fuel <= 0) return fuel;

			fuel =+ CalculateFuel(fuel);
			return fuel;
		}

		private static IEnumerable LoadData()
		{
			return Array.ConvertAll(Resources.PuzzleResources.PuzzleOne.Split("\r\n"), double.Parse);
		}

	}
}
