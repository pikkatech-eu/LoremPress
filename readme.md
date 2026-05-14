# LoremPress

I missed some features in the Bogus library and, after ChatGPT was unable to find a replacement, 
the decision was made to create something small and beatiful.

LoremPress is a minimal .NET library for generating synthetic book and article titles using lightweight grammar templates 
and curated vocabulary. 

I appreciate ChatGPT's assistance at the decision making as well as at coding.

It is designed to be:

  - small
  - deterministic (optional)
  - dependency-free
  - easily extensible
  - suitable for test data, UI prototyping, and procedural content generation

## Concept
LoremPress generates publication titles by combining:
  - Templates (structure rules)
  - Vocabulary pools (words)
  - Random selection (controlled variability)

Example output:

  - *Silent Worlds*
  - *The Hidden Theory*
  - *Empire of Broken Signals*
  - *On Ancient Structures*
  
Generation of journal names, publication URLs, and random texts follows similar principles.

## Installation
### Nuget
#### NuGet Console
`Install-Package LoremPress`

#### Visual Studio
`Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution` \
Browse for `LoremPress`.

### Cloning repository
Choose the local directory where you want the code files of LoremPress to be cloned to.
Then:
`git clone https://github.com/pikkatech-eu/LoremPress`

### Download binaries
  - Download self-extracting file with the latest installer version, e.g.:
`https://github.com/pikkatech-eu/LoremPress/releases/download/Beta_1.0/LoremPress_setup_2026-05-12.exe`
  - Launch the setup exe file, it will ask you where to install the files you need: `LoremPress.dll` and `LoremPress.deps.json`.
  - Add  `LoremPress.dll` as a dependency to your project.
## Quick Start
```
using LoremPress;

namespace LoremPress.Tests
{
	/// <summary>
	/// Getting Started with LoremPress
	/// </summary>
	public static class Program
	{
		static void Main()
		{
			// Create a publication title with academic flair
			string academic = Fakir.Publication.Title(Flair.Academic);
			Console.WriteLine($"Title academic: \"{academic}\"");

			// Create a publication title with literary flair
			string literary = Fakir.Publication.Title(Flair.Literary);
			Console.WriteLine($"Title literary: \"{literary}\"");

			// Create a publication title with sci-fi/technical flair
			string technical = Fakir.Publication.Title(Flair.Technical);
			Console.WriteLine($"Title technical: \"{technical}\"");

			// Create a publication title with random flair
			string randomTitle = Fakir.Publication.Title();
			Console.WriteLine($"Title random: \"{randomTitle}\"");

			Console.WriteLine();

			// Create a journal name
			string journal = Fakir.Journal.JournalName();
			Console.WriteLine($"Journal name: \"{journal}\"");

			Console.WriteLine();

			// Create a DOI
			string doi = Fakir.Codes.Doi();
			Console.WriteLine($"DOI: \"{doi}\"");

			// Creata an ISBN
			string isbn = Fakir.Codes.Isbn();
			Console.WriteLine($"ISBN: \"{isbn}\"");

			// Creata an ISSN
			string issn = Fakir.Codes.Issn();
			Console.WriteLine($"ISSN: \"{issn}\"");

			Console.WriteLine();

			// Create a sentence of academic flair
			string sentAcademic = Fakir.Prose.Sentence(Flair.Academic);
			Console.WriteLine($"Sentence academic: \"{sentAcademic}\"");

			// Create a sentence of literary flair
			string sentLiterary = Fakir.Prose.Sentence(Flair.Literary);
			Console.WriteLine($"Sentence literary: \"{sentLiterary}\"");

			// Create a sentence of technical flair
			string sentTechnical = Fakir.Prose.Sentence(Flair.Technical);
			Console.WriteLine($"Sentence technical: \"{sentTechnical}\"");

			// Create a sentence of random flair
			string sentRandom = Fakir.Prose.Sentence();
			Console.WriteLine($"Sentence random: \"{sentRandom}\"");

			Console.WriteLine();

			// Create a text of academic flair with given number of sentences
			string textAcademic = Fakir.Prose.Text(Flair.Academic, 4);
			Console.WriteLine($"Text academic (4): \"{textAcademic}\"");

			Console.WriteLine();

			// Create a text of academic flair with random number of sentences
			string textAcademicRandom = Fakir.Prose.Text(Flair.Academic, 6, 2);
			Console.WriteLine($"Text academic (random): \"{textAcademicRandom}\"");

			// Creates a random publication URL
			string url = Fakir.Internet.PublicationUrl("Chronicle of Radial Expeditions", 2012, 3);
			Console.WriteLine($"Publication URL: \"{url}\"");

			// Creates a publication URL date
			DateTime? dtPublication = Fakir.Internet.PublicationUrlDate(2012, 3, 5);
			Console.WriteLine($"Publication date: \"{dtPublication}\"");
		}
	}
}

```
### Your expected output:
<pre>
Title academic: "On Spectral Disciplines" \
Title literary: "Chronicle of Radial Expeditions" \
Title technical: "Frozen Translations Protocol" \
Title random: "Towards a Model of Residual Theories"

Journal name: "Quarterly Transactions of Cultural Memory"

DOI: "10.2284/tzuodh.2013.448" \
ISBN: "9783348670272" \
ISSN: "8936-8401"

Sentence academic: "The Concealed Labyrinth interacts under controlled conditions." \
Sentence literary: "The Vector orchestrates through forgotten Constructs." \
Sentence technical: "The interface constructs user-defined Narratives." \
Sentence random: "The Empires of the past diverges quietly."

Text academic (4): "The literature echoes conflicting interpretations of Temporal Vectors. 
					This approach manifests existing theories of Fragmentary Narratives. 
					Experimental results connects predicted Transient Constellations. 
					The model extends additional constraints on Dynamic Archives."

Text academic (random): "Empirical data deconstructs across multiple Lost Observations. 
						 The hypothesis attenuates the dynamics of Asymmetric Expeditions."

Publication URL: "https:/archive.mythic-studies.ac.uk/chronicle-of-radial.pdf"
Publication date: "2012-03-05 00:00:00"
</pre>
## Design Philosophy

LoremPress is intentionally minimal.

It avoids:

  - external datasets
  - NLP models
  - runtime corpus loading
  - heavy abstraction layers

Instead, it focuses on:

>small deterministic components that produce plausible structured text.

## Internal Model

The generator is based on three components:

### 1. Vocabulary

Simple in-memory word lists:

  - adjectives
  - nouns
  - connectors (of, and, in, etc.)
### 2. Templates

Structural patterns such as:

  - **\{Adj\}** **\{Noun\}**
  - The **\{Adj\}** **\{Noun\}**
  - **\{Noun\}** of **\{Adj\}** **\{Noun\}**

### 3. Renderer

A lightweight substitution engine that fills templates using random selection.

## Extensibility (planned)

Future versions may support:

  - weighted vocabulary
  - multiple style packs (academic, fantasy, news, etc.)
  - locale-based word sets
  - deterministic seeding modes
  - custom template providers
  
### Non-goals

LoremPress is NOT intended to be:

  - a natural language generator
  - a large-scale AI text system
  - a corpus-based NLP tool
  - a replacement for real linguistic datasets

It is intentionally small and symbolic.

## Inspiration

LoremPress is conceptually inspired by:

  - template-based text generation systems
  - procedural content generation techniques
  - lightweight fake data generators such as **Bogus**
  - classical rhetorical and editorial title structures
## License

MIT License
