using System;
using System.Collections.Generic;

public class Eventmaker {
    public static List<Event> CreateEvents()
    {
            Lecture lecture = new Lecture(
            "Tech Talk",
            "Learn about AI in 2025",
            "2025-04-15",
            "2:00 PM",
            new Address("123 Main St", "Springfield", "IL", "USA"),
            "Dr. Jane Smith",
            100
        );

        Reception reception = new Reception(
            "Networking Night",
            "Meet professionals and students.",
            "2025-04-20",
            "7:00 PM",
            new Address("500 Grand Ave", "New York", "NY", "USA"),
            "rsvp@example.com"
        );

        Outdoor outdoor = new Outdoor(
            "Park Picnic",
            "Enjoy food and games outdoors.",
            "2025-04-25",
            "12:00 PM",
            new Address("Sunset Park", "Austin", "TX", "USA"),
            "Sunny with light breeze"
        );

        return new List<Event> { lecture, reception, outdoor };
    }
}