using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD71Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            greeter.Greet("Nikki");
            greeter.Farwell("Nikki");
            greeter.TimeOfDay(10);
            Console.ReadKey();
        }
    }
}
