using System;

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string forecast)
        : base(title, description, dateTime, address)
    {
        _weatherForecast = forecast;
    }

    public override string GenerateFullDetails()
    {
        return $"{base.GenerateFullDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}
