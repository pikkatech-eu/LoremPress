/***********************************************************************************
* File:         TitleBuilder.cs                                                    *
* Contents:     Class TitleBuilder                                                 *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-12 17:18                                                   *
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
	public static class TitleBuilder
	{
		private static Random _random = new Random();

		#region "Corpora"
		//static readonly string[] Adjectives = { "Silent", "Ancient", "Broken", "Hidden" };
		//static readonly string[] Nouns = { "World", "Empire", "Theory", "Signal" };
		static readonly string[] Adjectives =
												{
													"Silent",
													"Ancient",
													"Hidden",
													"Broken",
													"Forgotten",
													"Infinite",
													"Dark",
													"Bright",
													"Invisible",
													"Lost",
													"Sacred",
													"Mechanical",
													"Astral",
													"Temporal",
													"Eternal",
													"Fragmented",
													"Synthetic",
													"Empty",
													"Shifting",
													"Parallel",
													"Secret",
													"Lucid",
													"Iron",
													"Golden",
													"Fading",
													"Emergent",
													"Recursive",
													"Distant",
													"Crimson",
													"Obscure",
													"Liminal",
													"Celestial",
													"Quantum",
													"Mythic",
													"Radial",
													"Nomadic",
													"Invisible",
													"Primal",
													"Frozen",
													"Unwritten"
												};

		static readonly string[] Nouns =
												{
													"Worlds",
													"Signals",
													"Systems",
													"Structures",
													"Horizons",
													"Empires",
													"Fragments",
													"Memories",
													"Machines",
													"Archives",
													"Languages",
													"Cities",
													"Maps",
													"Signals",
													"Patterns",
													"Forms",
													"Entities",
													"Chronicles",
													"Dimensions",
													"Fields",
													"Networks",
													"Objects",
													"Dreams",
													"Theories",
													"Cycles",
													"Infinities",
													"Orders",
													"Ruins",
													"Codes",
													"Observations",
													"Records",
													"Spaces",
													"Echoes",
													"Vectors",
													"Systems",
													"Phenomena",
													"Constructs",
													"Realms",
													"Archives",
													"Principles"
												};
		static readonly string[] Connectors = { "of", "and", "in" };


		static readonly string[] Templates =
												{
													"{Adj} {Noun}",
													"{Noun} of {Adj} {Noun}",
													"The {Adj} {Noun}",
													"On {Adj} {Noun}",
												};
		#endregion

		public static string GetTitle() => Render(Templates[_random.Next(Templates.Length)]);

		static string Pick(string[] arr) => arr[_random.Next(arr.Length)];

		static string Render(string template)
		{
			return template.Replace("{Adj}", Pick(Adjectives)).Replace("{Noun}", Pick(Nouns));
		}

	}
}
