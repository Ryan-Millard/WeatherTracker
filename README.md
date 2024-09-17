# WeatherTracker

## Overview
This application interacts with an external weather station class library to display weather information for various cities. It supports listing cities, filtering by province, displaying detailed weather records, and using reflection to inspect the `WeatherData` class.

## Features
- List all cities with their provinces.
- Display cities within a selected province.
- Display weather information (Temperature, Precipitation, Humidity, Wind) for a specific city.
- Display weather for all cities within a specific province.
- Use reflection to list all properties and methods in the `WeatherData` class.

## Requirements
- .NET Core or .NET Framework
- The provided `.dll` file containing the weather class library.

## Installation
1. Clone or download this repository.
2. Open the project in Visual Studio.
3. Add the provided `.dll` file as a reference.
4. Build and run the application.

## Usage
1. The app will list all cities upon startup.
2. You can then:
   - Enter a city name to see its weather.
   - Enter a province name to filter cities.
   - Use reflection to inspect the `WeatherData` class.

## License
This project is for educational purposes as part of PROG6212.
