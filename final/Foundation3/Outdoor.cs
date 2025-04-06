using System;
using System.Collections.Generic;

public class Outdoor: Event {
    private string WeatherForecast;

    public Outdoor(string title, string description, string date, string time, Address address, string weatherforecast)
    : base(title, description, date, time, address) {
        WeatherForecast = weatherforecast;
    }

    public override string GetFullDetails() {
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
} 