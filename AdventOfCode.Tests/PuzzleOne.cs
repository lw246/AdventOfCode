using AdventOfCode.Puzzles;
using NUnit.Framework;

namespace AdventOfCodeTests
{
	[TestFixture]
	public class PuzzleOne
	{
		[Test]
		public void CalculateFuelTest()
		{
			double moduleMass = 1969;

			var result = One.CalculateFuelForModule(moduleMass);

			Assert.AreEqual(966, result);
		}
	}
}