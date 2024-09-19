using System;
using System.Collections.Generic;

namespace WeatherTracker.Utilities
{
	public static class ConsoleUtils
	{
		public static string GetUserInput(string prompt)
		{
			Console.WriteLine(prompt);
			return Console.ReadLine();
		}

		public static void MultiWriteLine<T>(IEnumerable<T> text)
		{
			if(text == null)
				throw new ArgumentNullException(nameof(text), $"The collection (of type {typeof(T)}) cannot be null.");

			foreach(var str in text)
				Console.WriteLine(str);
		}
	}
}
