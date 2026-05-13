/***********************************************************************************
* File:         Prose.cs                                                           *
* Contents:     Class Prose                                                        *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 12:00                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.RegularExpressions;

namespace LoremPress
{
	/// <summary>
	/// Generates different pieces of random text.
	/// </summary>
	public class Prose
	{
		#region Sentence and Text building
		/// <summary>
		/// Creates a sentence of given flair.
		/// </summary>
		/// <param name="flair">Flair to use.</param>
		/// <returns>Random sentence generated.</returns>
		public string Sentence(Flair flair)
		{
			string template = "";
			switch (flair)
			{
				case Flair.Literary:
					template = Tools.Pick(Corpora.LiterarySentenceTemplates);
					break;

				case Flair.SciFi:
				case Flair.Technical:
					template = Tools.Pick(Corpora.TechnicalSentenceTemplates);
					break;


				case Flair.Academic:
				default:
					template = Tools.Pick(Corpora.AcademicSentenceTemplates);
					break;
			}

			return Render(template);
		}

		/// <summary>
		/// Creates a sentence of random flair.
		/// </summary>
		/// <returns>Random sentence generated.</returns>
		public string Sentence()
		{
			int i = Tools.Randomizer.Next(1, Enum.GetValues(typeof(Flair)).Length);

			Flair style = (Flair)i;

			return Sentence(style);
		}

		/// <summary>
		/// Creates an array of sentences of given flair.
		/// </summary>
		/// <param name="flair">Flair to use.</param>
		/// <param name="numberOfSentences">Number of sentences to generate.</param>
		/// <returns>Sentences genarated.</returns>
		public string[] Sentences(Flair flair, int numberOfSentences)
		{
			string[] result = new string[numberOfSentences];

			for (int i = 0; i < numberOfSentences; i++)
			{
				result[i] = this.Sentence(flair);
			}

			return result;
		}

		/// <summary>
		/// Added for convenience. Generates a text consisting of sentences of given flair.
		/// </summary>
		/// <param name="flair">Flair to use.</param>
		/// <param name="numberOfSentences">Number of sentences to generate.</param>
		/// <returns>The text generated.</returns>
		public string Text(Flair flair, int numberOfSentences)
		{
			return String.Join(" ", this.Sentences(flair, numberOfSentences));
		}

		/// <summary>
		/// Creates an array of sentences of given flair consisting of a random number of sentences.
		/// </summary>
		/// <param name="flair">Flair to use.</param>
		/// <param name="maxNumberOfSentences">Maximum number of sentences.</param>
		/// <param name="minNumberOfSentences">Minimum number of sentences. Default = 1.</param>
		/// <returns></returns>
		public string[] Sentences(Flair flair, int maxNumberOfSentences, int minNumberOfSentences = 1)
		{
			int numberOfSentences = Tools.Randomizer.Next(minNumberOfSentences, maxNumberOfSentences + 1);
			return this.Sentences(flair, numberOfSentences);
		}

		/// <summary>
		/// Added for convenience. Creates a array of text of given flair consisting of a random number of sentences.
		/// </summary>
		/// <param name="flair">Flair to use.</param>
		/// <param name="maxNumberOfSentences">Maximum number of sentences.</param>
		/// <param name="minNumberOfSentences">Minimum number of sentences. Default = 1.</param>
		/// <returns>The text generated.</returns>
		public string Text(Flair flair, int maxNumberOfSentences, int minNumberOfSentences = 1)
		{
			return String.Join(" ", this.Sentences(flair, maxNumberOfSentences, minNumberOfSentences));
		}
		#endregion

		#region Internal Auxiliary
		/// <summary>
		/// Renders a sentence using a template.
		/// </summary>
		/// <param name="template">Template to use</param>
		/// <returns>Sentence generated.</returns>
		internal static string Render(string template)
		{
			return Regex.Replace(template, @"\{(\w+)\}", match =>
			{
				string token = match.Groups[1].Value;

				return token switch
				{
					"Adj"			=> Tools.Pick(Corpora.Adjectives),
					"NounPlural"	=> Tools.Pick(Corpora.NounPlural),
					"NounSingular"	=> Tools.Pick(Corpora.NounSingular),
					"Verb"			=> Tools.Pick(Corpora.Verbs),
					_				=> match.Value
				};
			});
		}
		#endregion
	}
}
