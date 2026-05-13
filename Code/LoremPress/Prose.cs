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
using System.Text.RegularExpressions;
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


		public string Sentence(Style style)
		{
			string template = "";
			switch (style)
			{
				case Style.Literary:
					template = Tools.Pick(Corpora.TitleCorpus.LiterarySentenceTemplates);
					break;

				case Style.SciFi:
				case Style.Technical:
					template = Tools.Pick(Corpora.TitleCorpus.TechnicalSentenceTemplates);
					break;


				case Style.Academic:
				default:
					template = Tools.Pick(Corpora.TitleCorpus.AcademicSentenceTemplates);
					break;
			}

			return Render(template);
		}

		internal static string Render(string template)
		{
			return Regex.Replace(template, @"\{(\w+)\}", match =>
			{
				string token = match.Groups[1].Value;

				return token switch
				{
					"Adj" => Tools.Pick(Corpora.TitleCorpus.Adjectives),
					"NounPlural" => Tools.Pick(Corpora.TitleCorpus.NounPlural),
					"NounSingular" => Tools.Pick(Corpora.TitleCorpus.NounSingular),
					"Verb" => Tools.Pick(Corpora.TitleCorpus.Verbs),
					_ => match.Value
				};
			});
		}
	}
}
