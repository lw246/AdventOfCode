using System;
using System.Collections;

namespace AdventOfCode.Puzzles
{
	public class Helpers
	{
		public static double[] CovertListToDoubleArray(string data)
		{
			return Array.ConvertAll(data.Split("\r\n"), double.Parse);
		}

		public static int[] CoverterCommaListToIntArray(string data)
		{
			return Array.ConvertAll(data.Split(','), int.Parse);
		}
	}
}