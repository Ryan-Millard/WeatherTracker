using System;
using WeatherApi;
using WeatherTracker.Services;
using WeatherTracker.Utilities;

namespace WeatherTracker
{
	class Program
	{
		private static readonly WeatherData _weatherData = new WeatherData();
		private static readonly WeatherService _weatherService = new WeatherService();
		private static readonly CityService _cityService = new CityService(_weatherData);

		static void Main(string[] args)
		{
			Console.WriteLine("WeatherTracker Application");

			while(true)
			{
				DisplayMenu();
				var choice = Console.ReadLine();

				// Handle menu options using a switch expression
				HandleMenuChoice(choice);
			}
		}

		private static void DisplayMenu()
		{
			ConsoleUtils.MultiWriteLine(new []{
				"\nChoose an option:",
				"\t1. List all cities",
				"\t2. List cities in a province",
				"\t3. Display weather information for a city",
				"\t4. Display weather information for cities in a province",
				"\t5. Show properties and methods of WeatherData",
				"\t6. Exit"
			});
		}

		private static void HandleMenuChoice(string choice)
		{
			// Remove spaces at beginninng and end of choice
			choice = choice?.Trim();

			switch (choice)
			{
				// List all cities
				case "1":
					_cityService.ListAllCities();
					break;

				// List cities in a province
				// case "2":
				//     _cityService.ListCitiesByProvince();
				//     break;

				// Display weather information for a city
				case "3":
					var cityName = ConsoleUtils.GetUserInput("\nEnter the name of the city to get weather information:");
					cityName?.Trim();
					_weatherService.DisplayWeatherForCity(cityName);
					break;

				// Display weather information for cities in a province
				// case "4":
				//     _weatherService.DisplayWeatherForCitiesInProvince();
				//     break;

				// Show properties and methods of WeatherData
				case "5":
				     _weatherService.DisplayWeatherDataReflection();
				     break;

				case "6":
					Console.WriteLine("\nExiting...");
					Environment.Exit(0);
					break;

				default:
					Console.WriteLine("Invalid choice, please try again.");
					break;
			}
		}
	}
}
