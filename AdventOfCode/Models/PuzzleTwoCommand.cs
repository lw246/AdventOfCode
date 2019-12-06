using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Models
{
	public class PuzzleTwoCommand
	{
		public int Operation { get; set; }
		public int ValueOne { get; set; }
		public int ValueTwo { get; set; }
		public int NewPosition { get; set; }

		public int NewValue
		{
			get
			{
				switch (Operation)
				{
					case 1:
						return ValueOne + ValueTwo;
					case 2:
						return ValueOne * ValueTwo;
					default:
						throw new InvalidOperationException();
				}
			}
		}

		public PuzzleTwoCommand(IReadOnlyList<int> inputData, int position)
		{	
			Operation = inputData[position];

			if (Operation != 99 || position + 3 <= inputData.Count)
			{
				ValueOne = inputData[inputData[position + 1]];
				ValueTwo = inputData[inputData[position + 2]];
				NewPosition = inputData[position + 3];
			}
		}
	}
}
