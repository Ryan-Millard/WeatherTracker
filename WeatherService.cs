using System;
using System.Collections.Generic;
using WeatherApi;
using WeatherTracker.Utilities;

namespace WeatherTracker.Services
{
	public class WeatherService
	{
		private readonly WeatherData _weatherData;

		public WeatherService()
		{
			_weatherData = new WeatherData();
		}

		public void DisplayWeatherForCitiesInProvince(string provinceName)
		{
			var citiesInProvince = _weatherData.GetCities(provinceName);

			foreach(var city in citiesInProvince)
				DisplayWeatherForCity(city.Name);
		}

		public void DisplayWeatherForCity(string cityName)
		{
			var weatherRecord = _weatherData.GetWeatherRecordForCity(cityName);

			if(weatherRecord == null)
			{
				Console.WriteLine($"No weather data available for {cityName}.");
				return;
			}

			ConsoleUtils.MultiWriteLine(new []{
				$"\nWeather information for {weatherRecord.Name}:",
				$"\tTemperature: {weatherRecord.Weather.Temperature}°C",
				$"\tPrecipitation: {weatherRecord.Weather.Precipitation}",
				$"\tHumidity: {weatherRecord.Weather.Humidity}",
				$"\tWind: {weatherRecord.Weather.Wind}"
			});
		}
	}
}
