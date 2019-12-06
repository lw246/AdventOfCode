using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using AdventOfCode.Models;

namespace AdventOfCode.Puzzles
{
	public class Two
	{
		private static int[] _inputData;
		private static int _currentPosition = 0;
		private static PuzzleTwoCommand _currentCommand;

		public static string Solve()
		{
			var result = 0;
			int verb = 0;
			int noun = 0;

			for (int i=0; i <= 99; i++)
			{
				Console.WriteLine($"Checking verb: {i}");
				for (int j = 0; j <= 99; j++)
				{
					Console.WriteLine($"Checking Noun: {j}   For verb: {i}");
					var data = Helpers.CoverterCommaListToIntArray(Resources.PuzzleResources.PuzzleTwo);
					_currentPosition = 0;
					data = UpdateData(data, i, j);
					result = SolveIt(data);
					
					Console.WriteLine($"Result was: {result}");

					if (result != 19690720) continue;

					verb = i;
					noun = j;
					break;
				}
				if (result == 19690720) 
					break;
			}

			Console.WriteLine($"Final Noun: {noun}   Final verb: {verb}");

			return ((100 * noun) + verb).ToString();

		}

		public static int SolveIt(int[] data)
		{
			_inputData = data;
			_currentCommand = new PuzzleTwoCommand(_inputData, _currentPosition);

			while (_currentCommand.Operation != 99)
			{
				ActOnCommand();
				GetNextCommand();
			}

			return _inputData[0];
		}

		private static int[] SetUpData(int[] data)
		{
			Console.WriteLine("Enter Noun: ");
			var noun = Console.ReadLine();
			Console.WriteLine("Enter Verb: ");
			var verb = Console.ReadLine();
			return UpdateData(data, int.Parse(noun), int.Parse(verb));
		}

		private static int[] UpdateData(int[] data, int noun, int verb)
		{
			data[1] = noun;
			data[2] = verb;
			return data;
		}

		private static void GetNextCommand()
		{
			_currentPosition += 4;
			_currentCommand = new PuzzleTwoCommand(_inputData, _currentPosition);
		}

		private static void ActOnCommand()
		{
			//Console.WriteLine($"CurrentPosition: {_currentPosition} \n" +
			//				  $"Command: {_currentCommand.Operation} \n" +
			//                  $"ValueOne: {_currentCommand.ValueOne} \n" +
			//                  $"ValueTwo: {_currentCommand.ValueTwo} \n" +
			//                  $"NewValue: {_currentCommand.NewValue} \n" +
			//                  $"NewPostion: {_currentCommand.NewPosition}");
			_inputData[_currentCommand.NewPosition] = _currentCommand.NewValue;
		}
	}
}
