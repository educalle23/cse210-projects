using System;

namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        private string _weatherForecast;

        public OutdoorGathering(string title, string description, DateTime date, string time, string address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        // Getter and Setter for WeatherForecast
        public string GetWeatherForecast()
        {
            return _weatherForecast;
        }

        public void SetWeatherForecast(string weatherForecast)
        {
            _weatherForecast = weatherForecast;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {GetWeatherForecast()}";
        }
    }
}

