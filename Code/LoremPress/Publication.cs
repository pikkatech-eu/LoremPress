/***********************************************************************************
* File:         Title.cs                                                           *
* Contents:     Class Title                                                        *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 11:17                                                   *
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
	public class Publication
	{
		#region Public features
		/// <summary>
		/// Creates a random title for a given style.
		/// </summary>
		/// <param name="style">Style to use.</param>
		/// <returns>Created random title.</returns>
		public string Title(Style style)
		{
			string template = "";
			switch (style)
			{
				case Style.Literary:
					template = Tools.Pick(Corpora.TitleCorpus.LiteraryTitleTemplates);
					break;

				case Style.SciFi:
				case Style.Technical:
					template = Tools.Pick(Corpora.TitleCorpus.SciFiTitleTemplates);
					break;


				case Style.Academic:
				default:
					template = Tools.Pick(Corpora.TitleCorpus.AcademicTitleTemplates);
					break;
			}

			return Render(template);
		}

		/// <summary>
		/// Creates a title with a random style.
		/// </summary>
		/// <returns>Created random title.</returns>
		public string Title()
		{
			int i = Tools.Randomizer.Next(1, Enum.GetValues(typeof(Style)).Length);

			Style style = (Style)i;

			return Title(style);
		}
		#endregion

		/// <summary>
		/// Render a random title using a template.
		/// </summary>
		/// <param name="template">Template tu use.</param>
		/// <returns>Random title generated.</returns>
		static string Render(string template)
		{
			return template.Replace("{Adj}", Tools.Pick(Corpora.TitleCorpus.Adjectives)).Replace("{Noun}", Tools.Pick(Corpora.TitleCorpus.NounPlural));
		}
	}
}
