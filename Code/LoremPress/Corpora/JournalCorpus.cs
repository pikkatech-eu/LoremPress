/***********************************************************************************
* File:         JournalCorpus.cs                                                   *
* Contents:     Class JournalCorpus                                                *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 11:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoremPress.Corpora
{
	internal class JournalCorpus
	{
		internal static readonly string[] JournalNouns =
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

		internal static readonly string[] Domains =
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


		internal static readonly string[] JournalTemplates =
		{
			"{JournalNoun} of {Domain}",
			"International {JournalNoun} of {Domain}",
			"{Domain} {JournalNoun}",
			"Quarterly {JournalNoun} of {Domain}",
			"Annals of {Domain}",
			"{Domain}: A {JournalNoun}",
			"Transactions in {Domain}"
		};

	}
}
