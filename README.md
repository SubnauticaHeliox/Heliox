# Heliox

## Dev setup
1. Using Subnautica **2.0**, remove any mods or, if a clean installation, run the game if you haven't already\
Make sure your game is not in a write-protected folder or the mod dll will not be able to automatically be copied
2. Install [BepInEx](https://submodica.xyz/mods/sn1/141), [Nautilus](https://submodica.xyz/mods/sn1/250), and [Assembly Publicizer](https://github.com/CabbageCrow/AssemblyPublicizer)
3. Run the game and have it generate the publicized dll
4. Change the Reference paths in HelioxMod to your game installation path
5. Change the paths in PostBuild to match your installation directory\
Note: Do not include changes made in steps four and five in commits or PRs,
these steps will likely change later on with a better project structure.