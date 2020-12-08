using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD71Challenge4
{
    class Week4
    {
        static void Main(string[] args)
        {
            var bentley = new Sedan(15,"Bentley", "Flying Spur", 2020, "1GTY1235grt125sa12", "blue");
            bentley.ToString();
            Console.WriteLine(bentley.Make);
            bentley.TankDistance();
            Console.ReadKey();

            var ford = new Truck(18,"Ford","F150 Super Cab", 2020, "222KLI1245kfnm789","black");
            ford.ToString();
            Console.WriteLine(ford.Make);
            ford.TankDistance();
            Console.ReadKey();

            List<Car> newCars = new List<Car>();
            newCars.Add(bentley);
            newCars.Add(ford);
        }
    }
}
