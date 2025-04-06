using System;
using System.Collections.Generic;

public class Reception: Event {
    private string RsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {GetTitle()}\nDate: {GetDate()}";
    }
}