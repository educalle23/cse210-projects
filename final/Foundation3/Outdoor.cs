using System;

namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        public string WeatherForecast { get; set; }

        public OutdoorGathering(string title, string description, DateTime date, string time, string address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            WeatherForecast = weatherForecast;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
        }
    }
}
