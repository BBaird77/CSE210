using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");
        Event myEvent = new Event("Community Meetup", "A gathering of local residents.", "2025-04-10", "6:00 PM", address);
        
        string details = myEvent.GetStandardDetails();
        Console.WriteLine(details);
    }

}