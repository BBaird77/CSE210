using System;
using System.Collections.Generic;

public class Event {
    private string Title;
    private string Description;
    private string Date;
    private string Time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address) {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        _address = address;
    }

    public string GetStandardDetails() {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {_address.GetFullAddress()}";
    }

     public virtual string GetFullDetails() {
        return GetStandardDetails();
    }

     public virtual string GetShortDescription() {
        return $"Event Type: General\nTitle: {Title}\nDate: {Date}";
    }

    public string GetTitle() => Title;
    public string GetDate() => Date;
}