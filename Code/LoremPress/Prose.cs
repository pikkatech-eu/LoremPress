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
					template = Tools.Pick(Corpora.LiterarySentenceTemplates);
					break;

				case Style.SciFi:
				case Style.Technical:
					template = Tools.Pick(Corpora.TechnicalSentenceTemplates);
					break;


				case Style.Academic:
				default:
					template = Tools.Pick(Corpora.AcademicSentenceTemplates);
					break;
			}

			return Render(template);
		}

		public string Sentence()
		{
			int i = Tools.Randomizer.Next(1, Enum.GetValues(typeof(Style)).Length);

			Style style = (Style)i;

			return Sentence(style);
		}

		public string[] Sentences(Style style, int numberOfSentences)
		{
			string[] result = new string[numberOfSentences];

			for (int i = 0; i < numberOfSentences; i++)
			{
				result[i] = this.Sentence(style);
			}

			return result;
		}

		public string Text(Style style, int numberOfSentences)
		{
			return String.Join(" ", this.Sentences(style, numberOfSentences));
		}

		public string[] Sentences(Style style, int maxNumberOfSentences, int minNumberOfSentences = 1)
		{
			int numberOfSentences = Tools.Randomizer.Next(minNumberOfSentences, maxNumberOfSentences + 1);
			return this.Sentences(style, numberOfSentences);
		}

		public string Text(Style style, int maxNumberOfSentences, int minNumberOfSentences = 1)
		{
			return String.Join(" ", this.Sentences(style, maxNumberOfSentences, minNumberOfSentences));
		}

		#region Internal Auxiliary
		internal static string Render(string template)
		{
			return Regex.Replace(template, @"\{(\w+)\}", match =>
			{
				string token = match.Groups[1].Value;

				return token switch
				{
					"Adj" => Tools.Pick(Corpora.Adjectives),
					"NounPlural" => Tools.Pick(Corpora.NounPlural),
					"NounSingular" => Tools.Pick(Corpora.NounSingular),
					"Verb" => Tools.Pick(Corpora.Verbs),
					_ => match.Value
				};
			});
		}
		#endregion
	}
}
