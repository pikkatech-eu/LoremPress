/***********************************************************************************
* File:         JournalNameBuilder.cs                                              *
* Contents:     Class JournalNameBuilder                                           *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-12 22:50                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	public static class JournalNameBuilder
	{
		private static Random _random = new Random();

		static readonly string[] JournalNouns =
		{
			"Journal",
			"Review",
			"Annals",
			"Proceedings",
			"Transactions",
			"Bulletin",
			"Quarterly",
			"Reports",
			"Studies",
			"Archives"
		};

		static readonly string[] Domains =
		{
			"Temporal Studies",
			"Synthetic Systems",
			"Comparative Structures",
			"Symbolic Logic",
			"Astronomical Research",
			"Applied Geometry",
			"Cultural Memory",
			"Quantum Dynamics",
			"Historical Analysis",
			"Computational Theory",
			"Language Systems",
			"Artificial Societies",
			"Mythic Studies",
			"Regional Cartography",
			"Recursive Mathematics"
		};


		static readonly string[] JournalTemplates =
		{
			"{JournalNoun} of {Domain}",
			"International {JournalNoun} of {Domain}",
			"{Domain} {JournalNoun}",
			"Quarterly {JournalNoun} of {Domain}",
			"Annals of {Domain}",
			"{Domain}: A {JournalNoun}",
			"Transactions in {Domain}"
		};

		public static string GetJournalName()
		{
			string template = JournalTemplates[_random.Next(JournalTemplates.Length)];
			return Render(template);
		}

		static string Pick(string[] arr) => arr[_random.Next(arr.Length)];

		static string Render(string template)
		{
			return template.Replace("{JournalNoun}", Pick(JournalNouns)).Replace("{Domain}", Pick(Domains));
		}
	}
}
