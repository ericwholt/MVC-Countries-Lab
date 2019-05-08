using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        List<Country> CountryDb { get; set; }
        public CountryController()
        {
            CountryDb = new List<Country>();
            CountryBuilder cb = new CountryBuilder();
            Country USA = cb.BuildCountry("United States of America", "North America", "Red", "White", "Blue");
            Country Canada = cb.BuildCountry("Canada", "North America", "Red", "White");
            Country Mexico = cb.BuildCountry("Mexico", "South America", "Green", "White", "Red");
            CountryDb.Add(USA);
            CountryDb.Add(Canada);
            CountryDb.Add(Mexico);
        }
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            bool run = true;
            Console.WriteLine("Hello, welcome to the country app.");
            while (run)
            {
                Console.WriteLine("Please select a country from the following list:");
                clv.Display();
                int userInput = Helper.GetIntFromUser("Choose a country to get more information: ");
                if (!(userInput < 0) && userInput < CountryDb.Count)
                {
                    CountryAction(CountryDb[userInput]);
                }
                run = Helper.GetYesOrNoFromUser("Would you like to learn about another Country?");                
            }
        }
    }
}
