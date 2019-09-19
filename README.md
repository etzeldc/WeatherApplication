# WeatherApplication
A demo weather api project incorporating Google and Dark Sky's APIs (you must provide your own API keys)

When applying your own API keys:
--Enter in your Google API key on line 164 of the Views/Index.cshtml between after "&key=" and before the semi-colon, but be sure that there is a closing quotation mark at the end of the string.
--Enter your Dark Sky API key on line 49 of Controllers/HomeController.cs after "var apiKey = " and before the semi-colon. (This will replace "WebConfigurationManager.AppSettings["dsKey"]" portion of that line.)
