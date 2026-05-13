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
		internal static Random Randomizer { get; } = new Random();

		/// <summary>
		/// Picks a random element from an array.
		/// </summary>
		/// <param name="array">Array to pick from.</param>
		/// <returns>The item picked.</returns>
		internal static string Pick(string[] array) => array[Randomizer.Next(array.Length)];


	}
}
