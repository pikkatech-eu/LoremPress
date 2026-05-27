/***********************************************************************************
* File:         Publication.cs                                                     *
* Contents:     Class Publication                                                  *
* Author:       Alexander Konnen (alex@pikkatech.eu)                               *
* Date:         2026-05-14 23:01                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	/// <summary>
	/// Creates publiucation titles of different types and flairs.
	/// </summary>
	public class Publication
	{
		#region Public features
		/// <summary>
		/// Creates a random publication title for a given flair.
		/// </summary>
		/// <param name="flair">Flair to use.</param>
		/// <returns>Created random publication title.</returns> 
		public string Title(Flair flair)
		{
			string template = "";
			switch (flair)
			{
				case Flair.Literary:
					template = Tools.Pick(Corpora.LiteraryTitleTemplates);
					break;

				case Flair.SciFi:
				case Flair.Technical:
					template = Tools.Pick(Corpora.SciFiTitleTemplates);
					break;


				case Flair.Academic:
				default:
					template = Tools.Pick(Corpora.AcademicTitleTemplates);
					break;
			}

			return Render(template);
		}

		/// <summary>
		/// Creates a title with a random flair.
		/// </summary>
		/// <returns>Created random publication title.</returns>
		public string Title()
		{
			int i = Tools.Randomizer.Next(1, Enum.GetValues(typeof(Flair)).Length);

			Flair style = (Flair)i;

			return Title(style);
		}
		#endregion

		#region Internal Auxiliary
		/// <summary>
		/// Render a random title using a template.
		/// </summary>
		/// <param name="template">Template to use.</param>
		/// <returns>Random title generated.</returns>
		internal static string Render(string template)
		{
			return template.Replace("{Adj}", Tools.Pick(Corpora.Adjectives)).Replace("{Noun}", Tools.Pick(Corpora.NounPlural));
		}
		#endregion
	}
}
