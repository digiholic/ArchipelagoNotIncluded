# ArchipelagoNotIncluded

## Early Proof-of-concept prototype. Does _not_ currently support multiworld functionality or server connectivity, and attempting to generate with more than one game will cause errors.

**Warning:** This mod is in _very early_ experimental phases. This mod currently affects _all_ tech trees in _all_ seeds. Loading the wrong save could cause unwanted changes to existing colonies. _Please_ back up your saves and ensure you are only using purpose-made colonies for this mod when it is enabled.

This mod will randomize which technology each science unlocks. The Generation Logic is handled by the Archipelago Randomizer to ensure that all technology can be researched. Archipelago will generate a mod json file that you can use with this mod to swap the technology around on startup. If this json is not present, or cannot be parsed for whatever reason, the vanilla tech tree is loaded instead. The mod does not change any of the standard planetoid or dupe generation and can work with any setting (see below note about logical requirements if you find an unwinnable scenario)

Currently, the mod **Requires the Spaced Out! DLC to be installed in order to function**. This will not be a requirement for the full release, but due to lack of familiarity with non-DLC gameplay, the logic for it has not been created yet.

This mod should be compatible with any other mod that does not modify the tech tree in any way. Any mods that add technologies will not be included in the randomization and will not appear in your tech tree.

Notes on logic:
In addition to requiring their research points and research buildings, each tier of research also comes with another logical requirement:
- Advanced Research logically requires the ability to pipe fluids and gasses
- Materials Research logically requires the ability to Refine metal, and produce Radbolts
- Space Research logically requires the ability to build a functioning rocket

The logic might still not be completable, due to starting planetoid conditions. If this happens, please share your mod json and world seed in the Oxygen Not Included thread in the Archipelago Discord, under Future-Game-Design.

Ranching Dreckos for plastic or Hatches for Refined Metal _is_ considered in-logic, and if necessary, buildings will be available before they are logically required.

Files needed can be found on the [Releases](https://github.com/digiholic/ArchipelagoNotIncluded/releases) page

### Generation instructions
1. Place the `oni.apworld` file in your `libs/worlds/` directory in your Archipelago installation
2. Download the attached YAML and modify any options you deem necessary (note that currently there are no game-specific options, and likely all you will need to change is the player name) and place it in your `Players` directory in your Archipelago Installation. **Note:** If any other YAMLs are present, please back them up and remove them. This early prototype will _not_ generate if any other YAMLs are present.
3. Run "Generate" either through the executable or the AP launcher.
4. In your `Output` directory, extract the ZIP and find the `.json` file generated.
5. Move your `.json` file to your Mod Directory (See "Installing the mod" below)

### Installing the Mod
1. Download the `ArchipelagoNotIncluded.zip`
2. Extract the zip to its own folder in your ONI Local Mods directory (default windows location: `C:\Users\[YOUR NAME]\Documents\Klei\OxygenNotIncluded\mods\Local` )
3. Place the generated `.json` file from Archipelago (described in the "Generation Instructions" above) into the `ArchipelagoNotIncluded` mod directory you created in step 2.
4. Open Oxygen Not Included

Note: The mod will always use the _most recent_ json in the directory. If you generate another seed, copying it over will apply that mod to all colonies from that point forward. Previous jsons are not currently deleted, but can be manually deleted if you find that you are loading the wrong one.
