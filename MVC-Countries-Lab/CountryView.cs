using System;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country Country)
        {
            DisplayCountry = Country;
        }

        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name);
            Console.WriteLine(DisplayCountry.Continent);

            foreach (string color in DisplayCountry.Colors)
            {

                switch (color)
                {
                    case "White":
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case "Blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case "Red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case "Green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    default:
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(Helper.AddSpacesToString(color,20));
                Console.ResetColor();
            }
        }
    }
}
