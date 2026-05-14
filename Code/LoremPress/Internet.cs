/***********************************************************************************
* File:         Internet.cs                                                        *
* Contents:     Class Internet                                                     *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-14 08:27                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	/// <summary>
	/// Creates random internet publication URLs.
	/// </summary>
	public class Internet
	{
		private const int MAX_TITLE_WORDS = 3;
		private static readonly char[] SPLIT_BY = new char[]{' ', '.', ',', ';', ':', '-'};
		private const string DEFAULT_EXTENSION = ".pdf";

		/// <summary>
		/// Creates a random publication URL using its title and date.
		/// </summary>
		/// <param name="title">Publication's title.</param>
		/// <param name="year">Publication year, if known.</param>
		/// <param name="month">Publication month, if known.</param>
		/// <returns>Created random publication URL.</returns>
		public string PublicationUrl(string title, int? year, int? month)
		{
			string template = Tools.Pick(Corpora.UrlTemplates);
			string domain	= Tools.Pick(Corpora.Domains);
			
			domain = Tools.Slugify(domain);

			string[] lines		= title.Split(SPLIT_BY, StringSplitOptions.RemoveEmptyEntries).Take(MAX_TITLE_WORDS).ToArray();
			string title3		= String.Join(" ", lines);

			string slug = Tools.Slugify(title3);

			string result = template;
			result	= result.Replace("{Domain}", domain);
			result	= result.Replace("{Year}", year.ToString());
			result	= result.Replace("{Month}", month.ToString());
			result	= result.Replace("{Slug}", slug);
			result	= result.Replace("//", "/");
			result	+= DEFAULT_EXTENSION;

			return result;
		}

		/// <summary>
		/// Creates an URL date using given date elements.
		/// </summary>
		/// <param name="year">Publication year, if known.</param>
		/// <param name="month">Publication month, if known.</param>
		/// <param name="day">Publication day, if known.</param>
		/// <returns>Created publication date, if at least year was known, otherwise null.</returns>
		public DateTime? PublicationUrlDate(int? year, int? month, int? day)
		{
			if (year == null)
			{
				return null;
			}

			if (month == null)
			{
				month = Tools.Randomizer.Next(1, 13);
			}

			if (day == null)
			{
				day = Tools.Randomizer.Next(1, 29);
			}

			return new DateTime((int)year, (int)month, (int)day);
		}
	}
}
