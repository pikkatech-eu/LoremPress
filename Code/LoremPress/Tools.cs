using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoremPress
{
	internal static class Tools
	{
		private const string ALPHABETH = "abcdefhijklmnopqrstuvwxyz";

		internal static Random Randomizer { get; } = new Random();

		/// <summary>
		/// Picks a random element from an array.
		/// </summary>
		/// <param name="array">Array to pick from.</param>
		/// <returns>The item picked.</returns>
		internal static string Pick(string[] array) => array[Randomizer.Next(array.Length)];

		internal static string RandomString(int length)
		{
			string result = "";

			for (int i = 0; i < length; i++)
			{
				result	+= ALPHABETH[Randomizer.Next(ALPHABETH.Length)];
			}

			return result;
		}

		internal static string RandomString(int minLength, int maxLength)
		{
			int length = Randomizer.Next(minLength, maxLength + 1);

			return RandomString(length);
		}
	}
}
