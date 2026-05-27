/***********************************************************************************
* File:         Internet.cs                                                        *
* Contents:     Class Internet                                                     *
* Author:       Alexander Konnen (alex@pikkatech.eu)                               *
* Date:         2026-05-14 23:00                                                   *
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
		private const int MAX_TITLE_WORDS		= 3;
		private static readonly char[] SPLIT_BY	= new char[]{' ', '.', ',', ';', ':', '-'};
		private const string DEFAULT_EXTENSION	= ".pdf";

		/// <summary>
		/// Creates a random publication URL using its title and date.
		/// </summary>
		/// <param name="title">Publication's title.</param>
		/// <param name="year">Publication year, if known.</param>
		/// <param name="month">Publication month, if known.</param>
		/// <returns>Created random publication URL.</returns>
		public string PublicationUrl(string title, int? year, int? month)
		{
			string template		= Tools.Pick(Corpora.UrlTemplates);
			string domain		= Tools.Pick(Corpora.Domains);
			
			domain				= Tools.Slugify(domain);

			string[] lines		= title.Split(SPLIT_BY, StringSplitOptions.RemoveEmptyEntries).Take(MAX_TITLE_WORDS).ToArray();
			string title3		= String.Join(" ", lines);

			string slug			= Tools.Slugify(title3);

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
		/// Creates a random publication URL using its title. The year and month of the publication will be randomly created.
		/// </summary>
		/// <param name="title">Publication's title.</param>
		/// <returns>Created random publication URL.</returns>
		public string PublicationUrl(string title)
		{
			return this.PublicationUrl(title, null, null);
		}

		/// <summary>
		/// Creates a random publication URL. Title, year and month of the publication will be randomly created.
		/// </summary>
		/// <returns>Created random publication URL.</returns>
		public string PublicationUrl()
		{
			string title = Fakir.Publication.Title(Flair.Technical);

			return this.PublicationUrl(title);
		}
	}
}
