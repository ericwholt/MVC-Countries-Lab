using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class CountryBuilder
    {
        public Country BuildCountry(string name, string continent, string colorOne, string colorTwo)
        {
            Country c = new Country();
            c.Name = name;
            c.Continent = continent;
            c.Colors.Add(colorOne);
            c.Colors.Add(colorTwo);
            return c;
        }

        public Country BuildCountry(string name, string continent, string colorOne, string colorTwo, string colorThree)
        {
            Country c = new Country();
            c.Name = name;
            c.Continent = continent;
            c.Colors.Add(colorOne);
            c.Colors.Add(colorTwo);
            c.Colors.Add(colorThree);
            return c;
        }
    }
}
