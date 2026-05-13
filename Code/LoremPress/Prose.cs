/***********************************************************************************
* File:         Prose.cs                                                           *
* Contents:     Class Prose                                                        *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 12:00                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoremPress
{
	public class Prose
	{
		internal string[] Templates =
										{
											"Within the {Adj} {Noun}, the {Noun} {Verb} quietly.",
											"Several {Adj} {Noun} {Verb} beyond the {Noun}.",
											"The {Noun} of the {Adj} {Noun} remains {Adj}."
										};


		static readonly string[] Verbs =
										{
											"reveals",
											"contains",
											"transforms",
											"observes",
											"crosses",
											"defines",
											"echoes",
											"extends",
											"reflects",
											"preserves",
											"constructs",
											"conceals"
										};

		public string Sentence()
		{
			string template	= Tools.Pick(Templates);

			return Render(template);
		}

		private static string Render(string template)
		{
			string result = template;
			result = result.Replace("{Adj}", Tools.Pick(Corpora.TitleCorpus.Adjectives));
			result = result.Replace("{Noun}", Tools.Pick(Corpora.TitleCorpus.Nouns));
			result = result.Replace("{Verb}", Tools.Pick(Verbs));

			return result;
		}
	}
}
