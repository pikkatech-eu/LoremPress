/***********************************************************************************
* File:         Tools.cs                                                           *
* Contents:     Class Tools                                                        *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 16:32                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	/// <summary>
	/// Contains different tools for the creation of random elements.
	/// </summary>
	internal static class Tools
	{
		#region Constants
		/// <summary>
		/// Alphabet to create random text fragments for DOI.
		/// </summary>
		private const string ALPHABETH = "abcdefhijklmnopqrstuvwxyz";
		#endregion

		#region Internal members
		/// <summary>
		/// Randomizer based upon System.Random.
		/// </summary>
		internal static Random Randomizer {get;} = new Random();
		#endregion

		/// <summary>
		/// Picks a random element from an array.
		/// </summary>
		/// <param name="array">Array to pick from.</param>
		/// <returns>The item picked.</returns>
		internal static string Pick(string[] array) => array[Randomizer.Next(array.Length)];

		/// <summary>
		/// Generates a random string of given length.
		/// </summary>
		/// <param name="length">The length of the string to create.</param>
		/// <returns>Random string created.</returns>
		internal static string RandomString(int length)
		{
			string result = "";

			for (int i = 0; i < length; i++)
			{
				result	+= ALPHABETH[Randomizer.Next(ALPHABETH.Length)];
			}

			return result;
		}

		/// <summary>
		/// Generates a random string of random length.
		/// </summary>
		/// <param name="minLength">Minimum string length.</param>
		/// <param name="maxLength">Maximum string length.</param>
		/// <returns>Random string created.</returns>
		internal static string RandomString(int minLength, int maxLength)
		{
			int length = Randomizer.Next(minLength, maxLength + 1);

			return RandomString(length);
		}
	}
}
