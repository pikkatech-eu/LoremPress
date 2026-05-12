# LoremPress

LoremPress is a minimal .NET library for generating synthetic book and article titles using lightweight grammar templates and curated vocabulary.

It is designed to be:

  - small
  - deterministic (optional)
  - dependency-free
  - easily extensible
  - suitable for test data, UI prototyping, and procedural content generation
## Concept
LoremPress generates titles by combining:

  - Templates (structure rules)
  - Vocabulary pools (words)
  - Random selection (controlled variability)

Example output:

  - *Silent Worlds*
  - *The Hidden Theory*
  - *Empire of Broken Signals*
  - *On Ancient Structures*
  
## Installation
### Clone this repository
Choose the local directory where you want the code files of LoremPress to be cloned to.
Then:
`git clone https://github.com/pikkatech-eu/LoremPress`

### Download binaries
  - Download self-extracting file
`https://github.com/pikkatech-eu/LoremPress/releases/download/Beta_1.0/LoremPress_setup_2026-05-12.exe`
(which is the last version at the moment).
  - Launch the setup exe file, it will ask you where to install the files you need: `LoremPress.dll` and `LoremPress.deps.json`.
  - Add  `LoremPress.dll` as a dependency to your project.
## Quick Start
```
using LoremPress;

// Creates a title using "Academic" style.
string academic = TitleBuilder.GetTitle(Style.Academic);
Console.WriteLine(academic);

// Creates a title using a random style.
string title = TitleBuilder.GetTitle();
Console.WriteLine(title);
```
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
  - lightweight fake data generators such as Bogus
  - classical rhetorical and editorial title structures
## License

(to be defined)
