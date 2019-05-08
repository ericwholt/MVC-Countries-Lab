using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();
            cc.WelcomeAction();
        }
    }
}
