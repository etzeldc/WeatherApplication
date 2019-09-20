# WeatherApplication
A demo weather api project incorporating Google and Dark Sky's APIs (you must provide your own API keys)

When applying your own API keys:

--Enter in your Google API key on line 170 of the Views/Index.cshtml between after "var googleKey = " and before the semi-colon. (This will replace the "@System.Configuration.ConfigurationManager.AppSettings["googleKey"]" portion of that line.)

--Enter your Dark Sky API key on line 49 of Controllers/HomeController.cs after "var apiKey = " and before the semi-colon. (This will replace the "WebConfigurationManager.AppSettings["dsKey"]" portion of that line.)
