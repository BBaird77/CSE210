using System;
using System.Collections.Generic;

class Program {
    static void Main() {
          Address address = new Address("123 Main St", "Springfield", "IL", "USA");

        Event myEvent = new Event("Community Meetup", "A gathering of local residents.", "2025-04-10", "6:00 PM", address);
        Console.WriteLine("Standard Event Details:");
        Console.WriteLine(myEvent.GetFullDetails());
        Console.WriteLine();

        Lecture lecture = new Lecture("Tech Talk", "Learn about AI in 2025", "2025-04-15", "2:00 PM", address, "Dr. Jane Smith", 100);
        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetFullDetails());
    }

}