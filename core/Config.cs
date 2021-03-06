
/// <summary>
/// Configuration class containing all neccesary variables for generation
/// This class does not follow usual C# syntax because this class is parsed into JSON so it can be loaded by HOCON
/// Variables are parsed from Hocon (<see cref="ConfigManager"/>)
/// </summary>
public class Config {

    /// <summary>
    /// Variable for accesing <see cref="Config.Map"/> class
    /// </summary>
    public Map map { get; }

    /// <summary>
    /// Variable for accesing <see cref="Config.Noise"/> class
    /// </summary>
    public Elevation elevation { get; }

    /// <summary>
    /// Variable for accesing <see cref="Config.Temperature"/> class
    /// </summary>
    public Temperature temperature { get; }

    /// <summary>
    /// Variable for accesing <see cref="Config.Precipitation"/> class
    /// </summary>
    public Precipitation precipitation { get; }

    /// <summary>
    /// Variable for accesing <see cref="Config.Humidity"/> class
    /// </summary>
    public Humidity humidity { get; }

    /// <summary>
    /// Variable for accesing <see cref="Config.Circulation"/> class
    /// </summary>
    public Circulation circulation { get; }

    /// <summary>
    /// Initializes all config classes
    /// </summary>
    public Config () {
        map = new Map ();
        elevation = new Elevation ();
        temperature = new Temperature ();
        precipitation = new Precipitation ();
        humidity = new Humidity ();
        circulation = new Circulation ();
    }

    /// <summary>
    /// Config class containing basic variables needed for generating map
    /// Map variables are used only for generating random worlds
    /// </summary>
    public class Map {
        /// <summary>
        /// Any number which changes shape of the world
        /// </summary>
        public int seed { get; set; }

        /// <summary>
        /// Size of the world from south to north
        /// Unit is one voxel or pixel (depends on usage)
        /// Distance between voxels or pixels is detemined by engine
        /// </summary>
        public int latitude { get; set; }

        /// <summary>
        /// Size of the world from east to west
        /// Unit is one voxel or pixel (depends on usage)
        /// Distance between voxels or pixels is detemined by engine
        /// </summary>
        public int longitude { get; set; }
    }

    /// <summary>
    /// Config class containing noise variables needed for generating noise
    /// </summary>
    public class Elevation {
        /// <summary>
        /// Max elevation which can terrain achieve
        /// </summary>
        public int max_elevation { get; set; }

        /// <summary>
        /// Deepest level of an ocean
        /// </summary>
        public int min_elevation { get; set; }

        /// <summary>
        /// Below this level will be generated water
        /// </summary>
        public int water_level { get; set; }

        /// <summary>
        /// Frequency of noise
        /// </summary>
        public double frequency { get; set; }

        /// <summary>
        /// Noise octaves
        /// </summary>
        public int octaves { get; set; }
    }

    /// <summary>
    /// Config class containing temperature variables needed for generating temperature
    /// </summary>
    public class Temperature {
        /// <summary>
        /// Highest temperature located around the equator
        /// </summary>
        public int max_temperature { get; set; }

        /// <summary>
        /// Lowest temperature located around the poles
        /// </summary>
        public int min_temperature { get; set; }
    }

    /// <summary>
    /// Config class containing precipitation variables needed for generating precipitation
    /// </summary>
    public class Precipitation {
        /// <summary>
        /// Effect of circulation on precipitation
        /// (Should be smaller then 1)
        /// </summary>
        public double circulation_intensity { get; set; }

        /// <summary>
        /// Precipitation intensity in the world
        /// The lower the more deserts
        /// The higher the more jungles
        /// </summary>
        public double precipitation_intensity { get; set; }

        /// <summary>
        /// Default maximum precipitation
        /// Determines range of precipitation from 0 to chosen value
        /// Unit is mm
        /// </summary>
        public int max_precipitation { get; set; }
    }

    /// <summary>
    /// Config class containing humidity variables needed for generating humidity
    /// </summary>
    public class Humidity {
        /// <summary>
        /// Tranpiration determines humidity around landmasses
        /// </summary>
        public double transpiration { get; set; }

        /// <summary>
        /// Evaporation determines humidity around oceans
        /// </summary>
        public double evaporation { get; set; }
    }

    /// <summary>
    /// Config class containing circulation variables needed for generating circulation
    /// </summary>
    public class Circulation {

        /// <summary>
        /// Amout of units(pixels) on map which will wind travel
        /// The higher map the more units have to wind travel
        /// High range has negative effect on performance
        /// </summary>
        public int wind_range { get; set; }

        /// <summary>
        /// Scale of transfered humidity by wind
        /// The higher intensity the more humidity will be transfered
        /// </summary>
        public double wind_intensity { get; set; }

        /// <summary>
        /// Default pressure reference 
        /// Value used mostly in engine
        /// Unit is Pa
        /// </summary>
        public int pressure_at_sea_level { get; set; }
    }
}