using System;

namespace ChristmasWithTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Friday;

            Console.WriteLine("What holiday is it?:");

            var holiday = Console.ReadLine();

            happyHoliday(holiday);

            //set Santa's name to Kris Kringle
            xmas.Santa = "Kris Kringle";

            //Inserted 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{"A Watch", "A Bike", "Video Games" }; 

            //Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            
            Console.WriteLine($"This year Christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa: {xmas.Santa}");
        }

        private static void happyHoliday(string selection)
        {
            string[] holidayList = new string[] { "Christmas", "Easter", "Thanksgiving", "Hanukkah", "Valentines Day", "Fourth of July", "Halloween" };

            foreach (var v in holidayList )
            {
                if (selection == v) {
                    Console.WriteLine($"Happy {selection}");
                    return;
                }
            }
            Console.WriteLine("That is not a Holiday.");
        }

    }
}
