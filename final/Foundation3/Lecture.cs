using System;
using System.Collections.Generic;

public class Lecture: Event {
    private string Speaker;
    private int Capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
    : base(title, description, date, time, address) {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails() {
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
} 