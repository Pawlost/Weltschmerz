# Weltschmerz
![Example of earth generated in World map generator by Weltschmerz](https://github.com/starandserpent/World-map-generator/blob/dev/screenshots/earthbiomes.png)

## Table of Contents

* [About the Project](#about-the-project)
* [Examples](#examples)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
    * [Git submodule](#git-submodule)
    * [DLL Library](#dll-library)
* [Usage](#usage)
* [Documentation](#documentation)
* [License](#license)
* [Contact](#contact)
  * [Follow us](#follow-us)


## About the project

Weltschmerz is a library for simulating terrain, moisture, temperature, wind, and precipitation based on real environmental principles. The values Weltschmerz outputs can be used, for example, for generating realistic looking maps or terrain. Weltschmerz is primarily aimed at games and does not produce scientifically accurate data.

Weltschmerz is used in [Foreman](https://github.com/starandserpent/Foreman) to generate 3D voxel terrain and in [World map generator](https://github.com/starandserpent/World-map-generator) to generate  realistic looking maps.

## Examples

Foreman takes elevation from Weltschmerz and generates 3D voxel world based on this elevation.

Foreman example: https://www.youtube.com/watch?v=lAZFasyDf7Y

* World map generator generates biomes from environmental variables.

![World map generator example](https://github.com/starandserpent/World-map-generator/blob/dev/screenshots/world.png)

## Getting Started

These instructions will get you a copy of the library for development. See build for notes on how to build the dll library for your project.

### Prerequisites

Make sure you have installed all of the following prerequisites on your development machine:

* *.NET environment*

* [Git](https://git-scm.com/downloads) - OSX and Linux machines typically have this already installed.

* [Config file](https://github.com/starandserpent/Weltschmerz/blob/master/config/config.conf) in your project folder

### Installation
A step by step series how to install library into your project
1) Select or make your .NET project

2) Include [C# Hocon library](https://www.nuget.org/packages/Hocon.Configuration/) in your .csproj file. (File is located in your .NET project)

```
  <ItemGroup>
    <PackageReference Include="Hocon.Configuration">
      <Version>2.0.3</Version>
    </PackageReference>
  </ItemGroup>
```

Now you have 2 options how to include Weltschmerz in your project.

#### Git submodule
3) Go to your project folder
4) Initialize git in your repository
```git
git init
```
5) Add Weltschmerz as git submodule
```git
git submodule add git@github.com:starandserpent/Weltschmerz.git --recusive
```
6) Include all .cs files from Weltschmerz in your project

#### DLL Library
3) Open Weltschmerz in your IDE
4) Build solution
5) Open your project
6) Add Weltschmerz library as reference into your project


## Usage
You can access all environmental variables from *Weltschmerz* class
```csharp
    Weltschmerz weltschmerz = new Weltschmerz();
    double elevation = weltschmerz.GetElevation(0, 0);
```

If you want to replace any generator in weltschmerz by your own, use abstract class
```csharp
    weltschmerz.ElevationGenerator = new Elevation();
```

Default config file is named "config.conf", use *ConfigManager* to load your custom config files.
```csharp
    string path = "yourpath/to/file"
    Config config = ConfigManager.GetConfig(path);
```
For further implementation as library in 3D game see [Foreman](https://github.com/starandserpent/Foreman) or for map generation see [World-map-generator](https://github.com/starandserpent/World-map-generator)

## Documentation
You can find documetation on [github wiki](https://github.com/starandserpent/Weltschmerz/wiki)

## Licence
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## Contact us
* Discord: https://discord.starandserpent.com/

### Follow us
* Website: https://www.ritualsoftheold.com/
* IndieDB: https://www.indiedb.com/games/rituals-of-the-old
* Subscribe: https://www.youtube.com/c/Ritualsoftheold

This library is also used in [Rituals  of the old](https://www.ritualsoftheold.com/).