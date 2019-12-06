using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode.Puzzles;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
	[TestFixture]
	public class PuzzleTwo
	{
		[Test]
		public void ExampleShouldWork()
		{
			var data = new[] {1, 0, 0, 0, 99};

			var result = Two.SolveIt(data);

			Assert.AreEqual("2", result);
		}
	}
}
