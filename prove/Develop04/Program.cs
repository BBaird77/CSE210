using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Exit Program");
            Console.Write("Make your selection: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                /*"1" => new Breathing(),
                "2" => new Listing(),*/
                "3" => new Reflection(),
                "4" => null
            };

            if (activity == null) break;
            activity.Start();
        }


    }
}