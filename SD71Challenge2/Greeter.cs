using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD71Challenge2
{
    class Greeter
    {
        public void Greet(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }
        public void Farwell(string name)
        {
            Console.WriteLine("See ya later {0}!", name);
        }
        public void TimeOfDay(int time)
        {

            if (time < 11)
            {
                Console.WriteLine("Morning");
            }
            else if (time >= 11 && time < 15)
            {
                Console.WriteLine("Afternoon");
            }
            else if (time >= 15 && time <= 20)
            {
                Console.WriteLine("Evening");
            }
            else if (time > 20 && time <= 24)
            {
                Console.WriteLine("Night");
            }
            else
            {
                Console.WriteLine("Please enter a valid 24 hour time by just using hours, do not include minutes.");
            }
        }
    }
}
