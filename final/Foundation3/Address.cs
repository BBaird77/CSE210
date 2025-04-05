using System;
using System.Collections.Generic;

public class Address {
    private string Street;
    private string City;
    private string State;
    private string Country;

    public Address(string street, string city, string state, string country) {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }
}