using System;
using System.Collections.Generic;

class Program {
    static void Main() {
         List<Event> events = Eventmaker.CreateEvents();

        foreach (var ev in events)
        {
            if (ev is Lecture)
            {
                Console.WriteLine("Lecture Details:");
                Console.WriteLine(ev.GetFullDetails());
            }
            else if (ev is Reception)
            {
                Console.WriteLine("Reception Details:");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine("Short Description:");
                Console.WriteLine(ev.GetShortDescription());
            }
            else if (ev is Outdoor)
            {
                Console.WriteLine("Outdoor Event Details:");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine("Short Description:");
                Console.WriteLine(ev.GetShortDescription());
            }

            Console.WriteLine();
        }
    }
}