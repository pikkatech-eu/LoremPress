/***********************************************************************************
* File:         TitleCorpus.cs                                                     *
* Contents:     Class TitleCorpus                                                  *
* Author:       Stanislav Koncvebovski (aka Bav) (stanislav@pikkatech.eu)          *
* Date:         2026-05-13 11:22                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace LoremPress.Corpora
{
	internal class TitleCorpus
	{
		#region "Corpora"
		/// <summary>
		/// List of adjectives.
		/// </summary>
		internal  static readonly string[] Adjectives =
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
		internal  static readonly string[] Nouns =
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
		internal static readonly string[] Connectors = { "of", "and", "in" };

		/// <summary>
		/// List of academic templates.
		/// </summary>
		internal static readonly string[] AcademicTemplates =
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
		internal static readonly string[] LiteraryTemplates =
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
		internal static readonly string[] SciFiTemplates =
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
	}
}
