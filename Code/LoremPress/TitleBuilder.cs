/***********************************************************************************
* File:         TitleBuilder.cs                                                    *
* Contents:     Class TitleBuilder                                                 *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-12 17:18                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress
{
	/// <summary>
	/// Builder to create random pseudo-realistic titles of publications. 
	/// Works like a miniature probabilistic rhetoric engine.
	/// </summary>
	public static class TitleBuilder
	{
		#region Private static members
		/// <summary>
		/// Random generator.
		/// </summary>
		private static Random _random = new Random();
		#endregion

		#region "Corpora"
		/// <summary>
		/// List of adjectives.
		/// </summary>
		static readonly string[] Adjectives =
												{
													"Abstract",
													"Ancestral",
													"Ancient",
													"Arcane",
													"Astral",
													"Asymmetric",
													"Autonomous",
													"Bright",
													"Broken",
													"Celestial",
													"Cerulean",
													"Concealed",
													"Crimson",
													"Dark",
													"Distant",
													"Dormant",
													"Dynamic",
													"Emergent",
													"Empty",
													"Encoded",
													"Encrypted",
													"Eternal",
													"Fading",
													"Forgotten",
													"Fragmentary",
													"Fragmented",
													"Frozen",
													"Golden",
													"Harmonic",
													"Hidden",
													"Infinite",
													"Invisible",
													"Iron",
													"Isolated",
													"Liminal",
													"Lost",
													"Lucid",
													"Lunar",
													"Magnetic",
													"Mechanical",
													"Monolithic",
													"Mutable",
													"Mythic",
													"Nocturnal",
													"Nomadic",
													"Obscure",
													"Obsidian",
													"Parallel",
													"Peripheral",
													"Polar",
													"Primal",
													"Primeval",
													"Quantum",
													"Radial",
													"Recursive",
													"Remote",
													"Residual",
													"Resonant",
													"Sacred",
													"Secret",
													"Shifting",
													"Silent",
													"Solar",
													"Spectral",
													"Stellar",
													"Subterranean",
													"Subtle",
													"Symbolic",
													"Synthetic",
													"Temporal",
													"Transient",
													"Translucent",
													"Unwritten",
													"Vanishing",
													"Vertical",
													"Volatile",
												};

		/// <summary>
		/// List of nouns.
		/// </summary>
		static readonly string[] Nouns =
												{
													"Archives",
													"Artifacts",
													"Atlases",
													"Blueprints",
													"Cathedrals",
													"Chronicles",
													"Cities",
													"Codes",
													"Constellations",
													"Constructs",
													"Coordinates",
													"Corridors",
													"Cycles",
													"Dimensions",
													"Disciplines",
													"Doctrines",
													"Dreams",
													"Echoes",
													"Empires",
													"Engines",
													"Entities",
													"Equations",
													"Equinoxes",
													"Expeditions",
													"Fields",
													"Forms",
													"Fragments",
													"Frontiers",
													"Gateways",
													"Geometries",
													"Horizons",
													"Infinities",
													"Inscriptions",
													"Labyrinths",
													"Languages",
													"Libraries",
													"Machines",
													"Maps",
													"Matrices",
													"Mechanisms",
													"Memories",
													"Mirrors",
													"Monuments",
													"Narratives",
													"Networks",
													"Objects",
													"Observations",
													"Observatories",
													"Orbits",
													"Orders",
													"Parallels",
													"Patterns",
													"Phenomena",
													"Principles",
													"Realms",
													"Records",
													"Revelations",
													"Rituals",
													"Ruins",
													"Sequences",
													"Signals",
													"Spaces",
													"Spectra",
													"Structures",
													"Symbols",
													"Systems",
													"Territories",
													"Theories",
													"Thresholds",
													"Translations",
													"Vectors",
													"Volumes",
													"Worlds",
												};

		/// <summary>
		/// List of connectors.
		/// Not used in present version.
		/// </summary>
		static readonly string[] Connectors = { "of", "and", "in" };

		/// <summary>
		/// List of academic templates.
		/// </summary>
		static readonly string[] AcademicTemplates =
		{
			"On {Adj} {Noun}",
			"Studies in {Adj} {Noun}",
			"A Theory of {Adj} {Noun}",
			"Notes on {Adj} {Noun}",
			"Towards a Model of {Adj} {Noun}",
			"The Structure of {Adj} {Noun}",
			"Observations on {Adj} {Noun}",
			"A Framework for {Adj} {Noun}"
		};

		/// <summary>
		/// List of literary templates.
		/// </summary>
		static readonly string[] LiteraryTemplates =
		{
			"The {Adj} {Noun}",
			"The {Noun} of {Adj} {Noun}",
			"In the {Adj} {Noun}",
			"Between {Adj} {Noun}",
			"A History of {Adj} {Noun}",
			"The Last {Adj} {Noun}",
			"Songs of {Adj} {Noun}",
			"Chronicle of {Adj} {Noun}",
			"The Book of {Adj} {Noun}"
		};

		/// <summary>
		/// List of SciFi templates.
		/// </summary>
		static readonly string[] SciFiTemplates =
		{
			"{Adj} {Noun} Protocol",
			"{Adj} {Noun} System",
			"Field Report: {Adj} {Noun}",
			"Log Entry: {Adj} {Noun}",
			"{Noun} Classification: {Adj}",
			"Simulation of {Adj} {Noun}",
			"Model: {Adj} {Noun}",
			"Analysis of {Adj} {Noun}",
			"{Adj} {Noun} Interface"
		};
		#endregion

		#region Public features
		/// <summary>
		/// Creates a random title for a given style.
		/// </summary>
		/// <param name="style">Style to use.</param>
		/// <returns>Created random title.</returns>
		public static string GetTitle(Style style)
		{
			string template = "";
			switch (style)
			{
				case Style.Literary:
					template = LiteraryTemplates[_random.Next(LiteraryTemplates.Length)];
					break;

				case Style.SciFi:
					template = SciFiTemplates[_random.Next(SciFiTemplates.Length)];
					break;


				case Style.Academic:
				default:
					template = AcademicTemplates[_random.Next(AcademicTemplates.Length)];
					break;
			}

			return Render(template);
		}

		/// <summary>
		/// Creates a title with a random style.
		/// </summary>
		/// <returns>Created random title.</returns>
		public static string GetTitle()
		{
			int i = _random.Next(1, Enum.GetValues(typeof(Style)).Length);

			Style style = (Style)i;

			return GetTitle(style);
		}
		#endregion

		#region Internal Auxiliary
		/// <summary>
		/// Picks a random element from an array.
		/// </summary>
		/// <param name="arr">Array to pick from.</param>
		/// <returns>The item picked.</returns>
		static string Pick(string[] arr) => arr[_random.Next(arr.Length)];

		/// <summary>
		/// Render a random title using a template.
		/// </summary>
		/// <param name="template">Template tu use.</param>
		/// <returns>Random title generated.</returns>
		static string Render(string template)
		{
			return template.Replace("{Adj}", Pick(Adjectives)).Replace("{Noun}", Pick(Nouns));
		}
		#endregion
	}
}
