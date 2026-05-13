/***********************************************************************************
* File:         Journal.cs                                                         *
* Contents:     Class Journal                                                      *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 11:38                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	public class Journal
	{
		public string JournalName()
		{
			string template = Tools.Pick(Corpora.JournalTemplates);
			return Render(template);
		}

		static string Render(string template)
		{
			return template.Replace("{JournalNoun}", Tools.Pick(Corpora.JournalNouns)).Replace("{Domain}", Tools.Pick(Corpora.Domains));
		}

	}
}
