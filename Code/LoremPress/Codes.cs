/***********************************************************************************
* File:         Doi.cs                                                             *
* Contents:     Class Doi                                                          *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 11:44                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoremPress
{
	public class Codes
	{
		private const int MIN_STRING_LENGTH = 3;
		private const int MAX_STRING_LENGTH = 7;
		
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
	}
}
