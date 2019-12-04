using AdventOfCode.Puzzles;
using NUnit.Framework;

namespace Tests
{
	public class PuzzleOne
	{
		[Test]
		public void CalculateFuelTest()
		{
			double moduleMass = 1969;

			var result = One.CalculateFuel(moduleMass);

			Assert.AreEqual(966, result);
		}
	}
}