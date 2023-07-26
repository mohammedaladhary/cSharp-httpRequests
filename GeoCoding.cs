using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace httpRequest
{
    internal class GeoCoding
    {
        public class WeatherData
        {
            public Coord Coord { get; set; }
            public List<WeatherInfo> Weather { get; set; }
            public BaseInfo Base { get; set; }
            public MainWeatherData Main { get; set; }
            public int Visibility { get; set; }
            public WindInfo Wind { get; set; }
            public CloudsInfo Clouds { get; set; }
            public long Dt { get; set; }
            public SysInfo Sys { get; set; }
            public int Timezone { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cod { get; set; }

            public WeatherData() { }

            public WeatherData(Coord coord, List<WeatherInfo> weather, BaseInfo baseInfo, MainWeatherData main, int visibility, WindInfo wind, CloudsInfo clouds, long dt, SysInfo sys, int timezone, int id, string name, int cod)
            {
                this.Coord = coord;
                this.Weather = weather;
                this.Base = baseInfo;
                this.Main = main;
                this.Visibility = visibility;
                this.Wind = wind;
                this.Clouds = clouds;
                this.Dt = dt;
                this.Sys = sys;
                this.Timezone = timezone;
                this.Id = id;
                this.Name = name;
                this.Cod = cod;
            }
        }
        public class Coord
        {
            public double Lon { get; set; }
            public double Lat { get; set; }

            public Coord() { }

            public Coord(double lon, double lat)
            {
                this.Lon = lon;
                this.Lat = lat;
            }
        }

        public class WeatherInfo
        {
            public int Id { get; set; }
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }

            public WeatherInfo() { }

            public WeatherInfo(int id, string main, string description, string icon)
            {
                this.Id = id;
                this.Main = main;
                this.Description = description;
                this.Icon = icon;
            }
        }

        public class MainWeatherData
        {
            public double Temp { get; set; }
            public double FeelsLike { get; set; }
            public double TempMin { get; set; }
            public double TempMax { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }

            public MainWeatherData() { }

            public MainWeatherData(double temp, double feelsLike, double tempMin, double tempMax, int pressure, int humidity)
            {
                this.Temp = temp;
                this.FeelsLike = feelsLike;
                this.TempMin = tempMin;
                this.TempMax = tempMax;
                this.Pressure = pressure;
                this.Humidity = humidity;
            }
        }

        public class WindInfo
        {
            public double Speed { get; set; }
            public int Deg { get; set; }

            public WindInfo() { }

            public WindInfo(double speed, int deg)
            {
                this.Speed = speed;
                this.Deg = deg;
            }
        }

        public class CloudsInfo
        {
            public int All { get; set; }

            public CloudsInfo() { }

            public CloudsInfo(int all)
            {
                this.All = all;
            }
        }
        public class BaseInfo
        {
            public int Bs { get; set; }

            public BaseInfo() { }

            public BaseInfo(int bs)
            {
                this.Bs = bs;
            }
        }

        public class SysInfo
        {
            public int Type { get; set; }
            public int Id { get; set; }
            public string Country { get; set; }
            public long Sunrise { get; set; }
            public long Sunset { get; set; }

            public SysInfo() { }

            public SysInfo(int type, int id, string country, long sunrise, long sunset)
            {
                this.Type = type;
                this.Id = id;
                this.Country = country;
                this.Sunrise = sunrise;
                this.Sunset = sunset;
            }
        }
    }
}
