using System;
using AdventOfCode.Puzzles;

namespace AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter the puzzle number");
			var puzzle = (Puzzle) Enum.Parse(typeof(Puzzle), Console.ReadLine() ?? throw new InvalidOperationException());

			switch (puzzle)
			{
				case Puzzle.One:
					Console.WriteLine($"Fuel for modules: {One.Solve()}");
					break;
				case Puzzle.Two:
					Console.WriteLine($"Position Zero is: {Two.Solve()}");
					break;
				default:
					Console.WriteLine("No Puzzle solution found");
					break;
			}
		}
	}
}
