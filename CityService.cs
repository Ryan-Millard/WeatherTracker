using System;
using System.Linq;
using WeatherApi;
using WeatherTracker.Utilities;
using WeatherTracker.Services;

namespace WeatherTracker.Services
{
	public class CityService
	{
		private readonly WeatherData _weatherData;

		public CityService(WeatherData weatherData)
		{
			_weatherData = weatherData;
		}

		public void ListAllCities()
		{
			var cities = _weatherData.GetCities();

			// Group cities by Province
			var groupedByProvince = cities
				.GroupBy(city => city.Province)
				.OrderBy(group => group.Key); // Order by province name

			foreach(var provinceGroup in groupedByProvince)
			{
				// Display province name
				Console.WriteLine(provinceGroup.Key);

				// Display cities under the province
				foreach(var city in provinceGroup)
				{
					Console.WriteLine($"\t{city.Name}");
				}
			}
		}
	}
}
