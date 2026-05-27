/***********************************************************************************
* File:         Journal.cs                                                         *
* Contents:     Class Journal                                                      *
* Author:       Alexander Konnen (alex@pikkatech.eu)                               *
* Date:         2026-05-14 23:00                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	/// <summary>
	/// Creates random journal names.
	/// </summary>
	public class Journal
	{

		/// <summary>
		/// Creates a journal name.
		/// </summary>
		/// <returns>Journal name created.</returns>
		public string JournalName()
		{
			string template = Tools.Pick(Corpora.JournalTemplates);
			return Render(template);
		}

		#region Internal Auxiliary
		/// <summary>
		/// Render a random journal name using a template.
		/// </summary>
		/// <param name="template">Template to use.</param>
		/// <returns>Random title generated.</returns>
		static string Render(string template)
		{
			return template.Replace("{JournalNoun}", Tools.Pick(Corpora.JournalNouns)).Replace("{Domain}", Tools.Pick(Corpora.Domains));
		}
		#endregion
	}
}
