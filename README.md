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

## Contributions
Follow these steps to contribute:
1. **Clone the repository:** On your local machine, clone the repository.
   ```bash
   git clone https://github.com/your-username/WeatherTracker.git
   ```
2. **Create a new branch:** Always create a new branch for your changes. Use a meaningful name for your branch, such as fix-bug, add-feature, or update-documentation.
   ```bash
   git clone https://github.com/your-username/WeatherTracker.git
   git checkout -b <feature-name>
   ```
   
3. **Make your changes:** Edit the code, add your features, or fix bugs in the new branch.

4. **Commit your changes:** Once you're happy with your changes, commit them.
   ```bash
   git add .
   git commit -m "<feature-name>: <Description of the changes made>"
   ```
   Follow the convention of <branch-name>:<description> to simplify tracking and make it easier to understand the purpose of the commit.

5. **Push your changes:** Push the changes to the repository.
	- If the GitHub repository doesn't have your branch:
		```bash
      git push origin -u <feature-name>
		```
	- If it does already have your branch:
		```bash
      git push origin -u <feature-name>
		```
  
6. **Submit a pull request (PR):** Go to the GitHub repository and create a pull request (PR) from your branch. Make sure to add a descriptive title and provide a summary of your changes in the PR description.

Once you've submitted the PR, someone will review it and provide feedback or approve it for merging. Thank you for contributing!


## Usage
1. The app will list all cities upon startup.
2. You can then:
   - Enter a city name to see its weather.
   - Enter a province name to filter cities.
   - Use reflection to inspect the `WeatherData` class.

## License
This project is for educational purposes as part of PROG6212. There is no specific license.

