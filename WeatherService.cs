using System;
using System.Reflection;
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

		public void DisplayWeatherForCity(string cityName)
		{
			var weatherRecord = _weatherData.GetWeatherRecordForCity(cityName);

			if (weatherRecord == null)
			{
				Console.WriteLine($"No weather data available for {cityName}.");
				return;
			}

			ConsoleUtils.MultiWriteLine(new[]{
				$"\nWeather information for {weatherRecord.Name}:",
				$"\tTemperature: {weatherRecord.Weather.Temperature}°C",
				$"\tPrecipitation: {weatherRecord.Weather.Precipitation}",
				$"\tHumidity: {weatherRecord.Weather.Humidity}",
				$"\tWind: {weatherRecord.Weather.Wind}"
			});
		}

        // Method to use reflection to display properties and methods of the WeatherData class
        public void DisplayWeatherDataReflection()
        {
            Type weatherDataType = _weatherData.GetType();

            // Class name
            Console.WriteLine($"\nClass: {weatherDataType.Name}");

            // Properties
            Console.WriteLine("\nProperties:");
            PropertyInfo[] properties = weatherDataType.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine($"\t{prop.Name} ({prop.PropertyType})");
            }

            // Display methods
            Console.WriteLine("\nMethods:");
            MethodInfo[] methods = weatherDataType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var method in methods)
            {
                Console.WriteLine($"\t{method.Name}");
            }
        }
}
