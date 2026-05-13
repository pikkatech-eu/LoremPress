/***********************************************************************************
* File:         Fakir.cs                                                           *
* Contents:     Class Fakir                                                        *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 11:17                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	/// <summary>
	/// Fakir: the LoremPress manager.
	/// </summary>
	public static class Fakir
	{
		/// <summary>
		/// Working instance of Publication class.
		/// </summary>
		public static Publication Publication	{get;} = new Publication();

		/// <summary>
		/// Working instance of Journal class.
		/// </summary>
		public static Journal Journal			{get;} = new Journal();

		/// <summary>
		/// Working instance of Prose class.
		/// </summary>
		public static Prose Prose				{get;} = new Prose();

		/// <summary>
		/// Working instance of Codes class.
		/// </summary>
		public static Codes Codes				{get;} = new Codes();
	}
}
