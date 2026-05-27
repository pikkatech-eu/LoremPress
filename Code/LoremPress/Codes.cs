/***********************************************************************************
* File:         Codes.cs                                                           *
* Contents:     Class Codes                                                        *
* Author:       Alexander Konnen (alex@pikkatech.eu)                               *
* Date:         2026-05-14 22:59                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	/// <summary>
	/// Generates different useful codes.
	/// </summary>
	public class Codes
	{
		#region Constants
		/// <summary>
		/// Minimum length of the string component in a DOI.
		/// </summary>
		private const int MIN_STRING_LENGTH = 3;

		/// <summary>
		/// Maximum length of the string component in a DOI.
		/// </summary>
		private const int MAX_STRING_LENGTH = 7;
		#endregion

		/// <summary>
		/// Generates a random DOI.
		/// </summary>
		/// <returns>DOI created.</returns>
		public string Doi()
		{
			int registrant = Tools.Randomizer.Next(1000, 9999);

			string word = Tools.RandomString(MIN_STRING_LENGTH, MAX_STRING_LENGTH);

			string suffix =
				$"{word.ToLower()}." +
				$"{Tools.Randomizer.Next(2000, 2035)}." +
				$"{Tools.Randomizer.Next(1, 999):000}";

			return $"10.{registrant}/{suffix}";

		}

		/// <summary>
		/// Generates a random ISBN 13.
		/// </summary>
		/// <returns>ISBN created.</returns>
		public string Isbn()
		{
			int[] digits = new int[13];

			digits[0] = 9;
			digits[1] = 7;
			digits[2] = 8;

			for (int i = 3; i < 12; i++)
				digits[i] = Tools.Randomizer.Next(10);

			int sum = 0;

			for (int i = 0; i < 12; i++)
			{
				sum += digits[i] * (i % 2 == 0 ? 1 : 3);
			}

			digits[12] = (10 - (sum % 10)) % 10;

			return string.Concat(digits);

		}

		/// <summary>
		/// Generates a random ISSN.
		/// </summary>
		/// <returns>ISSN created.</returns>
		public string Issn()
		{
			int[] digits = new int[8];

			for (int i = 0; i < 7; i++)
				digits[i] = Tools.Randomizer.Next(10);

			int sum = 0;

			for (int i = 0; i < 7; i++)
			{
				sum += digits[i] * (8 - i);
			}

			int remainder = sum % 11;
			int checksum = 11 - remainder;

			string checkChar = checksum switch
			{
				10 => "X",
				11 => "0",
				_ => checksum.ToString()
			};

			return
				$"{digits[0]}{digits[1]}{digits[2]}{digits[3]}-" +
				$"{digits[4]}{digits[5]}{digits[6]}{checkChar}";

		}
	}
}
