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

			foreach (var moduleMass in Helpers.CovertListToDoubleArray(Resources.PuzzleResources.PuzzleOne))
			{
				fuelRequirement += CalculateFuelForModule(moduleMass);
			}

			return fuelRequirement.ToString(CultureInfo.InvariantCulture);
		}

		public static double CalculateFuelForModule(double moduleMass)
		{
			var fuel = CalculateFuel(moduleMass);
			var totalFuel = fuel;

			while (CalculateFuel(fuel) > 0)
			{
				fuel = CalculateFuel(fuel);
				totalFuel += fuel;
			}

			return totalFuel;
		}

		public static double CalculateFuel(double mass)
		{
			return Math.Floor(mass / 3) - 2;
		}
	}
}
